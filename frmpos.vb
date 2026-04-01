Imports System.Data
Imports System.Drawing

Public Class pos
    Private db As New DatabaseHelper()
    Private Cart As New List(Of CartItem)
    ' Temporary stock tracker to prevent over-adding to cart before checkout
    Private TempStock As New Dictionary(Of String, Integer)

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize UI
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.AutoScroll = True

        ' Load Data
        RefreshProductDisplay()
        LoadCartCards()
    End Sub

    ''' <summary>
    ''' Fetches products from DB and renders them as clickable cards.
    ''' </summary>
    Private Sub RefreshProductDisplay()
        flpProduct1.Controls.Clear()
        Dim dt As DataTable = db.LoadProducts()

        For Each row As DataRow In dt.Rows
            Dim productCode As String = row("ProductCode").ToString()

            ' Initialize temp stock tracker if this is the first load
            If Not TempStock.ContainsKey(productCode) Then
                TempStock(productCode) = Convert.ToInt32(row("Stock"))
            End If

            Dim currentStock As Integer = TempStock(productCode)

            ' Create the Card UI
            Dim card As New RoundedShadowPanel With {
                .Width = 200,
                .Height = 180,
                .Margin = New Padding(10),
                .BackColor = Color.White,
                .BorderColor = Color.LightGray,
                .CornerRadius = 15,
                .ShadowSize = 5
            }

            Dim lblName As New Label With {
                .Text = row("ProductName").ToString(),
                .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                .Location = New Point(10, 10),
                .AutoSize = True
            }

            Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(row("Price")).ToString("N2"),
                .Location = New Point(10, 40),
                .AutoSize = True
            }

            ' Stock Status Logic
            Dim stockText As String = ""
            Dim stockColor As Color = Color.Black

            If currentStock <= 0 Then
                stockText = "❌ Out of Stock"
                stockColor = Color.Red
            ElseIf currentStock <= 5 Then
                stockText = "⚠️ Low Stock (" & currentStock & ")"
                stockColor = Color.Orange
            Else
                stockText = "✅ In Stock (" & currentStock & ")"
                stockColor = Color.ForestGreen
            End If

            Dim lblStock As New Label With {
                .Text = stockText,
                .ForeColor = stockColor,
                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                .Location = New Point(10, 70),
                .AutoSize = True
            }

            ' Add to Cart Button
            Dim btnAdd As New RoundedButton With {
                .Text = "Add to Cart",
                .Location = New Point(10, 110),
                .Width = 120,
                .Height = 35,
                .Enabled = (currentStock > 0)
            }

            AddHandler btnAdd.Click, Sub() AddToCart(row)

            card.Controls.Add(lblName)
            card.Controls.Add(lblPrice)
            card.Controls.Add(lblStock)
            card.Controls.Add(btnAdd)
            flpProduct1.Controls.Add(card)
        Next
    End Sub

    Private Sub AddToCart(row As DataRow)
        Dim code As String = row("ProductCode").ToString()
        Dim name As String = row("ProductName").ToString()
        Dim price As Decimal = Convert.ToDecimal(row("Price"))

        If TempStock(code) > 0 Then
            TempStock(code) -= 1

            Dim existing = Cart.FirstOrDefault(Function(c) c.ProductCode = code)
            If existing IsNot Nothing Then
                existing.Quantity += 1
            Else
                Cart.Add(New CartItem With {
                    .ProductCode = code,
                    .ProductName = name,
                    .Price = price,
                    .Quantity = 1
                })
            End If

            LoadCartCards()
            RefreshProductDisplay()
        Else
            MessageBox.Show("Item is out of stock!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Renders the shopping cart items and the Checkout Panel.
    ''' </summary>
    Private Sub LoadCartCards()
        flpCart.Controls.Clear()

        ' Individual Item Rows
        For Each item In Cart
            Dim card As New Panel With {
                .Width = 260,
                .Height = 80,
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(5),
                .BackColor = Color.WhiteSmoke
            }

            Dim lblInfo As New Label With {
                .Text = $"{item.ProductName} (x{item.Quantity}){vbCrLf}₱{item.Subtotal:N2}",
                .Location = New Point(5, 10),
                .AutoSize = True,
                .Font = New Font("Segoe UI", 9)
            }

            Dim btnRemove As New Button With {
                .Text = "Remove",
                .Location = New Point(180, 25),
                .Width = 70
            }

            AddHandler btnRemove.Click, Sub()
                                            TempStock(item.ProductCode) += item.Quantity
                                            Cart.Remove(item)
                                            LoadCartCards()
                                            RefreshProductDisplay()
                                        End Sub

            card.Controls.Add(lblInfo)
            card.Controls.Add(btnRemove)
            flpCart.Controls.Add(card)
        Next

        ' Checkout Summary Panel
        If Cart.Count > 0 Then
            AddCheckoutPanel()
        End If
    End Sub

    Private Sub AddCheckoutPanel()
        Dim summaryPanel As New RoundedShadowPanel With {
            .Width = 260,
            .Height = 220,
            .BackColor = Color.White,
            .Margin = New Padding(5)
        }

        ' Simple labels for inputs (assuming you use TextBoxes named for checkout)
        Dim txtName As New TextBox With {.PlaceholderText = "Buyer Name", .Width = 220, .Location = New Point(20, 20)}
        Dim txtContact As New TextBox With {.PlaceholderText = "Contact No", .Width = 220, .Location = New Point(20, 50)}

        Dim totalAmount As Decimal = Cart.Sum(Function(c) c.Subtotal)
        Dim lblTotal As New Label With {
            .Text = "TOTAL: ₱" & totalAmount.ToString("N2"),
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .Location = New Point(20, 90),
            .AutoSize = True
        }

        Dim btnConfirm As New RoundedButton With {
            .Text = "CONFIRM CHECKOUT",
            .BackColor = Color.ForestGreen,
            .Location = New Point(20, 130),
            .Width = 220,
            .Height = 40
        }

        AddHandler btnConfirm.Click, Sub()
                                         If db.SaveSale(txtName.Text, "N/A", txtContact.Text, totalAmount, totalAmount) Then
                                             ' Update Database Stock
                                             For Each item In Cart
                                                 db.UpdateStock(item.ProductCode, item.Quantity)
                                             Next

                                             MessageBox.Show("Transaction Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                             Cart.Clear()
                                             TempStock.Clear()
                                             LoadCartCards()
                                             RefreshProductDisplay()
                                         End If
                                     End Sub

        summaryPanel.Controls.Add(txtName)
        summaryPanel.Controls.Add(txtContact)
        summaryPanel.Controls.Add(lblTotal)
        summaryPanel.Controls.Add(btnConfirm)
        flpCart.Controls.Add(summaryPanel)
    End Sub
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Me.Show()
        Hide()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        frmInventory.Show()
    End Sub
    Private Sub btnOpensalehistory_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Sales_History.Show()
    End Sub
End Class
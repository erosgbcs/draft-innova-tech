Imports System.Data
Imports System.Drawing

Public Class pos
    Private db As New DatabaseHelper()
    Private Cart As New List(Of CartItem)
    Private TempStock As New Dictionary(Of String, Integer)

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.AutoScroll = True

        RefreshProductDisplay()
        LoadCartCards()
    End Sub

    ' --- Hover styling for buttons ---
    Private Sub StyleButton(btn As Button)
        AddHandler btn.MouseEnter, Sub()
                                       btn.BackColor = Color.FromArgb(30, 144, 255)
                                   End Sub
        AddHandler btn.MouseLeave, Sub()
                                       btn.BackColor = Color.FromArgb(0, 120, 215)
                                   End Sub
    End Sub

    ' --- Toast notification ---
    Private Sub ShowToast(message As String, Optional success As Boolean = True)
        Dim toast As New Label With {
            .Text = message,
            .BackColor = If(success, Color.LightGreen, Color.LightCoral),
            .ForeColor = Color.Black,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .AutoSize = False,
            .Width = 250,
            .Height = 40,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        toast.Location = New Point(Me.Width - toast.Width - 40, 20)
        Me.Controls.Add(toast)
        toast.BringToFront()

        Dim t As New Timer With {.Interval = 3000}
        AddHandler t.Tick, Sub()
                               Me.Controls.Remove(toast)
                               t.Stop()
                           End Sub
        t.Start()
    End Sub

    ' --- Product Display (Search Bar Removed) ---
    Private Sub RefreshProductDisplay(Optional filter As String = "")
        flpProduct1.Controls.Clear()

        Dim lblProductHeader As New Label With {
            .Text = "PRODUCT SELECTION",
            .Font = New Font("Segoe UI", 14, FontStyle.Bold),
            .ForeColor = Color.FromArgb(64, 64, 64),
            .Width = flpProduct1.Width - 30,
            .Height = 40,
            .TextAlign = ContentAlignment.MiddleLeft,
            .Margin = New Padding(10, 20, 0, 10) ' Added top margin for spacing
        }
        flpProduct1.Controls.Add(lblProductHeader)

        Dim dt As DataTable = db.LoadProducts()

        For Each row As DataRow In dt.Rows
            If Not String.IsNullOrEmpty(filter) AndAlso
               Not row("ProductName").ToString().ToLower().Contains(filter.ToLower()) Then
                Continue For
            End If

            Dim productCode As String = row("ProductCode").ToString()
            If Not TempStock.ContainsKey(productCode) Then
                TempStock(productCode) = Convert.ToInt32(row("Stock"))
            End If
            Dim currentStock As Integer = TempStock(productCode)

            Dim card As New RoundedShadowPanel With {
                .Width = 200,
                .Height = 210,
                .Margin = New Padding(10),
                .BackColor = Color.White,
                .BorderColor = Color.LightGray,
                .CornerRadius = 15,
                .ShadowSize = 5
            }

            Dim lblName As New Label With {
                .Text = row("ProductName").ToString(),
                .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                .Location = New Point(15, 15),
                .AutoSize = True
            }

            Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(row("Price")).ToString("N2"),
                .Font = New Font("Segoe UI", 10),
                .Location = New Point(15, 40),
                .AutoSize = True
            }

            Dim lblCategory As New Label With {
                .Text = row("Category").ToString(),
                .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                .ForeColor = Color.DimGray,
                .Location = New Point(15, 65),
                .AutoSize = True
            }

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
                .Location = New Point(15, 90),
                .AutoSize = True
            }

            Dim btnAdd As New RoundedButton With {
                .Text = "Add to Cart",
                .Location = New Point(15, 130),
                .Width = 130,
                .Height = 35,
                .BackColor = Color.FromArgb(0, 120, 215),
                .ForeColor = Color.White,
                .Enabled = (currentStock > 0)
            }
            AddHandler btnAdd.Click, Sub() AddToCart(row)
            StyleButton(btnAdd)

            card.Controls.Add(lblName)
            card.Controls.Add(lblPrice)
            card.Controls.Add(lblCategory)
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
            ShowToast("Item is out of stock!", False)
        End If
    End Sub

    Private Sub LoadCartCards()
        flpCart.Controls.Clear()

        Dim lblCartHeader As New Label With {
            .Text = "CART ITEMS",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.Navy,
            .Width = flpCart.Width - 20,
            .Height = 30,
            .TextAlign = ContentAlignment.BottomLeft,
            .Margin = New Padding(5, 5, 5, 10)
        }
        flpCart.Controls.Add(lblCartHeader)

        If Cart.Count = 0 Then
            Dim lblEmpty As New Label With {
                .Text = "No items in cart.",
                .ForeColor = Color.Gray,
                .Width = flpCart.Width - 20,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Margin = New Padding(0, 20, 0, 0)
            }
            flpCart.Controls.Add(lblEmpty)
        End If

        For Each item In Cart
            Dim card As New RoundedShadowPanel With {
                .Width = 260,
                .Height = 90,
                .Margin = New Padding(5),
                .BackColor = Color.White,
                .CornerRadius = 12,
                .ShadowSize = 4
            }

            Dim lblInfo As New Label With {
                .Text = $"{item.ProductName}{vbCrLf}₱{item.Subtotal:N2}",
                .Location = New Point(10, 10),
                .AutoSize = True,
                .Font = New Font("Segoe UI", 9, FontStyle.Bold)
            }

            Dim nudQty As New NumericUpDown With {
                .Value = item.Quantity,
                .Minimum = 1,
                .Maximum = TempStock(item.ProductCode) + item.Quantity,
                .Location = New Point(150, 10),
                .Width = 60
            }
            AddHandler nudQty.ValueChanged, Sub()
                                                Dim diff = nudQty.Value - item.Quantity
                                                TempStock(item.ProductCode) -= diff
                                                item.Quantity = nudQty.Value
                                                LoadCartCards()
                                                RefreshProductDisplay()
                                            End Sub

            Dim btnRemove As New Button With {
                .Text = "Remove",
                .Location = New Point(150, 40),
                .Width = 70
            }
            AddHandler btnRemove.Click, Sub()
                                            TempStock(item.ProductCode) += item.Quantity
                                            Cart.Remove(item)
                                            LoadCartCards()
                                            RefreshProductDisplay()
                                        End Sub

            card.Controls.Add(lblInfo)
            card.Controls.Add(nudQty)
            card.Controls.Add(btnRemove)
            flpCart.Controls.Add(card)
        Next

        If Cart.Count > 0 Then
            AddCheckoutPanel()
        End If
    End Sub

    Private Sub AddCheckoutPanel()
        Dim summaryPanel As New RoundedShadowPanel With {
            .Width = 260,
            .Height = 300,
            .BackColor = Color.White,
            .Margin = New Padding(5, 20, 5, 5),
            .CornerRadius = 12,
            .ShadowSize = 4
        }

        Dim txtName As New TextBox With {.PlaceholderText = "Buyer Name", .Width = 220, .Location = New Point(20, 20)}
        Dim txtContact As New TextBox With {.PlaceholderText = "Contact No", .Width = 220, .Location = New Point(20, 60)}
        Dim txtAddress As New TextBox With {.PlaceholderText = "Address", .Width = 220, .Location = New Point(20, 100)}

        Dim totalAmount As Decimal = Cart.Sum(Function(c) c.Subtotal)
        Dim lblTotal As New Label With {
            .Text = "TOTAL: ₱" & totalAmount.ToString("N2"),
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .Location = New Point(20, 140),
            .AutoSize = True
        }

        Dim btnConfirm As New RoundedButton With {
            .Text = "CONFIRM CHECKOUT",
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .Location = New Point(20, 180),
            .Width = 220,
            .Height = 40
        }
        StyleButton(btnConfirm)

        AddHandler btnConfirm.Click, Sub()
                                         If String.IsNullOrWhiteSpace(txtName.Text) Then
                                             ShowToast("Please enter buyer name.", False)
                                             Return
                                         End If

                                         If db.SaveSale(txtName.Text, txtAddress.Text, txtContact.Text, totalAmount, totalAmount) Then
                                             For Each item In Cart
                                                 db.UpdateStock(item.ProductCode, item.Quantity)
                                             Next

                                             ShowToast("Transaction Successful!")
                                             Cart.Clear()
                                             TempStock.Clear()
                                             LoadCartCards()
                                             RefreshProductDisplay()
                                         End If
                                     End Sub

        summaryPanel.Controls.Add(txtName)
        summaryPanel.Controls.Add(txtContact)
        summaryPanel.Controls.Add(txtAddress)
        summaryPanel.Controls.Add(lblTotal)
        summaryPanel.Controls.Add(btnConfirm)
        flpCart.Controls.Add(summaryPanel)
    End Sub

    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Sales_History.Show()
    End Sub

    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Me.Show()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        frmInventory.Show()
    End Sub
End Class
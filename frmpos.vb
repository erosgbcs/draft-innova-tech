Imports System.Data
Imports System.Drawing

Public Class pos
    Private db As New DatabaseHelper()
    Private Cart As New List(Of CartItem)
    Private TempStock As New Dictionary(Of String, Integer)

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.AutoScroll = True
        SecurityManager.ApplyRestrictions(Me)
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
        flpProduct1.SuspendLayout()

        Try
            Dim dt As DataTable = db.LoadProducts()

            Dim groupedProducts = dt.AsEnumerable().
            GroupBy(Function(r) r("ProductName").ToString())

            For Each productGroup In groupedProducts
                Dim firstVariant = productGroup.First()

                ' FILTER
                If Not String.IsNullOrEmpty(filter) AndAlso
               Not firstVariant("ProductName").ToString().ToLower().Contains(filter.ToLower()) Then
                    Continue For
                End If

                ' ===== CARD =====
                Dim card As New RoundedShadowPanel With {
                .Width = 200,
                .Height = 250,
                .Margin = New Padding(10),
                .BackColor = Color.White,
                .CornerRadius = 15,
                .ShadowSize = 5
            }

                ' NAME
                Dim lblName As New Label With {
                .Text = firstVariant("ProductName").ToString().ToUpper(),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .Location = New Point(15, 15),
                .Width = 170
            }

                ' PRICE
                Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(firstVariant("Price")).ToString("N2"),
                .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                .ForeColor = Color.FromArgb(0, 120, 215),
                .Location = New Point(15, 50),
                .AutoSize = True
            }

                ' STOCK
                Dim lblStock As New Label With {
                .Font = New Font("Segoe UI", 8, FontStyle.Bold),
                .Location = New Point(15, 75),
                .AutoSize = True
            }

                ' 🔥 DYNAMIC SIZE LABEL (ITO YUNG MAGBABAGO)
                Dim lblSize As New Label With {
                .Text = "Size: Small",
                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                .Location = New Point(15, 95),
                .AutoSize = True
            }

                ' VARIANT PANEL
                Dim pnlVariants As New FlowLayoutPanel With {
                .Location = New Point(15, 120),
                .Size = New Size(170, 50)
            }

                ' ADD BUTTON
                Dim btnAdd As New RoundedButton With {
                .Text = "Add to Cart",
                .Location = New Point(15, 180),
                .Width = 170,
                .Height = 35,
                .BackColor = Color.FromArgb(0, 120, 215),
                .ForeColor = Color.White
            }

                card.Tag = firstVariant

                ' ===== VARIANTS =====
                Dim sizeList As New List(Of String)

                Dim variantCount As Integer = 1

                For Each variantRow In productGroup

                    Dim sizeValue As String = variantRow("Size").ToString()
                    sizeList.Add(sizeValue)

                    Dim btnVar As New Button With {
                    .Text = variantCount.ToString(),
                    .Width = 35,
                    .Height = 30,
                    .FlatStyle = FlatStyle.Flat,
                    .BackColor = Color.FromArgb(240, 240, 240),
                    .Tag = variantRow
                }

                    btnVar.FlatAppearance.BorderSize = 1

                    AddHandler btnVar.Click, Sub(s, ev)

                                                 Dim selectedRow = CType(CType(s, Button).Tag, DataRow)
                                                 card.Tag = selectedRow

                                                 ' UPDATE PRICE
                                                 lblPrice.Text = "₱" & Convert.ToDecimal(selectedRow("Price")).ToString("N2")

                                                 ' UPDATE STOCK
                                                 Dim stockVal As Integer = Convert.ToInt32(selectedRow("Stock"))
                                                 If stockVal <= 0 Then
                                                     lblStock.Text = "❌ OUT OF STOCK"
                                                     lblStock.ForeColor = Color.Red
                                                     btnAdd.Enabled = False
                                                 Else
                                                     lblStock.Text = "✅ STOCK: " & stockVal
                                                     lblStock.ForeColor = Color.Green
                                                     btnAdd.Enabled = True
                                                 End If

                                                 ' 🔥 UPDATE SIZE LABEL (ITO ANG MAIN)
                                                 Dim index As Integer = pnlVariants.Controls.IndexOf(CType(s, Button))
                                                 lblSize.Text = "Size: " & sizeList(index)

                                                 ' highlight
                                                 For Each b As Button In pnlVariants.Controls
                                                     b.BackColor = Color.FromArgb(240, 240, 240)
                                                 Next
                                                 CType(s, Button).BackColor = Color.FromArgb(0, 120, 215)

                                             End Sub

                    pnlVariants.Controls.Add(btnVar)

                    If variantCount = 1 Then btnVar.PerformClick()
                    variantCount += 1
                Next

                ' ADD TO CART
                AddHandler btnAdd.Click, Sub()
                                             AddToCart(CType(card.Tag, DataRow))
                                         End Sub
                StyleButton(btnAdd)

                ' ASSEMBLE
                card.Controls.Add(lblName)
                card.Controls.Add(lblPrice)
                card.Controls.Add(lblStock)
                card.Controls.Add(lblSize)
                card.Controls.Add(pnlVariants)
                card.Controls.Add(btnAdd)

                flpProduct1.Controls.Add(card)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            flpProduct1.ResumeLayout()
        End Try
    End Sub

    Private Sub AddToCart(row As DataRow)
        Dim code As String = row("ProductCode").ToString()
        Dim name As String = row("ProductName").ToString()
        Dim price As Decimal = Convert.ToDecimal(row("Price"))

        If TempStock(code) > 0 Then
            TempStock(code) -= 1

            ' Update the Cart List
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

            ' --- OPTIMIZATION START ---
            ' Update only the specific card's UI instead of RefreshProductDisplay()
            For Each ctrl As Control In flpProduct1.Controls
                Dim lblCode = ctrl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "lblProductCode")
                If lblCode IsNot Nothing AndAlso lblCode.Text = code Then
                    UpdateSingleCardUI(ctrl, TempStock(code))
                    Exit For
                End If
            Next
            ' --- OPTIMIZATION END ---

            LoadCartCards() ' Keep this, as the cart is small
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
                    .Location = New Point(180, 60),
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
                    .Location = New Point(100, 60),
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
            .Text = "CHECKOUT",
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .Location = New Point(20, 180),
            .Width = 220,
            .Height = 40
        }
        StyleButton(btnConfirm)

        AddHandler btnConfirm.Click, Sub()
                                         ' 1. Basic Cart Check
                                         If Cart.Count = 0 Then
                                             ShowToast("Cart is empty!", False)
                                             Return
                                         End If

                                         ' 2. VALIDATION: Check if fields are empty
                                         If String.IsNullOrWhiteSpace(txtName.Text) OrElse
                                            String.IsNullOrWhiteSpace(txtContact.Text) OrElse
                                            String.IsNullOrWhiteSpace(txtAddress.Text) Then

                                             MessageBox.Show("Please fill in all buyer information fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                             Return
                                         End If

                                         ' 3. Proceed to Payment
                                         Dim payDialog As New frmPayment()
                                         payDialog.CartItems = Me.Cart

                                         If payDialog.ShowDialog() = DialogResult.OK Then
                                             Dim itemsSummary As String = String.Join(", ", payDialog.CartItems.Select(Function(c) $"{c.ProductName} (x{c.Quantity})"))

                                             ' 4. Save to Database
                                             If db.SaveSale(txtName.Text, txtAddress.Text, txtContact.Text, itemsSummary, payDialog.TotalAmount, payDialog.AmountPaid) Then

                                                 ' --- PRINT RECEIPT TRIGGER ---
                                                 ' We do this BEFORE clearing the cart so the receipt has data to print
                                                 Dim changeAmount As Decimal = payDialog.AmountPaid - payDialog.TotalAmount
                                                 GenerateReceipt(txtName.Text, "Cash", payDialog.AmountPaid, changeAmount)
                                                 ' -----------------------------

                                                 ' 5. Update Stock
                                                 For Each item In payDialog.CartItems
                                                     db.UpdateStock(item.ProductCode, item.Quantity)
                                                 Next

                                                 ShowToast("Sale Successful!")

                                                 ' 6. Reset UI
                                                 Cart.Clear()
                                                 LoadCartCards()
                                                 RefreshProductDisplay()
                                             End If
                                         End If
                                     End Sub

        ' Add controls to the summary panel and add the panel to the cart flow panel
        summaryPanel.Controls.Add(txtName)
        summaryPanel.Controls.Add(txtContact)
        summaryPanel.Controls.Add(txtAddress)
        summaryPanel.Controls.Add(lblTotal)
        summaryPanel.Controls.Add(btnConfirm)

        flpCart.Controls.Add(summaryPanel)
    End Sub

    ' --- Dashboard Button ---
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
        Dim dashForm As New frmdashboard
        dashForm.WindowState = FormWindowState.Maximized
        dashForm.Show
        Hide() ' Hide the POS form when going to dashboard
    End Sub

    ' --- Inventory Button ---
    Private Sub btnOpenInventory_Click_1(sender As Object, e As EventArgs)
        Dim invForm As New frmInventory
        invForm.WindowState = FormWindowState.Maximized
        invForm.Show
        ' If you want to close/hide POS, add Me.Close() or Me.Hide()
    End Sub

    ' --- Sales History Button ---
    Private Sub btnSALESHISTORY_Click_1(sender As Object, e As EventArgs)
        Dim salesForm As New frmSalesHIstory
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show
    End Sub
    ' --- Logout Button ---
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim login As New FrmLogin
            login.Show
            Close
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs)
        User.Show
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub txtsearchproducts_TextChanged(sender As Object, e As EventArgs) Handles txtsearchproducts.TextChanged
        Try
            Dim searchText As String = txtsearchproducts.Text.Trim().ToLower()

            ' Loop through all controls inside the FlowLayoutPanel
            For Each ctrl As Control In flpProduct1.Controls
                ' Assuming each product card is a Panel or UserControl
                ' and has a Label for ProductName and ProductCode
                Dim productNameLabel As Label = ctrl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "lblProductName")
                Dim productCodeLabel As Label = ctrl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "lblProductCode")

                If productNameLabel IsNot Nothing AndAlso productCodeLabel IsNot Nothing Then
                    Dim productName As String = productNameLabel.Text.ToLower()
                    Dim productCode As String = productCodeLabel.Text.ToLower()

                    ' Show or hide card depending on match
                    If productName.Contains(searchText) OrElse productCode.Contains(searchText) Then
                        ctrl.Visible = True
                    Else
                        ctrl.Visible = False
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error while searching products: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GenerateReceipt(buyer As String, method As String, paid As Decimal, change As Decimal)
        ' Create the instance of your new receipt form
        Dim receiptForm As New frmReceipt()

        ' Calculate the total again or pass it from the payment dialog
        Dim totalAmount As Decimal = Cart.Sum(Function(c) c.Subtotal)

        ' Call the display method we created in Step 2
        receiptForm.DisplayReceipt(buyer, Me.Cart, totalAmount, paid, change)

        ' Show it as a pop-up window
        receiptForm.ShowDialog()
    End Sub
    Private Sub UpdateSingleCardUI(card As Control, currentStock As Integer)
        Dim lblStock = card.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Text.Contains("Stock"))
        Dim btnAdd = card.Controls.OfType(Of Button)().FirstOrDefault()

        If lblStock IsNot Nothing Then
            If currentStock <= 0 Then
                lblStock.Text = "❌ Out of Stock"
                lblStock.ForeColor = Color.Red
                If btnAdd IsNot Nothing Then btnAdd.Enabled = False
            ElseIf currentStock <= 5 Then
                lblStock.Text = "⚠️ Low Stock (" & currentStock & ")"
                lblStock.ForeColor = Color.Orange
                If btnAdd IsNot Nothing Then btnAdd.Enabled = True
            Else
                lblStock.Text = "✅ In Stock (" & currentStock & ")"
                lblStock.ForeColor = Color.ForestGreen
                If btnAdd IsNot Nothing Then btnAdd.Enabled = True
            End If
        End If
    End Sub

End Class
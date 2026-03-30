Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frmdashboard
    Private db As New DatabaseHelper()

    ' --- Rounded Button Class ---
    Public Class RoundedButton
        Inherits Button

        Public Property CornerRadius As Integer = 12
        Private normalColor As Color = Color.FromArgb(0, 120, 215)
        Private hoverColor As Color = Color.FromArgb(0, 150, 255)
        Private currentColor As Color = Color.FromArgb(0, 120, 215)

        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

            Using path As Drawing2D.GraphicsPath = GetRoundedRect(rect, CornerRadius)
                Using brush As New SolidBrush(currentColor)
                    pevent.Graphics.FillPath(brush, path)
                End Using
            End Using

            TextRenderer.DrawText(pevent.Graphics, Me.Text, Me.Font, rect, Me.ForeColor,
                                  TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End Sub

        Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
            Dim path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()
            Return path
        End Function

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            currentColor = hoverColor
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            currentColor = normalColor
            Me.Invalidate()
        End Sub
    End Class

    ' --- Rounded Shadow Panel Class ---
    Public Class RoundedShadowPanel
        Inherits Panel
        Public Property CornerRadius As Integer = 20
        Public Property ShadowSize As Integer = 5
        Public Property BorderColor As Color = Color.Gray

        Private normalShadowAlpha As Integer = 50
        Private hoverShadowAlpha As Integer = 120
        Private currentShadowAlpha As Integer = 50
        Private fadeTimer As Timer
        Private targetAlpha As Integer

        Public Sub New()
            Me.DoubleBuffered = True
            fadeTimer = New Timer()
            fadeTimer.Interval = 15
            AddHandler fadeTimer.Tick, AddressOf FadeStep
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim g As Graphics = e.Graphics
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            Dim shadowRect As New Rectangle(ShadowSize, ShadowSize, Me.Width - ShadowSize, Me.Height - ShadowSize)
            Using shadowPath As Drawing2D.GraphicsPath = GetRoundedRect(shadowRect, CornerRadius)
                Using shadowBrush As New SolidBrush(Color.FromArgb(currentShadowAlpha, Color.Black))
                    g.FillPath(shadowBrush, shadowPath)
                End Using
            End Using

            Dim rect As New Rectangle(0, 0, Me.Width - ShadowSize, Me.Height - ShadowSize)
            Using path As Drawing2D.GraphicsPath = GetRoundedRect(rect, CornerRadius)
                Using brush As New SolidBrush(Me.BackColor)
                    g.FillPath(brush, path)
                End Using
                Using pen As New Pen(Me.BorderColor, 1)
                    g.DrawPath(pen, path)
                End Using
            End Using
        End Sub

        Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
            Dim path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()
            Return path
        End Function

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            targetAlpha = hoverShadowAlpha
            fadeTimer.Start()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            targetAlpha = normalShadowAlpha
            fadeTimer.Start()
        End Sub

        Private Sub FadeStep(sender As Object, e As EventArgs)
            If currentShadowAlpha < targetAlpha Then
                currentShadowAlpha += 5
                If currentShadowAlpha >= targetAlpha Then
                    currentShadowAlpha = targetAlpha
                    fadeTimer.Stop()
                End If
            ElseIf currentShadowAlpha > targetAlpha Then
                currentShadowAlpha -= 5
                If currentShadowAlpha <= targetAlpha Then
                    currentShadowAlpha = targetAlpha
                    fadeTimer.Stop()
                End If
            End If
            Me.Invalidate()
        End Sub
    End Class

    ' --- Product and Cart Classes ---
    Public Class Product
        Public Property Code As String
        Public Property Name As String
        Public Property Category As String
        Public Property Price As Decimal
        Public Property Stock As Integer
    End Class

    Public Class CartItem
        Public Property ProductCode As String
        Public Property ProductName As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public ReadOnly Property Subtotal As Decimal
            Get
                Return Price * Quantity
            End Get
        End Property
    End Class

    Private Cart As New List(Of CartItem)

    ' --- Form Load ---
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.InitializeDatabase()
        Timer1.Start()

        ' Load Products and Sales into their respective Grids
        dgvProducts.DataSource = db.LoadProducts()
        dgvSales.DataSource = db.LoadSales() ' <--- Loads History on startup

        ' Optional: Grid Formatting
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        LoadProductCards()
        LoadCartCards()

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.AutoScroll = True
    End Sub

    ' --- Load selected row into textboxes ---
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = dgvProducts.Rows(e.RowIndex)
            txtProductCode.Text = row.Cells("ProductCode").Value.ToString
            txtProductName.Text = row.Cells("ProductName").Value.ToString
            txtCategory.Text = row.Cells("Category").Value.ToString
            txtPrice.Text = row.Cells("Price").Value.ToString
            txtStock.Text = row.Cells("Stock").Value.ToString
        End If
    End Sub

    'time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Example: March 26, 2026 02:17:45 PM
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub


    ' --- Export to CSV Button Click ---
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs)
        Try
            ' 1. Load products from the database into a DataTable
            Dim dt = db.LoadProducts

            ' 2. Ask the user where to save the CSV file
            Using sfd As New SaveFileDialog
                sfd.Filter = "CSV files (*.csv)|*.csv"   ' Only allow CSV files
                sfd.Title = "Export Products to CSV"    ' Dialog title
                sfd.FileName = "Products.csv"           ' Default file name

                ' 3. If the user clicks Save
                If sfd.ShowDialog = DialogResult.OK Then
                    ' 4. Create a StreamWriter to write the CSV file
                    Using sw As New StreamWriter(sfd.FileName, False, Encoding.UTF8)

                        ' 5. Write the header row (column names)
                        Dim headers = String.Join(",", dt.Columns.Cast(Of DataColumn).Select(Function(c) c.ColumnName))
                        sw.WriteLine(headers)

                        ' 6. Write each product row
                        For Each row As DataRow In dt.Rows
                            ' Convert each field to string and join with commas
                            Dim fields = String.Join(",", row.ItemArray.Select(Function(f) f.ToString))
                            sw.WriteLine(fields)
                        Next
                    End Using

                    ' 7. Show success message
                    MessageBox.Show("Products exported successfully to " & sfd.FileName,
                                "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' 8. Handle errors gracefully
            MessageBox.Show("Error exporting products: " & ex.Message,
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' --- Add/Update Product ---
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MessageBox.Show("Please fill in the Product Name and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim prod As New Product With {
                .Code = txtProductCode.Text,
                .Name = txtProductName.Text,
                .Category = txtCategory.Text,
                .Price = Decimal.Parse(txtPrice.Text),
                .Stock = Integer.Parse(txtStock.Text)
            }

            If db.SaveProduct(prod) Then
                dgvProducts.DataSource = db.LoadProducts
                LoadProductCards()
                ClearInputs()
                MessageBox.Show("Product saved/updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearInputs()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    ' Temporary stock tracker
    Private TempStock As New Dictionary(Of String, Integer)

    Private Sub AddToCart(code As String, name As String, price As Decimal)
        ' Initialize temp stock if not tracked yet
        If Not TempStock.ContainsKey(code) Then
            Dim actualStock As Integer = Convert.ToInt32(db.LoadProducts().Select("ProductCode='" & code & "'")(0)("Stock"))
            TempStock(code) = actualStock
        End If

        ' Check if stock is available
        If TempStock(code) > 0 Then
            ' Decrease temporary stock
            TempStock(code) -= 1

            ' Add to cart
            Dim existing = Cart.FirstOrDefault(Function(c) c.ProductCode = code)
            If existing IsNot Nothing Then
                existing.Quantity += 1
            Else
                Cart.Add(New CartItem With {.ProductCode = code, .ProductName = name, .Price = price, .Quantity = 1})
            End If

            ' Refresh UI
            LoadCartCards()
            LoadProductCards()
        Else
            MessageBox.Show("This product is out of stock!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    ' Load cart cards into flpCart
    Private Sub LoadCartCards()
        flpCart.Controls.Clear()

        For Each item In Cart
            Dim card As New Panel With {
                .Width = 250,
                .Height = 100,
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(5)
            }

            Dim lblName As New Label With {
                .Text = item.ProductName,
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .Location = New Point(10, 10),
                .AutoSize = True
            }
            card.Controls.Add(lblName)

            Dim lblQty As New Label With {
                .Text = "Qty: " & item.Quantity,
                .Location = New Point(10, 35),
                .AutoSize = True
            }
            card.Controls.Add(lblQty)

            Dim lblSubtotal1 As New Label With {
                .Text = "Subtotal: ₱" & item.Subtotal.ToString("N2"),
                .Location = New Point(10, 60),
                .AutoSize = True
            }
            card.Controls.Add(lblSubtotal1)

            ' Increase quantity
            Dim btnIncrease As New Button With {
                .Text = "+",
                .Location = New Point(150, 30),
                .Width = 30
            }
            AddHandler btnIncrease.Click,
                Sub(sender, e)
                    If TempStock.ContainsKey(item.ProductCode) AndAlso TempStock(item.ProductCode) > 0 Then
                        item.Quantity += 1
                        TempStock(item.ProductCode) -= 1   ' decrease temp stock
                        LoadCartCards()
                        LoadProductCards()
                    Else
                        MessageBox.Show("No more stock available for " & item.ProductName,
                                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Sub

            card.Controls.Add(btnIncrease)

            ' Decrease quantity
            Dim btnDecrease As New Button With {
                .Text = "-",
                .Location = New Point(190, 30),
                .Width = 30
            }
            AddHandler btnDecrease.Click,
                Sub(sender, e)
                    If item.Quantity > 1 Then
                        item.Quantity -= 1
                        TempStock(item.ProductCode) += 1   ' restore temp stock
                    Else
                        Cart.Remove(item)
                        TempStock(item.ProductCode) += 1   ' restore one unit back
                    End If
                    LoadCartCards()
                    LoadProductCards()
                End Sub

            card.Controls.Add(btnDecrease)

            ' Remove button
            Dim btnRemove As New Button With {
                .Text = "Remove",
                .Location = New Point(150, 60),
                .Width = 70
            }
            AddHandler btnRemove.Click,
                Sub(sender, e)
                    If TempStock.ContainsKey(item.ProductCode) Then
                        TempStock(item.ProductCode) += item.Quantity   ' restore all removed stock
                    End If
                    Cart.Remove(item)
                    LoadCartCards()
                    LoadProductCards()
                End Sub

            card.Controls.Add(btnRemove)

            flpCart.Controls.Add(card)
        Next

        ' --- Totals card at the bottom ---
        Dim totalsCard As New RoundedShadowPanel With {
            .Width = 300,
            .Height = 280,   ' Height maintained for a clean look
            .Margin = New Padding(10),
            .BackColor = Color.White,
            .BorderColor = Color.LightGray,
            .CornerRadius = 20,
            .ShadowSize = 6
        }

        ' --- Buyer Info fields (Aligned and Resized) ---
        Dim labelFont As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim textBoxWidth As Integer = 180

        ' Buyer Name
        Dim lblBuyerName As New Label With {
            .Text = "Buyer Name:",
            .Location = New Point(15, 40),
            .Font = labelFont,
            .AutoSize = True
        }
        Dim txtBuyerName As New TextBox With {
            .Name = "txtBuyerName",
            .Location = New Point(105, 37),
            .Width = textBoxWidth
        }

        ' Address
        Dim lblBuyerAddress As New Label With {
            .Text = "Address:",
            .Location = New Point(15, 90),
            .Font = labelFont,
            .AutoSize = True
        }
        Dim txtBuyerAddress As New TextBox With {
            .Name = "txtBuyerAddress",
            .Location = New Point(105, 87),
            .Width = textBoxWidth
        }

        ' Contact No
        Dim lblBuyerContact As New Label With {
            .Text = "Contact No:",
            .Location = New Point(15, 140),
            .Font = labelFont,
            .AutoSize = True
        }
        Dim txtBuyerContact As New TextBox With {
            .Name = "txtBuyerContact",
            .Location = New Point(105, 137),
            .Width = textBoxWidth
        }

        ' Add Info fields to the card
        totalsCard.Controls.Add(lblBuyerName)
        totalsCard.Controls.Add(txtBuyerName)
        totalsCard.Controls.Add(lblBuyerAddress)
        totalsCard.Controls.Add(txtBuyerAddress)
        totalsCard.Controls.Add(lblBuyerContact)
        totalsCard.Controls.Add(txtBuyerContact)

        ' --- Action Buttons (Positioned at the Bottom) ---

        ' Checkout button
        Dim btnCheckout As New RoundedButton With {
            .Text = "Checkout",
            .Location = New Point(20, 200),   ' Fixed position below the last field
            .Width = 125,
            .Height = 40,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .CornerRadius = 15
        }
        btnCheckout.BackColor = Color.ForestGreen
        AddHandler btnCheckout.Click, AddressOf btnCheckout_Click
        totalsCard.Controls.Add(btnCheckout)

        ' Clear Cart button
        Dim btnClear As New RoundedButton With {
            .Text = "Clear Cart",
            .Location = New Point(155, 200),  ' Aligned with Checkout
            .Width = 125,
            .Height = 40,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .CornerRadius = 15
        }
        btnClear.BackColor = Color.Firebrick
        AddHandler btnClear.Click,
            Sub(sender, e)
                Cart.Clear()
                TempStock.Clear()
                LoadCartCards()
                LoadProductCards()
            End Sub
        totalsCard.Controls.Add(btnClear)

        ' Finally add totalsCard to flow layout
        flpCart.Controls.Add(totalsCard)

    End Sub ' <-- Closes LoadCartCards

    ' Checkout logic
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs)
        If Cart.Count = 0 Then
            MessageBox.Show("Cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal = Cart.Sum(Function(c) c.Subtotal)
        Dim total As Decimal = subtotal

        ' Commit stock changes to database
        For Each item In Cart
            If Not db.UpdateStock(item.ProductCode, item.Quantity) Then
                MessageBox.Show("Failed to update stock for " & item.ProductName,
                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next

        ' --- Capture buyer info from totalsCard ---
        Dim buyerName As String = ""
        Dim buyerAddress As String = ""
        Dim buyerContact As String = ""

        For Each ctrl As Control In flpCart.Controls
            If TypeOf ctrl Is RoundedShadowPanel Then
                If ctrl.Controls.ContainsKey("txtBuyerName") Then
                    buyerName = CType(ctrl.Controls("txtBuyerName"), TextBox).Text
                End If
                If ctrl.Controls.ContainsKey("txtBuyerAddress") Then
                    buyerAddress = CType(ctrl.Controls("txtBuyerAddress"), TextBox).Text
                End If
                If ctrl.Controls.ContainsKey("txtBuyerContact") Then
                    buyerContact = CType(ctrl.Controls("txtBuyerContact"), TextBox).Text
                End If
            End If
        Next

        ' --- Save sale record ---
        If db.SaveSale(buyerName, buyerAddress, buyerContact, subtotal, total) Then
            MessageBox.Show("Checkout successful!" & vbCrLf &
                        "Subtotal: ₱" & subtotal.ToString("N2") & vbCrLf &
                        "Total: ₱" & total.ToString("N2"),
                        "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh sales grid
            dgvSales.DataSource = db.LoadSales()
        Else
            MessageBox.Show("Failed to save sale.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Refresh product list and cards
        dgvProducts.DataSource = db.LoadProducts()
        LoadProductCards()

        ' Clear cart and temporary stock
        Cart.Clear()
        TempStock.Clear()
        LoadCartCards()
    End Sub




    ' Load product cards into flpProduct1
    Private Sub LoadProductCards()
        flpProduct1.Controls.Clear()
        Dim dt As DataTable = db.LoadProducts()

        For Each row As DataRow In dt.Rows
            Dim card As New RoundedShadowPanel With {
    .Width = 200,
    .Height = 180,
    .Margin = New Padding(10),
    .BackColor = Color.White,
    .BorderColor = Color.LightGray,
    .CornerRadius = 30,   ' more rounded corners
    .ShadowSize = 8      ' bigger shadow spread
}


            Dim lblName As New Label With {
    .Text = row("ProductName").ToString(),
    .Font = New Font("Segoe UI", 11, FontStyle.Bold),
    .ForeColor = Color.FromArgb(30, 30, 30), ' dark gray
    .Location = New Point(10, 10),
    .AutoSize = True
}

            card.Controls.Add(lblName)

            Dim lblproductcode As New Label With {
                .Text = "Product Code: " & row("ProductCode").ToString(),
                .Location = New Point(10, 35),
                .AutoSize = True
            }
            card.Controls.Add(lblproductcode)

            Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(row("Price")).ToString("N2"),
                .Location = New Point(10, 60),
                .AutoSize = True
            }
            card.Controls.Add(lblPrice)

            Dim productCode As String = row("ProductCode").ToString()

            ' Use TempStock if available, otherwise use DB stock
            Dim stockValue As Integer = If(TempStock.ContainsKey(productCode),
                               TempStock(productCode),
                               Convert.ToInt32(row("Stock")))

            Dim stockText As String
            Dim stockColor As Color

            If stockValue = 0 Then
                stockText = "❌ Out of Stock"
                stockColor = Color.Red
            ElseIf stockValue <= 5 Then
                stockText = "⚠️ Low Stock (" & stockValue & ")"
                stockColor = Color.Orange
            Else
                stockText = "✅ In Stock (" & stockValue & ")"
                stockColor = Color.ForestGreen
            End If

            Dim lblStock As New Label With {
    .Text = stockText,
    .Font = New Font("Segoe UI", 9, FontStyle.Bold),
    .ForeColor = stockColor,
    .Location = New Point(10, 85),
    .AutoSize = True
}
            card.Controls.Add(lblStock)




            card.Controls.Add(lblStock)

            Dim btnAdd As New RoundedButton With {
    .Text = "Add to Cart",
    .Location = New Point(10, 110),
    .Width = 120,
    .Height = 35,
    .ForeColor = Color.White,
    .Font = New Font("Segoe UI", 9, FontStyle.Bold),
    .CornerRadius = 15
}
            btnAdd.FlatAppearance.BorderSize = 0
            AddHandler btnAdd.MouseEnter, Sub()
                                              btnAdd.BackColor = Color.FromArgb(0, 150, 255) ' lighter blue on hover
                                          End Sub
            AddHandler btnAdd.MouseLeave, Sub()
                                              btnAdd.BackColor = Color.FromArgb(0, 120, 215) ' revert
                                          End Sub

            AddHandler btnAdd.Click,
                Sub(sender, e)
                    AddToCart(row("ProductCode").ToString(),
                              row("ProductName").ToString(),
                              Convert.ToDecimal(row("Price")))
                End Sub
            card.Controls.Add(btnAdd)

            flpProduct1.Controls.Add(card)
        Next
    End Sub
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
                MessageBox.Show("Please select a product to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim prod As New Product With {
            .Code = txtProductCode.Text,
            .Name = txtProductName.Text,
            .Category = txtCategory.Text,
            .Price = Decimal.Parse(txtPrice.Text),
            .Stock = Integer.Parse(txtStock.Text)
        }

            ' Call your database helper update method
            If db.UpdateProduct(prod) Then
                dgvProducts.DataSource = db.LoadProducts
                LoadProductCards()
                ClearInputs()
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub flpProduct1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tabProducts_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub
End Class

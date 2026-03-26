Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmPOS
    Private db As New DatabaseHelper()
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
            fadeTimer.Interval = 15 ' speed of animation (ms)
            AddHandler fadeTimer.Tick, AddressOf FadeStep
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim g As Graphics = e.Graphics
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            ' Shadow rectangle with rounded corners
            Dim shadowRect As New Rectangle(ShadowSize, ShadowSize, Me.Width - ShadowSize, Me.Height - ShadowSize)
            Using shadowPath As Drawing2D.GraphicsPath = GetRoundedRect(shadowRect, CornerRadius)
                Using shadowBrush As New SolidBrush(Color.FromArgb(currentShadowAlpha, Color.Black))
                    g.FillPath(shadowBrush, shadowPath)
                End Using
            End Using

            ' Rounded rectangle for panel
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

        ' Hover effect with animation
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


    ' Product structure
    Public Class Product
        Public Property Code As String
        Public Property Name As String
        Public Property Category As String
        Public Property Price As Decimal
        Public Property Stock As Integer
    End Class

    ' Cart item structure
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

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.InitializeDatabase()
        Timer1.Start()
        dgvProducts.DataSource = db.LoadProducts()
        LoadProductCards()
        LoadCartCards()
    End Sub

    ' Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    ' Add Product
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MessageBox.Show("Please fill in the Product Name and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim newProd As New Product With {
                .Code = txtProductCode.Text,
                .Name = txtProductName.Text,
                .Category = txtCategory.Text,
                .Price = Decimal.Parse(txtPrice.Text),
                .Stock = Integer.Parse(txtStock.Text)
            }

            If db.SaveProduct(newProd) Then
                dgvProducts.DataSource = db.LoadProducts()
                LoadProductCards()
                ClearInputs()
                MessageBox.Show("Product saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearInputs()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    ' Add to Cart
    Private Sub AddToCart(code As String, name As String, price As Decimal)
        Dim existing = Cart.FirstOrDefault(Function(c) c.ProductCode = code)
        If existing IsNot Nothing Then
            existing.Quantity += 1
        Else
            Cart.Add(New CartItem With {.ProductCode = code, .ProductName = name, .Price = price, .Quantity = 1})
        End If
        LoadCartCards()
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
                    item.Quantity += 1
                    LoadCartCards()
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
                    Else
                        Cart.Remove(item)
                    End If
                    LoadCartCards()
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
                    Cart.Remove(item)
                    LoadCartCards()
                End Sub
            card.Controls.Add(btnRemove)

            flpCart.Controls.Add(card)
        Next

        ' --- Totals card at the bottom ---
        Dim totalsCard As New Panel With {
            .Width = 250,
            .Height = 100,
            .BorderStyle = BorderStyle.FixedSingle,
            .Margin = New Padding(5),
            .BackColor = Color.LightGray
        }

        Dim subtotal As Decimal = Cart.Sum(Function(c) c.Subtotal)
        Dim total As Decimal = subtotal ' add tax/discount logic here if needed

        Dim lblSubtotal As New Label With {
            .Text = "Subtotal: ₱" & subtotal.ToString("N2"),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .Location = New Point(10, 10),
            .AutoSize = True
        }
        totalsCard.Controls.Add(lblSubtotal)

        Dim lblTotal As New Label With {
            .Text = "Total: ₱" & total.ToString("N2"),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .Location = New Point(10, 35),
            .AutoSize = True
        }
        totalsCard.Controls.Add(lblTotal)

        ' Checkout button inside totals card
        ' Checkout button inside totals card
        Dim btnCheckout As New Button With {
            .Text = "Check Out",
            .Location = New Point(10, 60),
            .Width = 100
        }
        AddHandler btnCheckout.Click, AddressOf btnCheckout_Click
        totalsCard.Controls.Add(btnCheckout)

        ' Clear Cart button inside totals card
        Dim btnClear As New Button With {
            .Text = "Clear Cart",
            .Location = New Point(120, 60),
            .Width = 100
        }
        AddHandler btnClear.Click,
            Sub(sender, e)
                Cart.Clear()
                LoadCartCards()
            End Sub
        totalsCard.Controls.Add(btnClear)

        flpCart.Controls.Add(totalsCard)
    End Sub

    ' Checkout logic
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs)
        If Cart.Count = 0 Then
            MessageBox.Show("Cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal = Cart.Sum(Function(c) c.Subtotal)
        Dim total As Decimal = subtotal ' add tax/discount if needed

        MessageBox.Show("Checkout successful!" & vbCrLf &
                        "Subtotal: ₱" & subtotal.ToString("N2") & vbCrLf &
                        "Total: ₱" & total.ToString("N2"),
                        "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear cart after checkout
        Cart.Clear()
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
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .Location = New Point(10, 10),
                .AutoSize = True
            }
            card.Controls.Add(lblName)

            Dim lblCategory As New Label With {
                .Text = "Category: " & row("Category").ToString(),
                .Location = New Point(10, 35),
                .AutoSize = True
            }
            card.Controls.Add(lblCategory)

            Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(row("Price")).ToString("N2"),
                .Location = New Point(10, 60),
                .AutoSize = True
            }
            card.Controls.Add(lblPrice)

            Dim lblStock As New Label With {
                .Text = "Stock: " & row("Stock").ToString(),
                .Location = New Point(10, 85),
                .AutoSize = True
            }
            card.Controls.Add(lblStock)

            Dim btnAdd As New Button With {
                .Text = "Add to Cart",
                .Location = New Point(10, 110),
                .Width = 100
            }
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
End Class

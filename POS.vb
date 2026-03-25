Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmPOS
    Private db As New DatabaseHelper()

    ' Product structure
    Public Class Product
        Public Property Code As String
        Public Property Name As String
        Public Property Category As String
        Public Property Price As Decimal
        Public Property Stock As Integer
    End Class

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.InitializeDatabase()
        Timer1.Start()
        dgvProducts.DataSource = db.LoadProducts()
        LoadProductCards()
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

    ' Export to CSV
    Private Sub BtnExportcsv_Click(sender As Object, e As EventArgs) Handles BtnExportcsv.Click
        If dgvProducts.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim fileName As String = "Inventory_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"
        Dim fullPath As String = Path.Combine(folderPath, fileName)

        Dim sb As New StringBuilder()
        sb.AppendLine("Product Code,Product Name,Category,Price,Stock")

        For Each row As DataGridViewRow In dgvProducts.Rows
            If Not row.IsNewRow Then
                sb.AppendLine($"{row.Cells(0).Value},{row.Cells(1).Value},{row.Cells(2).Value},{row.Cells(3).Value},{row.Cells(4).Value}")
            End If
        Next

        File.WriteAllText(fullPath, sb.ToString(), Encoding.UTF8)
        MessageBox.Show("CSV Saved to My Documents!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Print Layout
    ' Print Layout
    Private Sub PrintLayout(sender As Object, e As PrintPageEventArgs)
        Dim fHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fBody As New Font("Arial", 10, FontStyle.Regular)
        Dim fBold As New Font("Arial", 10, FontStyle.Bold)

        Dim x As Integer = 50
        Dim y As Integer = 50

        e.Graphics.DrawString("INVENTORY REPORT", fHeader, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"), fBody, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString(New String("-"c, 45), fBody, Brushes.Black, x, y)

        ' Table Headers
        y += 25
        e.Graphics.DrawString("Product", fBold, Brushes.Black, x, y)
        e.Graphics.DrawString("Price", fBold, Brushes.Black, x + 200, y)
        e.Graphics.DrawString("Stock", fBold, Brushes.Black, x + 300, y)
        y += 20

        ' Items Loop
        For Each row As DataGridViewRow In dgvProducts.Rows
            If Not row.IsNewRow Then
                y += 25
                e.Graphics.DrawString(row.Cells("ProductName").Value.ToString(), fBody, Brushes.Black, x, y)
                e.Graphics.DrawString(row.Cells("Price").Value.ToString(), fBody, Brushes.Black, x + 200, y)
                e.Graphics.DrawString(row.Cells("Stock").Value.ToString(), fBody, Brushes.Black, x + 300, y)
            End If
        Next

        y += 40
        e.Graphics.DrawString("--- End of Report ---", fBody, Brushes.Black, x + 100, y)
    End Sub

    ' Clear Cart (optional logic)
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = db.LoadProducts()
        LoadProductCards()
        MessageBox.Show("Cart cleared and products reloaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' FlowLayoutPanel paint event (optional, can be used for custom drawing)
    Private Sub flpProduct1_Paint(sender As Object, e As PaintEventArgs) Handles flpProduct1.Paint
        ' You can leave this empty or add custom background drawing
    End Sub

    ' Load product cards into FlowLayoutPanel
    Private Sub LoadProductCards()
        flpProduct1.Controls.Clear()
        Dim dt As DataTable = db.LoadProducts()

        For Each row As DataRow In dt.Rows
            Dim card As New Panel With {
                .Width = 200,
                .Height = 140,
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(10),
                .BackColor = Color.White
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
                    MessageBox.Show(row("ProductName").ToString() & " added to cart!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Sub
            card.Controls.Add(btnAdd)

            flpProduct1.Controls.Add(card)
        Next
    End Sub
End Class

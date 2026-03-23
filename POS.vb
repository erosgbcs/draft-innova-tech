Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class frmPOS
    ' A simple list to act as our "Database" for this example
    ' In a real app, you'd save this to SQL or a file
    Private ProductList As New List(Of Product)

    ' Structure for our products
    Public Class Product
        Public Property Code As String
        Public Property Name As String
        Public Property Category As String
        Public Property Price As Decimal
        Public Property Stock As Integer
    End Class

    ' 1. TIMER FOR TIME AND REFRESH
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        ' Note: Loading products every 5 seconds might flicker. 
        ' Better to call LoadProducts() only when data changes.
    End Sub

    ' 2. ADD PRODUCT BUTTON (THE FIX)
    ' Make sure your TextBoxes are named correctly: txtCode, txtName, txtCategory, txtPrice, txtStock
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Validation: Check if fields are empty
            If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MessageBox.Show("Please fill in the Product Name and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create new product object
            Dim newProd As New Product With {
                .Code = txtProductCode.Text,
                .Name = txtProductName.Text,
                .Category = txtCategory.Text,
                .Price = Decimal.Parse(txtPrice.Text),
                .Stock = Integer.Parse(txtStock.Text)
            }

            ' Add to list and refresh grid
            ProductList.Add(newProd)
            LoadProducts()
            ClearInputs()

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 3. EXPORT AND PRINT BUTTON
    Private Sub BtnExportcsv_Click(sender As Object, e As EventArgs) Handles BtnExportcsv.Click
        If dgvProducts.Rows.Count = 0 Then
            MessageBox.Show("Walang data na pwedeng i-save o i-print.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' STEP A: SAVE CSV
            SaveToCSV()

            ' STEP B: PRINT/PREVIEW
            Dim pd As New PrintDocument()
            pd.PrinterSettings = New PrinterSettings()
            AddHandler pd.PrintPage, AddressOf PrintLayout

            Dim preview As New PrintPreviewDialog()
            preview.Document = pd
            preview.ShowDialog() ' This shows the preview first

            ' Actual Print
            pd.Print()

        Catch ex As Exception
            MessageBox.Show("May error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- HELPER METHODS ---

    Private Sub SaveToCSV()
        Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim fileName As String = "Inventory_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"
        Dim fullPath As String = Path.Combine(folderPath, fileName)

        Dim sb As New StringBuilder()
        sb.AppendLine("Product Code,Product Name,Category,Price,Stock")

        For Each row As DataGridViewRow In dgvProducts.Rows
            If Not row.IsNewRow Then
                Dim code As String = If(row.Cells(0).Value?.ToString(), "N/A")
                Dim name As String = If(row.Cells(1).Value?.ToString(), "N/A")
                Dim cat As String = If(row.Cells(2).Value?.ToString(), "N/A")
                Dim price As String = If(row.Cells(3).Value?.ToString(), "0")
                Dim stock As String = If(row.Cells(4).Value?.ToString(), "0")
                sb.AppendLine($"{code},{name},{cat},{price},{stock}")
            End If
        Next
        File.WriteAllText(fullPath, sb.ToString(), Encoding.UTF8)
        MessageBox.Show("CSV Saved to My Documents!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadProducts()
        ' Bind the list to the DataGridView
        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = ProductList
    End Sub

    Private Sub ClearInputs()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    ' PRINT LAYOUT
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
                e.Graphics.DrawString(row.Cells(1).Value.ToString(), fBody, Brushes.Black, x, y)
                e.Graphics.DrawString(row.Cells(3).Value.ToString(), fBody, Brushes.Black, x + 200, y)
                e.Graphics.DrawString(row.Cells(4).Value.ToString(), fBody, Brushes.Black, x + 300, y)
            End If
        Next

        y += 40
        e.Graphics.DrawString("--- End of Report ---", fBody, Brushes.Black, x + 100, y)
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click

    End Sub

End Class
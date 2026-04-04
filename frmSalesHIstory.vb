Public Class frmSalesHIstory
    Private db As New DatabaseHelper()

    Private Sub frmSalesHIstory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshSalesData()
        FormatGrid()
    End Sub

    ' Loads all sales into the grid
    Private Sub RefreshSalesData()
        Guna2DataGridView1.DataSource = db.LoadSales()
    End Sub

    ' Search logic: Filters as you type
    Private Sub txtSearchSales_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSales.TextChanged
        If String.IsNullOrWhiteSpace(txtSearchSales.Text) Then
            RefreshSalesData()
        Else
            Guna2DataGridView1.DataSource = db.SearchSales(txtSearchSales.Text)
        End If
    End Sub

    ' Grid Formatting (Optional but recommended for a clean look)
    Private Sub FormatGrid()
        With Guna2DataGridView1
            .Columns("SaleID").HeaderText = "ID"
            .Columns("BuyerName").HeaderText = "Customer Name"
            .Columns("SaleDate").HeaderText = "Date & Time"

            ' Format currency columns
            .Columns("Subtotal").DefaultCellStyle.Format = "N2"
            .Columns("Total").DefaultCellStyle.Format = "₱N2"

            ' Adjust widths
            .Columns("SaleID").Width = 50
            .Columns("Total").DefaultCellStyle.ForeColor = Color.SeaGreen
            .Columns("Total").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        End With
    End Sub

    ' Handle clicks (e.g., selecting a row to view details)
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        ' Check if a valid row was clicked (not the header)
        If e.RowIndex >= 0 Then
            Dim selectedID As String = Guna2DataGridView1.Rows(e.RowIndex).Cells("SaleID").Value.ToString()
            ' You could open a "Receipt View" here if you wanted
            Console.WriteLine("Selected Sale ID: " & selectedID)
        End If
    End Sub
End Class
Public Class frmInventory
    ' Declare the helper at the class level
    Private db As New DatabaseHelper()

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This ensures your tables exist before you try to load them
        db.InitializeDatabase()
        RefreshData()
    End Sub

    ' Add Product Button logic
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            ' Validation
            If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MessageBox.Show("Please fill in the Product Name and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create the Product object from TextBoxes
            Dim prod As New Product With {
                .Code = txtProductCode.Text,
                .Name = txtProductName.Text,
                .Category = txtCategory.Text,
                .Price = Decimal.Parse(txtPrice.Text),
                .Stock = Integer.Parse(txtStock.Text)
            }

            ' Save to SQLite via your Helper
            If db.SaveProduct(prod) Then
                RefreshData()
                ClearInputs()
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper to refresh the DataGridView
    Private Sub RefreshData()
        dgvProducts.DataSource = db.LoadProducts()
    End Sub

    ' Helper to clear TextBoxes
    Private Sub ClearInputs()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub
    ' Open Sales History
    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Dim salesForm As New Sales_History()
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show()
    End Sub

    ' Open POS
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Dim posForm As New pos()
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
    End Sub

    ' Open Inventory (current form) – usually not needed
    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        ' You’re already inside frmInventory, so this button doesn’t need to reopen itself.
        ' If you want to refresh, just call RefreshData()
        RefreshData()
    End Sub

    Private Sub Guna2CustomGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel2.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim posForm As New frmdashboard()
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
    End Sub
End Class
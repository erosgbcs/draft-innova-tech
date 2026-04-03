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
    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Sales_History.Show()
    End Sub

    Private Sub btnOpenPOS_Click_1(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        pos.Show()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        Me.Show()
    End Sub
End Class
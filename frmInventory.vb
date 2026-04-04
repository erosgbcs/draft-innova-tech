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
        Dim salesForm As New Sales_History
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show
    End Sub

    ' Open POS
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Dim posForm As New pos
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show
    End Sub

    ' Open Inventory (current form) – usually not needed
    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        ' You’re already inside frmInventory, so this button doesn’t need to reopen itself.
        ' If you want to refresh, just call RefreshData()
        RefreshData
    End Sub

    Private Sub Guna2CustomGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel2.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim posForm As New frmdashboard
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show
    End Sub

    ' Populate textboxes when a row is clicked
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductCode.Text = row.Cells("ProductCode").Value.ToString()
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = row.Cells("Category").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtStock.Text = row.Cells("Stock").Value.ToString()
            ' Disable editing the code since it is the unique ID for updates
            txtProductCode.ReadOnly = True
        End If
    End Sub

    ' Update Logic
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtProductCode.Text) Then Return

            Dim prod As New Product With {
                .Code = txtProductCode.Text,
                .Name = txtProductName.Text,
                .Category = txtCategory.Text,
                .Price = Decimal.Parse(txtPrice.Text),
                .Stock = Integer.Parse(txtStock.Text)
            }

            If db.UpdateProduct(prod) Then
                RefreshData()
                ClearInputs()
                MessageBox.Show("Inventory updated successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show("Update Error: " & ex.Message)
        End Try
    End Sub

    ' Delete Logic
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then Return

        Dim result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ' You'll need to add DeleteProduct to your DatabaseHelper (see below)
            If db.DeleteProduct(txtProductCode.Text) Then
                RefreshData()
                ClearInputs()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'PRINT REPORT INVENTORY
    End Sub
    'EXPORT CSV
    Private Sub BtnExportcsv_Click(sender As Object, e As EventArgs) Handles BtnExportcsv.Click
        Try
            Dim sfd As New SaveFileDialog() With {.Filter = "CSV File|*.csv", .FileName = "InventoryExport.csv"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()
                ' Column Headers
                sb.AppendLine("Code,Name,Category,Price,Stock")
                ' Rows
                For Each row As DataGridViewRow In dgvProducts.Rows
                    If Not row.IsNewRow Then
                        sb.AppendLine($"{row.Cells(0).Value},{row.Cells(1).Value},{row.Cells(2).Value},{row.Cells(3).Value},{row.Cells(4).Value}")
                    End If
                Next
                IO.File.WriteAllText(sfd.FileName, sb.ToString())
                MessageBox.Show("Export successful!")
            End If
        Catch ex As Exception
            MessageBox.Show("Export failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUploadPictures_Click(sender As Object, e As EventArgs) Handles btnUploadPictures.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "Images|*.jpg;*.png;*.bmp"}
        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = Image.FromFile(ofd.FileName)
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'PICTUREBOX
    End Sub
End Class
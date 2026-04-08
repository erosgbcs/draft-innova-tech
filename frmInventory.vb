Public Class frmInventory
    ' Declare the helper at the class level
    Private db As New DatabaseHelper()

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This ensures your tables exist before you try to load them
        db.InitializeDatabase()
        '--- SECURITY & DATA INTEGRITY SETTINGS FOR DGV ---
        dgvProducts.ReadOnly = True ' Prevents users from typing in cells
        dgvProducts.AllowUserToAddRows = False ' Removes the empty bottom row
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Highlights the whole row
        dgvProducts.MultiSelect = False ' Optional: only allow one item at a time
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
    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs)
        Dim salesForm As New frmSalesHIstory
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show()
    End Sub

    ' Open POS
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs)
        Dim posForm As New pos
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
    End Sub

    ' Open Inventory (current form) – usually not needed
    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs)
        ' You’re already inside frmInventory, so this button doesn’t need to reopen itself.
        ' If you want to refresh, just call RefreshData()
        RefreshData()
    End Sub

    Private Sub Guna2CustomGradientPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim posForm As New frmdashboard
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles printreport.Click
        ' Initialize the Print Preview Dialog
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintInventoryDoc
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        'PICTUREBOX
    End Sub
    ' THIS IS THE MISSING LOGIC THAT DRAWS THE CONTENT
    Private Sub PrintInventoryDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintInventoryDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontHeader As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Segoe UI", 9, FontStyle.Italic)
        Dim fontColumn As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontRow As New Font("Segoe UI", 10, FontStyle.Regular)

        Dim posX As Integer = 50
        Dim posY As Integer = 50

        ' 1. Title
        g.DrawString("INNOVATECH INVENTORY REPORT", fontHeader, Brushes.Black, posX, posY)

        ' 2. Full Date and Time
        posY += 35
        g.DrawString("Report Date: " & DateTime.Now.ToString("f"), fontSubHeader, Brushes.DimGray, posX, posY)

        posY += 45 ' Space before table

        ' 3. Table Headers (Using Column Indexes)
        g.DrawString("CODE", fontColumn, Brushes.Black, posX, posY)
        g.DrawString("NAME", fontColumn, Brushes.Black, posX + 100, posY)
        g.DrawString("CATEGORY", fontColumn, Brushes.Black, posX + 350, posY)
        g.DrawString("PRICE", fontColumn, Brushes.Black, posX + 500, posY)
        g.DrawString("STOCK", fontColumn, Brushes.Black, posX + 600, posY)

        posY += 25
        g.DrawLine(Pens.Black, posX, posY, posX + 700, posY)
        posY += 10

        ' 4. Loop Data (Safely)
        For Each row As DataGridViewRow In dgvProducts.Rows
            If Not row.IsNewRow Then
                ' The ?.ToString() and If(..., "") prevents "Object reference not set" errors
                Dim code As String = If(row.Cells(0).Value?.ToString(), "N/A")
                Dim name As String = If(row.Cells(1).Value?.ToString(), "Unknown")
                Dim cat As String = If(row.Cells(2).Value?.ToString(), "N/A")

                g.DrawString(code, fontRow, Brushes.Black, posX, posY)
                g.DrawString(name, fontRow, Brushes.Black, posX + 100, posY)
                g.DrawString(cat, fontRow, Brushes.Black, posX + 350, posY)

                ' Format as Currency safely
                Dim priceVal As Decimal = 0
                If row.Cells(3).Value IsNot Nothing AndAlso IsNumeric(row.Cells(3).Value) Then
                    priceVal = CDec(row.Cells(3).Value)
                End If
                g.DrawString(priceVal.ToString("N2"), fontRow, Brushes.Black, posX + 500, posY)

                Dim stock As String = If(row.Cells(4).Value?.ToString(), "0")
                g.DrawString(stock, fontRow, Brushes.Black, posX + 600, posY)

                posY += 25
            End If
        Next
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        User.Show()
    End Sub
    ' --- Logout Button ---
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Assuming you have a login form named FrmLogin
            Dim login As New FrmLogin
            login.Show()
            Close()
        End If
    End Sub
End Class
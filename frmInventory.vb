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

        ApplyHoverEffect(btnUpdate, Color.FromArgb(34, 197, 94))   ' Green
        ApplyHoverEffect(btnDelete, Color.FromArgb(239, 68, 68))   ' Red
        ApplyHoverEffect(btnAddProduct, Color.FromArgb(59, 130, 246)) ' Blue
        ApplyHoverEffect(BtnExportcsv, Color.FromArgb(20, 184, 166))  ' Teal
        ApplyHoverEffect(printreport, Color.FromArgb(107, 114, 128))  ' Gray


        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        RefreshData()
        ' Button colors
        btnUpdate.BackColor = Color.FromArgb(34, 197, 94)   ' Green
        btnDelete.BackColor = Color.FromArgb(239, 68, 68)   ' Red
        btnAddProduct.BackColor = Color.FromArgb(59, 130, 246) ' Blue
        BtnExportcsv.BackColor = Color.FromArgb(20, 184, 166)  ' Teal
        printreport.BackColor = Color.FromArgb(107, 114, 128)  ' Gray

    End Sub
    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        btnUpdate.Enabled = dgvProducts.SelectedRows.Count > 0
        btnDelete.Enabled = dgvProducts.SelectedRows.Count > 0
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            ' 1. Validation
            If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MessageBox.Show("Please fill in the Product Name and Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim price As Decimal
            Dim stock As Integer

            If Not Decimal.TryParse(txtPrice.Text, price) OrElse Not Integer.TryParse(txtStock.Text, stock) Then
                MessageBox.Show("Please enter valid numbers for Price and Stock.", "Input Error")
                Return
            End If

            Dim prod As New Product With {
    .Code = txtProductCode.Text,
    .Name = txtProductName.Text,
    .Category = txtCategory.Text,
    .Price = price,
    .Stock = stock
}

            ' 3. Save to SQLite via your Helper
            If db.SaveProduct(prod) Then

                ' --- START OF LOGGING LOGIC ---
                ' This sends the information to the InventoryLogs table
                Dim logDetails As String = $"Added new product: {prod.Name} (Qty: {prod.Stock})"

                ' Replace "Admin" with GlobalData.Username or whoever is logged in
                db.LogInventoryChange("Admin", "ADD PRODUCT", logDetails)
                ' --- END OF LOGGING LOGIC ---

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
                ' --- LOGGING LOGIC ---
                Dim logDetails As String = $"Updated {prod.Name}: Stock is now {prod.Stock}, Price is ₱{prod.Price:N2}"
                db.LogInventoryChange("Admin", "UPDATE PRODUCT", logDetails)
                ' ---------------------

                RefreshData()
                ClearInputs()
                MessageBox.Show("Inventory updated and change logged.")
            End If
        Catch ex As Exception
            MessageBox.Show("Update Error: " & ex.Message)
        End Try
    End Sub

    ' Delete Logic
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then Return

        ' Capture the name before deleting so we can use it in the log
        Dim productName As String = txtProductName.Text

        Dim result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If db.DeleteProduct(txtProductCode.Text) Then
                ' --- LOGGING LOGIC ---
                db.LogInventoryChange("Admin", "DELETE PRODUCT", $"Removed product: {productName} (Code: {txtProductCode.Text})")
                ' ---------------------

                RefreshData()
                ClearInputs()
                MessageBox.Show("Product deleted and action logged.")
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

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
    Private Sub ApplyHoverEffect(btn As Button, normalColor As Color)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = normalColor
        btn.ForeColor = Color.White

        AddHandler btn.MouseEnter,
            Sub(sender, e)
                Dim b = DirectCast(sender, Button)
                b.BackColor = ControlPaint.Dark(normalColor, 0.1)
                ' Shadow glow effect
                b.FlatAppearance.BorderColor = Color.FromArgb(120, 0, 0, 0)
                b.FlatAppearance.BorderSize = 3
            End Sub

        AddHandler btn.MouseLeave,
            Sub(sender, e)
                Dim b = DirectCast(sender, Button)
                b.BackColor = normalColor
                b.FlatAppearance.BorderSize = 0
            End Sub
    End Sub


    Private Sub MakeRounded(btn As Button, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        ' Apply rounded region
        btn.Region = New Region(path)

        ' Draw outline by handling Paint event
        AddHandler btn.Paint,
            Sub(sender, e)
                Dim g = e.Graphics
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                Using outlinePen As New Pen(Color.FromArgb(180, 0, 0, 0), 2) ' semi-dark outline
                    g.DrawPath(outlinePen, path)
                End Using
            End Sub
    End Sub
End Class
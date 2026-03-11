Imports System.Data.SQLite
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text

Public Class frmPOS
    ' Database connection string
    Private connectionString As String = "Data Source=products.db;Version=3;"

    ' Global variable para sa tracking
    Private currentWeekStartDate As DateTime

    ' Stock warning threshold (you can adjust this value)
    Private Const STOCK_WARNING_THRESHOLD As Integer = 10
    Private Const STOCK_CRITICAL_THRESHOLD As Integer = 5

    ' --- FORM LOAD ---
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        ' 1. Automatic: I-set ang picker sa Sunday ng kasalukuyang linggo
        Dim today As DateTime = DateTime.Today
        Dim diff As Integer = today.DayOfWeek
        currentWeekStartDate = today.AddDays(-diff)

        ' I-update ang UI controls
        DateTimePicker1.Value = currentWeekStartDate
        UpdateWeekLabel()

        ' Create database and table if not exists
        CreateDatabase()
        ' Load existing data
        LoadProducts()

        ' Configure DataGridView to be read-only
        ConfigureDataGridView()

        ' Check for low stock items on form load
        CheckLowStockItems()
    End Sub

    ' --- CONFIGURE DATAGRIDVIEW ---
    Private Sub ConfigureDataGridView()
        With dgvProducts
            ' Make grid read-only - CANNOT EDIT DIRECTLY
            .ReadOnly = True

            ' Prevent adding new rows
            .AllowUserToAddRows = False

            ' Prevent deleting rows
            .AllowUserToDeleteRows = False

            ' Allow full row selection
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Allow only single selection
            .MultiSelect = False

            ' Hide row headers (optional)
            .RowHeadersVisible = False

            ' Set background color
            .BackgroundColor = Color.White

            ' Set border style
            .BorderStyle = BorderStyle.Fixed3D

            ' Enable sorting
            .AllowUserToOrderColumns = True

            ' Make columns read-only individually (extra safety)
            For Each col As DataGridViewColumn In .Columns
                col.ReadOnly = True
            Next

            ' Enable cell formatting for stock warnings
            AddHandler .CellFormatting, AddressOf dgvProducts_CellFormatting
        End With
    End Sub

    ' --- STOCK WARNING CELL FORMATTING ---
    Private Sub dgvProducts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Check if this is the Stock column
        If dgvProducts.Columns(e.ColumnIndex).Name = "Stock" AndAlso e.RowIndex >= 0 Then
            Dim stockValue As Object = dgvProducts.Rows(e.RowIndex).Cells("Stock").Value

            If stockValue IsNot Nothing AndAlso stockValue IsNot DBNull.Value Then
                Dim stock As Integer = Convert.ToInt32(stockValue)

                ' Color code based on stock level
                If stock <= 0 Then
                    ' Out of stock - Red background, White text, Bold
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.DarkRed
                ElseIf stock <= STOCK_CRITICAL_THRESHOLD Then
                    ' Critical stock - Dark Orange background
                    e.CellStyle.BackColor = Color.FromArgb(255, 128, 0) ' Dark Orange
                    e.CellStyle.ForeColor = Color.White
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.FromArgb(204, 102, 0)
                ElseIf stock <= STOCK_WARNING_THRESHOLD Then
                    ' Low stock - Yellow background
                    e.CellStyle.BackColor = Color.Yellow
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.Gold
                End If

                ' Add tooltip for stock information
                dgvProducts.Rows(e.RowIndex).Cells("Stock").ToolTipText = GetStockTooltip(stock)
            End If
        End If

        ' Also highlight the entire row for out of stock items
        If e.RowIndex >= 0 AndAlso dgvProducts.Columns(e.ColumnIndex).Name <> "Stock" Then
            Dim stockValue As Object = dgvProducts.Rows(e.RowIndex).Cells("Stock").Value
            If stockValue IsNot Nothing AndAlso stockValue IsNot DBNull.Value Then
                Dim stock As Integer = Convert.ToInt32(stockValue)

                ' For out of stock items, give the whole row a light red tint
                If stock <= 0 Then
                    e.CellStyle.BackColor = Color.MistyRose
                End If
            End If
        End If
    End Sub

    ' --- CHECK LOW STOCK ITEMS ---
    Private Sub CheckLowStockItems()
        Try
            Dim lowStockProducts As New List(Of String)()
            Dim criticalStockProducts As New List(Of String)()
            Dim outOfStockProducts As New List(Of String)()

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Query for products with low stock
                Dim query As String = "SELECT ProductCode, ProductName, Stock FROM Products WHERE Stock <= @threshold ORDER BY Stock"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@threshold", STOCK_WARNING_THRESHOLD)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim productCode As String = reader("ProductCode").ToString()
                            Dim productName As String = reader("ProductName").ToString()
                            Dim stock As Integer = Convert.ToInt32(reader("Stock"))

                            Dim productInfo As String = $"{productCode} - {productName} (Stock: {stock})"

                            If stock <= 0 Then
                                outOfStockProducts.Add(productInfo)
                            ElseIf stock <= STOCK_CRITICAL_THRESHOLD Then
                                criticalStockProducts.Add(productInfo)
                            Else
                                lowStockProducts.Add(productInfo)
                            End If
                        End While
                    End Using
                End Using
            End Using

            ' Show warning messages
            ShowStockWarnings(lowStockProducts, criticalStockProducts, outOfStockProducts)

        Catch ex As Exception
            MessageBox.Show("Error checking stock levels: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- SHOW STOCK WARNINGS ---
    Private Sub ShowStockWarnings(lowStock As List(Of String), criticalStock As List(Of String), outOfStock As List(Of String))
        Dim warningMessage As String = ""
        Dim hasWarnings As Boolean = False

        ' Out of stock items
        If outOfStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "❌ OUT OF STOCK ITEMS:" & vbCrLf
            warningMessage &= "══════════════════════" & vbCrLf
            For Each item In outOfStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        ' Critical stock items
        If criticalStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "⚠️ CRITICAL STOCK (5 or less):" & vbCrLf
            warningMessage &= "════════════════════════════" & vbCrLf
            For Each item In criticalStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        ' Low stock items
        If lowStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "⚠️ LOW STOCK ITEMS (10 or less):" & vbCrLf
            warningMessage &= "══════════════════════════════" & vbCrLf
            For Each item In lowStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        ' Show warning if there are low stock items
        If hasWarnings Then
            warningMessage &= vbCrLf & "Please restock these items soon!"
            MessageBox.Show(warningMessage, "STOCK WARNING",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
        End If

        ' Update status label if you have one (optional)
        UpdateStockStatusLabel(lowStock.Count, criticalStock.Count, outOfStock.Count)
    End Sub

    ' --- UPDATE STOCK STATUS LABEL (if you have a label for stock status) ---
    Private Sub UpdateStockStatusLabel(lowCount As Integer, criticalCount As Integer, outCount As Integer)
        ' Check if you have a label named lblStockStatus
        ' If not, you can add one to your form or comment this out
        If HasControl("lblStockStatus") Then
            Dim totalWarnings As Integer = lowCount + criticalCount + outCount
            If totalWarnings > 0 Then
                CType(Controls("lblStockStatus"), Label).Text = $"⚠️ Stock Alerts: {outCount} Out, {criticalCount} Critical, {lowCount} Low"
                CType(Controls("lblStockStatus"), Label).ForeColor = Color.Red
                CType(Controls("lblStockStatus"), Label).Font = New Font(CType(Controls("lblStockStatus"), Label).Font, FontStyle.Bold)
            Else
                CType(Controls("lblStockStatus"), Label).Text = "✅ All stock levels are good"
                CType(Controls("lblStockStatus"), Label).ForeColor = Color.Green
            End If
        End If
    End Sub

    ' --- HELPER METHOD TO CHECK IF CONTROL EXISTS ---
    Private Function HasControl(controlName As String) As Boolean
        For Each ctrl As Control In Me.Controls
            If ctrl.Name = controlName Then
                Return True
            End If
        Next
        Return False
    End Function

    ' --- GET STOCK TOOLTIP ---
    Private Function GetStockTooltip(stock As Integer) As String
        If stock <= 0 Then
            Return "❌ OUT OF STOCK - Please restock immediately!"
        ElseIf stock <= STOCK_CRITICAL_THRESHOLD Then
            Return $"⚠️ CRITICAL STOCK! Only {stock} left! Order now!"
        ElseIf stock <= STOCK_WARNING_THRESHOLD Then
            Return $"⚠️ Low stock: {stock} items remaining. Consider restocking soon."
        Else
            Return $"✅ Stock level: {stock}"
        End If
    End Function

    ' --- TIMER LOGIC ---
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt")
    End Sub

    ' --- DATETIMEPICKER LOGIC ---
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Kapag namili ang user ng kahit anong araw, i-snap natin sa Sunday ng linggong iyon
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim diff As Integer = selectedDate.DayOfWeek
        currentWeekStartDate = selectedDate.AddDays(-diff)

        UpdateWeekLabel()
        LoadData()
    End Sub

    ' --- REFRESH BUTTON ---
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
        LoadProducts() ' Refresh products grid too
        CheckLowStockItems() ' Check stock levels after refresh
        MessageBox.Show("Report Refreshed!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- NAVIGATION BUTTONS ---
    Private Sub btnPreviousWeek_Click(sender As Object, e As EventArgs) Handles btnPreviousWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(-7)
        DateTimePicker1.Value = currentWeekStartDate
    End Sub

    Private Sub btnNextWeek_Click(sender As Object, e As EventArgs) Handles btnNextWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(7)
        DateTimePicker1.Value = currentWeekStartDate
    End Sub

    ' --- HELPER METHODS ---
    Private Sub UpdateWeekLabel()
        ' I-update ang label
        Dim endOfWeek = currentWeekStartDate.AddDays(6)
        Label13.Text = currentWeekStartDate.ToString("MMM dd") & " - " & endOfWeek.ToString("MMM dd, yyyy")
    End Sub

    Private Sub LoadData()
        ' Dito papasok ang logic para i-filter ang Data sa Revenue Summary at Sales Performance
        Console.WriteLine("Fetching sales from " & currentWeekStartDate.ToShortDateString())
    End Sub

    ' --- EXPORT CSV BUTTON ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.FileName = "Weekly_Sales_" & currentWeekStartDate.ToString("yyyyMMdd") & ".csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New StringBuilder()
                ' Headers
                Dim headers = From col As DataGridViewColumn In dgvProducts.Columns.Cast(Of DataGridViewColumn)()
                              Select col.HeaderText
                sb.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dgvProducts.Rows
                    If Not row.IsNewRow Then
                        Dim cells = From cell As DataGridViewCell In row.Cells.Cast(Of DataGridViewCell)()
                                    Select If(cell.Value IsNot Nothing, cell.Value.ToString().Replace(",", " "), "")
                        sb.AppendLine(String.Join(",", cells))
                    End If
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                MessageBox.Show("Export Successful!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- PRODUCT MANAGEMENT (DATABASE) ---

    ' Create database and table
    Private Sub CreateDatabase()
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Create table if not exists - Using ProductCode as PRIMARY KEY (as requested)
                Dim createTableQuery As String = "
                CREATE TABLE IF NOT EXISTS Products (
                    ProductCode TEXT PRIMARY KEY,
                    ProductName TEXT NOT NULL,
                    Category TEXT,
                    Price DECIMAL(10,2),
                    Stock INTEGER
                )"

                Using command As New SQLiteCommand(createTableQuery, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add product button click event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
            MessageBox.Show("Please enter Product Code", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Please enter Product Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Return
        End If

        ' Validate Price
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid Price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        ' Validate Stock
        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Please enter a valid Stock number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Return
        End If

        ' Add to database
        AddProduct(txtProductCode.Text.Trim(), txtProductName.Text.Trim(),
                  txtCategory.Text.Trim(), price, stock)
    End Sub

    ' Add product to database
    Private Sub AddProduct(code As String, name As String, category As String, price As Decimal, stock As Integer)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Dim insertQuery As String = "INSERT INTO Products (ProductCode, ProductName, Category, Price, Stock) 
                                            VALUES (@code, @name, @category, @price, @stock)"

                Using command As New SQLiteCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@code", code)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@stock", stock)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear input fields
            ClearInputFields()

            ' Refresh the DataGridView
            LoadProducts()

            ' Check for low stock items after adding
            CheckLowStockItems()

        Catch ex As SQLiteException When ex.Message.Contains("UNIQUE") Or ex.Message.Contains("PRIMARY KEY")
            MessageBox.Show("Product Code already exists. Please use a different code.", "Duplicate Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load products into DataGridView
    Private Sub LoadProducts()
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Removed Id from SELECT since ProductCode is now PRIMARY KEY
                Dim selectQuery As String = "SELECT ProductCode, ProductName, Category, Price, Stock FROM Products ORDER BY ProductCode"
                Dim dataAdapter As New SQLiteDataAdapter(selectQuery, connection)
                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                ' Bind to DataGridView
                dgvProducts.DataSource = dataTable

                ' Configure column headers and formatting
                If dgvProducts.Columns.Count > 0 Then
                    dgvProducts.Columns("ProductCode").HeaderText = "Product Code"
                    dgvProducts.Columns("ProductName").HeaderText = "Product Name"
                    dgvProducts.Columns("Category").HeaderText = "Category"
                    dgvProducts.Columns("Price").HeaderText = "Price"
                    dgvProducts.Columns("Stock").HeaderText = "Stock"

                    ' Philippine Peso formatting for Price column
                    dgvProducts.Columns("Price").DefaultCellStyle.Format = "C2"
                    dgvProducts.Columns("Price").DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("en-PH")
                    dgvProducts.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    ' Format Stock with commas
                    dgvProducts.Columns("Stock").DefaultCellStyle.Format = "N0"
                    dgvProducts.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    ' Center align other columns for better look
                    dgvProducts.Columns("ProductCode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvProducts.Columns("Category").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    ' Make all columns read-only (extra safety)
                    For Each col As DataGridViewColumn In dgvProducts.Columns
                        col.ReadOnly = True
                    Next
                End If

                ' Auto-size columns
                dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

                ' Re-apply grid configuration
                ConfigureDataGridView()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear input fields
    Private Sub ClearInputFields()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        txtProductCode.Focus()
    End Sub

    ' Double-click on DataGridView row to load data into textboxes for editing
    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        ' Check if valid row (not header, not out of bounds)
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProducts.Rows.Count Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            ' Load data into textboxes for editing
            txtProductCode.Text = row.Cells("ProductCode").Value.ToString()
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = If(row.Cells("Category").Value Is DBNull.Value, "", row.Cells("Category").Value.ToString())

            ' Handle price formatting when loading to textbox
            Dim priceValue As Object = row.Cells("Price").Value
            If priceValue IsNot Nothing AndAlso priceValue IsNot DBNull.Value Then
                txtPrice.Text = Convert.ToDecimal(priceValue).ToString("0.00")
            Else
                txtPrice.Clear()
            End If

            txtStock.Text = row.Cells("Stock").Value.ToString()

            ' Optional: Highlight the selected row
            dgvProducts.ClearSelection()
            row.Selected = True

            ' Optional: Set focus to first textbox for editing
            txtProductCode.Focus()

            ' Show stock warning for this product if low
            Dim stock As Integer = Convert.ToInt32(row.Cells("Stock").Value)
            If stock <= STOCK_WARNING_THRESHOLD Then
                MessageBox.Show(GetStockTooltip(stock), "Stock Alert",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ' Optional: Single click selection (but still requires double-click to edit)
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        ' Just for selection, no editing
        If e.RowIndex >= 0 Then
            ' You could show a message or just let selection happen
            ' This doesn't load to textboxes - only double-click does that
        End If
    End Sub

    ' Prevent any cell from entering edit mode
    Private Sub dgvProducts_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvProducts.CellBeginEdit
        ' Cancel any attempt to edit
        e.Cancel = True
        MessageBox.Show("Please double-click the row to edit in the text boxes.", "Edit via Textboxes",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
            MessageBox.Show("Please select a product to update or enter Product Code", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate other fields (similar to Add)
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Please enter Product Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Return
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid Price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Please enter a valid Stock number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Return
        End If

        ' Check if stock is low and warn before update
        If stock <= STOCK_WARNING_THRESHOLD Then
            Dim warnResult As DialogResult = MessageBox.Show(
                $"Warning: You're setting stock to {stock} which is below the warning threshold.{vbCrLf}{vbCrLf}Do you want to continue?",
                "Low Stock Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If warnResult = DialogResult.No Then
                Return
            End If
        End If

        ' Update product
        UpdateProduct(txtProductCode.Text.Trim(), txtProductName.Text.Trim(),
                     txtCategory.Text.Trim(), price, stock)
    End Sub

    ' Update product in database
    Private Sub UpdateProduct(code As String, name As String, category As String, price As Decimal, stock As Integer)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE Products SET ProductName = @name, Category = @category, 
                                           Price = @price, Stock = @stock WHERE ProductCode = @code"

                Using command As New SQLiteCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@code", code)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@stock", stock)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearInputFields()
                        LoadProducts()
                        CheckLowStockItems() ' Check stock levels after update
                    Else
                        MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtProductCode.Text) AndAlso dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete or enter Product Code", "Information",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim productCode As String = ""

        If dgvProducts.SelectedRows.Count > 0 Then
            productCode = dgvProducts.SelectedRows(0).Cells("ProductCode").Value.ToString()
        Else
            productCode = txtProductCode.Text.Trim()
        End If

        If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DeleteProduct(productCode)
        End If
    End Sub

    ' Delete product from database
    Private Sub DeleteProduct(productCode As String)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim deleteQuery As String = "DELETE FROM Products WHERE ProductCode = @code"
                Using command As New SQLiteCommand(deleteQuery, connection)
                    command.Parameters.AddWithValue("@code", productCode)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearInputFields()
                        LoadProducts()
                        CheckLowStockItems() ' Check stock levels after delete
                    Else
                        MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class
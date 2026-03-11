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

    ' Stock warning threshold
    Private Const STOCK_WARNING_THRESHOLD As Integer = 10
    Private Const STOCK_CRITICAL_THRESHOLD As Integer = 5

    ' For search functionality
    Private allProductsDataTable As DataTable ' Store all products for filtering

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

        ' Configure search textbox
        ConfigureSearchBox()
    End Sub

    ' --- CONFIGURE SEARCH TEXTBOX ---
    Private Sub ConfigureSearchBox()
        With txtSearch
            .Text = "Search products..." ' Placeholder text
            .ForeColor = Color.Gray

            ' Add event handlers
            AddHandler .Enter, AddressOf txtSearch_Enter
            AddHandler .Leave, AddressOf txtSearch_Leave
            AddHandler .TextChanged, AddressOf txtSearch_TextChanged
        End With
    End Sub

    ' --- SEARCH TEXTBOX ENTER EVENT (remove placeholder) ---
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs)
        If txtSearch.Text = "Search products..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    ' --- SEARCH TEXTBOX LEAVE EVENT (add placeholder if empty) ---
    Private Sub txtSearch_Leave(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search products..."
            txtSearch.ForeColor = Color.Gray
            ' Show all products when search is empty
            FilterProducts("")
        End If
    End Sub

    ' --- SEARCH TEXTBOX TEXT CHANGED EVENT ---
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        ' Don't filter if it's the placeholder text
        If txtSearch.Text = "Search products..." Then
            Return
        End If

        ' Filter products based on search text
        FilterProducts(txtSearch.Text.Trim())
    End Sub

    ' --- FILTER PRODUCTS BASED ON SEARCH ---
    Private Sub FilterProducts(searchText As String)
        If allProductsDataTable Is Nothing Then
            Return
        End If

        Try
            If String.IsNullOrWhiteSpace(searchText) Then
                ' Show all products
                dgvProducts.DataSource = allProductsDataTable
            Else
                ' Create a filtered view
                Dim filteredRows As New DataTable()
                filteredRows = allProductsDataTable.Clone() ' Copy structure

                ' Convert search text to lowercase for case-insensitive search
                Dim lowerSearchText As String = searchText.ToLower()

                ' Filter rows
                For Each row As DataRow In allProductsDataTable.Rows
                    Dim productCode As String = row("ProductCode").ToString().ToLower()
                    Dim productName As String = row("ProductName").ToString().ToLower()
                    Dim category As String = If(row("Category") Is DBNull.Value, "", row("Category").ToString().ToLower())

                    ' Check if search text matches any field
                    If productCode.Contains(lowerSearchText) OrElse
                       productName.Contains(lowerSearchText) OrElse
                       category.Contains(lowerSearchText) Then
                        filteredRows.ImportRow(row)
                    End If
                Next

                ' Bind filtered data
                dgvProducts.DataSource = filteredRows
            End If

            ' Reapply column formatting
            ApplyColumnFormatting()

            ' Update search result count (optional)
            UpdateSearchResultCount()

        Catch ex As Exception
            ' Silent fail for search
            Console.WriteLine("Search error: " & ex.Message)
        End Try
    End Sub

    ' --- UPDATE SEARCH RESULT COUNT (optional) ---
    Private Sub UpdateSearchResultCount()
        ' Check if you have a label named lblSearchResults
        If HasControl("lblSearchResults") Then
            Dim rowCount As Integer = dgvProducts.Rows.Count
            If txtSearch.Text <> "Search products..." AndAlso Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                CType(Controls("lblSearchResults"), Label).Text = $"Found {rowCount} product(s)"
                CType(Controls("lblSearchResults"), Label).Visible = True
            Else
                CType(Controls("lblSearchResults"), Label).Visible = False
            End If
        End If
    End Sub

    ' --- APPLY COLUMN FORMATTING AFTER FILTER ---
    Private Sub ApplyColumnFormatting()
        If dgvProducts.Columns.Count > 0 Then
            ' Reapply column headers if needed
            If dgvProducts.Columns.Contains("ProductCode") Then
                dgvProducts.Columns("ProductCode").HeaderText = "Product Code"
                dgvProducts.Columns("ProductCode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvProducts.Columns.Contains("ProductName") Then
                dgvProducts.Columns("ProductName").HeaderText = "Product Name"
            End If

            If dgvProducts.Columns.Contains("Category") Then
                dgvProducts.Columns("Category").HeaderText = "Category"
                dgvProducts.Columns("Category").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvProducts.Columns.Contains("Price") Then
                dgvProducts.Columns("Price").HeaderText = "Price"
                dgvProducts.Columns("Price").DefaultCellStyle.Format = "C2"
                dgvProducts.Columns("Price").DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("en-PH")
                dgvProducts.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If

            If dgvProducts.Columns.Contains("Stock") Then
                dgvProducts.Columns("Stock").HeaderText = "Stock"
                dgvProducts.Columns("Stock").DefaultCellStyle.Format = "N0"
                dgvProducts.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        End If
    End Sub

    ' --- CONFIGURE DATAGRIDVIEW ---
    Private Sub ConfigureDataGridView()
        With dgvProducts
            ' Make grid read-only
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D
            .AllowUserToOrderColumns = True

            ' Make columns read-only
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
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.DarkRed
                ElseIf stock <= STOCK_CRITICAL_THRESHOLD Then
                    e.CellStyle.BackColor = Color.FromArgb(255, 128, 0)
                    e.CellStyle.ForeColor = Color.White
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.FromArgb(204, 102, 0)
                ElseIf stock <= STOCK_WARNING_THRESHOLD Then
                    e.CellStyle.BackColor = Color.Yellow
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.Font = New Font(dgvProducts.Font, FontStyle.Bold)
                    e.CellStyle.SelectionBackColor = Color.Gold
                End If

                ' Add tooltip
                dgvProducts.Rows(e.RowIndex).Cells("Stock").ToolTipText = GetStockTooltip(stock)
            End If
        End If

        ' Highlight entire row for out of stock
        If e.RowIndex >= 0 AndAlso dgvProducts.Columns(e.ColumnIndex).Name <> "Stock" Then
            Dim stockValue As Object = dgvProducts.Rows(e.RowIndex).Cells("Stock").Value
            If stockValue IsNot Nothing AndAlso stockValue IsNot DBNull.Value Then
                Dim stock As Integer = Convert.ToInt32(stockValue)
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

        If outOfStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "❌ OUT OF STOCK ITEMS:" & vbCrLf
            warningMessage &= "══════════════════════" & vbCrLf
            For Each item In outOfStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        If criticalStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "⚠️ CRITICAL STOCK (5 or less):" & vbCrLf
            warningMessage &= "════════════════════════════" & vbCrLf
            For Each item In criticalStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        If lowStock.Count > 0 Then
            hasWarnings = True
            warningMessage &= "⚠️ LOW STOCK ITEMS (10 or less):" & vbCrLf
            warningMessage &= "══════════════════════════════" & vbCrLf
            For Each item In lowStock
                warningMessage &= "• " & item & vbCrLf
            Next
            warningMessage &= vbCrLf
        End If

        If hasWarnings Then
            warningMessage &= vbCrLf & "Please restock these items soon!"
            MessageBox.Show(warningMessage, "STOCK WARNING",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
        End If

        UpdateStockStatusLabel(lowStock.Count, criticalStock.Count, outOfStock.Count)
    End Sub

    ' --- UPDATE STOCK STATUS LABEL ---
    Private Sub UpdateStockStatusLabel(lowCount As Integer, criticalCount As Integer, outCount As Integer)
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
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim diff As Integer = selectedDate.DayOfWeek
        currentWeekStartDate = selectedDate.AddDays(-diff)

        UpdateWeekLabel()
        LoadData()
    End Sub

    ' --- REFRESH BUTTON ---
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
        LoadProducts()
        CheckLowStockItems()

        ' Clear search
        txtSearch.Text = "Search products..."
        txtSearch.ForeColor = Color.Gray

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
        Dim endOfWeek = currentWeekStartDate.AddDays(6)
        Label13.Text = currentWeekStartDate.ToString("MMM dd") & " - " & endOfWeek.ToString("MMM dd, yyyy")
    End Sub

    Private Sub LoadData()
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
                Dim headers = From col As DataGridViewColumn In dgvProducts.Columns.Cast(Of DataGridViewColumn)()
                              Select col.HeaderText
                sb.AppendLine(String.Join(",", headers))

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

            ClearInputFields()
            LoadProducts()
            CheckLowStockItems()

            ' Clear search
            txtSearch.Text = "Search products..."
            txtSearch.ForeColor = Color.Gray

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

                Dim selectQuery As String = "SELECT ProductCode, ProductName, Category, Price, Stock FROM Products ORDER BY ProductCode"
                Dim dataAdapter As New SQLiteDataAdapter(selectQuery, connection)
                allProductsDataTable = New DataTable()

                dataAdapter.Fill(allProductsDataTable)

                ' Store in global variable and bind
                dgvProducts.DataSource = allProductsDataTable

                ' Apply formatting
                ApplyColumnFormatting()

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

    ' Double-click on DataGridView row to load data into textboxes
    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProducts.Rows.Count Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            txtProductCode.Text = row.Cells("ProductCode").Value.ToString()
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = If(row.Cells("Category").Value Is DBNull.Value, "", row.Cells("Category").Value.ToString())

            Dim priceValue As Object = row.Cells("Price").Value
            If priceValue IsNot Nothing AndAlso priceValue IsNot DBNull.Value Then
                txtPrice.Text = Convert.ToDecimal(priceValue).ToString("0.00")
            Else
                txtPrice.Clear()
            End If

            txtStock.Text = row.Cells("Stock").Value.ToString()

            dgvProducts.ClearSelection()
            row.Selected = True
            txtProductCode.Focus()

            Dim stock As Integer = Convert.ToInt32(row.Cells("Stock").Value)
            If stock <= STOCK_WARNING_THRESHOLD Then
                MessageBox.Show(GetStockTooltip(stock), "Stock Alert",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ' Prevent cell editing
    Private Sub dgvProducts_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvProducts.CellBeginEdit
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
                        CheckLowStockItems()

                        ' Clear search
                        txtSearch.Text = "Search products..."
                        txtSearch.ForeColor = Color.Gray
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
                        CheckLowStockItems()

                        ' Clear search
                        txtSearch.Text = "Search products..."
                        txtSearch.ForeColor = Color.Gray
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
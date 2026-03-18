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

    ' Shopping cart DataTable
    Private cartDataTable As DataTable
    Private cartTotal As Decimal = 0

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

        ' Initialize shopping cart
        InitializeCart()

        ' Configure DataGridView to be read-only
        ConfigureDataGridView()
        ConfigureCartGridView()

        ' Check for low stock items on form load
        CheckLowStockItems()

        ' Configure search textbox
        ConfigureSearchBox()

        ' Initialize totals
        UpdateCartTotals()
    End Sub

    ' --- INITIALIZE SHOPPING CART ---
    Private Sub InitializeCart()
        cartDataTable = New DataTable()
        cartDataTable.Columns.Add("ProductCode", Type.GetType("System.String"))
        cartDataTable.Columns.Add("ProductName", Type.GetType("System.String"))
        cartDataTable.Columns.Add("Price", Type.GetType("System.Decimal"))
        cartDataTable.Columns.Add("Quantity", Type.GetType("System.Int32"))
        cartDataTable.Columns.Add("Subtotal", Type.GetType("System.Decimal"))

        ' Bind to cart DataGridView
        If dgvCart IsNot Nothing Then
            dgvCart.DataSource = cartDataTable
        End If
    End Sub

    ' --- CONFIGURE CART DATAGRIDVIEW ---
    Private Sub ConfigureCartGridView()
        If dgvCart Is Nothing Then Return

        With dgvCart
            .ReadOnly = False ' Allow quantity editing
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D

            ' Configure columns
            If .Columns.Count > 0 Then
                .Columns("ProductCode").HeaderText = "Code"
                .Columns("ProductCode").ReadOnly = True
                .Columns("ProductCode").Width = 80

                .Columns("ProductName").HeaderText = "Product Name"
                .Columns("ProductName").ReadOnly = True
                .Columns("ProductName").Width = 200

                .Columns("Price").HeaderText = "Price"
                .Columns("Price").ReadOnly = True
                .Columns("Price").DefaultCellStyle.Format = "C2"
                .Columns("Price").DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("en-PH")
                .Columns("Price").Width = 80

                .Columns("Quantity").HeaderText = "Qty"
                .Columns("Quantity").Width = 60

                .Columns("Subtotal").HeaderText = "Subtotal"
                .Columns("Subtotal").ReadOnly = True
                .Columns("Subtotal").DefaultCellStyle.Format = "C2"
                .Columns("Subtotal").DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("en-PH")
                .Columns("Subtotal").Width = 100
            End If

            ' Handle cell value changes for quantity updates
            AddHandler .CellValueChanged, AddressOf dgvCart_CellValueChanged
            AddHandler .UserDeletedRow, AddressOf dgvCart_UserDeletedRow
        End With
    End Sub

    ' --- CART CELL VALUE CHANGED ---
    Private Sub dgvCart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvCart.Columns("Quantity").Index Then
            UpdateCartItemSubtotal(e.RowIndex)
            UpdateCartTotals()
        End If
    End Sub

    ' --- CART ROW DELETED ---
    Private Sub dgvCart_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs)
        UpdateCartTotals()
    End Sub

    ' --- UPDATE CART ITEM SUBTOTAL ---
    Private Sub UpdateCartItemSubtotal(rowIndex As Integer)
        Try
            Dim row As DataRowView = DirectCast(dgvCart.Rows(rowIndex).DataBoundItem, DataRowView)
            Dim price As Decimal = Convert.ToDecimal(row("Price"))
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

            ' Validate quantity
            If quantity <= 0 Then
                quantity = 1
                row("Quantity") = 1
            End If

            ' Check stock availability
            Dim availableStock As Integer = GetProductStock(row("ProductCode").ToString())
            If quantity > availableStock Then
                MessageBox.Show($"Only {availableStock} item(s) available in stock!", "Stock Limit",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
                quantity = availableStock
                row("Quantity") = availableStock
            End If

            row("Subtotal") = price * quantity
        Catch ex As Exception
            ' Handle error silently
        End Try
    End Sub

    ' --- GET PRODUCT STOCK ---
    Private Function GetProductStock(productCode As String) As Integer
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Stock FROM Products WHERE ProductCode = @code"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@code", productCode)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking stock: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    ' --- UPDATE CART TOTALS ---
    Private Sub UpdateCartTotals()
        Dim subtotal As Decimal = 0

        If cartDataTable IsNot Nothing Then
            For Each row As DataRowView In cartDataTable.DefaultView
                subtotal += Convert.ToDecimal(row("Subtotal"))
            Next
        End If

        cartTotal = subtotal

        ' Update labels
        If lblSubtotal IsNot Nothing Then
            lblSubtotal.Text = subtotal.ToString("C2", New Globalization.CultureInfo("en-PH"))
        End If

        If lblTotal IsNot Nothing Then
            lblTotal.Text = subtotal.ToString("C2", New Globalization.CultureInfo("en-PH"))
        End If

        ' Enable/disable checkout button based on cart items
        btnCheckout.Enabled = (cartDataTable IsNot Nothing AndAlso
                               cartDataTable.Rows.Count > 0) AndAlso
                               Not String.IsNullOrWhiteSpace(txtBuyerName?.Text)
    End Sub

    ' --- ADD TO CART BUTTON ---
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to add to cart.", "No Product Selected",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
        Dim productCode As String = selectedRow.Cells("ProductCode").Value.ToString()
        Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
        Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("Price").Value)
        Dim availableStock As Integer = Convert.ToInt32(selectedRow.Cells("Stock").Value)

        ' Check if product already in cart
        Dim existingRow As DataRowView = FindProductInCart(productCode)

        If existingRow IsNot Nothing Then
            ' Update quantity
            Dim newQuantity As Integer = Convert.ToInt32(existingRow("Quantity")) + 1
            If newQuantity <= availableStock Then
                existingRow("Quantity") = newQuantity
                existingRow("Subtotal") = price * newQuantity
            Else
                MessageBox.Show($"Cannot add more. Only {availableStock} available in stock!",
                              "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            ' Add new row
            Dim newRow As DataRowView = cartDataTable.DefaultView.AddNew()
            newRow("ProductCode") = productCode
            newRow("ProductName") = productName
            newRow("Price") = price
            newRow("Quantity") = 1
            newRow("Subtotal") = price
            newRow.EndEdit()
        End If

        UpdateCartTotals()
    End Sub

    ' --- FIND PRODUCT IN CART ---
    Private Function FindProductInCart(productCode As String) As DataRowView
        If cartDataTable Is Nothing Then Return Nothing

        For Each row As DataRowView In cartDataTable.DefaultView
            If row("ProductCode").ToString() = productCode Then
                Return row
            End If
        Next
        Return Nothing
    End Function

    ' --- CHECKOUT BUTTON ---
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Validate buyer name
        If String.IsNullOrWhiteSpace(txtBuyerName.Text) Then
            MessageBox.Show("Please enter buyer name.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBuyerName.Focus()
            Return
        End If

        ' Validate cart has items
        If cartDataTable.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items to checkout.", "Empty Cart",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Show confirmation dialog
        Dim confirmMessage As String = $"Buyer: {txtBuyerName.Text.Trim()}{vbCrLf}" &
                                      $"Total Amount: {lblTotal.Text}{vbCrLf}{vbCrLf}" &
                                      $"Proceed with checkout?"

        If MessageBox.Show(confirmMessage, "Confirm Checkout",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ProcessCheckout()
        End If
    End Sub

    ' --- PROCESS CHECKOUT ---
    Private Sub ProcessCheckout()
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using transaction As SQLiteTransaction = connection.BeginTransaction()
                    Try
                        ' Update stock for each item in cart
                        For Each row As DataRowView In cartDataTable.DefaultView
                            Dim productCode As String = row("ProductCode").ToString()
                            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

                            ' Update stock in database
                            Dim updateQuery As String = "UPDATE Products SET Stock = Stock - @qty WHERE ProductCode = @code AND Stock >= @qty"
                            Using command As New SQLiteCommand(updateQuery, connection, transaction)
                                command.Parameters.AddWithValue("@qty", quantity)
                                command.Parameters.AddWithValue("@code", productCode)

                                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                                If rowsAffected = 0 Then
                                    Throw New Exception($"Insufficient stock for product: {productCode}")
                                End If
                            End Using
                        Next

                        ' Here you would typically save the transaction record
                        ' SaveTransaction(txtBuyerName.Text, cartTotal, cartDataTable)

                        transaction.Commit()

                        ' Show receipt/summary
                        ShowReceipt()

                        ' Clear cart and buyer name
                        ClearCart()
                        txtBuyerName.Clear()

                        ' Refresh product list to show updated stock
                        LoadProducts()

                        MessageBox.Show("Checkout completed successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error processing checkout: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- SHOW RECEIPT ---
    Private Sub ShowReceipt()
        Dim receipt As New StringBuilder()
        receipt.AppendLine("=" & StrDup(40, "=") & "=")
        receipt.AppendLine("           SALES RECEIPT")
        receipt.AppendLine("=" & StrDup(40, "=") & "=")
        receipt.AppendLine($"Date: {DateTime.Now:MMMM dd, yyyy}")
        receipt.AppendLine($"Time: {DateTime.Now:hh:mm:ss tt}")
        receipt.AppendLine($"Buyer: {txtBuyerName.Text.Trim()}")
        receipt.AppendLine("-" & StrDup(40, "-"))
        receipt.AppendLine("Qty  Description           Amount")
        receipt.AppendLine("-" & StrDup(40, "-"))

        For Each row As DataRowView In cartDataTable.DefaultView
            Dim qty As Integer = Convert.ToInt32(row("Quantity"))
            Dim name As String = row("ProductName").ToString()
            Dim subtotal As Decimal = Convert.ToDecimal(row("Subtotal"))

            ' Truncate name if too long
            If name.Length > 20 Then
                name = name.Substring(0, 17) + "..."
            End If

            receipt.AppendLine($"{qty,-4} {name,-20} {subtotal,10:C2}")
        Next

        receipt.AppendLine("-" & StrDup(40, "-"))
        receipt.AppendLine($"{"SUBTOTAL:",-25} {cartTotal,15:C2}")
        receipt.AppendLine($"{"TOTAL:",-25} {cartTotal,15:C2}")
        receipt.AppendLine("=" & StrDup(40, "=") & "=")
        receipt.AppendLine("      THANK YOU FOR SHOPPING!")
        receipt.AppendLine("=" & StrDup(40, "=") & "=")

        MessageBox.Show(receipt.ToString(), "Sales Receipt",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- CLEAR CART ---
    Private Sub ClearCart()
        If cartDataTable IsNot Nothing Then
            cartDataTable.Clear()
        End If
        UpdateCartTotals()
    End Sub

    ' --- CLEAR CART BUTTON ---
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        If cartDataTable IsNot Nothing AndAlso cartDataTable.Rows.Count > 0 Then
            If MessageBox.Show("Clear all items from cart?", "Confirm Clear",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ClearCart()
            End If
        End If
    End Sub

    ' --- BUYER NAME TEXT CHANGED ---
    Private Sub txtBuyerName_TextChanged(sender As Object, e As EventArgs) Handles txtBuyerName.TextChanged
        ' Enable/disable checkout button based on buyer name and cart items
        btnCheckout.Enabled = (cartDataTable IsNot Nothing AndAlso
                               cartDataTable.Rows.Count > 0) AndAlso
                               Not String.IsNullOrWhiteSpace(txtBuyerName.Text)
    End Sub

    ' --- REMOVE FROM CART BUTTON ---
    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvCart.SelectedRows(0)
            If Not selectedRow.IsNewRow Then
                Dim rowView As DataRowView = DirectCast(selectedRow.DataBoundItem, DataRowView)
                rowView.Delete()
                UpdateCartTotals()
            End If
        Else
            MessageBox.Show("Please select an item to remove from cart.", "No Item Selected",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' --- CONFIGURE SEARCH TEXTBOX ---
    Private Sub ConfigureSearchBox()
        If txtSearch Is Nothing Then Return

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
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
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

        Catch ex As Exception
            ' Silent fail for search
            Console.WriteLine("Search error: " & ex.Message)
        End Try
    End Sub

    ' --- APPLY COLUMN FORMATTING AFTER FILTER ---
    Private Sub ApplyColumnFormatting()
        If dgvProducts Is Nothing OrElse dgvProducts.Columns.Count = 0 Then Return

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
    End Sub

    ' --- CONFIGURE DATAGRIDVIEW ---
    Private Sub ConfigureDataGridView()
        If dgvProducts Is Nothing Then Return

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
            AddHandler .CellDoubleClick, AddressOf dgvProducts_CellDoubleClick
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
        ' You can add a label for stock status if needed
        Console.WriteLine($"Stock Status - Out: {outCount}, Critical: {criticalCount}, Low: {lowCount}")
    End Sub

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
        ' Update time label if it exists
        If HasControl("lblTime") Then
            CType(Controls("lblTime"), Label).Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt")
        End If
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
        If txtSearch IsNot Nothing Then
            txtSearch.Text = "Search products..."
            txtSearch.ForeColor = Color.Gray
        End If

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
        If HasControl("Label13") Then
            Dim endOfWeek = currentWeekStartDate.AddDays(6)
            CType(Controls("Label13"), Label).Text = currentWeekStartDate.ToString("MMM dd") & " - " & endOfWeek.ToString("MMM dd, yyyy")
        End If
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
            If txtSearch IsNot Nothing Then
                txtSearch.Text = "Search products..."
                txtSearch.ForeColor = Color.Gray
            End If

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
                If dgvProducts IsNot Nothing Then
                    dgvProducts.DataSource = allProductsDataTable

                    ' Apply formatting
                    ApplyColumnFormatting()

                    ' Auto-size columns
                    dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

                    ' Re-apply grid configuration
                    ConfigureDataGridView()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear input fields
    Private Sub ClearInputFields()
        If txtProductCode IsNot Nothing Then txtProductCode.Clear()
        If txtProductName IsNot Nothing Then txtProductName.Clear()
        If txtCategory IsNot Nothing Then txtCategory.Clear()
        If txtPrice IsNot Nothing Then txtPrice.Clear()
        If txtStock IsNot Nothing Then txtStock.Clear()
        If txtProductCode IsNot Nothing Then txtProductCode.Focus()
    End Sub

    ' Double-click on DataGridView row to load data into textboxes
    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProducts.Rows.Count Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            If txtProductCode IsNot Nothing Then
                txtProductCode.Text = row.Cells("ProductCode").Value.ToString()
            End If

            If txtProductName IsNot Nothing Then
                txtProductName.Text = row.Cells("ProductName").Value.ToString()
            End If

            If txtCategory IsNot Nothing Then
                txtCategory.Text = If(row.Cells("Category").Value Is DBNull.Value, "", row.Cells("Category").Value.ToString())
            End If

            Dim priceValue As Object = row.Cells("Price").Value
            If priceValue IsNot Nothing AndAlso priceValue IsNot DBNull.Value Then
                If txtPrice IsNot Nothing Then
                    txtPrice.Text = Convert.ToDecimal(priceValue).ToString("0.00")
                End If
            Else
                If txtPrice IsNot Nothing Then txtPrice.Clear()
            End If

            If txtStock IsNot Nothing Then
                txtStock.Text = row.Cells("Stock").Value.ToString()
            End If

            dgvProducts.ClearSelection()
            row.Selected = True

            If txtProductCode IsNot Nothing Then
                txtProductCode.Focus()
            End If

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
        If txtProductCode Is Nothing OrElse String.IsNullOrWhiteSpace(txtProductCode.Text) Then
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
                        If txtSearch IsNot Nothing Then
                            txtSearch.Text = "Search products..."
                            txtSearch.ForeColor = Color.Gray
                        End If
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
        If (txtProductCode Is Nothing OrElse String.IsNullOrWhiteSpace(txtProductCode.Text)) AndAlso dgvProducts.SelectedRows.Count = 0 Then
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
                        If txtSearch IsNot Nothing Then
                            txtSearch.Text = "Search products..."
                            txtSearch.ForeColor = Color.Gray
                        End If
                    Else
                        MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper method to check if control exists
    Private Function HasControl(controlName As String) As Boolean
        For Each ctrl As Control In Me.Controls
            If ctrl.Name = controlName Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class
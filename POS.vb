Imports System.Data.SQLite
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text

Public Class frmPOS

    ' Global variable para sa tracking
    Private currentWeekStartDate As DateTime

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
        LoadData()
    End Sub

    ' --- TIMER LOGIC ---
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt")
    End Sub

    ' --- DATETIMEPICKER LOGIC ---
    ' Kapag binago mo ang date sa picker, mag-uupdate dapat ang report
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
        MessageBox.Show("Report Refreshed!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- NAVIGATION BUTTONS ---

    Private Sub btnPreviousWeek_Click(sender As Object, e As EventArgs) Handles btnPreviousWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(-7)
        DateTimePicker1.Value = currentWeekStartDate ' Ito ang magti-trigger ng ValueChanged
    End Sub

    Private Sub btnNextWeek_Click(sender As Object, e As EventArgs) Handles btnNextWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(7)
        DateTimePicker1.Value = currentWeekStartDate ' Ito ang magti-trigger ng ValueChanged
    End Sub

    ' --- HELPER METHODS ---

    Private Sub UpdateWeekLabel()
        ' I-update ang label (halimbawa: Label13 o yung text na "UpdateWeekLabel" sa screenshot)
        Dim endOfWeek = currentWeekStartDate.AddDays(6)
        Label13.Text = currentWeekStartDate.ToString("MMM dd") & " - " & endOfWeek.ToString("MMM dd, yyyy")
    End Sub

    Private Sub LoadData()
        ' Dito papasok ang logic para i-filter ang Data sa Revenue Summary at Sales Performance
        ' Gamitin ang currentWeekStartDate para sa SQL query
        Console.WriteLine("Fetching sales from " & currentWeekStartDate.ToShortDateString())
    End Sub

    ' --- EXPORT CSV BUTTON (mula sa naunang usapan) ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.FileName = "Weekly_Sales_" & currentWeekStartDate.ToString("yyyyMMdd") & ".csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New StringBuilder()
                ' Headers
                Dim headers = From col As DataGridViewColumn In dv.Columns.Cast(Of DataGridViewColumn)()
                              Select col.HeaderText
                sb.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dv.Rows
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
    Public Class YourFormName
        ' Database connection string
        Private connectionString As String = "Data Source=products.db;Version=3;"

        Private Sub YourFormName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Create database and table if not exists
            CreateDatabase()
            ' Load existing data
            LoadProducts()
        End Sub

        ' Create database and table
        Private Sub CreateDatabase()
            Try
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()

                    ' Create table if not exists
                    Dim createTableQuery As String = "
                CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductCode TEXT NOT NULL UNIQUE,
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

            Catch ex As SQLiteException When ex.Message.Contains("UNIQUE")
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

                    Dim selectQuery As String = "SELECT Id, ProductCode, ProductName, Category, Price, Stock FROM Products ORDER BY Id DESC"
                    Dim dataAdapter As New SQLiteDataAdapter(selectQuery, connection)
                    Dim dataTable As New DataTable()

                    dataAdapter.Fill(dataTable)

                    ' Bind to DataGridView
                    dgvProducts.DataSource = dataTable

                    ' Optional: Configure column headers
                    If dgvProducts.Columns.Count > 0 Then
                        dgvProducts.Columns("Id").HeaderText = "ID"
                        dgvProducts.Columns("ProductCode").HeaderText = "Product Code"
                        dgvProducts.Columns("ProductName").HeaderText = "Product Name"
                        dgvProducts.Columns("Category").HeaderText = "Category"
                        dgvProducts.Columns("Price").HeaderText = "Price"
                        dgvProducts.Columns("Stock").HeaderText = "Stock"
                    End If

                    ' Auto-size columns
                    dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
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

        ' Optional: Double-click on DataGridView row to load data into textboxes for editing
        Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
                txtProductCode.Text = row.Cells("ProductCode").Value.ToString()
                txtProductName.Text = row.Cells("ProductName").Value.ToString()
                txtCategory.Text = If(row.Cells("Category").Value Is DBNull.Value, "", row.Cells("Category").Value.ToString())
                txtPrice.Text = row.Cells("Price").Value.ToString()
                txtStock.Text = row.Cells("Stock").Value.ToString()
            End If
        End Sub

        ' Optional: Update button if you want to add update functionality
        Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
            ' Similar to Add but with UPDATE query - you'll need to track selected ID
            MessageBox.Show("Update functionality - you need to track the selected product ID")
        End Sub

        ' Optional: Delete button
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If dgvProducts.SelectedRows.Count > 0 Then
                If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim productId As Integer = Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("Id").Value)
                    DeleteProduct(productId)
                End If
            Else
                MessageBox.Show("Please select a product to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        ' Delete product from database
        Private Sub DeleteProduct(productId As Integer)
            Try
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()
                    Dim deleteQuery As String = "DELETE FROM Products WHERE Id = @id"
                    Using command As New SQLiteCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@id", productId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProducts() ' Refresh the grid
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

End Class
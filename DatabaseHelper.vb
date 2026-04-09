Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text
Imports draft_innova_tech.frmdashboard

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New()
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Accounts.db")
        connectionString = $"Data Source={databasePath};Version=3;"
    End Sub

    ' --- Initialize Database ---
    Public Sub InitializeDatabase()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                ' 1. --- Create Users table ---
                Dim createUsers As String = "
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    Role TEXT DEFAULT 'Staff',
                    IsActive BOOLEAN DEFAULT 1,
                    LastLogin DATETIME,
                    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
                )"
                Using cmd As New SQLiteCommand(createUsers, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' 2. --- SEED DEFAULT ADMIN ACCOUNT ---
                ' Check if any user exists. If not, create the default admin.
                Dim checkUserQuery As String = "SELECT COUNT(*) FROM Users"
                Using checkCmd As New SQLiteCommand(checkUserQuery, conn)
                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userCount = 0 Then
                        Dim insertAdmin As String = "
                        INSERT INTO Users (Username, PasswordHash, FullName, Role, IsActive) 
                        VALUES (@Username, @Hash, @Full, 'Admin', 1)"

                        Using insertCmd As New SQLiteCommand(insertAdmin, conn)
                            insertCmd.Parameters.AddWithValue("@Username", "admin")
                            ' Standard password is 'admin123' - change this after first login!
                            insertCmd.Parameters.AddWithValue("@Hash", HashPassword("admin123"))
                            insertCmd.Parameters.AddWithValue("@Full", "System Administrator")
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                ' 3. --- Create Products table ---
                Dim createProducts As String = "
                CREATE TABLE IF NOT EXISTS Products (
                    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductCode TEXT UNIQUE NOT NULL,
                    ProductName TEXT NOT NULL,
                    Category TEXT,
                    Price REAL NOT NULL,
                    Stock INTEGER NOT NULL
                )"
                Using cmd As New SQLiteCommand(createProducts, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' 4. --- Create Sales table ---

                Dim createSales As String = "
CREATE TABLE IF NOT EXISTS Sales (
    SaleID INTEGER PRIMARY KEY AUTOINCREMENT,
    BuyerName TEXT,
    BuyerAddress TEXT,
    BuyerContact TEXT,
    ItemBought TEXT,   -- <--- ADD THIS LINE
    Subtotal REAL,
    Total REAL,
    ProcessedBy TEXT,
    SaleDate DATETIME DEFAULT CURRENT_TIMESTAMP
)"
                Using cmd As New SQLiteCommand(createSales, conn)
                    cmd.ExecuteNonQuery()
                End Using
                ' Add this inside InitializeDatabase, after creating the Sales table
                Dim addColumnQuery As String = "ALTER TABLE Sales ADD COLUMN ItemBought TEXT;"
                Try
                    Using cmd As New SQLiteCommand(addColumnQuery, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch
                    ' Column likely already exists, ignore error
                End Try
                ' 5. --- Create SystemSettings table for images/logos ---
                Dim createSettings As String = "
CREATE TABLE IF NOT EXISTS SystemSettings (
    SettingID INTEGER PRIMARY KEY AUTOINCREMENT,
    SettingName TEXT UNIQUE NOT NULL,
    SettingValue BLOB
)"
                Using cmd As New SQLiteCommand(createSettings, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Inside InitializeDatabase(), right before the final End Sub
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim createInventoryLogs As String = "
        CREATE TABLE IF NOT EXISTS InventoryLogs (
            LogID INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT NOT NULL,
            Action TEXT NOT NULL,
            Details TEXT NOT NULL,
            LogDate DATETIME DEFAULT CURRENT_TIMESTAMP
        )"
                Using cmd As New SQLiteCommand(createInventoryLogs, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle log table creation error
        End Try
    End Sub

    ' --- USER METHODS ---
    Public Function RegisterUser(username As String, password As String, fullName As String, role As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role) VALUES (@Username, @Hash, @Full, @Role)"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Hash", HashPassword(password))
                    cmd.Parameters.AddWithValue("@Full", fullName)
                    cmd.Parameters.AddWithValue("@Role", role)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As SQLiteException When ex.ErrorCode = SQLiteErrorCode.Constraint
            MessageBox.Show("Username already exists. Please choose another.", "Registration Error")
            Return False
        Catch ex As Exception
            MessageBox.Show($"Registration Error: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function ValidateUser(username As String, password As String) As DataTable
        Dim result As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT UserID, Username, FullName, Role FROM Users 
                                       WHERE Username = @Username AND PasswordHash = @PasswordHash AND IsActive = 1"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password))
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(result)
                    End Using
                End Using
                If result.Rows.Count > 0 Then UpdateLastLogin(username)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Login error: {ex.Message}")
        End Try
        Return result
    End Function

    Private Sub UpdateLastLogin(username As String)
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Users SET LastLogin = CURRENT_TIMESTAMP WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
            ' ignore errors silently
        End Try
    End Sub

    Private Shared Function HashPassword(password As String) As String
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hashBytes As Byte() = SHA256.HashData(passwordBytes)
        Return Convert.ToBase64String(hashBytes)
    End Function

    ' --- PRODUCT METHODS ---
    Public Function SaveProduct(prod As Product) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Products (ProductCode, ProductName, Category, Price, Stock) 
                                       VALUES (@Code, @Name, @Category, @Price, @Stock)"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", prod.Code)
                    cmd.Parameters.AddWithValue("@Name", prod.Name)
                    cmd.Parameters.AddWithValue("@Category", prod.Category)
                    cmd.Parameters.AddWithValue("@Price", prod.Price)
                    cmd.Parameters.AddWithValue("@Stock", prod.Stock)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UpdateProduct(prod As Product) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Products 
                                       SET ProductName=@Name, Category=@Category, Price=@Price, Stock=@Stock 
                                       WHERE ProductCode=@Code"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", prod.Code)
                    cmd.Parameters.AddWithValue("@Name", prod.Name)
                    cmd.Parameters.AddWithValue("@Category", prod.Category)
                    cmd.Parameters.AddWithValue("@Price", prod.Price)
                    cmd.Parameters.AddWithValue("@Stock", prod.Stock)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function LoadProducts() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProductCode, ProductName, Category, Price, Stock FROM Products"
                Using da As New SQLiteDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' --- STOCK METHODS ---
    Public Function DecreaseStock(productCode As String, quantity As Integer) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Products 
                                   SET Stock = Stock - @Qty 
                                   WHERE ProductCode = @Code AND Stock >= @Qty"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Qty", quantity)
                    cmd.Parameters.AddWithValue("@Code", productCode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error decreasing stock: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UpdateStock(productCode As String, quantity As Integer) As Boolean
        Try
            ' Stock = Stock - @Qty performs the subtraction in the database
            Dim query As String = "UPDATE Products SET Stock = Stock - @Qty WHERE ProductCode = @Code AND Stock >= @Qty"

            Using conn As New SQLiteConnection(connectionString) ' Or MySqlConnection
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Qty", quantity)
                    cmd.Parameters.AddWithValue("@Code", productCode)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' If 0 rows affected, it means the ProductCode wasn't found 
                    ' OR there wasn't enough stock to subtract (Stock >= @Qty failed)
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- SALES METHODS ---
    Public Function SaveSale(buyerName As String, buyerAddress As String, buyerContact As String, itemBought As String, subtotal As Decimal, total As Decimal) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' Added ItemBought to the INSERT query
                Dim query As String = "INSERT INTO Sales (BuyerName, BuyerAddress, BuyerContact, ItemBought, Subtotal, Total, ProcessedBy) " &
                                  "VALUES (@Name, @Address, @Contact, @Item, @Subtotal, @Total, @ProcessedBy)"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", buyerName)
                    cmd.Parameters.AddWithValue("@Address", buyerAddress)
                    cmd.Parameters.AddWithValue("@Contact", buyerContact)
                    cmd.Parameters.AddWithValue("@Item", itemBought) ' <--- NEW PARAMETER
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    cmd.Parameters.AddWithValue("@Total", total)
                    cmd.Parameters.AddWithValue("@ProcessedBy", GlobalData.CurrentUser)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving sale: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function LoadSales() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' Removed the WHERE clause here because this is for the initial load
                Dim query As String = "SELECT SaleID, BuyerName, ItemBought, Total, SaleDate FROM Sales ORDER BY SaleDate DESC"
                Using da As New SQLiteDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function DeleteProduct(productCode As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM Products WHERE ProductCode = @Code"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", productCode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' --- DASHBOARD STATS METHODS ---

    Public Function GetTotalProductsCount() As Integer
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT COUNT(*) FROM Products", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GetTotalItemsInStock() As Integer
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT SUM(Stock) FROM Products", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToInt32(result))
        End Using
    End Function

    Public Function GetTodaySales() As Decimal
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            ' Matches sales where the Date is Today
            Dim cmd As New SQLiteCommand("SELECT SUM(Total) FROM Sales WHERE date(SaleDate) = date('now')", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToDecimal(result))
        End Using
    End Function

    Public Function GetWeeklyRevenue() As Decimal
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            ' Calculates sum of Total for the last 7 days
            Dim cmd As New SQLiteCommand("SELECT SUM(Total) FROM Sales WHERE SaleDate >= date('now', '-7 days')", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToDecimal(result))
        End Using
    End Function
    ' --- INVENTORY INSIGHTS DATA METHODS ---

    Public Function GetLowStockItems(limit As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            ' Get items that are low but not out of stock
            Dim query As String = "SELECT ProductName, Stock FROM Products WHERE Stock > 0 AND Stock <= @Limit ORDER BY Stock ASC"
            Using da As New SQLiteDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@Limit", limit)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetOutOfStockCount() As Integer
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT COUNT(*) FROM Products WHERE Stock <= 0", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' Placeholder: This would usually query a "SalesDetails" table linked to Products
    Public Function GetTopSellingPlaceholder() As String
        Return "No sales data for this week"
    End Function
    ' Add this to DatabaseHelper.vb
    Public Function SearchSales(searchTerm As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' Added ItemBought to the selection so it matches LoadSales
                Dim query As String = "SELECT SaleID, BuyerName, ItemBought, Total, SaleDate " &
                                 "FROM Sales WHERE BuyerName LIKE @Search " &
                                 "OR ItemBought LIKE @Search " &
                                 "OR SaleID LIKE @Search " &
                                 "ORDER BY SaleDate DESC"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & searchTerm & "%")
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search Error: " & ex.Message)
        End Try
        Return dt
    End Function
    ' --- NEW USER MANAGEMENT METHODS ---

    ' Get all users for the management grid
    Public Function GetAllUsers() As DataTable
        Dim dt As New DataTable()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            ' We don't select PasswordHash for security
            Dim query As String = "SELECT UserID, Username, FullName, Role, IsActive, LastLogin FROM Users"
            Using da As New SQLiteDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' Get activity for a specific staff member (Sales they processed)
    Public Function GetUserActivity(username As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' Added ItemBought to the SELECT statement
                Dim query As String = "SELECT SaleID, ItemBought, Total, SaleDate FROM Sales WHERE ProcessedBy = @User ORDER BY SaleDate DESC"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@User", username)
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching staff activity: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Update User Status (Activate/Deactivate)
    Public Function UpdateUserStatus(userId As Integer, isActive As Boolean) As Boolean
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE Users SET IsActive = @Active WHERE UserID = @ID"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Active", If(isActive, 1, 0))
                cmd.Parameters.AddWithValue("@ID", userId)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    ' --- IMAGE / LOGO METHODS ---

    ' Save an Image to the database as a BLOB
    Public Function SaveSystemImage(imageName As String, img As Image) As Boolean
        Try
            Using ms As New IO.MemoryStream()
                ' Save image to stream in PNG format (best for logos)
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Dim byteImage As Byte() = ms.ToArray()

                Using conn As New SQLiteConnection(connectionString)
                    conn.Open()
                    ' INSERT OR REPLACE handles updating the existing logo
                    Dim query As String = "INSERT OR REPLACE INTO SystemSettings (SettingName, SettingValue) VALUES (@Name, @Value)"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Name", imageName)
                        cmd.Parameters.AddWithValue("@Value", byteImage)
                        Return cmd.ExecuteNonQuery() > 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving image: " & ex.Message)
            Return False
        End Try
    End Function

    ' Load an Image from the database
    Public Function LoadSystemImage(imageName As String) As Image
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SettingValue FROM SystemSettings WHERE SettingName = @Name"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", imageName)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim imgBytes As Byte() = DirectCast(result, Byte())
                        Using ms As New IO.MemoryStream(imgBytes)
                            ' Return a copy of the image to avoid stream-locking errors
                            Return Image.FromStream(ms)
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error loading image: " & ex.Message)
        End Try
        Return Nothing ' Return nothing if no image is found
    End Function
    ' --- 1. THE LOG WRITER (Use this in Inventory/POS forms) ---
    Public Function LogInventoryChange(user As String, action As String, details As String) As Boolean
        Try
            Dim query As String = "INSERT INTO InventoryLogs (Username, Action, Details, LogDate) VALUES (@User, @Act, @Det, @Date)"

            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, conn)
                    ' Bind the values to the @parameters
                    cmd.Parameters.AddWithValue("@User", user)
                    cmd.Parameters.AddWithValue("@Act", action)
                    cmd.Parameters.AddWithValue("@Det", details)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now) ' Records the current time

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            ' You can log the error to the console for debugging
            Console.WriteLine("Logging Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- 2. THE LOG READER (Used in your User form to show the list) ---
    Public Function GetInventoryLogs() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                ' DESC means newest logs appear at the top
                Dim query As String = "SELECT * FROM InventoryLogs ORDER BY LogDate DESC LIMIT 100"
                Using da As New SQLiteDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Fetch Error: " & ex.Message)
        End Try
        Return dt
    End Function
End Class

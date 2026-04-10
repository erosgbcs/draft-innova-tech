Imports Microsoft.Data.Sqlite
Imports System.Data
Imports System.Drawing
Imports System.Security.Cryptography
Imports System.Text
Imports draft_innova_tech.frmdashboard

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New()
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Accounts.db")
        connectionString = $"Data Source={databasePath};"
    End Sub

    ' --- Initialize Database ---
    Public Sub InitializeDatabase()
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()

                ' 1. Users Table
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
                ExecuteSimpleQuery(createUsers, conn)

                ' 2. Seed Admin
                SeedAdmin(conn)

                ' 3. Products Table
                Dim createProducts As String = "
                    CREATE TABLE IF NOT EXISTS Products (
                        ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ProductCode TEXT UNIQUE NOT NULL,
                        ProductName TEXT NOT NULL,
                        Category TEXT,
                        Price REAL NOT NULL,
                        Stock INTEGER NOT NULL
                    )"
                ExecuteSimpleQuery(createProducts, conn)

                ' 4. --- Create Sales table ---
                Try
                    ' This creates the table with all columns including ItemBought
                    Dim createSales As String = "
        CREATE TABLE IF NOT EXISTS Sales (
            SaleID INTEGER PRIMARY KEY AUTOINCREMENT,
            BuyerName TEXT,
            BuyerAddress TEXT,
            BuyerContact TEXT,
            ItemBought TEXT,   
            Subtotal REAL,
            Total REAL,
            ProcessedBy TEXT,
            SaleDate DATETIME DEFAULT CURRENT_TIMESTAMP
        )"

                    Using cmd As New SqliteCommand(createSales, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Migration check: adds ItemBought if it was missing from an older DB
                    Dim needsColumn As Boolean = True
                    Using checkCmd As New SqliteCommand("PRAGMA table_info(Sales)", conn)
                        Using reader As SqliteDataReader = checkCmd.ExecuteReader()
                            While reader.Read()
                                If reader("name").ToString().Equals("ItemBought", StringComparison.OrdinalIgnoreCase) Then
                                    needsColumn = False
                                    Exit While
                                End If
                            End While
                        End Using
                    End Using

                    If needsColumn Then
                        Using addCmd As New SqliteCommand("ALTER TABLE Sales ADD COLUMN ItemBought TEXT;", conn)
                            addCmd.ExecuteNonQuery()
                        End Using
                    End If
                Catch ex As Exception
                    Debug.WriteLine("Database Setup Error: " & ex.Message)
                End Try

                ' 5. System Settings (Logos)
                Dim createSettings As String = "
                    CREATE TABLE IF NOT EXISTS SystemSettings (
                        SettingID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SettingName TEXT UNIQUE NOT NULL,
                        SettingValue BLOB
                    )"
                ExecuteSimpleQuery(createSettings, conn)

                ' 6. Inventory Logs
                Dim createInventoryLogs As String = "
                    CREATE TABLE IF NOT EXISTS InventoryLogs (
                        LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Action TEXT NOT NULL,
                        Details TEXT NOT NULL,
                        LogDate DATETIME DEFAULT CURRENT_TIMESTAMP
                    )"
                ExecuteSimpleQuery(createInventoryLogs, conn)

                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper to reduce clutter
    Private Sub ExecuteSimpleQuery(sql As String, conn As SqliteConnection)
        Using cmd As New SqliteCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' --- USER METHODS ---
    Public Function RegisterUser(username As String, password As String, fullName As String, role As String) As Boolean
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role) VALUES (@Username, @Hash, @Full, @Role)"
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Hash", HashPassword(password))
                    cmd.Parameters.AddWithValue("@Full", fullName)
                    cmd.Parameters.AddWithValue("@Role", role)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As SqliteException When ex.SqliteErrorCode = 19 ' constraint violation
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT UserID, Username, FullName, Role FROM Users 
                                           WHERE Username = @Username AND PasswordHash = @PasswordHash AND IsActive = 1"
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password))
                    Using reader = cmd.ExecuteReader()
                        result.Load(reader)
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Users SET LastLogin = CURRENT_TIMESTAMP WHERE Username = @Username"
                Using cmd As New SqliteCommand(query, conn)
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Products (ProductCode, ProductName, Category, Price, Stock) 
                                           VALUES (@Code, @Name, @Category, @Price, @Stock)"
                Using cmd As New SqliteCommand(query, conn)
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Products 
                                           SET ProductName=@Name, Category=@Category, Price=@Price, Stock=@Stock 
                                           WHERE ProductCode=@Code"
                Using cmd As New SqliteCommand(query, conn)
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProductCode, ProductName, Category, Price, Stock FROM Products"
                Using cmd As New SqliteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Products 
                                       SET Stock = Stock - @Qty 
                                       WHERE ProductCode = @Code AND Stock >= @Qty"
                Using cmd As New SqliteCommand(query, conn)
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
            Dim query As String = "UPDATE Products SET Stock = Stock - @Qty WHERE ProductCode = @Code AND Stock >= @Qty"

            Using conn As New SqliteConnection(connectionString)
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Qty", quantity)
                    cmd.Parameters.AddWithValue("@Code", productCode)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Sales (BuyerName, BuyerAddress, BuyerContact, ItemBought, Subtotal, Total, ProcessedBy) " &
                                      "VALUES (@Name, @Address, @Contact, @Item, @Subtotal, @Total, @ProcessedBy)"

                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", buyerName)
                    cmd.Parameters.AddWithValue("@Address", buyerAddress)
                    cmd.Parameters.AddWithValue("@Contact", buyerContact)
                    cmd.Parameters.AddWithValue("@Item", itemBought)
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
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SaleID, BuyerName, BuyerContact, ItemBought, Total, SaleDate FROM Sales ORDER BY SaleDate DESC"
                Using cmd As New SqliteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function DeleteProduct(productCode As String) As Boolean
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM Products WHERE ProductCode = @Code"
                Using cmd As New SqliteCommand(query, conn)
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
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT COUNT(*) FROM Products", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GetTotalItemsInStock() As Integer
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT SUM(Stock) FROM Products", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToInt32(result))
        End Using
    End Function

    Public Function GetTodaySales() As Decimal
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT SUM(Total) FROM Sales WHERE date(SaleDate) = date('now')", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToDecimal(result))
        End Using
    End Function

    Public Function GetWeeklyRevenue() As Decimal
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT SUM(Total) FROM Sales WHERE SaleDate >= date('now', '-7 days')", conn)
            Dim result = cmd.ExecuteScalar()
            Return If(IsDBNull(result), 0, Convert.ToDecimal(result))
        End Using
    End Function

    ' --- INVENTORY INSIGHTS DATA METHODS ---
    Public Function GetLowStockItems(limit As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ProductName, Stock FROM Products WHERE Stock > 0 AND Stock <= @Limit ORDER BY Stock ASC"
            Using cmd As New SqliteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Limit", limit)
                Using reader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetOutOfStockCount() As Integer
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT COUNT(*) FROM Products WHERE Stock <= 0", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GetTopSellingPlaceholder() As String
        Return "No sales data for this week"
    End Function

    Public Function SearchSales(searchTerm As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SaleID, BuyerName, BuyerContact, ItemBought, Total, SaleDate " &
                                     "FROM Sales WHERE BuyerName LIKE @Search " &
                                     "OR BuyerContact LIKE @Search " &
                                     "OR ItemBought LIKE @Search " &
                                     "OR SaleID LIKE @Search " &
                                     "ORDER BY SaleDate DESC"
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & searchTerm & "%")
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search Error: " & ex.Message)
        End Try
        Return dt
    End Function

    ' --- NEW USER MANAGEMENT METHODS ---
    Public Function GetAllUsers() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT UserID, Username, FullName, Role, IsActive, LastLogin FROM Users"
            Using cmd As New SqliteCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetUserActivity(username As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SaleID, ItemBought, Total, SaleDate FROM Sales WHERE ProcessedBy = @User ORDER BY SaleDate DESC"
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@User", username)
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching staff activity: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function UpdateUserStatus(userId As Integer, isActive As Boolean) As Boolean
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE Users SET IsActive = @Active WHERE UserID = @ID"
            Using cmd As New SqliteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Active", If(isActive, 1, 0))
                cmd.Parameters.AddWithValue("@ID", userId)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' --- IMAGE / LOGO METHODS ---
    Public Function SaveSystemImage(imageName As String, img As Image) As Boolean
        Try
            Using ms As New IO.MemoryStream()
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Dim byteImage As Byte() = ms.ToArray()

                Using conn As New SqliteConnection(connectionString)
                    conn.Open()
                    Dim query As String = "INSERT OR REPLACE INTO SystemSettings (SettingName, SettingValue) VALUES (@Name, @Value)"
                    Using cmd As New SqliteCommand(query, conn)
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

    Public Function LoadSystemImage(imageName As String) As Image
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SettingValue FROM SystemSettings WHERE SettingName = @Name"
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", imageName)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim imgBytes As Byte() = DirectCast(result, Byte())
                        Using ms As New IO.MemoryStream(imgBytes)
                            ' Create a detached copy so the MemoryStream can be disposed safely
                            Using imgSrc As Image = Image.FromStream(ms)
                                Dim copy As New Bitmap(imgSrc)
                                Return copy
                            End Using
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error loading image: " & ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function LogInventoryChange(user As String, action As String, details As String) As Boolean
        Try
            Dim query As String = "INSERT INTO InventoryLogs (Username, Action, Details, LogDate) VALUES (@User, @Act, @Det, @Date)"
            Using conn As New SqliteConnection(connectionString)
                Using cmd As New SqliteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@User", user)
                    cmd.Parameters.AddWithValue("@Act", action)
                    cmd.Parameters.AddWithValue("@Det", details)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Logging Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetInventoryLogs() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqliteConnection(connectionString)
                Dim query As String = "SELECT * FROM InventoryLogs ORDER BY LogDate DESC LIMIT 100"
                Using cmd As New SqliteCommand(query, conn)
                    conn.Open()
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Fetch Error: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetWeeklySalesData() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT strftime('%Y-%m-%d', SaleDate) as SaleDay, SUM(Total) as DailyTotal " &
                              "FROM Sales " &
                              "WHERE SaleDate >= date('now', '-7 days') " &
                              "GROUP BY SaleDay " &
                              "ORDER BY SaleDay ASC"
        Try
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Using cmd As New SqliteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Chart Query Error: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetTopSellingProducts() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT ItemBought, COUNT(*) as SalesCount " &
                                  "FROM Sales " &
                                  "GROUP BY ItemBought " &
                                  "ORDER BY SalesCount DESC LIMIT 5"
        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Using cmd As New SqliteCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' --- Seed Admin User ---
    Private Sub SeedAdmin(conn As SqliteConnection)
        Try
            Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'"
            Dim count As Integer
            Using cmd As New SqliteCommand(checkQuery, conn)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If count = 0 Then
                Dim seedQuery As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role) 
                                           VALUES (@User, @Hash, @Full, 'Admin')"
                Using cmd As New SqliteCommand(seedQuery, conn)
                    cmd.Parameters.AddWithValue("@User", "admin")
                    cmd.Parameters.AddWithValue("@Hash", HashPassword("admin123"))
                    cmd.Parameters.AddWithValue("@Full", "System Administrator")
                    cmd.ExecuteNonQuery()
                End Using
                Debug.WriteLine("Default admin account created: admin / admin123")
            End If
        Catch ex As Exception
            Debug.WriteLine("Error seeding admin: " & ex.Message)
        End Try
    End Sub
    ' --- AUTO-BACKUP LOGIC ---
    Public Sub AutoBackup()
        Try
            Dim dbFolder As String = Application.StartupPath
            Dim backupFolder As String = IO.Path.Combine(dbFolder, "Backups")

            ' Create Backups directory if it doesn't exist
            If Not IO.Directory.Exists(backupFolder) Then
                IO.Directory.CreateDirectory(backupFolder)
            End If

            Dim sourcePath As String = IO.Path.Combine(dbFolder, "Accounts.db")
            ' Format: Backup_2026_04_11.db
            Dim fileName As String = $"Backup_{DateTime.Now:yyyy_MM_dd}.db"
            Dim destPath As String = IO.Path.Combine(backupFolder, fileName)

            ' Only copy if today's backup doesn't exist yet
            If IO.File.Exists(sourcePath) AndAlso Not IO.File.Exists(destPath) Then
                IO.File.Copy(sourcePath, destPath, True)
                Debug.WriteLine("Auto-backup successful: " & fileName)
            End If

            ' Run cleanup to remove old files
            CleanupOldBackups(backupFolder)
        Catch ex As Exception
            ' We use Debug.WriteLine so the user isn't interrupted by backup errors
            Debug.WriteLine("Auto-backup failed: " & ex.Message)
        End Try
    End Sub

    Private Sub CleanupOldBackups(backupFolder As String)
        Try
            Dim files = IO.Directory.GetFiles(backupFolder, "Backup_*.db")
            For Each file In files
                Dim fi As New IO.FileInfo(file)
                ' Keep only the last 7 days of backups
                If fi.CreationTime < DateTime.Now.AddDays(-7) Then
                    fi.Delete()
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("Cleanup failed: " & ex.Message)
        End Try
    End Sub
    Public Function RestoreDatabase(backupFilePath As String) As Boolean
        Try
            Dim dbFolder As String = Application.StartupPath
            Dim destPath As String = IO.Path.Combine(dbFolder, "Accounts.db")

            ' 1. Check if the backup file actually exists
            If Not IO.File.Exists(backupFilePath) Then Return False

            SqliteConnection.ClearAllPools()

            ' 3. Overwrite the current database with the backup
            IO.File.Copy(backupFilePath, destPath, True)

            Return True
        Catch ex As Exception
            MessageBox.Show("Restore failed: " & ex.Message)
            Return False
        End Try
    End Function
End Class
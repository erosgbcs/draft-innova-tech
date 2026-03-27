Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New()
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Accounts.db")
        connectionString = $"Data Source={databasePath};Version=3;"
    End Sub

    Public Sub InitializeDatabase()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                ' --- Users table ---
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

                ' --- Products table ---
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
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Public Function SaveProduct(prod As frmPOS.Product) As Boolean
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

    Public Function UpdateProduct(prod As frmPOS.Product) As Boolean
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
    ' --- Decrease stock when adding to cart ---
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
    ' --- Update stock after checkout ---
    Public Function UpdateStock(productCode As String, quantity As Integer) As Boolean
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
            MessageBox.Show($"Error updating stock: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


End Class

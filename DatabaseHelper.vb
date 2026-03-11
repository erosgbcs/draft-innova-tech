Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New()
        ' Database will be created in the application folder
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "POSSystem.db")
        connectionString = $"Data Source={databasePath};Version=3;"
    End Sub

    ' Initialize database and create users table
    Public Sub InitializeDatabase()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                ' Create Users table if it doesn't exist
                Dim createTableQuery As String = "
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

                Using cmd As New SQLiteCommand(createTableQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Check if admin user exists, if not create default admin
                If Not AdminUserExists() Then
                    CreateDefaultAdmin()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if admin user exists
    Private Function AdminUserExists() As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = 'Admin'"
                Using cmd As New SQLiteCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Create default admin user
    Private Sub CreateDefaultAdmin()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role) VALUES (@Username, @PasswordHash, @FullName, @Role)"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", "Admin")
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword("1")) ' Default password: 1
                    cmd.Parameters.AddWithValue("@FullName", "System Administrator")
                    cmd.Parameters.AddWithValue("@Role", "Administrator")
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error creating default admin: {ex.Message}")
        End Try
    End Sub

    ' Fixed HashPassword method - using Shared to resolve warning
    Private Shared Function HashPassword(password As String) As String
        ' Using the newer SHA256.HashData method
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hashBytes As Byte() = SHA256.HashData(passwordBytes)
        Return Convert.ToBase64String(hashBytes)
    End Function

    ' Validate user login
    Public Function ValidateUser(username As String, password As String) As DataTable
        Dim result As New DataTable()

        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                ' Query to check username and password
                Dim query As String = "SELECT UserID, Username, FullName, Role FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash AND IsActive = 1"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password))

                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(result)
                    End Using
                End Using

                ' If login successful, update LastLogin
                If result.Rows.Count > 0 Then
                    UpdateLastLogin(username)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return result
    End Function

    ' Update last login timestamp
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
        Catch ex As Exception
            ' Silently fail - not critical
        End Try
    End Sub
End Class
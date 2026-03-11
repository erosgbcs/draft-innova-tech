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

                ' If no users exist, create a default admin account
                Dim countQuery As String = "SELECT COUNT(*) FROM Users"
                Using countCmd As New SQLiteCommand(countQuery, conn)
                    Dim userCount As Integer = Convert.ToInt32(countCmd.ExecuteScalar())
                    If userCount = 0 Then
                        Dim defaultPassword As String = "admin123" ' you may change this or prompt the user
                        Dim insertQuery As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role) VALUES (@Username, @PasswordHash, @FullName, @Role)"
                        Using insertCmd As New SQLiteCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@Username", "admin")
                            insertCmd.Parameters.AddWithValue("@PasswordHash", HashPassword(defaultPassword))
                            insertCmd.Parameters.AddWithValue("@FullName", "Administrator")
                            insertCmd.Parameters.AddWithValue("@Role", "Admin")
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Static helper for hashing
    Public Shared Function HashPassword(password As String) As String
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
                Dim query As String = "SELECT UserID, Username, FullName, Role FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash AND IsActive = 1"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password))
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(result)
                    End Using
                End Using

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
        End Try
    End Sub

    ' Change password logic
    Public Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim verifyQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @OldPasswordHash"
                Using verifyCmd As New SQLiteCommand(verifyQuery, conn)
                    verifyCmd.Parameters.AddWithValue("@Username", username)
                    verifyCmd.Parameters.AddWithValue("@OldPasswordHash", HashPassword(oldPassword))
                    If Convert.ToInt32(verifyCmd.ExecuteScalar()) = 0 Then
                        MessageBox.Show("Old password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End Using

                Dim updateQuery As String = "UPDATE Users SET PasswordHash = @NewPasswordHash WHERE Username = @Username"
                Using updateCmd As New SQLiteCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@Username", username)
                    updateCmd.Parameters.AddWithValue("@NewPasswordHash", HashPassword(newPassword))
                    Return updateCmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error changing password: {ex.Message}")
            Return False
        End Try
    End Function

    ' Admin reset password
    Public Function ResetPassword(username As String, newPassword As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Users SET PasswordHash = @PasswordHash WHERE Username = @Username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(newPassword))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error resetting password: {ex.Message}")
            Return False
        End Try
    End Function
End Class
Imports System.Runtime.Versioning
Imports System.Data.SQLite

<SupportedOSPlatform("windows")>
Public Class FrmLogin
    Private dbHelper As DatabaseHelper

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c

        ' Fix button style
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0

        ' Initialize database
        dbHelper = New DatabaseHelper()
        dbHelper.InitializeDatabase()

        ' Optional: Add debug info to show database location
        ' lblDbPath.Text = "DB: " & IO.Path.Combine(Application.StartupPath, "POSSystem.db")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Validate input
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please enter username", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter password", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' Disable button to prevent multiple clicks
        btnLogin.Enabled = False
        btnLogin.Text = "Logging in..."

        ' Validate credentials against database
        Dim userData As DataTable = dbHelper.ValidateUser(username, password)

        If userData.Rows.Count > 0 Then
            ' Login successful
            Dim userRow As DataRow = userData.Rows(0)

            ' Store user info for use in other forms
            Dim currentUser As New Dictionary(Of String, Object) From {
                {"UserID", userRow("UserID")},
                {"Username", userRow("Username")},
                {"FullName", userRow("FullName")},
                {"Role", userRow("Role")}
            }

            ' You can pass this to your POS form
            ' For example, create a constructor in frmPOS that accepts user info
            Dim posForm As New frmPOS()
            ' If you want to pass user info, you can add a property to frmPOS
            ' posForm.CurrentUser = currentUser

            MessageBox.Show($"Login Successful! Welcome {userRow("FullName")}!",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Show POS form and hide login
            posForm.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password", "Login Failed",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUsername.Focus()
        End If

        ' Re-enable button
        btnLogin.Enabled = True
        btnLogin.Text = "Login"
    End Sub

    Private Sub BtnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar
            btnShowHide.Text = "🔒" ' Lock emoji when visible
        Else
            txtPassword.PasswordChar = "*"c
            btnShowHide.Text = "👁" ' Eye emoji when hidden
        End If
    End Sub

    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ' Show forgot password dialog
        Using forgotForm As New FrmForgotPassword(dbHelper)
            forgotForm.ShowDialog()
        End Using
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Handle Enter key to trigger login
    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnLogin_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
            e.Handled = True
        End If
    End Sub
End Class
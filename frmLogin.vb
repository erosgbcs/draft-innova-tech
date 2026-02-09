Public Class frmLogin
    ' Variable to track password visibility
    Private isPasswordVisible As Boolean = False

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form appearance settings
        Me.Text = "Login System"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Initialize password visibility
        UpdatePasswordVisibility()

        ' Set focus to username textbox
        txtUsername.Focus()
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        ' Toggle password visibility
        isPasswordVisible = Not isPasswordVisible
        UpdatePasswordVisibility()
    End Sub

    Private Sub UpdatePasswordVisibility()
        If isPasswordVisible Then
            txtPassword.PasswordChar = Char.MinValue ' Show password
            btnShowHide.Text = "Hide"
            btnShowHide.BackColor = Color.LightCoral
        Else
            txtPassword.PasswordChar = "●" ' Hide password
            btnShowHide.Text = "Show"
            btnShowHide.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter username", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter password", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' Here you would normally validate against database
        ' This is a simple example with hardcoded credentials
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Example validation (Replace with your actual authentication)
        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login Successful!", "Success",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Close login form and show main application form
            Me.Hide()
            Dim mainForm As New frmMain() ' Create your main form
            mainForm.Show()
        Else
            MessageBox.Show("Invalid username or password", "Login Failed",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        ' Replace this with your actual authentication logic
        ' Example: Check against database
        ' For demonstration, using hardcoded values
        Dim validUsername As String = "admin"
        Dim validPassword As String = "password123"

        ' In real application, this would connect to a database
        ' Example: 
        ' Dim query As String = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password"
        ' Using parameters to prevent SQL injection

        Return (username = validUsername AndAlso password = validPassword)
    End Function

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ' Show forgot password form or dialog
        MessageBox.Show("Please contact system administrator to reset your password." &
                       Environment.NewLine & "Email: support@innovatech.com",
                       "Forgot Password",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Alternative: Open a password recovery form
        ' Dim recoveryForm As New frmPasswordRecovery()
        ' recoveryForm.ShowDialog()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        ' Press Enter to move to password field
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Press Enter to trigger login
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnLogin.PerformClick()
        End If
    End Sub

    ' Optional: Add a clear button if needed
    ' Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '     txtUsername.Clear()
    '     txtPassword.Clear()
    '     txtUsername.Focus()
    ' End Sub
End Class

Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Public Class frmLogin

    ' Fixes the Naming Rule Violation (Capital F)
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Admin Credentials
        If username = "Admin" And password = "12345" Then
            MsgBox("Login Successful!", MsgBoxStyle.Information)

            ' Show Dashboard
            frmPOS.Show()

            ' Close this form and ensure the hidden loading form is gone
            ' This prevents the "File Locked" error later
            Me.Hide()
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    ' Logic for the Show/Hide Eye Button
    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar
            btnShowHide.Text = "🔒"
        Else
            txtPassword.PasswordChar = "*"c
            btnShowHide.Text = "👁"
        End If
    End Sub

    ' Logic for the Forgot Password Button
    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        MsgBox("Please contact Innovatech Support to reset your password.", MsgBoxStyle.Information)
    End Sub

End Class
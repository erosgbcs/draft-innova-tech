Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Public Class FrmLogin ' Changed to Uppercase F

    ' Fixes the Naming Rule Violation (Capital F)
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c

        ' FIXING THE BUTTON STYLE ERRORS
        ' Use FlatAppearance for BorderSize
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
    End Sub

    ' Renamed with Capital B and L to satisfy naming rules
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "Admin" And password = "12345" Then
            MsgBox("Login Successful!", MsgBoxStyle.Information)
            frmPOS.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    ' Logic for the Show/Hide Eye Button (Capital B)
    Private Sub BtnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar
            btnShowHide.Text = "🔒"
        Else
            txtPassword.PasswordChar = "*"c
            btnShowHide.Text = "👁"
        End If
    End Sub

    ' Logic for the Forgot Password Button (Capital B)
    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        MsgBox("Please contact Innovatech Support to reset your password.", MsgBoxStyle.Information)
    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        ' Code here if needed
    End Sub
    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This ensures that when Login closes, the hidden Loading form dies too
        Application.Exit()
    End Sub

    Private Sub IbIUsername_Click(sender As Object, e As EventArgs) Handles IbIUsername.Click

    End Sub
End Class
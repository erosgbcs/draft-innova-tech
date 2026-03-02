Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' sample account
        If username = "Admin" And password = "12345" Then
            MsgBox("Login Successful!", MsgBoxStyle.Information)
            frmLoading.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
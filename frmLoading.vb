Public Class frmLoading
    ' Use Capital 'F' for the naming rule
    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 30 ' Speed of progress
        Timer1.Start()
        lblPercent.Text = "0%"
        ProgressBar1.Value = 0
    End Sub

    ' Add "Handles Timer1.Tick" to the end of this line!
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
            lblPercent.Text = ProgressBar1.Value & "%"
        Else
            Timer1.Stop() ' Good practice to use parentheses

            ' Open Login Form
            frmLogin.Show() ' Use the default instance or your Dim

            ' Hide the loading screen
            Me.Hide()
        End If
    End Sub


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    ' Add this inside your main form's code
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This kills the hidden background process completely
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
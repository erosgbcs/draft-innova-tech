Public Class FrmLoading
    ' Use Capital 'F' for the naming rule
    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Speed of progress
        Timer1.Start()
        lblPercent.Text = "0%"
        Progressbar1.Value = 0
    End Sub

    ' Add "Handles Timer1.Tick" to the end of this line!
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Progressbar1.Value < 100 Then
            Progressbar1.Value += 2
            lblPercent.Text = Progressbar1.Value & "%........Initializing "
        Else
            Timer1.Stop() ' Good practice to use parentheses

            ' Open Login Form
            FrmLogin.Show() ' Use the default instance or your Dim

            ' Hide the loading screen
            Me.Hide()
        End If
    End Sub


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
    End Sub
    ' Add this inside your main form's code
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This kills the hidden background process completely
        Application.Exit()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub
End Class
Public Class FrmLoading
    ' Use Capital 'F' for the naming rule
    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Speed of progress
        Timer1.Start()
        lblPercent.Text = "0%"
        Progressbar1.Value = 0
    End Sub

    ' Add "Handles Timer1.Tick" to the end of this line!
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Progressbar1.Value < 100 Then
            Progressbar1.Value += 2
            lblPercent.Text = Progressbar1.Value & "%........Initializing Database"
        Else
            Timer1.Stop() ' Good practice to use parentheses

            ' Open Login Form
            FrmLogin.Show() ' Use the default instance or your Dim

            ' Hide the loading screen
            Me.Hide()
        End If
    End Sub


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
    End Sub
    ' Add this inside your main form's code
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This kills the hidden background process completely
        Application.Exit()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub
End Class
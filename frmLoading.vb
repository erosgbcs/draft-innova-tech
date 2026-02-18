<<<<<<< HEAD
﻿Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDeveloper.Text = "Developed by Innovatech"
        lblPercent.Text = "0%"
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
            lblPercent.Text = ProgressBar1.Value & "%"
        Else
            Timer1.Stop()
            Me.Hide()
            Dim loginForm As New frmLogin()
            loginForm.Show()
        End If
    End Sub

    Private Sub lblDeveloper_Click(sender As Object, e As EventArgs) Handles lblDeveloper.Click

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
=======
﻿Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDeveloper.Text = "Developed by Innovatech"
        lblPercent.Text = "0%"
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
            lblPercent.Text = ProgressBar1.Value & "%"
        Else
            Timer1.Stop()
            Me.Hide()
            Dim loginForm As New frmLogin()
            loginForm.Show()
        End If
    End Sub

    Private Sub lblDeveloper_Click(sender As Object, e As EventArgs) Handles lblDeveloper.Click

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
>>>>>>> 1a3ada36988c1c8db55bf1fafe979419d955ea4e
End Class
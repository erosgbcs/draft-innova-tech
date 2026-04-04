Public Class frmdashboard
    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    ' Clock Logic
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    ' Navigation button

    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs)
        pos.Show
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs)
        frmInventory.Show
    End Sub

    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs)
        Sales_History.Show
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub tabWeeklyReports_Click(sender As Object, e As EventArgs)

    End Sub
End Class
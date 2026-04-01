Public Class frmdashboard
    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    ' Clock Logic
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    ' Navigation Example
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        pos.Show
        Hide
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        frmInventory.Show
    End Sub
    Private Sub btnOpensalehistory_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Sales_History.Show
    End Sub
End Class
Public Class frmdashboard
    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    ' Clock Logic
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    ' Navigation button

    ' Open POS form maximized
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Dim posForm As New pos()
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
    End Sub

    ' Open Inventory form maximized
    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        Dim invForm As New frmInventory()
        invForm.WindowState = FormWindowState.Maximized
        invForm.Show()
    End Sub

    ' Open Sales History form maximized
    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Dim salesForm As New Sales_History()
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub tabWeeklyReports_Click(sender As Object, e As EventArgs)

    End Sub
End Class
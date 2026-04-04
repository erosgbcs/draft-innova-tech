Imports System.Data

Public Class frmdashboard
    ' Fixed: Declare the database helper and the Timer with events to fix "Not Declared" errors
    Private db As New DatabaseHelper()
    Private WithEvents DashboardTimer As New Timer()

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Setup Clock Timer (Timer1 should be dragged from Toolbox or declared)
        Timer1.Start()

        ' Setup Dashboard Refresh Timer
        DashboardTimer.Interval = 5000 ' 5 seconds
        DashboardTimer.Start()

        ' Initial Load
        LoadDashboardStats()
    End Sub

    ' Clock Logic
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    ' Auto-refresh stats from Timer
    Private Sub DashboardTimer_Tick(sender As Object, e As EventArgs) Handles DashboardTimer.Tick
        LoadDashboardStats()
    End Sub

    ' Load dashboard summary values
    Private Sub LoadDashboardStats()
        ' Clear previous controls to prevent stacking/memory leaks
        ClearPanelControls(flptotalproducts)
        ClearPanelControls(flpitemsinstock)
        ClearPanelControls(flptodaysales)
        ClearPanelControls(flpweeklyrevenue)

        Try
            ' Fetch data using the specific helper methods
            Dim totalProducts As Integer = db.GetTotalProductsCount()
            Dim itemsInStock As Integer = db.GetTotalItemsInStock()
            Dim todaysSales As Decimal = db.GetTodaySales()
            Dim weeklyRevenue As Decimal = db.GetWeeklyRevenue()

            ' Add the big summary cards
            flptotalproducts.Controls.Add(CreateSummaryCard("Total Products", totalProducts.ToString()))
            flpitemsinstock.Controls.Add(CreateSummaryCard("Items in Stock", itemsInStock.ToString()))
            flptodaysales.Controls.Add(CreateSummaryCard("Today's Sales", "₱" & todaysSales.ToString("N2")))
            flpweeklyrevenue.Controls.Add(CreateSummaryCard("Weekly Revenue", "₱" & weeklyRevenue.ToString("N2")))
        Catch ex As Exception
            Console.WriteLine("Data Load Error: " & ex.Message)
        End Try
    End Sub

    ' Helper to properly dispose and clear panels
    Private Sub ClearPanelControls(panel As FlowLayoutPanel)
        For Each ctrl As Control In panel.Controls
            ctrl.Dispose()
        Next
        panel.Controls.Clear()
    End Sub

    ' Helper to build BIG summary cards
    Private Function CreateSummaryCard(title As String, value As String) As Panel
        Dim card As New Panel With {
            .Width = 250, ' Increased width
            .Height = 130, ' Increased height for big labels
            .BackColor = Color.White,
            .Margin = New Padding(10)
        }

        Dim lblTitle As New Label With {
            .Text = title.ToUpper(),
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.DimGray,
            .Location = New Point(15, 15),
            .AutoSize = True
        }

        Dim lblValue As New Label With {
            .Text = value,
            .Font = New Font("Segoe UI", 32, FontStyle.Bold), ' BIG FONT
            .ForeColor = Color.MidnightBlue,
            .Location = New Point(15, 55),
            .AutoSize = True
        }

        card.Controls.Add(lblTitle)
        card.Controls.Add(lblValue)
        Return card
    End Function

    ' Navigation buttons
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        Dim posForm As New pos()
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        Dim invForm As New frmInventory()
        invForm.WindowState = FormWindowState.Maximized
        invForm.Show()
    End Sub

    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        Dim salesForm As New frmSalesHIstory()
        salesForm.WindowState = FormWindowState.Maximized
        salesForm.Show()
    End Sub
End Class
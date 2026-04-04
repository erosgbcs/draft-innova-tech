Imports System.Data

Public Class frmdashboard
    Private db As New DatabaseHelper()
    Private WithEvents DashboardTimer As New Timer()

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Setup Clock
        Timer1.Start()

        ' Setup Refresh Timer (5 seconds)
        DashboardTimer.Interval = 5000
        DashboardTimer.Start()

        ' Initial Data Load
        LoadDashboardStats()
    End Sub

    ' Update Clock Label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    ' Auto-refresh every 5 seconds
    Private Sub DashboardTimer_Tick(sender As Object, e As EventArgs) Handles DashboardTimer.Tick
        LoadDashboardStats()
    End Sub

    ' MAIN LOADING LOGIC
    Private Sub LoadDashboardStats()
        ' Clear all panels to prevent stacking data
        ClearPanelControls(flptotalproducts)
        ClearPanelControls(flpitemsinstock)
        ClearPanelControls(flptodaysales)
        ClearPanelControls(flpweeklyrevenue)
        ClearPanelControls(flpinventoryinsights) ' Clear the insights panel

        Try
            ' 1. Fetch Main Stats
            Dim totalProducts As Integer = db.GetTotalProductsCount()
            Dim itemsInStock As Integer = db.GetTotalItemsInStock()
            Dim todaysSales As Decimal = db.GetTodaySales()
            Dim weeklyRevenue As Decimal = db.GetWeeklyRevenue()

            ' 2. Create Big Summary Cards
            flptotalproducts.Controls.Add(CreateSummaryCard("Total Products", totalProducts.ToString()))
            flpitemsinstock.Controls.Add(CreateSummaryCard("Items in Stock", itemsInStock.ToString()))
            flptodaysales.Controls.Add(CreateSummaryCard("Today's Sales", "₱" & todaysSales.ToString("N2")))
            flpweeklyrevenue.Controls.Add(CreateSummaryCard("Weekly Revenue", "₱" & weeklyRevenue.ToString("N2")))

            ' 3. LOAD THE INSIGHTS (The missing link)
            LoadInventoryInsights()

        Catch ex As Exception
            Console.WriteLine("Data Load Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadInventoryInsights()
        flpinventoryinsights.FlowDirection = FlowDirection.TopDown
        flpinventoryinsights.WrapContents = False
        flpinventoryinsights.AutoScroll = True

        ' Header
        Dim lblHeader As New Label With {
            .Text = "Inventory Insights",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .AutoSize = True,
            .Margin = New Padding(10, 10, 0, 10)
        }
        flpinventoryinsights.Controls.Add(lblHeader)

        ' Low Stock Section
        Dim lowStockDt As DataTable = db.GetLowStockItems(10)
        Dim lowStockText As String = ""
        If lowStockDt.Rows.Count > 0 Then
            For Each row As DataRow In lowStockDt.Rows
                lowStockText &= $"• {row("ProductName")} ({row("Stock")} left)" & vbCrLf
            Next
        Else
            lowStockText = "• All items are well stocked."
        End If
        flpinventoryinsights.Controls.Add(CreateInsightSection("Low Stock Items (< 10)", lowStockText, Color.Firebrick))

        ' Recommendations Section
        Dim outCount As Integer = db.GetOutOfStockCount()
        Dim recs As String = $"• Restock {outCount} out-of-stock items" & vbCrLf & $"• Reorder {lowStockDt.Rows.Count} low-stock items"
        flpinventoryinsights.Controls.Add(CreateInsightSection("Recommendations", recs, Color.DarkGreen))
    End Sub

    ' HELPERS
    Private Sub ClearPanelControls(panel As FlowLayoutPanel)
        For Each ctrl As Control In panel.Controls : ctrl.Dispose() : Next
        panel.Controls.Clear()
    End Sub

    Private Function CreateSummaryCard(title As String, value As String) As Panel
        Dim card As New Panel With {.Width = 250, .Height = 130, .BackColor = Color.White, .Margin = New Padding(10)}
        Dim lblT As New Label With {.Text = title.ToUpper(), .Font = New Font("Segoe UI", 12, FontStyle.Bold), .ForeColor = Color.DimGray, .Location = New Point(15, 15), .AutoSize = True}
        Dim lblV As New Label With {.Text = value, .Font = New Font("Segoe UI", 32, FontStyle.Bold), .ForeColor = Color.MidnightBlue, .Location = New Point(15, 55), .AutoSize = True}
        card.Controls.Add(lblT) : card.Controls.Add(lblV)
        Return card
    End Function

    Private Function CreateInsightSection(title As String, content As String, titleColor As Color) As Panel
        Dim pnl As New Panel With {.Width = flpinventoryinsights.Width - 25, .AutoSize = True, .Margin = New Padding(10, 0, 0, 15)}
        Dim lblT As New Label With {.Text = title, .Font = New Font("Segoe UI", 11, FontStyle.Bold), .ForeColor = titleColor, .AutoSize = True}
        Dim lblC As New Label With {.Text = content, .Font = New Font("Segoe UI", 10), .ForeColor = Color.FromArgb(64, 64, 64), .Location = New Point(5, 22), .AutoSize = True}
        pnl.Controls.Add(lblT) : pnl.Controls.Add(lblC)
        Return pnl
    End Function

    ' NAVIGATION
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs) Handles btnOpenPOS.Click
        pos.Show()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs) Handles btnOpenInventory.Click
        frmInventory.Show()
    End Sub

    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        frmSalesHIstory.Show()
    End Sub
End Class
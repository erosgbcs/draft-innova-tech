Imports System.Data
Imports System.Drawing.Drawing2D
Imports System.Security

Public Class frmdashboard
    Private db As New DatabaseHelper()
    Private WithEvents DashboardTimer As New Timer()

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.DoubleBuffered = True
        Timer1.Interval = 1000
        Timer1.Start()

        SecurityManager.ApplyRestrictions(Me)

        DashboardTimer.Interval = 5000
        DashboardTimer.Start()

        LoadDashboardStats()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub DashboardTimer_Tick(sender As Object, e As EventArgs) Handles DashboardTimer.Tick
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        MainStatsContainer.SuspendLayout()
        ClearPanelControls(MainStatsContainer)

        Try
            MainStatsContainer.Controls.Add(CreateSummaryCard("Total Products", db.GetTotalProductsCount().ToString(), "📦"))
            MainStatsContainer.Controls.Add(CreateSummaryCard("Items in Stock", db.GetTotalItemsInStock().ToString(), "📉"))
            MainStatsContainer.Controls.Add(CreateSummaryCard("Today's Sales", "₱" & db.GetTodaySales().ToString("N2"), "💰"))
            MainStatsContainer.Controls.Add(CreateSummaryCard("Weekly Revenue", "₱" & db.GetWeeklyRevenue().ToString("N2"), "📈"))

            LoadInventoryInsights()
        Catch ex As Exception
            Console.WriteLine("Data Load Error: " & ex.Message)
        Finally
            MainStatsContainer.ResumeLayout()
        End Try
    End Sub

    Private Sub LoadInventoryInsights()
        ClearPanelControls(flpinventoryinsights)
        ClearPanelControls(flpchart)

        Dim lblHeader As New Label With {
            .Text = "Inventory Insights & Analytics",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .AutoSize = True,
            .Margin = New Padding(10, 10, 0, 10)
        }
        flpinventoryinsights.Controls.Add(lblHeader)

        Dim dtSales As DataTable = db.GetWeeklySalesData()
        Dim lowStockDt As DataTable = db.GetLowStockItems(10)
        Dim outCount As Integer = db.GetOutOfStockCount()

        Dim lowStockText As String = ""
        If lowStockDt.Rows.Count > 0 Then
            For Each row As DataRow In lowStockDt.Rows
                lowStockText &= $"• {row("ProductName")} ({row("Stock")} left)" & vbCrLf
            Next
        Else
            lowStockText = "• All items are well stocked."
        End If
        flpinventoryinsights.Controls.Add(CreateInsightSection("Low Stock Alerts", lowStockText, Color.Firebrick))

        Dim chartWidth As Integer = (flpchart.Width / 3) - 25
        If chartWidth < 300 Then chartWidth = 350

        flpchart.Controls.Add(CreateManualBarGraph("Weekly Revenue", dtSales, chartWidth))
        flpchart.Controls.Add(CreateManualPieChart("Revenue Share", dtSales, chartWidth))
        flpchart.Controls.Add(CreateManualLineGraph("Growth Trend", dtSales, chartWidth))
        ' Add this line inside LoadInventoryInsights
        flpchart.Controls.Add(CreateDailyRevenueTrend("Daily Revenue Trend", dtSales, chartWidth))

        Dim recs As String = $"• Restock {outCount} out-of-stock items ASAP" & vbCrLf &
                             $"• Reorder {lowStockDt.Rows.Count} items nearing critical level"
        flpinventoryinsights.Controls.Add(CreateInsightSection("Action Plan", recs, Color.DarkGreen))
    End Sub

    Private Function CreateManualBarGraph(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim graphPanel As New Panel With {.Width = panelWidth, .Height = 280, .BackColor = Color.White, .Margin = New Padding(10)}

        ' Header Title
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        graphPanel.Controls.Add(lbl)

        ' Subtitle for Date Range (Example: Apr 03 - Apr 10)
        If dt.Rows.Count > 0 Then
            Dim startDate = DateTime.Parse(dt.Rows(0)("SaleDay").ToString()).ToString("MMM dd")
            Dim endDate = DateTime.Parse(dt.Rows(dt.Rows.Count - 1)("SaleDay").ToString()).ToString("MMM dd")
            Dim lblSub As New Label With {
            .Text = $"{startDate} - {endDate}",
            .Font = New Font("Segoe UI", 8),
            .ForeColor = Color.Gray,
            .Location = New Point(15, 30),
            .AutoSize = True
        }
            graphPanel.Controls.Add(lblSub)
        End If

        AddHandler graphPanel.Paint, Sub(sender, e)
                                         Dim g = e.Graphics
                                         g.SmoothingMode = SmoothingMode.AntiAlias

                                         ' Adjusted chart area to make room for labels at the bottom
                                         Dim chartArea As New Rectangle(50, 60, graphPanel.Width - 80, graphPanel.Height - 110)
                                         Dim maxVal As Double = 1

                                         For Each r As DataRow In dt.Rows
                                             If Convert.ToDouble(r("DailyTotal")) > maxVal Then maxVal = Convert.ToDouble(r("DailyTotal"))
                                         Next

                                         Dim barWidth As Integer = (chartArea.Width / Math.Max(dt.Rows.Count, 1)) - 15
                                         Dim startX As Integer = chartArea.Left

                                         Dim fontLabels As New Font("Segoe UI", 7)
                                         Dim fontValues As New Font("Segoe UI Semibold", 7)

                                         For Each row As DataRow In dt.Rows
                                             Dim val As Double = Convert.ToDouble(row("DailyTotal"))
                                             Dim h As Integer = (val / maxVal) * chartArea.Height
                                             Dim rect As New Rectangle(startX, chartArea.Bottom - h, barWidth, h)

                                             ' 1. Draw the Bar
                                             If h > 0 Then
                                                 Using br As New LinearGradientBrush(rect, Color.FromArgb(79, 70, 229), Color.FromArgb(129, 140, 248), 90.0F)
                                                     DrawRoundedBar(g, br, rect, 5)
                                                 End Using
                                             End If

                                             '' 2. Draw Value Label on top of bar (e.g., ₱500)
                                             Dim displayVal As String = "₱" & val.ToString("N0")
                                             Dim valSize = g.MeasureString(displayVal, fontValues)
                                             ' Fixed: Wrapped coordinates in CSng()
                                             Dim valX As Single = CSng(startX + (barWidth / 2) - (valSize.Width / 2))
                                             Dim valY As Single = CSng(rect.Y - 15)
                                             g.DrawString(displayVal, fontValues, Brushes.DimGray, valX, valY)

                                             ' 3. Draw Date Label at the bottom (X-Axis)
                                             Dim dateTxt As String = DateTime.Parse(row("SaleDay").ToString()).ToString("MM/dd")
                                             Dim dateSize = g.MeasureString(dateTxt, fontLabels)
                                             ' Fixed: Wrapped coordinates in CSng()
                                             Dim dateX As Single = CSng(startX + (barWidth / 2) - (dateSize.Width / 2))
                                             Dim dateY As Single = CSng(chartArea.Bottom + 5)
                                             g.DrawString(dateTxt, fontLabels, Brushes.Gray, dateX, dateY)

                                             startX += barWidth + 15
                                         Next
                                     End Sub
        Return graphPanel
    End Function

    Private Function CreateManualPieChart(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim piepanel As New Panel With {.Width = panelWidth, .Height = 280, .BackColor = Color.White, .Margin = New Padding(10)}
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        piepanel.Controls.Add(lbl)

        AddHandler piepanel.Paint, Sub(sender, e)
                                       Dim g = e.Graphics
                                       g.SmoothingMode = SmoothingMode.AntiAlias
                                       Dim total As Double = 0

                                       ' Fixed: Missing Next
                                       For Each r As DataRow In dt.Rows
                                           total += Convert.ToDouble(r("DailyTotal"))
                                       Next

                                       If total = 0 Then Return

                                       Dim rect As New Rectangle(30, 60, 140, 140)
                                       Dim angle As Single = 0
                                       Dim colors As Color() = {Color.FromArgb(79, 70, 229), Color.FromArgb(129, 140, 248), Color.FromArgb(199, 210, 254), Color.FromArgb(67, 56, 202)}

                                       For i As Integer = 0 To Math.Min(dt.Rows.Count - 1, 3)
                                           Dim sweep As Single = (Convert.ToDouble(dt.Rows(i)("DailyTotal")) / total) * 360
                                           Using br As New SolidBrush(colors(i Mod colors.Length))
                                               g.FillPie(br, rect, angle, sweep)
                                               g.FillRectangle(br, 180, 70 + (i * 30), 12, 12)
                                               Dim dateTxt = DateTime.Parse(dt.Rows(i)("SaleDay").ToString()).ToString("MM/dd")
                                               g.DrawString($"{dateTxt}: ₱{dt.Rows(i)("DailyTotal"):N0}", New Font("Segoe UI", 8), Brushes.DimGray, 200, 68 + (i * 30))
                                           End Using
                                           angle += sweep
                                       Next
                                   End Sub ' Fixed: Closing the AddHandler Sub
        Return piepanel
    End Function

    Private Function CreateManualLineGraph(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim linePanel As New Panel With {.Width = panelWidth, .Height = 280, .BackColor = Color.White, .Margin = New Padding(10)}
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        linePanel.Controls.Add(lbl)

        AddHandler linePanel.Paint, Sub(sender, e)
                                        Dim g = e.Graphics
                                        g.SmoothingMode = SmoothingMode.AntiAlias
                                        Dim chartArea As New Rectangle(50, 60, linePanel.Width - 80, linePanel.Height - 110)
                                        If dt.Rows.Count < 2 Then Return

                                        Dim maxVal As Double = 1
                                        ' Fixed: Missing Next
                                        For Each r As DataRow In dt.Rows
                                            If Convert.ToDouble(r("DailyTotal")) > maxVal Then maxVal = Convert.ToDouble(r("DailyTotal"))
                                        Next

                                        Dim points As New List(Of PointF)
                                        Dim stepX As Single = chartArea.Width / (dt.Rows.Count - 1)
                                        For i As Integer = 0 To dt.Rows.Count - 1
                                            Dim x As Single = chartArea.Left + (i * stepX)
                                            Dim y As Single = chartArea.Bottom - (CSng(dt.Rows(i)("DailyTotal") / maxVal) * chartArea.Height)
                                            points.Add(New PointF(x, y))
                                        Next

                                        Using p As New Pen(Color.FromArgb(79, 70, 229), 3)
                                            g.DrawLines(p, points.ToArray())
                                        End Using

                                        For Each pt In points
                                            g.FillEllipse(Brushes.White, pt.X - 4, pt.Y - 4, 8, 8)
                                            g.DrawEllipse(New Pen(Color.RoyalBlue, 2), pt.X - 4, pt.Y - 4, 8, 8)
                                        Next
                                    End Sub ' Fixed: Closing the AddHandler Sub
        Return linePanel
    End Function

    Private Sub ClearPanelControls(container As Control)
        If container IsNot Nothing Then
            For i As Integer = container.Controls.Count - 1 To 0 Step -1
                Dim ctrl = container.Controls(i)
                container.Controls.Remove(ctrl)
                ctrl.Dispose()
            Next
        End If
    End Sub

    Private Function CreateSummaryCard(title As String, value As String, icon As String) As Panel
        Dim card As New Panel With {.Width = 280, .Height = 140, .BackColor = Color.White, .Margin = New Padding(15), .Cursor = Cursors.Hand}
        Dim lblT As New Label With {.Text = title.ToUpper(), .Font = New Font("Segoe UI Semibold", 11), .ForeColor = Color.Navy, .Location = New Point(20, 20), .AutoSize = True}
        Dim lblV As New Label With {.Text = value, .Font = New Font("Segoe UI Variable Display", 28, FontStyle.Bold), .ForeColor = Color.FromArgb(30, 41, 59), .Location = New Point(15, 50), .AutoSize = True}
        Dim lblIcon As New Label With {.Text = icon, .Font = New Font("Segoe UI", 24), .ForeColor = Color.Navy, .Location = New Point(210, 80), .AutoSize = True}
        AddHandler card.Paint, AddressOf Card_Paint
        card.Controls.Add(lblT)
        card.Controls.Add(lblV)
        card.Controls.Add(lblIcon)
        Return card
    End Function

    Private Function CreateInsightSection(title As String, content As String, titleColor As Color) As Panel
        Dim pnl As New Panel With {.Width = flpinventoryinsights.Width - 25, .AutoSize = True, .Margin = New Padding(10, 0, 0, 15)}
        Dim lblT As New Label With {.Text = title, .Font = New Font("Segoe UI", 11, FontStyle.Bold), .ForeColor = titleColor, .AutoSize = True}
        Dim lblC As New Label With {.Text = content, .Font = New Font("Segoe UI", 10), .ForeColor = Color.FromArgb(64, 64, 64), .Location = New Point(5, 22), .AutoSize = True}
        pnl.Controls.Add(lblT)
        pnl.Controls.Add(lblC)
        Return pnl
    End Function

    Private Sub Card_Paint(sender As Object, e As PaintEventArgs)
        Dim pnl = DirectCast(sender, Panel)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim radius As Integer = 20
        Dim rect As New Rectangle(0, 0, pnl.Width - 5, pnl.Height - 5)
        Using path As GraphicsPath = GetRoundedRectPath(rect, radius)
            g.FillPath(New SolidBrush(pnl.BackColor), path)
            g.DrawPath(New Pen(Color.FromArgb(230, 230, 230)), path)
        End Using
    End Sub

    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub DrawRoundedBar(g As Graphics, br As Brush, rect As Rectangle, radius As Integer)
        If rect.Width <= 0 Or rect.Height <= 0 Then Return
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom)
        path.CloseFigure()
        g.FillPath(br, path)
    End Sub
    Private Function CreateDailyRevenueTrend(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim trendPanel As New Panel With {.Width = panelWidth, .Height = 280, .BackColor = Color.White, .Margin = New Padding(10)}

        ' Icon and Title
        Dim lblIcon As New Label With {.Text = "📈", .Font = New Font("Segoe UI", 12), .Location = New Point(15, 12), .AutoSize = True}
        Dim lblTitle As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.FromArgb(70, 90, 150), .Location = New Point(40, 10), .AutoSize = True}
        trendPanel.Controls.Add(lblIcon)
        trendPanel.Controls.Add(lblTitle)

        AddHandler trendPanel.Paint, Sub(sender, e)
                                         Dim g = e.Graphics
                                         g.SmoothingMode = SmoothingMode.AntiAlias

                                         Dim chartArea As New Rectangle(50, 60, trendPanel.Width - 80, trendPanel.Height - 110)
                                         If dt.Rows.Count < 2 Then Return

                                         ' 1. Calculate Max Value for Scaling
                                         Dim maxVal As Double = 1
                                         For Each r As DataRow In dt.Rows
                                             If Convert.ToDouble(r("DailyTotal")) > maxVal Then maxVal = Convert.ToDouble(r("DailyTotal"))
                                         Next

                                         ' 2. Generate Points
                                         Dim points As New List(Of PointF)
                                         Dim stepX As Single = chartArea.Width / (dt.Rows.Count - 1)

                                         For i As Integer = 0 To dt.Rows.Count - 1
                                             Dim x As Single = chartArea.Left + (i * stepX)
                                             Dim y As Single = chartArea.Bottom - (CSng(dt.Rows(i)("DailyTotal") / maxVal) * chartArea.Height)
                                             points.Add(New PointF(x, y))
                                         Next

                                         ' 3. Create the Filled Area (Gradient)
                                         Using areaPath As New GraphicsPath()
                                             areaPath.AddLines(points.ToArray())
                                             areaPath.AddLine(points.Last().X, chartArea.Bottom, points.First().X, chartArea.Bottom)
                                             areaPath.CloseFigure()

                                             Using fillBrush As New LinearGradientBrush(chartArea, Color.FromArgb(100, 79, 70, 229), Color.Transparent, LinearGradientMode.Vertical)
                                                 g.FillPath(fillBrush, areaPath)
                                             End Using
                                         End Using

                                         ' 4. Draw the Top Line
                                         Using p As New Pen(Color.FromArgb(79, 70, 229), 3)
                                             g.DrawLines(p, points.ToArray())
                                         End Using

                                         ' 5. Draw Labels (Dates and % or Values)
                                         For i As Integer = 0 To points.Count - 1
                                             ' X-Axis (Days)
                                             Dim dayTxt As String = DateTime.Parse(dt.Rows(i)("SaleDay").ToString()).ToString("ddd")
                                             Dim daySize = g.MeasureString(dayTxt, Me.Font)
                                             g.DrawString(dayTxt, New Font("Segoe UI", 7), Brushes.Gray, points(i).X - (daySize.Width / 2), chartArea.Bottom + 5)

                                             ' Top Values (Percentage or Currency)
                                             Dim val = Convert.ToDouble(dt.Rows(i)("DailyTotal"))
                                             Dim valTxt As String = If(val = maxVal, "100.0%", (val / maxVal).ToString("P1"))
                                             Dim valSize = g.MeasureString(valTxt, Me.Font)
                                             g.DrawString(valTxt, New Font("Segoe UI", 7), Brushes.DimGray, points(i).X - (valSize.Width / 2), points(i).Y - 15)
                                         Next
                                     End Sub

        Return trendPanel
    End Function
End Class
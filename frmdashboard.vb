Imports System.Data
Imports System.Drawing.Drawing2D
Imports System.Security
Imports System.Reflection

Public Class frmdashboard
    Private db As New DatabaseHelper()
    Private ReadOnly TopSellerCandidates As String() = {"GetTopSellingProducts", "GetTopSellingItems", "GetTopSellers"}
    Private WithEvents DashboardTimer As New Timer()

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.DoubleBuffered = True
        Timer1.Interval = 1000
        Timer1.Start()

        SecurityManager.ApplyRestrictions(Me)

        DashboardTimer.Interval = 30000
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
            ' Keep error handling minimal for production
        Finally
            MainStatsContainer.ResumeLayout()
        End Try
    End Sub

    Private Sub SetPanelDoubleBuffered(p As Panel)
        Try
            Dim pi = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            If pi IsNot Nothing Then pi.SetValue(p, True, Nothing)
        Catch
            ' ignore
        End Try
    End Sub

    Private Sub LoadInventoryInsights()
        ' Clear previous content
        ClearPanelControls(flpinventoryinsights)
        ClearPanelControls(flpchart)

        ' Header
        Dim lblHeader As New Label With {
            .Text = "Inventory Insights",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .AutoSize = True,
            .Margin = New Padding(10, 10, 0, 10)
        }
        flpinventoryinsights.Controls.Add(lblHeader)

        ' --- Low stock (dynamic from DB) ---
        Dim lowStockDt As DataTable = Nothing
        Try
            lowStockDt = db.GetLowStockItems(10)
        Catch
            lowStockDt = Nothing
        End Try

        Dim lowStockText As String = ""
        If lowStockDt IsNot Nothing AndAlso lowStockDt.Rows.Count > 0 Then
            For Each row As DataRow In lowStockDt.Rows
                Dim name = If(row.Table.Columns.Contains("ProductName") AndAlso Not IsDBNull(row("ProductName")), row("ProductName").ToString(), "Unknown")
                Dim stock = If(row.Table.Columns.Contains("Stock") AndAlso Not IsDBNull(row("Stock")), SafeToDouble(row("Stock")).ToString("N0"), "0")
                lowStockText &= $"{name} ({stock} left)" & vbCrLf
            Next
        Else
            ' fallback sample content
            lowStockText = "" & vbCrLf & ""
        End If
        flpinventoryinsights.Controls.Add(CreateInsightSection("Low Stock Items (< 10)", lowStockText.Trim(), Color.Firebrick))

        ' --- Top selling products (try to obtain from DatabaseHelper via reflection) ---
        Dim topSellingText As String = "No sales data for this week"
        Try
            Dim dbType = db.GetType()
            Dim candidateNames = New String() {"GetTopSellingProducts", "GetTopSellingItems", "GetTopSellers"}
            Dim topDt As DataTable = Nothing
            For Each candidateName In TopSellerCandidates
                Dim mi = dbType.GetMethod(candidateName)
                If mi IsNot Nothing Then
                    Dim result = mi.Invoke(db, Nothing)
                    If TypeOf result Is DataTable Then
                        topDt = DirectCast(result, DataTable)
                        Exit For
                    End If
                End If
            Next

            If topDt IsNot Nothing AndAlso topDt.Rows.Count > 0 Then
                ' prefer columns ProductName + Quantity/TotalSold/Total
                Dim rowsToShow = Math.Min(5, topDt.Rows.Count)
                Dim sb As New System.Text.StringBuilder()
                For i = 0 To rowsToShow - 1
                    Dim r = topDt.Rows(i)
                    Dim pname = If(topDt.Columns.Contains("ProductName") AndAlso Not IsDBNull(r("ProductName")), r("ProductName").ToString(), If(topDt.Columns.Count > 0, r(0).ToString(), "Item"))
                    Dim qtyCol = If(topDt.Columns.Contains("Quantity"), "Quantity", If(topDt.Columns.Contains("TotalSold"), "TotalSold", If(topDt.Columns.Contains("Total"), "Total", Nothing)))
                    Dim qty = If(qtyCol IsNot Nothing AndAlso Not IsDBNull(r(qtyCol)), SafeToDouble(r(qtyCol)).ToString("N0"), "")
                    If String.IsNullOrEmpty(qty) Then
                        sb.AppendLine(pname)
                    Else
                        sb.AppendLine($"{pname} ({qty} sold)")
                    End If
                Next
                topSellingText = sb.ToString().Trim()
            End If
        Catch
            topSellingText = "No sales data for this week"
        End Try
        flpinventoryinsights.Controls.Add(CreateInsightSection("Top Selling Products", topSellingText, Color.Navy))

        ' --- Recommendations (derived from DB values) ---
        Dim outCount As Integer = 0
        Try
            outCount = db.GetOutOfStockCount()
        Catch
            outCount = 0
        End Try
        Dim lowCount As Integer = If(lowStockDt IsNot Nothing, lowStockDt.Rows.Count, 2)
        Dim recs As String = $"Restock {outCount} out-of-stock items" & vbCrLf & $"Reorder {lowCount} low-stock items"
        flpinventoryinsights.Controls.Add(CreateInsightSection("Recommendations", recs, Color.DarkGreen))

        ' --- Charts container (use actual DB weekly sales) ---
        Dim chartsContainer As New FlowLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.LeftToRight,
            .WrapContents = True,
            .AutoScroll = True,
            .BackColor = Color.Transparent
        }
        flpchart.Controls.Add(chartsContainer)

        Dim dtSales As DataTable = Nothing
        Try
            dtSales = db.GetWeeklySalesData()
        Catch
            dtSales = Nothing
        End Try

        If dtSales Is Nothing Then
            dtSales = New DataTable()
            dtSales.Columns.Add("SaleDay", GetType(String))
            dtSales.Columns.Add("DailyTotal", GetType(Double))
        End If

        Dim chartWidth As Integer
        Try
            chartWidth = Math.Max(350, (If(chartsContainer.ClientSize.Width > 0, chartsContainer.ClientSize.Width, 1050) \ 3) - 25)
        Catch
            chartWidth = 350
        End Try

        chartsContainer.Controls.Add(CreateManualBarGraph("Weekly Revenue", dtSales, chartWidth))
        chartsContainer.Controls.Add(CreateManualPieChart("Top-Selling Products", dtSales, chartWidth))
        chartsContainer.Controls.Add(CreateManualLineGraph("Growth Trend", dtSales, chartWidth))
        chartsContainer.Controls.Add(CreateDailyRevenueTrend("Daily Revenue Trend", dtSales, chartWidth))
        chartsContainer.Controls.Add(CreateGaugeChart("Sales Target Progress", db.GetTodaySales(), 100000, chartWidth))

        chartsContainer.PerformLayout()
        chartsContainer.Refresh()
    End Sub

    Private Function CreateManualBarGraph(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim panel As New Panel With {
            .Width = panelWidth,
            .Height = 280,
            .BackColor = Color.White,
            .Margin = New Padding(10),
            .BorderStyle = BorderStyle.FixedSingle,
            .Name = "bar_" & title.Replace(" ", "_")
        }
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        panel.Controls.Add(lbl)

        AddHandler panel.Paint, Sub(sender, e)
                                    Dim g = e.Graphics
                                    g.SmoothingMode = SmoothingMode.AntiAlias
                                    Dim pad = 10
                                    Dim area = New Rectangle(pad + 40, 40, panel.ClientSize.Width - (pad * 2) - 40, panel.ClientSize.Height - 90)

                                    If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                                        g.DrawString("No data available", New Font("Segoe UI", 9), Brushes.Gray, area.Left + 10, area.Top + 10)
                                        Return
                                    End If

                                    Dim values = dt.Rows.Cast(Of DataRow)().Select(Function(r) SafeToDouble(r("DailyTotal"))).ToList()
                                    Dim maxVal = Math.Max(1, values.Max())
                                    ' draw Y axis baseline and gridlines
                                    Using penGrid As New Pen(Color.FromArgb(230, 230, 230))
                                        Dim steps = 4
                                        For i = 0 To steps
                                            Dim y = area.Top + CInt(i * (area.Height / steps))
                                            g.DrawLine(penGrid, area.Left, y, area.Right, y)
                                        Next
                                    End Using

                                    ' draw bars
                                    Dim count = values.Count
                                    Dim barSpace = Math.Max(1, CInt(area.Width / Math.Max(1, count)))
                                    Dim barWidth = Math.Max(8, barSpace - 12)
                                    Dim x = area.Left + 6
                                    Dim fontLabel As New Font("Segoe UI", 7)
                                    Dim fontVal As New Font("Segoe UI Semibold", 8)
                                    For i = 0 To count - 1
                                        Dim val = values(i)
                                        Dim h = If(maxVal = 0, 0, CInt((val / maxVal) * (area.Height - 10)))
                                        Dim rect = New Rectangle(x, area.Bottom - h, barWidth, h)
                                        Using br As New LinearGradientBrush(rect, Color.FromArgb(79, 70, 229), Color.FromArgb(129, 140, 248), 90.0F)
                                            DrawRoundedBar(g, br, rect, 4)
                                        End Using
                                        ' value label
                                        g.DrawString($"₱{val:N0}", fontVal, Brushes.DimGray, rect.Left, rect.Top - 16)
                                        ' x label (SaleDay)
                                        Dim label = If(dt.Columns.Contains("SaleDay") AndAlso Not IsDBNull(dt.Rows(i)("SaleDay")), DateTime.Parse(dt.Rows(i)("SaleDay").ToString()).ToString("MM/dd"), "")
                                        g.DrawString(label, fontLabel, Brushes.Gray, rect.Left, area.Bottom + 2)
                                        x += barSpace
                                    Next
                                End Sub
        Return panel
    End Function

    Private Function CreateManualPieChart(title As String, dt As DataTable, panelWidth As Integer) As Panel
        ' Reworked: show Top Selling Products (from DatabaseHelper if available) otherwise fallback to previous revenue/category behavior
        Dim panel As New Panel With {
            .Width = panelWidth,
            .Height = 280,
            .BackColor = Color.White,
            .Margin = New Padding(10),
            .BorderStyle = BorderStyle.FixedSingle,
            .Name = "pie_" & title.Replace(" ", "_")
        }
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        panel.Controls.Add(lbl)

        ' Build slices: prefer a top-selling DataTable from DatabaseHelper
        Dim slices As New List(Of KeyValuePair(Of String, Double))

        Try
            Dim dbType = db.GetType()
            Dim topDt As DataTable = Nothing
            For Each candidate In TopSellerCandidates
                Dim mi = dbType.GetMethod(candidate)
                If mi IsNot Nothing Then
                    Dim res = mi.Invoke(db, Nothing)
                    If TypeOf res Is DataTable Then
                        topDt = DirectCast(res, DataTable)
                        Exit For
                    End If
                End If
            Next

            If topDt IsNot Nothing AndAlso topDt.Rows.Count > 0 Then
                ' prefer ProductName and Quantity/TotalSold/Total
                Dim qtyCol = If(topDt.Columns.Contains("Quantity"), "Quantity", If(topDt.Columns.Contains("TotalSold"), "TotalSold", If(topDt.Columns.Contains("Total"), "Total", Nothing)))
                For Each r As DataRow In topDt.Rows
                    Dim name = If(topDt.Columns.Contains("ProductName") AndAlso Not IsDBNull(r("ProductName")), r("ProductName").ToString(), If(topDt.Columns.Count > 0, r(0).ToString(), "Item"))
                    Dim value As Double = If(qtyCol IsNot Nothing AndAlso Not IsDBNull(r(qtyCol)), SafeToDouble(r(qtyCol)), 1)
                    slices.Add(New KeyValuePair(Of String, Double)(name, value))
                Next
                ' sort descending
                slices = slices.OrderByDescending(Function(s) s.Value).ToList()
            End If
        Catch
            ' ignore, fallback to revenue/category below
        End Try

        ' Fallback: if no top-selling table found, aggregate by category or date from passed dt
        If slices.Count = 0 AndAlso dt IsNot Nothing Then
            Dim categoryCol = dt.Columns.Cast(Of DataColumn)().FirstOrDefault(Function(c) {"Category", "SaleCategory", "ProductCategory", "CategoryName"}.Contains(c.ColumnName))?.ColumnName
            Dim valueCol = dt.Columns.Cast(Of DataColumn)().FirstOrDefault(Function(c) {"DailyTotal", "Amount", "Revenue", "Total"}.Contains(c.ColumnName))?.ColumnName
            If valueCol Is Nothing AndAlso dt.Columns.Count > 0 Then valueCol = dt.Columns(0).ColumnName

            If categoryCol IsNot Nothing Then
                Dim agg As New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
                For Each r As DataRow In dt.Rows
                    Dim k = If(Not r.IsNull(categoryCol), r(categoryCol).ToString(), "Unknown")
                    Dim v = SafeToDouble(If(valueCol IsNot Nothing AndAlso dt.Columns.Contains(valueCol), r(valueCol), 0))
                    If Not agg.TryAdd(k, v) Then agg(k) += v
                Next
                slices.AddRange(agg.OrderByDescending(Function(k) k.Value).Select(Function(k) New KeyValuePair(Of String, Double)(k.Key, k.Value)))
            Else
                For i = 0 To dt.Rows.Count - 1
                    Dim label = If(dt.Columns.Contains("SaleDay") AndAlso Not IsDBNull(dt.Rows(i)("SaleDay")), DateTime.Parse(dt.Rows(i)("SaleDay").ToString()).ToString("MM/dd"), $"Row{i}")
                    Dim val = If(dt.Columns.Contains("DailyTotal"), SafeToDouble(dt.Rows(i)("DailyTotal")), 0)
                    slices.Add(New KeyValuePair(Of String, Double)(label, val))
                Next
                slices = slices.OrderByDescending(Function(s) s.Value).ToList()
            End If
        End If

        AddHandler panel.Paint, Sub(sender, e)
                                    Dim g = e.Graphics
                                    g.SmoothingMode = SmoothingMode.AntiAlias
                                    If slices Is Nothing OrElse slices.Count = 0 OrElse slices.Sum(Function(s) s.Value) <= 0 Then
                                        g.DrawString("No data", New Font("Segoe UI", 9), Brushes.Gray, 40, 120)
                                        Return
                                    End If

                                    Dim total = slices.Sum(Function(s) s.Value)
                                    Dim pieSize = Math.Min(140, panel.ClientSize.Height - 120)
                                    If pieSize <= 0 Then pieSize = 140
                                    Dim rect = New Rectangle(30, 60, pieSize, pieSize)
                                    Dim colors = New Color() {Color.FromArgb(79, 70, 229), Color.FromArgb(129, 140, 248), Color.FromArgb(199, 210, 254), Color.FromArgb(67, 56, 202), Color.FromArgb(99, 102, 241)}
                                    Dim display = Math.Min(4, slices.Count)
                                    Dim angle As Single = 0
                                    For i = 0 To display - 1
                                        Dim part = slices(i).Value
                                        Dim sweep = CSng((part / total) * 360.0)
                                        Using br As New SolidBrush(colors(i Mod colors.Length))
                                            g.FillPie(br, rect, angle, sweep)
                                            g.FillRectangle(br, rect.Right + 10, rect.Top + (i * 20), 12, 12)
                                            Dim percentage As Double = Math.Round((part / total) * 100, 1)
                                            g.DrawString($"{slices(i).Key}: {If(title.Contains("Top", StringComparison.OrdinalIgnoreCase), $"{part:N0}", $"₱{part:N0}")} ({percentage}%)",
             New Font("Segoe UI", 8), Brushes.DimGray, rect.Right + 30, rect.Top + (i * 20))

                                        End Using
                                        angle += sweep
                                    Next
                                    If slices.Count > display Then
                                        Dim others = slices.Skip(display).Sum(Function(s) s.Value)
                                        Dim sweep = CSng((others / total) * 360.0)
                                        Dim othersPct As Double = Math.Round((others / total) * 100, 1)
                                        Using br As New SolidBrush(colors(display Mod colors.Length))
                                            g.FillPie(br, rect, angle, sweep)
                                            g.FillRectangle(br, rect.Right + 10, rect.Top + (display * 20), 12, 12)
                                            g.DrawString($"Others: {If(title.Contains("Top", StringComparison.OrdinalIgnoreCase), $"{others:N0}", $"₱{others:N0}")} ({othersPct}%)",
                                                         New Font("Segoe UI", 8), Brushes.DimGray, rect.Right + 30, rect.Top + (display * 20))
                                        End Using
                                    End If
                                End Sub

        Return panel
    End Function

    Private Function CreateManualLineGraph(title As String, dt As DataTable, panelWidth As Integer) As Panel
        Dim panel As New Panel With {
            .Width = panelWidth,
            .Height = 280,
            .BackColor = Color.White,
            .Margin = New Padding(10),
            .BorderStyle = BorderStyle.FixedSingle,
            .Name = "line_" & title.Replace(" ", "_")
        }
        Dim lbl As New Label With {.Text = title, .Font = New Font("Segoe UI Semibold", 12), .ForeColor = Color.Navy, .Location = New Point(15, 10), .AutoSize = True}
        panel.Controls.Add(lbl)

        AddHandler panel.Paint, Sub(sender, e)
                                    Dim g = e.Graphics
                                    g.SmoothingMode = SmoothingMode.AntiAlias
                                    Dim padLeft = 40, padRight = 20, padTop = 40, padBottom = 40
                                    Dim area = New Rectangle(padLeft, padTop, panel.ClientSize.Width - padLeft - padRight, panel.ClientSize.Height - padTop - padBottom)

                                    Dim values As New List(Of Double)
                                    Dim labels As New List(Of String)
                                    If dt IsNot Nothing Then
                                        For i = 0 To dt.Rows.Count - 1
                                            values.Add(SafeToDouble(dt.Rows(i).Item("DailyTotal")))
                                            If dt.Columns.Contains("SaleDay") AndAlso Not IsDBNull(dt.Rows(i).Item("SaleDay")) Then
                                                Dim parsed As DateTime
                                                If DateTime.TryParse(dt.Rows(i).Item("SaleDay").ToString(), parsed) Then
                                                    labels.Add(parsed.ToString("ddd"))
                                                Else
                                                    labels.Add(dt.Rows(i).Item("SaleDay").ToString())
                                                End If
                                            Else
                                                labels.Add($"P{i}")
                                            End If
                                        Next
                                    End If

                                    If values.Count = 0 OrElse values.Sum(Function(v) v) = 0 Then
                                        g.DrawString("No trend data", New Font("Segoe UI", 9), Brushes.Gray, area.Left + 10, area.Top + 10)
                                        Return
                                    End If

                                    Dim maxVal = Math.Max(1, values.Max())
                                    ' draw gridlines
                                    Using penGrid As New Pen(Color.FromArgb(230, 230, 230))
                                        For i = 0 To 4
                                            Dim y = area.Top + CInt(i * (area.Height / 4))
                                            g.DrawLine(penGrid, area.Left, y, area.Right, y)
                                        Next
                                    End Using

                                    ' compute points
                                    Dim pts As New List(Of PointF)
                                    Dim stepX = If(values.Count > 1, area.Width / (values.Count - 1), area.Width / 2.0F)
                                    For i = 0 To values.Count - 1
                                        Dim x = area.Left + (i * stepX)
                                        Dim y = area.Bottom - CSng((values(i) / maxVal) * area.Height)
                                        pts.Add(New PointF(x, y))
                                    Next

                                    ' fill area
                                    If pts.Count > 1 Then
                                        Using path As New Drawing2D.GraphicsPath()
                                            path.AddLines(pts.ToArray())
                                            path.AddLine(pts.Last().X, area.Bottom, pts.First().X, area.Bottom)
                                            Using brush As New LinearGradientBrush(area, Color.FromArgb(100, 79, 70, 229), Color.Transparent, LinearGradientMode.Vertical)
                                                g.FillPath(brush, path)
                                            End Using
                                        End Using
                                        Using p As New Pen(Color.FromArgb(79, 70, 229), 2)
                                            g.DrawLines(p, pts.ToArray())
                                        End Using
                                    Else
                                        ' single point
                                        Dim pt = pts(0)
                                        g.FillEllipse(Brushes.White, pt.X - 5, pt.Y - 5, 10, 10)
                                        g.DrawEllipse(New Pen(Color.RoyalBlue, 2), pt.X - 5, pt.Y - 5, 10, 10)
                                    End If

                                    ' draw markers and labels
                                    For i = 0 To pts.Count - 1
                                        g.FillEllipse(Brushes.White, pts(i).X - 4, pts(i).Y - 4, 8, 8)
                                        g.DrawEllipse(New Pen(Color.RoyalBlue, 2), pts(i).X - 4, pts(i).Y - 4, 8, 8)
                                        Dim dayTxt = If(labels.Count > i, labels(i), "")
                                        g.DrawString(dayTxt, New Font("Segoe UI", 7), Brushes.Gray, pts(i).X - 10, area.Bottom + 4)
                                        Dim valTxt = If(maxVal = 0, "0%", (values(i) / maxVal).ToString("P1"))
                                        g.DrawString(valTxt, New Font("Segoe UI", 7), Brushes.DimGray, pts(i).X - 10, pts(i).Y - 16)
                                    Next
                                End Sub

        Return panel
    End Function

    Private Function CreateDailyRevenueTrend(title As String, dt As DataTable, panelWidth As Integer) As Panel
        ' reuse CreateManualLineGraph behavior but with different title/icon styling
        Dim p = CreateManualLineGraph(title, dt, panelWidth)
        ' add icon/title color tweak
        Return p
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
        Dim card As New Panel With {
        .Width = 280,
        .Height = 140,
        .BackColor = Color.White,
        .Margin = New Padding(15),
        .Cursor = Cursors.Hand
    }

        Dim lblT As New Label With {.Text = title.ToUpper(), .Font = New Font("Segoe UI Semibold", 11), .ForeColor = Color.Navy, .Location = New Point(20, 20), .AutoSize = True}
        Dim lblV As New Label With {.Text = value, .Font = New Font("Segoe UI Variable Display", 28, FontStyle.Bold), .ForeColor = Color.FromArgb(30, 41, 59), .Location = New Point(15, 50), .AutoSize = True}
        Dim lblIcon As New Label With {.Text = icon, .Font = New Font("Segoe UI", 24), .ForeColor = Color.Navy, .Location = New Point(210, 80), .AutoSize = True}

        AddHandler card.Paint, AddressOf Card_Paint
        card.Controls.Add(lblT)
        card.Controls.Add(lblV)
        card.Controls.Add(lblIcon)

        ' Apply hover effect
        ApplyHoverEffect(card)

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

        ' Rounded shadow (offset path)
        Dim shadowOffset As Integer = 4
        Dim shadowRect As New Rectangle(rect.X + shadowOffset, rect.Y + shadowOffset, rect.Width, rect.Height)

        Using shadowPath As GraphicsPath = GetRoundedRectPath(shadowRect, radius)
            Using shadowBrush As New SolidBrush(Color.FromArgb(50, 0, 0, 0))
                g.FillPath(shadowBrush, shadowPath)
            End Using
        End Using

        ' Rounded card
        Using path As GraphicsPath = GetRoundedRectPath(rect, radius)
            g.FillPath(New SolidBrush(pnl.BackColor), path)
            g.DrawPath(New Pen(Color.FromArgb(200, 200, 200)), path)
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

    ' Helper: safely convert to double, returning 0 on null/invalid
    Private Function SafeToDouble(obj As Object) As Double
        If obj Is Nothing OrElse IsDBNull(obj) Then Return 0
        Dim s = obj.ToString().Trim()
        Dim d As Double
        If Double.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, d) Then
            Return d
        End If
        Return 0
    End Function
    ' Enhanced hover effect for summary cards
    Private Sub ApplyHoverEffect(card As Panel)
        AddHandler card.MouseEnter,
        Sub(sender, e)
            Dim pnl = DirectCast(sender, Panel)
            pnl.BackColor = Color.FromArgb(230, 240, 255) ' stronger highlight
            pnl.BorderStyle = BorderStyle.FixedSingle
            pnl.Padding = New Padding(2)

            ' Add shadow effect by redrawing
            pnl.Invalidate()
        End Sub

        AddHandler card.MouseLeave,
        Sub(sender, e)
            Dim pnl = DirectCast(sender, Panel)
            pnl.BackColor = Color.White ' reset
            pnl.BorderStyle = BorderStyle.None
            pnl.Padding = New Padding(0)

            pnl.Invalidate()
        End Sub
    End Sub
    Private Function CreateGaugeChart(title As String, value As Double, maxValue As Double, panelWidth As Integer) As Panel
        Dim panel As New Panel With {
        .Width = panelWidth,
        .Height = 200,
        .BackColor = Color.White,
        .Margin = New Padding(10),
        .BorderStyle = BorderStyle.FixedSingle,
        .Name = "gauge_" & title.Replace(" ", "_")
    }

        Dim lbl As New Label With {
        .Text = title,
        .Font = New Font("Segoe UI Semibold", 12),
        .ForeColor = Color.Navy,
        .Location = New Point(15, 10),
        .AutoSize = True
    }
        panel.Controls.Add(lbl)

        AddHandler panel.Paint, Sub(sender, e)
                                    Dim g = e.Graphics
                                    g.SmoothingMode = SmoothingMode.AntiAlias

                                    ' Semi-circle gauge
                                    Dim rect As New Rectangle(20, 40, panel.Width - 40, panel.Height - 60)
                                    Dim sweepAngle As Single = CSng((value / maxValue) * 180)

                                    ' Background arc
                                    Using bgPen As New Pen(Color.LightGray, 20)
                                        g.DrawArc(bgPen, rect, 180, 180)
                                    End Using

                                    ' Progress arc
                                    Using fgPen As New Pen(Color.FromArgb(79, 70, 229), 20)
                                        g.DrawArc(fgPen, rect, 180, sweepAngle)
                                    End Using

                                    ' Value text
                                    Dim txt As String = $"{value:N0}/{maxValue:N0}"
                                    Dim txtSize = g.MeasureString(txt, New Font("Segoe UI", 10, FontStyle.Bold))
                                    g.DrawString(txt, New Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black,
                                             rect.Left + rect.Width \ 2 - txtSize.Width \ 2,
                                             rect.Bottom - 20)
                                End Sub

        Return panel
    End Function

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub flpinventoryinsights_Paint(sender As Object, e As PaintEventArgs) Handles flpinventoryinsights.Paint

    End Sub
End Class
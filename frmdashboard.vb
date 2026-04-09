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
        'hideuser button
        SecurityManager.ApplyRestrictions(Me)
        ' 2. Setup Refresh Timer (5 seconds)
        DashboardTimer.Interval = 5000
        DashboardTimer.Start()
        ' 3. Initial Data Load
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
        ' Prevents visual lag during the refresh
        MainStatsContainer.SuspendLayout()
        ClearPanelControls(MainStatsContainer)

        Try
            ' Add all cards to the same container with icons
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

    ' --- HELPERS (Defining these ONLY ONCE) ---

    ' Changed to "container As Control" to handle both FlowLayoutPanel and Panels
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

        ' Subtitle - Using Gray for a modern look
        Dim lblT As New Label With {
        .Text = title.ToUpper(),
        .Font = New Font("Segoe UI Semibold", 11),
        .ForeColor = Color.Navy,
        .Location = New Point(20, 20),
        .AutoSize = True
    }

        ' Value - Large, bold Slate Blue color
        Dim lblV As New Label With {
        .Text = value,
        .Font = New Font("Segoe UI Variable Display", 28, FontStyle.Bold),
        .ForeColor = Color.FromArgb(30, 41, 59),
        .Location = New Point(15, 50),
        .AutoSize = True
    }

        ' Background Icon - Faint large emoji or symbol
        Dim lblIcon As New Label With {
        .Text = icon,
        .Font = New Font("Segoe UI", 24),
        .ForeColor = Color.Navy,
        .Location = New Point(210, 80),
        .AutoSize = True
    }

        ' Reuse your existing Card_Paint for the rounded corners and shadows
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

    ' --- GDI+ PAINTING FOR ROUNDED CORNERS & SHADOWS ---
    Private Sub Card_Paint(sender As Object, e As PaintEventArgs)
        Dim pnl = DirectCast(sender, Panel)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim radius As Integer = 20
        Dim rect As New Rectangle(0, 0, pnl.Width - 5, pnl.Height - 5)

        Using path As GraphicsPath = GetRoundedRectPath(rect, radius)
            ' Draw Shadow
            Dim shadowRect = rect
            shadowRect.Offset(3, 3)
            Using shadowPath As GraphicsPath = GetRoundedRectPath(shadowRect, radius)
                g.FillPath(New SolidBrush(Color.FromArgb(30, Color.Black)), shadowPath)
            End Using
            ' Draw Background
            g.FillPath(New SolidBrush(pnl.BackColor), path)
            ' Draw Border
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

    Private Sub Card_MouseEnter(sender As Object, e As EventArgs)
        DirectCast(sender, Panel).BackColor = Color.FromArgb(245, 250, 255)
    End Sub

    Private Sub Card_MouseLeave(sender As Object, e As EventArgs)
        DirectCast(sender, Panel).BackColor = Color.White
    End Sub

    ' --- NAVIGATION BUTTONS ---
    ' Ensure these buttons (btnOpenPOS, etc) exist in your Designer!
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs)
        pos.Show()
    End Sub

    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs)
        frmInventory.Show()
    End Sub

    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs)
        frmSalesHIstory.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        User.Show()
    End Sub

    ' --- LOGOUT LOGIC ---
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        ' 1. Ask for confirmation
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' 2. Stop the timers to prevent background errors while closing
            Timer1.Stop()
            DashboardTimer.Stop()

            ' 3. Clear Global Session Data for security
            CurrentUser = ""
            UserRole = ""

            ' 4. Show the Login Form (Ensure the name matches your login form, e.g., frmLogin)
            ' Using a new instance to ensure a fresh state
            Dim loginForm As New FrmLogin
            loginForm.Show()

            ' 5. Close this Dashboard
            Dispose()
        End If
    End Sub

    Private Sub flptotalproducts_Paint(sender As Object, e As PaintEventArgs) Handles MainStatsContainer.Paint

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class
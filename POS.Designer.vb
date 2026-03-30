<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlHeader = New Panel()
        lblTime = New Label()
        Label24 = New Label()
        Label2 = New Label()
        lblTitle = New Label()
        pnlWeeklyRevenue = New Panel()
        Label5 = New Label()
        pnlTodaysSales = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel7 = New Panel()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        Button18 = New Button()
        Label25 = New Label()
        Timer1 = New Timer(components)
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Button1 = New Button()
        Button2 = New Button()
        tabWeeklyReports = New TabPage()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label13 = New Label()
        lblWeeklyReport = New Label()
        lblCategory = New Label()
        btnPreviousWeek = New Button()
        btnRefresh = New Button()
        lblWeekStarting = New Label()
        btnNextWeek = New Button()
        DataGridView2 = New DataGridView()
        colAvgTransaction = New DataGridViewTextBoxColumn()
        colRevenue = New DataGridViewTextBoxColumn()
        colItemsSold = New DataGridViewTextBoxColumn()
        colTransactions = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colDay = New DataGridViewTextBoxColumn()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label1 = New Label()
        Label15 = New Label()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label9 = New Label()
        Label8 = New Label()
        Inventory = New TabControl()
        Button3 = New Button()
        pnlHeader.SuspendLayout()
        pnlWeeklyRevenue.SuspendLayout()
        pnlTodaysSales.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel3.SuspendLayout()
        Guna2CustomGradientPanel4.SuspendLayout()
        tabWeeklyReports.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel1.SuspendLayout()
        Guna2CustomGradientPanel2.SuspendLayout()
        Inventory.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(lblTime)
        pnlHeader.Controls.Add(Label24)
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(181, 4)
        pnlHeader.Margin = New Padding(4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(2224, 131)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(1724, 94)
        lblTime.Margin = New Padding(4, 0, 4, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(127, 37)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(9, 40)
        Label24.Margin = New Padding(4, 0, 4, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(267, 62)
        Label24.TabIndex = 9
        Label24.Text = "Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(321, 86)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(599, 32)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(268, 11)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1310, 68)
        lblTitle.TabIndex = 0
        lblTitle.Text = "POS - Inventory Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlWeeklyRevenue
        ' 
        pnlWeeklyRevenue.BackColor = Color.White
        pnlWeeklyRevenue.BorderStyle = BorderStyle.FixedSingle
        pnlWeeklyRevenue.Controls.Add(Label5)
        pnlWeeklyRevenue.Location = New Point(1861, 162)
        pnlWeeklyRevenue.Margin = New Padding(4)
        pnlWeeklyRevenue.Name = "pnlWeeklyRevenue"
        pnlWeeklyRevenue.Size = New Size(328, 144)
        pnlWeeklyRevenue.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(80, 99)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 28)
        Label5.TabIndex = 0
        Label5.Text = "Weekly Revenue"
        ' 
        ' pnlTodaysSales
        ' 
        pnlTodaysSales.BackColor = Color.White
        pnlTodaysSales.BorderStyle = BorderStyle.FixedSingle
        pnlTodaysSales.Controls.Add(Label4)
        pnlTodaysSales.Location = New Point(1309, 162)
        pnlTodaysSales.Margin = New Padding(4)
        pnlTodaysSales.Name = "pnlTodaysSales"
        pnlTodaysSales.Size = New Size(323, 144)
        pnlTodaysSales.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(98, 99)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 28)
        Label4.TabIndex = 0
        Label4.Text = "Today’s Sales"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(54, 16)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 0
        Label3.Text = "Items in Stock"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.CornflowerBlue
        Panel7.Controls.Add(Button3)
        Panel7.Controls.Add(Button2)
        Panel7.Controls.Add(Button1)
        Panel7.Controls.Add(btnUploadPictures)
        Panel7.Controls.Add(PictureBox3)
        Panel7.Controls.Add(Button18)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Margin = New Padding(4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(179, 1331)
        Panel7.TabIndex = 4
        ' 
        ' btnUploadPictures
        ' 
        btnUploadPictures.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadPictures.Location = New Point(26, 152)
        btnUploadPictures.Margin = New Padding(4, 2, 4, 2)
        btnUploadPictures.Name = "btnUploadPictures"
        btnUploadPictures.Size = New Size(129, 29)
        btnUploadPictures.TabIndex = 1
        btnUploadPictures.Text = "Upload Pictures"
        btnUploadPictures.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 15)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(159, 131)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = SystemColors.Info
        Button18.Location = New Point(15, 1206)
        Button18.Margin = New Padding(4)
        Button18.Name = "Button18"
        Button18.Size = New Size(146, 38)
        Button18.TabIndex = 8
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(36, 18)
        Label25.Margin = New Padding(4, 0, 4, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(140, 25)
        Label25.TabIndex = 0
        Label25.Text = "Total Products"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.DarkBlue
        Guna2CustomGradientPanel3.BorderRadius = 25
        Guna2CustomGradientPanel3.Controls.Add(Label25)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel3.Location = New Point(198, 149)
        Guna2CustomGradientPanel3.Margin = New Padding(4, 2, 4, 2)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel3.Size = New Size(330, 165)
        Guna2CustomGradientPanel3.TabIndex = 22
        ' 
        ' Guna2CustomGradientPanel4
        ' 
        Guna2CustomGradientPanel4.BackColor = Color.Transparent
        Guna2CustomGradientPanel4.BorderColor = Color.DarkBlue
        Guna2CustomGradientPanel4.BorderRadius = 25
        Guna2CustomGradientPanel4.Controls.Add(Label3)
        Guna2CustomGradientPanel4.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel4.Location = New Point(691, 149)
        Guna2CustomGradientPanel4.Margin = New Padding(4, 2, 4, 2)
        Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Guna2CustomGradientPanel4.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel4.Size = New Size(330, 165)
        Guna2CustomGradientPanel4.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(36, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Products"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(36, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Inventory"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' tabWeeklyReports
        ' 
        tabWeeklyReports.BackColor = Color.White
        tabWeeklyReports.Controls.Add(Guna2CustomGradientPanel2)
        tabWeeklyReports.Controls.Add(Guna2CustomGradientPanel1)
        tabWeeklyReports.Controls.Add(DataGridView2)
        tabWeeklyReports.Controls.Add(btnNextWeek)
        tabWeeklyReports.Controls.Add(lblWeekStarting)
        tabWeeklyReports.Controls.Add(btnRefresh)
        tabWeeklyReports.Controls.Add(btnPreviousWeek)
        tabWeeklyReports.Controls.Add(lblCategory)
        tabWeeklyReports.Controls.Add(lblWeeklyReport)
        tabWeeklyReports.Controls.Add(Label13)
        tabWeeklyReports.Controls.Add(ComboBox1)
        tabWeeklyReports.Controls.Add(DateTimePicker1)
        tabWeeklyReports.Location = New Point(4, 30)
        tabWeeklyReports.Margin = New Padding(4)
        tabWeeklyReports.Name = "tabWeeklyReports"
        tabWeeklyReports.Padding = New Padding(4)
        tabWeeklyReports.Size = New Size(1396, 966)
        tabWeeklyReports.TabIndex = 2
        tabWeeklyReports.Text = "Weekly Reports"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(795, 20)
        DateTimePicker1.Margin = New Padding(4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(274, 29)
        DateTimePicker1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(1254, 20)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 29)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "All Categories"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(280, 80)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(157, 23)
        Label13.TabIndex = 2
        Label13.Text = "UpdateWeekLabel"
        ' 
        ' lblWeeklyReport
        ' 
        lblWeeklyReport.AutoSize = True
        lblWeeklyReport.BackColor = Color.Transparent
        lblWeeklyReport.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeeklyReport.ForeColor = Color.Navy
        lblWeeklyReport.Location = New Point(30, 8)
        lblWeeklyReport.Margin = New Padding(4, 0, 4, 0)
        lblWeeklyReport.Name = "lblWeeklyReport"
        lblWeeklyReport.Size = New Size(305, 41)
        lblWeeklyReport.TabIndex = 9
        lblWeeklyReport.Text = "Weekly Sales Report"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.DarkBlue
        lblCategory.Location = New Point(1099, 16)
        lblCategory.Margin = New Padding(4, 0, 4, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(125, 32)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Category:"
        ' 
        ' btnPreviousWeek
        ' 
        btnPreviousWeek.BackColor = Color.White
        btnPreviousWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreviousWeek.Location = New Point(30, 71)
        btnPreviousWeek.Margin = New Padding(4)
        btnPreviousWeek.Name = "btnPreviousWeek"
        btnPreviousWeek.Size = New Size(198, 36)
        btnPreviousWeek.TabIndex = 14
        btnPreviousWeek.Text = "<  Previous Week"
        btnPreviousWeek.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Navy
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1254, 62)
        btnRefresh.Margin = New Padding(4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(146, 49)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "🔄  Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblWeekStarting
        ' 
        lblWeekStarting.AutoSize = True
        lblWeekStarting.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeekStarting.ForeColor = Color.Navy
        lblWeekStarting.Location = New Point(594, 20)
        lblWeekStarting.Margin = New Padding(4, 0, 4, 0)
        lblWeekStarting.Name = "lblWeekStarting"
        lblWeekStarting.Size = New Size(181, 32)
        lblWeekStarting.TabIndex = 16
        lblWeekStarting.Text = "Week Starting:"
        ' 
        ' btnNextWeek
        ' 
        btnNextWeek.BackColor = Color.White
        btnNextWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNextWeek.Location = New Point(488, 71)
        btnNextWeek.Margin = New Padding(4)
        btnNextWeek.Name = "btnNextWeek"
        btnNextWeek.Size = New Size(146, 36)
        btnNextWeek.TabIndex = 17
        btnNextWeek.Text = "Next Week >"
        btnNextWeek.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {colDay, colDate, colTransactions, colItemsSold, colRevenue, colAvgTransaction})
        DataGridView2.Location = New Point(30, 415)
        DataGridView2.Margin = New Padding(4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1375, 458)
        DataGridView2.TabIndex = 20
        ' 
        ' colAvgTransaction
        ' 
        colAvgTransaction.HeaderText = "Avg. Transaction"
        colAvgTransaction.MinimumWidth = 6
        colAvgTransaction.Name = "colAvgTransaction"
        colAvgTransaction.Width = 125
        ' 
        ' colRevenue
        ' 
        colRevenue.HeaderText = "Revenue"
        colRevenue.MinimumWidth = 6
        colRevenue.Name = "colRevenue"
        colRevenue.Width = 125
        ' 
        ' colItemsSold
        ' 
        colItemsSold.HeaderText = "Items Sold"
        colItemsSold.MinimumWidth = 6
        colItemsSold.Name = "colItemsSold"
        colItemsSold.Width = 125
        ' 
        ' colTransactions
        ' 
        colTransactions.HeaderText = "Transactions"
        colTransactions.MinimumWidth = 6
        colTransactions.Name = "colTransactions"
        colTransactions.Width = 125
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.Width = 125
        ' 
        ' colDay
        ' 
        colDay.HeaderText = "Day"
        colDay.MinimumWidth = 6
        colDay.Name = "colDay"
        colDay.Width = 125
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.DarkBlue
        Guna2CustomGradientPanel1.BorderRadius = 40
        Guna2CustomGradientPanel1.Controls.Add(Label15)
        Guna2CustomGradientPanel1.Controls.Add(Label1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2CustomGradientPanel1.Location = New Point(74, 151)
        Guna2CustomGradientPanel1.Margin = New Padding(4, 2, 4, 2)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2CustomGradientPanel1.Size = New Size(598, 215)
        Guna2CustomGradientPanel1.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(40, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 0
        Label1.Text = "₱  Revenue Summary"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.DodgerBlue
        Label15.Location = New Point(40, 65)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(25, 28)
        Label15.TabIndex = 1
        Label15.Text = "₱"
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.BackColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderColor = Color.DarkBlue
        Guna2CustomGradientPanel2.BorderRadius = 40
        Guna2CustomGradientPanel2.Controls.Add(Label8)
        Guna2CustomGradientPanel2.Controls.Add(Label9)
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges5
        Guna2CustomGradientPanel2.Location = New Point(714, 151)
        Guna2CustomGradientPanel2.Margin = New Padding(4, 2, 4, 2)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomGradientPanel2.Size = New Size(598, 215)
        Guna2CustomGradientPanel2.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(40, 18)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(201, 25)
        Label9.TabIndex = 0
        Label9.Text = "₱  Revenue Summary"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DodgerBlue
        Label8.Location = New Point(40, 65)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(25, 28)
        Label8.TabIndex = 1
        Label8.Text = "₱"
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(tabWeeklyReports)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(198, 331)
        Inventory.Margin = New Padding(4)
        Inventory.Multiline = True
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(1404, 1000)
        Inventory.TabIndex = 2
        Inventory.Tag = "."
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(25, 376)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 36)
        Button3.TabIndex = 12
        Button3.Text = "Sales History"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.LightGray
        ClientSize = New Size(1336, 1055)
        Controls.Add(Guna2CustomGradientPanel4)
        Controls.Add(Inventory)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(pnlHeader)
        Controls.Add(pnlTodaysSales)
        Controls.Add(pnlWeeklyRevenue)
        Controls.Add(Panel7)
        KeyPreview = True
        Margin = New Padding(4)
        MinimumSize = New Size(996, 738)
        Name = "frmPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlWeeklyRevenue.ResumeLayout(False)
        pnlWeeklyRevenue.PerformLayout()
        pnlTodaysSales.ResumeLayout(False)
        pnlTodaysSales.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        Guna2CustomGradientPanel4.ResumeLayout(False)
        Guna2CustomGradientPanel4.PerformLayout()
        tabWeeklyReports.ResumeLayout(False)
        tabWeeklyReports.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        Guna2CustomGradientPanel2.ResumeLayout(False)
        Guna2CustomGradientPanel2.PerformLayout()
        Inventory.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlWeeklyRevenue As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlTodaysSales As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button18 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tabWeeklyReports As TabPage
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents colDay As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTransactions As DataGridViewTextBoxColumn
    Friend WithEvents colItemsSold As DataGridViewTextBoxColumn
    Friend WithEvents colRevenue As DataGridViewTextBoxColumn
    Friend WithEvents colAvgTransaction As DataGridViewTextBoxColumn
    Friend WithEvents btnNextWeek As Button
    Friend WithEvents lblWeekStarting As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPreviousWeek As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblWeeklyReport As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Inventory As TabControl

End Class

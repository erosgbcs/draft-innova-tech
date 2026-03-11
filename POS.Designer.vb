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
        pnlHeader = New Panel()
        lblTime = New Label()
        Label24 = New Label()
        Label2 = New Label()
        lblTitle = New Label()
        pnlWeeklyRevenue = New Panel()
        Label5 = New Label()
        pnlTodaysSales = New Panel()
        Label4 = New Label()
        pnlItemsStock = New Panel()
        Label3 = New Label()
        lblAvailableProducts = New Label()
        TextBox1 = New TextBox()
        Inventory = New TabControl()
        tabProducts = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        tabInventory = New TabPage()
        Button2 = New Button()
        TextBox7 = New TextBox()
        TextBox5 = New TextBox()
        txtCategory = New TextBox()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        lblInventoryManagement = New Label()
        txtProductCode = New TextBox()
        Button1 = New Button()
        dv = New DataGridView()
        tabWeeklyReports = New TabPage()
        DataGridView2 = New DataGridView()
        colDay = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colTransactions = New DataGridViewTextBoxColumn()
        colItemsSold = New DataGridViewTextBoxColumn()
        colRevenue = New DataGridViewTextBoxColumn()
        colAvgTransaction = New DataGridViewTextBoxColumn()
        Panel10 = New Panel()
        Label16 = New Label()
        Label14 = New Label()
        Panel9 = New Panel()
        Label15 = New Label()
        Label1 = New Label()
        btnNextWeek = New Button()
        lblWeekStarting = New Label()
        btnRefresh = New Button()
        btnPreviousWeek = New Button()
        lblCategory = New Label()
        lblWeeklyReport = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        tabSalesHistory = New TabPage()
        Panel1 = New Panel()
        Label22 = New Label()
        Label26 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        lblSalesHistory = New Label()
        txtSearchHistory = New TextBox()
        DataGridView3 = New DataGridView()
        SalesDate = New DataGridViewTextBoxColumn()
        SalesTime = New DataGridViewTextBoxColumn()
        SalesBuyer = New DataGridViewTextBoxColumn()
        SalesTotal = New DataGridViewTextBoxColumn()
        pnlShoppingCart = New Panel()
        Panel6 = New Panel()
        btnCheckout = New Button()
        lblTotal = New Label()
        lblSubtotal = New Label()
        txtBuyer = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblShoppingCart = New Label()
        Panel7 = New Panel()
        Button18 = New Button()
        pnlTotalProducts = New Panel()
        Label25 = New Label()
        Timer1 = New Timer(components)
        pnlHeader.SuspendLayout()
        pnlWeeklyRevenue.SuspendLayout()
        pnlTodaysSales.SuspendLayout()
        pnlItemsStock.SuspendLayout()
        Inventory.SuspendLayout()
        tabProducts.SuspendLayout()
        tabInventory.SuspendLayout()
        CType(dv, ComponentModel.ISupportInitialize).BeginInit()
        tabWeeklyReports.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        tabSalesHistory.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        pnlShoppingCart.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        pnlTotalProducts.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(lblTime)
        pnlHeader.Controls.Add(Label24)
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(145, 3)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1779, 105)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(1549, 6)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(72, 21)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(3, 22)
        Label24.Name = "Label24"
        Label24.Size = New Size(211, 50)
        Label24.TabIndex = 9
        Label24.Text = "Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(257, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(472, 25)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(160, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1048, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "POS - Inventory Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlWeeklyRevenue
        ' 
        pnlWeeklyRevenue.BackColor = Color.White
        pnlWeeklyRevenue.BorderStyle = BorderStyle.FixedSingle
        pnlWeeklyRevenue.Controls.Add(Label5)
        pnlWeeklyRevenue.Location = New Point(1489, 130)
        pnlWeeklyRevenue.Name = "pnlWeeklyRevenue"
        pnlWeeklyRevenue.Size = New Size(263, 116)
        pnlWeeklyRevenue.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(64, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 21)
        Label5.TabIndex = 0
        Label5.Text = "Weekly Revenue"
        ' 
        ' pnlTodaysSales
        ' 
        pnlTodaysSales.BackColor = Color.White
        pnlTodaysSales.BorderStyle = BorderStyle.FixedSingle
        pnlTodaysSales.Controls.Add(Label4)
        pnlTodaysSales.Location = New Point(1047, 130)
        pnlTodaysSales.Name = "pnlTodaysSales"
        pnlTodaysSales.Size = New Size(259, 116)
        pnlTodaysSales.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(78, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 21)
        Label4.TabIndex = 0
        Label4.Text = "Today’s Sales"
        ' 
        ' pnlItemsStock
        ' 
        pnlItemsStock.BackColor = Color.White
        pnlItemsStock.BorderStyle = BorderStyle.FixedSingle
        pnlItemsStock.Controls.Add(Label3)
        pnlItemsStock.Location = New Point(595, 130)
        pnlItemsStock.Name = "pnlItemsStock"
        pnlItemsStock.Size = New Size(240, 116)
        pnlItemsStock.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(67, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 21)
        Label3.TabIndex = 0
        Label3.Text = "Items in Stock"
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = Color.Navy
        lblAvailableProducts.Location = New Point(874, 3)
        lblAvailableProducts.Name = "lblAvailableProducts"
        lblAvailableProducts.Size = New Size(257, 37)
        lblAvailableProducts.TabIndex = 5
        lblAvailableProducts.Text = "Available Products"
        lblAvailableProducts.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(6, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(1125, 25)
        TextBox1.TabIndex = 3
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(tabProducts)
        Inventory.Controls.Add(tabInventory)
        Inventory.Controls.Add(tabWeeklyReports)
        Inventory.Controls.Add(tabSalesHistory)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(148, 267)
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(1148, 794)
        Inventory.TabIndex = 2
        Inventory.Tag = "."
        ' 
        ' tabProducts
        ' 
        tabProducts.BackColor = Color.White
        tabProducts.Controls.Add(TextBox1)
        tabProducts.Controls.Add(FlowLayoutPanel1)
        tabProducts.Controls.Add(lblAvailableProducts)
        tabProducts.Location = New Point(4, 26)
        tabProducts.Name = "tabProducts"
        tabProducts.Padding = New Padding(3)
        tabProducts.Size = New Size(1140, 764)
        tabProducts.TabIndex = 0
        tabProducts.Text = "Products"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Silver
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(6, 85)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1125, 667)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' tabInventory
        ' 
        tabInventory.Controls.Add(Button2)
        tabInventory.Controls.Add(TextBox7)
        tabInventory.Controls.Add(TextBox5)
        tabInventory.Controls.Add(txtCategory)
        tabInventory.Controls.Add(txtProductName)
        tabInventory.Controls.Add(txtPrice)
        tabInventory.Controls.Add(lblInventoryManagement)
        tabInventory.Controls.Add(txtProductCode)
        tabInventory.Controls.Add(Button1)
        tabInventory.Controls.Add(dv)
        tabInventory.Location = New Point(4, 26)
        tabInventory.Name = "tabInventory"
        tabInventory.Padding = New Padding(3)
        tabInventory.Size = New Size(1140, 764)
        tabInventory.TabIndex = 1
        tabInventory.Text = "Inventory"
        tabInventory.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(6, 713)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 39)
        Button2.TabIndex = 3
        Button2.Text = "Export CSV"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(6, 49)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Product Inventory by code or name.."
        TextBox7.Size = New Size(1125, 27)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(743, 673)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Stock"
        TextBox5.Size = New Size(153, 25)
        TextBox5.TabIndex = 3
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(372, 673)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(153, 25)
        txtCategory.TabIndex = 3
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(186, 673)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(153, 25)
        txtProductName.TabIndex = 3
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(554, 673)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(153, 25)
        txtPrice.TabIndex = 3
        ' 
        ' lblInventoryManagement
        ' 
        lblInventoryManagement.AutoSize = True
        lblInventoryManagement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryManagement.ForeColor = Color.Navy
        lblInventoryManagement.Location = New Point(857, 6)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(284, 32)
        lblInventoryManagement.TabIndex = 3
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Location = New Point(6, 673)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(153, 25)
        txtProductCode.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(930, 668)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 44)
        Button1.TabIndex = 3
        Button1.Text = "Add Product"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dv
        ' 
        dv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dv.Location = New Point(6, 82)
        dv.Name = "dv"
        dv.Size = New Size(1125, 570)
        dv.TabIndex = 4
        ' 
        ' tabWeeklyReports
        ' 
        tabWeeklyReports.BackColor = Color.White
        tabWeeklyReports.Controls.Add(DataGridView2)
        tabWeeklyReports.Controls.Add(Panel10)
        tabWeeklyReports.Controls.Add(Panel9)
        tabWeeklyReports.Controls.Add(btnNextWeek)
        tabWeeklyReports.Controls.Add(lblWeekStarting)
        tabWeeklyReports.Controls.Add(btnRefresh)
        tabWeeklyReports.Controls.Add(btnPreviousWeek)
        tabWeeklyReports.Controls.Add(lblCategory)
        tabWeeklyReports.Controls.Add(lblWeeklyReport)
        tabWeeklyReports.Controls.Add(Label13)
        tabWeeklyReports.Controls.Add(ComboBox1)
        tabWeeklyReports.Controls.Add(DateTimePicker1)
        tabWeeklyReports.Location = New Point(4, 26)
        tabWeeklyReports.Name = "tabWeeklyReports"
        tabWeeklyReports.Padding = New Padding(3)
        tabWeeklyReports.Size = New Size(1140, 764)
        tabWeeklyReports.TabIndex = 2
        tabWeeklyReports.Text = "Weekly Reports"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {colDay, colDate, colTransactions, colItemsSold, colRevenue, colAvgTransaction})
        DataGridView2.Location = New Point(24, 332)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(1100, 366)
        DataGridView2.TabIndex = 20
        ' 
        ' colDay
        ' 
        colDay.HeaderText = "Day"
        colDay.Name = "colDay"
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.Name = "colDate"
        ' 
        ' colTransactions
        ' 
        colTransactions.HeaderText = "Transactions"
        colTransactions.Name = "colTransactions"
        ' 
        ' colItemsSold
        ' 
        colItemsSold.HeaderText = "Items Sold"
        colItemsSold.Name = "colItemsSold"
        ' 
        ' colRevenue
        ' 
        colRevenue.HeaderText = "Revenue"
        colRevenue.Name = "colRevenue"
        ' 
        ' colAvgTransaction
        ' 
        colAvgTransaction.HeaderText = "Avg. Transaction"
        colAvgTransaction.Name = "colAvgTransaction"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(Label16)
        Panel10.Controls.Add(Label14)
        Panel10.Location = New Point(608, 122)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(516, 194)
        Panel10.TabIndex = 19
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.DodgerBlue
        Label16.Location = New Point(26, 50)
        Label16.Name = "Label16"
        Label16.Size = New Size(20, 21)
        Label16.TabIndex = 1
        Label16.Text = "₱"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Navy
        Label14.Location = New Point(26, 13)
        Label14.Name = "Label14"
        Label14.Size = New Size(164, 20)
        Label14.TabIndex = 0
        Label14.Text = ChrW(55357) & ChrW(57042) & " Sales Performance"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(Label1)
        Panel9.Location = New Point(24, 122)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(472, 194)
        Panel9.TabIndex = 18
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.DodgerBlue
        Label15.Location = New Point(12, 50)
        Label15.Name = "Label15"
        Label15.Size = New Size(20, 21)
        Label15.TabIndex = 1
        Label15.Text = "₱"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(12, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 0
        Label1.Text = "₱  Revenue Summary"
        ' 
        ' btnNextWeek
        ' 
        btnNextWeek.BackColor = Color.White
        btnNextWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNextWeek.Location = New Point(390, 57)
        btnNextWeek.Name = "btnNextWeek"
        btnNextWeek.Size = New Size(117, 29)
        btnNextWeek.TabIndex = 17
        btnNextWeek.Text = "Next Week >"
        btnNextWeek.UseVisualStyleBackColor = False
        ' 
        ' lblWeekStarting
        ' 
        lblWeekStarting.AutoSize = True
        lblWeekStarting.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeekStarting.ForeColor = Color.Navy
        lblWeekStarting.Location = New Point(475, 16)
        lblWeekStarting.Name = "lblWeekStarting"
        lblWeekStarting.Size = New Size(144, 25)
        lblWeekStarting.TabIndex = 16
        lblWeekStarting.Text = "Week Starting:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Navy
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1003, 50)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(117, 39)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "🔄  Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnPreviousWeek
        ' 
        btnPreviousWeek.BackColor = Color.White
        btnPreviousWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreviousWeek.Location = New Point(24, 57)
        btnPreviousWeek.Name = "btnPreviousWeek"
        btnPreviousWeek.Size = New Size(158, 29)
        btnPreviousWeek.TabIndex = 14
        btnPreviousWeek.Text = "<  Previous Week"
        btnPreviousWeek.UseVisualStyleBackColor = False
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.DarkBlue
        lblCategory.Location = New Point(879, 13)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(99, 25)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Category:"
        ' 
        ' lblWeeklyReport
        ' 
        lblWeeklyReport.AutoSize = True
        lblWeeklyReport.BackColor = Color.Transparent
        lblWeeklyReport.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeeklyReport.ForeColor = Color.Navy
        lblWeeklyReport.Location = New Point(24, 6)
        lblWeeklyReport.Name = "lblWeeklyReport"
        lblWeeklyReport.Size = New Size(245, 32)
        lblWeeklyReport.TabIndex = 9
        lblWeeklyReport.Text = "Weekly Sales Report"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(224, 64)
        Label13.Name = "Label13"
        Label13.Size = New Size(119, 17)
        Label13.TabIndex = 2
        Label13.Text = "UpdateWeekLabel"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(1003, 16)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 25)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "All Categories"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(636, 16)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(220, 25)
        DateTimePicker1.TabIndex = 0
        ' 
        ' tabSalesHistory
        ' 
        tabSalesHistory.BackColor = Color.White
        tabSalesHistory.Controls.Add(Panel1)
        tabSalesHistory.Controls.Add(lblSalesHistory)
        tabSalesHistory.Controls.Add(txtSearchHistory)
        tabSalesHistory.Controls.Add(DataGridView3)
        tabSalesHistory.Location = New Point(4, 26)
        tabSalesHistory.Name = "tabSalesHistory"
        tabSalesHistory.Padding = New Padding(3)
        tabSalesHistory.Size = New Size(1140, 764)
        tabSalesHistory.TabIndex = 3
        tabSalesHistory.Text = "Sales History"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Location = New Point(19, 588)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1108, 155)
        Panel1.TabIndex = 3
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(894, 80)
        Label22.Name = "Label22"
        Label22.Size = New Size(153, 21)
        Label22.TabIndex = 4
        Label22.Text = "Recommendations"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(431, 80)
        Label26.Name = "Label26"
        Label26.Size = New Size(166, 21)
        Label26.TabIndex = 3
        Label26.Text = "Top Selling Products"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(21, 80)
        Label19.Name = "Label19"
        Label19.Size = New Size(182, 21)
        Label19.TabIndex = 1
        Label19.Text = "Low Stock Items (< 10)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Navy
        Label18.Location = New Point(21, 22)
        Label18.Name = "Label18"
        Label18.Size = New Size(174, 25)
        Label18.TabIndex = 0
        Label18.Text = "Inventory Insights"
        ' 
        ' lblSalesHistory
        ' 
        lblSalesHistory.AutoSize = True
        lblSalesHistory.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalesHistory.ForeColor = Color.Navy
        lblSalesHistory.Location = New Point(19, 12)
        lblSalesHistory.Name = "lblSalesHistory"
        lblSalesHistory.Size = New Size(215, 45)
        lblSalesHistory.TabIndex = 2
        lblSalesHistory.Text = "Sales History"
        ' 
        ' txtSearchHistory
        ' 
        txtSearchHistory.Location = New Point(767, 41)
        txtSearchHistory.Name = "txtSearchHistory"
        txtSearchHistory.PlaceholderText = "Search History Sales..."
        txtSearchHistory.Size = New Size(360, 25)
        txtSearchHistory.TabIndex = 1
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = Color.Silver
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {SalesDate, SalesTime, SalesBuyer, SalesTotal})
        DataGridView3.Location = New Point(19, 72)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(1108, 483)
        DataGridView3.TabIndex = 0
        ' 
        ' SalesDate
        ' 
        SalesDate.HeaderText = "Date"
        SalesDate.Name = "SalesDate"
        ' 
        ' SalesTime
        ' 
        SalesTime.HeaderText = "Time"
        SalesTime.Name = "SalesTime"
        ' 
        ' SalesBuyer
        ' 
        SalesBuyer.HeaderText = "Buyer"
        SalesBuyer.Name = "SalesBuyer"
        ' 
        ' SalesTotal
        ' 
        SalesTotal.HeaderText = "Total"
        SalesTotal.Name = "SalesTotal"
        ' 
        ' pnlShoppingCart
        ' 
        pnlShoppingCart.BackColor = Color.Silver
        pnlShoppingCart.Controls.Add(Panel6)
        pnlShoppingCart.Controls.Add(Label7)
        pnlShoppingCart.Controls.Add(Label6)
        pnlShoppingCart.Controls.Add(lblShoppingCart)
        pnlShoppingCart.Location = New Point(1334, 296)
        pnlShoppingCart.Name = "pnlShoppingCart"
        pnlShoppingCart.Size = New Size(562, 487)
        pnlShoppingCart.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(btnCheckout)
        Panel6.Controls.Add(lblTotal)
        Panel6.Controls.Add(lblSubtotal)
        Panel6.Controls.Add(txtBuyer)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label8)
        Panel6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel6.Location = New Point(38, 164)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(480, 249)
        Panel6.TabIndex = 3
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.Green
        btnCheckout.ForeColor = Color.White
        btnCheckout.Location = New Point(104, 159)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(329, 53)
        btnCheckout.TabIndex = 6
        btnCheckout.Text = "Checkout"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.Navy
        lblTotal.Location = New Point(322, 118)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(34, 25)
        lblTotal.TabIndex = 5
        lblTotal.Text = "₱  "
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtotal.Location = New Point(322, 87)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(26, 20)
        lblSubtotal.TabIndex = 4
        lblSubtotal.Text = "₱  "
        ' 
        ' txtBuyer
        ' 
        txtBuyer.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuyer.Location = New Point(182, 35)
        txtBuyer.Name = "txtBuyer"
        txtBuyer.PlaceholderText = "Buyer name"
        txtBuyer.Size = New Size(251, 27)
        txtBuyer.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 25)
        Label10.TabIndex = 2
        Label10.Text = "Total:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(11, 81)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 25)
        Label9.TabIndex = 1
        Label9.Text = "Subtotal:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(15, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 25)
        Label8.TabIndex = 0
        Label8.Text = "Buyer:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(169, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 21)
        Label7.TabIndex = 2
        Label7.Text = "Add products from the list"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(193, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 20)
        Label6.TabIndex = 1
        Label6.Text = "Your cart is empty"
        ' 
        ' lblShoppingCart
        ' 
        lblShoppingCart.AutoSize = True
        lblShoppingCart.BackColor = Color.Transparent
        lblShoppingCart.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShoppingCart.ForeColor = Color.Navy
        lblShoppingCart.Location = New Point(403, 15)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(156, 30)
        lblShoppingCart.TabIndex = 0
        lblShoppingCart.Text = "Shopping Cart"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LightSteelBlue
        Panel7.Controls.Add(Button18)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(143, 1061)
        Panel7.TabIndex = 4
        ' 
        ' Button18
        ' 
        Button18.BackColor = SystemColors.Info
        Button18.Location = New Point(12, 965)
        Button18.Name = "Button18"
        Button18.Size = New Size(117, 30)
        Button18.TabIndex = 8
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' pnlTotalProducts
        ' 
        pnlTotalProducts.BackColor = Color.White
        pnlTotalProducts.Controls.Add(Label25)
        pnlTotalProducts.Location = New Point(185, 130)
        pnlTotalProducts.Name = "pnlTotalProducts"
        pnlTotalProducts.Size = New Size(230, 116)
        pnlTotalProducts.TabIndex = 5
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(50, 81)
        Label25.Name = "Label25"
        Label25.Size = New Size(110, 20)
        Label25.TabIndex = 0
        Label25.Text = "Total Products"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(1370, 749)
        Controls.Add(pnlTotalProducts)
        Controls.Add(pnlHeader)
        Controls.Add(pnlTodaysSales)
        Controls.Add(pnlWeeklyRevenue)
        Controls.Add(Panel7)
        Controls.Add(pnlItemsStock)
        Controls.Add(pnlShoppingCart)
        Controls.Add(Inventory)
        KeyPreview = True
        MaximizeBox = False
        Name = "frmPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlWeeklyRevenue.ResumeLayout(False)
        pnlWeeklyRevenue.PerformLayout()
        pnlTodaysSales.ResumeLayout(False)
        pnlTodaysSales.PerformLayout()
        pnlItemsStock.ResumeLayout(False)
        pnlItemsStock.PerformLayout()
        Inventory.ResumeLayout(False)
        tabProducts.ResumeLayout(False)
        tabProducts.PerformLayout()
        tabInventory.ResumeLayout(False)
        tabInventory.PerformLayout()
        CType(dv, ComponentModel.ISupportInitialize).EndInit()
        tabWeeklyReports.ResumeLayout(False)
        tabWeeklyReports.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        tabSalesHistory.ResumeLayout(False)
        tabSalesHistory.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        pnlShoppingCart.ResumeLayout(False)
        pnlShoppingCart.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        pnlTotalProducts.ResumeLayout(False)
        pnlTotalProducts.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlWeeklyRevenue As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlTodaysSales As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlItemsStock As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Inventory As TabControl
    Friend WithEvents tabProducts As TabPage
    Friend WithEvents tabInventory As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tabWeeklyReports As TabPage
    Friend WithEvents lblAvailableProducts As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblInventoryManagement As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlShoppingCart As Panel
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtBuyer As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPreviousWeek As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblWeeklyReport As Label
    Friend WithEvents lblWeekStarting As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents dv As DataGridView
    Friend WithEvents pnlTotalProducts As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnNextWeek As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents colDay As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTransactions As DataGridViewTextBoxColumn
    Friend WithEvents colItemsSold As DataGridViewTextBoxColumn
    Friend WithEvents colRevenue As DataGridViewTextBoxColumn
    Friend WithEvents colAvgTransaction As DataGridViewTextBoxColumn
    Friend WithEvents tabSalesHistory As TabPage
    Friend WithEvents lblSalesHistory As Label
    Friend WithEvents txtSearchHistory As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents SalesDate As DataGridViewTextBoxColumn
    Friend WithEvents SalesTime As DataGridViewTextBoxColumn
    Friend WithEvents SalesBuyer As DataGridViewTextBoxColumn
    Friend WithEvents SalesTotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
End Class

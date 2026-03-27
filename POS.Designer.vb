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
        flpProduct1 = New FlowLayoutPanel()
        tabInventory = New TabPage()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        txtSearch = New TextBox()
        txtStock = New TextBox()
        txtCategory = New TextBox()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        lblInventoryManagement = New Label()
        txtProductCode = New TextBox()
        btnAdd = New Button()
        dgvProducts = New DataGridView()
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
        dvgsales = New DataGridView()
        SalesDate = New DataGridViewTextBoxColumn()
        SalesTime = New DataGridViewTextBoxColumn()
        SalesBuyer = New DataGridViewTextBoxColumn()
        SalesTotal = New DataGridViewTextBoxColumn()
        pnlShoppingCart = New Panel()
        flpCart = New FlowLayoutPanel()
        Label7 = New Label()
        Label6 = New Label()
        lblShoppingCart = New Label()
        Panel7 = New Panel()
        PictureBox3 = New PictureBox()
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
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        tabWeeklyReports.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        tabSalesHistory.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dvgsales, ComponentModel.ISupportInitialize).BeginInit()
        pnlShoppingCart.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Location = New Point(166, 4)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(2033, 140)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(1576, 100)
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
        Label24.Location = New Point(3, 29)
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
        Label2.Location = New Point(294, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(599, 32)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(183, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1198, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "POS - Inventory Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlWeeklyRevenue
        ' 
        pnlWeeklyRevenue.BackColor = Color.White
        pnlWeeklyRevenue.BorderStyle = BorderStyle.FixedSingle
        pnlWeeklyRevenue.Controls.Add(Label5)
        pnlWeeklyRevenue.Location = New Point(1702, 173)
        pnlWeeklyRevenue.Margin = New Padding(3, 4, 3, 4)
        pnlWeeklyRevenue.Name = "pnlWeeklyRevenue"
        pnlWeeklyRevenue.Size = New Size(300, 154)
        pnlWeeklyRevenue.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(73, 105)
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
        pnlTodaysSales.Location = New Point(1197, 173)
        pnlTodaysSales.Margin = New Padding(3, 4, 3, 4)
        pnlTodaysSales.Name = "pnlTodaysSales"
        pnlTodaysSales.Size = New Size(296, 154)
        pnlTodaysSales.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(89, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 28)
        Label4.TabIndex = 0
        Label4.Text = "Today’s Sales"
        ' 
        ' pnlItemsStock
        ' 
        pnlItemsStock.BackColor = Color.White
        pnlItemsStock.BorderStyle = BorderStyle.FixedSingle
        pnlItemsStock.Controls.Add(Label3)
        pnlItemsStock.Location = New Point(680, 173)
        pnlItemsStock.Margin = New Padding(3, 4, 3, 4)
        pnlItemsStock.Name = "pnlItemsStock"
        pnlItemsStock.Size = New Size(274, 154)
        pnlItemsStock.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(77, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 0
        Label3.Text = "Items in Stock"
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = Color.Navy
        lblAvailableProducts.Location = New Point(999, 4)
        lblAvailableProducts.Name = "lblAvailableProducts"
        lblAvailableProducts.Size = New Size(316, 46)
        lblAvailableProducts.TabIndex = 5
        lblAvailableProducts.Text = "Available Products"
        lblAvailableProducts.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(7, 72)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(1285, 29)
        TextBox1.TabIndex = 3
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(tabProducts)
        Inventory.Controls.Add(tabInventory)
        Inventory.Controls.Add(tabWeeklyReports)
        Inventory.Controls.Add(tabSalesHistory)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(169, 356)
        Inventory.Margin = New Padding(3, 4, 3, 4)
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(1312, 1059)
        Inventory.TabIndex = 2
        Inventory.Tag = "."
        ' 
        ' tabProducts
        ' 
        tabProducts.BackColor = Color.White
        tabProducts.Controls.Add(TextBox1)
        tabProducts.Controls.Add(flpProduct1)
        tabProducts.Controls.Add(lblAvailableProducts)
        tabProducts.Location = New Point(4, 30)
        tabProducts.Margin = New Padding(3, 4, 3, 4)
        tabProducts.Name = "tabProducts"
        tabProducts.Padding = New Padding(3, 4, 3, 4)
        tabProducts.Size = New Size(1304, 1025)
        tabProducts.TabIndex = 0
        tabProducts.Text = "Products"
        ' 
        ' flpProduct1
        ' 
        flpProduct1.BackColor = Color.White
        flpProduct1.BackgroundImageLayout = ImageLayout.Zoom
        flpProduct1.Location = New Point(7, 113)
        flpProduct1.Margin = New Padding(3, 4, 3, 4)
        flpProduct1.Name = "flpProduct1"
        flpProduct1.Size = New Size(1286, 889)
        flpProduct1.TabIndex = 7
        ' 
        ' tabInventory
        ' 
        tabInventory.Controls.Add(btnDelete)
        tabInventory.Controls.Add(btnUpdate)
        tabInventory.Controls.Add(BtnExportcsv)
        tabInventory.Controls.Add(txtSearch)
        tabInventory.Controls.Add(txtStock)
        tabInventory.Controls.Add(txtCategory)
        tabInventory.Controls.Add(txtProductName)
        tabInventory.Controls.Add(txtPrice)
        tabInventory.Controls.Add(lblInventoryManagement)
        tabInventory.Controls.Add(txtProductCode)
        tabInventory.Controls.Add(btnAdd)
        tabInventory.Controls.Add(dgvProducts)
        tabInventory.Location = New Point(4, 30)
        tabInventory.Margin = New Padding(3, 4, 3, 4)
        tabInventory.Name = "tabInventory"
        tabInventory.Padding = New Padding(3, 4, 3, 4)
        tabInventory.Size = New Size(1304, 1025)
        tabInventory.TabIndex = 1
        tabInventory.Text = "Inventory"
        tabInventory.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Green
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(902, 957)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(133, 59)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete Product"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Green
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(1063, 957)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(133, 59)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update Product"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnExportcsv
        ' 
        BtnExportcsv.BackColor = Color.Lime
        BtnExportcsv.FlatStyle = FlatStyle.Flat
        BtnExportcsv.Location = New Point(7, 951)
        BtnExportcsv.Margin = New Padding(3, 4, 3, 4)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(119, 52)
        BtnExportcsv.TabIndex = 3
        BtnExportcsv.Text = "Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(7, 65)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(1285, 32)
        txtSearch.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(849, 897)
        txtStock.Margin = New Padding(3, 4, 3, 4)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(174, 29)
        txtStock.TabIndex = 3
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(425, 897)
        txtCategory.Margin = New Padding(3, 4, 3, 4)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(174, 29)
        txtCategory.TabIndex = 3
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(213, 897)
        txtProductName.Margin = New Padding(3, 4, 3, 4)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(174, 29)
        txtProductName.TabIndex = 3
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(633, 897)
        txtPrice.Margin = New Padding(3, 4, 3, 4)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(174, 29)
        txtPrice.TabIndex = 3
        ' 
        ' lblInventoryManagement
        ' 
        lblInventoryManagement.AutoSize = True
        lblInventoryManagement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryManagement.ForeColor = Color.Navy
        lblInventoryManagement.Location = New Point(979, 8)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(350, 41)
        lblInventoryManagement.TabIndex = 3
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Location = New Point(7, 897)
        txtProductCode.Margin = New Padding(3, 4, 3, 4)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(174, 29)
        txtProductCode.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(1063, 891)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(133, 59)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Product"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(22, 123)
        dgvProducts.Margin = New Padding(3, 4, 3, 4)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(1286, 760)
        dgvProducts.TabIndex = 4
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
        tabWeeklyReports.Location = New Point(4, 30)
        tabWeeklyReports.Margin = New Padding(3, 4, 3, 4)
        tabWeeklyReports.Name = "tabWeeklyReports"
        tabWeeklyReports.Padding = New Padding(3, 4, 3, 4)
        tabWeeklyReports.Size = New Size(1304, 1025)
        tabWeeklyReports.TabIndex = 2
        tabWeeklyReports.Text = "Weekly Reports"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {colDay, colDate, colTransactions, colItemsSold, colRevenue, colAvgTransaction})
        DataGridView2.Location = New Point(27, 443)
        DataGridView2.Margin = New Padding(3, 4, 3, 4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1257, 488)
        DataGridView2.TabIndex = 20
        ' 
        ' colDay
        ' 
        colDay.HeaderText = "Day"
        colDay.MinimumWidth = 6
        colDay.Name = "colDay"
        colDay.Width = 125
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.Width = 125
        ' 
        ' colTransactions
        ' 
        colTransactions.HeaderText = "Transactions"
        colTransactions.MinimumWidth = 6
        colTransactions.Name = "colTransactions"
        colTransactions.Width = 125
        ' 
        ' colItemsSold
        ' 
        colItemsSold.HeaderText = "Items Sold"
        colItemsSold.MinimumWidth = 6
        colItemsSold.Name = "colItemsSold"
        colItemsSold.Width = 125
        ' 
        ' colRevenue
        ' 
        colRevenue.HeaderText = "Revenue"
        colRevenue.MinimumWidth = 6
        colRevenue.Name = "colRevenue"
        colRevenue.Width = 125
        ' 
        ' colAvgTransaction
        ' 
        colAvgTransaction.HeaderText = "Avg. Transaction"
        colAvgTransaction.MinimumWidth = 6
        colAvgTransaction.Name = "colAvgTransaction"
        colAvgTransaction.Width = 125
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(Label16)
        Panel10.Controls.Add(Label14)
        Panel10.Location = New Point(695, 163)
        Panel10.Margin = New Padding(3, 4, 3, 4)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(590, 259)
        Panel10.TabIndex = 19
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.DodgerBlue
        Label16.Location = New Point(30, 67)
        Label16.Name = "Label16"
        Label16.Size = New Size(25, 28)
        Label16.TabIndex = 1
        Label16.Text = "₱"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Navy
        Label14.Location = New Point(30, 17)
        Label14.Name = "Label14"
        Label14.Size = New Size(202, 25)
        Label14.TabIndex = 0
        Label14.Text = ChrW(55357) & ChrW(57042) & " Sales Performance"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(Label1)
        Panel9.Location = New Point(27, 163)
        Panel9.Margin = New Padding(3, 4, 3, 4)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(539, 259)
        Panel9.TabIndex = 18
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.DodgerBlue
        Label15.Location = New Point(14, 67)
        Label15.Name = "Label15"
        Label15.Size = New Size(25, 28)
        Label15.TabIndex = 1
        Label15.Text = "₱"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(14, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 0
        Label1.Text = "₱  Revenue Summary"
        ' 
        ' btnNextWeek
        ' 
        btnNextWeek.BackColor = Color.White
        btnNextWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNextWeek.Location = New Point(446, 76)
        btnNextWeek.Margin = New Padding(3, 4, 3, 4)
        btnNextWeek.Name = "btnNextWeek"
        btnNextWeek.Size = New Size(134, 39)
        btnNextWeek.TabIndex = 17
        btnNextWeek.Text = "Next Week >"
        btnNextWeek.UseVisualStyleBackColor = False
        ' 
        ' lblWeekStarting
        ' 
        lblWeekStarting.AutoSize = True
        lblWeekStarting.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeekStarting.ForeColor = Color.Navy
        lblWeekStarting.Location = New Point(543, 21)
        lblWeekStarting.Name = "lblWeekStarting"
        lblWeekStarting.Size = New Size(181, 32)
        lblWeekStarting.TabIndex = 16
        lblWeekStarting.Text = "Week Starting:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Navy
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1146, 67)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(134, 52)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "🔄  Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnPreviousWeek
        ' 
        btnPreviousWeek.BackColor = Color.White
        btnPreviousWeek.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreviousWeek.Location = New Point(27, 76)
        btnPreviousWeek.Margin = New Padding(3, 4, 3, 4)
        btnPreviousWeek.Name = "btnPreviousWeek"
        btnPreviousWeek.Size = New Size(181, 39)
        btnPreviousWeek.TabIndex = 14
        btnPreviousWeek.Text = "<  Previous Week"
        btnPreviousWeek.UseVisualStyleBackColor = False
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.DarkBlue
        lblCategory.Location = New Point(1005, 17)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(125, 32)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Category:"
        ' 
        ' lblWeeklyReport
        ' 
        lblWeeklyReport.AutoSize = True
        lblWeeklyReport.BackColor = Color.Transparent
        lblWeeklyReport.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeeklyReport.ForeColor = Color.Navy
        lblWeeklyReport.Location = New Point(27, 8)
        lblWeeklyReport.Name = "lblWeeklyReport"
        lblWeeklyReport.Size = New Size(305, 41)
        lblWeeklyReport.TabIndex = 9
        lblWeeklyReport.Text = "Weekly Sales Report"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(256, 85)
        Label13.Name = "Label13"
        Label13.Size = New Size(157, 23)
        Label13.TabIndex = 2
        Label13.Text = "UpdateWeekLabel"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(1146, 21)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 29)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "All Categories"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(727, 21)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(251, 29)
        DateTimePicker1.TabIndex = 0
        ' 
        ' tabSalesHistory
        ' 
        tabSalesHistory.BackColor = Color.White
        tabSalesHistory.Controls.Add(Panel1)
        tabSalesHistory.Controls.Add(lblSalesHistory)
        tabSalesHistory.Controls.Add(txtSearchHistory)
        tabSalesHistory.Controls.Add(dvgsales)
        tabSalesHistory.Location = New Point(4, 30)
        tabSalesHistory.Margin = New Padding(3, 4, 3, 4)
        tabSalesHistory.Name = "tabSalesHistory"
        tabSalesHistory.Padding = New Padding(3, 4, 3, 4)
        tabSalesHistory.Size = New Size(1304, 1025)
        tabSalesHistory.TabIndex = 3
        tabSalesHistory.Text = "Sales History"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Location = New Point(22, 784)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1266, 207)
        Panel1.TabIndex = 3
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(1022, 107)
        Label22.Name = "Label22"
        Label22.Size = New Size(187, 28)
        Label22.TabIndex = 4
        Label22.Text = "Recommendations"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(493, 107)
        Label26.Name = "Label26"
        Label26.Size = New Size(205, 28)
        Label26.TabIndex = 3
        Label26.Text = "Top Selling Products"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(24, 107)
        Label19.Name = "Label19"
        Label19.Size = New Size(230, 28)
        Label19.TabIndex = 1
        Label19.Text = "Low Stock Items (< 10)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Navy
        Label18.Location = New Point(24, 29)
        Label18.Name = "Label18"
        Label18.Size = New Size(223, 32)
        Label18.TabIndex = 0
        Label18.Text = "Inventory Insights"
        ' 
        ' lblSalesHistory
        ' 
        lblSalesHistory.AutoSize = True
        lblSalesHistory.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalesHistory.ForeColor = Color.Navy
        lblSalesHistory.Location = New Point(22, 16)
        lblSalesHistory.Name = "lblSalesHistory"
        lblSalesHistory.Size = New Size(269, 54)
        lblSalesHistory.TabIndex = 2
        lblSalesHistory.Text = "Sales History"
        ' 
        ' txtSearchHistory
        ' 
        txtSearchHistory.Location = New Point(877, 55)
        txtSearchHistory.Margin = New Padding(3, 4, 3, 4)
        txtSearchHistory.Name = "txtSearchHistory"
        txtSearchHistory.PlaceholderText = "Search History Sales..."
        txtSearchHistory.Size = New Size(411, 29)
        txtSearchHistory.TabIndex = 1
        ' 
        ' dvgsales
        ' 
        dvgsales.BackgroundColor = Color.Silver
        dvgsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgsales.Columns.AddRange(New DataGridViewColumn() {SalesDate, SalesTime, SalesBuyer, SalesTotal})
        dvgsales.Location = New Point(22, 96)
        dvgsales.Margin = New Padding(3, 4, 3, 4)
        dvgsales.Name = "dvgsales"
        dvgsales.RowHeadersWidth = 51
        dvgsales.Size = New Size(1266, 644)
        dvgsales.TabIndex = 0
        ' 
        ' SalesDate
        ' 
        SalesDate.HeaderText = "Date"
        SalesDate.MinimumWidth = 6
        SalesDate.Name = "SalesDate"
        SalesDate.Width = 125
        ' 
        ' SalesTime
        ' 
        SalesTime.HeaderText = "Time"
        SalesTime.MinimumWidth = 6
        SalesTime.Name = "SalesTime"
        SalesTime.Width = 125
        ' 
        ' SalesBuyer
        ' 
        SalesBuyer.HeaderText = "Buyer"
        SalesBuyer.MinimumWidth = 6
        SalesBuyer.Name = "SalesBuyer"
        SalesBuyer.Width = 125
        ' 
        ' SalesTotal
        ' 
        SalesTotal.HeaderText = "Total"
        SalesTotal.MinimumWidth = 6
        SalesTotal.Name = "SalesTotal"
        SalesTotal.Width = 125
        ' 
        ' pnlShoppingCart
        ' 
        pnlShoppingCart.BackColor = Color.Silver
        pnlShoppingCart.Controls.Add(flpCart)
        pnlShoppingCart.Controls.Add(Label7)
        pnlShoppingCart.Controls.Add(Label6)
        pnlShoppingCart.Controls.Add(lblShoppingCart)
        pnlShoppingCart.Location = New Point(1525, 395)
        pnlShoppingCart.Margin = New Padding(3, 4, 3, 4)
        pnlShoppingCart.Name = "pnlShoppingCart"
        pnlShoppingCart.Size = New Size(642, 929)
        pnlShoppingCart.TabIndex = 3
        ' 
        ' flpCart
        ' 
        flpCart.BackColor = Color.White
        flpCart.Dock = DockStyle.Fill
        flpCart.Location = New Point(0, 0)
        flpCart.Margin = New Padding(3, 4, 3, 4)
        flpCart.Name = "flpCart"
        flpCart.Size = New Size(642, 929)
        flpCart.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(193, 152)
        Label7.Name = "Label7"
        Label7.Size = New Size(242, 28)
        Label7.TabIndex = 2
        Label7.Text = "Add products from the list"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(221, 125)
        Label6.Name = "Label6"
        Label6.Size = New Size(162, 25)
        Label6.TabIndex = 1
        Label6.Text = "Your cart is empty"
        ' 
        ' lblShoppingCart
        ' 
        lblShoppingCart.AutoSize = True
        lblShoppingCart.BackColor = Color.Transparent
        lblShoppingCart.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShoppingCart.ForeColor = Color.Navy
        lblShoppingCart.Location = New Point(461, 20)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(202, 37)
        lblShoppingCart.TabIndex = 0
        lblShoppingCart.Text = "Shopping Cart"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LightSteelBlue
        Panel7.Controls.Add(PictureBox3)
        Panel7.Controls.Add(Button18)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(163, 1415)
        Panel7.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 16)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(145, 140)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = SystemColors.Info
        Button18.Location = New Point(14, 1287)
        Button18.Margin = New Padding(3, 4, 3, 4)
        Button18.Name = "Button18"
        Button18.Size = New Size(134, 40)
        Button18.TabIndex = 8
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' pnlTotalProducts
        ' 
        pnlTotalProducts.BackColor = Color.White
        pnlTotalProducts.Controls.Add(Label25)
        pnlTotalProducts.Location = New Point(211, 173)
        pnlTotalProducts.Margin = New Padding(3, 4, 3, 4)
        pnlTotalProducts.Name = "pnlTotalProducts"
        pnlTotalProducts.Size = New Size(263, 155)
        pnlTotalProducts.TabIndex = 5
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(57, 108)
        Label25.Name = "Label25"
        Label25.Size = New Size(140, 25)
        Label25.TabIndex = 0
        Label25.Text = "Total Products"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(1566, 999)
        Controls.Add(pnlTotalProducts)
        Controls.Add(pnlHeader)
        Controls.Add(pnlTodaysSales)
        Controls.Add(pnlWeeklyRevenue)
        Controls.Add(Panel7)
        Controls.Add(pnlItemsStock)
        Controls.Add(pnlShoppingCart)
        Controls.Add(Inventory)
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
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
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
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
        CType(dvgsales, ComponentModel.ISupportInitialize).EndInit()
        pnlShoppingCart.ResumeLayout(False)
        pnlShoppingCart.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblInventoryManagement As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnExportcsv As Button
    Friend WithEvents pnlShoppingCart As Panel
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents pnlTotalProducts As Panel
    Friend WithEvents Label25 As Label
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
    Friend WithEvents dvgsales As DataGridView
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
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents flpProduct1 As FlowLayoutPanel
    Friend WithEvents flpCart As FlowLayoutPanel

End Class

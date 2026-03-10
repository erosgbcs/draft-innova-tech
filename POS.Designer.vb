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
        pnlHeader = New Panel()
        Label24 = New Label()
        Label2 = New Label()
        lblTitle = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        lblAvailableProducts = New Label()
        TextBox1 = New TextBox()
        Inventory = New TabControl()
        TabPage1 = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblSearchBar = New Label()
        TabPage2 = New TabPage()
        Button2 = New Button()
        TextBox7 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox6 = New TextBox()
        lblInventoryManagement = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        TabPage3 = New TabPage()
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
        Button7 = New Button()
        Label23 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Label21 = New Label()
        Label20 = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Button3 = New Button()
        Label12 = New Label()
        Label11 = New Label()
        TextBox8 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblShoppingCart = New Label()
        Panel7 = New Panel()
        Button18 = New Button()
        Panel8 = New Panel()
        Label25 = New Label()
        TabPage4 = New TabPage()
        DataGridView3 = New DataGridView()
        TextBox9 = New TextBox()
        Label17 = New Label()
        SalesDate = New DataGridViewTextBoxColumn()
        SalesTime = New DataGridViewTextBoxColumn()
        SalesBuyer = New DataGridViewTextBoxColumn()
        SalesTotal = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label18 = New Label()
        Label19 = New Label()
        Label26 = New Label()
        Label22 = New Label()
        pnlHeader.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Inventory.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(Label24)
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(145, 3)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1739, 111)
        pnlHeader.TabIndex = 0
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
        Label2.Location = New Point(486, 73)
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
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(1489, 130)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(263, 116)
        Panel4.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 0
        Label5.Text = "Weekly Revenue"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSteelBlue
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(1047, 130)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(259, 116)
        Panel3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 0
        Label4.Text = "Today’s Sales"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(595, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(240, 116)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 0
        Label3.Text = "Items in Stock"
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = Color.MediumBlue
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
        TextBox1.Location = New Point(606, 43)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(525, 25)
        TextBox1.TabIndex = 3
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(TabPage1)
        Inventory.Controls.Add(TabPage2)
        Inventory.Controls.Add(TabPage3)
        Inventory.Controls.Add(TabPage4)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(141, 271)
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(1155, 790)
        Inventory.TabIndex = 2
        Inventory.Tag = "."
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.WhiteSmoke
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(FlowLayoutPanel1)
        TabPage1.Controls.Add(lblSearchBar)
        TabPage1.Controls.Add(lblAvailableProducts)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1147, 760)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Products"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Location = New Point(6, 85)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1125, 667)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' lblSearchBar
        ' 
        lblSearchBar.AutoSize = True
        lblSearchBar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearchBar.Location = New Point(480, 44)
        lblSearchBar.Name = "lblSearchBar"
        lblSearchBar.Size = New Size(106, 25)
        lblSearchBar.TabIndex = 6
        lblSearchBar.Text = "Search Bar"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(TextBox7)
        TabPage2.Controls.Add(TextBox5)
        TabPage2.Controls.Add(TextBox4)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(TextBox6)
        TabPage2.Controls.Add(lblInventoryManagement)
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1147, 760)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Inventory"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(6, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 39)
        Button2.TabIndex = 3
        Button2.Text = "Export CSV"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(586, 49)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Product Inventory by code or name.."
        TextBox7.Size = New Size(545, 27)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(826, 673)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Stock"
        TextBox5.Size = New Size(153, 25)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(476, 673)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Category"
        TextBox4.Size = New Size(153, 25)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(299, 673)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Product name"
        TextBox3.Size = New Size(153, 25)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(658, 673)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Price"
        TextBox6.Size = New Size(153, 25)
        TextBox6.TabIndex = 3
        ' 
        ' lblInventoryManagement
        ' 
        lblInventoryManagement.AutoSize = True
        lblInventoryManagement.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryManagement.ForeColor = Color.DodgerBlue
        lblInventoryManagement.Location = New Point(886, 6)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(245, 30)
        lblInventoryManagement.TabIndex = 3
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(97, 673)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Product code"
        TextBox2.Size = New Size(153, 25)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1015, 673)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 35)
        Button1.TabIndex = 3
        Button1.Text = "Add Product"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 82)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1125, 570)
        DataGridView1.TabIndex = 4
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.WhiteSmoke
        TabPage3.Controls.Add(DataGridView2)
        TabPage3.Controls.Add(Panel10)
        TabPage3.Controls.Add(Panel9)
        TabPage3.Controls.Add(Button7)
        TabPage3.Controls.Add(Label23)
        TabPage3.Controls.Add(Button6)
        TabPage3.Controls.Add(Button5)
        TabPage3.Controls.Add(Label21)
        TabPage3.Controls.Add(Label20)
        TabPage3.Controls.Add(Label13)
        TabPage3.Controls.Add(ComboBox1)
        TabPage3.Controls.Add(DateTimePicker1)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1147, 760)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Weekly Reports"
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
        Panel10.Location = New Point(604, 100)
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
        Label14.ForeColor = Color.DodgerBlue
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
        Panel9.Location = New Point(24, 98)
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
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(12, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 0
        Label1.Text = "₱  Revenue Summary"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.White
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(325, 57)
        Button7.Name = "Button7"
        Button7.Size = New Size(117, 29)
        Button7.TabIndex = 17
        Button7.Text = "Next Week >"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Navy
        Label23.Location = New Point(475, 16)
        Label23.Name = "Label23"
        Label23.Size = New Size(144, 25)
        Label23.TabIndex = 16
        Label23.Text = "Week Starting:"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Navy
        Button6.ForeColor = Color.White
        Button6.Location = New Point(1003, 50)
        Button6.Name = "Button6"
        Button6.Size = New Size(117, 39)
        Button6.TabIndex = 15
        Button6.Text = "🔄  Refresh"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(24, 57)
        Button5.Name = "Button5"
        Button5.Size = New Size(158, 29)
        Button5.TabIndex = 14
        Button5.Text = "<  Previous Week"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.DarkBlue
        Label21.Location = New Point(879, 13)
        Label21.Name = "Label21"
        Label21.Size = New Size(99, 25)
        Label21.TabIndex = 10
        Label21.Text = "Category:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Navy
        Label20.Location = New Point(22, 16)
        Label20.Name = "Label20"
        Label20.Size = New Size(192, 25)
        Label20.TabIndex = 9
        Label20.Text = "Weekly Sales Report"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(217, 64)
        Label13.Name = "Label13"
        Label13.Size = New Size(53, 17)
        Label13.TabIndex = 2
        Label13.Text = "Label13"
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
        DateTimePicker1.Size = New Size(200, 25)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Silver
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(lblShoppingCart)
        Panel5.Location = New Point(1328, 271)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(556, 513)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(TextBox8)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label8)
        Panel6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel6.Location = New Point(35, 173)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(403, 232)
        Panel6.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.ForeColor = Color.White
        Button3.Location = New Point(47, 163)
        Button3.Name = "Button3"
        Button3.Size = New Size(329, 53)
        Button3.TabIndex = 6
        Button3.Text = "Checkout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(315, 118)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 17)
        Label12.TabIndex = 5
        Label12.Text = "Label12"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(315, 89)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 17)
        Label11.TabIndex = 4
        Label11.Text = "Label11"
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(111, 37)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Buyer name"
        TextBox8.Size = New Size(251, 27)
        TextBox8.TabIndex = 3
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
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(146, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 17)
        Label7.TabIndex = 2
        Label7.Text = "Add products from the list"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(167, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 17)
        Label6.TabIndex = 1
        Label6.Text = "Your cart is empty"
        ' 
        ' lblShoppingCart
        ' 
        lblShoppingCart.AutoSize = True
        lblShoppingCart.BackColor = Color.Transparent
        lblShoppingCart.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblShoppingCart.ForeColor = Color.DodgerBlue
        lblShoppingCart.Location = New Point(367, 18)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(145, 30)
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
        ' Panel8
        ' 
        Panel8.BackColor = Color.Silver
        Panel8.Controls.Add(Label25)
        Panel8.Location = New Point(202, 120)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(230, 116)
        Panel8.TabIndex = 5
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(59, 74)
        Label25.Name = "Label25"
        Label25.Size = New Size(82, 15)
        Label25.TabIndex = 0
        Label25.Text = "Total Products"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel1)
        TabPage4.Controls.Add(Label17)
        TabPage4.Controls.Add(TextBox9)
        TabPage4.Controls.Add(DataGridView3)
        TabPage4.Location = New Point(4, 26)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1147, 760)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Sales History"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = Color.White
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {SalesDate, SalesTime, SalesBuyer, SalesTotal})
        DataGridView3.Location = New Point(19, 72)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(1108, 483)
        DataGridView3.TabIndex = 0
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(767, 41)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "Search History Sales..."
        TextBox9.Size = New Size(360, 25)
        TextBox9.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Navy
        Label17.Location = New Point(19, 12)
        Label17.Name = "Label17"
        Label17.Size = New Size(215, 45)
        Label17.TabIndex = 2
        Label17.Text = "Sales History"
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
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1881, 1061)
        Controls.Add(Panel8)
        Controls.Add(pnlHeader)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Inventory)
        KeyPreview = True
        MaximizeBox = False
        Name = "frmPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Inventory.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Inventory As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblAvailableProducts As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblInventoryManagement As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Button18 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblSearchBar As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button7 As Button
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
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox9 As TextBox
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
End Class

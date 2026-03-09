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
        Label24 = New Label()
        Label2 = New Label()
        lblTitle = New Label()
        pnlStats = New Panel()
        Panel4 = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        lblAvailableProducts = New Label()
        TextBox1 = New TextBox()
        Inventory = New TabControl()
        TabPage1 = New TabPage()
        DataGridView3 = New DataGridView()
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
        Label23 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        DataGridView2 = New DataGridView()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
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
        imgProducts = New ImageList(components)
        Panel7 = New Panel()
        Button18 = New Button()
        pnlHeader.SuspendLayout()
        pnlStats.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Inventory.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(Label24)
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(141, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1763, 111)
        pnlHeader.TabIndex = 0
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(4, 16)
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
        ' pnlStats
        ' 
        pnlStats.Controls.Add(Panel4)
        pnlStats.Controls.Add(Panel3)
        pnlStats.Controls.Add(Panel2)
        pnlStats.Controls.Add(Panel1)
        pnlStats.Location = New Point(141, 117)
        pnlStats.Name = "pnlStats"
        pnlStats.Size = New Size(1763, 119)
        pnlStats.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(1533, 7)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(227, 89)
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
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(596, 16)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 80)
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
        Panel2.Location = New Point(302, 16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 80)
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
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(33, 16)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 0
        Label1.Text = "Total Products"
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = SystemColors.MenuHighlight
        lblAvailableProducts.Location = New Point(712, 9)
        lblAvailableProducts.Name = "lblAvailableProducts"
        lblAvailableProducts.Size = New Size(257, 37)
        lblAvailableProducts.TabIndex = 5
        lblAvailableProducts.Text = "Available Products"
        lblAvailableProducts.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(25, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(711, 25)
        TextBox1.TabIndex = 3
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(TabPage1)
        Inventory.Controls.Add(TabPage2)
        Inventory.Controls.Add(TabPage3)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(141, 242)
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(992, 799)
        Inventory.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(lblAvailableProducts)
        TabPage1.Controls.Add(DataGridView3)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(984, 769)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Products"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Dock = DockStyle.Fill
        DataGridView3.Location = New Point(3, 3)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(978, 763)
        DataGridView3.TabIndex = 4
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
        TabPage2.Size = New Size(984, 769)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Inventory"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(19, 722)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 39)
        Button2.TabIndex = 3
        Button2.Text = "Export CSV"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(41, 70)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Product Inventory by code or name.."
        TextBox7.Size = New Size(733, 27)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(650, 680)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Stock"
        TextBox5.Size = New Size(153, 25)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(332, 680)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Category"
        TextBox4.Size = New Size(153, 25)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(173, 680)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Product name"
        TextBox3.Size = New Size(153, 25)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(491, 680)
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
        lblInventoryManagement.Location = New Point(702, 24)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(245, 30)
        lblInventoryManagement.TabIndex = 3
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(14, 680)
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
        Button1.Location = New Point(820, 674)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 35)
        Button1.TabIndex = 3
        Button1.Text = "Add Product"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(978, 763)
        DataGridView1.TabIndex = 4
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label23)
        TabPage3.Controls.Add(Button6)
        TabPage3.Controls.Add(Button5)
        TabPage3.Controls.Add(Button4)
        TabPage3.Controls.Add(DataGridView2)
        TabPage3.Controls.Add(Label22)
        TabPage3.Controls.Add(Label21)
        TabPage3.Controls.Add(Label20)
        TabPage3.Controls.Add(Label19)
        TabPage3.Controls.Add(Label18)
        TabPage3.Controls.Add(Label17)
        TabPage3.Controls.Add(Label16)
        TabPage3.Controls.Add(Label15)
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(Label13)
        TabPage3.Controls.Add(ComboBox1)
        TabPage3.Controls.Add(DateTimePicker1)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(984, 769)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Weekly Reports"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Navy
        Label23.Location = New Point(232, 52)
        Label23.Name = "Label23"
        Label23.Size = New Size(90, 25)
        Label23.TabIndex = 16
        Label23.Text = "Starting:"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(63, 67)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 15
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(332, 249)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 14
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(635, 135)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 22)
        Button4.TabIndex = 13
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(616, 424)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(240, 150)
        DataGridView2.TabIndex = 12
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(548, 330)
        Label22.Name = "Label22"
        Label22.Size = New Size(53, 17)
        Label22.TabIndex = 11
        Label22.Text = "Label22"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.DarkBlue
        Label21.Location = New Point(558, 8)
        Label21.Name = "Label21"
        Label21.Size = New Size(99, 25)
        Label21.TabIndex = 10
        Label21.Text = "Category:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(147, 149)
        Label20.Name = "Label20"
        Label20.Size = New Size(53, 17)
        Label20.TabIndex = 9
        Label20.Text = "Label20"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Navy
        Label19.Location = New Point(232, 27)
        Label19.Name = "Label19"
        Label19.Size = New Size(61, 25)
        Label19.TabIndex = 8
        Label19.Text = "Week"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(269, 359)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 17)
        Label18.TabIndex = 7
        Label18.Text = "Label18"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(367, 276)
        Label17.Name = "Label17"
        Label17.Size = New Size(53, 17)
        Label17.TabIndex = 6
        Label17.Text = "Label17"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(359, 268)
        Label16.Name = "Label16"
        Label16.Size = New Size(53, 17)
        Label16.TabIndex = 5
        Label16.Text = "Label16"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(351, 260)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 17)
        Label15.TabIndex = 4
        Label15.Text = "Label15"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(343, 252)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 17)
        Label14.TabIndex = 3
        Label14.Text = "Label14"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(333, 226)
        Label13.Name = "Label13"
        Label13.Size = New Size(53, 17)
        Label13.TabIndex = 2
        Label13.Text = "Label13"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(548, 47)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 25)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "All Categories"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(333, 43)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 25)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(lblShoppingCart)
        Panel5.Location = New Point(1158, 271)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(618, 513)
        Panel5.TabIndex = 3
        ' 
        ' Panel6
        ' 
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
        Label7.Location = New Point(146, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 17)
        Label7.TabIndex = 2
        Label7.Text = "Add products from the list"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(171, 118)
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
        lblShoppingCart.ForeColor = SystemColors.MenuHighlight
        lblShoppingCart.Location = New Point(293, 21)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(145, 30)
        lblShoppingCart.TabIndex = 0
        lblShoppingCart.Text = "Shopping Cart"
        ' 
        ' imgProducts
        ' 
        imgProducts.ColorDepth = ColorDepth.Depth32Bit
        imgProducts.ImageSize = New Size(16, 16)
        imgProducts.TransparentColor = Color.Transparent
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
        Button18.Location = New Point(12, 990)
        Button18.Name = "Button18"
        Button18.Size = New Size(117, 30)
        Button18.TabIndex = 8
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1924, 1061)
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        Controls.Add(pnlHeader)
        Controls.Add(Inventory)
        Controls.Add(pnlStats)
        KeyPreview = True
        Name = "frmPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlStats.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Inventory.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
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
    Friend WithEvents imgProducts As ImageList
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button18 As Button
    Friend WithEvents Label24 As Label
End Class

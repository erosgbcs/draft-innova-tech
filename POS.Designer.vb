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
        Inventory = New TabControl()
        TabPage1 = New TabPage()
        NumericUpDown1 = New NumericUpDown()
        lblAvailableProducts = New Label()
        TextBox1 = New TextBox()
        TabPage2 = New TabPage()
        lblInventoryManagement = New Label()
        TextBox7 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TabPage3 = New TabPage()
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
        lvMenu = New ListView()
        imgProducts = New ImageList(components)
        pnlHeader.SuspendLayout()
        pnlStats.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Inventory.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1353, 97)
        pnlHeader.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(11, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(295, 15)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(11, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(643, 54)
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
        pnlStats.Dock = DockStyle.Top
        pnlStats.Location = New Point(0, 97)
        pnlStats.Name = "pnlStats"
        pnlStats.Size = New Size(1353, 119)
        pnlStats.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(874, 16)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 80)
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
        ' Inventory
        ' 
        Inventory.Controls.Add(TabPage1)
        Inventory.Controls.Add(TabPage2)
        Inventory.Controls.Add(TabPage3)
        Inventory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Inventory.Location = New Point(0, 236)
        Inventory.Name = "Inventory"
        Inventory.SelectedIndex = 0
        Inventory.Size = New Size(867, 566)
        Inventory.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(lblAvailableProducts)
        TabPage1.Controls.Add(lvMenu)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(859, 536)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Products"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumericUpDown1.Location = New Point(800, 224)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(43, 29)
        NumericUpDown1.TabIndex = 6
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = SystemColors.MenuHighlight
        lblAvailableProducts.Location = New Point(643, 18)
        lblAvailableProducts.Name = "lblAvailableProducts"
        lblAvailableProducts.Size = New Size(196, 30)
        lblAvailableProducts.TabIndex = 5
        lblAvailableProducts.Text = "Available Products"
        lblAvailableProducts.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(8, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(817, 25)
        TextBox1.TabIndex = 3
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblInventoryManagement)
        TabPage2.Controls.Add(TextBox7)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(TextBox6)
        TabPage2.Controls.Add(TextBox5)
        TabPage2.Controls.Add(TextBox4)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(859, 536)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Inventory"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblInventoryManagement
        ' 
        lblInventoryManagement.AutoSize = True
        lblInventoryManagement.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryManagement.ForeColor = Color.DodgerBlue
        lblInventoryManagement.Location = New Point(608, 20)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(245, 30)
        lblInventoryManagement.TabIndex = 3
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(8, 66)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Product Inventory by code or name.."
        TextBox7.Size = New Size(837, 27)
        TextBox7.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(19, 506)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 23)
        Button2.TabIndex = 3
        Button2.Text = "Export CSV"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(702, 464)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 28)
        Button1.TabIndex = 3
        Button1.Text = "Add Product"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(549, 468)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Price"
        TextBox6.Size = New Size(128, 25)
        TextBox6.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(413, 468)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Stock"
        TextBox5.Size = New Size(130, 25)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(277, 468)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Category"
        TextBox4.Size = New Size(130, 25)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(148, 468)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Product name"
        TextBox3.Size = New Size(123, 25)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(19, 468)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Product code"
        TextBox2.Size = New Size(123, 25)
        TextBox2.TabIndex = 3
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(859, 536)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Weekly Reports"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(lblShoppingCart)
        Panel5.Location = New Point(883, 260)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(458, 491)
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
        lblShoppingCart.Location = New Point(293, 20)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(145, 30)
        lblShoppingCart.TabIndex = 0
        lblShoppingCart.Text = "Shopping Cart"
        ' 
        ' lvMenu
        ' 
        lvMenu.Dock = DockStyle.Fill
        lvMenu.Location = New Point(3, 3)
        lvMenu.Name = "lvMenu"
        lvMenu.Size = New Size(853, 530)
        lvMenu.TabIndex = 0
        lvMenu.TileSize = New Size(180, 80)
        lvMenu.UseCompatibleStateImageBehavior = False
        lvMenu.View = View.Tile
        ' 
        ' imgProducts
        ' 
        imgProducts.ColorDepth = ColorDepth.Depth32Bit
        imgProducts.ImageSize = New Size(16, 16)
        imgProducts.TransparentColor = Color.Transparent
        ' 
        ' frmPOS
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1353, 801)
        Controls.Add(NumericUpDown1)
        Controls.Add(Panel5)
        Controls.Add(Inventory)
        Controls.Add(pnlStats)
        Controls.Add(pnlHeader)
        KeyPreview = True
        Name = "frmPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS System"
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
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
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
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lvMenu As ListView
    Friend WithEvents imgProducts As ImageList
End Class

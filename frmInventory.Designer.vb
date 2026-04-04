<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        btnAddProduct = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtCategory = New TextBox()
        txtProductCode = New TextBox()
        txtProductName = New TextBox()
        txtStock = New TextBox()
        txtPrice = New TextBox()
        PictureBox3 = New PictureBox()
        btnUploadPictures = New Button()
        btnSALESHISTORY = New Guna.UI2.WinForms.Guna2Button()
        btnOpenPOS = New Guna.UI2.WinForms.Guna2Button()
        btnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel2.SuspendLayout()
        Guna2CustomGradientPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(171, 363)
        txtSearch.Margin = New Padding(5, 4, 5, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(1379, 32)
        txtSearch.TabIndex = 5
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.BackgroundColor = Color.White
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(171, 412)
        dgvProducts.Margin = New Padding(5, 4, 5, 4)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(1378, 521)
        dgvProducts.TabIndex = 6
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(1308, 8)
        btnAddProduct.Margin = New Padding(5, 4, 5, 4)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(37, 33)
        btnAddProduct.TabIndex = 12
        btnAddProduct.Text = "➕"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1259, 8)
        btnDelete.Margin = New Padding(5, 4, 5, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(41, 33)
        btnDelete.TabIndex = 16
        btnDelete.Text = "🗑️"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Green
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.Wheat
        btnUpdate.Location = New Point(837, 8)
        btnUpdate.Margin = New Padding(5, 4, 5, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(145, 37)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update Product"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnExportcsv
        ' 
        BtnExportcsv.BackColor = Color.Lime
        BtnExportcsv.FlatStyle = FlatStyle.Flat
        BtnExportcsv.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnExportcsv.Location = New Point(1134, 8)
        BtnExportcsv.Margin = New Padding(5, 4, 5, 4)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(107, 33)
        BtnExportcsv.TabIndex = 18
        BtnExportcsv.Text = "📄 Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DimGray
        Label1.Location = New Point(171, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(1367, 2)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(990, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 33)
        Button1.TabIndex = 21
        Button1.Text = "🖨️ Print Report"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.Black
        Guna2CustomGradientPanel1.BorderRadius = 20
        Guna2CustomGradientPanel1.BorderThickness = 1
        Guna2CustomGradientPanel1.Controls.Add(Label3)
        Guna2CustomGradientPanel1.Controls.Add(Label4)
        Guna2CustomGradientPanel1.Controls.Add(Label7)
        Guna2CustomGradientPanel1.Controls.Add(Label5)
        Guna2CustomGradientPanel1.Controls.Add(Label6)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel1.FillColor = Color.DodgerBlue
        Guna2CustomGradientPanel1.FillColor2 = Color.SteelBlue
        Guna2CustomGradientPanel1.FillColor3 = Color.Navy
        Guna2CustomGradientPanel1.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel1.Location = New Point(168, 138)
        Guna2CustomGradientPanel1.Margin = New Padding(3, 4, 3, 4)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 25
        Guna2CustomGradientPanel1.ShadowDecoration.Color = Color.FromArgb(CByte(191), CByte(219), CByte(254))
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel1.ShadowDecoration.Enabled = True
        Guna2CustomGradientPanel1.Size = New Size(1378, 211)
        Guna2CustomGradientPanel1.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(39, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 48
        Label3.Text = "Product Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 49
        Label4.Text = "Product Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(614, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 20)
        Label7.TabIndex = 52
        Label7.Text = "Stock"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(322, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 50
        Label5.Text = "Category"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(322, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 20)
        Label6.TabIndex = 51
        Label6.Text = "Price"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(494, 151)
        txtCategory.Margin = New Padding(5, 4, 5, 4)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(220, 27)
        txtCategory.TabIndex = 45
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = Color.Maroon
        txtProductCode.ForeColor = Color.White
        txtProductCode.Location = New Point(205, 151)
        txtProductCode.Margin = New Padding(5, 4, 5, 4)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(220, 27)
        txtProductCode.TabIndex = 43
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.White
        txtProductName.Location = New Point(205, 223)
        txtProductName.Margin = New Padding(5, 4, 5, 4)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(220, 27)
        txtProductName.TabIndex = 44
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(785, 151)
        txtStock.Margin = New Padding(5, 4, 5, 4)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(220, 27)
        txtStock.TabIndex = 47
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(494, 223)
        txtPrice.Margin = New Padding(5, 4, 5, 4)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(220, 27)
        txtPrice.TabIndex = 46
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(15, 36)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(129, 140)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' btnUploadPictures
        ' 
        btnUploadPictures.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadPictures.Location = New Point(26, 189)
        btnUploadPictures.Name = "btnUploadPictures"
        btnUploadPictures.Size = New Size(118, 31)
        btnUploadPictures.TabIndex = 13
        btnUploadPictures.Text = "Upload Pictures"
        btnUploadPictures.UseVisualStyleBackColor = True
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.BorderColor = Color.White
        btnSALESHISTORY.BorderRadius = 12
        btnSALESHISTORY.BorderThickness = 1
        btnSALESHISTORY.CustomizableEdges = CustomizableEdges3
        btnSALESHISTORY.DisabledState.BorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.CustomBorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSALESHISTORY.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSALESHISTORY.FillColor = Color.Blue
        btnSALESHISTORY.Font = New Font("Segoe UI", 9F)
        btnSALESHISTORY.ForeColor = Color.WhiteSmoke
        btnSALESHISTORY.Location = New Point(10, 608)
        btnSALESHISTORY.Margin = New Padding(3, 4, 3, 4)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSALESHISTORY.Size = New Size(146, 45)
        btnSALESHISTORY.TabIndex = 21
        btnSALESHISTORY.Text = "Sales History 📜"
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.BorderColor = Color.DarkBlue
        btnOpenPOS.BorderRadius = 12
        btnOpenPOS.BorderThickness = 1
        btnOpenPOS.CustomizableEdges = CustomizableEdges5
        btnOpenPOS.DisabledState.BorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenPOS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenPOS.FillColor = Color.Transparent
        btnOpenPOS.Font = New Font("Segoe UI", 9F)
        btnOpenPOS.ForeColor = Color.DarkBlue
        btnOpenPOS.Location = New Point(8, 408)
        btnOpenPOS.Margin = New Padding(3, 4, 3, 4)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnOpenPOS.Size = New Size(146, 45)
        btnOpenPOS.TabIndex = 22
        btnOpenPOS.Text = "Point Of Sale " & ChrW(55357) & ChrW(57042)
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.BorderColor = Color.DarkBlue
        btnOpenInventory.BorderRadius = 12
        btnOpenInventory.BorderThickness = 1
        btnOpenInventory.CustomizableEdges = CustomizableEdges7
        btnOpenInventory.DisabledState.BorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenInventory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenInventory.FillColor = Color.Transparent
        btnOpenInventory.Font = New Font("Segoe UI", 9F)
        btnOpenInventory.ForeColor = Color.DarkBlue
        btnOpenInventory.Location = New Point(9, 508)
        btnOpenInventory.Margin = New Padding(3, 4, 3, 4)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.PressedColor = Color.Transparent
        btnOpenInventory.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnOpenInventory.Size = New Size(146, 45)
        btnOpenInventory.TabIndex = 23
        btnOpenInventory.Text = "Inventory  📦"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.DarkBlue
        Guna2Button1.BorderRadius = 12
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges9
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.DarkBlue
        Guna2Button1.Location = New Point(8, 301)
        Guna2Button1.Margin = New Padding(3, 4, 3, 4)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button1.Size = New Size(146, 45)
        Guna2Button1.TabIndex = 24
        Guna2Button1.Text = "Dasboard"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.White
        Guna2Button2.BorderRadius = 12
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges11
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Blue
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.WhiteSmoke
        Guna2Button2.Location = New Point(10, 705)
        Guna2Button2.Margin = New Padding(3, 4, 3, 4)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button2.Size = New Size(146, 45)
        Guna2Button2.TabIndex = 25
        Guna2Button2.Text = "Users 👥"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.White
        Guna2Button3.BorderRadius = 12
        Guna2Button3.BorderThickness = 1
        Guna2Button3.CustomizableEdges = CustomizableEdges13
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Blue
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.WhiteSmoke
        Guna2Button3.Location = New Point(11, 813)
        Guna2Button3.Margin = New Padding(3, 4, 3, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Button3.Size = New Size(146, 45)
        Guna2Button3.TabIndex = 26
        Guna2Button3.Text = "Logout"
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.BackColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderColor = Color.Black
        Guna2CustomGradientPanel2.BorderRadius = 20
        Guna2CustomGradientPanel2.BorderThickness = 1
        Guna2CustomGradientPanel2.Controls.Add(Guna2Button1)
        Guna2CustomGradientPanel2.Controls.Add(Guna2Button2)
        Guna2CustomGradientPanel2.Controls.Add(btnOpenInventory)
        Guna2CustomGradientPanel2.Controls.Add(Guna2Button3)
        Guna2CustomGradientPanel2.Controls.Add(btnOpenPOS)
        Guna2CustomGradientPanel2.Controls.Add(btnSALESHISTORY)
        Guna2CustomGradientPanel2.Controls.Add(btnUploadPictures)
        Guna2CustomGradientPanel2.Controls.Add(PictureBox3)
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges15
        Guna2CustomGradientPanel2.FillColor = Color.DodgerBlue
        Guna2CustomGradientPanel2.FillColor2 = Color.SteelBlue
        Guna2CustomGradientPanel2.FillColor3 = Color.Navy
        Guna2CustomGradientPanel2.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel2.Location = New Point(2, 118)
        Guna2CustomGradientPanel2.Margin = New Padding(3, 4, 3, 4)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2CustomGradientPanel2.Size = New Size(163, 815)
        Guna2CustomGradientPanel2.TabIndex = 54
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label2)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button7)
        Guna2CustomGradientPanel3.Controls.Add(btnUpdate)
        Guna2CustomGradientPanel3.Controls.Add(Button1)
        Guna2CustomGradientPanel3.Controls.Add(BtnExportcsv)
        Guna2CustomGradientPanel3.Controls.Add(btnDelete)
        Guna2CustomGradientPanel3.Controls.Add(btnAddProduct)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges19
        Guna2CustomGradientPanel3.FillColor = Color.DimGray
        Guna2CustomGradientPanel3.FillColor2 = Color.RoyalBlue
        Guna2CustomGradientPanel3.FillColor3 = Color.LightSkyBlue
        Guna2CustomGradientPanel3.FillColor4 = Color.Navy
        Guna2CustomGradientPanel3.Location = New Point(171, 13)
        Guna2CustomGradientPanel3.Margin = New Padding(3, 4, 3, 4)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2CustomGradientPanel3.Size = New Size(1367, 93)
        Guna2CustomGradientPanel3.TabIndex = 56
        ' 
        ' Guna2Button7
        ' 
        Guna2Button7.BorderColor = Color.White
        Guna2Button7.BorderRadius = 12
        Guna2Button7.BorderThickness = 1
        Guna2Button7.CustomizableEdges = CustomizableEdges17
        Guna2Button7.DisabledState.BorderColor = Color.DarkGray
        Guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button7.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button7.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button7.FillColor = Color.Blue
        Guna2Button7.Font = New Font("Segoe UI", 9F)
        Guna2Button7.ForeColor = Color.WhiteSmoke
        Guna2Button7.Location = New Point(11, 813)
        Guna2Button7.Margin = New Padding(3, 4, 3, 4)
        Guna2Button7.Name = "Guna2Button7"
        Guna2Button7.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2Button7.Size = New Size(146, 45)
        Guna2Button7.TabIndex = 26
        Guna2Button7.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(163, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 50)
        Label2.TabIndex = 27
        Label2.Text = "Inventory"
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(1135, 684)
        Controls.Add(PictureBox1)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(Guna2CustomGradientPanel2)
        Controls.Add(txtCategory)
        Controls.Add(txtProductCode)
        Controls.Add(txtProductName)
        Controls.Add(Label1)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        WindowState = FormWindowState.Maximized
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel2.ResumeLayout(False)
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnExportcsv As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents btnSALESHISTORY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class

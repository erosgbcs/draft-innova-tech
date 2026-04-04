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
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        btnAddProduct = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label3 = New Label()
        txtCategory = New TextBox()
        Label7 = New Label()
        txtProductCode = New TextBox()
        Label6 = New Label()
        txtProductName = New TextBox()
        Label4 = New Label()
        txtStock = New TextBox()
        txtPrice = New TextBox()
        Label5 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        btnOpenPOS = New Guna.UI2.WinForms.Guna2Button()
        btnSALESHISTORY = New Guna.UI2.WinForms.Guna2Button()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(149, 234)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(1034, 27)
        txtSearch.TabIndex = 5
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(150, 267)
        dgvProducts.Margin = New Padding(4, 3, 4, 3)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(1048, 367)
        dgvProducts.TabIndex = 6
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(894, 15)
        btnAddProduct.Margin = New Padding(4, 3, 4, 3)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(32, 25)
        btnAddProduct.TabIndex = 12
        btnAddProduct.Text = "➕"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(851, 15)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(36, 25)
        btnDelete.TabIndex = 16
        btnDelete.Text = "🗑️"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Green
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(500, 12)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(127, 28)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update Product"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnExportcsv
        ' 
        BtnExportcsv.BackColor = Color.Lime
        BtnExportcsv.FlatStyle = FlatStyle.Flat
        BtnExportcsv.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnExportcsv.Location = New Point(751, 15)
        BtnExportcsv.Margin = New Padding(4, 3, 4, 3)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(94, 25)
        BtnExportcsv.TabIndex = 18
        BtnExportcsv.Text = "📄 Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DimGray
        Label1.Location = New Point(149, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(740, 2)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(149, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 20
        Label2.Text = "Inventory"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(633, 15)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 25)
        Button1.TabIndex = 21
        Button1.Text = "🖨️ Print Report"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.FromArgb(CByte(147), CByte(197), CByte(253))
        Guna2CustomGradientPanel1.BorderRadius = 20
        Guna2CustomGradientPanel1.BorderThickness = 1
        Guna2CustomGradientPanel1.Controls.Add(Label3)
        Guna2CustomGradientPanel1.Controls.Add(Label4)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel1.FillColor = Color.Black
        Guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2CustomGradientPanel1.FillColor3 = Color.LightSlateGray
        Guna2CustomGradientPanel1.FillColor4 = Color.Lavender
        Guna2CustomGradientPanel1.Location = New Point(150, 61)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 25
        Guna2CustomGradientPanel1.ShadowDecoration.Color = Color.FromArgb(CByte(191), CByte(219), CByte(254))
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel1.ShadowDecoration.Enabled = True
        Guna2CustomGradientPanel1.Size = New Size(1033, 158)
        Guna2CustomGradientPanel1.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(34, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 48
        Label3.Text = "Product Code"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(432, 113)
        txtCategory.Margin = New Padding(4, 3, 4, 3)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(193, 23)
        txtCategory.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(687, 95)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 52
        Label7.Text = "Stock"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = Color.White
        txtProductCode.Location = New Point(179, 113)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(193, 23)
        txtProductCode.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(432, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 51
        Label6.Text = "Price"
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.White
        txtProductName.Location = New Point(179, 167)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(193, 23)
        txtProductName.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(34, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 49
        Label4.Text = "Product Name"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(687, 113)
        txtStock.Margin = New Padding(4, 3, 4, 3)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(193, 23)
        txtStock.TabIndex = 47
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(432, 167)
        txtPrice.Margin = New Padding(4, 3, 4, 3)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(193, 23)
        txtPrice.TabIndex = 46
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(432, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 50
        Label5.Text = "Category"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(Guna2Button3)
        Guna2Panel1.Controls.Add(Guna2Button2)
        Guna2Panel1.Controls.Add(Guna2Button1)
        Guna2Panel1.Controls.Add(btnOpenInventory)
        Guna2Panel1.Controls.Add(btnOpenPOS)
        Guna2Panel1.Controls.Add(btnSALESHISTORY)
        Guna2Panel1.Controls.Add(btnUploadPictures)
        Guna2Panel1.Controls.Add(PictureBox3)
        Guna2Panel1.CustomBorderColor = Color.Transparent
        Guna2Panel1.CustomizableEdges = CustomizableEdges15
        Guna2Panel1.FillColor = SystemColors.WindowFrame
        Guna2Panel1.Location = New Point(2, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2Panel1.Size = New Size(142, 699)
        Guna2Panel1.TabIndex = 53
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.White
        Guna2Button3.BorderRadius = 12
        Guna2Button3.BorderThickness = 1
        Guna2Button3.CustomizableEdges = CustomizableEdges3
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Blue
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.WhiteSmoke
        Guna2Button3.Location = New Point(8, 600)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button3.Size = New Size(128, 34)
        Guna2Button3.TabIndex = 26
        Guna2Button3.Text = "Logout"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.White
        Guna2Button2.BorderRadius = 12
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges5
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Blue
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.WhiteSmoke
        Guna2Button2.Location = New Point(6, 526)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button2.Size = New Size(128, 34)
        Guna2Button2.TabIndex = 25
        Guna2Button2.Text = "Users 👥"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.White
        Guna2Button1.BorderRadius = 12
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges7
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Blue
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.WhiteSmoke
        Guna2Button1.Location = New Point(6, 220)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button1.Size = New Size(128, 34)
        Guna2Button1.TabIndex = 24
        Guna2Button1.Text = "Dasboard"
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.BorderColor = Color.White
        btnOpenInventory.BorderRadius = 12
        btnOpenInventory.BorderThickness = 1
        btnOpenInventory.CustomizableEdges = CustomizableEdges9
        btnOpenInventory.DisabledState.BorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenInventory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenInventory.FillColor = Color.Blue
        btnOpenInventory.Font = New Font("Segoe UI", 9F)
        btnOpenInventory.ForeColor = Color.White
        btnOpenInventory.Location = New Point(6, 374)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnOpenInventory.Size = New Size(128, 34)
        btnOpenInventory.TabIndex = 23
        btnOpenInventory.Text = "Inventory  📦"
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.BorderColor = Color.White
        btnOpenPOS.BorderRadius = 12
        btnOpenPOS.BorderThickness = 1
        btnOpenPOS.CustomizableEdges = CustomizableEdges11
        btnOpenPOS.DisabledState.BorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenPOS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenPOS.FillColor = Color.Blue
        btnOpenPOS.Font = New Font("Segoe UI", 9F)
        btnOpenPOS.ForeColor = Color.White
        btnOpenPOS.Location = New Point(6, 299)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnOpenPOS.Size = New Size(128, 34)
        btnOpenPOS.TabIndex = 22
        btnOpenPOS.Text = "Point Of Sale " & ChrW(55357) & ChrW(57042)
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.BorderColor = Color.White
        btnSALESHISTORY.BorderRadius = 12
        btnSALESHISTORY.BorderThickness = 1
        btnSALESHISTORY.CustomizableEdges = CustomizableEdges13
        btnSALESHISTORY.DisabledState.BorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.CustomBorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSALESHISTORY.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSALESHISTORY.FillColor = Color.Blue
        btnSALESHISTORY.Font = New Font("Segoe UI", 9F)
        btnSALESHISTORY.ForeColor = Color.WhiteSmoke
        btnSALESHISTORY.Location = New Point(6, 449)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnSALESHISTORY.Size = New Size(128, 34)
        btnSALESHISTORY.TabIndex = 21
        btnSALESHISTORY.Text = "Sales History 📜"
        ' 
        ' btnUploadPictures
        ' 
        btnUploadPictures.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadPictures.Location = New Point(18, 125)
        btnUploadPictures.Margin = New Padding(3, 2, 3, 2)
        btnUploadPictures.Name = "btnUploadPictures"
        btnUploadPictures.Size = New Size(103, 23)
        btnUploadPictures.TabIndex = 13
        btnUploadPictures.Text = "Upload Pictures"
        btnUploadPictures.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(230), CByte(242), CByte(255))
        ClientSize = New Size(1044, 516)
        Controls.Add(Guna2Panel1)
        Controls.Add(txtCategory)
        Controls.Add(Label7)
        Controls.Add(txtProductCode)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(txtProductName)
        Controls.Add(Label1)
        Controls.Add(btnUpdate)
        Controls.Add(txtStock)
        Controls.Add(BtnExportcsv)
        Controls.Add(txtPrice)
        Controls.Add(btnAddProduct)
        Controls.Add(Label5)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(btnDelete)
        Controls.Add(Guna2CustomGradientPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        WindowState = FormWindowState.Maximized
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
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
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSALESHISTORY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class

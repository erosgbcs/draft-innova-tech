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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        Label7 = New Label()
        txtCategory = New TextBox()
        Label6 = New Label()
        txtStock = New TextBox()
        Label5 = New Label()
        txtPrice = New TextBox()
        Label4 = New Label()
        txtProductName = New TextBox()
        Label3 = New Label()
        txtProductCode = New TextBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        btnOpenPOS = New Guna.UI2.WinForms.Guna2Button()
        btnSALESHISTORY = New Guna.UI2.WinForms.Guna2Button()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(689, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 42
        Label7.Text = "Stock"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(434, 94)
        txtCategory.Margin = New Padding(4, 3, 4, 3)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(193, 23)
        txtCategory.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(434, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 41
        Label6.Text = "Price"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(689, 94)
        txtStock.Margin = New Padding(4, 3, 4, 3)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(193, 23)
        txtStock.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(434, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 40
        Label5.Text = "Category"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(434, 148)
        txtPrice.Margin = New Padding(4, 3, 4, 3)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(193, 23)
        txtPrice.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(181, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 39
        Label4.Text = "Product Name"
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.White
        txtProductName.Location = New Point(181, 148)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(193, 23)
        txtProductName.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(181, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 38
        Label3.Text = "Product Code"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = Color.White
        txtProductCode.Location = New Point(181, 94)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(193, 23)
        txtProductCode.TabIndex = 33
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(btnOpenInventory)
        Guna2Panel1.Controls.Add(btnOpenPOS)
        Guna2Panel1.Controls.Add(btnSALESHISTORY)
        Guna2Panel1.Controls.Add(btnUploadPictures)
        Guna2Panel1.Controls.Add(PictureBox3)
        Guna2Panel1.CustomBorderColor = Color.Transparent
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.FillColor = Color.DarkBlue
        Guna2Panel1.Location = New Point(1, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(142, 634)
        Guna2Panel1.TabIndex = 43
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.CustomizableEdges = CustomizableEdges1
        btnOpenInventory.DisabledState.BorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenInventory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenInventory.Font = New Font("Segoe UI", 9F)
        btnOpenInventory.ForeColor = Color.White
        btnOpenInventory.Location = New Point(7, 332)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnOpenInventory.Size = New Size(128, 34)
        btnOpenInventory.TabIndex = 20
        btnOpenInventory.Text = "Inventory"
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.CustomizableEdges = CustomizableEdges3
        btnOpenPOS.DisabledState.BorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenPOS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenPOS.Font = New Font("Segoe UI", 9F)
        btnOpenPOS.ForeColor = Color.White
        btnOpenPOS.Location = New Point(7, 280)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnOpenPOS.Size = New Size(128, 34)
        btnOpenPOS.TabIndex = 19
        btnOpenPOS.Text = "Products"
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.CustomizableEdges = CustomizableEdges5
        btnSALESHISTORY.DisabledState.BorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.CustomBorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSALESHISTORY.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSALESHISTORY.Font = New Font("Segoe UI", 9F)
        btnSALESHISTORY.ForeColor = Color.White
        btnSALESHISTORY.Location = New Point(7, 224)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSALESHISTORY.Size = New Size(128, 34)
        btnSALESHISTORY.TabIndex = 18
        btnSALESHISTORY.Text = "Sales History"
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
        ClientSize = New Size(1044, 516)
        Controls.Add(Guna2Panel1)
        Controls.Add(Label7)
        Controls.Add(txtCategory)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(txtStock)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(btnUpdate)
        Controls.Add(Label4)
        Controls.Add(BtnExportcsv)
        Controls.Add(txtProductName)
        Controls.Add(btnAddProduct)
        Controls.Add(Label3)
        Controls.Add(dgvProducts)
        Controls.Add(txtProductCode)
        Controls.Add(txtSearch)
        Controls.Add(btnDelete)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        WindowState = FormWindowState.Maximized
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSALESHISTORY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class

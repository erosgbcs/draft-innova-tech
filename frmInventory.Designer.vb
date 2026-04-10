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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PrintInventoryDoc = New Printing.PrintDocument()
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        btnAddProduct = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        printreport = New Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        txtCategory = New TextBox()
        txtStock = New TextBox()
        Label5 = New Label()
        txtProductCode = New TextBox()
        Label6 = New Label()
        txtPrice = New TextBox()
        txtProductName = New TextBox()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label2 = New Label()
        Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        lblTitle = New Label()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel1.SuspendLayout()
        Guna2CustomGradientPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrintInventoryDoc
        ' 
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(6, 264)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(1145, 27)
        txtSearch.TabIndex = 5
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.BackgroundColor = Color.Gainsboro
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(6, 297)
        dgvProducts.Margin = New Padding(4, 3, 4, 3)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(1145, 482)
        dgvProducts.TabIndex = 6
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(973, 94)
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
        btnDelete.Location = New Point(918, 94)
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
        btnUpdate.ForeColor = Color.Wheat
        btnUpdate.Location = New Point(541, 94)
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
        BtnExportcsv.Location = New Point(805, 94)
        BtnExportcsv.Margin = New Padding(4, 3, 4, 3)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(94, 25)
        BtnExportcsv.TabIndex = 18
        BtnExportcsv.Text = "📄 Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' printreport
        ' 
        printreport.BackColor = SystemColors.Highlight
        printreport.FlatStyle = FlatStyle.Flat
        printreport.ForeColor = Color.Black
        printreport.Location = New Point(687, 96)
        printreport.Margin = New Padding(3, 2, 3, 2)
        printreport.Name = "printreport"
        printreport.Size = New Size(111, 25)
        printreport.TabIndex = 21
        printreport.Text = "🖨️ Print Report"
        printreport.UseVisualStyleBackColor = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.Black
        Guna2CustomGradientPanel1.BorderRadius = 20
        Guna2CustomGradientPanel1.BorderThickness = 1
        Guna2CustomGradientPanel1.Controls.Add(Label3)
        Guna2CustomGradientPanel1.Controls.Add(Label4)
        Guna2CustomGradientPanel1.Controls.Add(btnUpdate)
        Guna2CustomGradientPanel1.Controls.Add(Label7)
        Guna2CustomGradientPanel1.Controls.Add(printreport)
        Guna2CustomGradientPanel1.Controls.Add(BtnExportcsv)
        Guna2CustomGradientPanel1.Controls.Add(txtCategory)
        Guna2CustomGradientPanel1.Controls.Add(btnDelete)
        Guna2CustomGradientPanel1.Controls.Add(txtStock)
        Guna2CustomGradientPanel1.Controls.Add(btnAddProduct)
        Guna2CustomGradientPanel1.Controls.Add(Label5)
        Guna2CustomGradientPanel1.Controls.Add(txtProductCode)
        Guna2CustomGradientPanel1.Controls.Add(Label6)
        Guna2CustomGradientPanel1.Controls.Add(txtPrice)
        Guna2CustomGradientPanel1.Controls.Add(txtProductName)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel1.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel1.FillColor2 = Color.DarkTurquoise
        Guna2CustomGradientPanel1.FillColor3 = Color.Navy
        Guna2CustomGradientPanel1.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel1.Location = New Point(6, 120)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 25
        Guna2CustomGradientPanel1.ShadowDecoration.Color = Color.FromArgb(CByte(191), CByte(219), CByte(254))
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel1.ShadowDecoration.Enabled = True
        Guna2CustomGradientPanel1.Size = New Size(1148, 138)
        Guna2CustomGradientPanel1.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 48
        Label3.Text = "Product Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(24, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 49
        Label4.Text = "Product Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(534, 17)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 20)
        Label7.TabIndex = 52
        Label7.Text = "Stock"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(282, 40)
        txtCategory.Margin = New Padding(4, 3, 4, 3)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(193, 23)
        txtCategory.TabIndex = 45
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(537, 40)
        txtStock.Margin = New Padding(4, 3, 4, 3)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(193, 23)
        txtStock.TabIndex = 47
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(279, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 50
        Label5.Text = "Category"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = Color.White
        txtProductCode.ForeColor = SystemColors.WindowText
        txtProductCode.Location = New Point(24, 40)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(193, 23)
        txtProductCode.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(281, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 20)
        Label6.TabIndex = 51
        Label6.Text = "Price"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(282, 96)
        txtPrice.Margin = New Padding(4, 3, 4, 3)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(193, 23)
        txtPrice.TabIndex = 46
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.White
        txtProductName.Location = New Point(24, 96)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(193, 23)
        txtProductName.TabIndex = 44
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label2)
        Guna2CustomGradientPanel3.Controls.Add(lblTitle)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button7)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges5
        Guna2CustomGradientPanel3.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel3.FillColor2 = Color.DarkTurquoise
        Guna2CustomGradientPanel3.FillColor3 = Color.Navy
        Guna2CustomGradientPanel3.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel3.Location = New Point(6, 3)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomGradientPanel3.Size = New Size(1148, 102)
        Guna2CustomGradientPanel3.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(485, 25)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' Guna2Button7
        ' 
        Guna2Button7.BorderColor = Color.White
        Guna2Button7.BorderRadius = 12
        Guna2Button7.BorderThickness = 1
        Guna2Button7.CustomizableEdges = CustomizableEdges3
        Guna2Button7.DisabledState.BorderColor = Color.DarkGray
        Guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button7.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button7.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button7.FillColor = Color.Blue
        Guna2Button7.Font = New Font("Segoe UI", 9F)
        Guna2Button7.ForeColor = Color.WhiteSmoke
        Guna2Button7.Location = New Point(10, 610)
        Guna2Button7.Name = "Guna2Button7"
        Guna2Button7.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button7.Size = New Size(128, 34)
        Guna2Button7.TabIndex = 26
        Guna2Button7.Text = "Logout"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(-40, 4)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(929, 75)
        lblTitle.TabIndex = 27
        lblTitle.Text = "Kirby's Hardware Trading Inventory"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1174, 562)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(Guna2CustomGradientPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        WindowState = FormWindowState.Maximized
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnExportcsv As Button
    Friend WithEvents printreport As Button
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
    Friend WithEvents PrintInventoryDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Label
End Class

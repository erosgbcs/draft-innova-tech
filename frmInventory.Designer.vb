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
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        txtProductCode = New TextBox()
        txtProductName = New TextBox()
        txtCategory = New TextBox()
        txtPrice = New TextBox()
        txtStock = New TextBox()
        btnAddProduct = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(10, 175)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(731, 27)
        txtSearch.TabIndex = 5
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(11, 214)
        dgvProducts.Margin = New Padding(4, 3, 4, 3)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(730, 172)
        dgvProducts.TabIndex = 6
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = Color.White
        txtProductCode.Location = New Point(18, 26)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(193, 23)
        txtProductCode.TabIndex = 7
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.White
        txtProductName.Location = New Point(18, 80)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(193, 23)
        txtProductName.TabIndex = 8
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(271, 26)
        txtCategory.Margin = New Padding(4, 3, 4, 3)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(193, 23)
        txtCategory.TabIndex = 9
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(271, 80)
        txtPrice.Margin = New Padding(4, 3, 4, 3)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(193, 23)
        txtPrice.TabIndex = 10
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(526, 26)
        txtStock.Margin = New Padding(4, 3, 4, 3)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(193, 23)
        txtStock.TabIndex = 11
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(713, 7)
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
        btnDelete.Location = New Point(670, 7)
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
        btnUpdate.Location = New Point(319, 4)
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
        BtnExportcsv.Location = New Point(570, 7)
        BtnExportcsv.Margin = New Padding(4, 3, 4, 3)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(94, 25)
        BtnExportcsv.TabIndex = 18
        BtnExportcsv.Text = "📄 Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtCategory)
        Panel1.Controls.Add(txtProductCode)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(txtPrice)
        Panel1.Controls.Add(txtStock)
        Panel1.Location = New Point(5, 46)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(756, 111)
        Panel1.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(526, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 16
        Label7.Text = "Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(271, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 15
        Label6.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(271, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 14
        Label5.Text = "Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(18, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 13
        Label4.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 12
        Label3.Text = "Product Code"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DimGray
        Label1.Location = New Point(5, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(740, 2)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(5, 7)
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
        Button1.Location = New Point(452, 7)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 25)
        Button1.TabIndex = 21
        Button1.Text = "🖨️ Print Report"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 392)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnUpdate)
        Controls.Add(BtnExportcsv)
        Controls.Add(btnAddProduct)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(btnDelete)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        WindowState = FormWindowState.Maximized
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnExportcsv As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class

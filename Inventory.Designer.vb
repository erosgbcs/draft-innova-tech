<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        lblInventoryManagement = New Label()
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        txtProductCode = New TextBox()
        txtProductName = New TextBox()
        txtCategory = New TextBox()
        txtPrice = New TextBox()
        txtStock = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        BtnExportcsv = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblInventoryManagement
        ' 
        lblInventoryManagement.AutoSize = True
        lblInventoryManagement.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryManagement.ForeColor = Color.Navy
        lblInventoryManagement.Location = New Point(497, 9)
        lblInventoryManagement.Margin = New Padding(4, 0, 4, 0)
        lblInventoryManagement.Name = "lblInventoryManagement"
        lblInventoryManagement.Size = New Size(350, 41)
        lblInventoryManagement.TabIndex = 4
        lblInventoryManagement.Text = "Inventory Management"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(22, 54)
        txtSearch.Margin = New Padding(4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Product Inventory by code or name.."
        txtSearch.Size = New Size(825, 32)
        txtSearch.TabIndex = 5
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(22, 94)
        dgvProducts.Margin = New Padding(4)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(825, 310)
        dgvProducts.TabIndex = 6
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Location = New Point(22, 412)
        txtProductCode.Margin = New Padding(4)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.PlaceholderText = "Product code"
        txtProductCode.Size = New Size(142, 27)
        txtProductCode.TabIndex = 7
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(172, 412)
        txtProductName.Margin = New Padding(4)
        txtProductName.Name = "txtProductName"
        txtProductName.PlaceholderText = "Product name"
        txtProductName.Size = New Size(148, 27)
        txtProductName.TabIndex = 8
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(337, 412)
        txtCategory.Margin = New Padding(4)
        txtCategory.Name = "txtCategory"
        txtCategory.PlaceholderText = "Category"
        txtCategory.Size = New Size(124, 27)
        txtCategory.TabIndex = 9
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(479, 412)
        txtPrice.Margin = New Padding(4)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(103, 27)
        txtPrice.TabIndex = 10
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(590, 412)
        txtStock.Margin = New Padding(4)
        txtStock.Name = "txtStock"
        txtStock.PlaceholderText = "Stock"
        txtStock.Size = New Size(126, 27)
        txtStock.TabIndex = 11
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(45), CByte(84), CByte(150))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(730, 412)
        btnAdd.Margin = New Padding(4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(117, 43)
        btnAdd.TabIndex = 12
        btnAdd.Text = "Add Product"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Green
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(549, 460)
        btnDelete.Margin = New Padding(4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(145, 55)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete Product"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Green
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(702, 457)
        btnUpdate.Margin = New Padding(4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(145, 55)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update Product"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnExportcsv
        ' 
        BtnExportcsv.BackColor = Color.Lime
        BtnExportcsv.FlatStyle = FlatStyle.Flat
        BtnExportcsv.Location = New Point(22, 460)
        BtnExportcsv.Margin = New Padding(4)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(131, 49)
        BtnExportcsv.TabIndex = 18
        BtnExportcsv.Text = "Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 522)
        Controls.Add(BtnExportcsv)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtCategory)
        Controls.Add(txtProductName)
        Controls.Add(txtProductCode)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(lblInventoryManagement)
        Name = "Inventory"
        Text = "Inventory"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInventoryManagement As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnExportcsv As Button
End Class

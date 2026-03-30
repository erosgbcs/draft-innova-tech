<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_History
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
        txtSearchHistory = New TextBox()
        lblSalesHistory = New Label()
        dgvSales = New DataGridView()
        Panel1 = New Panel()
        Label22 = New Label()
        Label26 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearchHistory
        ' 
        txtSearchHistory.Location = New Point(13, 54)
        txtSearchHistory.Margin = New Padding(4)
        txtSearchHistory.Name = "txtSearchHistory"
        txtSearchHistory.PlaceholderText = "Search History Sales..."
        txtSearchHistory.Size = New Size(825, 27)
        txtSearchHistory.TabIndex = 2
        ' 
        ' lblSalesHistory
        ' 
        lblSalesHistory.AutoSize = True
        lblSalesHistory.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalesHistory.ForeColor = Color.Navy
        lblSalesHistory.Location = New Point(590, 0)
        lblSalesHistory.Margin = New Padding(4, 0, 4, 0)
        lblSalesHistory.Name = "lblSalesHistory"
        lblSalesHistory.Size = New Size(248, 50)
        lblSalesHistory.TabIndex = 3
        lblSalesHistory.Text = "Sales History"
        ' 
        ' dgvSales
        ' 
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSales.BackgroundColor = Color.Silver
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(13, 89)
        dgvSales.Margin = New Padding(4)
        dgvSales.Name = "dgvSales"
        dgvSales.RowHeadersWidth = 51
        dgvSales.Size = New Size(825, 248)
        dgvSales.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Location = New Point(13, 361)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 139)
        Panel1.TabIndex = 5
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(567, 62)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(187, 28)
        Label22.TabIndex = 4
        Label22.Text = "Recommendations"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(300, 62)
        Label26.Margin = New Padding(4, 0, 4, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(205, 28)
        Label26.TabIndex = 3
        Label26.Text = "Top Selling Products"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(11, 62)
        Label19.Margin = New Padding(4, 0, 4, 0)
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
        Label18.Location = New Point(11, 10)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(223, 32)
        Label18.TabIndex = 0
        Label18.Text = "Inventory Insights"
        ' 
        ' Sales_History
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(867, 531)
        Controls.Add(Panel1)
        Controls.Add(dgvSales)
        Controls.Add(lblSalesHistory)
        Controls.Add(txtSearchHistory)
        Name = "Sales_History"
        Text = "Sales_History"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearchHistory As TextBox
    Friend WithEvents lblSalesHistory As Label
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
End Class

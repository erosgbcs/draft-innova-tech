<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesHIstory
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label1 = New Label()
        Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        txtSearchSales = New TextBox()
        dgvsaleshistory = New DataGridView()
        printreport = New Button()
        BtnExportcsv = New Button()
        PrintSalesDoc = New Printing.PrintDocument()
        Guna2CustomGradientPanel3.SuspendLayout()
        CType(dgvsaleshistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label1)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button7)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel3.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel3.FillColor2 = Color.DarkTurquoise
        Guna2CustomGradientPanel3.FillColor3 = Color.Navy
        Guna2CustomGradientPanel3.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel3.Location = New Point(5, 5)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel3.Size = New Size(1159, 87)
        Guna2CustomGradientPanel3.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 65)
        Label1.TabIndex = 27
        Label1.Text = "Sales History"
        ' 
        ' Guna2Button7
        ' 
        Guna2Button7.BorderColor = Color.White
        Guna2Button7.BorderRadius = 12
        Guna2Button7.BorderThickness = 1
        Guna2Button7.CustomizableEdges = CustomizableEdges1
        Guna2Button7.DisabledState.BorderColor = Color.DarkGray
        Guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button7.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button7.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button7.FillColor = Color.Blue
        Guna2Button7.Font = New Font("Segoe UI", 9F)
        Guna2Button7.ForeColor = Color.WhiteSmoke
        Guna2Button7.Location = New Point(-1, 611)
        Guna2Button7.Name = "Guna2Button7"
        Guna2Button7.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button7.Size = New Size(128, 34)
        Guna2Button7.TabIndex = 26
        Guna2Button7.Text = "Logout"
        ' 
        ' txtSearchSales
        ' 
        txtSearchSales.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchSales.Location = New Point(8, 142)
        txtSearchSales.Margin = New Padding(4, 3, 4, 3)
        txtSearchSales.Name = "txtSearchSales"
        txtSearchSales.PlaceholderText = "Product Sales History by code or name.."
        txtSearchSales.Size = New Size(1156, 27)
        txtSearchSales.TabIndex = 60
        ' 
        ' dgvsaleshistory
        ' 
        dgvsaleshistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvsaleshistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvsaleshistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvsaleshistory.Location = New Point(9, 173)
        dgvsaleshistory.Name = "dgvsaleshistory"
        dgvsaleshistory.Size = New Size(1155, 576)
        dgvsaleshistory.TabIndex = 61
        ' 
        ' printreport
        ' 
        printreport.BackColor = SystemColors.Highlight
        printreport.FlatStyle = FlatStyle.Flat
        printreport.ForeColor = Color.Black
        printreport.Location = New Point(8, 100)
        printreport.Margin = New Padding(3, 2, 3, 2)
        printreport.Name = "printreport"
        printreport.Size = New Size(111, 30)
        printreport.TabIndex = 63
        printreport.Text = "🖨️ Print Report"
        printreport.UseVisualStyleBackColor = False
        ' 
        ' BtnExportcsv
        ' 
        BtnExportcsv.BackColor = Color.Lime
        BtnExportcsv.FlatStyle = FlatStyle.Flat
        BtnExportcsv.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnExportcsv.Location = New Point(132, 100)
        BtnExportcsv.Margin = New Padding(4, 3, 4, 3)
        BtnExportcsv.Name = "BtnExportcsv"
        BtnExportcsv.Size = New Size(94, 30)
        BtnExportcsv.TabIndex = 62
        BtnExportcsv.Text = "📄 Export CSV"
        BtnExportcsv.UseVisualStyleBackColor = False
        ' 
        ' PrintSalesDoc
        ' 
        ' 
        ' frmSalesHIstory
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1179, 567)
        Controls.Add(printreport)
        Controls.Add(dgvsaleshistory)
        Controls.Add(BtnExportcsv)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(txtSearchSales)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmSalesHIstory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSalesHIstory"
        WindowState = FormWindowState.Maximized
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        CType(dgvsaleshistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchSales As TextBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvsaleshistory As DataGridView
    Friend WithEvents printreport As Button
    Friend WithEvents BtnExportcsv As Button
    Friend WithEvents PrintSalesDoc As Printing.PrintDocument

End Class

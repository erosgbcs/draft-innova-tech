<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label24 = New Label()
        Timer1 = New Timer(components)
        MainStatsContainer = New FlowLayoutPanel()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        lblTime = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        flpchart = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        flpinventoryinsights = New FlowLayoutPanel()
        PageSetupDialog1 = New PageSetupDialog()
        MainStatsContainer.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2CustomGradientPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(579, 3)
        Label24.Name = "Label24"
        Label24.Size = New Size(273, 65)
        Label24.TabIndex = 9
        Label24.Text = "Dashboard"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' MainStatsContainer
        ' 
        MainStatsContainer.BackColor = Color.Transparent
        MainStatsContainer.Controls.Add(Guna2DataGridView1)
        MainStatsContainer.Location = New Point(9, 129)
        MainStatsContainer.Name = "MainStatsContainer"
        MainStatsContainer.Size = New Size(1297, 160)
        MainStatsContainer.TabIndex = 46
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(3, 3)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.Size = New Size(240, 150)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label2)
        Guna2CustomGradientPanel3.Controls.Add(Label1)
        Guna2CustomGradientPanel3.Controls.Add(Label24)
        Guna2CustomGradientPanel3.Controls.Add(Label4)
        Guna2CustomGradientPanel3.Controls.Add(lblTime)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button1)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel3.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel3.FillColor2 = Color.SteelBlue
        Guna2CustomGradientPanel3.FillColor3 = Color.Navy
        Guna2CustomGradientPanel3.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel3.Location = New Point(7, 4)
        Guna2CustomGradientPanel3.Margin = New Padding(2, 3, 2, 3)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel3.Size = New Size(1299, 109)
        Guna2CustomGradientPanel3.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(430, 8)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 51)
        Label2.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(33, 62)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(485, 25)
        Label1.TabIndex = 1
        Label1.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(-12, 0)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(616, 58)
        Label4.TabIndex = 0
        Label4.Text = "Kirby's Hardware Trading"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(542, 62)
        lblTime.Margin = New Padding(2, 0, 2, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(97, 30)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.White
        Guna2Button1.BorderRadius = 12
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Blue
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.WhiteSmoke
        Guna2Button1.Location = New Point(9, 650)
        Guna2Button1.Margin = New Padding(2, 3, 2, 3)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(117, 36)
        Guna2Button1.TabIndex = 26
        Guna2Button1.Text = "Logout"
        ' 
        ' flpchart
        ' 
        flpchart.AutoScroll = True
        flpchart.BackColor = Color.Transparent
        flpchart.BorderRadius = 37
        flpchart.CustomizableEdges = CustomizableEdges5
        flpchart.Location = New Point(12, 321)
        flpchart.Name = "flpchart"
        flpchart.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        flpchart.Size = New Size(1294, 392)
        flpchart.TabIndex = 61
        ' 
        ' flpinventoryinsights
        ' 
        flpinventoryinsights.BackColor = Color.White
        flpinventoryinsights.Location = New Point(12, 719)
        flpinventoryinsights.Name = "flpinventoryinsights"
        flpinventoryinsights.Size = New Size(1294, 160)
        flpinventoryinsights.TabIndex = 62
        ' 
        ' frmdashboard
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1199, 599)
        Controls.Add(flpinventoryinsights)
        Controls.Add(flpchart)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(MainStatsContainer)
        KeyPreview = True
        Name = "frmdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        WindowState = FormWindowState.Maximized
        MainStatsContainer.ResumeLayout(False)
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label24 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainStatsContainer As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents flpchart As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flpinventoryinsights As FlowLayoutPanel
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView

End Class

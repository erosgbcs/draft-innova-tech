<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvActivity = New DataGridView()
        lblActivityHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        dgvUsers = New DataGridView()
        btnToggleStatus = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvActivity, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvActivity
        ' 
        dgvActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActivity.Location = New Point(21, 53)
        dgvActivity.Name = "dgvActivity"
        dgvActivity.Size = New Size(763, 176)
        dgvActivity.TabIndex = 0
        ' 
        ' lblActivityHeader
        ' 
        lblActivityHeader.BackColor = Color.Transparent
        lblActivityHeader.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivityHeader.ForeColor = Color.MediumBlue
        lblActivityHeader.Location = New Point(25, 12)
        lblActivityHeader.Name = "lblActivityHeader"
        lblActivityHeader.Size = New Size(140, 23)
        lblActivityHeader.TabIndex = 1
        lblActivityHeader.Text = "Guna2HtmlLabel1"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BorderRadius = 15
        btnRefresh.CustomizableEdges = CustomizableEdges5
        btnRefresh.DisabledState.BorderColor = Color.DarkGray
        btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefresh.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefresh.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(648, 2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnRefresh.Size = New Size(140, 45)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Guna2Button1"
        ' 
        ' dgvUsers
        ' 
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(21, 251)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.Size = New Size(763, 178)
        dgvUsers.TabIndex = 3
        ' 
        ' btnToggleStatus
        ' 
        btnToggleStatus.BorderRadius = 15
        btnToggleStatus.CustomizableEdges = CustomizableEdges7
        btnToggleStatus.DisabledState.BorderColor = Color.DarkGray
        btnToggleStatus.DisabledState.CustomBorderColor = Color.DarkGray
        btnToggleStatus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnToggleStatus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnToggleStatus.Font = New Font("Segoe UI", 9F)
        btnToggleStatus.ForeColor = Color.White
        btnToggleStatus.Location = New Point(475, 2)
        btnToggleStatus.Name = "btnToggleStatus"
        btnToggleStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnToggleStatus.Size = New Size(140, 45)
        btnToggleStatus.TabIndex = 4
        btnToggleStatus.Text = "Guna2Button1"
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnToggleStatus)
        Controls.Add(dgvUsers)
        Controls.Add(btnRefresh)
        Controls.Add(lblActivityHeader)
        Controls.Add(dgvActivity)
        Name = "User"
        Text = "User"
        CType(dgvActivity, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvActivity As DataGridView
    Friend WithEvents lblActivityHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnToggleStatus As Guna.UI2.WinForms.Guna2Button
End Class

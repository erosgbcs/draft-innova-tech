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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvActivity = New DataGridView()
        lblActivityHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgvUsers = New DataGridView()
        btnToggleStatus = New Guna.UI2.WinForms.Guna2Button()
        btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvActivity, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvActivity
        ' 
        dgvActivity.BackgroundColor = Color.White
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
        ' dgvUsers
        ' 
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(21, 251)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.Size = New Size(763, 178)
        dgvUsers.TabIndex = 3
        ' 
        ' btnToggleStatus
        ' 
        btnToggleStatus.BorderRadius = 15
        btnToggleStatus.BorderThickness = 1
        btnToggleStatus.CustomizableEdges = CustomizableEdges1
        btnToggleStatus.DisabledState.BorderColor = Color.DarkGray
        btnToggleStatus.DisabledState.CustomBorderColor = Color.DarkGray
        btnToggleStatus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnToggleStatus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnToggleStatus.Font = New Font("Segoe UI", 9F)
        btnToggleStatus.ForeColor = Color.Black
        btnToggleStatus.Location = New Point(548, 12)
        btnToggleStatus.Name = "btnToggleStatus"
        btnToggleStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnToggleStatus.Size = New Size(117, 33)
        btnToggleStatus.TabIndex = 4
        btnToggleStatus.Text = "TOGGLE STATUS"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BorderRadius = 15
        btnRefresh.BorderThickness = 1
        btnRefresh.CustomizableEdges = CustomizableEdges3
        btnRefresh.DisabledState.BorderColor = Color.DarkGray
        btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefresh.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefresh.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefresh.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnRefresh.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.Black
        btnRefresh.Location = New Point(671, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnRefresh.Size = New Size(113, 33)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "REFRESH 🔃"
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
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnToggleStatus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
End Class

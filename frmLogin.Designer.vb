<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        btnShowHide = New Button()
        btnForgotPassword = New Button()
        btnLogin = New Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnShowHide
        ' 
        btnShowHide.AccessibleRole = AccessibleRole.MenuBar
        btnShowHide.Anchor = AnchorStyles.None
        btnShowHide.BackColor = SystemColors.GradientInactiveCaption
        btnShowHide.FlatStyle = FlatStyle.Flat
        btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowHide.ForeColor = Color.Black
        btnShowHide.Location = New Point(282, 143)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(44, 33)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.AccessibleRole = AccessibleRole.Application
        btnForgotPassword.Anchor = AnchorStyles.None
        btnForgotPassword.BackColor = Color.Maroon
        btnForgotPassword.FlatStyle = FlatStyle.Flat
        btnForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.White
        btnForgotPassword.Location = New Point(223, 204)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(118, 31)
        btnForgotPassword.TabIndex = 6
        btnForgotPassword.Text = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.Green
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(30, 204)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.Black
        Guna2CustomGradientPanel1.BorderRadius = 18
        Guna2CustomGradientPanel1.Controls.Add(txtPassword)
        Guna2CustomGradientPanel1.Controls.Add(txtUsername)
        Guna2CustomGradientPanel1.Controls.Add(btnShowHide)
        Guna2CustomGradientPanel1.Controls.Add(btnLogin)
        Guna2CustomGradientPanel1.Controls.Add(btnForgotPassword)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2CustomGradientPanel1.FillColor = Color.DarkBlue
        Guna2CustomGradientPanel1.FillColor2 = Color.DarkBlue
        Guna2CustomGradientPanel1.Location = New Point(527, 229)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomGradientPanel1.Size = New Size(349, 391)
        Guna2CustomGradientPanel1.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.CustomizableEdges = CustomizableEdges3
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(129, 48)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = ""
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtUsername.Size = New Size(200, 36)
        txtUsername.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.CustomizableEdges = CustomizableEdges1
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(52, 102)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = ""
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtPassword.Size = New Size(200, 36)
        txtPassword.TabIndex = 9
        ' 
        ' FrmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.IndianRed
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1264, 681)
        Controls.Add(Guna2CustomGradientPanel1)
        Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        WindowState = FormWindowState.Maximized
        Guna2CustomGradientPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
End Class

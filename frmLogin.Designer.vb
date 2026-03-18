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
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        btnShowHide = New Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        btnRegister = New Guna.UI2.WinForms.Guna2Button()
        btnForgotPassword = New Guna.UI2.WinForms.Guna2Button()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
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
        btnShowHide.Location = New Point(259, 105)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(44, 33)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.Black
        Guna2CustomGradientPanel1.BorderRadius = 18
        Guna2CustomGradientPanel1.Controls.Add(btnRegister)
        Guna2CustomGradientPanel1.Controls.Add(btnForgotPassword)
        Guna2CustomGradientPanel1.Controls.Add(btnLogin)
        Guna2CustomGradientPanel1.Controls.Add(txtUsername)
        Guna2CustomGradientPanel1.Controls.Add(btnShowHide)
        Guna2CustomGradientPanel1.Controls.Add(txtPassword)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges23
        Guna2CustomGradientPanel1.FillColor = Color.DarkBlue
        Guna2CustomGradientPanel1.FillColor2 = Color.DarkBlue
        Guna2CustomGradientPanel1.Location = New Point(527, 229)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Guna2CustomGradientPanel1.Size = New Size(349, 391)
        Guna2CustomGradientPanel1.TabIndex = 8
        ' 
        ' btnRegister
        ' 
        btnRegister.CustomizableEdges = CustomizableEdges13
        btnRegister.DisabledState.BorderColor = Color.DarkGray
        btnRegister.DisabledState.CustomBorderColor = Color.DarkGray
        btnRegister.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRegister.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRegister.FillColor = Color.Transparent
        btnRegister.Font = New Font("Segoe UI", 9.0F)
        btnRegister.ForeColor = Color.Black
        btnRegister.Location = New Point(97, 270)
        btnRegister.Name = "btnRegister"
        btnRegister.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnRegister.Size = New Size(166, 39)
        btnRegister.TabIndex = 12
        btnRegister.Text = "Don't have an Account?"
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.BorderRadius = 15
        btnForgotPassword.CustomizableEdges = CustomizableEdges15
        btnForgotPassword.DisabledState.BorderColor = Color.DarkGray
        btnForgotPassword.DisabledState.CustomBorderColor = Color.DarkGray
        btnForgotPassword.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnForgotPassword.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnForgotPassword.Font = New Font("Segoe UI", 9.0F)
        btnForgotPassword.ForeColor = Color.White
        btnForgotPassword.Location = New Point(194, 230)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnForgotPassword.Size = New Size(131, 34)
        btnForgotPassword.TabIndex = 11
        btnForgotPassword.Text = "Forgot Password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 15
        btnLogin.CustomizableEdges = CustomizableEdges17
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.Font = New Font("Segoe UI", 9.0F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(30, 230)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnLogin.Size = New Size(135, 34)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Sign In"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderRadius = 15
        txtUsername.CustomizableEdges = CustomizableEdges19
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9.0F)
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(30, 46)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        txtUsername.Size = New Size(281, 36)
        txtUsername.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderRadius = 15
        txtPassword.CustomizableEdges = CustomizableEdges21
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9.0F)
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(30, 102)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter Password"
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        txtPassword.Size = New Size(281, 36)
        txtPassword.TabIndex = 9
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.IndianRed
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1264, 681)
        Controls.Add(Guna2CustomGradientPanel1)
        Font = New Font("Segoe UI", 48.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnForgotPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
End Class

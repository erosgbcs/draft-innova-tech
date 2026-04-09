Partial Class FrmRegister
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        cboRole = New ComboBox()
        btnRegister = New Button()
        lblUser = New Label()
        lblPass = New Label()
        lblFull = New Label()
        lblRole = New Label()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        lblFullname = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        Label4 = New Label()
        BtnShowHide = New Button()
        txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        lbl = New Label()
        SuspendLayout()
        ' 
        ' cboRole
        ' 
        cboRole.BackColor = Color.White
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Location = New Point(228, 330)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(272, 23)
        cboRole.TabIndex = 7
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(227, 370)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(273, 24)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblUser
        ' 
        lblUser.Location = New Point(0, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(100, 23)
        lblUser.TabIndex = 0
        ' 
        ' lblPass
        ' 
        lblPass.Location = New Point(0, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(100, 23)
        lblPass.TabIndex = 0
        ' 
        ' lblFull
        ' 
        lblFull.Location = New Point(0, 0)
        lblFull.Name = "lblFull"
        lblFull.Size = New Size(100, 23)
        lblFull.TabIndex = 0
        ' 
        ' lblRole
        ' 
        lblRole.Location = New Point(0, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(100, 23)
        lblRole.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Transparent
        txtUsername.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txtUsername.BorderRadius = 15
        txtUsername.CustomizableEdges = CustomizableEdges1
        txtUsername.DefaultText = ""
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.Location = New Point(227, 114)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter New Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtUsername.Size = New Size(281, 36)
        txtUsername.TabIndex = 10
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Transparent
        txtPassword.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txtPassword.BorderRadius = 15
        txtPassword.CustomizableEdges = CustomizableEdges3
        txtPassword.DefaultText = ""
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.Location = New Point(227, 185)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter New Password"
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPassword.Size = New Size(281, 36)
        txtPassword.TabIndex = 11
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.Transparent
        txtFullName.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txtFullName.BorderRadius = 15
        txtFullName.CustomizableEdges = CustomizableEdges5
        txtFullName.DefaultText = ""
        txtFullName.Font = New Font("Segoe UI", 9F)
        txtFullName.Location = New Point(227, 36)
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "Enter your fullname"
        txtFullName.SelectedText = ""
        txtFullName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtFullName.Size = New Size(281, 36)
        txtFullName.TabIndex = 12
        txtFullName.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.BackColor = Color.Transparent
        lblFullname.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullname.ForeColor = Color.White
        lblFullname.Location = New Point(227, 13)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(89, 20)
        lblFullname.TabIndex = 13
        lblFullname.Text = "Full Name"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(228, 91)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 20)
        lblUsername.TabIndex = 14
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(228, 162)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 20)
        lblPassword.TabIndex = 15
        lblPassword.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(228, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 16
        Label4.Text = "Role"
        ' 
        ' BtnShowHide
        ' 
        BtnShowHide.AccessibleRole = AccessibleRole.MenuBar
        BtnShowHide.BackColor = Color.White
        BtnShowHide.FlatStyle = FlatStyle.Flat
        BtnShowHide.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnShowHide.ForeColor = Color.Black
        BtnShowHide.ImageAlign = ContentAlignment.TopRight
        BtnShowHide.Location = New Point(462, 188)
        BtnShowHide.Name = "BtnShowHide"
        BtnShowHide.Size = New Size(33, 30)
        BtnShowHide.TabIndex = 17
        BtnShowHide.Text = "👁"
        BtnShowHide.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.Transparent
        txtConfirmPassword.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txtConfirmPassword.BorderRadius = 15
        txtConfirmPassword.CustomizableEdges = CustomizableEdges7
        txtConfirmPassword.DefaultText = ""
        txtConfirmPassword.Font = New Font("Segoe UI", 9F)
        txtConfirmPassword.Location = New Point(227, 249)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Confirm Password"
        txtConfirmPassword.SelectedText = ""
        txtConfirmPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtConfirmPassword.Size = New Size(281, 36)
        txtConfirmPassword.TabIndex = 18
        txtConfirmPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl.ForeColor = Color.White
        lbl.Location = New Point(233, 227)
        lbl.Name = "lbl"
        lbl.Size = New Size(153, 20)
        lbl.TabIndex = 19
        lbl.Text = "Confirm Password"
        ' 
        ' FrmRegister
        ' 
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(723, 412)
        Controls.Add(lbl)
        Controls.Add(txtConfirmPassword)
        Controls.Add(BtnShowHide)
        Controls.Add(Label4)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblFullname)
        Controls.Add(txtFullName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(cboRole)
        Controls.Add(btnRegister)
        Name = "FrmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create New Account"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' FIXED DECLARATIONS: Only one of each, and the correct types.
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox ' Only this one remains!
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnShowHide As Button
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl As Label

End Class
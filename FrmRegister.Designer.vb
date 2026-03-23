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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        cboRole = New ComboBox()
        btnRegister = New Button()
        btnCancel = New Button()
        lblUser = New Label()
        lblPass = New Label()
        lblFull = New Label()
        lblRole = New Label()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' cboRole
        ' 
        cboRole.BackColor = Color.White
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Location = New Point(142, 197)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(100, 23)
        cboRole.TabIndex = 7
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(55, 241)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(101, 24)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.LightCoral
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(224, 241)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(99, 24)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
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
        txtUsername.Location = New Point(55, 84)
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
        txtPassword.Location = New Point(55, 140)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
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
        txtFullName.Location = New Point(55, 29)
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "Enter your fullname"
        txtFullName.SelectedText = ""
        txtFullName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtFullName.Size = New Size(281, 36)
        txtFullName.TabIndex = 12
        txtFullName.TextAlign = HorizontalAlignment.Center
        ' 
        ' FrmRegister
        ' 
        BackColor = Color.WhiteSmoke
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(383, 343)
        Controls.Add(txtFullName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(cboRole)
        Controls.Add(btnRegister)
        Controls.Add(btnCancel)
        Name = "FrmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create New Account"
        ResumeLayout(False)

    End Sub

    ' FIXED DECLARATIONS: Only one of each, and the correct types.
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox ' Only this one remains!

End Class
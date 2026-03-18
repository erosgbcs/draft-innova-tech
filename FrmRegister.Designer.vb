Partial Class FrmRegister
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtFullName = New TextBox()
        cboRole = New ComboBox()
        btnRegister = New Button()
        btnCancel = New Button()
        lblUser = New Label()
        lblPass = New Label()
        lblFull = New Label()
        lblRole = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(100, 20)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(100, 50)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 5
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(100, 80)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(100, 23)
        txtFullName.TabIndex = 6
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Location = New Point(86, 110)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(135, 23)
        cboRole.TabIndex = 7
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(40, 150)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(125, 150)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
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
        lblPass.TabIndex = 1
        ' 
        ' lblFull
        ' 
        lblFull.Location = New Point(0, 0)
        lblFull.Name = "lblFull"
        lblFull.Size = New Size(100, 23)
        lblFull.TabIndex = 2
        ' 
        ' lblRole
        ' 
        lblRole.Location = New Point(0, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(100, 23)
        lblRole.TabIndex = 3
        ' 
        ' FrmRegister
        ' 
        ClientSize = New Size(309, 233)
        Controls.Add(lblUser)
        Controls.Add(lblPass)
        Controls.Add(lblFull)
        Controls.Add(lblRole)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtFullName)
        Controls.Add(cboRole)
        Controls.Add(btnRegister)
        Controls.Add(btnCancel)
        Name = "FrmRegister"
        Text = "Create New Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Declarations
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblFull As Label
    Friend WithEvents lblRole As Label
End Class
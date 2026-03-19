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

        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'cboRole
        '
        Me.cboRole.BackColor = System.Drawing.Color.White
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Location = New System.Drawing.Point(142, 197)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(100, 23)
        Me.cboRole.TabIndex = 7
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(128, 128, 255)
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Location = New System.Drawing.Point(55, 241)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(101, 24)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(224, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 24)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192)
        Me.txtUsername.BorderRadius = 15
        Me.txtUsername.CustomizableEdges = CustomizableEdges1
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.Location = New System.Drawing.Point(55, 84)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Enter New Username"
        Me.txtUsername.Size = New System.Drawing.Size(281, 36)
        Me.txtUsername.TabIndex = 10
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192)
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.CustomizableEdges = CustomizableEdges3
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.Location = New System.Drawing.Point(55, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Enter New Password"
        Me.txtPassword.Size = New System.Drawing.Size(281, 36)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFullName
        '
        Me.txtFullName.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192)
        Me.txtFullName.BorderRadius = 15
        Me.txtFullName.CustomizableEdges = CustomizableEdges5
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.Location = New System.Drawing.Point(55, 29)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = "Enter your fullname"
        Me.txtFullName.Size = New System.Drawing.Size(281, 36)
        Me.txtFullName.TabIndex = 12
        Me.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmRegister
        '
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(383, 343)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "FrmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Account"
        Me.ResumeLayout(False)

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
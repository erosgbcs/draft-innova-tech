Partial Class FrmRegister
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        ' Labels
        Dim lblUser As New System.Windows.Forms.Label() With {.Text = "Username:", .Left = 20, .Top = 20}
        Dim lblPass As New System.Windows.Forms.Label() With {.Text = "Password:", .Left = 20, .Top = 50}
        Dim lblFull As New System.Windows.Forms.Label() With {.Text = "Full Name:", .Left = 20, .Top = 80}
        Dim lblRole As New System.Windows.Forms.Label() With {.Text = "Role:", .Left = 20, .Top = 110}

        ' Controls Setup
        Me.txtUsername.Location = New System.Drawing.Point(100, 20)
        Me.txtPassword.Location = New System.Drawing.Point(100, 50)
        Me.txtPassword.PasswordChar = "*"c ' Mask password

        Me.txtFullName.Location = New System.Drawing.Point(100, 80)

        Me.cboRole.Location = New System.Drawing.Point(100, 110)
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.btnRegister.Text = "Register"
        Me.btnRegister.Location = New System.Drawing.Point(40, 150)

        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Location = New System.Drawing.Point(125, 150)

        ' Form Settings
        Me.ClientSize = New System.Drawing.Size(250, 200)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {
            lblUser, lblPass, lblFull, lblRole,
            txtUsername, txtPassword, txtFullName, cboRole,
            btnRegister, btnCancel
        })
        Me.Text = "Create New Account"
    End Sub

    ' Declarations
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
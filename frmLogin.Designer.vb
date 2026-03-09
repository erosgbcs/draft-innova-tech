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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        btnForgotPassword = New Button()
        IbIUsername = New Label()
        IbIPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnShowHide = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.AccessibleRole = AccessibleRole.Application
        btnForgotPassword.Anchor = AnchorStyles.None
        btnForgotPassword.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnForgotPassword.FlatStyle = FlatStyle.Flat
        btnForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.White
        btnForgotPassword.Location = New Point(420, 620)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(118, 31)
        btnForgotPassword.TabIndex = 6
        btnForgotPassword.Text = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' IbIUsername
        ' 
        IbIUsername.Anchor = AnchorStyles.None
        IbIUsername.AutoSize = True
        IbIUsername.BackColor = Color.Transparent
        IbIUsername.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIUsername.ForeColor = Color.White
        IbIUsername.Location = New Point(120, 518)
        IbIUsername.Name = "IbIUsername"
        IbIUsername.Size = New Size(106, 28)
        IbIUsername.TabIndex = 0
        IbIUsername.Text = "Username"
        ' 
        ' IbIPassword
        ' 
        IbIPassword.Anchor = AnchorStyles.None
        IbIPassword.AutoSize = True
        IbIPassword.BackColor = Color.Transparent
        IbIPassword.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIPassword.ForeColor = Color.White
        IbIPassword.Location = New Point(120, 560)
        IbIPassword.Name = "IbIPassword"
        IbIPassword.Size = New Size(101, 28)
        IbIPassword.TabIndex = 1
        IbIPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = SystemColors.GradientInactiveCaption
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(242, 513)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(296, 33)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = SystemColors.GradientInactiveCaption
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(242, 557)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(296, 33)
        txtPassword.TabIndex = 4
        ' 
        ' btnShowHide
        ' 
        btnShowHide.AccessibleRole = AccessibleRole.MenuBar
        btnShowHide.Anchor = AnchorStyles.None
        btnShowHide.BackColor = SystemColors.GradientInactiveCaption
        btnShowHide.FlatStyle = FlatStyle.Flat
        btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowHide.ForeColor = Color.Gray
        btnShowHide.Location = New Point(471, 560)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(41, 26)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(225, 620)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' FrmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(868, 693)
        Controls.Add(btnShowHide)
        Controls.Add(btnForgotPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(IbIPassword)
        Controls.Add(IbIUsername)
        Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Logic definitions for the Designer
    Friend WithEvents IbIUsername As Label
    Friend WithEvents IbIPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnForgotPassword As Button

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class

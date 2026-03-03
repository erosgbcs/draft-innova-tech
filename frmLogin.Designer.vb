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
        btnForgotPassword = New Button()
        IbIUsername = New Label()
        IbIPassword = New Label()
        label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnShowHide = New Button()
        Label2 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.AccessibleRole = AccessibleRole.Application
        btnForgotPassword.Anchor = AnchorStyles.None
        btnForgotPassword.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnForgotPassword.FlatStyle = FlatStyle.Flat
        btnForgotPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.White
        btnForgotPassword.Location = New Point(304, 252)
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
        IbIUsername.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIUsername.ForeColor = Color.White
        IbIUsername.Location = New Point(22, 151)
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
        IbIPassword.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIPassword.ForeColor = Color.White
        IbIPassword.Location = New Point(22, 206)
        IbIPassword.Name = "IbIPassword"
        IbIPassword.Size = New Size(101, 28)
        IbIPassword.TabIndex = 1
        IbIPassword.Text = "Password"
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.None
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.White
        label1.Location = New Point(22, 30)
        label1.Name = "label1"
        label1.Size = New Size(473, 37)
        label1.TabIndex = 2
        label1.Text = " Point of Sale and Inventory System"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.BackColor = SystemColors.GradientInactiveCaption
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(139, 152)
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
        txtPassword.Location = New Point(139, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(296, 33)
        txtPassword.TabIndex = 4
        ' 
        ' btnShowHide
        ' 
        btnShowHide.AccessibleRole = AccessibleRole.MenuBar
        btnShowHide.BackColor = SystemColors.GradientInactiveCaption
        btnShowHide.FlatStyle = FlatStyle.Flat
        btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowHide.ForeColor = Color.Gray
        btnShowHide.Location = New Point(381, 202)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(41, 26)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(109, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 37)
        Label2.TabIndex = 8
        Label2.Text = "for Hardware Trading"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(151, 252)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.DodgerBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(532, 307)
        Controls.Add(Label2)
        Controls.Add(btnShowHide)
        Controls.Add(btnForgotPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(label1)
        Controls.Add(IbIPassword)
        Controls.Add(IbIUsername)
        Font = New Font("Segoe UI", 48.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Logic definitions for the Designer
    Friend WithEvents IbIUsername As Label
    Friend WithEvents IbIPassword As Label
    Friend WithEvents label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnForgotPassword As Button

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

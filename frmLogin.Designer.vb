<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim btnForgotPassword As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        IbIUsername = New Label()
        IbIPassword = New Label()
        label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnShowHide = New Button()
        Label2 = New Label()
        btnLogin = New Button()
        btnForgotPassword = New Button()
        SuspendLayout()
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.AccessibleRole = AccessibleRole.Application
        btnForgotPassword.BackColor = Color.Red
        btnForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.Transparent
        btnForgotPassword.Location = New Point(304, 252)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(118, 31)
        btnForgotPassword.TabIndex = 6
        btnForgotPassword.Text = "Forgot Password"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' IbIUsername
        ' 
        IbIUsername.AutoSize = True
        IbIUsername.BackColor = Color.Lavender
        IbIUsername.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIUsername.ForeColor = SystemColors.MenuText
        IbIUsername.Location = New Point(22, 151)
        IbIUsername.Name = "IbIUsername"
        IbIUsername.Size = New Size(106, 28)
        IbIUsername.TabIndex = 0
        IbIUsername.Text = "Username"
        ' 
        ' IbIPassword
        ' 
        IbIPassword.AutoSize = True
        IbIPassword.BackColor = Color.Lavender
        IbIPassword.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIPassword.Location = New Point(22, 206)
        IbIPassword.Name = "IbIPassword"
        IbIPassword.Size = New Size(101, 28)
        IbIPassword.TabIndex = 1
        IbIPassword.Text = "Password"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.SkyBlue
        label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(22, 9)
        label1.Name = "label1"
        label1.Size = New Size(473, 37)
        label1.TabIndex = 2
        label1.Text = " Point of Sale and Inventory System"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.Info
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(139, 152)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(296, 33)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.Info
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
        btnShowHide.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowHide.ForeColor = Color.Gray
        btnShowHide.Location = New Point(394, 206)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(41, 26)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SkyBlue
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(99, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 37)
        Label2.TabIndex = 8
        Label2.Text = "for Hardware Trading"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(151, 252)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
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
        Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IbIUsername As Label
    Friend WithEvents IbIPassword As Label
    Friend WithEvents label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnLogin As Button
End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim btnForgotPassword As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        IbIUsername = New Label()
        IbIPassword = New Label()
        label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnShowHide = New Button()
        Label2 = New Label()
        btnLogin = New Button()
        btnForgotPassword = New Button()
        SuspendLayout()
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.AccessibleRole = AccessibleRole.Application
        btnForgotPassword.BackColor = Color.Red
        btnForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForgotPassword.ForeColor = Color.Transparent
        btnForgotPassword.Location = New Point(304, 252)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(118, 31)
        btnForgotPassword.TabIndex = 6
        btnForgotPassword.Text = "Forgot Password"
        btnForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' IbIUsername
        ' 
        IbIUsername.AutoSize = True
        IbIUsername.BackColor = Color.Lavender
        IbIUsername.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIUsername.ForeColor = SystemColors.MenuText
        IbIUsername.Location = New Point(22, 151)
        IbIUsername.Name = "IbIUsername"
        IbIUsername.Size = New Size(106, 28)
        IbIUsername.TabIndex = 0
        IbIUsername.Text = "Username"
        ' 
        ' IbIPassword
        ' 
        IbIPassword.AutoSize = True
        IbIPassword.BackColor = Color.Lavender
        IbIPassword.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IbIPassword.Location = New Point(22, 206)
        IbIPassword.Name = "IbIPassword"
        IbIPassword.Size = New Size(101, 28)
        IbIPassword.TabIndex = 1
        IbIPassword.Text = "Password"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.SkyBlue
        label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(22, 9)
        label1.Name = "label1"
        label1.Size = New Size(473, 37)
        label1.TabIndex = 2
        label1.Text = " Point of Sale and Inventory System"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.Info
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(139, 146)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(296, 33)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.Info
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(139, 203)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(296, 33)
        txtPassword.TabIndex = 4
        ' 
        ' btnShowHide
        ' 
        btnShowHide.AccessibleRole = AccessibleRole.MenuBar
        btnShowHide.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowHide.ForeColor = Color.Gray
        btnShowHide.Location = New Point(394, 206)
        btnShowHide.Name = "btnShowHide"
        btnShowHide.Size = New Size(41, 26)
        btnShowHide.TabIndex = 7
        btnShowHide.Text = "👁"
        btnShowHide.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SkyBlue
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(99, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 37)
        Label2.TabIndex = 8
        Label2.Text = "for Hardware Trading"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(151, 252)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
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
        Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IbIUsername As Label
    Friend WithEvents IbIPassword As Label
    Friend WithEvents label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnLogin As Button
End Class
>>>>>>> 1a3ada36988c1c8db55bf1fafe979419d955ea4e

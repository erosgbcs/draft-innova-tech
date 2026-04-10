Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Public Class FrmLogin
    Private dbHelper As DatabaseHelper

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c

        ' Initialize database
        dbHelper = New DatabaseHelper()
        dbHelper.InitializeDatabase()

        ' Optional: Add debug info to show database location
        ' lblDbPath.Text = "DB: " & IO.Path.Combine(Application.StartupPath, "POSSystem.db")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim
        Dim password = txtPassword.Text

        Dim userData = dbHelper.ValidateUser(username, password)

        If userData.Rows.Count > 0 Then
            ' --- LOGIN SUCCESSFUL ---
            Dim userRow = userData.Rows(0)
            GlobalData.CurrentUser = userRow("Username").ToString()
            GlobalData.UserRole = userRow("Role").ToString()

            ' TRIGGER AUTO-BACKUP HERE
            ' Using Task.Run ensures the login doesn't "freeze" while copying the file
            Task.Run(Sub() dbHelper.AutoBackup())

            MessageBox.Show($"Login Successful! Welcome {userRow("FullName")}!",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim mainApp As New frmMain()
            mainApp.Show()
            Me.Hide()
        Else
            ' Login failed logic...
            MessageBox.Show("Invalid username or password", "Login Failed",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUsername.Focus()
        End If

        ' Re-enable button
        btnLogin.Enabled = True
        btnLogin.Text = "Login"
    End Sub

    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ' Show forgot password dialog
        Using forgotForm As New FrmForgotPassword(dbHelper)
            forgotForm.ShowDialog()
        End Using
    End Sub

    ' New Register button click event
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Show registration form
        Using registerForm As New FrmRegister(dbHelper)
            If registerForm.ShowDialog() = DialogResult.OK Then
                txtUsername.Text = registerForm.RegisteredUsername
                MessageBox.Show("Registration successful! Please login with your new account.",
                              "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Focus()
            End If
        End Using
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Handle Enter key to trigger login
    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnLogin_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub IbIPassword_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmLogin
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
            Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
            IbIUsername = New Label()
            txtPassword = New TextBox()
            IbIPassword = New Label()
            txtUsername = New TextBox()
            btnShowHide = New Button()
            btnForgotPassword = New Button()
            btnLogin = New Button()
            btnRegister = New Button() ' New register button
            Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
            Guna2CustomGradientPanel1.SuspendLayout()
            SuspendLayout()
            ' 
            ' IbIUsername
            ' 
            IbIUsername.Anchor = AnchorStyles.None
            IbIUsername.AutoSize = True
            IbIUsername.BackColor = Color.Transparent
            IbIUsername.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            IbIUsername.ForeColor = Color.White
            IbIUsername.Location = New Point(7, 85)
            IbIUsername.Name = "IbIUsername"
            IbIUsername.Size = New Size(106, 28)
            IbIUsername.TabIndex = 0
            IbIUsername.Text = "Username"
            ' 
            ' txtPassword
            ' 
            txtPassword.Anchor = AnchorStyles.None
            txtPassword.BackColor = SystemColors.GradientInactiveCaption
            txtPassword.BorderStyle = BorderStyle.FixedSingle
            txtPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txtPassword.Location = New Point(119, 143)
            txtPassword.Name = "txtPassword"
            txtPassword.PasswordChar = "*"c
            txtPassword.Size = New Size(207, 33)
            txtPassword.TabIndex = 4
            ' 
            ' IbIPassword
            ' 
            IbIPassword.Anchor = AnchorStyles.None
            IbIPassword.AutoSize = True
            IbIPassword.BackColor = Color.Transparent
            IbIPassword.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            IbIPassword.ForeColor = Color.White
            IbIPassword.Location = New Point(7, 148)
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
            txtUsername.Location = New Point(119, 80)
            txtUsername.Name = "txtUsername"
            txtUsername.Size = New Size(207, 33)
            txtUsername.TabIndex = 3
            ' 
            ' btnShowHide
            ' 
            btnShowHide.AccessibleRole = AccessibleRole.MenuBar
            btnShowHide.Anchor = AnchorStyles.None
            btnShowHide.BackColor = SystemColors.GradientInactiveCaption
            btnShowHide.FlatStyle = FlatStyle.Flat
            btnShowHide.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnShowHide.ForeColor = Color.Black
            btnShowHide.Location = New Point(282, 80)
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
            btnForgotPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnForgotPassword.ForeColor = Color.White
            btnForgotPassword.Location = New Point(30, 258) ' Moved down to make room for register button
            btnForgotPassword.Name = "btnForgotPassword"
            btnForgotPassword.Size = New Size(126, 31)
            btnForgotPassword.TabIndex = 6
            btnForgotPassword.Text = "Forgot Password?"
            btnForgotPassword.UseVisualStyleBackColor = False
            ' 
            ' btnLogin
            ' 
            btnLogin.Anchor = AnchorStyles.None
            btnLogin.BackColor = Color.Green
            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnLogin.ForeColor = Color.White
            btnLogin.Location = New Point(30, 204)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Size(126, 38)
            btnLogin.TabIndex = 5
            btnLogin.Text = "Login"
            btnLogin.UseVisualStyleBackColor = False
            ' 
            ' btnRegister
            ' 
            btnRegister.Anchor = AnchorStyles.None
            btnRegister.BackColor = Color.FromArgb(0, 102, 204) ' Blue color
            btnRegister.FlatStyle = FlatStyle.Flat
            btnRegister.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnRegister.ForeColor = Color.White
            btnRegister.Location = New Point(200, 204)
            btnRegister.Name = "btnRegister"
            btnRegister.Size = New Size(126, 38)
            btnRegister.TabIndex = 8
            btnRegister.Text = "Register"
            btnRegister.UseVisualStyleBackColor = False
            ' 
            ' Guna2CustomGradientPanel1
            ' 
            Guna2CustomGradientPanel1.BackColor = Color.Transparent
            Guna2CustomGradientPanel1.BorderColor = Color.Black
            Guna2CustomGradientPanel1.BorderRadius = 18
            Guna2CustomGradientPanel1.Controls.Add(btnRegister) ' Add register button
            Guna2CustomGradientPanel1.Controls.Add(txtPassword)
            Guna2CustomGradientPanel1.Controls.Add(btnShowHide)
            Guna2CustomGradientPanel1.Controls.Add(txtUsername)
            Guna2CustomGradientPanel1.Controls.Add(btnLogin)
            Guna2CustomGradientPanel1.Controls.Add(IbIUsername)
            Guna2CustomGradientPanel1.Controls.Add(btnForgotPassword)
            Guna2CustomGradientPanel1.Controls.Add(IbIPassword)
            Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges1
            Guna2CustomGradientPanel1.FillColor = Color.DarkBlue
            Guna2CustomGradientPanel1.FillColor2 = Color.DarkBlue
            Guna2CustomGradientPanel1.Location = New Point(409, 232)
            Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
            Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
            Guna2CustomGradientPanel1.Size = New Size(349, 391)
            Guna2CustomGradientPanel1.TabIndex = 8
            ' 
            ' FrmLogin
            ' 
            AcceptButton = btnLogin
            AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            AutoScaleMode = AutoScaleMode.Dpi
            AutoSize = True
            BackColor = Color.Gray
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
            Guna2CustomGradientPanel1.PerformLayout()
            ResumeLayout(False)
        End Sub

        Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs)

        End Sub

        Friend WithEvents IbIUsername As Label
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents IbIPassword As Label
        Friend WithEvents txtUsername As TextBox
        Friend WithEvents btnShowHide As Button
        Friend WithEvents btnForgotPassword As Button
        Friend WithEvents btnLogin As Button
        Friend WithEvents btnRegister As Button ' New register button
        Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
        ' Add this inside your FrmLogin class
        Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' This ensures that when the form (or the app) is closed, 
            ' the background process is killed immediately.
            Application.Exit()
        End Sub
    End Class

    Private Sub BtnShowHide_Click(sender As Object, e As EventArgs) Handles BtnShowHide.Click
        ' Check if the password is currently hidden (using '*' as the mask)
        If txtPassword.PasswordChar = "*"c Then
            ' If it's currently hidden, show the text
            txtPassword.PasswordChar = Convert.ToChar(0)
            BtnShowHide.Text = "🔒"

            ' 2. The alternative case
        Else
            ' If it's already visible, hide it again
            txtPassword.PasswordChar = "*"c
            BtnShowHide.Text = "👁"

            ' 3. The Required Closing Statement
        End If
    End Sub

    Private Sub BtnShowHide_Click_1(sender As Object, e As EventArgs) Handles BtnShowHide.Click

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TextBox1 = New TextBox()
        flpProduct1 = New FlowLayoutPanel()
        flpCart = New FlowLayoutPanel()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label2 = New Label()
        Label24 = New Label()
        lblTitle = New Label()
        lblTime = New Label()
        Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CustomGradientPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(7, 117)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(1143, 23)
        TextBox1.TabIndex = 4
        ' 
        ' flpProduct1
        ' 
        flpProduct1.BackColor = Color.White
        flpProduct1.BorderStyle = BorderStyle.FixedSingle
        flpProduct1.Location = New Point(11, 155)
        flpProduct1.Margin = New Padding(4, 3, 4, 3)
        flpProduct1.Name = "flpProduct1"
        flpProduct1.Size = New Size(825, 529)
        flpProduct1.TabIndex = 7
        ' 
        ' flpCart
        ' 
        flpCart.AutoScroll = True
        flpCart.BackColor = Color.White
        flpCart.BorderStyle = BorderStyle.FixedSingle
        flpCart.Cursor = Cursors.Hand
        flpCart.Location = New Point(853, 155)
        flpCart.Margin = New Padding(4, 3, 4, 3)
        flpCart.Name = "flpCart"
        flpCart.Size = New Size(297, 529)
        flpCart.TabIndex = 8
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label2)
        Guna2CustomGradientPanel3.Controls.Add(Label24)
        Guna2CustomGradientPanel3.Controls.Add(lblTitle)
        Guna2CustomGradientPanel3.Controls.Add(lblTime)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button7)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel3.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel3.FillColor2 = Color.DarkTurquoise
        Guna2CustomGradientPanel3.FillColor3 = Color.Navy
        Guna2CustomGradientPanel3.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel3.Location = New Point(2, 9)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel3.Size = New Size(1148, 102)
        Guna2CustomGradientPanel3.TabIndex = 58
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(472, 25)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(531, 30)
        Label24.Name = "Label24"
        Label24.Size = New Size(235, 47)
        Label24.TabIndex = 9
        Label24.Text = "Point Of Sale"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(5, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(430, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Kirby's Hardware Trading"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(597, 72)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(97, 30)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Guna2Button7
        ' 
        Guna2Button7.BorderColor = Color.White
        Guna2Button7.BorderRadius = 12
        Guna2Button7.BorderThickness = 1
        Guna2Button7.CustomizableEdges = CustomizableEdges1
        Guna2Button7.DisabledState.BorderColor = Color.DarkGray
        Guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button7.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button7.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button7.FillColor = Color.Blue
        Guna2Button7.Font = New Font("Segoe UI", 9F)
        Guna2Button7.ForeColor = Color.WhiteSmoke
        Guna2Button7.Location = New Point(10, 610)
        Guna2Button7.Name = "Guna2Button7"
        Guna2Button7.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button7.Size = New Size(128, 34)
        Guna2Button7.TabIndex = 26
        Guna2Button7.Text = "Logout"
        ' 
        ' pos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(939, 562)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(flpCart)
        Controls.Add(flpProduct1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "pos"
        Text = "Products"
        WindowState = FormWindowState.Maximized
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents flpProduct1 As FlowLayoutPanel
    Friend WithEvents flpCart As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdashboard
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label24 = New Label()
        Timer1 = New Timer(components)
        flptotalproducts = New FlowLayoutPanel()
        flpitemsinstock = New FlowLayoutPanel()
        flptodaysales = New FlowLayoutPanel()
        flpweeklyrevenue = New FlowLayoutPanel()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        lblTime = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        flpinventoryinsights = New FlowLayoutPanel()
        Guna2CustomGradientPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(591, 9)
        Label24.Name = "Label24"
        Label24.Size = New Size(211, 50)
        Label24.TabIndex = 9
        Label24.Text = "Dashboard"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' flptotalproducts
        ' 
        flptotalproducts.BackColor = Color.Transparent
        flptotalproducts.Location = New Point(9, 129)
        flptotalproducts.Name = "flptotalproducts"
        flptotalproducts.Size = New Size(273, 160)
        flptotalproducts.TabIndex = 46
        ' 
        ' flpitemsinstock
        ' 
        flpitemsinstock.BackColor = Color.Transparent
        flpitemsinstock.Location = New Point(339, 129)
        flpitemsinstock.Name = "flpitemsinstock"
        flpitemsinstock.Size = New Size(273, 160)
        flpitemsinstock.TabIndex = 47
        ' 
        ' flptodaysales
        ' 
        flptodaysales.BackColor = Color.Transparent
        flptodaysales.Location = New Point(661, 129)
        flptodaysales.Name = "flptodaysales"
        flptodaysales.Size = New Size(273, 160)
        flptodaysales.TabIndex = 48
        ' 
        ' flpweeklyrevenue
        ' 
        flpweeklyrevenue.BackColor = Color.Transparent
        flpweeklyrevenue.Location = New Point(988, 129)
        flpweeklyrevenue.Name = "flpweeklyrevenue"
        flpweeklyrevenue.Size = New Size(273, 160)
        flpweeklyrevenue.TabIndex = 47
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Black
        Guna2CustomGradientPanel3.BorderRadius = 20
        Guna2CustomGradientPanel3.BorderThickness = 1
        Guna2CustomGradientPanel3.Controls.Add(Label2)
        Guna2CustomGradientPanel3.Controls.Add(Label1)
        Guna2CustomGradientPanel3.Controls.Add(Label24)
        Guna2CustomGradientPanel3.Controls.Add(Label4)
        Guna2CustomGradientPanel3.Controls.Add(lblTime)
        Guna2CustomGradientPanel3.Controls.Add(Guna2Button1)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel3.FillColor = Color.DarkMagenta
        Guna2CustomGradientPanel3.FillColor2 = Color.DarkTurquoise
        Guna2CustomGradientPanel3.FillColor3 = Color.Navy
        Guna2CustomGradientPanel3.FillColor4 = Color.SkyBlue
        Guna2CustomGradientPanel3.Location = New Point(7, 4)
        Guna2CustomGradientPanel3.Margin = New Padding(2, 3, 2, 3)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel3.Size = New Size(1299, 109)
        Guna2CustomGradientPanel3.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(430, 8)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 51)
        Label2.TabIndex = 27
        Label2.Text = "Trading"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(27, 73)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 25)
        Label1.TabIndex = 1
        Label1.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(5, 0)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(446, 58)
        Label4.TabIndex = 0
        Label4.Text = "Kirby's Hardware Trading"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(1018, 73)
        lblTime.Margin = New Padding(2, 0, 2, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(97, 30)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.White
        Guna2Button1.BorderRadius = 12
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Blue
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.WhiteSmoke
        Guna2Button1.Location = New Point(9, 650)
        Guna2Button1.Margin = New Padding(2, 3, 2, 3)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(117, 36)
        Guna2Button1.TabIndex = 26
        Guna2Button1.Text = "Logout"
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.AutoScroll = True
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderRadius = 37
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2CustomGradientPanel1.Location = New Point(12, 321)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomGradientPanel1.Size = New Size(1294, 392)
        Guna2CustomGradientPanel1.TabIndex = 61
        ' 
        ' flpinventoryinsights
        ' 
        flpinventoryinsights.BackColor = Color.Transparent
        flpinventoryinsights.Location = New Point(12, 719)
        flpinventoryinsights.Name = "flpinventoryinsights"
        flpinventoryinsights.Size = New Size(273, 160)
        flpinventoryinsights.TabIndex = 62
        ' 
        ' frmdashboard
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoSize = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(971, 599)
        Controls.Add(flpinventoryinsights)
        Controls.Add(Guna2CustomGradientPanel1)
        Controls.Add(Guna2CustomGradientPanel3)
        Controls.Add(flpweeklyrevenue)
        Controls.Add(flptodaysales)
        Controls.Add(flpitemsinstock)
        Controls.Add(flptotalproducts)
        KeyPreview = True
        Name = "frmdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "S"
        WindowState = FormWindowState.Maximized
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label24 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents flptotalproducts As FlowLayoutPanel
    Friend WithEvents flpitemsinstock As FlowLayoutPanel
    Friend WithEvents flptodaysales As FlowLayoutPanel
    Friend WithEvents flpweeklyrevenue As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flpinventoryinsights As FlowLayoutPanel

End Class

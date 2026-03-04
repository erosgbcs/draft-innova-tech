<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Panel1 = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        txtSearch = New TextBox()
        Panel6 = New Panel()
        PanelMain = New Panel()
        picReport = New PictureBox()
        btnReport = New Button()
        Panel9 = New Panel()
        Button12 = New Button()
        Panel8 = New Panel()
        Button11 = New Button()
        Panel7 = New Panel()
        Button13 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        Button6 = New Button()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Button10 = New Button()
        btnSearch = New Button()
        PanelMenu = New Panel()
        PictureBox3 = New PictureBox()
        Button18 = New Button()
        Button17 = New Button()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        PanelMain.SuspendLayout()
        CType(picReport, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AccessibleName = ""
        Panel1.BackColor = Color.MidnightBlue
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(144, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(836, 84)
        Panel1.TabIndex = 0
        Panel1.Tag = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(849, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(0, 103)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(153, 706)
        Panel3.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(22, 44)
        Button4.Name = "Button4"
        Button4.Size = New Size(89, 35)
        Button4.TabIndex = 3
        Button4.Text = "Categories"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(22, 143)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 31)
        Button3.TabIndex = 2
        Button3.Text = "Orders"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(22, 108)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 29)
        Button2.TabIndex = 1
        Button2.Text = "Products"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(0, 109)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(137, 703)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(36, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 47)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' txtSearch
        ' 
        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(247, 93)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = ChrW(8220) & "Enter item name or code" & ChrW(8221)
        txtSearch.Size = New Size(540, 25)
        txtSearch.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(PanelMain)
        Panel6.Location = New Point(144, 124)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(836, 485)
        Panel6.TabIndex = 5
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.LightGray
        PanelMain.Controls.Add(picReport)
        PanelMain.Controls.Add(btnReport)
        PanelMain.Controls.Add(Panel9)
        PanelMain.Controls.Add(Panel8)
        PanelMain.Controls.Add(Panel7)
        PanelMain.Controls.Add(Panel5)
        PanelMain.Controls.Add(Panel4)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(836, 485)
        PanelMain.TabIndex = 0
        ' 
        ' picReport
        ' 
        picReport.Cursor = Cursors.Hand
        picReport.Image = CType(resources.GetObject("picReport.Image"), Image)
        picReport.Location = New Point(602, 262)
        picReport.Name = "picReport"
        picReport.Size = New Size(231, 200)
        picReport.SizeMode = PictureBoxSizeMode.Zoom
        picReport.TabIndex = 6
        picReport.TabStop = False
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.SteelBlue
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReport.ForeColor = Color.White
        btnReport.Location = New Point(645, 194)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(144, 50)
        btnReport.TabIndex = 5
        btnReport.Text = "📈 Cash Report"
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.SkyBlue
        Panel9.Controls.Add(Button12)
        Panel9.Location = New Point(595, 26)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(198, 115)
        Panel9.TabIndex = 4
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(50, 37)
        Button12.Name = "Button12"
        Button12.Size = New Size(79, 30)
        Button12.TabIndex = 0
        Button12.Text = "Button12"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.SkyBlue
        Panel8.Controls.Add(Button11)
        Panel8.Location = New Point(404, 26)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(185, 114)
        Panel8.TabIndex = 3
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(106, 64)
        Button11.Name = "Button11"
        Button11.Size = New Size(76, 27)
        Button11.TabIndex = 0
        Button11.Text = "Button11"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Beige
        Panel7.Controls.Add(Button13)
        Panel7.Controls.Add(TextBox1)
        Panel7.Controls.Add(Label2)
        Panel7.Location = New Point(22, 162)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(567, 312)
        Panel7.TabIndex = 2
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(519, 11)
        Button13.Name = "Button13"
        Button13.Size = New Size(26, 24)
        Button13.TabIndex = 2
        Button13.Text = "🔍"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(137, 11)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = """Enter a orders"""
        TextBox1.Size = New Size(376, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 21)
        Label2.TabIndex = 0
        Label2.Text = "Recent Orders"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.SkyBlue
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(Button6)
        Panel5.Location = New Point(213, 26)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(185, 114)
        Panel5.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(88, 80)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(97, 70)
        Button6.Name = "Button6"
        Button6.Size = New Size(85, 23)
        Button6.TabIndex = 0
        Button6.Text = "Total Sales"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SkyBlue
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Button5)
        Panel4.Location = New Point(22, 26)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(185, 114)
        Panel4.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(110, 70)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 0
        Button5.Text = "Orders"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(190, 93)
        Button10.Name = "Button10"
        Button10.Size = New Size(51, 23)
        Button10.TabIndex = 6
        Button10.Text = "Menu"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DodgerBlue
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(793, 95)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.LightSteelBlue
        PanelMenu.Controls.Add(PictureBox3)
        PanelMenu.Controls.Add(Button18)
        PanelMenu.Controls.Add(Button17)
        PanelMenu.Controls.Add(Button16)
        PanelMenu.Controls.Add(Button15)
        PanelMenu.Controls.Add(Button14)
        PanelMenu.Controls.Add(Button9)
        PanelMenu.Controls.Add(Button8)
        PanelMenu.Controls.Add(Button7)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(147, 610)
        PanelMenu.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(21, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(91, 64)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = SystemColors.Info
        Button18.Location = New Point(12, 556)
        Button18.Name = "Button18"
        Button18.Size = New Size(117, 30)
        Button18.TabIndex = 7
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Button17
        ' 
        Button17.BackColor = SystemColors.Info
        Button17.Location = New Point(12, 176)
        Button17.Name = "Button17"
        Button17.Size = New Size(117, 31)
        Button17.TabIndex = 6
        Button17.Text = "Orders"
        Button17.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = SystemColors.ButtonShadow
        Button16.ForeColor = Color.White
        Button16.Location = New Point(21, 64)
        Button16.Name = "Button16"
        Button16.Size = New Size(91, 32)
        Button16.TabIndex = 5
        Button16.Text = "Admin"
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = SystemColors.Info
        Button15.Location = New Point(12, 507)
        Button15.Name = "Button15"
        Button15.Size = New Size(117, 31)
        Button15.TabIndex = 4
        Button15.Text = "Settings"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = SystemColors.Info
        Button14.Location = New Point(12, 226)
        Button14.Name = "Button14"
        Button14.Size = New Size(117, 27)
        Button14.TabIndex = 3
        Button14.Text = "Sales Report"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = SystemColors.Info
        Button9.Location = New Point(12, 277)
        Button9.Name = "Button9"
        Button9.Size = New Size(117, 30)
        Button9.TabIndex = 2
        Button9.Text = "Point of Sales"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.Info
        Button8.Location = New Point(12, 329)
        Button8.Name = "Button8"
        Button8.Size = New Size(117, 31)
        Button8.TabIndex = 1
        Button8.Text = "Inventory"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.Info
        Button7.Location = New Point(12, 124)
        Button7.Name = "Button7"
        Button7.Size = New Size(117, 30)
        Button7.TabIndex = 0
        Button7.Text = "Products"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(978, 610)
        Controls.Add(PanelMenu)
        Controls.Add(btnSearch)
        Controls.Add(Button10)
        Controls.Add(Panel6)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "(Blank or Cashier Dashboard)"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        CType(picReport, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents picReport As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

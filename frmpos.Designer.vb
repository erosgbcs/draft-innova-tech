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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos))
        TextBox1 = New TextBox()
        flpProduct1 = New FlowLayoutPanel()
        flpCart = New FlowLayoutPanel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        btnOpenPOS = New Guna.UI2.WinForms.Guna2Button()
        btnSALESHISTORY = New Guna.UI2.WinForms.Guna2Button()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        pnlHeader = New Panel()
        lblTime = New Label()
        Label24 = New Label()
        Label2 = New Label()
        lblTitle = New Label()
        Guna2Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(153, 125)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(873, 23)
        TextBox1.TabIndex = 4
        ' 
        ' flpProduct1
        ' 
        flpProduct1.BackColor = Color.White
        flpProduct1.BorderStyle = BorderStyle.FixedSingle
        flpProduct1.Location = New Point(153, 168)
        flpProduct1.Margin = New Padding(4, 3, 4, 3)
        flpProduct1.Name = "flpProduct1"
        flpProduct1.Size = New Size(733, 530)
        flpProduct1.TabIndex = 7
        ' 
        ' flpCart
        ' 
        flpCart.AutoScroll = True
        flpCart.BackColor = Color.White
        flpCart.BorderStyle = BorderStyle.FixedSingle
        flpCart.Cursor = Cursors.Hand
        flpCart.Location = New Point(894, 168)
        flpCart.Margin = New Padding(4, 3, 4, 3)
        flpCart.Name = "flpCart"
        flpCart.Size = New Size(465, 530)
        flpCart.TabIndex = 8
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(Guna2Button3)
        Guna2Panel1.Controls.Add(Guna2Button2)
        Guna2Panel1.Controls.Add(Guna2Button1)
        Guna2Panel1.Controls.Add(btnOpenInventory)
        Guna2Panel1.Controls.Add(btnOpenPOS)
        Guna2Panel1.Controls.Add(btnSALESHISTORY)
        Guna2Panel1.Controls.Add(btnUploadPictures)
        Guna2Panel1.Controls.Add(PictureBox3)
        Guna2Panel1.CustomBorderColor = Color.Transparent
        Guna2Panel1.CustomizableEdges = CustomizableEdges13
        Guna2Panel1.FillColor = Color.DarkBlue
        Guna2Panel1.Location = New Point(4, -1)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Panel1.Size = New Size(142, 699)
        Guna2Panel1.TabIndex = 44
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.White
        Guna2Button3.BorderRadius = 12
        Guna2Button3.BorderThickness = 1
        Guna2Button3.CustomizableEdges = CustomizableEdges1
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Blue
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.WhiteSmoke
        Guna2Button3.Location = New Point(8, 600)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(128, 34)
        Guna2Button3.TabIndex = 26
        Guna2Button3.Text = "Logout"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.White
        Guna2Button2.BorderRadius = 12
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Blue
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.WhiteSmoke
        Guna2Button2.Location = New Point(6, 526)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(128, 34)
        Guna2Button2.TabIndex = 25
        Guna2Button2.Text = "Users 👥"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.White
        Guna2Button1.BorderRadius = 12
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Blue
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.WhiteSmoke
        Guna2Button1.Location = New Point(6, 220)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(128, 34)
        Guna2Button1.TabIndex = 24
        Guna2Button1.Text = "Dasboard"
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.BorderColor = Color.White
        btnOpenInventory.BorderRadius = 12
        btnOpenInventory.BorderThickness = 1
        btnOpenInventory.CustomizableEdges = CustomizableEdges7
        btnOpenInventory.DisabledState.BorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenInventory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenInventory.FillColor = Color.Blue
        btnOpenInventory.Font = New Font("Segoe UI", 9F)
        btnOpenInventory.ForeColor = Color.White
        btnOpenInventory.Location = New Point(6, 374)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnOpenInventory.Size = New Size(128, 34)
        btnOpenInventory.TabIndex = 23
        btnOpenInventory.Text = "Inventory  📦"
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.BorderColor = Color.White
        btnOpenPOS.BorderRadius = 12
        btnOpenPOS.BorderThickness = 1
        btnOpenPOS.CustomizableEdges = CustomizableEdges9
        btnOpenPOS.DisabledState.BorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenPOS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenPOS.FillColor = Color.Blue
        btnOpenPOS.Font = New Font("Segoe UI", 9F)
        btnOpenPOS.ForeColor = Color.White
        btnOpenPOS.Location = New Point(6, 299)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnOpenPOS.Size = New Size(128, 34)
        btnOpenPOS.TabIndex = 22
        btnOpenPOS.Text = "Point Of Sale " & ChrW(55357) & ChrW(57042)
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.BorderColor = Color.White
        btnSALESHISTORY.BorderRadius = 12
        btnSALESHISTORY.BorderThickness = 1
        btnSALESHISTORY.CustomizableEdges = CustomizableEdges11
        btnSALESHISTORY.DisabledState.BorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.CustomBorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSALESHISTORY.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSALESHISTORY.FillColor = Color.Blue
        btnSALESHISTORY.Font = New Font("Segoe UI", 9F)
        btnSALESHISTORY.ForeColor = Color.WhiteSmoke
        btnSALESHISTORY.Location = New Point(6, 449)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnSALESHISTORY.Size = New Size(128, 34)
        btnSALESHISTORY.TabIndex = 21
        btnSALESHISTORY.Text = "Sales History 📜"
        ' 
        ' btnUploadPictures
        ' 
        btnUploadPictures.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadPictures.Location = New Point(18, 125)
        btnUploadPictures.Margin = New Padding(3, 2, 3, 2)
        btnUploadPictures.Name = "btnUploadPictures"
        btnUploadPictures.Size = New Size(103, 23)
        btnUploadPictures.TabIndex = 13
        btnUploadPictures.Text = "Upload Pictures"
        btnUploadPictures.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Navy
        pnlHeader.Controls.Add(lblTime)
        pnlHeader.Controls.Add(Label24)
        pnlHeader.Controls.Add(Label2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(146, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1213, 105)
        pnlHeader.TabIndex = 24
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(724, 59)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(97, 30)
        lblTime.TabIndex = 6
        lblTime.Text = "00:00:00"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.White
        Label24.Location = New Point(5, 49)
        Label24.Name = "Label24"
        Label24.Size = New Size(214, 45)
        Label24.TabIndex = 9
        Label24.Text = "Point Of Sale"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(222, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(472, 25)
        Label2.TabIndex = 1
        Label2.Text = "Manage sales, track inventory, and view weekly reports"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(-215, -5)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1048, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Kirby's Hardware Trading"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1068, 517)
        Controls.Add(pnlHeader)
        Controls.Add(Guna2Panel1)
        Controls.Add(flpCart)
        Controls.Add(flpProduct1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "pos"
        Text = "Products"
        WindowState = FormWindowState.Maximized
        Guna2Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents flpProduct1 As FlowLayoutPanel
    Friend WithEvents flpCart As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSALESHISTORY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class

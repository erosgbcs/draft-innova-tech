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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos))
        TextBox1 = New TextBox()
        flpProduct1 = New FlowLayoutPanel()
        flpCart = New FlowLayoutPanel()
        lblAvailableProducts = New Label()
        Label1 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        btnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        btnOpenPOS = New Guna.UI2.WinForms.Guna2Button()
        btnSALESHISTORY = New Guna.UI2.WinForms.Guna2Button()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        Guna2Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(153, 84)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search products by one code or name..."
        TextBox1.Size = New Size(873, 23)
        TextBox1.TabIndex = 4
        ' 
        ' flpProduct1
        ' 
        flpProduct1.BackColor = Color.White
        flpProduct1.Location = New Point(153, 113)
        flpProduct1.Margin = New Padding(4, 3, 4, 3)
        flpProduct1.Name = "flpProduct1"
        flpProduct1.Size = New Size(534, 520)
        flpProduct1.TabIndex = 7
        ' 
        ' flpCart
        ' 
        flpCart.AutoScroll = True
        flpCart.BackColor = Color.White
        flpCart.Location = New Point(711, 113)
        flpCart.Margin = New Padding(4, 3, 4, 3)
        flpCart.Name = "flpCart"
        flpCart.Size = New Size(374, 508)
        flpCart.TabIndex = 8
        ' 
        ' lblAvailableProducts
        ' 
        lblAvailableProducts.AutoSize = True
        lblAvailableProducts.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableProducts.ForeColor = Color.Navy
        lblAvailableProducts.Location = New Point(153, 44)
        lblAvailableProducts.Margin = New Padding(4, 0, 4, 0)
        lblAvailableProducts.Name = "lblAvailableProducts"
        lblAvailableProducts.Size = New Size(257, 37)
        lblAvailableProducts.TabIndex = 9
        lblAvailableProducts.Text = "Available Products"
        lblAvailableProducts.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(221, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(600, 37)
        Label1.TabIndex = 11
        Label1.Text = "KIRBYS HARDWARE TRADING POINT OF SALE"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(btnOpenInventory)
        Guna2Panel1.Controls.Add(btnOpenPOS)
        Guna2Panel1.Controls.Add(btnSALESHISTORY)
        Guna2Panel1.Controls.Add(btnUploadPictures)
        Guna2Panel1.Controls.Add(PictureBox3)
        Guna2Panel1.CustomBorderColor = Color.Transparent
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.FillColor = Color.DarkBlue
        Guna2Panel1.Location = New Point(4, -1)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(142, 634)
        Guna2Panel1.TabIndex = 44
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.BorderRadius = 12
        btnOpenInventory.CustomizableEdges = CustomizableEdges1
        btnOpenInventory.DisabledState.BorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenInventory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenInventory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenInventory.Font = New Font("Segoe UI", 9F)
        btnOpenInventory.ForeColor = Color.White
        btnOpenInventory.Location = New Point(7, 332)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnOpenInventory.Size = New Size(128, 34)
        btnOpenInventory.TabIndex = 20
        btnOpenInventory.Text = "Inventory"
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.BorderRadius = 12
        btnOpenPOS.CustomizableEdges = CustomizableEdges3
        btnOpenPOS.DisabledState.BorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.CustomBorderColor = Color.DarkGray
        btnOpenPOS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOpenPOS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOpenPOS.Font = New Font("Segoe UI", 9F)
        btnOpenPOS.ForeColor = Color.White
        btnOpenPOS.Location = New Point(7, 280)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnOpenPOS.Size = New Size(128, 34)
        btnOpenPOS.TabIndex = 19
        btnOpenPOS.Text = "Products"
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.BorderRadius = 12
        btnSALESHISTORY.CustomizableEdges = CustomizableEdges5
        btnSALESHISTORY.DisabledState.BorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.CustomBorderColor = Color.DarkGray
        btnSALESHISTORY.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSALESHISTORY.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSALESHISTORY.Font = New Font("Segoe UI", 9F)
        btnSALESHISTORY.ForeColor = Color.White
        btnSALESHISTORY.Location = New Point(7, 224)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSALESHISTORY.Size = New Size(128, 34)
        btnSALESHISTORY.TabIndex = 18
        btnSALESHISTORY.Text = "Sales History"
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
        ' pos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1068, 517)
        Controls.Add(Guna2Panel1)
        Controls.Add(Label1)
        Controls.Add(lblAvailableProducts)
        Controls.Add(flpCart)
        Controls.Add(flpProduct1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "pos"
        Text = "Products"
        WindowState = FormWindowState.Maximized
        Guna2Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents flpProduct1 As FlowLayoutPanel
    Friend WithEvents flpCart As FlowLayoutPanel
    Friend WithEvents lblAvailableProducts As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOpenPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSALESHISTORY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class

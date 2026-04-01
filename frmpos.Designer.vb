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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos))
        TextBox1 = New TextBox()
        flpProduct1 = New FlowLayoutPanel()
        flpCart = New FlowLayoutPanel()
        lblAvailableProducts = New Label()
        Panel7 = New Panel()
        btnSALESHISTORY = New Button()
        btnOpenInventory = New Button()
        btnOpenPOS = New Button()
        btnUploadPictures = New Button()
        PictureBox3 = New PictureBox()
        Button18 = New Button()
        Label1 = New Label()
        Panel7.SuspendLayout()
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
        flpProduct1.Size = New Size(534, 481)
        flpProduct1.TabIndex = 7
        ' 
        ' flpCart
        ' 
        flpCart.AutoScroll = True
        flpCart.BackColor = Color.White
        flpCart.Location = New Point(711, 113)
        flpCart.Margin = New Padding(4, 3, 4, 3)
        flpCart.Name = "flpCart"
        flpCart.Size = New Size(374, 481)
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
        ' Panel7
        ' 
        Panel7.BackColor = Color.CornflowerBlue
        Panel7.Controls.Add(btnSALESHISTORY)
        Panel7.Controls.Add(btnOpenInventory)
        Panel7.Controls.Add(btnOpenPOS)
        Panel7.Controls.Add(btnUploadPictures)
        Panel7.Controls.Add(PictureBox3)
        Panel7.Controls.Add(Button18)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(126, 594)
        Panel7.TabIndex = 10
        ' 
        ' btnSALESHISTORY
        ' 
        btnSALESHISTORY.Location = New Point(29, 301)
        btnSALESHISTORY.Margin = New Padding(2)
        btnSALESHISTORY.Name = "btnSALESHISTORY"
        btnSALESHISTORY.Size = New Size(75, 25)
        btnSALESHISTORY.TabIndex = 12
        btnSALESHISTORY.Text = "Sales History"
        btnSALESHISTORY.UseVisualStyleBackColor = True
        ' 
        ' btnOpenInventory
        ' 
        btnOpenInventory.Location = New Point(29, 265)
        btnOpenInventory.Margin = New Padding(2)
        btnOpenInventory.Name = "btnOpenInventory"
        btnOpenInventory.Size = New Size(75, 23)
        btnOpenInventory.TabIndex = 11
        btnOpenInventory.Text = "Inventory"
        btnOpenInventory.UseVisualStyleBackColor = True
        ' 
        ' btnOpenPOS
        ' 
        btnOpenPOS.Location = New Point(29, 219)
        btnOpenPOS.Margin = New Padding(2)
        btnOpenPOS.Name = "btnOpenPOS"
        btnOpenPOS.Size = New Size(75, 23)
        btnOpenPOS.TabIndex = 10
        btnOpenPOS.Text = "Products"
        btnOpenPOS.UseVisualStyleBackColor = True
        ' 
        ' btnUploadPictures
        ' 
        btnUploadPictures.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadPictures.Location = New Point(10, 122)
        btnUploadPictures.Margin = New Padding(3, 2, 3, 2)
        btnUploadPictures.Name = "btnUploadPictures"
        btnUploadPictures.Size = New Size(103, 23)
        btnUploadPictures.TabIndex = 1
        btnUploadPictures.Text = "Upload Pictures"
        btnUploadPictures.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = SystemColors.Info
        Button18.Location = New Point(12, 965)
        Button18.Name = "Button18"
        Button18.Size = New Size(117, 30)
        Button18.TabIndex = 8
        Button18.Text = "Logout"
        Button18.UseVisualStyleBackColor = False
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
        ' pos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1068, 514)
        Controls.Add(Label1)
        Controls.Add(Panel7)
        Controls.Add(lblAvailableProducts)
        Controls.Add(flpCart)
        Controls.Add(flpProduct1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "pos"
        Text = "Products"
        WindowState = FormWindowState.Maximized
        Panel7.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents flpProduct1 As FlowLayoutPanel
    Friend WithEvents flpCart As FlowLayoutPanel
    Friend WithEvents lblAvailableProducts As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnSALESHISTORY As Button
    Friend WithEvents btnOpenInventory As Button
    Friend WithEvents btnOpenPOS As Button
    Friend WithEvents btnUploadPictures As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_list
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
        flpProducts = New FlowLayoutPanel()
        pnlProduct = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        flpProducts.SuspendLayout()
        pnlProduct.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' flpProducts
        ' 
        flpProducts.AutoScroll = True
        flpProducts.Controls.Add(pnlProduct)
        flpProducts.Dock = DockStyle.Fill
        flpProducts.Location = New Point(0, 0)
        flpProducts.Name = "flpProducts"
        flpProducts.Size = New Size(952, 616)
        flpProducts.TabIndex = 0
        ' 
        ' pnlProduct
        ' 
        pnlProduct.BackColor = Color.White
        pnlProduct.BorderStyle = BorderStyle.FixedSingle
        pnlProduct.Controls.Add(PictureBox1)
        pnlProduct.Location = New Point(3, 3)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Size = New Size(220, 260)
        pnlProduct.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(8, 8)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Product_list
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(952, 616)
        Controls.Add(flpProducts)
        Name = "Product_list"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product_list"
        WindowState = FormWindowState.Maximized
        flpProducts.ResumeLayout(False)
        pnlProduct.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpProducts As FlowLayoutPanel
    Friend WithEvents pnlProduct As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class

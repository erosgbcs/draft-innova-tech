<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoading))
        ProgressBar1 = New ProgressBar()
        lblPercent = New Label()
        lblDeveloper = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.IndianRed
        ProgressBar1.Location = New Point(514, 519)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(973, 35)
        ProgressBar1.TabIndex = 0
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.BackColor = Color.Transparent
        lblPercent.Font = New Font("Segoe UI", 14.0F)
        lblPercent.Location = New Point(994, 491)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(38, 25)
        lblPercent.TabIndex = 1
        lblPercent.Text = "0%"
        ' 
        ' lblDeveloper
        ' 
        lblDeveloper.AutoSize = True
        lblDeveloper.BackColor = Color.Transparent
        lblDeveloper.Font = New Font("Impact", 72.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDeveloper.Location = New Point(476, 201)
        lblDeveloper.Name = "lblDeveloper"
        lblDeveloper.Size = New Size(1047, 117)
        lblDeveloper.TabIndex = 2
        lblDeveloper.Text = "Developed by InnovaTech"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' frmLoading
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1702, 976)
        Controls.Add(lblDeveloper)
        Controls.Add(lblPercent)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLoading"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmLoading"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class

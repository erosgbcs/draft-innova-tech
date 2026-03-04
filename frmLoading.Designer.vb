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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoading))
        ProgressBar1 = New ProgressBar()
        lblPercent = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.None
        ProgressBar1.BackColor = SystemColors.Highlight
        ProgressBar1.Location = New Point(3, 41)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(361, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' lblPercent
        ' 
        lblPercent.Anchor = AnchorStyles.None
        lblPercent.AutoSize = True
        lblPercent.Font = New Font("Arial", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPercent.ForeColor = SystemColors.HotTrack
        lblPercent.Location = New Point(154, 79)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(45, 15)
        lblPercent.TabIndex = 1
        lblPercent.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 200
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblPercent)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Location = New Point(281, 314)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(374, 100)
        Panel1.TabIndex = 2
        ' 
        ' FrmLoading
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(906, 535)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmLoading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLoading"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblPercent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceipt
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
        rtbReceipt = New RichTextBox()
        btnDone = New Button()
        btnPrintreceipt = New Button()
        SuspendLayout()
        ' 
        ' rtbReceipt
        ' 
        rtbReceipt.Location = New Point(1, 0)
        rtbReceipt.Name = "rtbReceipt"
        rtbReceipt.Size = New Size(397, 347)
        rtbReceipt.TabIndex = 0
        rtbReceipt.Text = ""
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.Red
        btnDone.ForeColor = Color.White
        btnDone.Location = New Point(223, 357)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(89, 26)
        btnDone.TabIndex = 1
        btnDone.Text = "Exit"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' btnPrintreceipt
        ' 
        btnPrintreceipt.BackColor = Color.DodgerBlue
        btnPrintreceipt.Location = New Point(74, 355)
        btnPrintreceipt.Name = "btnPrintreceipt"
        btnPrintreceipt.Size = New Size(115, 28)
        btnPrintreceipt.TabIndex = 2
        btnPrintreceipt.Text = "Print Receipt"
        btnPrintreceipt.UseVisualStyleBackColor = False
        ' 
        ' frmReceipt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(402, 388)
        Controls.Add(btnPrintreceipt)
        Controls.Add(btnDone)
        Controls.Add(rtbReceipt)
        Name = "frmReceipt"
        Text = "frmReceipt"
        ResumeLayout(False)
    End Sub

    Public WithEvents rtbReceipt As RichTextBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnPrintreceipt As Button
End Class

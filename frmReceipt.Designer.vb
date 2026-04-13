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
        SuspendLayout()
        ' 
        ' rtbReceipt
        ' 
        rtbReceipt.Location = New Point(1, 0)
        rtbReceipt.Name = "rtbReceipt"
        rtbReceipt.Size = New Size(391, 347)
        rtbReceipt.TabIndex = 0
        rtbReceipt.Text = ""
        ' 
        ' btnDone
        ' 
        btnDone.Location = New Point(143, 353)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(75, 23)
        btnDone.TabIndex = 1
        btnDone.Text = "Button1"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' frmReceipt
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(393, 392)
        Controls.Add(btnDone)
        Controls.Add(rtbReceipt)
        Name = "frmReceipt"
        Text = "frmReceipt"
        ResumeLayout(False)
    End Sub

    Public WithEvents rtbReceipt As RichTextBox
    Friend WithEvents btnDone As Button
End Class

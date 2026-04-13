<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()

        Me.rbcash = New System.Windows.Forms.RadioButton()
        Me.rbGCash = New System.Windows.Forms.RadioButton()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAmountPaid = New Guna.UI2.WinForms.Guna2TextBox()

        Dim LabelHeader As New System.Windows.Forms.Label()
        Dim LabelMethod As New System.Windows.Forms.Label()
        Dim LabelChangeTxt As New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' LabelHeader
        LabelHeader.AutoSize = True
        LabelHeader.Font = New System.Drawing.Font("Segoe UI", 10.0F)
        LabelHeader.ForeColor = System.Drawing.Color.Gray
        LabelHeader.Location = New System.Drawing.Point(40, 30)
        LabelHeader.Text = "TOTAL AMOUNT DUE"

        ' lblTotalAmount
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 26.0F, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.lblTotalAmount.Location = New System.Drawing.Point(35, 50)
        Me.lblTotalAmount.Text = "₱0.00"

        ' LabelMethod
        LabelMethod.AutoSize = True
        LabelMethod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0F, System.Drawing.FontStyle.Bold)
        LabelMethod.Location = New System.Drawing.Point(40, 125)
        LabelMethod.Text = "Select Payment Method:"

        ' rbcash
        Me.rbcash.AutoSize = True
        Me.rbcash.Location = New System.Drawing.Point(45, 150)
        Me.rbcash.Text = "Cash"
        Me.rbcash.Checked = True

        ' rbGCash
        Me.rbGCash.AutoSize = True
        Me.rbGCash.Location = New System.Drawing.Point(130, 150)
        Me.rbGCash.Text = "GCash"

        ' txtAmountPaid
        Me.txtAmountPaid.BorderRadius = 8
        Me.txtAmountPaid.CustomizableEdges = CustomizableEdges1
        Me.txtAmountPaid.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.txtAmountPaid.Location = New System.Drawing.Point(40, 210)
        Me.txtAmountPaid.PlaceholderText = "Enter Amount"
        Me.txtAmountPaid.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Me.txtAmountPaid.Size = New System.Drawing.Size(300, 45)

        ' LabelChangeTxt
        LabelChangeTxt.AutoSize = True
        LabelChangeTxt.Font = New System.Drawing.Font("Segoe UI", 10.0F)
        LabelChangeTxt.Location = New System.Drawing.Point(40, 270)
        LabelChangeTxt.Text = "Change:"

        ' lblChange
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0F, System.Drawing.FontStyle.Bold)
        Me.lblChange.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblChange.Location = New System.Drawing.Point(105, 267)
        Me.lblChange.Text = "₱0.00"

        ' btnConfirm
        Me.btnConfirm.BorderRadius = 10
        Me.btnConfirm.CustomizableEdges = CustomizableEdges3
        Me.btnConfirm.FillColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0F, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(40, 320)
        Me.btnConfirm.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Me.btnConfirm.Size = New System.Drawing.Size(300, 50)
        Me.btnConfirm.Text = "COMPLETE TRANSACTION"

        ' frmPayment Form Setup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 410)
        Me.Controls.Add(LabelHeader)
        Me.Controls.Add(LabelMethod)
        Me.Controls.Add(LabelChangeTxt)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.rbGCash)
        Me.Controls.Add(Me.rbcash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment Processing"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' DECLARATIONS: This is what connects the UI to the Logic
    Friend WithEvents rbcash As System.Windows.Forms.RadioButton
    Friend WithEvents rbGCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAmountPaid As Guna.UI2.WinForms.Guna2TextBox
End Class
Imports Guna.UI2.WinForms
Imports TheArtOfDevHtmlRenderer.Adapters

Public Class frmPayment
    ' Data properties to pass back to the POS form
    Public Property TotalAmount As Decimal
    Public Property AmountPaid As Decimal
    Public Property Change As Decimal
    Public Property PaymentMethod As String
    Public Property IsConfirmed As Boolean = False

    ' When the form opens
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalAmount.Text = "₱" & TotalAmount.ToString("N2")
        rbcash.Checked = True
        txtAmountPaid.Focus()
    End Sub

    ' Real-time Change Calculation
    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        Dim paid As Decimal = 0
        ' Cleaning the input of symbols and commas
        Dim cleanInput As String = txtAmountPaid.Text.Replace("₱", "").Replace(",", "").Trim()

        If Decimal.TryParse(cleanInput, paid) Then
            AmountPaid = paid
            Change = AmountPaid - TotalAmount

            If Change >= 0 Then
                lblChange.Text = "₱" & Change.ToString("N2")
                lblChange.ForeColor = Color.ForestGreen
            Else
                lblChange.Text = "₱0.00"
                lblChange.ForeColor = Color.DimGray
            End If
        Else
            lblChange.Text = "₱0.00"
        End If
    End Sub

    ' The Confirm Button Logic
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Check if amount is enough for cash payments
        If AmountPaid < TotalAmount AndAlso rbcash.Checked Then
            MessageBox.Show("Amount provided is less than the Total Amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        PaymentMethod = If(rbcash.Checked, "Cash", "GCash")
        IsConfirmed = True
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
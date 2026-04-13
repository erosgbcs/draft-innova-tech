Public Class frmPayment
    Public Property CartItems As List(Of CartItem) ' Receive the list from POS
    Public Property TotalAmount As Decimal
    Public Property AmountPaid As Decimal
    Public Property Change As Decimal
    Public Property PaymentMethod As String
    Public Property IsConfirmed As Boolean = False

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Columns
        dgvItems.Columns.Clear()
        dgvItems.Columns.Add("Code", "Code")
        dgvItems.Columns.Add("Name", "Product")
        dgvItems.Columns.Add("Qty", "Qty")
        dgvItems.Columns.Add("Price", "Price")

        dgvItems.Columns("Code").Visible = False ' Hide the code
        dgvItems.Columns("Name").ReadOnly = True
        dgvItems.Columns("Price").ReadOnly = True

        ' Load items into grid
        RefreshGrid()
        UpdateTotals()

        rbcash.Checked = True
        txtAmountPaid.Focus()
    End Sub

    Private Sub RefreshGrid()
        dgvItems.Rows.Clear()
        For Each item In CartItems
            dgvItems.Rows.Add(item.ProductCode, item.ProductName, item.Quantity, item.Price)
        Next
    End Sub

    ' Update Total when quantity is edited in the grid
    Private Sub dgvItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 2 Then ' If Qty column is changed
            Dim newQty As Integer = 0
            If Integer.TryParse(dgvItems.Rows(e.RowIndex).Cells(2).Value.ToString(), newQty) Then
                ' Update the linked list
                CartItems(e.RowIndex).Quantity = newQty
                UpdateTotals()
            End If
        End If
    End Sub

    Private Sub UpdateTotals()
        TotalAmount = CartItems.Sum(Function(c) c.Price * c.Quantity)
        lblTotalAmount.Text = "₱" & TotalAmount.ToString("N2")
        CalculateChange()
    End Sub

    Private Sub CalculateChange()
        Dim paid As Decimal = 0
        If Decimal.TryParse(txtAmountPaid.Text, paid) Then
            AmountPaid = paid
            Change = AmountPaid - TotalAmount
            lblChange.Text = "₱" & Math.Max(0, Change).ToString("N2")
        End If
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        CalculateChange()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If AmountPaid < TotalAmount AndAlso rbcash.Checked Then
            MessageBox.Show("Insufficient amount.")
            Return
        End If
        IsConfirmed = True
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
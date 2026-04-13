Public Class frmReceipt

    ' Allow the user to drag the form even without a border
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Transaction Receipt"
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Optional: Style the RichTextBox via code to ensure it looks right
        rtbReceipt.ReadOnly = True
        rtbReceipt.BackColor = Color.White
        rtbReceipt.Font = New Font("Courier New", 10)
    End Sub

    Public Sub DisplayReceipt(buyer As String, cart As List(Of CartItem), total As Decimal, paid As Decimal, change As Decimal)
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("==================================")
        sb.AppendLine("      Kirby's Hardware Trading      ") ' Using your project name
        sb.AppendLine("      Guyong, Sta.maria, Bulacan         ")
        sb.AppendLine("==================================")
        sb.AppendLine($"Date:     {DateTime.Now:MM/dd/yyyy}")
        sb.AppendLine($"Time:     {DateTime.Now:hh:mm tt}")
        sb.AppendLine($"Cashier:  System Admin")
        sb.AppendLine($"Customer: {buyer}")
        sb.AppendLine("----------------------------------")
        sb.AppendLine(String.Format("{0,-18} {1,15}", "ITEM", "PRICE"))
        sb.AppendLine("----------------------------------")

        For Each item In cart
            ' Formats item name and quantity, then aligns price to the right
            Dim itemInfo As String = $"{item.ProductName} (x{item.Quantity})"
            sb.AppendLine(String.Format("{0,-18} {1,15:N2}", itemInfo, item.Subtotal))
        Next

        sb.AppendLine("----------------------------------")
        sb.AppendLine(String.Format("{0,-18} {1,15:N2}", "TOTAL AMOUNT:", total))
        sb.AppendLine(String.Format("{0,-18} {1,15:N2}", "CASH PAID:", paid))
        sb.AppendLine(String.Format("{0,-18} {1,15:N2}", "CHANGE:", change))
        sb.AppendLine("==================================")
        sb.AppendLine("     THANK YOU FOR SHOPPING!     ")
        sb.AppendLine("    Please come again soon.      ")
        sb.AppendLine("==================================")

        rtbReceipt.Text = sb.ToString()
    End Sub

    ' Button to close the receipt
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
End Class
Imports System.Data

Public Class frmSalesHIstory
    Private db As New DatabaseHelper()

    Private Sub frmSalesHIstory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Form Background
        Me.BackColor = Color.FromArgb(241, 245, 249) ' Ghost Blue
        ' Load Initial Data
        RefreshSalesData()
    End Sub

    ' --- Method para sa pag-load at refresh ng data ---
    Private Sub RefreshSalesData()
        Try
            ' Gamit ang iyong control name: dgvsaleshistory
            Dim dt As DataTable = db.LoadSales()
            dgvsaleshistory.DataSource = dt

            ' I-format ang grid kapag may data na
            If dgvsaleshistory.Columns.Count > 0 Then
                FormatGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading sales history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Search Logic (Filters as you type) ---
    Private Sub txtSearchSales_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSales.TextChanged
        Try
            If String.IsNullOrWhiteSpace(txtSearchSales.Text) Then
                RefreshSalesData()
            Else
                dgvsaleshistory.DataSource = db.SearchSales(txtSearchSales.Text)
            End If
        Catch ex As Exception
            ' Silent catch para iwas lag habang nag-e-entry
        End Try
    End Sub

    ' --- Modern Grid Formatting with Centered Text ---
    Private Sub FormatGrid()
        Try
            With dgvsaleshistory
                ' 1. Basic Modern Setup
                .BackgroundColor = Color.White
                .BorderStyle = BorderStyle.None
                .EnableHeadersVisualStyles = False ' Para gumana ang custom header color
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
                .RowHeadersVisible = False ' Mas malinis tingnan
                .ReadOnly = True

                ' 2. HEADER ALIGNMENT & STYLE (CENTERED)
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42) ' Deep Navy
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10)
                .ColumnHeadersHeight = 45
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                ' 3. DATA ALIGNMENT & STYLE (CENTERED)
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Font = New Font("Segoe UI", 9)
                .RowTemplate.Height = 35
                .GridColor = Color.FromArgb(241, 245, 249)

                ' 4. Alternating Rows (Striped Effect)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252)

                ' 5. Column Headers & Specific Formatting
                If .Columns.Contains("SaleID") Then
                    .Columns("SaleID").HeaderText = "ID"
                    .Columns("SaleID").Width = 60
                End If

                If .Columns.Contains("BuyerName") Then
                    .Columns("BuyerName").HeaderText = "Customer Name"
                    ' Optional: Left align names if preferred for readability, else keep center
                    .Columns("BuyerName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If .Columns.Contains("SaleDate") Then
                    .Columns("SaleDate").HeaderText = "Date & Time"
                End If

                If .Columns.Contains("Total") Then
                    .Columns("Total").HeaderText = "Total Amount"
                    .Columns("Total").DefaultCellStyle.Format = "N2"
                    .Columns("Total").DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235) ' Innova Blue
                    .Columns("Total").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    ' Keep Amount Center or MiddleRight
                    .Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                ' 6. Auto-size Columns to Fill Space
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        Catch ex As Exception
            ' Silent error handling for formatting
        End Try
    End Sub

    ' --- Row Click Event ---
    Private Sub dgvsaleshistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsaleshistory.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim selectedID = dgvsaleshistory.Rows(e.RowIndex).Cells("SaleID").Value.ToString
                ' Debugging check:
                Console.WriteLine("Selected Sale ID: " & selectedID)
            Catch ex As Exception
                ' Silent catch if column name doesn't match
            End Try
        End If
    End Sub

    ' --- Dashboard Button ---
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim dashForm As New frmdashboard
        dashForm.WindowState = FormWindowState.Maximized
        dashForm.Show()
        Hide() ' Hide current form
    End Sub

    ' --- POS Button ---
    Private Sub btnOpenPOS_Click(sender As Object, e As EventArgs)
        Dim posForm As New pos
        posForm.WindowState = FormWindowState.Maximized
        posForm.Show()
        Hide()
    End Sub

    ' --- Inventory Button ---
    Private Sub btnOpenInventory_Click(sender As Object, e As EventArgs)
        Dim invForm As New frmInventory
        invForm.WindowState = FormWindowState.Maximized
        invForm.Show()
        Hide()
    End Sub

    ' --- Sales History Button (Acts as Refresh) ---
    Private Sub btnSALESHISTORY_Click(sender As Object, e As EventArgs)
        ' Since you are already in Sales History, we just refresh the data
        RefreshSalesData()
        txtSearchSales.Clear()
        MessageBox.Show("Sales History Refreshed!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- Users / Management Button ---
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        ' This opens your User management form
        Dim userForm As New User
        userForm.Show()
        Hide() ' Hides the Sales History form
    End Sub

    ' --- Logout Button ---
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Assuming your login form is named FrmLogin
            Dim login As New FrmLogin
            login.Show()

            ' Closes the Sales History form
            Close()
        End If
    End Sub

    ' --- EXPORT TO CSV ---
    Private Sub BtnExportcsv_Click(sender As Object, e As EventArgs) Handles BtnExportcsv.Click
        Try
            Dim sfd As New SaveFileDialog() With {
                .Filter = "CSV File|*.csv",
                .FileName = "SalesHistory_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"
            }

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                ' Column Headers
                sb.AppendLine("ID,Customer Name,Date,Total Amount")

                ' Data Rows
                For Each row As DataGridViewRow In dgvsaleshistory.Rows
                    If Not row.IsNewRow Then
                        Dim id As String = row.Cells("SaleID").Value?.ToString()
                        Dim name As String = row.Cells("BuyerName").Value?.ToString().Replace(",", " ") ' Remove commas to keep CSV clean
                        Dim sDate As String = row.Cells("SaleDate").Value?.ToString()
                        Dim total As String = row.Cells("Total").Value?.ToString()

                        sb.AppendLine($"{id},{name},{sDate},{total}")
                    End If
                Next

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString())
                MessageBox.Show("Sales History exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Export failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- PRINT REPORT BUTTON ---
    Private Sub printreport_Click(sender As Object, e As EventArgs) Handles printreport.Click
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintSalesDoc
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    ' --- PRINT DOCUMENT CONTENT ---
    Private Sub PrintSalesDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSalesDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontHeader As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim fontSub As New Font("Segoe UI", 10, FontStyle.Italic)
        Dim fontCol As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontRow As New Font("Segoe UI", 9, FontStyle.Regular)

        Dim x As Integer = 50
        Dim y As Integer = 50

        ' Title & Date
        g.DrawString("INNOVATECH SALES REPORT", fontHeader, Brushes.Black, x, y)
        y += 35
        g.DrawString("Generated on: " & DateTime.Now.ToString("f"), fontSub, Brushes.Gray, x, y)
        y += 50

        ' Table Headers
        g.DrawString("ID", fontCol, Brushes.Black, x, y)
        g.DrawString("CUSTOMER", fontCol, Brushes.Black, x + 50, y)
        g.DrawString("DATE & TIME", fontCol, Brushes.Black, x + 300, y)
        g.DrawString("AMOUNT", fontCol, Brushes.Black, x + 550, y)

        y += 20
        g.DrawLine(Pens.Black, x, y, x + 650, y)
        y += 10

        ' Loop Sales Data
        Dim grandTotal As Decimal = 0
        For Each row As DataGridViewRow In dgvsaleshistory.Rows
            If Not row.IsNewRow Then
                g.DrawString(row.Cells("SaleID").Value?.ToString(), fontRow, Brushes.Black, x, y)
                g.DrawString(row.Cells("BuyerName").Value?.ToString(), fontRow, Brushes.Black, x + 50, y)
                g.DrawString(row.Cells("SaleDate").Value?.ToString(), fontRow, Brushes.Black, x + 300, y)

                Dim val As Decimal = If(IsNumeric(row.Cells("Total").Value), CDec(row.Cells("Total").Value), 0)
                g.DrawString("₱" & val.ToString("N2"), fontRow, Brushes.Black, x + 550, y)

                grandTotal += val
                y += 25

                ' Simple Page Overflow check
                If y > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Return
                End If
            End If
        Next

        ' Grand Total at the bottom
        y += 20
        g.DrawLine(Pens.Black, x, y, x + 650, y)
        y += 10
        g.DrawString("GRAND TOTAL: ₱" & grandTotal.ToString("N2"), fontHeader, Brushes.DarkBlue, x + 350, y)
    End Sub
End Class
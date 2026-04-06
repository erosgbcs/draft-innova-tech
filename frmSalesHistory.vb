Imports System.Data

Public Class frmSalesHIstory
    Private db As New DatabaseHelper()

    Private Sub frmSalesHIstory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Form Background
        Me.BackColor = Color.FromArgb(241, 245, 249) ' Ghost Blue
        SyncFormLogo(Me.PictureBox1)
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

End Class
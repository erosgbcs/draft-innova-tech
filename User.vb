Imports System.Data

Public Class User
    Private db As New DatabaseHelper()

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUserList()

        ' UI Styling
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.MultiSelect = False
        dgvActivity.ReadOnly = True
    End Sub

    ' 1. LOAD ALL USERS
    Private Sub RefreshUserList()
        dgvUsers.DataSource = db.GetAllUsers()

        ' Pretty Header Names
        If dgvUsers.Columns.Count > 0 Then
            dgvUsers.Columns("FullName").HeaderText = "Staff Name"
            dgvUsers.Columns("IsActive").HeaderText = "Account Status"
        End If
    End Sub

    ' 2. THE "STAFF DOING" LOGIC
    ' When a user is clicked, show their specific activity
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            Dim selectedUser As String = row.Cells("Username").Value.ToString()
            Dim staffDisplayName As String = row.Cells("FullName").Value.ToString()

            lblActivityHeader.Text = "Recent Sales Processed by: " & staffDisplayName

            ' Fetch this specific staff's work from the database
            LoadStaffActivity(selectedUser)
        End If
    End Sub

    Private Sub LoadStaffActivity(username As String)
        Try
            Dim dt As DataTable = db.GetUserActivity(username)
            dgvActivity.DataSource = dt

            ' --- Advanced Grid Formatting ---
            With dgvActivity
                .BackgroundColor = Color.White
                .RowHeadersVisible = False
                .BorderStyle = BorderStyle.None
                .EnableHeadersVisualStyles = False

                ' Header Style (Slate Gray for secondary grid)
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(71, 85, 105)
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersHeight = 35

                ' 1. Format Sale ID
                If .Columns.Contains("SaleID") Then
                    .Columns("SaleID").HeaderText = "ID"
                    .Columns("SaleID").Width = 50
                End If

                ' 2. NEW: Format Item Bought Column
                If .Columns.Contains("ItemBought") Then
                    .Columns("ItemBought").HeaderText = "Product(s) Sold"
                    .Columns("ItemBought").MinimumWidth = 150 ' Give it more room
                    .Columns("ItemBought").DefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85)
                End If

                ' 3. Format Total Column
                If .Columns.Contains("Total") Then
                    .Columns("Total").HeaderText = "Amount"
                    .Columns("Total").DefaultCellStyle.Format = "N2"
                    .Columns("Total").DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74) ' Success Green
                    .Columns("Total").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    .Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If

                ' 4. Format Date
                If .Columns.Contains("SaleDate") Then
                    .Columns("SaleDate").HeaderText = "Transaction Date"
                End If

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With

            ' Update UI if no data
            If dt.Rows.Count = 0 Then
                lblActivityHeader.Text = "No sales recorded for this staff member."
                lblActivityHeader.ForeColor = Color.Gray
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading activity: " & ex.Message)
        End Try
    End Sub

    ' 3. TOGGLE STATUS (Deactivate/Activate Staff)
    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("UserID").Value)
            Dim currentStatus As Boolean = Convert.ToBoolean(dgvUsers.SelectedRows(0).Cells("IsActive").Value)

            ' Switch status
            Dim newStatus As Boolean = Not currentStatus

            If db.UpdateUserStatus(userId, newStatus) Then
                MessageBox.Show("Staff status updated successfully!")
                RefreshUserList()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshUserList()
    End Sub
End Class
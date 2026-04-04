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
        Dim dt As DataTable = db.GetUserActivity(username)
        dgvActivity.DataSource = dt

        ' Format the activity list
        If dgvActivity.Columns.Contains("Total") Then
            dgvActivity.Columns("Total").DefaultCellStyle.Format = "₱N2"
        End If

        ' If no activity found
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No sales recorded for this staff member yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
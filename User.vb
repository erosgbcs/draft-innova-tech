Imports System.Data

Public Class User
    Private db As New DatabaseHelper()

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If dgvUsers.Columns.Contains("FullName") Then dgvUsers.Columns("FullName").HeaderText = "Staff Name"
            If dgvUsers.Columns.Contains("IsActive") Then dgvUsers.Columns("IsActive").HeaderText = "Account Status"
        End If

        ' Ensure IsActive column is a checkbox
        Dim col As New DataGridViewCheckBoxColumn()
        col.Name = "IsActive"
        col.DataPropertyName = "IsActive"
        col.TrueValue = 1
        col.FalseValue = 0
        col.ValueType = GetType(Boolean)

        If dgvUsers.Columns.Contains("IsActive") Then
            dgvUsers.Columns.Remove("IsActive") ' if auto-generated
        End If

        dgvUsers.Columns.Add(col)
    End Sub

    ' 2. THE "STAFF DOING" LOGIC
    Private Sub DgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

            Dim usernameObj = row.Cells("Username").Value
            Dim selectedUser As String = If(usernameObj IsNot Nothing AndAlso Not IsDBNull(usernameObj), usernameObj.ToString(), String.Empty)

            Dim staffNameObj = row.Cells("FullName").Value
            Dim staffDisplayName As String = If(staffNameObj IsNot Nothing AndAlso Not IsDBNull(staffNameObj), staffNameObj.ToString(), String.Empty)

            lblActivityHeader.Text = "Recent Sales Processed by: " & staffDisplayName

            If Not String.IsNullOrEmpty(selectedUser) Then
                LoadStaffActivity(selectedUser)
            Else
                dgvActivity.DataSource = Nothing
                lblActivityHeader.Text = "No staff selected."
                lblActivityHeader.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub DgvUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
        If dgvUsers.Columns(e.ColumnIndex).Name = "IsActive" Then
            Dim raw = e.Value
            Dim isActive As Boolean

            If raw Is Nothing OrElse IsDBNull(raw) Then
                isActive = False
            Else
                Try
                    isActive = Convert.ToBoolean(raw)
                Catch ex As Exception
                    Try
                        Dim n As Long = Convert.ToInt64(raw)
                        isActive = (n <> 0)
                    Catch
                        isActive = False
                    End Try
                End Try
            End If

            If isActive = False Then
                dgvUsers.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                dgvUsers.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub LoadStaffActivity(username As String)
        Try
            Dim dt As DataTable = db.GetUserActivity(username)
            dgvActivity.DataSource = dt

            ' --- Advanced Grid Formatting with Text Wrap ---
            With dgvActivity
                .BackgroundColor = Color.White
                .RowHeadersVisible = False
                .BorderStyle = BorderStyle.None
                .EnableHeadersVisualStyles = False

                ' IMPORTANT: Allow rows to expand for wrapped text
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                ' Header Style
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(71, 85, 105)
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersHeight = 35

                ' 1. Format Sale ID
                If .Columns.Contains("SaleID") Then
                    .Columns("SaleID").HeaderText = "ID"
                    .Columns("SaleID").Width = 50
                End If

                ' 2. Format Item Bought Column (WRAP ENABLED)
                If .Columns.Contains("ItemBought") Then
                    .Columns("ItemBought").HeaderText = "Product(s) Sold"
                    .Columns("ItemBought").MinimumWidth = 200
                    .Columns("ItemBought").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns("ItemBought").DefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85)
                End If

                ' 3. Format Total Column
                If .Columns.Contains("Total") Then
                    .Columns("Total").HeaderText = "Amount"
                    .Columns("Total").DefaultCellStyle.Format = "N2"
                    .Columns("Total").DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74)
                    .Columns("Total").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                    .Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If

                ' 4. Format Date
                If .Columns.Contains("SaleDate") Then
                    .Columns("SaleDate").HeaderText = "Transaction Date"
                End If

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With

            If dt.Rows.Count = 0 Then
                lblActivityHeader.Text = "No sales recorded for this staff member."
                lblActivityHeader.ForeColor = Color.Gray
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading activity: " & ex.Message)
        End Try
    End Sub

    ' 3. TOGGLE STATUS
    Private Sub BtnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userIdObj = dgvUsers.SelectedRows(0).Cells("UserID").Value
            Dim userId As Integer = If(userIdObj IsNot Nothing AndAlso Not IsDBNull(userIdObj), Convert.ToInt32(userIdObj), -1)

            Dim statusObj = dgvUsers.SelectedRows(0).Cells("IsActive").Value
            Dim currentStatus As Boolean

            If statusObj Is Nothing OrElse IsDBNull(statusObj) Then
                currentStatus = False
            Else
                Try
                    currentStatus = Convert.ToBoolean(statusObj)
                Catch
                    Try
                        currentStatus = (Convert.ToInt64(statusObj) <> 0)
                    Catch
                        currentStatus = False
                    End Try
                End Try
            End If

            If userId >= 0 Then
                Dim newStatus As Boolean = Not currentStatus
                If db.UpdateUserStatus(userId, newStatus) Then
                    MessageBox.Show("Staff status updated successfully!")
                    RefreshUserList()
                End If
            Else
                MessageBox.Show("Invalid user selected.")
            End If
        End If
    End Sub

    ' 4. LOAD GENERAL INVENTORY LOGS
    Private Sub RefreshInventoryLogs()
        Try
            Dim dtLogs As DataTable = db.GetInventoryLogs()
            dgvActivity.DataSource = dtLogs

            With dgvActivity
                ' IMPORTANT: Allow rows to expand for wrapped text
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                If .Columns.Contains("LogID") Then .Columns("LogID").Visible = False

                If .Columns.Contains("Username") Then
                    .Columns("Username").HeaderText = "Performed By"
                End If

                If .Columns.Contains("Action") Then
                    .Columns("Action").HeaderText = "Action Details"
                    .Columns("Action").DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235)
                    .Columns("Action").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                End If

                ' --- ADD THIS BLOCK FOR THE DETAILS COLUMN ---
                If .Columns.Contains("Details") Then
                    .Columns("Details").HeaderText = "Details"
                    .Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns("Details").MinimumWidth = 250 ' Gives the text enough room to wrap
                End If
                ' ----------------------------------------------

                If .Columns.Contains("LogDate") Then
                    .Columns("LogDate").HeaderText = "Timestamp"
                End If

                ' Change Fill mode to make sure "Details" takes up most of the space
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With

            lblActivityHeader.Text = "System-Wide Inventory Logs"
            lblActivityHeader.ForeColor = Color.Black

        Catch ex As Exception
            MessageBox.Show("Error loading inventory logs: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnShowInventoryLogs_Click(sender As Object, e As EventArgs) Handles btnShowInventoryLogs.Click
        RefreshInventoryLogs()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshUserList()
    End Sub
End Class
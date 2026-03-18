Public Class FrmRegister
    Private dbHelper As DatabaseHelper

    ' Properties to pass data back to the calling form
    Public Property RegisteredUsername As String
    Public Property RegisteredFullName As String
    Public Property RegisteredRole As String

    Public Sub New(dbHelper As DatabaseHelper)
        InitializeComponent()
        Me.dbHelper = dbHelper

        ' Setup Role ComboBox
        cboRole.Items.AddRange(New String() {"Admin", "Staff"})
        cboRole.SelectedIndex = 1 ' Default to Staff

        ' Manually hook up events to fix the "WithEvents" error
        AddHandler btnRegister.Click, AddressOf btnRegister_Click
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        Try
            ' 1. Validation
            If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
               String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
               String.IsNullOrWhiteSpace(txtFullName.Text) Then
                MessageBox.Show("Please fill in all fields.", "Validation Error")
                Return
            End If

            ' 2. Save to Database (Example Logic)
            ' dbHelper.SaveUser(txtUsername.Text, txtPassword.Text, txtFullName.Text, cboRole.SelectedItem.ToString())

            ' 3. Store properties for the Login form to use
            RegisteredUsername = txtUsername.Text
            RegisteredFullName = txtFullName.Text
            RegisteredRole = cboRole.SelectedItem.ToString()

            MessageBox.Show("Registration Successful!", "Success")
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
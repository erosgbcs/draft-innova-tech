Public Class FrmRegister
    Private dbHelper As DatabaseHelper

    ' Public properties to share data back with the Login form
    Public Property RegisteredUsername As String

    Public Sub New(dbHelper As DatabaseHelper)
        InitializeComponent()
        Me.dbHelper = dbHelper

        ' Setup Role Options
        cboRole.Items.Clear()
        cboRole.Items.AddRange(New String() {"Staff"})
        cboRole.SelectedIndex = 1 ' Default to Staff

        ' Link Buttons
        AddHandler btnRegister.Click, AddressOf btnRegister_Click
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        ' 1. Validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Required")
            Return
        End If

        ' 2. Attempt to save to database
        Dim success As Boolean = dbHelper.RegisterUser(
            txtUsername.Text.Trim(),
            txtPassword.Text,
            txtFullName.Text.Trim(),
            cboRole.SelectedItem.ToString()
        )

        ' 3. If successful, close and return OK
        If success Then
            Me.RegisteredUsername = txtUsername.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class
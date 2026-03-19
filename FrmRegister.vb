Public Class FrmRegister
    Private dbHelper As DatabaseHelper

    ' Public properties to share data back with the Login form
    Public Property RegisteredUsername As String

    Public Sub New(dbHelper As DatabaseHelper)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dbHelper = dbHelper

        ' Setup Role Options
        cboRole.Items.Clear()
        cboRole.Items.Add("Staff")

        If cboRole.Items.Count > 0 Then
            cboRole.SelectedIndex = 0 ' Set default to the first item
        End If
    End Sub

    ' Handles the Register button logic
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    ' Handles the Cancel button logic
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
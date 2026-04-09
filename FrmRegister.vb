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
        ' 1. Basic Validation - Changed 'lbl' to 'txtConfirmPassword'
        If {txtUsername, txtPassword, txtConfirmPassword, txtFullName}.Any(Function(t) String.IsNullOrWhiteSpace(t.Text)) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Password Match Check - Changed 'lbl' to 'txtConfirmPassword'
        If txtPassword.Text.Trim() <> txtConfirmPassword.Text.Trim() Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Text = "" ' Clear the confirm box
            txtConfirmPassword.Focus()
            Return
        End If

        ' 3. Minimum Length Check
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' 4. Attempt to save
            Dim success As Boolean = dbHelper.RegisterUser(
                txtUsername.Text.Trim(),
                txtPassword.Text,
                txtFullName.Text.Trim(),
                cboRole.SelectedItem.ToString()
            )

            If success Then
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RegisteredUsername = txtUsername.Text
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Username might already be taken.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("A system error occurred: " & ex.Message)
        End Try
    End Sub

    ' Handles the Cancel button logic
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make labels transparent against the background
        lblFullname.BackColor = Color.Transparent
        lblUsername.BackColor = Color.Transparent
        lblPassword.BackColor = Color.Transparent
        lblRole.BackColor = Color.Transparent

        ' Set initial focus
        txtFullName.Select()
    End Sub

    Private Sub BtnShowHide_Click(sender As Object, e As EventArgs) Handles BtnShowHide.Click
        ' Toggle the property (If it's true, make it false; if false, make it true)
        Dim isHidden As Boolean = txtPassword.UseSystemPasswordChar

        ' Apply to both fields
        txtPassword.UseSystemPasswordChar = Not isHidden
        txtConfirmPassword.UseSystemPasswordChar = Not isHidden

        ' Optional: Change the button text or icon to give feedback
        If txtPassword.UseSystemPasswordChar Then
            BtnShowHide.Text = "👁"
            ' If using Guna2 icons: BtnShowHide.Image = My.Resources.eye_open
        Else
            BtnShowHide.Text = "🔒"
            ' If using Guna2 icons: BtnShowHide.Image = My.Resources.eye_closed
        End If
    End Sub
End Class
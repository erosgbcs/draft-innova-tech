Public Class FrmRegister
    Private dbHelper As DatabaseHelper

    ' Add this property
    Public Property RegisteredUsername As String

    ' Add this constructor
    Public Sub New(dbHelper As DatabaseHelper)
        ' This call is required by the designer
        InitializeComponent()

        ' Store the database helper
        Me.dbHelper = dbHelper
    End Sub

    ' Example method showing proper exception handling
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Your registration logic here
            ' After successful registration, store the username
            RegisteredUsername = txtUsername.Text

            ' Close the form with OK result
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            ' Show error to user
            MessageBox.Show("Registration failed: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Log the error (optional)
            ' Logger.Log(ex)

            ' If you need to rethrow, use Throw (not Throw ex)
            ' Throw  ' This preserves stack trace
        End Try
    End Sub

    ' Rest of your form code...
End Class
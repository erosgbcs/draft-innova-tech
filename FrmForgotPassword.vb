Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Public Class FrmForgotPassword
    Private dbHelper As DatabaseHelper

    ' Constructor that accepts the database helper
    Public Sub New(helper As DatabaseHelper)
        InitializeComponent()
        dbHelper = helper
        SetupForm()
    End Sub

    ' Setup the form
    Private Sub SetupForm()
        ' Form properties
        Me.Text = "Forgot Password"
        Me.Size = New Size(450, 300)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White

        ' Create all controls
        CreateControls()
    End Sub

    Private Sub CreateControls()
        ' Title Label
        Dim lblTitle As New Label()
        lblTitle.Text = "Reset Password"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(52, 73, 94)
        lblTitle.Size = New Size(400, 40)
        lblTitle.Location = New Point(25, 20)
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblTitle)

        ' Support Message - THIS IS WHAT YOU WANT
        Dim lblSupportMessage As New Label()
        lblSupportMessage.Text = "Please contact Innovatech Support to reset your password."
        lblSupportMessage.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblSupportMessage.ForeColor = Color.FromArgb(192, 0, 0) ' Dark Red
        lblSupportMessage.Size = New Size(400, 30)
        lblSupportMessage.Location = New Point(25, 70)
        lblSupportMessage.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblSupportMessage)

        ' Contact Information
        Dim lblContactInfo As New Label()
        lblContactInfo.Text = "Innovatech Support Team" & vbCrLf &
                              "-------------------" & vbCrLf &
                              "📞 Hotline: +63 (2) 1234-5678" & vbCrLf &
                              "📧 Email: support@innovatech.com" & vbCrLf &
                              "🌐 Website: www.innovatech.com/support" & vbCrLf & vbCrLf &
                              "Our support team is available 24/7 to assist you."
        lblContactInfo.Font = New Font("Segoe UI", 10)
        lblContactInfo.ForeColor = Color.FromArgb(44, 62, 80)
        lblContactInfo.Size = New Size(400, 150)
        lblContactInfo.Location = New Point(25, 100)
        lblContactInfo.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblContactInfo)

        ' Contact Support Button
        Dim btnContact As New Button()
        btnContact.Text = "Contact Support"
        btnContact.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnContact.Size = New Size(150, 35)
        btnContact.Location = New Point(70, 220)
        btnContact.BackColor = Color.FromArgb(52, 152, 219)
        btnContact.ForeColor = Color.White
        btnContact.FlatStyle = FlatStyle.Flat
        btnContact.FlatAppearance.BorderSize = 0
        AddHandler btnContact.Click, AddressOf BtnContact_Click
        Me.Controls.Add(btnContact)

        ' Close Button
        Dim btnClose As New Button()
        btnClose.Text = "Close"
        btnClose.Font = New Font("Segoe UI", 10)
        btnClose.Size = New Size(150, 35)
        btnClose.Location = New Point(230, 220)
        btnClose.BackColor = Color.FromArgb(149, 165, 166)
        btnClose.ForeColor = Color.White
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderSize = 0
        AddHandler btnClose.Click, AddressOf BtnClose_Click
        Me.Controls.Add(btnClose)
    End Sub

    ' Contact Support button click
    Private Sub BtnContact_Click(sender As Object, e As EventArgs)
        Try
            ' Try to open email client
            Dim mailto As String = "mailto:support@innovatech.com?subject=Password%20Reset%20Request&body=Please%20help%20me%20reset%20my%20password.%0D%0A%0D%0AUsername:%20[Enter%20your%20username%20here]%0D%0A%0D%0AThank%20you!"
            System.Diagnostics.Process.Start(mailto)
        Catch ex As Exception
            ' If email client fails, show full contact information
            MessageBox.Show(
                "Please contact Innovatech Support:" & vbCrLf & vbCrLf &
                "Phone: +63 (2) 1234-5678" & vbCrLf &
                "Email: support@innovatech.com" & vbCrLf &
                "Website: www.innovatech.com/support" & vbCrLf & vbCrLf &
                "Please provide your username when contacting support.",
                "Contact Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End Try
    End Sub

    ' Close button click
    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
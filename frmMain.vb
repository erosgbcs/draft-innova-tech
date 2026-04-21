Imports System.Runtime.InteropServices

Public Class frmMain

    ' --- 1. Form Dragging Logic (Optional: Allows moving the form if BorderStyle is None) ---
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private db As New DatabaseHelper()
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) ' If you have a top header panel
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    ' --- 2. The Master Navigation Function ---
    ' This replaces the old .Show() and .Hide() logic
    Private Sub ShowChildForm(ByVal childForm As Form)
        ' Clear the panel of any previous forms
        If pnlContent.Controls.Count > 0 Then
            pnlContent.Controls.RemoveAt(0)
        End If

        ' Setup the new form to "live" inside the panel
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add to the panel and display
        pnlContent.Controls.Add(childForm)
        pnlContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    ' --- 3. Form Load (Default Screen) ---
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically show the Dashboard when the app starts
        ShowChildForm(New frmdashboard())
        ' Inside frmMain.vb Load Event
        If GlobalData.UserRole <> "Admin" Then
            btnUsers.Visible = False ' Hide User Management for Cashiers
            btnInventory.Visible = False
        End If
        Dim savedLogo = db.LoadSystemImage("StoreLogo")
        If savedLogo IsNot Nothing Then
            PictureBox1.Image = savedLogo
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' --- 4. Sidebar Button Click Events ---

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowChildForm(New frmdashboard())
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        ShowChildForm(New pos())
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ShowChildForm(New frmInventory())
    End Sub

    Private Sub btnSalesHistory_Click(sender As Object, e As EventArgs) Handles btnSALESHISTORY.Click
        ShowChildForm(New frmSalesHIstory())
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ShowChildForm(New User())
    End Sub

    ' --- 5. Logout Logic ---
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Show the login form and close this main frame
            Dim login As New FrmLogin
            login.Show()
            Close()
        End If
    End Sub
    ' Logic for the Upload Pictures Button
    Private Sub btnuploadpictures_Click(sender As Object, e As EventArgs) Handles btnuploadpictures.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Images|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim newImg = Image.FromFile(ofd.FileName)
                PictureBox1.Image = newImg

                ' 1. Save to DB
                If db.SaveSystemImage("StoreLogo", newImg) Then
                    ' 2. SYNC OPEN FORMS IMMEDIATELY
                    ' This loops through all currently open windows and updates their PictureBox
                    For Each f As Form In Application.OpenForms
                        ' Look for a PictureBox named "PictureBox1" 
                        Dim targetPB = f.Controls.Find("PictureBox1", True).FirstOrDefault()
                        If targetPB IsNot Nothing AndAlso TypeOf targetPB Is PictureBox Then
                            DirectCast(targetPB, PictureBox).Image = newImg
                        End If
                    Next

                    MessageBox.Show("Logo synced across all open forms!")
                End If
            End If
        End Using
    End Sub
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = IO.Path.Combine(Application.StartupPath, "Backups")
        ofd.Filter = "SQLite Database (*.db)|*.db"
        ofd.Title = "Select a Backup to Restore"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim result = MessageBox.Show("Are you sure? This will overwrite all current data!",
                                       "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If db.RestoreDatabase(ofd.FileName) Then
                    MessageBox.Show("System restored successfully! The app will now restart.")
                    Application.Restart() ' Restart to reload the new data
                End If
            End If
        End If
    End Sub
End Class
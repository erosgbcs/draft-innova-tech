Public Module GlobalData
    ' This stores the username and role (Owner, Admin, or Staff)
    Public Property CurrentUser As String = ""
    Public Property UserRole As String = ""

    ' Add this to a Module or your DatabaseHelper
    Public Sub SyncFormLogo(pb As PictureBox)
        Dim db As New DatabaseHelper()
        Dim savedLogo = db.LoadSystemImage("StoreLogo")
        If savedLogo IsNot Nothing Then
            pb.Image = savedLogo
            pb.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Module
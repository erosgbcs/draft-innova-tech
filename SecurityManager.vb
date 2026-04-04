Public Module SecurityManager
    Public Sub ApplyRestrictions(ByRef frm As Form)
        ' Define which roles are restricted
        If GlobalData.UserRole = "Staff" Then
            ' Find the button named "btnUsers" anywhere on the form
            Dim btnUsers = frm.Controls.Find("btnUsers", True).FirstOrDefault()

            ' If the button exists on this form, hide it
            If btnUsers IsNot Nothing Then
                btnUsers.Visible = False
            End If

            ' You can add more buttons here, like btnReports or btnDelete
        End If
    End Sub
End Module
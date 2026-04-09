Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Windows.Forms
Imports System.Text

Namespace My
    Partial Friend Class MyApplication

        ' Application startup logging (optional)
        Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
            Try
                Dim logPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "app_start.log")
                File.AppendAllText(logPath, $"{DateTime.Now:u} - Application starting{Environment.NewLine}")
            Catch
                ' ignore
            End Try
        End Sub

        ' Capture unhandled exceptions (UI and non-UI threads)
        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try
                Dim ex = e.Exception
                Dim sb As New StringBuilder()
                sb.AppendLine($"[{DateTime.Now:u}] Unhandled exception")
                sb.AppendLine("Message: " & ex.Message)
                sb.AppendLine("Type: " & ex.GetType().FullName)
                sb.AppendLine("StackTrace:")
                sb.AppendLine(ex.StackTrace)
                If ex.InnerException IsNot Nothing Then
                    sb.AppendLine()
                    sb.AppendLine("Inner Exception:")
                    sb.AppendLine(ex.InnerException.ToString())
                End If

                Dim logPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "crash.log")
                File.AppendAllText(logPath, sb.ToString() & Environment.NewLine & New String("-"c, 80) & Environment.NewLine)

                MessageBox.Show("An unhandled error occurred. Check crash.log in the application folder for details.", "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch
                ' best-effort only
            Finally
                e.ExitApplication = True
            End Try
        End Sub
    End Class
End Namespace

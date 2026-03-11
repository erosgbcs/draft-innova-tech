Imports System.Drawing
Imports System.Text
Imports System.IO  ' <--- THIS WAS MISSING!

Public Class frmPOS

    ' --- YOUR EXISTING POS EVENTS ---

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Logic for Label2
    End Sub

    ' ... (Keeping your other events as they are) ...

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt")
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    ' --- FIXED EXPORT BUTTON ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 1. Setup the Save File Dialog
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.Title = "Save Inventory Export"
        sfd.FileName = "Inventory_Data.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' 2. Reference your DataGridView
                ' IMPORTANT: Ensure your grid is actually named DataGridView1
                Dim grid As DataGridView = DataGridView1
                Dim sb As New StringBuilder()

                ' 3. Create Column Headers
                Dim headers = From col As DataGridViewColumn In grid.Columns.Cast(Of DataGridViewColumn)()
                              Select col.HeaderText
                sb.AppendLine(String.Join(",", headers))

                ' 4. Loop through Rows
                For Each row As DataGridViewRow In grid.Rows
                    If Not row.IsNewRow Then
                        ' Clean data by replacing any existing commas with a space 
                        Dim cells = From cell As DataGridViewCell In row.Cells.Cast(Of DataGridViewCell)()
                                    Select If(cell.Value IsNot Nothing, cell.Value.ToString().Replace(",", " "), "")

                        sb.AppendLine(String.Join(",", cells))
                    End If
                Next

                ' 5. Save the file (Using System.IO.File to be 100% safe)
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)

                MessageBox.Show("Export Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
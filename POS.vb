Imports System.Drawing
Imports System.Text
Imports System.IO
Imports System.Linq

Public Class frmPOS

    ' Global variable para sa tracking
    Private currentWeekStartDate As DateTime

    ' --- FORM LOAD ---
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        ' 1. Automatic: I-set ang picker sa Sunday ng kasalukuyang linggo
        Dim today As DateTime = DateTime.Today
        Dim diff As Integer = today.DayOfWeek
        currentWeekStartDate = today.AddDays(-diff)

        ' I-update ang UI controls
        DateTimePicker1.Value = currentWeekStartDate
        UpdateWeekLabel()
        LoadData()
    End Sub

    ' --- TIMER LOGIC ---
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt")
    End Sub

    ' --- DATETIMEPICKER LOGIC ---
    ' Kapag binago mo ang date sa picker, mag-uupdate dapat ang report
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Kapag namili ang user ng kahit anong araw, i-snap natin sa Sunday ng linggong iyon
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim diff As Integer = selectedDate.DayOfWeek
        currentWeekStartDate = selectedDate.AddDays(-diff)

        UpdateWeekLabel()
        LoadData()
    End Sub

    ' --- REFRESH BUTTON ---
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
        MessageBox.Show("Report Refreshed!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- NAVIGATION BUTTONS ---

    Private Sub btnPreviousWeek_Click(sender As Object, e As EventArgs) Handles btnPreviousWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(-7)
        DateTimePicker1.Value = currentWeekStartDate ' Ito ang magti-trigger ng ValueChanged
    End Sub

    Private Sub btnNextWeek_Click(sender As Object, e As EventArgs) Handles btnNextWeek.Click
        currentWeekStartDate = currentWeekStartDate.AddDays(7)
        DateTimePicker1.Value = currentWeekStartDate ' Ito ang magti-trigger ng ValueChanged
    End Sub

    ' --- HELPER METHODS ---

    Private Sub UpdateWeekLabel()
        ' I-update ang label (halimbawa: Label13 o yung text na "UpdateWeekLabel" sa screenshot)
        Dim endOfWeek = currentWeekStartDate.AddDays(6)
        Label13.Text = currentWeekStartDate.ToString("MMM dd") & " - " & endOfWeek.ToString("MMM dd, yyyy")
    End Sub

    Private Sub LoadData()
        ' Dito papasok ang logic para i-filter ang Data sa Revenue Summary at Sales Performance
        ' Gamitin ang currentWeekStartDate para sa SQL query
        Console.WriteLine("Fetching sales from " & currentWeekStartDate.ToShortDateString())
    End Sub

    ' --- EXPORT CSV BUTTON (mula sa naunang usapan) ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files (*.csv)|*.csv"
        sfd.FileName = "Weekly_Sales_" & currentWeekStartDate.ToString("yyyyMMdd") & ".csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New StringBuilder()
                ' Headers
                Dim headers = From col As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                              Select col.HeaderText
                sb.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim cells = From cell As DataGridViewCell In row.Cells.Cast(Of DataGridViewCell)()
                                    Select If(cell.Value IsNot Nothing, cell.Value.ToString().Replace(",", " "), "")
                        sb.AppendLine(String.Join(",", cells))
                    End If
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                MessageBox.Show("Export Successful!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

End Class
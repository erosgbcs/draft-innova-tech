Public Class frmPOS

    ' Flag to prevent overlapping refresh calls
    Private isLoading As Boolean = False

    ' FORM LOAD
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer settings (in case not set in designer)
        Timer1.Interval = 1000   ' 1 second
        Timer1.Enabled = False

        ' Start timer
        Timer1.Start()

        ' Initial load
        LoadProducts()
    End Sub

    ' TIMER TICK EVENT (runs every 1 second)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' 1. Show real-time clock
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        ' 2. Auto refresh inventory every 5 seconds
        Static counter As Integer = 0
        counter += 1

        If counter >= 5 Then
            RefreshInventorySafe()
            counter = 0
        End If
    End Sub

    ' SAFE INVENTORY REFRESH (prevents UI freeze)
    Private Sub RefreshInventorySafe()
        If isLoading Then Exit Sub

        isLoading = True

        Try
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show("Error refreshing inventory: " & ex.Message)
        Finally
            isLoading = False
        End Try
    End Sub

    ' SAMPLE METHOD: LOAD PRODUCTS INTO GRID
    Private Sub LoadProducts()
        ' TODO: Replace with your actual database code

        ' Example:
        ' DataGridView1.DataSource = GetProductsFromDatabase()

        ' Dummy placeholder:
        Console.WriteLine("Products refreshed at " & DateTime.Now.ToString())
    End Sub
End Class


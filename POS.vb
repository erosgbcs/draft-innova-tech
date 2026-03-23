Imports System.IO

Public Class frmPOS
    ' Centralized Data Table (Dito nanggagaling lahat ng data)
    Private dtInventory As New DataTable()

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Setup Columns (Gawin lang ito kung wala pang columns ang DataTable)
        If dtInventory.Columns.Count = 0 Then
            dtInventory.Columns.Add("ProductCode")
            dtInventory.Columns.Add("ProductName")
            dtInventory.Columns.Add("Category")
            dtInventory.Columns.Add("Price", GetType(Decimal))
            dtInventory.Columns.Add("Stock", GetType(Integer))
        End If

        ' 2. I-bind ang dgvProducts sa DataTable
        dgvProducts.DataSource = dtInventory

        ' 3. Simulan ang Timer para sa Clock
        Timer1.Interval = 1000
        Timer1.Start()

        ' Load existing cards kung meron man
        DisplayProductCards()
    End Sub

    ' --- ADD PRODUCT ---
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim price As Decimal
        Dim stock As Integer

        ' Step 1: Validation (Bawal empty)
        If String.IsNullOrWhiteSpace(txtProductCode.Text) OrElse String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Pakisulat ang Product Code at Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Step 2: Strict Number Validation (Dito mag-eerror pag hindi number ang Price/Stock)
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Mali ang Price! Maglagay ng tamang numero.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Focus()
            Return
        End If

        If Not Integer.TryParse(txtStock.Text, stock) Then
            MessageBox.Show("Mali ang Stock! Whole number dapat.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStock.Focus()
            Return
        End If

        Try
            ' Step 3: Dagdag sa DataTable (Auto-update na ang dgvProducts dito)
            dtInventory.Rows.Add(txtProductCode.Text, txtProductName.Text, txtCategory.Text, price, stock)

            ' Step 4: I-update ang flpProducts1 (Dito lalabas yung card)
            DisplayProductCards()

            ClearFields()
            MessageBox.Show("Product added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- DYNAMIC PRODUCT CARDS (Lalabas sa flpProducts1) ---
    Private Sub DisplayProductCards()
        ' Linisin muna ang panel para hindi magdoble-doble
        flpProduct1.Controls.Clear()

        For Each row As DataRow In dtInventory.Rows
            ' Gawa ng Container (Yung puting box)
            Dim pnlCard As New Panel()
            pnlCard.Size = New Size(200, 160) ' Size ng box
            pnlCard.BackColor = Color.White
            pnlCard.BorderStyle = BorderStyle.FixedSingle
            pnlCard.Margin = New Padding(10)

            ' Label para sa Product Name
            Dim lblName As New Label With {
                .Text = row("ProductName").ToString().ToUpper(),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .Dock = DockStyle.Top,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Height = 30
            }

            ' Label para sa Price
            Dim lblPrice As New Label With {
                .Text = "Price: ₱" & Decimal.Parse(row("Price")).ToString("N2"),
                .Location = New Point(10, 45),
                .AutoSize = True
            }

            ' Label para sa Stock
            Dim lblStock As New Label With {
                .Text = "Stock: " & row("Stock").ToString(),
                .Location = New Point(10, 75),
                .AutoSize = True
            }

            ' Checkout Button
            Dim btnCheck As New Button With {
                .Text = "Checkout",
                .Size = New Size(120, 35),
                .Location = New Point(40, 110),
                .BackColor = Color.FromArgb(0, 122, 204),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }

            ' Click function ng Checkout button
            AddHandler btnCheck.Click, Sub()
                                           MessageBox.Show("Product: " & row("ProductName").ToString() & vbCrLf & "Price: ₱" & row("Price").ToString(), "Checkout Info")
                                       End Sub

            ' Ilagay ang lahat ng items sa loob ng panel
            pnlCard.Controls.Add(btnCheck)
            pnlCard.Controls.Add(lblStock)
            pnlCard.Controls.Add(lblPrice)
            pnlCard.Controls.Add(lblName)

            ' I-add ang buong box sa FlowLayoutPanel
            flpProduct1.Controls.Add(pnlCard)
        Next
    End Sub

    ' --- UPDATE PRODUCT ---
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim foundRow As DataRow() = dtInventory.Select("ProductCode = '" & txtProductCode.Text & "'")

        If foundRow.Length > 0 Then
            Dim price As Decimal
            Dim stock As Integer

            If Decimal.TryParse(txtPrice.Text, price) AndAlso Integer.TryParse(txtStock.Text, stock) Then
                foundRow(0)("ProductName") = txtProductName.Text
                foundRow(0)("Category") = txtCategory.Text
                foundRow(0)("Price") = price
                foundRow(0)("Stock") = stock

                DisplayProductCards() ' Refresh cards
                MessageBox.Show("Product updated!")
            End If
        End If
    End Sub

    ' --- DELETE PRODUCT ---
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim foundRow As DataRow() = dtInventory.Select("ProductCode = '" & txtProductCode.Text & "'")
        If foundRow.Length > 0 Then
            dtInventory.Rows.Remove(foundRow(0))
            DisplayProductCards() ' Refresh cards
            ClearFields()
            MessageBox.Show("Deleted!")
        End If
    End Sub

    ' --- EXPORT CSV ---
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles BtnExportcsv.Click
        If dtInventory.Rows.Count = 0 Then Return

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File (*.csv)|*.csv"
        sfd.FileName = "POS_Inventory_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New System.Text.StringBuilder()
                ' Header
                sb.AppendLine("Code,Product,Category,Price,Stock")
                ' Rows
                For Each row As DataRow In dtInventory.Rows
                    sb.AppendLine($"{row("ProductCode")},{row("ProductName")},{row("Category")},{row("Price")},{row("Stock")}")
                Next
                File.WriteAllText(sfd.FileName, sb.ToString())
                MessageBox.Show("Data printed to CSV file!")
            Catch ex As Exception
                MessageBox.Show("Error printing: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- SEARCH ---
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dtInventory.DefaultView.RowFilter = String.Format("ProductCode LIKE '%{0}%' OR ProductName LIKE '%{0}%'", txtSearch.Text)
        ' Note: Kung gusto mong pati Cards ay ma-filter, kailangang i-loop ang flpProducts1 controls.
    End Sub

    Private Sub ClearFields()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class
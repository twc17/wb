Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'WbDataSet1.Table2' table.
        Me.Table2TableAdapter1.Fill(Me.WbDataSet1.Table2)
        'This line of code loads data into the 'WbDataSet1.Table1' table.
        Me.Table1TableAdapter.Fill(Me.WbDataSet1.Table1)

        'Sorts the table in descending order of last date modify
        Me.DataGridView1.Sort(DataGridView1.Columns(5), System.ComponentModel.ListSortDirection.Descending)
        Me.DataGridView2.Sort(DataGridView2.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ' Get all cell values from selected row
        Dim Submitter As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim TicketNum As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim Critical As Boolean = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim Type As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim Description As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Dim Resolved As Boolean = DataGridView1.Rows(e.RowIndex).Cells(6).Value

        'Display the selected rows data
        Form2.Show()
        Form2.TextBox4.Text = TicketNum
        Form2.TextBox4.ReadOnly = True
        Form2.TextBox5.Text = Submitter
        Form2.ComboBox1.Text = Type
        Form2.ComboBox1.Enabled = False
        Form2.TextBox7.Text = Description
        Form2.TextBox7.ReadOnly = True
        Form2.CheckBox1.Checked = Resolved
        Form2.CheckBox1.Enabled = False
        Form2.Button1.Visible = False
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        ' Get all cell values from selected row
        Dim ID As String = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Dim Submitter As String = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Dim Description As String = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        Dim Resolved As Boolean = DataGridView2.Rows(e.RowIndex).Cells(4).Value

        'Display the selected rows data
        Form2.Show()
        Form2.TextBox5.Text = Submitter
        Form2.TextBox5.ReadOnly = True
        Form2.TextBox4.Text = ID
        Form2.TextBox4.ReadOnly = True
        Form2.ComboBox1.Text = "Note"
        Form2.ComboBox1.Enabled = False
        Form2.CheckBox1.Checked = Resolved
        Form2.CheckBox1.Enabled = False
        Form2.TextBox7.Text = Description
        Form2.TextBox7.ReadOnly = True
        Form2.Button1.Visible = False
    End Sub
End Class
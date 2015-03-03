Imports System.Data.OleDb

Public Class Form1

    'Need to have a starting date to compare to.
    Dim lastDate As Date = #12/12/2012 12:12:12 PM#

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Timer1.Tick
        'This line of code loads data into the 'WbDataSet.Table2' table.
        Me.Table2TableAdapter.Fill(Me.WbDataSet.Table2)
        'This line of code loads data into the 'WbDataSet.Table1' table.
        Me.Table1TableAdapter.Fill(Me.WbDataSet.Table1)

        'Sorts the table in descending order of last date modify
        Me.DataGridView1.Sort(DataGridView1.Columns(5), System.ComponentModel.ListSortDirection.Descending)
        Me.DataGridView2.Sort(DataGridView2.Columns(1), System.ComponentModel.ListSortDirection.Descending)

        'Pull top dates from each table
        Dim topTicketDate As Date = DataGridView1.Rows(0).Cells(5).Value
        Dim topNoteDate As Date = DataGridView2.Rows(0).Cells(1).Value

        'Compare to see which date is more recent, then displays the notification for it.
        If (Date.Compare(topTicketDate, topNoteDate) < 0) Then
            If (Date.Compare(topNoteDate, lastDate) > 0) Then
                lastDate = DataGridView2.Rows(0).Cells(1).Value
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipTitle = "Note #" & DataGridView2.Rows(0).Cells(3).Value
                NotifyIcon1.BalloonTipText = DataGridView2.Rows(0).Cells(0).Value
                NotifyIcon1.ShowBalloonTip(30000)
            End If
        ElseIf (Date.Compare(topTicketDate, lastDate) > 0) Then
            lastDate = DataGridView1.Rows(0).Cells(5).Value
            If DataGridView1.Rows(0).Cells(2).Value Then
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
            Else
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
            End If
            NotifyIcon1.BalloonTipTitle = "Ticket #" & DataGridView1.Rows(0).Cells(1).Value
            NotifyIcon1.BalloonTipText = DataGridView1.Rows(0).Cells(4).Value
            NotifyIcon1.ShowBalloonTip(30000)
        End If
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        'When users clicks on the button labled Quit, the program closes
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Cancel Closing:
        e.Cancel = True

        'Minimize the form:
        Me.WindowState = FormWindowState.Minimized

        'Don't show in the task bar
        Me.ShowInTaskbar = False

        'Enable the Context Menu Strip
        ContextMenuStrip1.Enabled = True
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click, NotifyIcon1.DoubleClick
        'When Show menu clicks, it will show the form:
        Me.WindowState = FormWindowState.Normal

        'Show in the task bar:
        Me.ShowInTaskbar = True

        'Disable the Context Menu:
        ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Right click on StripMenuItem and select Quit, will close the application
        End
    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        'If user tries to minimize window, hide in taskbar and move to context menu strip
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
            ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles NewTicket.Click
        'When creating a new ticket, load a blank form
        Form2.Show()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        ' When user clicks on balloon tip, it will open the window with the ticket information and be able to edit it.
        Form2.Show()
        If NotifyIcon1.BalloonTipIcon.Equals(ToolTipIcon.Info) Then
            'If the note is resolved, make everything read only
            If Table2TableAdapter.IsResolved(Mid(NotifyIcon1.BalloonTipTitle, (NotifyIcon1.BalloonTipTitle.IndexOf("#") + 2))) Then
                Form2.TextBox7.ReadOnly = True
                Form2.CheckBox1.Checked = True
                Form2.CheckBox1.Enabled = False
                Form2.Button1.Visible = False
            End If
            Form2.ComboBox1.Text = "Note"
        ElseIf Table1TableAdapter.IsResolved(Mid(NotifyIcon1.BalloonTipTitle, (NotifyIcon1.BalloonTipTitle.IndexOf("#") + 2))) Then
            'If the ticket is resolved, make everything read only
            Form2.TextBox7.ReadOnly = True
            Form2.CheckBox1.Checked = True
            Form2.CheckBox1.Enabled = False
            Form2.Button1.Visible = False
        End If

        If NotifyIcon1.BalloonTipIcon.Equals(ToolTipIcon.Warning) Then
            Form2.ComboBox1.Text = "Problem"
        Else
            Form2.ComboBox1.Text = "Critical"
        End If
        Form2.TextBox7.Text = NotifyIcon1.BalloonTipText
        Form2.ComboBox1.Enabled = False
        Form2.TextBox4.Text = Mid(NotifyIcon1.BalloonTipTitle, (NotifyIcon1.BalloonTipTitle.IndexOf("#") + 2))
        Form2.TextBox4.ReadOnly = True
        Form2.Button1.Text = "Update"
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ' Get all cell values from selected row
        If (e.RowIndex >= 0) Then
            Dim Submitter As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim TicketNum As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Dim Critical As Boolean = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim Type As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            Dim Description As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value

            'Display the selected rows data
            Form2.Show()
            Form2.TextBox4.Text = TicketNum
            Form2.TextBox4.ReadOnly = True
            Form2.TextBox5.Text = Submitter
            Form2.ComboBox1.Text = Type
            Form2.ComboBox1.Enabled = False
            Form2.TextBox7.Text = Description
            Form2.Button1.Text = "Update"
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        ' Get all cell values from selected row
        If (e.RowIndex >= 0) Then
            Dim Description As String = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            Dim ID As String = DataGridView2.Rows(e.RowIndex).Cells(3).Value
            Dim Submitter As String = DataGridView2.Rows(e.RowIndex).Cells(4).Value

            'Display the selected rows data
            Form2.Show()
            Form2.TextBox5.Text = Submitter
            Form2.TextBox4.Text = ID
            Form2.TextBox4.ReadOnly = True
            Form2.ComboBox1.Text = "Note"
            Form2.ComboBox1.Enabled = False
            Form2.TextBox7.Text = Description
            Form2.Button1.Text = "Update"
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        For Each Row As DataGridViewRow In CType(sender, DataGridView).Rows
            ' Only show tickets that have not been resolved
            If Row.Cells(6).Value.Equals(True) Then
                DataGridView1.CurrentCell = Nothing
                Row.Visible = False
            End If
        Next
    End Sub

    Private Sub ViewPastTickets_Click(sender As Object, e As EventArgs) Handles ViewPastTickets.Click
        'When the user wants to view past tickets, show the correct form
        Form3.Show()
        Form3.TopMost = True
    End Sub

    Private Sub DataGridView2_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete
        For Each Row As DataGridViewRow In CType(sender, DataGridView).Rows
            ' Only show tickets that have not been resolved
            If Row.Cells(2).Value.Equals(True) Then
                DataGridView2.CurrentCell = Nothing
                Row.Visible = False
            End If
        Next
    End Sub
End Class

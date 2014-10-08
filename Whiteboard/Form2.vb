Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Text = Environment.UserName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim crit As String

        If ComboBox1.Text.Equals("Critical") Then
            crit = True
        Else
            crit = False
        End If

        If (Button1.Text.Equals("Submit")) Then
            If ComboBox1.Text.Equals("Note") Then
                Form1.Table2TableAdapter.InsertQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox5.Text)
                Form1.TestDataSet.AcceptChanges()
                Me.Close()
            ElseIf (Form1.Table1TableAdapter.SearchTicket(TextBox4.Text) = 0) Then
                Form1.Table1TableAdapter.InsertQuery(TextBox5.Text, TextBox4.Text, crit, ComboBox1.Text, TextBox7.Text, DateAndTime.Now, CheckBox1.Checked)
                Form1.TestDataSet.AcceptChanges()
                Me.Close()
            Else
                MsgBox("Ticket Already Exists, Please Use Update Feature")
            End If

        ElseIf (ComboBox1.Text.Equals("Note")) Then
            Form1.Table2TableAdapter.UpdateQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox4.Text)
            Close()
        Else
            Form1.Table1TableAdapter.UpdateQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox4.Text)
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
﻿Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load, set the submitter field to the username of the logged in Windows user
        TextBox5.Text = Environment.UserName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim crit As String

        If ComboBox1.Text.Equals("Critical") Then
            'Check to see if it's a crit, before constructing any sql querey
            crit = True
        Else
            crit = False
        End If

        If (Button1.Text.Equals("Submit")) Then
            If (String.IsNullOrEmpty(TextBox7.Text)) Then
                'Check to make sure user entered a description before submitting
                MsgBox("You MUST enter a description when submitting a ticket")

            Else

                'If you're submitting a ticket, and not updating one.
                If ComboBox1.Text.Equals("Note") Then
                    'Note ticket numbers are auto generate, no need to check against DB, okay to create new entry
                    Form1.Table2TableAdapter.InsertQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox5.Text)
                    Form1.WbDataSet.AcceptChanges()
                    Me.Close()
                ElseIf (TextBox4.TextLength = 0) Then
                    'Check to see if a ticket number was entered, before trying to execute sql query
                    MsgBox("You must enter a ticket number when submitting a problem or critical ticket")
                ElseIf (Form1.Table1TableAdapter.SearchTicket(TextBox4.Text) = 0) Then
                    'Check to see if the ticket number has already been used
                    'If it hasn't been used, create a new entry in the DB
                    Form1.Table1TableAdapter.InsertQuery(TextBox5.Text, TextBox4.Text, crit, ComboBox1.Text, TextBox7.Text, DateAndTime.Now, CheckBox1.Checked)
                    Form1.WbDataSet.AcceptChanges()
                    Me.Close()
                Else
                    MsgBox("Ticket Already Exists, Please Use Update Feature")
                End If
            End If

        ElseIf (ComboBox1.Text.Equals("Note")) Then
            'If you're updating a note... execute the sql querey
            Form1.Table2TableAdapter.UpdateQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox4.Text)
            Close()

        Else
            'Else... you're updating an existing ticket with the sql query
            Form1.Table1TableAdapter.UpdateQuery(TextBox7.Text, DateAndTime.Now, CheckBox1.Checked, TextBox4.Text)
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        'Only integer values are allowed in the Ticket Number field
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class
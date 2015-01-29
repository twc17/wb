<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SubmitterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResolvedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WbDataSet = New Whiteboard.wbDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.OtherNotesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifiedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResolvedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubmitterDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewTicket = New System.Windows.Forms.Button()
        Me.ViewPastTickets = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OtherNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1TableAdapter = New Whiteboard.wbDataSetTableAdapters.Table1TableAdapter()
        Me.Table2TableAdapter = New Whiteboard.wbDataSetTableAdapters.Table2TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubmitterDataGridViewTextBoxColumn, Me.TicketNumberDataGridViewTextBoxColumn, Me.CriticalDataGridViewCheckBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LastModifiedDataGridViewTextBoxColumn, Me.ResolvedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 250)
        Me.DataGridView1.TabIndex = 0
        '
        'SubmitterDataGridViewTextBoxColumn
        '
        Me.SubmitterDataGridViewTextBoxColumn.DataPropertyName = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn.HeaderText = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn.Name = "SubmitterDataGridViewTextBoxColumn"
        Me.SubmitterDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubmitterDataGridViewTextBoxColumn.Width = 80
        '
        'TicketNumberDataGridViewTextBoxColumn
        '
        Me.TicketNumberDataGridViewTextBoxColumn.DataPropertyName = "Ticket Number"
        Me.TicketNumberDataGridViewTextBoxColumn.HeaderText = "Ticket Number"
        Me.TicketNumberDataGridViewTextBoxColumn.Name = "TicketNumberDataGridViewTextBoxColumn"
        Me.TicketNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CriticalDataGridViewCheckBoxColumn
        '
        Me.CriticalDataGridViewCheckBoxColumn.DataPropertyName = "Critical"
        Me.CriticalDataGridViewCheckBoxColumn.HeaderText = "Critical"
        Me.CriticalDataGridViewCheckBoxColumn.Name = "CriticalDataGridViewCheckBoxColumn"
        Me.CriticalDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CriticalDataGridViewCheckBoxColumn.Width = 50
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 80
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 600
        '
        'LastModifiedDataGridViewTextBoxColumn
        '
        Me.LastModifiedDataGridViewTextBoxColumn.DataPropertyName = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn.HeaderText = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn.Name = "LastModifiedDataGridViewTextBoxColumn"
        Me.LastModifiedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResolvedDataGridViewCheckBoxColumn
        '
        Me.ResolvedDataGridViewCheckBoxColumn.DataPropertyName = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn.HeaderText = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn.Name = "ResolvedDataGridViewCheckBoxColumn"
        Me.ResolvedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ResolvedDataGridViewCheckBoxColumn.Visible = False
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.WbDataSet
        '
        'WbDataSet
        '
        Me.WbDataSet.DataSetName = "wbDataSet"
        Me.WbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OtherNotesDataGridViewTextBoxColumn1, Me.LastModifiedDataGridViewTextBoxColumn1, Me.ResolvedDataGridViewCheckBoxColumn1, Me.IDDataGridViewTextBoxColumn, Me.SubmitterDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.Table2BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 281)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView2.Size = New System.Drawing.Size(1010, 179)
        Me.DataGridView2.TabIndex = 1
        '
        'OtherNotesDataGridViewTextBoxColumn1
        '
        Me.OtherNotesDataGridViewTextBoxColumn1.DataPropertyName = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn1.HeaderText = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn1.Name = "OtherNotesDataGridViewTextBoxColumn1"
        Me.OtherNotesDataGridViewTextBoxColumn1.Width = 910
        '
        'LastModifiedDataGridViewTextBoxColumn1
        '
        Me.LastModifiedDataGridViewTextBoxColumn1.DataPropertyName = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn1.HeaderText = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn1.Name = "LastModifiedDataGridViewTextBoxColumn1"
        '
        'ResolvedDataGridViewCheckBoxColumn1
        '
        Me.ResolvedDataGridViewCheckBoxColumn1.DataPropertyName = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn1.HeaderText = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn1.Name = "ResolvedDataGridViewCheckBoxColumn1"
        Me.ResolvedDataGridViewCheckBoxColumn1.Visible = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'SubmitterDataGridViewTextBoxColumn1
        '
        Me.SubmitterDataGridViewTextBoxColumn1.DataPropertyName = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn1.HeaderText = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn1.Name = "SubmitterDataGridViewTextBoxColumn1"
        Me.SubmitterDataGridViewTextBoxColumn1.Visible = False
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.WbDataSet
        '
        'NewTicket
        '
        Me.NewTicket.BackColor = System.Drawing.SystemColors.ControlDark
        Me.NewTicket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewTicket.Location = New System.Drawing.Point(486, 466)
        Me.NewTicket.Name = "NewTicket"
        Me.NewTicket.Size = New System.Drawing.Size(157, 43)
        Me.NewTicket.TabIndex = 2
        Me.NewTicket.Text = "New Ticket"
        Me.NewTicket.UseVisualStyleBackColor = True
        '
        'ViewPastTickets
        '
        Me.ViewPastTickets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewPastTickets.Location = New System.Drawing.Point(677, 466)
        Me.ViewPastTickets.Name = "ViewPastTickets"
        Me.ViewPastTickets.Size = New System.Drawing.Size(157, 43)
        Me.ViewPastTickets.TabIndex = 4
        Me.ViewPastTickets.Text = "View Past Tickets"
        Me.ViewPastTickets.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quit.Location = New System.Drawing.Point(865, 466)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(157, 43)
        Me.Quit.TabIndex = 5
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Whiteboard"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'OtherNotesDataGridViewTextBoxColumn
        '
        Me.OtherNotesDataGridViewTextBoxColumn.DataPropertyName = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.HeaderText = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.Name = "OtherNotesDataGridViewTextBoxColumn"
        Me.OtherNotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherNotesDataGridViewTextBoxColumn.Width = 500
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1042, 529)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.ViewPastTickets)
        Me.Controls.Add(Me.NewTicket)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Whiteboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NewTicket As System.Windows.Forms.Button
    Friend WithEvents ViewPastTickets As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmitterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticalDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResolvedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WbDataSet As Whiteboard.wbDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Whiteboard.wbDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2TableAdapter As Whiteboard.wbDataSetTableAdapters.Table2TableAdapter
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResolvedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmitterDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

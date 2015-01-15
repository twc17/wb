<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SubmitterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResolvedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubmitterDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifiedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResolvedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WbDataSet1 = New Whiteboard.wbDataSet()
        Me.Table1TableAdapter = New Whiteboard.wbDataSetTableAdapters.Table1TableAdapter()
        Me.Table2TableAdapter1 = New Whiteboard.wbDataSetTableAdapters.Table2TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubmitterDataGridViewTextBoxColumn, Me.TicketNumberDataGridViewTextBoxColumn, Me.CriticalDataGridViewCheckBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LastModifiedDataGridViewTextBoxColumn, Me.ResolvedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1000, 250)
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
        Me.DescriptionDataGridViewTextBoxColumn.Width = 500
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
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.WbDataSet1
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SubmitterDataGridViewTextBoxColumn1, Me.OtherNotesDataGridViewTextBoxColumn, Me.LastModifiedDataGridViewTextBoxColumn1, Me.ResolvedDataGridViewCheckBoxColumn1})
        Me.DataGridView2.DataSource = Me.Table2BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 268)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.Size = New System.Drawing.Size(1000, 250)
        Me.DataGridView2.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'SubmitterDataGridViewTextBoxColumn1
        '
        Me.SubmitterDataGridViewTextBoxColumn1.DataPropertyName = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn1.HeaderText = "Submitter"
        Me.SubmitterDataGridViewTextBoxColumn1.Name = "SubmitterDataGridViewTextBoxColumn1"
        Me.SubmitterDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'OtherNotesDataGridViewTextBoxColumn
        '
        Me.OtherNotesDataGridViewTextBoxColumn.DataPropertyName = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.HeaderText = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.Name = "OtherNotesDataGridViewTextBoxColumn"
        Me.OtherNotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherNotesDataGridViewTextBoxColumn.Width = 650
        '
        'LastModifiedDataGridViewTextBoxColumn1
        '
        Me.LastModifiedDataGridViewTextBoxColumn1.DataPropertyName = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn1.HeaderText = "Last Modified"
        Me.LastModifiedDataGridViewTextBoxColumn1.Name = "LastModifiedDataGridViewTextBoxColumn1"
        Me.LastModifiedDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ResolvedDataGridViewCheckBoxColumn1
        '
        Me.ResolvedDataGridViewCheckBoxColumn1.DataPropertyName = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn1.HeaderText = "Resolved"
        Me.ResolvedDataGridViewCheckBoxColumn1.Name = "ResolvedDataGridViewCheckBoxColumn1"
        Me.ResolvedDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.WbDataSet1
        '
        'WbDataSet1
        '
        Me.WbDataSet1.DataSetName = "wbDataSet"
        Me.WbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table2TableAdapter1
        '
        Me.Table2TableAdapter1.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1000, 527)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Past Tickets"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubmitterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TicketNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticalDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResolvedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmitterDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResolvedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WbDataSet1 As Whiteboard.wbDataSet
    Friend WithEvents Table1TableAdapter As Whiteboard.wbDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Table2TableAdapter1 As Whiteboard.wbDataSetTableAdapters.Table2TableAdapter
End Class

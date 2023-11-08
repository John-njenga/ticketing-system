<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BusesDataGridView = New System.Windows.Forms.DataGridView()
        Me.BusesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bus_ticketing_systemDataSet = New Trial.bus_ticketing_systemDataSet()
        Me.BusesTableAdapter = New Trial.bus_ticketing_systemDataSetTableAdapters.busesTableAdapter()
        Me.TableAdapterManager = New Trial.bus_ticketing_systemDataSetTableAdapters.TableAdapterManager()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BusesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bus_ticketing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BusesDataGridView
        '
        Me.BusesDataGridView.AllowUserToOrderColumns = True
        Me.BusesDataGridView.AutoGenerateColumns = False
        Me.BusesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BusesDataGridView.DataSource = Me.BusesBindingSource
        Me.BusesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.BusesDataGridView.Name = "BusesDataGridView"
        Me.BusesDataGridView.Size = New System.Drawing.Size(644, 232)
        Me.BusesDataGridView.TabIndex = 1
        '
        'BusesBindingSource
        '
        Me.BusesBindingSource.DataMember = "buses"
        Me.BusesBindingSource.DataSource = Me.Bus_ticketing_systemDataSet
        '
        'Bus_ticketing_systemDataSet
        '
        Me.Bus_ticketing_systemDataSet.DataSetName = "bus_ticketing_systemDataSet"
        Me.Bus_ticketing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusesTableAdapter
        '
        Me.BusesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.busesTableAdapter = Me.BusesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trial.bus_ticketing_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(255, 266)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(145, 31)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Current Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bus Type"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bus Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bus Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bus Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Reg No"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Reg No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fuel Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fuel Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "No of Seats"
        Me.DataGridViewTextBoxColumn5.HeaderText = "No of Seats"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'BusReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 319)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BusesDataGridView)
        Me.Name = "BusReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusReports"
        CType(Me.BusesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bus_ticketing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bus_ticketing_systemDataSet As bus_ticketing_systemDataSet
    Friend WithEvents BusesBindingSource As BindingSource
    Friend WithEvents BusesTableAdapter As bus_ticketing_systemDataSetTableAdapters.busesTableAdapter
    Friend WithEvents TableAdapterManager As bus_ticketing_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusesDataGridView As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

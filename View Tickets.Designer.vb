<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Tickets
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
        Me.Tickets_dataset = New Trial.tickets_dataset()
        Me.Query_ticketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_ticketsTableAdapter = New Trial.tickets_datasetTableAdapters.query_ticketsTableAdapter()
        Me.TableAdapterManager = New Trial.tickets_datasetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bus_ticketing_systemDataSet2 = New Trial.bus_ticketing_systemDataSet2()
        Me.TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketsTableAdapter = New Trial.bus_ticketing_systemDataSet2TableAdapters.TicketsTableAdapter()
        Me.TableAdapterManager1 = New Trial.bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager()
        Me.TicketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Tickets_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_ticketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bus_ticketing_systemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tickets_dataset
        '
        Me.Tickets_dataset.DataSetName = "tickets_dataset"
        Me.Tickets_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_ticketsBindingSource
        '
        Me.Query_ticketsBindingSource.DataMember = "query_tickets"
        Me.Query_ticketsBindingSource.DataSource = Me.Tickets_dataset
        '
        'Query_ticketsTableAdapter
        '
        Me.Query_ticketsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Trial.tickets_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete Ticket"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bus_ticketing_systemDataSet2
        '
        Me.Bus_ticketing_systemDataSet2.DataSetName = "bus_ticketing_systemDataSet2"
        Me.Bus_ticketing_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketsBindingSource
        '
        Me.TicketsBindingSource.DataMember = "Tickets"
        Me.TicketsBindingSource.DataSource = Me.Bus_ticketing_systemDataSet2
        '
        'TicketsTableAdapter
        '
        Me.TicketsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TicketsTableAdapter = Me.TicketsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Trial.bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TicketsDataGridView
        '
        Me.TicketsDataGridView.AutoGenerateColumns = False
        Me.TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TicketsDataGridView.DataSource = Me.TicketsBindingSource
        Me.TicketsDataGridView.Location = New System.Drawing.Point(12, 25)
        Me.TicketsDataGridView.Name = "TicketsDataGridView"
        Me.TicketsDataGridView.Size = New System.Drawing.Size(341, 220)
        Me.TicketsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ticket ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ticket ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Passenger Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Passenger Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Journey Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Journey Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'View_Tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 296)
        Me.Controls.Add(Me.TicketsDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "View_Tickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View_Tickets"
        CType(Me.Tickets_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_ticketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bus_ticketing_systemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tickets_dataset As tickets_dataset
    Friend WithEvents Query_ticketsBindingSource As BindingSource
    Friend WithEvents Query_ticketsTableAdapter As tickets_datasetTableAdapters.query_ticketsTableAdapter
    Friend WithEvents TableAdapterManager As tickets_datasetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Bus_ticketing_systemDataSet2 As bus_ticketing_systemDataSet2
    Friend WithEvents TicketsBindingSource As BindingSource
    Friend WithEvents TicketsTableAdapter As bus_ticketing_systemDataSet2TableAdapters.TicketsTableAdapter
    Friend WithEvents TableAdapterManager1 As bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TicketsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePassengers
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
        Me.Bus_ticketing_systemDataSet1 = New Trial.bus_ticketing_systemDataSet1()
        Me.PassengersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassengersTableAdapter = New Trial.bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter()
        Me.TableAdapterManager = New Trial.bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager()
        Me.PassengersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bus_ticketing_systemDataSet1
        '
        Me.Bus_ticketing_systemDataSet1.DataSetName = "bus_ticketing_systemDataSet1"
        Me.Bus_ticketing_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PassengersBindingSource
        '
        Me.PassengersBindingSource.DataMember = "Passengers"
        Me.PassengersBindingSource.DataSource = Me.Bus_ticketing_systemDataSet1
        '
        'PassengersTableAdapter
        '
        Me.PassengersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PassengersTableAdapter = Me.PassengersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trial.bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PassengersDataGridView
        '
        Me.PassengersDataGridView.AutoGenerateColumns = False
        Me.PassengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PassengersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PassengersDataGridView.DataSource = Me.PassengersBindingSource
        Me.PassengersDataGridView.Location = New System.Drawing.Point(12, 23)
        Me.PassengersDataGridView.Name = "PassengersDataGridView"
        Me.PassengersDataGridView.Size = New System.Drawing.Size(922, 220)
        Me.PassengersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Contact Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nationality"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nationality"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn8.HeaderText = "City"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Zipcode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Zipcode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EC Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EC Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Contact No"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Relationship"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Relationship"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete Passenger"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ManagePassengers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PassengersDataGridView)
        Me.Name = "ManagePassengers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagePassengers"
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bus_ticketing_systemDataSet1 As bus_ticketing_systemDataSet1
    Friend WithEvents PassengersBindingSource As BindingSource
    Friend WithEvents PassengersTableAdapter As bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter
    Friend WithEvents TableAdapterManager As bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PassengersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class

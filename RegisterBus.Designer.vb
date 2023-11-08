<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterBus
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
        Dim Bus_TypeLabel As System.Windows.Forms.Label
        Dim Bus_NameLabel As System.Windows.Forms.Label
        Dim Reg_NoLabel As System.Windows.Forms.Label
        Dim Fuel_TypeLabel As System.Windows.Forms.Label
        Dim No_of_SeatsLabel As System.Windows.Forms.Label
        Me.Bus_ticketing_systemDataSet = New Trial.bus_ticketing_systemDataSet()
        Me.BusesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusesTableAdapter = New Trial.bus_ticketing_systemDataSetTableAdapters.busesTableAdapter()
        Me.TableAdapterManager = New Trial.bus_ticketing_systemDataSetTableAdapters.TableAdapterManager()
        Me.BusesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Bus_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Bus_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Reg_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Fuel_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.No_of_SeatsTextBox = New System.Windows.Forms.TextBox()
        Bus_TypeLabel = New System.Windows.Forms.Label()
        Bus_NameLabel = New System.Windows.Forms.Label()
        Reg_NoLabel = New System.Windows.Forms.Label()
        Fuel_TypeLabel = New System.Windows.Forms.Label()
        No_of_SeatsLabel = New System.Windows.Forms.Label()
        CType(Me.Bus_ticketing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bus_TypeLabel
        '
        Bus_TypeLabel.AutoSize = True
        Bus_TypeLabel.Location = New System.Drawing.Point(3, 30)
        Bus_TypeLabel.Name = "Bus_TypeLabel"
        Bus_TypeLabel.Size = New System.Drawing.Size(55, 13)
        Bus_TypeLabel.TabIndex = 18
        Bus_TypeLabel.Text = "Bus Type:"
        '
        'Bus_NameLabel
        '
        Bus_NameLabel.AutoSize = True
        Bus_NameLabel.Location = New System.Drawing.Point(3, 57)
        Bus_NameLabel.Name = "Bus_NameLabel"
        Bus_NameLabel.Size = New System.Drawing.Size(59, 13)
        Bus_NameLabel.TabIndex = 20
        Bus_NameLabel.Text = "Bus Name:"
        '
        'Reg_NoLabel
        '
        Reg_NoLabel.AutoSize = True
        Reg_NoLabel.Location = New System.Drawing.Point(3, 83)
        Reg_NoLabel.Name = "Reg_NoLabel"
        Reg_NoLabel.Size = New System.Drawing.Size(47, 13)
        Reg_NoLabel.TabIndex = 22
        Reg_NoLabel.Text = "Reg No:"
        '
        'Fuel_TypeLabel
        '
        Fuel_TypeLabel.AutoSize = True
        Fuel_TypeLabel.Location = New System.Drawing.Point(3, 109)
        Fuel_TypeLabel.Name = "Fuel_TypeLabel"
        Fuel_TypeLabel.Size = New System.Drawing.Size(57, 13)
        Fuel_TypeLabel.TabIndex = 24
        Fuel_TypeLabel.Text = "Fuel Type:"
        '
        'No_of_SeatsLabel
        '
        No_of_SeatsLabel.AutoSize = True
        No_of_SeatsLabel.Location = New System.Drawing.Point(3, 136)
        No_of_SeatsLabel.Name = "No_of_SeatsLabel"
        No_of_SeatsLabel.Size = New System.Drawing.Size(66, 13)
        No_of_SeatsLabel.TabIndex = 26
        No_of_SeatsLabel.Text = "No of Seats:"
        '
        'Bus_ticketing_systemDataSet
        '
        Me.Bus_ticketing_systemDataSet.DataSetName = "bus_ticketing_systemDataSet"
        Me.Bus_ticketing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusesBindingSource
        '
        Me.BusesBindingSource.DataMember = "buses"
        Me.BusesBindingSource.DataSource = Me.Bus_ticketing_systemDataSet
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
        'BusesDataGridView
        '
        Me.BusesDataGridView.AutoGenerateColumns = False
        Me.BusesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BusesDataGridView.DataSource = Me.BusesBindingSource
        Me.BusesDataGridView.Location = New System.Drawing.Point(228, 27)
        Me.BusesDataGridView.Name = "BusesDataGridView"
        Me.BusesDataGridView.Size = New System.Drawing.Size(544, 229)
        Me.BusesDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bus Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bus Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bus Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bus Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Reg No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Reg No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fuel Type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fuel Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "No of Seats"
        Me.DataGridViewTextBoxColumn6.HeaderText = "No of Seats"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 195)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 32)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(104, 195)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Bus_TypeComboBox
        '
        Me.Bus_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusesBindingSource, "Bus Type", True))
        Me.Bus_TypeComboBox.FormattingEnabled = True
        Me.Bus_TypeComboBox.Location = New System.Drawing.Point(75, 27)
        Me.Bus_TypeComboBox.Name = "Bus_TypeComboBox"
        Me.Bus_TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Bus_TypeComboBox.TabIndex = 19
        '
        'Bus_NameTextBox
        '
        Me.Bus_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusesBindingSource, "Bus Name", True))
        Me.Bus_NameTextBox.Location = New System.Drawing.Point(75, 54)
        Me.Bus_NameTextBox.Name = "Bus_NameTextBox"
        Me.Bus_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Bus_NameTextBox.TabIndex = 21
        '
        'Reg_NoTextBox
        '
        Me.Reg_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusesBindingSource, "Reg No", True))
        Me.Reg_NoTextBox.Location = New System.Drawing.Point(75, 80)
        Me.Reg_NoTextBox.Name = "Reg_NoTextBox"
        Me.Reg_NoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Reg_NoTextBox.TabIndex = 23
        '
        'Fuel_TypeComboBox
        '
        Me.Fuel_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusesBindingSource, "Fuel Type", True))
        Me.Fuel_TypeComboBox.FormattingEnabled = True
        Me.Fuel_TypeComboBox.Location = New System.Drawing.Point(75, 106)
        Me.Fuel_TypeComboBox.Name = "Fuel_TypeComboBox"
        Me.Fuel_TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Fuel_TypeComboBox.TabIndex = 25
        '
        'No_of_SeatsTextBox
        '
        Me.No_of_SeatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusesBindingSource, "No of Seats", True))
        Me.No_of_SeatsTextBox.Location = New System.Drawing.Point(75, 133)
        Me.No_of_SeatsTextBox.Name = "No_of_SeatsTextBox"
        Me.No_of_SeatsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.No_of_SeatsTextBox.TabIndex = 27
        '
        'RegisterBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 292)
        Me.Controls.Add(Bus_TypeLabel)
        Me.Controls.Add(Me.Bus_TypeComboBox)
        Me.Controls.Add(Bus_NameLabel)
        Me.Controls.Add(Me.Bus_NameTextBox)
        Me.Controls.Add(Reg_NoLabel)
        Me.Controls.Add(Me.Reg_NoTextBox)
        Me.Controls.Add(Fuel_TypeLabel)
        Me.Controls.Add(Me.Fuel_TypeComboBox)
        Me.Controls.Add(No_of_SeatsLabel)
        Me.Controls.Add(Me.No_of_SeatsTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.BusesDataGridView)
        Me.Name = "RegisterBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterBus"
        CType(Me.Bus_ticketing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bus_ticketing_systemDataSet As bus_ticketing_systemDataSet
    Friend WithEvents BusesBindingSource As BindingSource
    Friend WithEvents BusesTableAdapter As bus_ticketing_systemDataSetTableAdapters.busesTableAdapter
    Friend WithEvents TableAdapterManager As bus_ticketing_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Bus_TypeComboBox As ComboBox
    Friend WithEvents Bus_NameTextBox As TextBox
    Friend WithEvents Reg_NoTextBox As TextBox
    Friend WithEvents Fuel_TypeComboBox As ComboBox
    Friend WithEvents No_of_SeatsTextBox As TextBox
End Class

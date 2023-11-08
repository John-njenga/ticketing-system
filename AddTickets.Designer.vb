<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddTickets
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
        Dim Passenger_NameLabel1 As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim Journey_NameLabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Source_LocationLabel As System.Windows.Forms.Label
        Dim Depature_TimeLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim Arrival_TimeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Passenger_NameLabel As System.Windows.Forms.Label
        Dim Journey_NameLabel As System.Windows.Forms.Label
        Me.Bus_ticketing_systemDataSet2 = New Trial.bus_ticketing_systemDataSet2()
        Me.TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketsTableAdapter = New Trial.bus_ticketing_systemDataSet2TableAdapters.TicketsTableAdapter()
        Me.TableAdapterManager = New Trial.bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Journey_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Passenger_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Bus_ticketing_systemDataSet1 = New Trial.bus_ticketing_systemDataSet1()
        Me.PassengersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassengersTableAdapter = New Trial.bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter()
        Me.TableAdapterManager1 = New Trial.bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager()
        Me.PassengersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Journeys = New Trial.Journeys()
        Me.JourneysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JourneysTableAdapter = New Trial.JourneysTableAdapters.journeysTableAdapter()
        Me.TableAdapterManager2 = New Trial.JourneysTableAdapters.TableAdapterManager()
        Me.JourneysDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Passenger_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Query_ticketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tickets_dataset = New Trial.tickets_dataset()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Journey_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Source_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Depature_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.Arrival_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Query_ticketsTableAdapter = New Trial.tickets_datasetTableAdapters.query_ticketsTableAdapter()
        Me.TableAdapterManager3 = New Trial.tickets_datasetTableAdapters.TableAdapterManager()
        Me.Query_ticketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Passenger_NameLabel1 = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        Journey_NameLabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Source_LocationLabel = New System.Windows.Forms.Label()
        Depature_TimeLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        Arrival_TimeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Passenger_NameLabel = New System.Windows.Forms.Label()
        Journey_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Bus_ticketing_systemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Query_ticketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tickets_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Query_ticketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Passenger_NameLabel1
        '
        Passenger_NameLabel1.AutoSize = True
        Passenger_NameLabel1.Location = New System.Drawing.Point(6, 36)
        Passenger_NameLabel1.Name = "Passenger_NameLabel1"
        Passenger_NameLabel1.Size = New System.Drawing.Size(74, 13)
        Passenger_NameLabel1.TabIndex = 0
        Passenger_NameLabel1.Text = "Passenger ID:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(6, 62)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 2
        GenderLabel.Text = "Gender:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Location = New System.Drawing.Point(6, 88)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(87, 13)
        Contact_NumberLabel.TabIndex = 4
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'Journey_NameLabel1
        '
        Journey_NameLabel1.AutoSize = True
        Journey_NameLabel1.Location = New System.Drawing.Point(22, 29)
        Journey_NameLabel1.Name = "Journey_NameLabel1"
        Journey_NameLabel1.Size = New System.Drawing.Size(61, 13)
        Journey_NameLabel1.TabIndex = 0
        Journey_NameLabel1.Text = "Journey ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(22, 56)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 2
        DateLabel.Text = "Date:"
        '
        'Source_LocationLabel
        '
        Source_LocationLabel.AutoSize = True
        Source_LocationLabel.Location = New System.Drawing.Point(22, 81)
        Source_LocationLabel.Name = "Source_LocationLabel"
        Source_LocationLabel.Size = New System.Drawing.Size(88, 13)
        Source_LocationLabel.TabIndex = 4
        Source_LocationLabel.Text = "Source Location:"
        '
        'Depature_TimeLabel
        '
        Depature_TimeLabel.AutoSize = True
        Depature_TimeLabel.Location = New System.Drawing.Point(22, 107)
        Depature_TimeLabel.Name = "Depature_TimeLabel"
        Depature_TimeLabel.Size = New System.Drawing.Size(80, 13)
        Depature_TimeLabel.TabIndex = 6
        Depature_TimeLabel.Text = "Depature Time:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(22, 133)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(63, 13)
        DestinationLabel.TabIndex = 8
        DestinationLabel.Text = "Destination:"
        '
        'Arrival_TimeLabel
        '
        Arrival_TimeLabel.AutoSize = True
        Arrival_TimeLabel.Location = New System.Drawing.Point(22, 159)
        Arrival_TimeLabel.Name = "Arrival_TimeLabel"
        Arrival_TimeLabel.Size = New System.Drawing.Size(65, 13)
        Arrival_TimeLabel.TabIndex = 10
        Arrival_TimeLabel.Text = "Arrival Time:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(22, 185)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 12
        PriceLabel.Text = "Price:"
        '
        'Passenger_NameLabel
        '
        Passenger_NameLabel.AutoSize = True
        Passenger_NameLabel.Location = New System.Drawing.Point(7, 18)
        Passenger_NameLabel.Name = "Passenger_NameLabel"
        Passenger_NameLabel.Size = New System.Drawing.Size(74, 13)
        Passenger_NameLabel.TabIndex = 0
        Passenger_NameLabel.Text = "Passenger ID:"
        '
        'Journey_NameLabel
        '
        Journey_NameLabel.AutoSize = True
        Journey_NameLabel.Location = New System.Drawing.Point(7, 42)
        Journey_NameLabel.Name = "Journey_NameLabel"
        Journey_NameLabel.Size = New System.Drawing.Size(61, 13)
        Journey_NameLabel.TabIndex = 2
        Journey_NameLabel.Text = "Journey ID:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TicketsTableAdapter = Me.TicketsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trial.bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Journey_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Journey_NameComboBox)
        Me.GroupBox1.Controls.Add(Passenger_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Passenger_NameComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 70)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Details:"
        '
        'Journey_NameComboBox
        '
        Me.Journey_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsBindingSource, "Journey Name", True))
        Me.Journey_NameComboBox.FormattingEnabled = True
        Me.Journey_NameComboBox.Location = New System.Drawing.Point(104, 42)
        Me.Journey_NameComboBox.Name = "Journey_NameComboBox"
        Me.Journey_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Journey_NameComboBox.TabIndex = 3
        '
        'Passenger_NameComboBox
        '
        Me.Passenger_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsBindingSource, "Passenger Name", True))
        Me.Passenger_NameComboBox.FormattingEnabled = True
        Me.Passenger_NameComboBox.Location = New System.Drawing.Point(104, 15)
        Me.Passenger_NameComboBox.Name = "Passenger_NameComboBox"
        Me.Passenger_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Passenger_NameComboBox.TabIndex = 1
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PassengersTableAdapter = Me.PassengersTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Trial.bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PassengersDataGridView
        '
        Me.PassengersDataGridView.AllowUserToAddRows = False
        Me.PassengersDataGridView.AllowUserToDeleteRows = False
        Me.PassengersDataGridView.AutoGenerateColumns = False
        Me.PassengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PassengersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PassengersDataGridView.DataSource = Me.PassengersBindingSource
        Me.PassengersDataGridView.Location = New System.Drawing.Point(407, 29)
        Me.PassengersDataGridView.Name = "PassengersDataGridView"
        Me.PassengersDataGridView.ReadOnly = True
        Me.PassengersDataGridView.Size = New System.Drawing.Size(242, 91)
        Me.PassengersDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Passenger_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Passenger_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(479, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Find Passengers"
        '
        'Journeys
        '
        Me.Journeys.DataSetName = "Journeys"
        Me.Journeys.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JourneysBindingSource
        '
        Me.JourneysBindingSource.DataMember = "journeys"
        Me.JourneysBindingSource.DataSource = Me.Journeys
        '
        'JourneysTableAdapter
        '
        Me.JourneysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.journeysTableAdapter = Me.JourneysTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Trial.JourneysTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JourneysDataGridView
        '
        Me.JourneysDataGridView.AllowUserToAddRows = False
        Me.JourneysDataGridView.AllowUserToDeleteRows = False
        Me.JourneysDataGridView.AutoGenerateColumns = False
        Me.JourneysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JourneysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.JourneysDataGridView.DataSource = Me.JourneysBindingSource
        Me.JourneysDataGridView.Location = New System.Drawing.Point(730, 29)
        Me.JourneysDataGridView.Name = "JourneysDataGridView"
        Me.JourneysDataGridView.ReadOnly = True
        Me.JourneysDataGridView.Size = New System.Drawing.Size(241, 91)
        Me.JourneysDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Journey_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Journey_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(824, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Find Journey"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fill the following"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Autopopulated Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Passenger_NameLabel1)
        Me.GroupBox2.Controls.Add(Me.Passenger_NameTextBox1)
        Me.GroupBox2.Controls.Add(GenderLabel)
        Me.GroupBox2.Controls.Add(Me.GenderTextBox)
        Me.GroupBox2.Controls.Add(Contact_NumberLabel)
        Me.GroupBox2.Controls.Add(Me.Contact_NumberTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 124)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Passenger Details"
        '
        'Passenger_NameTextBox1
        '
        Me.Passenger_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Passenger Name", True))
        Me.Passenger_NameTextBox1.Enabled = False
        Me.Passenger_NameTextBox1.Location = New System.Drawing.Point(103, 33)
        Me.Passenger_NameTextBox1.Name = "Passenger_NameTextBox1"
        Me.Passenger_NameTextBox1.Size = New System.Drawing.Size(213, 20)
        Me.Passenger_NameTextBox1.TabIndex = 1
        '
        'Query_ticketsBindingSource
        '
        Me.Query_ticketsBindingSource.DataMember = "query_tickets"
        Me.Query_ticketsBindingSource.DataSource = Me.Tickets_dataset
        '
        'Tickets_dataset
        '
        Me.Tickets_dataset.DataSetName = "tickets_dataset"
        Me.Tickets_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Gender", True))
        Me.GenderTextBox.Enabled = False
        Me.GenderTextBox.Location = New System.Drawing.Point(103, 59)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(213, 20)
        Me.GenderTextBox.TabIndex = 3
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Enabled = False
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(103, 85)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Contact_NumberTextBox.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Journey_NameLabel1)
        Me.GroupBox3.Controls.Add(Me.Journey_NameTextBox1)
        Me.GroupBox3.Controls.Add(DateLabel)
        Me.GroupBox3.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Source_LocationLabel)
        Me.GroupBox3.Controls.Add(Me.Source_LocationTextBox)
        Me.GroupBox3.Controls.Add(Depature_TimeLabel)
        Me.GroupBox3.Controls.Add(Me.Depature_TimeTextBox)
        Me.GroupBox3.Controls.Add(DestinationLabel)
        Me.GroupBox3.Controls.Add(Me.DestinationTextBox)
        Me.GroupBox3.Controls.Add(Arrival_TimeLabel)
        Me.GroupBox3.Controls.Add(Me.Arrival_TimeTextBox)
        Me.GroupBox3.Controls.Add(PriceLabel)
        Me.GroupBox3.Controls.Add(Me.PriceTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 222)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ticket Details"
        '
        'Journey_NameTextBox1
        '
        Me.Journey_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Journey Name", True))
        Me.Journey_NameTextBox1.Enabled = False
        Me.Journey_NameTextBox1.Location = New System.Drawing.Point(116, 26)
        Me.Journey_NameTextBox1.Name = "Journey_NameTextBox1"
        Me.Journey_NameTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Journey_NameTextBox1.TabIndex = 1
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Query_ticketsBindingSource, "Date", True))
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(116, 52)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 3
        '
        'Source_LocationTextBox
        '
        Me.Source_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Source Location", True))
        Me.Source_LocationTextBox.Enabled = False
        Me.Source_LocationTextBox.Location = New System.Drawing.Point(116, 78)
        Me.Source_LocationTextBox.Name = "Source_LocationTextBox"
        Me.Source_LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Source_LocationTextBox.TabIndex = 5
        '
        'Depature_TimeTextBox
        '
        Me.Depature_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Depature Time", True))
        Me.Depature_TimeTextBox.Enabled = False
        Me.Depature_TimeTextBox.Location = New System.Drawing.Point(116, 104)
        Me.Depature_TimeTextBox.Name = "Depature_TimeTextBox"
        Me.Depature_TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depature_TimeTextBox.TabIndex = 7
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Destination", True))
        Me.DestinationTextBox.Enabled = False
        Me.DestinationTextBox.Location = New System.Drawing.Point(116, 130)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DestinationTextBox.TabIndex = 9
        '
        'Arrival_TimeTextBox
        '
        Me.Arrival_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Arrival Time", True))
        Me.Arrival_TimeTextBox.Enabled = False
        Me.Arrival_TimeTextBox.Location = New System.Drawing.Point(116, 156)
        Me.Arrival_TimeTextBox.Name = "Arrival_TimeTextBox"
        Me.Arrival_TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Arrival_TimeTextBox.TabIndex = 11
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Query_ticketsBindingSource, "Price", True))
        Me.PriceTextBox.Enabled = False
        Me.PriceTextBox.Location = New System.Drawing.Point(116, 182)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriceTextBox.TabIndex = 13
        '
        'Query_ticketsTableAdapter
        '
        Me.Query_ticketsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = Trial.tickets_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Query_ticketsDataGridView
        '
        Me.Query_ticketsDataGridView.AllowUserToOrderColumns = True
        Me.Query_ticketsDataGridView.AutoGenerateColumns = False
        Me.Query_ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Query_ticketsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Query_ticketsDataGridView.DataSource = Me.Query_ticketsBindingSource
        Me.Query_ticketsDataGridView.Location = New System.Drawing.Point(407, 173)
        Me.Query_ticketsDataGridView.Name = "Query_ticketsDataGridView"
        Me.Query_ticketsDataGridView.Size = New System.Drawing.Size(564, 250)
        Me.Query_ticketsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Ticket ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ticket ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Passenger Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Passenger Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Contact Number"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Journey Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Journey Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Source Location"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Source Location"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Depature Time"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Depature Time"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Arrival Time"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Arrival Time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "New Ticket"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(708, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 39)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Book Ticket"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 535)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Query_ticketsDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JourneysDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassengersDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "AddTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddTickets"
        CType(Me.Bus_ticketing_systemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Query_ticketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tickets_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Query_ticketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bus_ticketing_systemDataSet2 As bus_ticketing_systemDataSet2
    Friend WithEvents TicketsBindingSource As BindingSource
    Friend WithEvents TicketsTableAdapter As bus_ticketing_systemDataSet2TableAdapters.TicketsTableAdapter
    Friend WithEvents TableAdapterManager As bus_ticketing_systemDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bus_ticketing_systemDataSet1 As bus_ticketing_systemDataSet1
    Friend WithEvents PassengersBindingSource As BindingSource
    Friend WithEvents PassengersTableAdapter As bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter
    Friend WithEvents TableAdapterManager1 As bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PassengersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Journeys As Journeys
    Friend WithEvents JourneysBindingSource As BindingSource
    Friend WithEvents JourneysTableAdapter As JourneysTableAdapters.journeysTableAdapter
    Friend WithEvents TableAdapterManager2 As JourneysTableAdapters.TableAdapterManager
    Friend WithEvents JourneysDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Tickets_dataset As tickets_dataset
    Friend WithEvents Query_ticketsBindingSource As BindingSource
    Friend WithEvents Query_ticketsTableAdapter As tickets_datasetTableAdapters.query_ticketsTableAdapter
    Friend WithEvents TableAdapterManager3 As tickets_datasetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Passenger_NameTextBox1 As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Journey_NameTextBox1 As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Source_LocationTextBox As TextBox
    Friend WithEvents Depature_TimeTextBox As TextBox
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents Arrival_TimeTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Query_ticketsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Journey_NameComboBox As ComboBox
    Friend WithEvents Passenger_NameComboBox As ComboBox
End Class

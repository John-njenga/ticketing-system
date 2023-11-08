<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPassenger
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
        Dim AgeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ZipcodeLabel As System.Windows.Forms.Label
        Dim EC_NameLabel As System.Windows.Forms.Label
        Dim Contact_NoLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim Passenger_nameLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EC_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NoTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PassengersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassengersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bus_ticketing_systemDataSet1 = New Trial.bus_ticketing_systemDataSet1()
        Me.PassengersTableAdapter = New Trial.bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter()
        Me.TableAdapterManager = New Trial.bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager()
        Me.Passenger_nameTextBox = New System.Windows.Forms.TextBox()
        AgeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        ZipcodeLabel = New System.Windows.Forms.Label()
        EC_NameLabel = New System.Windows.Forms.Label()
        Contact_NoLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(26, 89)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 4
        AgeLabel.Text = "Age:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(26, 115)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Location = New System.Drawing.Point(26, 141)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(91, 13)
        Contact_NumberLabel.TabIndex = 8
        Contact_NumberLabel.Text = "Contact Number:*"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Location = New System.Drawing.Point(26, 167)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(63, 13)
        NationalityLabel.TabIndex = 10
        NationalityLabel.Text = "Nationality:*"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(26, 193)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(31, 13)
        CityLabel.TabIndex = 12
        CityLabel.Text = "City:*"
        '
        'ZipcodeLabel
        '
        ZipcodeLabel.AutoSize = True
        ZipcodeLabel.Location = New System.Drawing.Point(26, 219)
        ZipcodeLabel.Name = "ZipcodeLabel"
        ZipcodeLabel.Size = New System.Drawing.Size(49, 13)
        ZipcodeLabel.TabIndex = 14
        ZipcodeLabel.Text = "Zipcode:"
        '
        'EC_NameLabel
        '
        EC_NameLabel.AutoSize = True
        EC_NameLabel.Location = New System.Drawing.Point(25, 26)
        EC_NameLabel.Name = "EC_NameLabel"
        EC_NameLabel.Size = New System.Drawing.Size(59, 13)
        EC_NameLabel.TabIndex = 0
        EC_NameLabel.Text = "EC Name:*"
        '
        'Contact_NoLabel
        '
        Contact_NoLabel.AutoSize = True
        Contact_NoLabel.Location = New System.Drawing.Point(25, 52)
        Contact_NoLabel.Name = "Contact_NoLabel"
        Contact_NoLabel.Size = New System.Drawing.Size(68, 13)
        Contact_NoLabel.TabIndex = 2
        Contact_NoLabel.Text = "Contact No:*"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Location = New System.Drawing.Point(25, 78)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(72, 13)
        RelationshipLabel.TabIndex = 4
        RelationshipLabel.Text = "Relationship:*"
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Location = New System.Drawing.Point(26, 62)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(45, 13)
        GenderLabel1.TabIndex = 15
        GenderLabel1.Text = "Gender:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Passenger_nameLabel)
        Me.GroupBox1.Controls.Add(Me.Passenger_nameTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel1)
        Me.GroupBox1.Controls.Add(Me.GenderComboBox)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Contact_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Contact_NumberTextBox)
        Me.GroupBox1.Controls.Add(NationalityLabel)
        Me.GroupBox1.Controls.Add(Me.NationalityTextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(ZipcodeLabel)
        Me.GroupBox1.Controls.Add(Me.ZipcodeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Passenger Details"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(121, 59)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderComboBox.TabIndex = 16
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(121, 86)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(121, 112)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(121, 138)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Contact_NumberTextBox.TabIndex = 9
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(121, 164)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NationalityTextBox.TabIndex = 11
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(121, 190)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 13
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Zipcode", True))
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(121, 216)
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipcodeTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fields marked with (*) are required"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(EC_NameLabel)
        Me.GroupBox2.Controls.Add(Me.EC_NameTextBox)
        Me.GroupBox2.Controls.Add(Contact_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Contact_NoTextBox)
        Me.GroupBox2.Controls.Add(RelationshipLabel)
        Me.GroupBox2.Controls.Add(Me.RelationshipTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 108)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emergency contact"
        '
        'EC_NameTextBox
        '
        Me.EC_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "EC Name", True))
        Me.EC_NameTextBox.Location = New System.Drawing.Point(120, 26)
        Me.EC_NameTextBox.Name = "EC_NameTextBox"
        Me.EC_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EC_NameTextBox.TabIndex = 1
        '
        'Contact_NoTextBox
        '
        Me.Contact_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Contact No", True))
        Me.Contact_NoTextBox.Location = New System.Drawing.Point(120, 52)
        Me.Contact_NoTextBox.Name = "Contact_NoTextBox"
        Me.Contact_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Contact_NoTextBox.TabIndex = 3
        '
        'RelationshipTextBox
        '
        Me.RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Relationship", True))
        Me.RelationshipTextBox.Location = New System.Drawing.Point(120, 78)
        Me.RelationshipTextBox.Name = "RelationshipTextBox"
        Me.RelationshipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RelationshipTextBox.TabIndex = 5
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(563, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PassengersDataGridView
        '
        Me.PassengersDataGridView.AutoGenerateColumns = False
        Me.PassengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PassengersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.PassengersDataGridView.DataSource = Me.PassengersBindingSource
        Me.PassengersDataGridView.Location = New System.Drawing.Point(291, 25)
        Me.PassengersDataGridView.Name = "PassengersDataGridView"
        Me.PassengersDataGridView.Size = New System.Drawing.Size(694, 268)
        Me.PassengersDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Passenger_name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Passenger_name"
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
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Contact Number"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nationality"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nationality"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn19.HeaderText = "City"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Zipcode"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Zipcode"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "EC Name"
        Me.DataGridViewTextBoxColumn21.HeaderText = "EC Name"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Contact No"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Relationship"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Relationship"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'PassengersBindingSource
        '
        Me.PassengersBindingSource.DataMember = "Passengers"
        Me.PassengersBindingSource.DataSource = Me.Bus_ticketing_systemDataSet1
        '
        'Bus_ticketing_systemDataSet1
        '
        Me.Bus_ticketing_systemDataSet1.DataSetName = "bus_ticketing_systemDataSet1"
        Me.Bus_ticketing_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(26, 39)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(93, 13)
        Passenger_nameLabel.TabIndex = 16
        Passenger_nameLabel.Text = "Passenger name:*"
        '
        'Passenger_nameTextBox
        '
        Me.Passenger_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PassengersBindingSource, "Passenger_name", True))
        Me.Passenger_nameTextBox.Location = New System.Drawing.Point(121, 32)
        Me.Passenger_nameTextBox.Name = "Passenger_nameTextBox"
        Me.Passenger_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Passenger_nameTextBox.TabIndex = 17
        '
        'RegisterPassenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 419)
        Me.Controls.Add(Me.PassengersDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "RegisterPassenger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterPassenger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PassengersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassengersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bus_ticketing_systemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bus_ticketing_systemDataSet1 As bus_ticketing_systemDataSet1
    Friend WithEvents PassengersBindingSource As BindingSource
    Friend WithEvents PassengersTableAdapter As bus_ticketing_systemDataSet1TableAdapters.PassengersTableAdapter
    Friend WithEvents TableAdapterManager As bus_ticketing_systemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ZipcodeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EC_NameTextBox As TextBox
    Friend WithEvents Contact_NoTextBox As TextBox
    Friend WithEvents RelationshipTextBox As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
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
    Friend WithEvents Button2 As Button
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents PassengersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Passenger_nameTextBox As TextBox
End Class

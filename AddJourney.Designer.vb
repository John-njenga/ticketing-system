<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddJourney
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
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Arrival_TimeLabel As System.Windows.Forms.Label
        Dim Depature_TimeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Source_LocationLabel As System.Windows.Forms.Label
        Dim Journey_nameLabel As System.Windows.Forms.Label
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.JourneysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journeys = New Trial.Journeys()
        Me.Source_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Depature_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Arrival_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.JourneysDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JourneysTableAdapter = New Trial.JourneysTableAdapters.journeysTableAdapter()
        Me.TableAdapterManager = New Trial.JourneysTableAdapters.TableAdapterManager()
        Me.Journey_nameTextBox = New System.Windows.Forms.TextBox()
        DestinationLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Arrival_TimeLabel = New System.Windows.Forms.Label()
        Depature_TimeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Source_LocationLabel = New System.Windows.Forms.Label()
        Journey_nameLabel = New System.Windows.Forms.Label()
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(15, 75)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(63, 13)
        DestinationLabel.TabIndex = 7
        DestinationLabel.Text = "Destination:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(15, 179)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 15
        PriceLabel.Text = "Price:"
        '
        'Arrival_TimeLabel
        '
        Arrival_TimeLabel.AutoSize = True
        Arrival_TimeLabel.Location = New System.Drawing.Point(15, 127)
        Arrival_TimeLabel.Name = "Arrival_TimeLabel"
        Arrival_TimeLabel.Size = New System.Drawing.Size(65, 13)
        Arrival_TimeLabel.TabIndex = 11
        Arrival_TimeLabel.Text = "Arrival Time:"
        '
        'Depature_TimeLabel
        '
        Depature_TimeLabel.AutoSize = True
        Depature_TimeLabel.Location = New System.Drawing.Point(15, 101)
        Depature_TimeLabel.Name = "Depature_TimeLabel"
        Depature_TimeLabel.Size = New System.Drawing.Size(80, 13)
        Depature_TimeLabel.TabIndex = 9
        Depature_TimeLabel.Text = "Depature Time:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(15, 154)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 13
        DateLabel.Text = "Date:"
        '
        'Source_LocationLabel
        '
        Source_LocationLabel.AutoSize = True
        Source_LocationLabel.Location = New System.Drawing.Point(15, 49)
        Source_LocationLabel.Name = "Source_LocationLabel"
        Source_LocationLabel.Size = New System.Drawing.Size(88, 13)
        Source_LocationLabel.TabIndex = 5
        Source_LocationLabel.Text = "Source Location:"
        '
        'Journey_nameLabel
        '
        Journey_nameLabel.AutoSize = True
        Journey_nameLabel.Location = New System.Drawing.Point(15, 23)
        Journey_nameLabel.Name = "Journey_nameLabel"
        Journey_nameLabel.Size = New System.Drawing.Size(76, 13)
        Journey_nameLabel.TabIndex = 18
        Journey_nameLabel.Text = "Journey name:"
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Destination", True))
        Me.DestinationTextBox.Location = New System.Drawing.Point(109, 72)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DestinationTextBox.TabIndex = 8
        '
        'JourneysBindingSource
        '
        Me.JourneysBindingSource.DataMember = "journeys"
        Me.JourneysBindingSource.DataSource = Me.Journeys
        '
        'Journeys
        '
        Me.Journeys.DataSetName = "Journeys"
        Me.Journeys.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Source_LocationTextBox
        '
        Me.Source_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Source Location", True))
        Me.Source_LocationTextBox.Location = New System.Drawing.Point(109, 46)
        Me.Source_LocationTextBox.Name = "Source_LocationTextBox"
        Me.Source_LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Source_LocationTextBox.TabIndex = 6
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(109, 176)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriceTextBox.TabIndex = 16
        '
        'Depature_TimeTextBox
        '
        Me.Depature_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Depature Time", True))
        Me.Depature_TimeTextBox.Location = New System.Drawing.Point(109, 98)
        Me.Depature_TimeTextBox.Name = "Depature_TimeTextBox"
        Me.Depature_TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Depature_TimeTextBox.TabIndex = 10
        '
        'Arrival_TimeTextBox
        '
        Me.Arrival_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Arrival Time", True))
        Me.Arrival_TimeTextBox.Location = New System.Drawing.Point(109, 124)
        Me.Arrival_TimeTextBox.Name = "Arrival_TimeTextBox"
        Me.Arrival_TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Arrival_TimeTextBox.TabIndex = 12
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JourneysBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(109, 150)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 38)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 38)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Add Journey"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'JourneysDataGridView
        '
        Me.JourneysDataGridView.AllowUserToOrderColumns = True
        Me.JourneysDataGridView.AutoGenerateColumns = False
        Me.JourneysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JourneysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.JourneysDataGridView.DataSource = Me.JourneysBindingSource
        Me.JourneysDataGridView.Location = New System.Drawing.Point(330, 20)
        Me.JourneysDataGridView.Name = "JourneysDataGridView"
        Me.JourneysDataGridView.Size = New System.Drawing.Size(650, 234)
        Me.JourneysDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Journey_name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Journey_name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Source Location"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Source Location"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Depature Time"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Depature Time"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Arrival Time"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Arrival Time"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'JourneysTableAdapter
        '
        Me.JourneysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.journeysTableAdapter = Me.JourneysTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trial.JourneysTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Journey_nameTextBox
        '
        Me.Journey_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JourneysBindingSource, "Journey_name", True))
        Me.Journey_nameTextBox.Location = New System.Drawing.Point(109, 20)
        Me.Journey_nameTextBox.Name = "Journey_nameTextBox"
        Me.Journey_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Journey_nameTextBox.TabIndex = 19
        '
        'AddJourney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 290)
        Me.Controls.Add(Journey_nameLabel)
        Me.Controls.Add(Me.Journey_nameTextBox)
        Me.Controls.Add(Me.JourneysDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Source_LocationLabel)
        Me.Controls.Add(Me.Source_LocationTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(Depature_TimeLabel)
        Me.Controls.Add(Me.Depature_TimeTextBox)
        Me.Controls.Add(Arrival_TimeLabel)
        Me.Controls.Add(Me.Arrival_TimeTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Name = "AddJourney"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddJourney"
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Journeys As Journeys
    Friend WithEvents JourneysBindingSource As BindingSource
    Friend WithEvents JourneysTableAdapter As JourneysTableAdapters.journeysTableAdapter
    Friend WithEvents TableAdapterManager As JourneysTableAdapters.TableAdapterManager
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents Source_LocationTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Depature_TimeTextBox As TextBox
    Friend WithEvents Arrival_TimeTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents JourneysDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Journey_nameTextBox As TextBox
End Class

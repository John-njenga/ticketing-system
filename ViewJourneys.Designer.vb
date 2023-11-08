<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewJourneys
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
        Me.Journeys = New Trial.Journeys()
        Me.JourneysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JourneysTableAdapter = New Trial.JourneysTableAdapters.journeysTableAdapter()
        Me.TableAdapterManager = New Trial.JourneysTableAdapters.TableAdapterManager()
        Me.JourneysDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.journeysTableAdapter = Me.JourneysTableAdapter
        Me.TableAdapterManager.UpdateOrder = Trial.JourneysTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JourneysDataGridView
        '
        Me.JourneysDataGridView.AutoGenerateColumns = False
        Me.JourneysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JourneysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.JourneysDataGridView.DataSource = Me.JourneysBindingSource
        Me.JourneysDataGridView.Location = New System.Drawing.Point(12, 22)
        Me.JourneysDataGridView.Name = "JourneysDataGridView"
        Me.JourneysDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.JourneysDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Source Location"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Source Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Depature Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Depature Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Arrival Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Arrival Time"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Journey_name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Journey_name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete Journey"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewJourneys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 335)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.JourneysDataGridView)
        Me.Name = "ViewJourneys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewJourneys"
        CType(Me.Journeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JourneysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JourneysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Journeys As Journeys
    Friend WithEvents JourneysBindingSource As BindingSource
    Friend WithEvents JourneysTableAdapter As JourneysTableAdapters.journeysTableAdapter
    Friend WithEvents TableAdapterManager As JourneysTableAdapters.TableAdapterManager
    Friend WithEvents JourneysDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class

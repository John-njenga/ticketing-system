Imports System.Data.OleDb
Imports System.Net

Public Class RegisterBus
    Private Sub BusesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BusesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet)

    End Sub

    Private Sub RegisterBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet.buses' table. You can move, or remove it, as needed.
        Me.BusesTableAdapter.Fill(Me.Bus_ticketing_systemDataSet.buses)

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dave\Documents\bus_ticketing_system.accdb")

        conn.Open()
        'Fuel type combobox
        Dim strsql As New OleDbCommand("select fuel_name from fuel_type", conn)
        Dim myReader As OleDb.OleDbDataReader = strsql.ExecuteReader

        While myReader.Read()
            Fuel_TypeComboBox.Items.Add(myReader("fuel_name"))
        End While

        'Bus type combobox
        Dim strsql2 As New OleDbCommand("select bus_name from bus_type", conn)
        Dim myReader2 As OleDb.OleDbDataReader = strsql2.ExecuteReader

        While myReader2.Read()
            Bus_TypeComboBox.Items.Add(myReader2("bus_name"))
        End While

        'close db connection
        conn.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        BusesBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            BusesBindingSource.EndEdit()
            BusesTableAdapter.Update(Bus_ticketing_systemDataSet.buses)
            MsgBox("Data saved successfully!",, "Success")
        Catch ex As Exception
            MsgBox("An Error occurred while saving data!",, "Error")
            Close()
        End Try
    End Sub
End Class
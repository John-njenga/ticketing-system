Imports System.Data.OleDb
Imports Trial.bus_ticketing_systemDataSet2TableAdapters

Public Class AddTickets
    Private Sub TicketsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TicketsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet2)

    End Sub

    Private Sub AddTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tickets_dataset.query_tickets' table. You can move, or remove it, as needed.
        Me.Query_ticketsTableAdapter.Fill(Me.Tickets_dataset.query_tickets)
        'TODO: This line of code loads data into the 'Journeys._journeys' table. You can move, or remove it, as needed.
        Me.JourneysTableAdapter.Fill(Me.Journeys._journeys)
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet1.Passengers' table. You can move, or remove it, as needed.
        Me.PassengersTableAdapter.Fill(Me.Bus_ticketing_systemDataSet1.Passengers)
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet2.Tickets' table. You can move, or remove it, as needed.
        Me.TicketsTableAdapter.Fill(Me.Bus_ticketing_systemDataSet2.Tickets)

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dave\Documents\bus_ticketing_system.accdb")

        conn.Open()
        'passenger name type combobox
        Dim strsql As New OleDbCommand("select ID from Passengers", conn)
        Dim myReader As OleDb.OleDbDataReader = strsql.ExecuteReader

        While myReader.Read()
            Passenger_NameComboBox.Items.Add(myReader("ID"))
        End While

        'journey name type combobox
        Dim strsql1 As New OleDbCommand("select ID from journeys", conn)
        Dim myReader1 As OleDb.OleDbDataReader = strsql1.ExecuteReader

        While myReader1.Read()
            Journey_NameComboBox.Items.Add(myReader1("ID"))
        End While

        'close connection
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TicketsBindingSource.AddNew()
        Query_ticketsBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TicketsBindingSource.EndEdit()
            TicketsTableAdapter.Update(Bus_ticketing_systemDataSet2.Tickets)

            Query_ticketsBindingSource.EndEdit()

            MessageBox.Show("Ticket Booked Successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Query_ticketsTableAdapter.Fill(Tickets_dataset.query_tickets)
    End Sub
End Class
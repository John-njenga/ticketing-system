Imports Trial.tickets_datasetTableAdapters

Public Class View_Tickets
    Private Sub View_Tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet2.Tickets' table. You can move, or remove it, as needed.
        Me.TicketsTableAdapter.Fill(Me.Bus_ticketing_systemDataSet2.Tickets)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TicketsBindingSource.RemoveCurrent()
            TicketsBindingSource.EndEdit()
            TicketsTableAdapter.Update(Bus_ticketing_systemDataSet2.Tickets)
            MessageBox.Show("Ticket Deleted successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Query_ticketsTableAdapter.Fill(Tickets_dataset.query_tickets)
    End Sub
End Class
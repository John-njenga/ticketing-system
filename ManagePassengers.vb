Public Class ManagePassengers
    Private Sub PassengersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PassengersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet1)

    End Sub

    Private Sub ManagePassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet1.Passengers' table. You can move, or remove it, as needed.
        Me.PassengersTableAdapter.Fill(Me.Bus_ticketing_systemDataSet1.Passengers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PassengersBindingSource.RemoveCurrent()
            PassengersBindingSource.EndEdit()
            PassengersTableAdapter.Update(Bus_ticketing_systemDataSet1.Passengers)
            MessageBox.Show("Record deleted successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting record!")
        End Try

    End Sub
End Class
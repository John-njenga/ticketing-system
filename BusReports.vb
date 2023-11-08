Public Class BusReports
    Private Sub BusesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BusesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet)

    End Sub

    Private Sub BusesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BusesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet)

    End Sub

    Private Sub BusReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet.buses' table. You can move, or remove it, as needed.
        Me.BusesTableAdapter.Fill(Me.Bus_ticketing_systemDataSet.buses)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            BusesBindingSource.RemoveCurrent()
            BusesBindingSource.EndEdit()
            BusesTableAdapter.Update(Bus_ticketing_systemDataSet.buses)
            MessageBox.Show("Record Deleted successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
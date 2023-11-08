Public Class ViewJourneys
    Private Sub JourneysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.JourneysBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Journeys)

    End Sub

    Private Sub ViewJourneys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Journeys._journeys' table. You can move, or remove it, as needed.
        Me.JourneysTableAdapter.Fill(Me.Journeys._journeys)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            JourneysBindingSource.RemoveCurrent()
            JourneysBindingSource.EndEdit()
            JourneysTableAdapter.Update(Journeys._journeys)
            MessageBox.Show("Record deleted successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
Public Class AddJourney
    Private Sub JourneysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.JourneysBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Journeys)

    End Sub

    Private Sub AddJourney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Journeys._journeys' table. You can move, or remove it, as needed.
        Me.JourneysTableAdapter.Fill(Me.Journeys._journeys)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        JourneysBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            JourneysBindingSource.EndEdit()
            JourneysTableAdapter.Update(Journeys._journeys)
            MessageBox.Show("Record saved successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving data!")
            JourneysDataGridView.ClearSelection()
        End Try

    End Sub
End Class
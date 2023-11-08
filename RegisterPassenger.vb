Imports System.Data.OleDb

Public Class RegisterPassenger
    Private Sub PassengersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PassengersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bus_ticketing_systemDataSet1)

    End Sub

    Private Sub RegisterPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus_ticketing_systemDataSet1.Passengers' table. You can move, or remove it, as needed.
        Me.PassengersTableAdapter.Fill(Me.Bus_ticketing_systemDataSet1.Passengers)

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dave\Documents\bus_ticketing_system.accdb")

        conn.Open()
        'Gender type combobox
        Dim strsql As New OleDbCommand("select type from Gender", conn)
        Dim myReader As OleDb.OleDbDataReader = strsql.ExecuteReader

        While myReader.Read()
            GenderComboBox.Items.Add(myReader("type"))
        End While

        'close connection
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PassengersBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            PassengersBindingSource.EndEdit()
            PassengersTableAdapter.Update(Bus_ticketing_systemDataSet1.Passengers)
            MessageBox.Show("Passenger Registered successfully")
        Catch ex As Exception
            MessageBox.Show("An error occurred when saving data!" + vbCrLf + "Kindly check your inputs.")
        End Try
    End Sub
End Class
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Dashboard_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub

    Private Sub btnRegBus_Click(sender As Object, e As EventArgs) Handles btnRegBus.Click
        RegisterBus.Show()
    End Sub

    Private Sub btnBusRep_Click(sender As Object, e As EventArgs) Handles btnBusRep.Click
        BusReports.Show()
    End Sub

    Private Sub btnBookTicket_Click(sender As Object, e As EventArgs) Handles btnBookTicket.Click
        AddTickets.Show()
    End Sub

    Private Sub btnCanTicket_Click(sender As Object, e As EventArgs) Handles btnCanTicket.Click
        View_Tickets.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterPassenger.Show()
    End Sub

    Private Sub btnManPass_Click(sender As Object, e As EventArgs) Handles btnManPass.Click
        ManagePassengers.Show()
    End Sub

    Private Sub btnNewJou_Click(sender As Object, e As EventArgs) Handles btnNewJou.Click
        AddJourney.Show()
    End Sub

    Private Sub btnViewJou_Click(sender As Object, e As EventArgs) Handles btnViewJou.Click
        ViewJourneys.Show()
    End Sub
End Class
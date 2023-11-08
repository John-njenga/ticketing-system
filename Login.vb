Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As Integer

        Try
            username = txtUsername.Text
            password = CInt(txtPassword.Text)

            If (username = "admin" And password = "1234") Then
                MsgBox("Login Successful!",, "Successful")
                'launch dashboard
                dashboard.Show()
                'clear credentials
                txtUsername.Clear()
                txtPassword.Clear()
                'hide login form
                Me.Hide()
            Else
                MsgBox("Incorrect credentials",, "Note")
            End If
        Catch ex As Exception
            MsgBox("Incorrect credentials",, "Note")
        End Try

    End Sub
End Class

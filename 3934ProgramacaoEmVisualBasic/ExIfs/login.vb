Public Class login
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim Nome As String = txtUtilizador.Text
        Dim Password As String = txtPassword.Text

        If Nome = "Maria" And Password = "iefp123" Then
            MessageBox.Show("BenVinda Maria")
        Else
            MessageBox.Show("UItilizador inválido ou Password incorreta")
        End If

    End Sub
End Class
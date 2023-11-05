Public Class Form1
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Val(txtNumero1.Text) > Val(txtNumero2.Text) Then ' Val faz a conversão do texto para numero
            lblMax.Text = "O valor Máximo é: " & txtNumero1.Text
        Else
            lblMax.Text = "O valor Máximo é: " & txtNumero2.Text

        End If
    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        txtNumero1.Text = ""
        txtNumero2.Text = ""
        lblMax.Text = ""
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        login.Show()
    End Sub
End Class

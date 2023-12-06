Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False ' oculta a imagem
        Label1.Text = CStr(Int(1 + Rnd() * 10)) ' Gerar um numero de 1 a 10 aleatoriamente
        Label2.Text = CStr(Int(1 + Rnd() * 10)) ' Gerar um numero de 1 a 10 aleatoriamente
        Label3.Text = CStr(Int(1 + Rnd() * 10)) ' Gerar um numero de 1 a 10 aleatoriamente

        ' se qualquer dos números da label for 7 então mostra a imagem
        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True

            Beep()
            MessageBox.Show("Parabéns, Acabou de acertar e ganhou o Prémio")

        End If

    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10)) 'vai gerar um numero aleatório
        Label2.Text = CStr(Int(Rnd() * 10)) 'vai gerar um numero aleatório
        Label2.Text = CStr(Int(Rnd() * 10)) 'vai gerar um numero aleatório
        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If

    End Sub
End Class

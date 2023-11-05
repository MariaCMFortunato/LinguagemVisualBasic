Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Valor As Single
        Valor = TextBox1.Text

        Select Case Valor
            Case 0 To 49
                lblAvalia.Text = "Ir à prova de Recuperação"
            Case 50 To 59
                lblAvalia.Text = "Suficiente"
            Case 60 To 69
                lblAvalia.Text = "Bom"
            Case 70 To 79
                lblAvalia.Text = "Muito Bom"
            Case 80 To 100
                lblAvalia.Text = "Excelente"
            Case Else
                lblAvalia.Text = "Erro, insira a Nota novamente"

        End Select

    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declaração de uma variável tipo string
        Dim nome As String
        nome = InputBox("Digite o seu nome.")

        MsgBox("Bemvindo(a) " + nome)
        'o sinal + é um operador de concatenação

    End Sub
End Class

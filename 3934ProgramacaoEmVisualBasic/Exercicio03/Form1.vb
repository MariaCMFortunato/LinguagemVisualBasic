Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nome As String
        Dim mensagem As New Label

        nome = InputBox("Digite o seu nome.")

        mensagem.Location = New Point(30, 30)
        mensagem.Width = 300
        mensagem.Height = 100
        mensagem.Text = "Bemvindo(a) " + nome
        Label1.Text = "Bemvindo(a) " + nome
        Me.Controls.Add(mensagem)





    End Sub
End Class

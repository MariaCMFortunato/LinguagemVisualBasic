Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Dim nome As String
        'nome = InputBox("Por favor, insira o seu nome")
        'MsgBox("Olá, " & nome)

        Dim nome As String
        Dim apelido As String
        Dim genero As String
        Dim ocupacao As String


        nome = txtNome.Text
        apelido = txtApelido.Text
        genero = txtGenero.Text
        ocupacao = lstOcupacao.SelectedItem

        MsgBox(" Olá, " & nome & " " & apelido & ", tu és uma pessoa do género " &
            genero & vbNewLine & " e és " & ocupacao & "!")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOcupacao.Items.Add("Escritor(a)")
        lstOcupacao.Items.Add("Ator / atriz")
        lstOcupacao.Items.Add("Pinto(a)")

    End Sub
End Class

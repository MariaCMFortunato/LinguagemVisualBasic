Public Class Form1


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Bem-vindo ao curso de programação em VB.NET")
        MessageBox.Show("Esta é outra menagem ... ")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim nome As String
        Dim apelido As String

        nome = "Maria C"
        apelido = "M Fortunato"
        MessageBox.Show("Olá e bem-vinda, " & nome & " " & apelido & ", espero que estejas bem!")

        nome = "Daniela F"
        apelido = "M Fortunato"
        MsgBox("Olá e bem-vinda, " & nome & " " & apelido & ", espero que estejas bem!")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim marca As String
        Dim modelo As String
        Dim portas As Integer
        Dim cor As String
        Dim taxado As Boolean
        Dim motor As Integer
        Dim preco As Decimal
        Dim dataRegisto As Date
        'A data tem de ser declarada entre # e no formato americano mês/dia/ano
        'a exibição no ecrâ será de acordo com as configurações do sistema operativo

        marca = "Ford"
        modelo = "Escort"
        portas = 5
        cor = "Amarelo"
        taxado = True
        motor = 1200
        preco = 999.99
        dataRegisto = #11/30/2005#

        MsgBox("O carro é " & marca & vbNewLine & modelo & vbNewLine & portas & vbNewLine &
               cor & vbNewLine & taxado & vbNewLine & motor & vbNewLine & preco & vbNewLine &
               dataRegisto)

        MessageBox.Show("O carro é " & marca & vbNewLine & modelo & vbNewLine & portas &
                        vbNewLine & cor & vbNewLine & taxado & vbNewLine & motor & vbNewLine 
                        & preco & vbNewLine & dataRegisto)

    End Sub
End Class

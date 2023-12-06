Public Class Form1
    Private Sub btnCalculaQ_Click_1(sender As Object, e As EventArgs) Handles btnCalculaQ.Click
        Dim C As Double 'Definir variável comprimento
        Dim A1 As Double ' Definir a variável área
        C = txtComp.Text 'obter o comprimento
        A1 = C ^ 2 'Calcular a área
        txtAreaQ.Text = A1 ' mostra a área 
        lstHistorico.Items.Add("A área do Quadrado é: " & A1) ' Adiciona à listbox

    End Sub

    Private Sub btnCalulaR_Click(sender As Object, e As EventArgs) Handles btnCalulaR.Click
        Dim L As Double 'Definir a variável Largura
        Dim A As Double ' Definir a variável Altura
        Dim A2 As Double ' Definir a área

        L = txtLarg.Text 'Obtém a Largura
        A = txtAlt.Text ' Ontém a altura
        A2 = L * A ' calcula a área do retângulo

        txtAreaR.Text = A2

        Dim s1 As String
        Dim S2 As String
        s1 = "A área do Retângulo é: " ' mensagem
        S2 = s1 & A2
        lstHistorico.Items.Add(S2) ' Adiciona à listbox

    End Sub

    Private Sub btnCalulaT_Click(sender As Object, e As EventArgs) Handles btnCalulaT.Click
        Dim base As Double ' Define a Base
        Dim altura As Double ' Define a Altura
        Dim area As Double 'Define a Area
        base = txtBase.Text ' Obtém a Base
        altura = txtAlt2.Text 'Obtém a Altura
        area = 0.5 * base * altura 'Clacula a área (1/2*base*altura
        txtAreaT.Text = area 'mostra o resultado

        Dim Str As String
        Str = "A área do Triângulo e: " & area ' gera a mensagem

        lstHistorico.Items.Add(Str) ' Adiciona à listbox


    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        txtComp.Text = "" ' Limpa a textbox Comprimento
        txtAreaQ.Text = "" ' Idem Área do Quadrado
        txtLarg.Text = "" ' Idem Largura do Retângulo
        txtAlt.Text = "" ' Idem Altura do Retângulo
        txtAreaR.Text = "" ' Idem Área do Retângulo
        txtBase.Text = "" 'Idem Base do Triângulo
        txtAltura.Text = "" 'Idem Altura do Triângulo
        txtAreaT.Text = "" 'Idem Área do Triângulo
        lstHistorico.Items.Clear() ' Limpa a listbox



    End Sub
End Class

Public Class Form1
    Dim Ans As Integer
    Dim Desconto As Integer
    Dim Taxa As Integer
    Dim Saude As Integer
    Dim SS As Integer
    Dim Liquido As Integer

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Ans = (txtHoras.Text * txtDias.Text) * (txtValor.Text)
        txtSalarioB.Text = Ans

        'Calcular o valor do IVA
        Taxa = Ans * 0.23
        txtIva.Text = Taxa

        'Calcular o valor da Saúde
        Saude = Ans * 0.05
        txtS.Text = Saude

        'Calcular o valor da Segurança Social
        SS = Ans * 0.11
        txtSS.Text = SS

        ' Calcular total de descontos
        Desconto = Taxa + Saude + SS
        txtDescontos.Text = Desconto

        ' Calcular salário líquido
        Liquido = Ans - Desconto
        txtSalarioL.Text = Liquido


    End Sub
End Class

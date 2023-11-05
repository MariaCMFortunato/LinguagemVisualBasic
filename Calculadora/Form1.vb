Public Class Form1
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Integer

        Valor1 = txtValor1.Text
        Valor2 = txtValor2.Text
        Resultado = Valor1 + Valor2

        lblResultado.Text = Resultado

    End Sub

    Private Sub btnSubtrai_Click(sender As Object, e As EventArgs) Handles btnSubtrai.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Integer

        Valor1 = txtValor1.Text
        Valor2 = txtValor2.Text
        Resultado = Valor1 - Valor2

        lblResultado.Text = Resultado

    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Integer

        Valor1 = txtValor1.Text
        Valor2 = txtValor2.Text
        Resultado = Valor1 * Valor2

        lblResultado.Text = Resultado

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Double

        Valor1 = txtValor1.Text
        Valor2 = txtValor2.Text
        Resultado = Valor1 / Valor2

        lblResultado.Text = Resultado.ToString("#0.000000")

    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        txtValor1.Text = ""
        txtValor2.Text = ""
        lblResultado.Text = "Resultado"
    End Sub
End Class

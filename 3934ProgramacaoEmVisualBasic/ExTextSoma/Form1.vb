Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Integer

        Valor1 = txtValor1.Text
        Valor2 = txtValor2.Text
        Resultado = Valor1 + Valor2

        MessageBox.Show("O total é: " & Resultado)

        lblResultado.Text = ("O total é: " & Resultado)

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtValor1.Text = ""
        txtValor2.Text = ""

    End Sub
End Class

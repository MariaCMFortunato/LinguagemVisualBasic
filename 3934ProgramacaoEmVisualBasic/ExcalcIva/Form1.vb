Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Const TaxaIva = 0.23

        Dim Valor As Double = CDbl(txtValor.Text) 'converter em double o valor da textBox
        Dim IVA As Double = Valor * TaxaIva

        Dim CustoTotal = Valor + IVA

        ListBox1.Items.Clear()

        ListBox1.Items.Add("Cliente: " & txtCliente.Text)
        ListBox1.Items.Add("Taxa IVA 23%")

        ListBox1.Items.Add("Valor do Produto: " & Valor.ToString("C"))
        ListBox1.Items.Add("Valor do IVA: " & IVA.ToString("C"))
        ListBox1.Items.Add("Total a Pagar: " & CustoTotal.ToString("C"))

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        ListBox1.Items.Clear()
        txtCliente.Text = ""
        txtValor.Text = ""

    End Sub
End Class

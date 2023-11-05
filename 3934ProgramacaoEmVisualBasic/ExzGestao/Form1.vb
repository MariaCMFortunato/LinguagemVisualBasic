Public Class Form1
    Private Sub btnCalculo_Click(sender As Object, e As EventArgs) Handles btnCalculo.Click

        Const ValorHora As Double = 35.0 'Valor constante de Mão de obra
        Dim horas As Double = CDbl(txtHoras.Text) 'Converte texto em Double
        Dim MObra As Double = ValorHora * horas
        Dim partes As Double = CDbl(txtCusto.Text)
        Dim CustoTotal As Double = MObra + partes ' varia´vel para clacular o total do orçamento

        ListBox1.Items.Clear()
        ListBox1.Items.Add("Nome do Cliente: " & txtCliente.Text)
        ListBox1.Items.Add("Mão de Obra: " & MObra.ToString("C")) 'Faz aparecr o sinal de moeda
        ListBox1.Items.Add("Valor das peças: " & partes.ToString("€ 0.00"))
        ListBox1.Items.Add("Total a pagar: " & CustoTotal.ToString("0.00 €"))


    End Sub
End Class

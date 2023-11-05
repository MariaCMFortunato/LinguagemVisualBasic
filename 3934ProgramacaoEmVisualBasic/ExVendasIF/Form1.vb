Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Vendas As Integer
        Vendas = txtVendas.Text

        If Vendas < 200 Then
            MessageBox.Show("Tem de se esforçar mais ...")
            lblVendas.ForeColor = Color.Red
            lblVendas.Text = "Tem de se esforçar mais ... O valor apresentado é: " + Vendas.ToString

        ElseIf Vendas < 400 Then
            MessageBox.Show("Pode melhorar!")
            lblVendas.ForeColor = Color.Blue
            lblVendas.Text = "Pode melhorar! O valor apresentado é: " + Vendas.ToString
        ElseIf Vendas < 600 Then
            MessageBox.Show("Bom!")
            lblVendas.ForeColor = Color.DarkOrange
            lblVendas.Text = "Bom! O valor apresentado é: " + Vendas.ToString
        ElseIf Vendas < 800 Then
            MessageBox.Show("Muito Bom!")
            lblVendas.ForeColor = Color.BlueViolet
            lblVendas.Text = "Muito Bom! O valor apresentado é: " + Vendas.ToString
        Else
            MessageBox.Show("Excelente!!!")
            lblVendas.ForeColor = Color.Green
            lblVendas.Text = "Excelente!!! O valor apresentado é: " + Vendas.ToString

        End If
    End Sub

End Class

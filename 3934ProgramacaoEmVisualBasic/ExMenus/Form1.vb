Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Não preencheu os Campos todos")

        End If
        If TextBox1.Text = "Maria" Or TextBox2.Text = "teste123" Then
            MessageBox.Show("Irá aceder à aplicação de Marketing")
            Form2.Show()

        End If



    End Sub
End Class

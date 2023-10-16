Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dia As Date
        Dia = DateTimePicker1.Value

        MessageBox.Show("A data escolhida é : " & Dia)

        lblData.Text = "A data fica marcada para " & Dia



    End Sub
End Class

Public Class Programa
    Private Sub Programa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form1.a

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contador As Integer
        Do Until contador = 20
            ComboBox1.Items.Add(contador)
            contador = contador + 1
        Loop
    End Sub
End Class
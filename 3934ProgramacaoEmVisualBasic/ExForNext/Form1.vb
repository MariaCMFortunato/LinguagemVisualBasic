Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo As Integer = 1
        Dim A As Integer = 0
        For A = 0 To 10 Step 1
            codigo = MessageBox.Show(A)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim contador As Integer
        For contador = 1 To 10 'step aqui não é necessário
            ListBox1.Items.Add(contador)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ano As Integer = Year(Now)
        Dim i As Integer = 0

        For i = 1 To 12
            ListBox2.Items.Add(ano + i)
        Next
    End Sub
End Class

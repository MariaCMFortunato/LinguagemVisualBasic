Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NFila As Integer
        NFila = TextBox1.Text

        Select Case NFila
            Case 1
                MessageBox.Show("É o próximo")'IF NFila = 1 Then

            Case 2 To 5
                MessageBox.Show("Será atendido em breve") 'ElseIf NFila >= 2 and NFila <= 5 Then
            Case 6, 7, 8
                MessageBox.Show("Tempo de espera Moderado") 'ElseIf NFila = 6 Or NFila = 7 Or NFila = 8 Then
            Case Else
                MessageBox.Show("Não será atendido hoje") 'Else

        End Select

    End Sub
End Class

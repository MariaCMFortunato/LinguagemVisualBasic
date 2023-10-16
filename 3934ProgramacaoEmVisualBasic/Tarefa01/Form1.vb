Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Linguagem As String
        Linguagem = ComboBox1.Text

        LblLinguagem.Text = ("Linguagem escolhida: " & Linguagem)

    End Sub

End Class

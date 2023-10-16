Public Class Form1
    Private Sub btnCor_Click(sender As Object, e As EventArgs) Handles btnCor.Click

        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
        'Label2.BackColor = ColorDialog1.Color

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Equipas As String

        Equipas = ComboBox1.Text
        MessageBox.Show("A equipa escolhida é " & Equipas)
        Label4.Text = (Equipas)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Notas As String
        Notas = ListBox1.Text
        Label6.Text = ("Atribui a Avaliação: " & Notas)

    End Sub
End Class

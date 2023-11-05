Public Class Form1
    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("Escolheu o Ronaldo - O melhor")
        ElseIf CheckBox2.Checked = True Then
            MessageBox.Show("Escolheu o Messi  - 2nd Best")
        ElseIf CheckBox3.Checked = True Then
            MessageBox.Show("Escolheu o Neymar  - 2nd Best")
        Else
            MessageBox.Show("Escolheu o Mbape  - 2nd Best")
        End If
    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Label1.Text = RadioButton1.Text + "será Campeão!"
        ElseIf RadioButton2.Checked = True Then
            Label1.Text = RadioButton2.Text + "será Campeão!"
        Else
            Label1.Text = RadioButton3.Text + "será Campeão!"
        End If
    End Sub

End Class

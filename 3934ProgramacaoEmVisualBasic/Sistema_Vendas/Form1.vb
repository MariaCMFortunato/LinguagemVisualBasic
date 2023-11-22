Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Lisboa"
                txtPartida.Text = "Lisboa"

            Case "Porto"
                txtPartida.Text = "Porto"

            Case "Coimbra"
                txtPartida.Text = "Coimbra"

            Case "Braga"
                txtPartida.Text = "Braga"

            Case "Faro"
                txtPartida.Text = "Faro"
        End Select
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Select Case ListBox2.SelectedItem
            Case "Lisboa"
                txtDestino.Text = "Lisboa"
                txtPUnit.Text = "15"

            Case "Porto"
                txtDestino.Text = "Porto"
                txtPUnit.Text = "15"

            Case "Coimbra"
                txtDestino.Text = "Coimbra"

            Case "Braga"
                txtDestino.Text = "Braga"

            Case "Faro"
                txtDestino.Text = "Faro"
        End Select
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtvalPagar.Text = Val(txtPUnit.Text) * txtBilhete.Text

        txtTroco.Text = Val(txtValEntreg.Text) - txtvalPagar.Text

    End Sub
End Class

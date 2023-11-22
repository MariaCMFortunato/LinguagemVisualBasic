Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Pagamento As Single
        Dim PagInicio As DueDate

        If CheckBox1.Checked Then
            PagInicio = DueDate.BegOfPeriod

        Else
            PagInicio = DueDate.EndOfPeriod

        End If

        Pagamento = Pmt(0.01 * txtJuros.Text / 12, txtPrazo.Text, -txtValor.Text, 0, PagInicio)

        txtPagam.Text = Pagamento.ToString("#.00")

    End Sub
End Class

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataIn As Date
        Dim DataFim As Date
        Dim IntDias As Integer

        'Validar as datas escritas
        If Not IsDate(txtDataInic.Text) Then
            MessageBox.Show("Por favor, digite a Data Inicial corretamente.", "Data de Aluguer")
            txtDataInic.Focus()
        End If

        If Not IsDate(txtDataFinal.Text) Then
            MessageBox.Show("Por favor, digite a Data Inicial corretamente.", "Data de Entrega")
            txtDataFinal.Focus()
        End If

        DataIn = CDate(txtDataInic.Text)
        DataFim = CDate(txtDataFinal.Text)

        IntDias = DateDiff(DateInterval.Day, DataIn, DataFim)

        lblDif.Text = CStr(IntDias)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDataInic.Text = ""
        txtDataFinal.Text = ""
        lblDif.Text = ""
    End Sub

    Private Sub btnCalc2_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        'DateTimePicker Só conta noites, não conta dias























        lbolDif2.Text = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub
End Class

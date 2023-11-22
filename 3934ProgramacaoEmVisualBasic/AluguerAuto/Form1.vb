Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataAluguer As Date
        Dim DataFinal As Date
        Dim KmInicial As Integer
        Dim KmFinal As Integer
        Dim NDias As Integer
        Dim Kms As Integer
        Dim TotalDias As Integer
        Dim TotalKm As Single
        Dim ValorTotal As Integer

        'Cálculo de datas e valor total a pagar
        DataAluguer = CDate(txtInicio.Text)
        DataFinal = CDate(txtEntrega.Text)

        NDias = DateDiff(DateInterval.Day, DataAluguer, DataFinal)
        NDias = NDias + 1
        TotalDias = NDias * 35

        KmInicial = Val(txtKmInicio.Text)
        KmFinal = Val(txtKmFinal.Text)
        Kms = KmFinal - KmInicial
        TotalKm = Kms * 0.1
        ValorTotal = TotalKm + TotalDias

        lblDias.Text = CStr(NDias)
        lblkm.Text = CStr(Kms)
        lblPagamento.Text = Format(TotalDias, "Currency")
        lblPagKms.Text = Format(TotalKm, "Currency")
        lblTotal.Text = Format(ValorTotal, "Currency")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtInicio.Clear()
        txtEntrega.Clear()
        txtKmInicio.Clear()
        txtKmFinal.Clear()
        lblDias.Text = "--"
        lblkm.Text = "--"
        lblPagamento.Text = "--"
        lblPagKms.Text = "--"
        lblTotal.Text = "--"
    End Sub

End Class

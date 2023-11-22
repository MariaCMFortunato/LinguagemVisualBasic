Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const LX As Integer = 100
        Const PA As Integer = 500
        Const SD As Integer = 200
        Const CW As Integer = 80
        Const HM As Integer = 300
        Const AM As Integer = 150

        Dim Soma As Integer

        If CheckBox1.Checked = True Then
            Soma += LX
        End If

        If CheckBox2.Checked = True Then
            Soma += PA
        End If

        If CheckBox3.Checked = True Then
            Soma += SD
        End If


        If CheckBox6.Checked = True Then
            Soma += CW
        End If

        If CheckBox5.Checked = True Then
            Soma += HM
        End If

        If CheckBox4.Checked = True Then
            Soma += AM
        End If

        lblPagar.Text = Soma.ToString("C")

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        lblPagar.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False

    End Sub
End Class

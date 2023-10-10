Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'variavel tipo Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = InputBox("Insira um Valor")
        b = InputBox("Insira outro valor")

        c = a + b

        MsgBox("A variável C vale: " & c)
        '& concatenação de variável numérica

        Label2.Text = c
        Label3.Text = a
        Label4.Text = " + "
        Label5.Text = b
    End Sub

End Class
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub
End Class

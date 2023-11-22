Public Class Form1
    Public a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        lblNumero.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5 'é + 5 por cento, neste caso
        lblNumero.Text = ProgressBar1.Value & "%" & " completo"

        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False

            If txtNome.Text = "Maria" And TxtPassword.Text = "teste123" Then
                MsgBox("BemVindo", MsgBoxStyle.Information, "Maria")
                ProgressBar1.Value = 0
                a = txtNome.Text
                Programa.Show()
            Else
                MsgBox("Dados inválidos", MsgBoxStyle.Information, "Repetir")
                lblNumero.Text = ""
                ProgressBar1.Value = 0
                txtNome.Focus()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblNumero.Visible = True
        ProgressBar1.Visible = True
        Timer1.Enabled = True
    End Sub
End Class

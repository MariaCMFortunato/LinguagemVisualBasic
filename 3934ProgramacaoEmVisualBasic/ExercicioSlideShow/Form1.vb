Imports System.IO

Public Class Form1
    Dim Imagens() As String
    'Trata-se de um array de strings onde será armazenado o caminho das imagens
    Dim contador As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuCarregar_Click(sender As Object, e As EventArgs) Handles mnuCarregar.Click
        Dim fdb1 As New FolderBrowserDialog
        fdb1.Description = "Selecione uma pasta para Exibir Imagens"
        fdb1.RootFolder = Environment.SpecialFolder.MyComputer
        fdb1.ShowNewFolderButton = True
        'Exibe a caixa de diálogo
        If fdb1.ShowDialog = DialogResult.OK Then
            'Carrega as imagens na pasta selecionada
            CarregaImagens(fdb1.SelectedPath)
        End If
    End Sub
    Private Sub CarregaImagens(ByVal pasta As String)
        Imagens = Directory.GetFiles(pasta, "*.jpeg")
        PicImagem.Image = Image.FromFile(Imagens(0))
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador += 1
        If Imagens.Length = contador Then
            contador = 0
        End If
        PicImagem.Image = Image.FromFile(Imagens(contador))
    End Sub

    Private Sub tsbtnSeguinte_Click(sender As Object, e As EventArgs) Handles tsbtnSeguinte.Click
        Timer1.Enabled = False
        contador += 1
        If Imagens.Length = contador Then
            contador = 0
        End If
        PicImagem.Image = Image.FromFile(Imagens(contador))
        Timer1.Enabled = True
    End Sub

    Private Sub tsbtnAnterior_Click(sender As Object, e As EventArgs) Handles tsbtnAnterior.Click
        Timer1.Enabled = False
        If contador = 0 Then
            contador = Imagens.Length
        End If
        contador -= 1
        PicImagem.Image = Image.FromFile(Imagens(contador))
        Timer1.Enabled = True
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        If (MessageBox.Show("Deseja encerrar o programa?", "Sair",
                            MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Application.Exit()
        End If

    End Sub
End Class

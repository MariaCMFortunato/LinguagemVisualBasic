Imports System.Data.OleDb
Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conn As New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source = G:\Documentos\01Docs\06_IEF_FORMACAO\001_Programador_Informatica\3934-ProgramacaoEmVisualBasic_KundanNarendra\dados.xlsx;Extended Properties= Excel 8.0")
        Conn.Open()

        Dim cmd As New OleDbCommand("Select * from [f1$] where ID=@id1", Conn)
        cmd.Parameters.AddWithValue("Id1", TextBox1.Text)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader

        If myReader.Read Then
            TextBox2.Text = myReader("Nome")
            TextBox3.Text = myReader("Idade")
            TextBox4.Text = myReader("Clube")
        Else
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            MessageBox.Show("Sem Dados para apresentar")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.View = View.Details

        'Colunas que aparecerão com os titulos e respetivo tamanho
        ListView1.Columns.Add("Id", 50)
        ListView1.Columns.Add("Nome", 300)
        ListView1.Columns.Add("Idade", 50)
        ListView1.Columns.Add("Clube", 150)

        ListView1.GridLines = True
        'Ligação ao ficheiro de excel
        Dim Conn As New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source = G:\Documentos\01Docs\06_IEF_FORMACAO\001_Programador_Informatica\3934-ProgramacaoEmVisualBasic_KundanNarendra\dados.xlsx;Extended Properties= Excel 8.0")
        Conn.Open()

        Dim cmd As New OleDbCommand("Select * from [f1$]", Conn)
        Dim da As OleDbDataReader = cmd.ExecuteReader
        Do While da.Read = True
            Dim list1 = ListView1.Items.Add(da(0))
            list1.SubItems.Add(da(1))
            list1.SubItems.Add(da(2))
            list1.SubItems.Add(da(3))
        Loop
        Conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class

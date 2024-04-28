Imports System.Data.SqlClient
Public Class LogIn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNome.Text.Length <= 0 Then
            MessageBox.Show("Dgite o seu Nome de Utilizaor!")
        ElseIf txtPassword.Text.Length <= 0 Then
            MessageBox.Show("Dgite a sua Password0!")
        End If
        Dim str As String = "Data Source=(localdb)\MSSQLLocalDB;Database=Dados.mdb;Integrated Security=True"
        Dim sql As String = "select count(*) from utilizadores Nome=@nome and Password=@password"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then
                    MessageBox.Show("Login efetuado com sucesso!")
                    Form1.Show()
                End If
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Clear()
        txtNome.Clear()
        txtNome.Focus()
    End Sub
End Class
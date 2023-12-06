Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Rh.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim Result As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "INSERT INTO nomes (Id, Nome, Apelido) values('" & txtId.Text & "';'" & txtNome.Text & "';'" & txtApelido.Text & "');"


    End Sub

    Private Sub saveData(sql As String)
        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                Result = .ExecuteNonQuery
            End With
            If Result > 0 Then
                MessageBox.Show("Dados inseridos com sucesso")
            Else
                MessageBox.Show("Erro de introdução")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class

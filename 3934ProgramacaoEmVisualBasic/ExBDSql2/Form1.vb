Imports System.Data.SqlClient
Public Class Form1
    'Variável com ligação à BD

    'Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\clientes.mdf;Integrated Security=True;")
    Public strConexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\clientes.mdf;Integrated Security=True;"
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    'Public objCommand As SqlCommand(strInstrucao, objConexa)

    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        strInstrucao = "INSERT INTO clientes VALUES(@nome,@cidade,@email)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objCommand.Parameters.AddWithValue("(@nome", "clientes.Nome")
        objCommand.Parameters.AddWithValue("(@cidade", "clientes.Cidade")
        objCommand.Parameters.AddWithValue("(@email", "clientes.eMail")

    End Sub
End Class

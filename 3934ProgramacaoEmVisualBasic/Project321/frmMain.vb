
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class frmMain

    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim datatable As New DataTable
    Dim cmd As New OleDbCommand

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\db_project321.mdb"
        showData() 'função que mostra os dados na dtagridview

    End Sub

    Private Sub showData()
        Dim dbCommand As String
        dbCommand = "Select * from Info"
        adt = New OleDbDataAdapter(dbCommand, dbconn)
        datatable = New DataTable
        adt.Fill(datatable)
        dgvInfo.DataSource = datatable


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Guardar Informação inserida?", "Guardar", MessageBoxButtons.YesNo)

        If dr = DialogResult.No Then

        Else
            If Len(Trim(txtSurname.Text)) = 0 Then
                MessageBox.Show("Digite o Nome", "Guardar", MessageBoxButtons.OK)
                txtSurname.Focus()
            ElseIf Len(Trim(txtEmail.Text)) = 0 Then
                MessageBox.Show("Digite o E-mail", "Guardar", MessageBoxButtons.OK)
                txtEmail.Focus()
            ElseIf Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Digite a Morada", "Guardar", MessageBoxButtons.OK)
                txtAddress.Focus()
            ElseIf Len(Trim(txtContact_no.Text)) = 0 Then
                MessageBox.Show("Digite a Morada", "Guardar", MessageBoxButtons.OK)
                txtContact_no.Focus()
            Else
                adt = New OleDbDataAdapter("Insert into Info(Nome, email,Morada,Contacto) values ('" & txtSurname.Text & "', '" & txtEmail.Text & "', '" & txtAddress.Text & "', '" & txtContact_no.Text & "')", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData()
                MessageBox.Show("Dados inseridos com sucesso!")
                clearText()
            End If
        End If
    End Sub
    Sub clearText()
        txtSurname.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContact_no.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            Dim sql = "Select * from info where id like " & txtID.Text & ""
            adt = New OleDbDataAdapter(sql, dbconn)
            cmd = New OleDbCommand(sql)
            adt.Fill(ds, "info")

            txtSurname.Text = ds.Tables("info").Rows(0)(1).ToString
            txtEmail.Text = ds.Tables("info").Rows(0)(2).ToString
            txtAddress.Text = ds.Tables("info").Rows(0)(3).ToString
            txtContact_no.Text = ds.Tables("info").Rows(0)(4).ToString

            ds = New DataSet

        Catch ex As Exception
            MsgBox("Não existem dados da Pesquisa", MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class

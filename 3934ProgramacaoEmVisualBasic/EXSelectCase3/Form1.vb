Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Short"
                Dim VarShort As Short
                TextBox1.Text = VarShort.MinValue
                TextBox2.Text = VarShort.MaxValue
            Case "Integer"
                Dim VarInteger As Integer
                TextBox1.Text = VarInteger.MinValue
                TextBox2.Text = VarInteger.MaxValue
            Case "Long"
                Dim VarLong As Long
                TextBox1.Text = VarLong.MinValue
                TextBox2.Text = VarLong.MaxValue
            Case "Single"
                Dim VarSingle As Single
                TextBox1.Text = VarSingle.MinValue
                TextBox2.Text = VarSingle.MaxValue
            Case "Double"
                Dim VarDouble As Double
                TextBox1.Text = VarDouble.MinValue
                TextBox2.Text = VarDouble.MaxValue
            Case "String"
                Dim VarString As String
                TextBox1.Text = "Informação não disponível"
                TextBox2.Text = "Informação não disponível"
            Case "Char"
                Dim VarChar As Char
                TextBox1.Text = VarChar.MinValue
                TextBox2.Text = VarChar.MaxValue
            Case "bit"
                Dim Varbit As String
                TextBox1.Text = "Bit não é um tipo válido"
                TextBox2.Text = "Bit não é um tipo válido"
            Case "Byte"
                Dim VarByte As Byte
                TextBox1.Text = VarByte.MinValue
                TextBox2.Text = VarByte.MaxValue
            Case "Decimal"
                Dim VarDecimal As Decimal
                TextBox1.Text = VarDecimal.MinValue
                TextBox2.Text = VarDecimal.MaxValue

        End Select

    End Sub
End Class

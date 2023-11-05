Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("Menu Big Tasty Duplo", "7.90")
        DataGridView1.Rows.Add("Big Tasty Mac", "6.65")
        DataGridView1.Rows.Add("McMenu Duplo X Frango", "5.90")
        DataGridView1.Rows.Add("McMenu Duplo X Bacon", "3.90")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        TextBox4.Text = (Val(TextBox3.Text) - Val(TextBox2.Text)).ToString("0.00")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.lblItem.Text = TextBox1.Text
        Form2.lblValor.Text = TextBox2.Text & " €"
        Form2.lblPago.Text = TextBox3.Text & " €"
        Form2.lblTroco.Text = TextBox4.Text & " €"
        Form2.Show()

    End Sub
End Class

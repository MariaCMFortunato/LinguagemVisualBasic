Public Class Form1
    Dim x As Integer
    Dim preco As Integer

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        x = ListView1.FocusedItem.Index
        If x = 0 Then
            MessageBox.Show("Seleccionou a Mala Karina, preço: 200€", "Foto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 200
            txtValor.Text = preco.ToString()
        ElseIf x = 1 Then
            MessageBox.Show("Seleccionou a Mala Fortunato, preço: 300€", "Foto2", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 300
            txtValor.Text = preco.ToString()

        ElseIf x = 2 Then
            MessageBox.Show("Seleccionou a Mala Joana, preço: 380€", "Foto3", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 380
            txtValor.Text = preco.ToString()

        ElseIf x = 3 Then
            MessageBox.Show("Seleccionou a Mala Jaqueline, preço: 420€", "Foto4", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 420
            txtValor.Text = preco.ToString()

        ElseIf x = 4 Then
            MessageBox.Show("Seleccionou a Mala Eduarda, preço: 460€", "Foto5", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 460
            txtValor.Text = preco.ToString()

        ElseIf x = 5 Then
            MessageBox.Show("Seleccionou a Mala Emilia, preço: 480€", "Foto6", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Add(ListView1.FocusedItem.Text)
            preco = preco + 480
            txtValor.Text = preco.ToString()

        End If

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click

        If lstCart.SelectedItem = "Mala 1" Then
            'MessageBox.Show("Seleccionou a Mala Karina, preço: 200€", "Foto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 200
            txtValor.Text = preco.ToString()
        ElseIf lstCart.SelectedItem = "Mala 2" Then
            'MessageBox.Show("Seleccionou a Mala Fortunato, preço: 300€", "Foto2", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 300
            txtValor.Text = preco.ToString()

        ElseIf lstCart.SelectedItem = "Mala 3" Then
            'MessageBox.Show("Seleccionou a Mala Joana, preço: 380€", "Foto3", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 380
            txtValor.Text = preco.ToString()

        ElseIf lstCart.SelectedItem = "Mala 4" Then
            'MessageBox.Show("Seleccionou a Mala Jaqueline, preço: 420€", "Foto4", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 420
            txtValor.Text = preco.ToString()

        ElseIf lstCart.SelectedItem = "Mala 5" Then
            'MessageBox.Show("Seleccionou a Mala Eduarda, preço: 460€", "Foto5", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 460
            txtValor.Text = preco.ToString()

        ElseIf lstCart.SelectedItem = "Mala 6" Then
            'MessageBox.Show("Seleccionou a Mala Emilia, preço: 480€", "Foto6", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstCart.Items.Remove(lstCart.SelectedItem)
            preco = preco - 480
            txtValor.Text = preco.ToString()

        End If
    End Sub

    Private Sub btnSubmeter_Click(sender As Object, e As EventArgs) Handles btnSubmeter.Click
        MessageBox.Show("Obrigado por comprar na nossa Loja", "Loja MF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub
End Class

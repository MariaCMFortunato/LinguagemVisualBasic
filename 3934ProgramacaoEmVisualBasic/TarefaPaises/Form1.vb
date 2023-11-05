Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Português"
                lblBV.Text = "Olá, bem-vindo a Portugal!"
            Case "Inglês"
                lblBV.Text = "Hello, welcome to England!"
            Case "Espanhol"
                lblBV.Text = "Hola, bienvenido a España!"
            Case "Alemão"
                lblBV.Text = "Hallo, willkommen in Deutschland!"
            Case "Francês"
                lblBV.Text = "Bonjour, bienvenue en France!"
            Case "Italiano"
                lblBV.Text = "Ciao, benvenuto in Italia!"

        End Select
    End Sub
End Class

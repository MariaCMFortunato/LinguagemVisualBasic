<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        txtPartida = New TextBox()
        txtDestino = New TextBox()
        txtPUnit = New TextBox()
        txtBilhete = New TextBox()
        txtValEntreg = New TextBox()
        txtTroco = New TextBox()
        btnCalcular = New Button()
        txtvalPagar = New TextBox()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(64, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(414, 43)
        Label1.TabIndex = 0
        Label1.Text = "Comboios de Portugal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 18)
        Label2.TabIndex = 1
        Label2.Text = "Cidade de Partida:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 18)
        Label3.TabIndex = 2
        Label3.Text = "Selecione o Destino:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label4.Location = New Point(285, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 18)
        Label4.TabIndex = 3
        Label4.Text = "Dados de pagamento:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(257, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 18)
        Label5.TabIndex = 4
        Label5.Text = "Partida:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(257, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 18)
        Label6.TabIndex = 5
        Label6.Text = "Destino:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(257, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 18)
        Label7.TabIndex = 6
        Label7.Text = "Preço Unitário:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(254, 235)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 18)
        Label8.TabIndex = 7
        Label8.Text = "Nº de Bilhetes:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(254, 321)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 18)
        Label9.TabIndex = 8
        Label9.Text = "Valor Entregue:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(257, 408)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 18)
        Label10.TabIndex = 9
        Label10.Text = "Troco:"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 16
        ListBox1.Items.AddRange(New Object() {"Lisboa", "Porto", "Coimbra", "Braga", "Faro"})
        ListBox1.Location = New Point(24, 116)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(129, 84)
        ListBox1.TabIndex = 10
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 16
        ListBox2.Items.AddRange(New Object() {"Lisboa", "Porto", "Coimbra", "Braga", "Faro"})
        ListBox2.Location = New Point(24, 268)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(129, 84)
        ListBox2.TabIndex = 11
        ' 
        ' txtPartida
        ' 
        txtPartida.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPartida.Location = New Point(387, 100)
        txtPartida.Name = "txtPartida"
        txtPartida.Size = New Size(221, 26)
        txtPartida.TabIndex = 12
        ' 
        ' txtDestino
        ' 
        txtDestino.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtDestino.Location = New Point(387, 141)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(221, 26)
        txtDestino.TabIndex = 13
        ' 
        ' txtPUnit
        ' 
        txtPUnit.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPUnit.Location = New Point(387, 184)
        txtPUnit.Name = "txtPUnit"
        txtPUnit.Size = New Size(221, 26)
        txtPUnit.TabIndex = 14
        ' 
        ' txtBilhete
        ' 
        txtBilhete.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtBilhete.Location = New Point(384, 227)
        txtBilhete.Name = "txtBilhete"
        txtBilhete.Size = New Size(221, 26)
        txtBilhete.TabIndex = 15
        ' 
        ' txtValEntreg
        ' 
        txtValEntreg.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtValEntreg.Location = New Point(384, 313)
        txtValEntreg.Name = "txtValEntreg"
        txtValEntreg.Size = New Size(221, 26)
        txtValEntreg.TabIndex = 16
        ' 
        ' txtTroco
        ' 
        txtTroco.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTroco.Location = New Point(384, 400)
        txtTroco.Name = "txtTroco"
        txtTroco.Size = New Size(221, 26)
        txtTroco.TabIndex = 17
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalcular.Location = New Point(458, 354)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(94, 31)
        btnCalcular.TabIndex = 18
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' txtvalPagar
        ' 
        txtvalPagar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtvalPagar.Location = New Point(384, 270)
        txtvalPagar.Name = "txtvalPagar"
        txtvalPagar.Size = New Size(221, 26)
        txtvalPagar.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(254, 278)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 18)
        Label11.TabIndex = 19
        Label11.Text = "Valor a pagar:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 447)
        Controls.Add(txtvalPagar)
        Controls.Add(Label11)
        Controls.Add(btnCalcular)
        Controls.Add(txtTroco)
        Controls.Add(txtValEntreg)
        Controls.Add(txtBilhete)
        Controls.Add(txtPUnit)
        Controls.Add(txtDestino)
        Controls.Add(txtPartida)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtPartida As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtPUnit As TextBox
    Friend WithEvents txtBilhete As TextBox
    Friend WithEvents txtValEntreg As TextBox
    Friend WithEvents txtTroco As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtvalPagar As TextBox
    Friend WithEvents Label11 As Label
End Class

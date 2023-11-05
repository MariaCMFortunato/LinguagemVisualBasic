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
        txtCliente = New TextBox()
        txtHoras = New TextBox()
        txtCusto = New TextBox()
        ListBox1 = New ListBox()
        btnCalculo = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 37)
        Label1.TabIndex = 0
        Label1.Text = "Pedido de orçamento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(27, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 18)
        Label2.TabIndex = 1
        Label2.Text = "Cliente: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(27, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 18)
        Label3.TabIndex = 2
        Label3.Text = " Número de horas:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(27, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 18)
        Label4.TabIndex = 3
        Label4.Text = "Valor das peças"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(27, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 18)
        Label5.TabIndex = 4
        Label5.Text = "Dados:"
        ' 
        ' txtCliente
        ' 
        txtCliente.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCliente.Location = New Point(98, 58)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(373, 26)
        txtCliente.TabIndex = 5
        ' 
        ' txtHoras
        ' 
        txtHoras.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtHoras.Location = New Point(169, 91)
        txtHoras.Name = "txtHoras"
        txtHoras.Size = New Size(100, 26)
        txtHoras.TabIndex = 6
        ' 
        ' txtCusto
        ' 
        txtCusto.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCusto.Location = New Point(169, 127)
        txtCusto.Name = "txtCusto"
        txtCusto.Size = New Size(100, 26)
        txtCusto.TabIndex = 7
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(104, 174)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(367, 109)
        ListBox1.TabIndex = 8
        ' 
        ' btnCalculo
        ' 
        btnCalculo.Location = New Point(336, 99)
        btnCalculo.Name = "btnCalculo"
        btnCalculo.Size = New Size(135, 50)
        btnCalculo.TabIndex = 9
        btnCalculo.Text = "Total a Pagar"
        btnCalculo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(524, 311)
        Controls.Add(btnCalculo)
        Controls.Add(ListBox1)
        Controls.Add(txtCusto)
        Controls.Add(txtHoras)
        Controls.Add(txtCliente)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Gestão de Oficina"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtCusto As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnCalculo As Button
End Class

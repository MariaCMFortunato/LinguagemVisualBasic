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
        txtCliente = New TextBox()
        Label3 = New Label()
        txtValor = New TextBox()
        btnCalcular = New Button()
        btnLimpar = New Button()
        Label4 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(52, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 28)
        Label1.TabIndex = 0
        Label1.Text = "Cálculo IVA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(52, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 16)
        Label2.TabIndex = 1
        Label2.Text = "Nome Cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(154, 69)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(424, 23)
        txtCliente.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(52, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 16)
        Label3.TabIndex = 3
        Label3.Text = "Valor Produto"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(154, 110)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(144, 23)
        txtValor.TabIndex = 4
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalcular.Location = New Point(420, 110)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(158, 35)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpar.Location = New Point(52, 162)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(526, 35)
        btnLimpar.TabIndex = 6
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(52, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 7
        Label4.Text = "Detalhes"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(58, 246)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(520, 154)
        ListBox1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 450)
        Controls.Add(ListBox1)
        Controls.Add(Label4)
        Controls.Add(btnLimpar)
        Controls.Add(btnCalcular)
        Controls.Add(txtValor)
        Controls.Add(Label3)
        Controls.Add(txtCliente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
End Class

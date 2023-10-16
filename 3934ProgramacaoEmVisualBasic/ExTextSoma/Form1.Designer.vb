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
        txtValor1 = New TextBox()
        txtValor2 = New TextBox()
        btnCalcular = New Button()
        btnLimpar = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(64, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 31)
        Label1.TabIndex = 0
        Label1.Text = "Exemplo textBox Visual Basic"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.CornflowerBlue
        Label2.Location = New Point(71, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 19)
        Label2.TabIndex = 1
        Label2.Text = "Valor 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.CornflowerBlue
        Label3.Location = New Point(71, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 19)
        Label3.TabIndex = 2
        Label3.Text = "Valor 2"
        ' 
        ' txtValor1
        ' 
        txtValor1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtValor1.Location = New Point(147, 143)
        txtValor1.Name = "txtValor1"
        txtValor1.Size = New Size(150, 26)
        txtValor1.TabIndex = 3
        ' 
        ' txtValor2
        ' 
        txtValor2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtValor2.Location = New Point(147, 192)
        txtValor2.Name = "txtValor2"
        txtValor2.Size = New Size(150, 26)
        txtValor2.TabIndex = 4
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(158, 255)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "Somar"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(306, 255)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(75, 23)
        btnLimpar.TabIndex = 6
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultado.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblResultado.Location = New Point(414, 163)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(60, 19)
        lblResultado.TabIndex = 7
        lblResultado.Text = "Label4"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 317)
        Controls.Add(lblResultado)
        Controls.Add(btnLimpar)
        Controls.Add(btnCalcular)
        Controls.Add(txtValor2)
        Controls.Add(txtValor1)
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
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents lblResultado As Label
End Class

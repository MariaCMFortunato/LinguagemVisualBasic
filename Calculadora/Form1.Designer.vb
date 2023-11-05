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
        btnSoma = New Button()
        btnSubtrai = New Button()
        btnMultiplica = New Button()
        btnDividir = New Button()
        btnLimpa = New Button()
        Label4 = New Label()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(58, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(402, 30)
        Label1.TabIndex = 0
        Label1.Text = "Calculadora  (Operações Básicas)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(58, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 22)
        Label2.TabIndex = 1
        Label2.Text = "Valor 1:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(58, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 22)
        Label3.TabIndex = 2
        Label3.Text = "Valor 2:"
        ' 
        ' txtValor1
        ' 
        txtValor1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtValor1.Location = New Point(157, 117)
        txtValor1.Name = "txtValor1"
        txtValor1.Size = New Size(100, 26)
        txtValor1.TabIndex = 3
        ' 
        ' txtValor2
        ' 
        txtValor2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtValor2.Location = New Point(157, 169)
        txtValor2.Name = "txtValor2"
        txtValor2.Size = New Size(100, 26)
        txtValor2.TabIndex = 4
        ' 
        ' btnSoma
        ' 
        btnSoma.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSoma.ForeColor = Color.Green
        btnSoma.Location = New Point(58, 240)
        btnSoma.Name = "btnSoma"
        btnSoma.Size = New Size(104, 35)
        btnSoma.TabIndex = 5
        btnSoma.Text = "Somar"
        btnSoma.UseVisualStyleBackColor = True
        ' 
        ' btnSubtrai
        ' 
        btnSubtrai.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubtrai.ForeColor = Color.Green
        btnSubtrai.Location = New Point(168, 240)
        btnSubtrai.Name = "btnSubtrai"
        btnSubtrai.Size = New Size(104, 35)
        btnSubtrai.TabIndex = 6
        btnSubtrai.Text = "Substrair"
        btnSubtrai.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplica
        ' 
        btnMultiplica.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMultiplica.ForeColor = Color.Green
        btnMultiplica.Location = New Point(278, 240)
        btnMultiplica.Name = "btnMultiplica"
        btnMultiplica.Size = New Size(104, 35)
        btnMultiplica.TabIndex = 7
        btnMultiplica.Text = "Multiplicar"
        btnMultiplica.UseVisualStyleBackColor = True
        ' 
        ' btnDividir
        ' 
        btnDividir.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDividir.ForeColor = Color.Green
        btnDividir.Location = New Point(388, 240)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(104, 35)
        btnDividir.TabIndex = 8
        btnDividir.Text = "Dividir"
        btnDividir.UseVisualStyleBackColor = True
        ' 
        ' btnLimpa
        ' 
        btnLimpa.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpa.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLimpa.Location = New Point(388, 298)
        btnLimpa.Name = "btnLimpa"
        btnLimpa.Size = New Size(104, 35)
        btnLimpa.TabIndex = 9
        btnLimpa.Text = "Limpar"
        btnLimpa.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(278, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 22)
        Label4.TabIndex = 10
        Label4.Text = "Resultado:"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblResultado.ForeColor = SystemColors.ControlDarkDark
        lblResultado.Location = New Point(407, 144)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(102, 22)
        lblResultado.TabIndex = 11
        lblResultado.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 367)
        Controls.Add(lblResultado)
        Controls.Add(Label4)
        Controls.Add(btnLimpa)
        Controls.Add(btnDividir)
        Controls.Add(btnMultiplica)
        Controls.Add(btnSubtrai)
        Controls.Add(btnSoma)
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
    Friend WithEvents btnSoma As Button
    Friend WithEvents btnSubtrai As Button
    Friend WithEvents btnMultiplica As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnLimpa As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResultado As Label
End Class

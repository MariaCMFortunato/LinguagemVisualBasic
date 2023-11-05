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
        txtNumero1 = New TextBox()
        txtNumero2 = New TextBox()
        lblMax = New Label()
        btnMax = New Button()
        btnLimpa = New Button()
        btnLog = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(37, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 33)
        Label1.TabIndex = 0
        Label1.Text = "Exemplos IF"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(37, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 18)
        Label2.TabIndex = 1
        Label2.Text = "Valor 1:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(37, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 18)
        Label3.TabIndex = 2
        Label3.Text = "Valor 2:"
        ' 
        ' txtNumero1
        ' 
        txtNumero1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumero1.Location = New Point(124, 72)
        txtNumero1.Name = "txtNumero1"
        txtNumero1.Size = New Size(100, 26)
        txtNumero1.TabIndex = 3
        ' 
        ' txtNumero2
        ' 
        txtNumero2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumero2.Location = New Point(124, 110)
        txtNumero2.Name = "txtNumero2"
        txtNumero2.Size = New Size(100, 26)
        txtNumero2.TabIndex = 4
        ' 
        ' lblMax
        ' 
        lblMax.AutoSize = True
        lblMax.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMax.Location = New Point(124, 159)
        lblMax.Name = "lblMax"
        lblMax.Size = New Size(28, 18)
        lblMax.TabIndex = 5
        lblMax.Text = "----"
        ' 
        ' btnMax
        ' 
        btnMax.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMax.Location = New Point(269, 64)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(88, 34)
        btnMax.TabIndex = 6
        btnMax.Text = "Clique"
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnLimpa
        ' 
        btnLimpa.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpa.Location = New Point(246, 110)
        btnLimpa.Name = "btnLimpa"
        btnLimpa.Size = New Size(124, 34)
        btnLimpa.TabIndex = 7
        btnLimpa.Text = "Limpar Valores"
        btnLimpa.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLog.Location = New Point(37, 189)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(125, 30)
        btnLog.TabIndex = 8
        btnLog.Text = "Login"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 271)
        Controls.Add(btnLog)
        Controls.Add(btnLimpa)
        Controls.Add(btnMax)
        Controls.Add(lblMax)
        Controls.Add(txtNumero2)
        Controls.Add(txtNumero1)
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
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents lblMax As Label
    Friend WithEvents btnMax As Button
    Friend WithEvents btnLimpa As Button
    Friend WithEvents btnLog As Button
End Class

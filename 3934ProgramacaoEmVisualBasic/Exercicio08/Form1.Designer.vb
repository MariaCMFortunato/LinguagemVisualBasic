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
        ColorDialog1 = New ColorDialog()
        btnCor = New Button()
        Label2 = New Label()
        ColorDialog2 = New ColorDialog()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        ListBox1 = New ListBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 33)
        Label1.TabIndex = 0
        Label1.Text = "Diversos controles"
        ' 
        ' btnCor
        ' 
        btnCor.Location = New Point(59, 54)
        btnCor.Name = "btnCor"
        btnCor.Size = New Size(75, 23)
        btnCor.TabIndex = 1
        btnCor.Text = "Mude a cor"
        btnCor.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(167, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(380, 27)
        Label2.TabIndex = 2
        Label2.Text = "Formatação de fundo do formulário"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 3
        Label3.Text = "Escolha uma equipa"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Sporting", "Portimonense", "Moreirense", "Braga", "Porto", "Benfica", "Vitória de Setúbal"})
        ComboBox1.Location = New Point(79, 115)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label4.Location = New Point(233, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 18)
        Label4.TabIndex = 5
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 15)
        Label5.TabIndex = 6
        Label5.Text = "Escolha a Avaliação"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Excelente", "Muito Bom", "Bom", "Suficiente", "Mau", "Péssimo"})
        ListBox1.Location = New Point(79, 181)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(121, 109)
        ListBox1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label6.Location = New Point(233, 193)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 18)
        Label6.TabIndex = 8
        Label6.Text = "Label6"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(593, 317)
        Controls.Add(Label6)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnCor)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnCor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
End Class

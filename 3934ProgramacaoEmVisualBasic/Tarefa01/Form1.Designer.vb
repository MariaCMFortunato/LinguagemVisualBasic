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
        ComboBox1 = New ComboBox()
        LblLinguagem = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(32, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 27)
        Label1.TabIndex = 0
        Label1.Text = "Tarefa 01 - Criação de uma combox "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"C", "C++", "C#", "Java", "Vb.Net", "ASP.Net", "Python", "JavaScript"})
        ComboBox1.Location = New Point(43, 90)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' LblLinguagem
        ' 
        LblLinguagem.AutoSize = True
        LblLinguagem.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblLinguagem.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        LblLinguagem.Location = New Point(213, 96)
        LblLinguagem.Name = "LblLinguagem"
        LblLinguagem.Size = New Size(24, 18)
        LblLinguagem.TabIndex = 2
        LblLinguagem.Text = "    "
        LblLinguagem.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(43, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(355, 27)
        Label2.TabIndex = 3
        Label2.Text = "com linguagens de programação"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(511, 211)
        Controls.Add(Label2)
        Controls.Add(LblLinguagem)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LblLinguagem As Label
    Friend WithEvents Label2 As Label
End Class

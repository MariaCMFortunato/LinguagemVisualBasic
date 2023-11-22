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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblNumero = New Label()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Timer1 = New Timer(components)
        txtNome = New TextBox()
        TxtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(489, 32)
        Label1.TabIndex = 0
        Label1.Text = "Exemplo de Login com progress Bar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(83, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 17)
        Label2.TabIndex = 1
        Label2.Text = "Nome do Utilizador:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(83, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 17)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblNumero.ForeColor = Color.Green
        lblNumero.Location = New Point(294, 188)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(16, 22)
        lblNumero.TabIndex = 3
        lblNumero.Text = "-"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ProgressBar1.Location = New Point(103, 213)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(381, 23)
        ProgressBar1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(264, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 27)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' txtNome
        ' 
        txtNome.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNome.Location = New Point(224, 68)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(260, 25)
        txtNome.TabIndex = 6
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(224, 133)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(260, 25)
        TxtPassword.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(566, 322)
        Controls.Add(TxtPassword)
        Controls.Add(txtNome)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(lblNumero)
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
    Friend WithEvents lblNumero As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtNome As TextBox
    Friend WithEvents TxtPassword As TextBox
End Class

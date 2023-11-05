<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUtilizador = New TextBox()
        txtPassword = New TextBox()
        btnLogIn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 40)
        Label1.TabIndex = 0
        Label1.Text = "Realizar Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 18)
        Label2.TabIndex = 1
        Label2.Text = "Preencher os dados e clique no botão Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 18)
        Label3.TabIndex = 2
        Label3.Text = "Nome Utilizador"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(33, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 18)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' txtUtilizador
        ' 
        txtUtilizador.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUtilizador.Location = New Point(198, 111)
        txtUtilizador.Name = "txtUtilizador"
        txtUtilizador.Size = New Size(199, 26)
        txtUtilizador.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(198, 150)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(199, 26)
        txtPassword.TabIndex = 5
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogIn.Location = New Point(202, 217)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(167, 39)
        btnLogIn.TabIndex = 6
        btnLogIn.Text = "Realizar Login"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 289)
        Controls.Add(btnLogIn)
        Controls.Add(txtPassword)
        Controls.Add(txtUtilizador)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "login"
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUtilizador As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
End Class

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopRight
        Label1.Location = New Point(12, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 32)
        Label1.TabIndex = 0
        Label1.Text = "Acesso ao Programa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(504, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(174, 205)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(156, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 18)
        Label3.TabIndex = 4
        Label3.Text = "Nome Utilizador"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 18)
        Label4.TabIndex = 6
        Label4.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(156, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(157, 161)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 38)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(410, 287)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class

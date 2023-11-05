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
        GroupBox1 = New GroupBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        btnVotar = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(38, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(392, 24)
        Label1.TabIndex = 0
        Label1.Text = "Escolha o Futebolista do Ano 2023 /24"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(38, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(235, 188)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nomes dos Jogadores"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(23, 139)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(63, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Mbape"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(24, 106)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(68, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Neymar"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(23, 68)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(94, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Leonel Messi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(21, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(120, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Cristiano Ronaldo"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnVotar
        ' 
        btnVotar.BackgroundImage = CType(resources.GetObject("btnVotar.BackgroundImage"), Image)
        btnVotar.Location = New Point(63, 283)
        btnVotar.Name = "btnVotar"
        btnVotar.Size = New Size(125, 51)
        btnVotar.TabIndex = 2
        btnVotar.Text = "Votar"
        btnVotar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(346, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 174)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 346)
        Controls.Add(PictureBox1)
        Controls.Add(btnVotar)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnVotar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

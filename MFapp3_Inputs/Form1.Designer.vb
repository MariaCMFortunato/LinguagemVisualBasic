<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblApelido = New System.Windows.Forms.Label()
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.lstOcupacao = New System.Windows.Forms.ListBox()
        Me.lblOcupacao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(80, 226)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(133, 50)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(80, 37)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(166, 20)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(39, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome:"
        '
        'lblApelido
        '
        Me.lblApelido.AutoSize = True
        Me.lblApelido.Location = New System.Drawing.Point(32, 79)
        Me.lblApelido.Name = "lblApelido"
        Me.lblApelido.Size = New System.Drawing.Size(45, 13)
        Me.lblApelido.TabIndex = 4
        Me.lblApelido.Text = "Apelido:"
        '
        'txtApelido
        '
        Me.txtApelido.Location = New System.Drawing.Point(80, 76)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(166, 20)
        Me.txtApelido.TabIndex = 3
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(32, 118)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 6
        Me.lblGenero.Text = "Género:"
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(80, 115)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(73, 20)
        Me.txtGenero.TabIndex = 5
        '
        'lstOcupacao
        '
        Me.lstOcupacao.FormattingEnabled = True
        Me.lstOcupacao.Items.AddRange(New Object() {"Médico(a)", "Programador(a)", "Professor(a)", "Estudante", "Funileiro(a)", "Alfaiate", "Soldado", "Marinheiro"})
        Me.lstOcupacao.Location = New System.Drawing.Point(290, 37)
        Me.lstOcupacao.Name = "lstOcupacao"
        Me.lstOcupacao.Size = New System.Drawing.Size(135, 186)
        Me.lstOcupacao.TabIndex = 7
        '
        'lblOcupacao
        '
        Me.lblOcupacao.AutoSize = True
        Me.lblOcupacao.Location = New System.Drawing.Point(291, 15)
        Me.lblOcupacao.Name = "lblOcupacao"
        Me.lblOcupacao.Size = New System.Drawing.Size(60, 13)
        Me.lblOcupacao.TabIndex = 8
        Me.lblOcupacao.Text = "Ocupação:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 300)
        Me.Controls.Add(Me.lblOcupacao)
        Me.Controls.Add(Me.lstOcupacao)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.lblApelido)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblApelido As Label
    Friend WithEvents txtApelido As TextBox
    Friend WithEvents lblGenero As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents lstOcupacao As ListBox
    Friend WithEvents lblOcupacao As Label
End Class

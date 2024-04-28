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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAnterior = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSeguinte = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCarregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicImagem = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAnterior, Me.tsbtnSeguinte})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 407)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(742, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnAnterior
        '
        Me.tsbtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAnterior.Image = Global.ExercicioLogIn.My.Resources.Resources.anterior
        Me.tsbtnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAnterior.Name = "tsbtnAnterior"
        Me.tsbtnAnterior.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAnterior.Text = "ToolStripButton1"
        Me.tsbtnAnterior.ToolTipText = "Exibe imagem anterior"
        '
        'tsbtnSeguinte
        '
        Me.tsbtnSeguinte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnSeguinte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSeguinte.Image = Global.ExercicioLogIn.My.Resources.Resources.proximo
        Me.tsbtnSeguinte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSeguinte.Name = "tsbtnSeguinte"
        Me.tsbtnSeguinte.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnSeguinte.Text = "ToolStripButton2"
        Me.tsbtnSeguinte.ToolTipText = "Exibe imagem seguinte"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImagensToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImagensToolStripMenuItem
        '
        Me.ImagensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCarregar, Me.mnuSair})
        Me.ImagensToolStripMenuItem.Name = "ImagensToolStripMenuItem"
        Me.ImagensToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ImagensToolStripMenuItem.Text = "Imagens"
        '
        'mnuCarregar
        '
        Me.mnuCarregar.Image = Global.ExercicioLogIn.My.Resources.Resources.mais
        Me.mnuCarregar.Name = "mnuCarregar"
        Me.mnuCarregar.Size = New System.Drawing.Size(180, 22)
        Me.mnuCarregar.Text = "Carregar"
        '
        'mnuSair
        '
        Me.mnuSair.Image = Global.ExercicioLogIn.My.Resources.Resources.Sair
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(180, 22)
        Me.mnuSair.Text = "Sair"
        '
        'PicImagem
        '
        Me.PicImagem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicImagem.Location = New System.Drawing.Point(0, 24)
        Me.PicImagem.Name = "PicImagem"
        Me.PicImagem.Size = New System.Drawing.Size(742, 383)
        Me.PicImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImagem.TabIndex = 1
        Me.PicImagem.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 432)
        Me.Controls.Add(Me.PicImagem)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnAnterior As ToolStripButton
    Friend WithEvents tsbtnSeguinte As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PicImagem As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImagensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCarregar As ToolStripMenuItem
    Friend WithEvents mnuSair As ToolStripMenuItem
End Class

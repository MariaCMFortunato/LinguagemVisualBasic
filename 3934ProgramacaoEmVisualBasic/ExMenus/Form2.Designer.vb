<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        FicheirosToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(30, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(530, 32)
        Label1.TabIndex = 0
        Label1.Text = "Exemplo com Menus e Caixa de Diálogo"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FicheirosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(600, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FicheirosToolStripMenuItem
        ' 
        FicheirosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbrirToolStripMenuItem, GuardarToolStripMenuItem})
        FicheirosToolStripMenuItem.Name = "FicheirosToolStripMenuItem"
        FicheirosToolStripMenuItem.Size = New Size(66, 20)
        FicheirosToolStripMenuItem.Text = "Ficheiros"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(180, 22)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(180, 22)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 377)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheirosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

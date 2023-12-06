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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 1", 0)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 2", 1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 3", 2)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 4", 3)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 5", 4)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mala 6", 5)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaImagem = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmeter = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carrinho de Compras "
        '
        'ListaImagem
        '
        Me.ListaImagem.ImageStream = CType(resources.GetObject("ListaImagem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagem.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagem.Images.SetKeyName(0, "b1.png")
        Me.ListaImagem.Images.SetKeyName(1, "b2.png")
        Me.ListaImagem.Images.SetKeyName(2, "b3.png")
        Me.ListaImagem.Images.SetKeyName(3, "b4.png")
        Me.ListaImagem.Images.SetKeyName(4, "b5.png")
        Me.ListaImagem.Images.SetKeyName(5, "b6.png")
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView1.LargeImageList = Me.ListaImagem
        Me.ListView1.Location = New System.Drawing.Point(28, 52)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(305, 460)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(358, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "A escolha"
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 18
        Me.lstCart.Location = New System.Drawing.Point(364, 85)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(361, 166)
        Me.lstCart.TabIndex = 3
        '
        'btnCart
        '
        Me.btnCart.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCart.Location = New System.Drawing.Point(364, 293)
        Me.btnCart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(128, 60)
        Me.btnCart.TabIndex = 4
        Me.btnCart.Text = "Adicionar"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemover.Location = New System.Drawing.Point(600, 293)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(128, 60)
        Me.btnRemover.TabIndex = 5
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 392)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total a Pagar:"
        '
        'btnSubmeter
        '
        Me.btnSubmeter.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmeter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmeter.Location = New System.Drawing.Point(364, 453)
        Me.btnSubmeter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmeter.Name = "btnSubmeter"
        Me.btnSubmeter.Size = New System.Drawing.Size(128, 60)
        Me.btnSubmeter.TabIndex = 7
        Me.btnSubmeter.Text = "Submeter"
        Me.btnSubmeter.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(517, 385)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(208, 26)
        Me.txtValor.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 753)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnSubmeter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Total a Pagar:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ListaImagem As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmeter As Button
    Friend WithEvents txtValor As TextBox
End Class

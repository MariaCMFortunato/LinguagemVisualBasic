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
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        Nome = New DataGridViewTextBoxColumn()
        Preco = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(425, 37)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de Pagamento MF"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(12, 106)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(255, 294)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menu"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nome, Preco})
        DataGridView1.Location = New Point(0, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(255, 186)
        DataGridView1.TabIndex = 0
        ' 
        ' Nome
        ' 
        Nome.HeaderText = "Produto"
        Nome.Name = "Nome"
        ' 
        ' Preco
        ' 
        Preco.HeaderText = "Preço"
        Preco.Name = "Preco"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(336, 112)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(339, 288)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pagamento"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(136, 231)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Limpar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(26, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Imprimir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(96, 180)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(127, 22)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(96, 132)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(127, 22)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(96, 85)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(161, 22)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(96, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(237, 22)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(19, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 16)
        Label5.TabIndex = 3
        Label5.Text = "Troco"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(19, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 16)
        Label4.TabIndex = 2
        Label4.Text = "Valor Pago"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(19, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 16)
        Label3.TabIndex = 1
        Label3.Text = "Preço"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(19, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 16)
        Label2.TabIndex = 0
        Label2.Text = "Produto"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Preco As DataGridViewTextBoxColumn
End Class

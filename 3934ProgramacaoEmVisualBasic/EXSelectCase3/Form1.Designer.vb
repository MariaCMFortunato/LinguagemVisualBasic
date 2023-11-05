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
        ListBox1 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Short", "Integer", "Long", "Single", "Double", "String", "Char", "bit", "Byte", "Decimal"})
        ListBox1.Location = New Point(50, 77)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(126, 154)
        ListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(31, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 37)
        Label1.TabIndex = 1
        Label1.Text = "Tipo de Dados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(211, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 3
        Label2.Text = "Valor minimo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(211, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 19)
        Label3.TabIndex = 4
        Label3.Text = "Valor Máximo"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(215, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(229, 22)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(215, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 22)
        TextBox2.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(505, 331)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class

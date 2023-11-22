<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programa
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
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label1.Location = New Point(27, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 28)
        Label1.TabIndex = 0
        Label1.Text = "BemVindo ao Sistema"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label2.Location = New Point(326, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 28)
        Label2.TabIndex = 1
        Label2.Text = "-"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(27, 109)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(242, 25)
        ComboBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(27, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 18)
        Label3.TabIndex = 3
        Label3.Text = "Exemplo Do Untill"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(38, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Clique"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Programa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(718, 322)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Programa"
        Text = "Programa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class

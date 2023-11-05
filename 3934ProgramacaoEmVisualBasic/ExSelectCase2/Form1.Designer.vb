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
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(52, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 28)
        Label1.TabIndex = 0
        Label1.Text = "Exemplo Select Case 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(52, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(266, 26)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(61, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 34)
        Button1.TabIndex = 2
        Button1.Text = "Analisar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(642, 395)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class

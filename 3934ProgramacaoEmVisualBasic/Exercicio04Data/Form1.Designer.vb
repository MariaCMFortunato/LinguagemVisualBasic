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
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        lblData = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(159, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 27)
        Label1.TabIndex = 0
        Label1.Text = "Exercício Data"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 15)
        Label2.TabIndex = 1
        Label2.Text = "Escolha a Data  da de Marcação"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(125, 123)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(127, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Clique aqui"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Location = New Point(127, 232)
        lblData.Name = "lblData"
        lblData.Size = New Size(0, 15)
        lblData.TabIndex = 4
        lblData.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(655, 380)
        Controls.Add(lblData)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents lblData As Label
End Class

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
        Label3 = New Label()
        Label4 = New Label()
        txtDataInic = New TextBox()
        txtDataFinal = New TextBox()
        lblDif = New Label()
        Button1 = New Button()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        lbolDif2 = New Label()
        btnCalc2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(93, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 32)
        Label1.TabIndex = 0
        Label1.Text = "Datas em Visual Basic"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 17)
        Label2.TabIndex = 1
        Label2.Text = "Data Inicial"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(58, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 17)
        Label3.TabIndex = 2
        Label3.Text = "Data Final"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(63, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 17)
        Label4.TabIndex = 3
        Label4.Text = "Nº de Dias"
        ' 
        ' txtDataInic
        ' 
        txtDataInic.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDataInic.Location = New Point(165, 112)
        txtDataInic.Name = "txtDataInic"
        txtDataInic.Size = New Size(185, 25)
        txtDataInic.TabIndex = 4
        ' 
        ' txtDataFinal
        ' 
        txtDataFinal.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDataFinal.Location = New Point(165, 168)
        txtDataFinal.Name = "txtDataFinal"
        txtDataFinal.Size = New Size(185, 25)
        txtDataFinal.TabIndex = 5
        ' 
        ' lblDif
        ' 
        lblDif.AutoSize = True
        lblDif.BorderStyle = BorderStyle.Fixed3D
        lblDif.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDif.Location = New Point(177, 228)
        lblDif.Name = "lblDif"
        lblDif.Size = New Size(20, 19)
        lblDif.TabIndex = 6
        lblDif.Text = "--"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(165, 281)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 27)
        Button1.TabIndex = 7
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(278, 281)
        Button2.Name = "Button2"
        Button2.Size = New Size(81, 27)
        Button2.TabIndex = 8
        Button2.Text = "Limpar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(391, 114)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 9
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(391, 170)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 10
        ' 
        ' lbolDif2
        ' 
        lbolDif2.AutoSize = True
        lbolDif2.BorderStyle = BorderStyle.Fixed3D
        lbolDif2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbolDif2.Location = New Point(391, 228)
        lbolDif2.Name = "lbolDif2"
        lbolDif2.Size = New Size(20, 19)
        lbolDif2.TabIndex = 11
        lbolDif2.Text = "--"
        ' 
        ' btnCalc2
        ' 
        btnCalc2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalc2.Location = New Point(391, 281)
        btnCalc2.Name = "btnCalc2"
        btnCalc2.Size = New Size(81, 27)
        btnCalc2.TabIndex = 12
        btnCalc2.Text = "Calcular 2"
        btnCalc2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 387)
        Controls.Add(btnCalc2)
        Controls.Add(lbolDif2)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblDif)
        Controls.Add(txtDataFinal)
        Controls.Add(txtDataInic)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Datas Cálculo de Dias"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDataInic As TextBox
    Friend WithEvents txtDataFinal As TextBox
    Friend WithEvents lblDif As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbolDif2 As Label
    Friend WithEvents btnCalc2 As Button
End Class

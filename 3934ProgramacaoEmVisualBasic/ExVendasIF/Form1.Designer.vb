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
        txtVendas = New TextBox()
        Button1 = New Button()
        lblVendas = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(27, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 32)
        Label1.TabIndex = 0
        Label1.Text = "Inserir Valor de Vendas"
        ' 
        ' txtVendas
        ' 
        txtVendas.Location = New Point(36, 67)
        txtVendas.Name = "txtVendas"
        txtVendas.Size = New Size(191, 23)
        txtVendas.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(36, 109)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 27)
        Button1.TabIndex = 2
        Button1.Text = "Análise"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblVendas
        ' 
        lblVendas.AutoSize = True
        lblVendas.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblVendas.Location = New Point(55, 158)
        lblVendas.Name = "lblVendas"
        lblVendas.Size = New Size(22, 23)
        lblVendas.TabIndex = 3
        lblVendas.Text = "..."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(565, 270)
        Controls.Add(lblVendas)
        Controls.Add(Button1)
        Controls.Add(txtVendas)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtVendas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblVendas As Label
End Class

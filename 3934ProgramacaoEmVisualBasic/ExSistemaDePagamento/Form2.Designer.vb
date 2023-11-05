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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblItem = New Label()
        lblValor = New Label()
        lblPago = New Label()
        lblTroco = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(66, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 32)
        Label1.TabIndex = 0
        Label1.Text = "Recibo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 17)
        Label2.TabIndex = 1
        Label2.Text = "Item:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(58, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 17)
        Label3.TabIndex = 2
        Label3.Text = "Preço:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(58, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 17)
        Label4.TabIndex = 3
        Label4.Text = "Valor Pago:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(58, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 4
        Label5.Text = "Troco:"
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblItem.Location = New Point(147, 96)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(24, 17)
        lblItem.TabIndex = 5
        lblItem.Text = "...."
        ' 
        ' lblValor
        ' 
        lblValor.AutoSize = True
        lblValor.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblValor.Location = New Point(147, 135)
        lblValor.Name = "lblValor"
        lblValor.Size = New Size(24, 17)
        lblValor.TabIndex = 6
        lblValor.Text = "...."
        ' 
        ' lblPago
        ' 
        lblPago.AutoSize = True
        lblPago.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPago.Location = New Point(147, 177)
        lblPago.Name = "lblPago"
        lblPago.Size = New Size(24, 17)
        lblPago.TabIndex = 7
        lblPago.Text = "...."
        ' 
        ' lblTroco
        ' 
        lblTroco.AutoSize = True
        lblTroco.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTroco.Location = New Point(147, 221)
        lblTroco.Name = "lblTroco"
        lblTroco.Size = New Size(24, 17)
        lblTroco.TabIndex = 8
        lblTroco.Text = "...."
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 335)
        Controls.Add(lblTroco)
        Controls.Add(lblPago)
        Controls.Add(lblValor)
        Controls.Add(lblItem)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents lblTroco As Label
End Class

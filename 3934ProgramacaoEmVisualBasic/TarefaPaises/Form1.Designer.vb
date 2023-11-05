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
        ListBox1 = New ListBox()
        lblBV = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(37, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(389, 32)
        Label1.TabIndex = 0
        Label1.Text = "Paises e seus cumprimentos"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.OldLace
        ListBox1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.ForeColor = Color.DimGray
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 17
        ListBox1.Items.AddRange(New Object() {"Português", "Inglês", "Espanhol", "Alemão", "Francês", "Italiano"})
        ListBox1.Location = New Point(68, 78)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 123)
        ListBox1.TabIndex = 1
        ' 
        ' lblBV
        ' 
        lblBV.AutoSize = True
        lblBV.BackColor = Color.AntiqueWhite
        lblBV.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblBV.ForeColor = Color.IndianRed
        lblBV.Location = New Point(230, 78)
        lblBV.Name = "lblBV"
        lblBV.Size = New Size(31, 24)
        lblBV.TabIndex = 2
        lblBV.Text = "---"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(657, 346)
        Controls.Add(lblBV)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblBV As Label
End Class

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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalculaQ = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAreaQ = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAltura = New System.Windows.Forms.Label()
        Me.txtAlt = New System.Windows.Forms.TextBox()
        Me.btnCalulaR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLargura = New System.Windows.Forms.Label()
        Me.txtAreaR = New System.Windows.Forms.TextBox()
        Me.txtLarg = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlt2 = New System.Windows.Forms.TextBox()
        Me.btnCalulaT = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAreaT = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lstHistorico = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(23, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cálculo de Áreas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalculaQ)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAreaQ)
        Me.GroupBox1.Controls.Add(Me.txtComp)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 113)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUADRADO"
        '
        'btnCalculaQ
        '
        Me.btnCalculaQ.BackColor = System.Drawing.Color.Teal
        Me.btnCalculaQ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculaQ.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalculaQ.Location = New System.Drawing.Point(258, 47)
        Me.btnCalculaQ.Name = "btnCalculaQ"
        Me.btnCalculaQ.Size = New System.Drawing.Size(76, 35)
        Me.btnCalculaQ.TabIndex = 9
        Me.btnCalculaQ.Text = "Calcular"
        Me.btnCalculaQ.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Área"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Comprimento"
        '
        'txtAreaQ
        '
        Me.txtAreaQ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaQ.Location = New System.Drawing.Point(112, 63)
        Me.txtAreaQ.Name = "txtAreaQ"
        Me.txtAreaQ.ReadOnly = True
        Me.txtAreaQ.Size = New System.Drawing.Size(100, 22)
        Me.txtAreaQ.TabIndex = 6
        '
        'txtComp
        '
        Me.txtComp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.Location = New System.Drawing.Point(112, 26)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(100, 22)
        Me.txtComp.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAltura)
        Me.GroupBox2.Controls.Add(Me.txtAlt)
        Me.GroupBox2.Controls.Add(Me.btnCalulaR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLargura)
        Me.GroupBox2.Controls.Add(Me.txtAreaR)
        Me.GroupBox2.Controls.Add(Me.txtLarg)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Location = New System.Drawing.Point(23, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 136)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RETÂNGULO"
        '
        'txtAltura
        '
        Me.txtAltura.AutoSize = True
        Me.txtAltura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(6, 66)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(41, 16)
        Me.txtAltura.TabIndex = 11
        Me.txtAltura.Text = "Altura"
        '
        'txtAlt
        '
        Me.txtAlt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt.Location = New System.Drawing.Point(112, 66)
        Me.txtAlt.Name = "txtAlt"
        Me.txtAlt.Size = New System.Drawing.Size(100, 22)
        Me.txtAlt.TabIndex = 10
        '
        'btnCalulaR
        '
        Me.btnCalulaR.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCalulaR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalulaR.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalulaR.Location = New System.Drawing.Point(258, 47)
        Me.btnCalulaR.Name = "btnCalulaR"
        Me.btnCalulaR.Size = New System.Drawing.Size(76, 35)
        Me.btnCalulaR.TabIndex = 9
        Me.btnCalulaR.Text = "Calcular"
        Me.btnCalulaR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Área"
        '
        'txtLargura
        '
        Me.txtLargura.AutoSize = True
        Me.txtLargura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLargura.Location = New System.Drawing.Point(6, 29)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(50, 16)
        Me.txtLargura.TabIndex = 7
        Me.txtLargura.Text = "Largura"
        '
        'txtAreaR
        '
        Me.txtAreaR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaR.Location = New System.Drawing.Point(112, 102)
        Me.txtAreaR.Name = "txtAreaR"
        Me.txtAreaR.ReadOnly = True
        Me.txtAreaR.Size = New System.Drawing.Size(100, 22)
        Me.txtAreaR.TabIndex = 6
        '
        'txtLarg
        '
        Me.txtLarg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLarg.Location = New System.Drawing.Point(112, 26)
        Me.txtLarg.Name = "txtLarg"
        Me.txtLarg.Size = New System.Drawing.Size(100, 22)
        Me.txtLarg.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtAlt2)
        Me.GroupBox3.Controls.Add(Me.btnCalulaT)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAreaT)
        Me.GroupBox3.Controls.Add(Me.txtBase)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox3.Location = New System.Drawing.Point(23, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(341, 136)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRIÂNGULO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Altura"
        '
        'txtAlt2
        '
        Me.txtAlt2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt2.Location = New System.Drawing.Point(112, 66)
        Me.txtAlt2.Name = "txtAlt2"
        Me.txtAlt2.Size = New System.Drawing.Size(100, 22)
        Me.txtAlt2.TabIndex = 10
        '
        'btnCalulaT
        '
        Me.btnCalulaT.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCalulaT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalulaT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalulaT.Location = New System.Drawing.Point(258, 47)
        Me.btnCalulaT.Name = "btnCalulaT"
        Me.btnCalulaT.Size = New System.Drawing.Size(76, 35)
        Me.btnCalulaT.TabIndex = 9
        Me.btnCalulaT.Text = "Calcular"
        Me.btnCalulaT.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Área"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Base"
        '
        'txtAreaT
        '
        Me.txtAreaT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaT.Location = New System.Drawing.Point(112, 102)
        Me.txtAreaT.Name = "txtAreaT"
        Me.txtAreaT.ReadOnly = True
        Me.txtAreaT.Size = New System.Drawing.Size(100, 22)
        Me.txtAreaT.TabIndex = 6
        '
        'txtBase
        '
        Me.txtBase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(112, 26)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 22)
        Me.txtBase.TabIndex = 5
        '
        'lstHistorico
        '
        Me.lstHistorico.FormattingEnabled = True
        Me.lstHistorico.ItemHeight = 16
        Me.lstHistorico.Location = New System.Drawing.Point(22, 29)
        Me.lstHistorico.Name = "lstHistorico"
        Me.lstHistorico.Size = New System.Drawing.Size(302, 308)
        Me.lstHistorico.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstHistorico)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(395, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(341, 359)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DADOS DE CÁLCULO"
        '
        'btnLimpa
        '
        Me.btnLimpa.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLimpa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLimpa.Location = New System.Drawing.Point(524, 427)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(76, 35)
        Me.btnLimpa.TabIndex = 11
        Me.btnLimpa.Text = "Limpar"
        Me.btnLimpa.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 485)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calcular Área"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalculaQ As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAreaQ As TextBox
    Friend WithEvents txtComp As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAltura As Label
    Friend WithEvents txtAlt As TextBox
    Friend WithEvents btnCalulaR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLargura As Label
    Friend WithEvents txtAreaR As TextBox
    Friend WithEvents txtLarg As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlt2 As TextBox
    Friend WithEvents btnCalulaT As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAreaT As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents lstHistorico As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLimpa As Button
End Class

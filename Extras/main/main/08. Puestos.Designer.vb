<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puestos))
        Me.AplyPuestos = New System.Windows.Forms.Button()
        Me.BackPuesto = New System.Windows.Forms.Button()
        Me.TB_NSP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_NP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AplyPuestos
        '
        Me.AplyPuestos.Location = New System.Drawing.Point(291, 169)
        Me.AplyPuestos.Name = "AplyPuestos"
        Me.AplyPuestos.Size = New System.Drawing.Size(75, 23)
        Me.AplyPuestos.TabIndex = 113
        Me.AplyPuestos.Text = "Aplicar"
        Me.AplyPuestos.UseVisualStyleBackColor = True
        '
        'BackPuesto
        '
        Me.BackPuesto.Location = New System.Drawing.Point(15, 169)
        Me.BackPuesto.Name = "BackPuesto"
        Me.BackPuesto.Size = New System.Drawing.Size(75, 23)
        Me.BackPuesto.TabIndex = 112
        Me.BackPuesto.Text = "Atrás"
        Me.BackPuesto.UseVisualStyleBackColor = True
        '
        'TB_NSP
        '
        Me.TB_NSP.Location = New System.Drawing.Point(118, 70)
        Me.TB_NSP.Name = "TB_NSP"
        Me.TB_NSP.Size = New System.Drawing.Size(143, 20)
        Me.TB_NSP.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Nivel Salarial:"
        '
        'TB_NP
        '
        Me.TB_NP.Location = New System.Drawing.Point(118, 37)
        Me.TB_NP.Name = "TB_NP"
        Me.TB_NP.Size = New System.Drawing.Size(164, 20)
        Me.TB_NP.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "%"
        '
        'Puestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 204)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AplyPuestos)
        Me.Controls.Add(Me.BackPuesto)
        Me.Controls.Add(Me.TB_NSP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TB_NP)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Puestos"
        Me.Text = "Puestos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AplyPuestos As Button
    Friend WithEvents BackPuesto As Button
    Friend WithEvents TB_NSP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_NP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

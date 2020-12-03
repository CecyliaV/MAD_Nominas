<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deducciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deducciones))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_NDV = New System.Windows.Forms.TextBox()
        Me.TB_NDP = New System.Windows.Forms.TextBox()
        Me.TB_NDN = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Aplicar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "%"
        '
        'TB_NDV
        '
        Me.TB_NDV.Location = New System.Drawing.Point(149, 80)
        Me.TB_NDV.Name = "TB_NDV"
        Me.TB_NDV.Size = New System.Drawing.Size(144, 20)
        Me.TB_NDV.TabIndex = 120
        '
        'TB_NDP
        '
        Me.TB_NDP.Location = New System.Drawing.Point(178, 106)
        Me.TB_NDP.Name = "TB_NDP"
        Me.TB_NDP.Size = New System.Drawing.Size(100, 20)
        Me.TB_NDP.TabIndex = 119
        '
        'TB_NDN
        '
        Me.TB_NDN.Location = New System.Drawing.Point(142, 38)
        Me.TB_NDN.Name = "TB_NDN"
        Me.TB_NDN.Size = New System.Drawing.Size(151, 20)
        Me.TB_NDN.TabIndex = 118
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(96, 106)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton3.TabIndex = 117
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Porcentaje"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(96, 83)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton4.TabIndex = 116
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Valor"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Nombre"
        '
        'Deducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 200)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_NDV)
        Me.Controls.Add(Me.TB_NDP)
        Me.Controls.Add(Me.TB_NDN)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Deducciones"
        Me.Text = "Deducciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_NDV As TextBox
    Friend WithEvents TB_NDP As TextBox
    Friend WithEvents TB_NDN As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label3 As Label
End Class

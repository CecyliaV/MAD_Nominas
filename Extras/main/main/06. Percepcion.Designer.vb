<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TB_NPN = New System.Windows.Forms.TextBox()
        Me.TB_NPP = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_NPV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(96, 84)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Valor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(96, 107)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Porcentaje"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TB_NPN
        '
        Me.TB_NPN.Location = New System.Drawing.Point(142, 39)
        Me.TB_NPN.Name = "TB_NPN"
        Me.TB_NPN.Size = New System.Drawing.Size(151, 20)
        Me.TB_NPN.TabIndex = 3
        '
        'TB_NPP
        '
        Me.TB_NPP.Location = New System.Drawing.Point(178, 107)
        Me.TB_NPP.Name = "TB_NPP"
        Me.TB_NPP.Size = New System.Drawing.Size(100, 20)
        Me.TB_NPP.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Aplicar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_NPV
        '
        Me.TB_NPV.Location = New System.Drawing.Point(149, 81)
        Me.TB_NPV.Name = "TB_NPV"
        Me.TB_NPV.Size = New System.Drawing.Size(144, 20)
        Me.TB_NPV.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "%"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 199)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_NPV)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_NPP)
        Me.Controls.Add(Me.TB_NPN)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Percepción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TB_NPN As TextBox
    Friend WithEvents TB_NPP As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_NPV As TextBox
    Friend WithEvents Label2 As Label
End Class

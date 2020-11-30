<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.TextBoxSBD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxND = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBGerente = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ApplyDept = New System.Windows.Forms.Button()
        Me.BackDept = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxSBD
        '
        Me.TextBoxSBD.Location = New System.Drawing.Point(118, 72)
        Me.TextBoxSBD.Name = "TextBoxSBD"
        Me.TextBoxSBD.Size = New System.Drawing.Size(164, 20)
        Me.TextBoxSBD.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Sueldo Base:"
        '
        'TextBoxND
        '
        Me.TextBoxND.Location = New System.Drawing.Point(118, 39)
        Me.TextBoxND.Name = "TextBoxND"
        Me.TextBoxND.Size = New System.Drawing.Size(164, 20)
        Me.TextBoxND.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Nombre:"
        '
        'CBGerente
        '
        Me.CBGerente.FormattingEnabled = True
        Me.CBGerente.Location = New System.Drawing.Point(135, 122)
        Me.CBGerente.Name = "CBGerente"
        Me.CBGerente.Size = New System.Drawing.Size(121, 21)
        Me.CBGerente.TabIndex = 103
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(132, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Gerente de Departamento"
        '
        'ApplyDept
        '
        Me.ApplyDept.Location = New System.Drawing.Point(288, 169)
        Me.ApplyDept.Name = "ApplyDept"
        Me.ApplyDept.Size = New System.Drawing.Size(75, 23)
        Me.ApplyDept.TabIndex = 105
        Me.ApplyDept.Text = "Aplicar"
        Me.ApplyDept.UseVisualStyleBackColor = True
        '
        'BackDept
        '
        Me.BackDept.Location = New System.Drawing.Point(12, 169)
        Me.BackDept.Name = "BackDept"
        Me.BackDept.Size = New System.Drawing.Size(75, 23)
        Me.BackDept.TabIndex = 104
        Me.BackDept.Text = "Atrás"
        Me.BackDept.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 204)
        Me.Controls.Add(Me.ApplyDept)
        Me.Controls.Add(Me.BackDept)
        Me.Controls.Add(Me.CBGerente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBoxSBD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxND)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSBD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxND As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBGerente As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ApplyDept As Button
    Friend WithEvents BackDept As Button
End Class

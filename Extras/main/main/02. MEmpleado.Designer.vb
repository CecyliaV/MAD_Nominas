<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarRecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IdEmpleado = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MisDatosToolStripMenuItem, Me.GenerarRecibosToolStripMenuItem, Me.SolicitarVacacionesToolStripMenuItem, Me.ResumenDePagosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MisDatosToolStripMenuItem
        '
        Me.MisDatosToolStripMenuItem.Name = "MisDatosToolStripMenuItem"
        Me.MisDatosToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.MisDatosToolStripMenuItem.Text = "Mis datos"
        '
        'GenerarRecibosToolStripMenuItem
        '
        Me.GenerarRecibosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReciboDeToolStripMenuItem})
        Me.GenerarRecibosToolStripMenuItem.Name = "GenerarRecibosToolStripMenuItem"
        Me.GenerarRecibosToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.GenerarRecibosToolStripMenuItem.Text = "Generar recibos"
        '
        'ReciboDeToolStripMenuItem
        '
        Me.ReciboDeToolStripMenuItem.Name = "ReciboDeToolStripMenuItem"
        Me.ReciboDeToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ReciboDeToolStripMenuItem.Text = "Recibo de Nomina"
        '
        'SolicitarVacacionesToolStripMenuItem
        '
        Me.SolicitarVacacionesToolStripMenuItem.Name = "SolicitarVacacionesToolStripMenuItem"
        Me.SolicitarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(133, 21)
        Me.SolicitarVacacionesToolStripMenuItem.Text = "Solicitar vacaciones"
        '
        'ResumenDePagosToolStripMenuItem
        '
        Me.ResumenDePagosToolStripMenuItem.Name = "ResumenDePagosToolStripMenuItem"
        Me.ResumenDePagosToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.ResumenDePagosToolStripMenuItem.Text = "Resumen de Pagos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Puesto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Departamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(331, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Número de Empleado:"
        '
        'IdEmpleado
        '
        Me.IdEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdEmpleado.Location = New System.Drawing.Point(144, 94)
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.Size = New System.Drawing.Size(120, 20)
        Me.IdEmpleado.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(380, 157)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 20)
        Me.TextBox6.TabIndex = 23
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(414, 127)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(164, 20)
        Me.TextBox7.TabIndex = 22
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(388, 94)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(190, 20)
        Me.TextBox8.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(617, 236)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.IdEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Empleado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MisDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarRecibosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarVacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents IdEmpleado As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ReciboDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenDePagosToolStripMenuItem As ToolStripMenuItem
End Class

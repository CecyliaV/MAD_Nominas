﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form11))
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.IdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarRecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteNominaGeneralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteHeadcounterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeNominaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(401, 106)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(190, 20)
        Me.TextBox8.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(95, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.TextBox2.TabIndex = 32
        '
        'IdEmpleado
        '
        Me.IdEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdEmpleado.Location = New System.Drawing.Point(157, 106)
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.Size = New System.Drawing.Size(120, 20)
        Me.IdEmpleado.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Número de Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Bienvenido"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MisDatosToolStripMenuItem, Me.GenerarRecibosToolStripMenuItem, Me.GenerarToolStripMenuItem, Me.SolicitarVacacionesToolStripMenuItem, Me.ResumenDePagosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 25)
        Me.MenuStrip1.TabIndex = 24
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
        'ReporteNominaGeneralToolStripMenuItem1
        '
        Me.ReporteNominaGeneralToolStripMenuItem1.Name = "ReporteNominaGeneralToolStripMenuItem1"
        Me.ReporteNominaGeneralToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
        Me.ReporteNominaGeneralToolStripMenuItem1.Text = "Reporte Nomina General"
        '
        'ReporteHeadcounterToolStripMenuItem1
        '
        Me.ReporteHeadcounterToolStripMenuItem1.Name = "ReporteHeadcounterToolStripMenuItem1"
        Me.ReporteHeadcounterToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
        Me.ReporteHeadcounterToolStripMenuItem1.Text = "Reporte Headcounter"
        '
        'ReporteDeNominaToolStripMenuItem1
        '
        Me.ReporteDeNominaToolStripMenuItem1.Name = "ReporteDeNominaToolStripMenuItem1"
        Me.ReporteDeNominaToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
        Me.ReporteDeNominaToolStripMenuItem1.Text = "Reporte de Nomina"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteNominaGeneralToolStripMenuItem1, Me.ReporteHeadcounterToolStripMenuItem1, Me.ReporteDeNominaToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Puesto:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(393, 143)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 20)
        Me.TextBox6.TabIndex = 35
        '
        'form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 232)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.IdEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form11"
        Me.Text = "Menu Gerente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents IdEmpleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MisDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarRecibosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReciboDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarVacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenDePagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteNominaGeneralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteHeadcounterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteDeNominaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
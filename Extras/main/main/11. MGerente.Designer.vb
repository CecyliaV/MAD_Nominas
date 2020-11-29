<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TBEmpresa = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.IdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EDIT_MisDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarRecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateDep = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteNominaGeneralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteHeadcounterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeNominaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBPuesto = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBEmpresa
        '
        Me.TBEmpresa.Location = New System.Drawing.Point(401, 106)
        Me.TBEmpresa.Name = "TBEmpresa"
        Me.TBEmpresa.ReadOnly = True
        Me.TBEmpresa.Size = New System.Drawing.Size(190, 20)
        Me.TBEmpresa.TabIndex = 33
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(95, 139)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.ReadOnly = True
        Me.TBNombre.Size = New System.Drawing.Size(182, 20)
        Me.TBNombre.TabIndex = 32
        '
        'IdEmpleado
        '
        Me.IdEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdEmpleado.Location = New System.Drawing.Point(157, 106)
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDIT_MisDatos, Me.GenerarRecibosToolStripMenuItem, Me.GenerarToolStripMenuItem, Me.SolicitarVacacionesToolStripMenuItem, Me.ResumenDePagosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EDIT_MisDatos
        '
        Me.EDIT_MisDatos.Name = "EDIT_MisDatos"
        Me.EDIT_MisDatos.Size = New System.Drawing.Size(70, 20)
        Me.EDIT_MisDatos.Text = "Mis datos"
        '
        'GenerarRecibosToolStripMenuItem
        '
        Me.GenerarRecibosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReciboDeToolStripMenuItem})
        Me.GenerarRecibosToolStripMenuItem.Name = "GenerarRecibosToolStripMenuItem"
        Me.GenerarRecibosToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.GenerarRecibosToolStripMenuItem.Text = "Generar recibos"
        '
        'ReciboDeToolStripMenuItem
        '
        Me.ReciboDeToolStripMenuItem.Name = "ReciboDeToolStripMenuItem"
        Me.ReciboDeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReciboDeToolStripMenuItem.Text = "Recibo de Nomina"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateEmpresa, Me.CreateDep, Me.CreateEmpleado})
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'CreateEmpresa
        '
        Me.CreateEmpresa.Name = "CreateEmpresa"
        Me.CreateEmpresa.Size = New System.Drawing.Size(180, 22)
        Me.CreateEmpresa.Text = "Empresa"
        '
        'CreateDep
        '
        Me.CreateDep.Name = "CreateDep"
        Me.CreateDep.Size = New System.Drawing.Size(180, 22)
        Me.CreateDep.Text = "Departamento"
        '
        'CreateEmpleado
        '
        Me.CreateEmpleado.Name = "CreateEmpleado"
        Me.CreateEmpleado.Size = New System.Drawing.Size(180, 22)
        Me.CreateEmpleado.Text = "Empleado"
        '
        'SolicitarVacacionesToolStripMenuItem
        '
        Me.SolicitarVacacionesToolStripMenuItem.Name = "SolicitarVacacionesToolStripMenuItem"
        Me.SolicitarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.SolicitarVacacionesToolStripMenuItem.Text = "Solicitar vacaciones"
        '
        'ResumenDePagosToolStripMenuItem
        '
        Me.ResumenDePagosToolStripMenuItem.Name = "ResumenDePagosToolStripMenuItem"
        Me.ResumenDePagosToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ResumenDePagosToolStripMenuItem.Text = "Resumen de Pagos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteNominaGeneralToolStripMenuItem1, Me.ReporteHeadcounterToolStripMenuItem1, Me.ReporteDeNominaToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteNominaGeneralToolStripMenuItem1
        '
        Me.ReporteNominaGeneralToolStripMenuItem1.Name = "ReporteNominaGeneralToolStripMenuItem1"
        Me.ReporteNominaGeneralToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ReporteNominaGeneralToolStripMenuItem1.Text = "Reporte Nomina General"
        '
        'ReporteHeadcounterToolStripMenuItem1
        '
        Me.ReporteHeadcounterToolStripMenuItem1.Name = "ReporteHeadcounterToolStripMenuItem1"
        Me.ReporteHeadcounterToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ReporteHeadcounterToolStripMenuItem1.Text = "Reporte Headcounter"
        '
        'ReporteDeNominaToolStripMenuItem1
        '
        Me.ReporteDeNominaToolStripMenuItem1.Name = "ReporteDeNominaToolStripMenuItem1"
        Me.ReporteDeNominaToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ReporteDeNominaToolStripMenuItem1.Text = "Reporte de Nomina"
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
        'TBPuesto
        '
        Me.TBPuesto.Location = New System.Drawing.Point(393, 143)
        Me.TBPuesto.Name = "TBPuesto"
        Me.TBPuesto.ReadOnly = True
        Me.TBPuesto.Size = New System.Drawing.Size(198, 20)
        Me.TBPuesto.TabIndex = 35
        '
        'form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 232)
        Me.Controls.Add(Me.TBPuesto)
        Me.Controls.Add(Me.TBEmpresa)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.IdEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Gerente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBEmpresa As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents IdEmpleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EDIT_MisDatos As ToolStripMenuItem
    Friend WithEvents GenerarRecibosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReciboDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarVacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenDePagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteNominaGeneralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteHeadcounterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteDeNominaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateDep As ToolStripMenuItem
    Friend WithEvents CreateEmpresa As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TBPuesto As TextBox
    Friend WithEvents CreateEmpleado As ToolStripMenuItem
End Class

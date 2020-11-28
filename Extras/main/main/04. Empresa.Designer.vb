<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaWnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpresaWnd))
        Me.DomEmpr = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBRSocial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBRPatronal = New System.Windows.Forms.TextBox()
        Me.TBNomEmpr = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBRFC = New System.Windows.Forms.TextBox()
        Me.TelEmpr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBFrecPago = New System.Windows.Forms.ComboBox()
        Me.CBGerente = New System.Windows.Forms.ComboBox()
        Me.OkayEmpresa = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTPEmpresa = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'DomEmpr
        '
        Me.DomEmpr.Location = New System.Drawing.Point(130, 97)
        Me.DomEmpr.Name = "DomEmpr"
        Me.DomEmpr.Size = New System.Drawing.Size(164, 20)
        Me.DomEmpr.TabIndex = 87
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(95, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Dom:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(507, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Gerente"
        '
        'TBRSocial
        '
        Me.TBRSocial.Location = New System.Drawing.Point(130, 64)
        Me.TBRSocial.Name = "TBRSocial"
        Me.TBRSocial.Size = New System.Drawing.Size(164, 20)
        Me.TBRSocial.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Razon Social:"
        '
        'TBRPatronal
        '
        Me.TBRPatronal.Location = New System.Drawing.Point(130, 130)
        Me.TBRPatronal.Name = "TBRPatronal"
        Me.TBRPatronal.Size = New System.Drawing.Size(164, 20)
        Me.TBRPatronal.TabIndex = 69
        '
        'TBNomEmpr
        '
        Me.TBNomEmpr.Location = New System.Drawing.Point(130, 31)
        Me.TBNomEmpr.Name = "TBNomEmpr"
        Me.TBNomEmpr.Size = New System.Drawing.Size(164, 20)
        Me.TBNomEmpr.TabIndex = 68
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(409, 31)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(164, 20)
        Me.TBEmail.TabIndex = 67
        '
        'TBRFC
        '
        Me.TBRFC.Location = New System.Drawing.Point(130, 163)
        Me.TBRFC.Name = "TBRFC"
        Me.TBRFC.Size = New System.Drawing.Size(164, 20)
        Me.TBRFC.TabIndex = 65
        '
        'TelEmpr
        '
        Me.TelEmpr.Location = New System.Drawing.Point(409, 64)
        Me.TelEmpr.Name = "TelEmpr"
        Me.TelEmpr.Size = New System.Drawing.Size(164, 20)
        Me.TelEmpr.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Frecuencia de pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Fec_Ini:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "RFC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Registro Patronal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nombre:"
        '
        'CBFrecPago
        '
        Me.CBFrecPago.FormattingEnabled = True
        Me.CBFrecPago.Location = New System.Drawing.Point(347, 120)
        Me.CBFrecPago.Name = "CBFrecPago"
        Me.CBFrecPago.Size = New System.Drawing.Size(121, 21)
        Me.CBFrecPago.TabIndex = 88
        '
        'CBGerente
        '
        Me.CBGerente.FormattingEnabled = True
        Me.CBGerente.Location = New System.Drawing.Point(474, 120)
        Me.CBGerente.Name = "CBGerente"
        Me.CBGerente.Size = New System.Drawing.Size(121, 21)
        Me.CBGerente.TabIndex = 89
        '
        'OkayEmpresa
        '
        Me.OkayEmpresa.Location = New System.Drawing.Point(529, 248)
        Me.OkayEmpresa.Name = "OkayEmpresa"
        Me.OkayEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.OkayEmpresa.TabIndex = 91
        Me.OkayEmpresa.Text = "Aplicar"
        Me.OkayEmpresa.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTPEmpresa
        '
        Me.DTPEmpresa.Location = New System.Drawing.Point(130, 193)
        Me.DTPEmpresa.Name = "DTPEmpresa"
        Me.DTPEmpresa.Size = New System.Drawing.Size(164, 20)
        Me.DTPEmpresa.TabIndex = 92
        '
        'EmpresaWnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 283)
        Me.Controls.Add(Me.DTPEmpresa)
        Me.Controls.Add(Me.OkayEmpresa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBGerente)
        Me.Controls.Add(Me.CBFrecPago)
        Me.Controls.Add(Me.DomEmpr)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBRSocial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBRPatronal)
        Me.Controls.Add(Me.TBNomEmpr)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBRFC)
        Me.Controls.Add(Me.TelEmpr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmpresaWnd"
        Me.Text = "Empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DomEmpr As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TBRSocial As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBRPatronal As TextBox
    Friend WithEvents TBNomEmpr As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBRFC As TextBox
    Friend WithEvents TelEmpr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBFrecPago As ComboBox
    Friend WithEvents CBGerente As ComboBox
    Friend WithEvents OkayEmpresa As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DTPEmpresa As DateTimePicker
End Class

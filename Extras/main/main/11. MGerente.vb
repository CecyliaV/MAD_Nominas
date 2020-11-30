Public Class form11
    Public Temp As EnlaceBD
    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateEmpresa.Click
        Me.Hide()
        EmpresaWnd.Show()
    End Sub

    Private Sub form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Temp = New EnlaceBD
        Dim aux As DataTable

        Dim IdGerente As Integer
        Dim user As String
        user = LogIn.TBUser.Text
        Dim pass As String
        pass = LogIn.TBPass.Text


        IdGerente = Temp.GetId(user, pass)

        aux = Temp.Get_GerenteInfo(IdGerente)


        If (Temp.ValidaSuperUser(IdGerente)) Then
            CreateEmpresa.Enabled = True
        Else
            CreateEmpresa.Enabled = False
        End If

        IdEmpleado.Text = aux.Rows(0).Item("id").ToString
        TBNombre.Text = aux.Rows(0).Item("Nombre").ToString
        TBEmpresa.Text = aux.Rows(0).Item("Empresa").ToString
        TBPuesto.Text = aux.Rows(0).Item("Puesto").ToString



    End Sub

    Private Sub IdEmpleado_TextChanged(sender As Object, e As EventArgs) Handles IdEmpleado.TextChanged

    End Sub

    Private Sub CreateDep_Click(sender As Object, e As EventArgs) Handles CreateDep.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click

        Me.Hide()
        Puestos.Show()

    End Sub
End Class
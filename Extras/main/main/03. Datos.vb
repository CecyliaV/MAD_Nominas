Public Class FEmpleado
    Public Temp As EnlaceBD
    Dim idEmprTemp As Integer = 0
    Dim name As String
    Dim pass As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackDatos.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GerenteCheck_CheckedChanged(sender As Object, e As EventArgs) Handles GerenteCheck.CheckedChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Temp = New EnlaceBD
        Dim aux As DataTable


        name = LogIn.TBUser.Text
        pass = LogIn.TBPass.Text

        If sender Is GerenteForm.CreateEmpleado Then
            aux = Temp.GetEmpresaNom(name, pass)
            TBEmpresa.Text = aux.Rows(0).Item("Empresa").ToString
        End If




    End Sub

    Private Sub DatosConfirm_Click(sender As Object, e As EventArgs) Handles DatosConfirm.Click
        Temp = New EnlaceBD
        Dim data As New DataTable
        Dim isGerente As Integer
        name = LogIn.TBUser.Text
        pass = LogIn.TBPass.Text
        idEmprTemp = Temp.GetIdEmpresa(name, pass)

        If (GerenteCheck.Checked) Then
            isGerente = 1
        Else
            isGerente = 0
        End If


        Temp.AddEmpleadoInfo("I", NomEmpl.Text, UserEmpl.Text, ContraEmpl.Text, NSSEmpl.Text, RFCEmpl.Text, BancoEmpl.Text, NumCuentaEmpl.Text, EmailEmpl.Text, TelEmpl.Text, ApM.Text, ApP.Text, CURPEmpl.Text, idEmprTemp, Nothing, Nothing, Nothing, CalleEmpl.Text,
                                NumEmpl.Text, ColEmpl.Text, MunEmpl.Text, EtdoEmpl.Text, CPEmpl.Text, isGerente, DTFec.Text)


        Me.Hide()
        GerenteForm.Show()


    End Sub

End Class
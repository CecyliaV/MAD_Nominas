Public Class EmpresaWnd
    Public Temp As EnlaceBD
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBGerente.DropDownStyle = ComboBoxStyle.DropDownList
        Temp = New EnlaceBD
        Temp.LoadGerente(CBGerente)
        Temp = Nothing

        If (CBGerente.Items.Count <> 0) Then
            CBGerente.SelectedIndex = 0
        End If


    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TBRSocial.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OkayEmpresa.Click
        Temp = New EnlaceBD
        Dim data As New DataTable


        Temp.AddEmpresaInfo("I", TBNomEmpr.Text, TBRSocial.Text, DomEmpr.Text, TBRPatronal.Text, TBRFC.Text, DTPEmpresa.Text, TBEmail.Text, TelEmpr.Text, Nothing, Nothing)

        TBNomEmpr.Text = 0

    End Sub

    Private Sub CBFrecPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFrecPago.SelectedIndexChanged

    End Sub

    Private Sub CBGerente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGerente.SelectedIndexChanged

    End Sub
End Class
﻿Public Class EmpresaWnd
    Public Temp As EnlaceBD
    Dim idGerTemp As Integer = 0
    Dim idFrecTemp As Integer = 0
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBGerente.DropDownStyle = ComboBoxStyle.DropDownList
        Temp = New EnlaceBD
        Temp.LoadGerente(CBGerente)


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

        idGerTemp = Temp.GetIdFrecandGer(CBGerente.Text)

        Temp.AddEmpresaInfo("I", TBNomEmpr.Text, TBRSocial.Text, DomEmpr.Text, TBRPatronal.Text, TBRFC.Text, DTPEmpresa.Text, TBEmail.Text, TelEmpr.Text, Nothing, idGerTemp)


        Me.Hide()
        GerenteForm.Show()

    End Sub

    Private Sub CBFrecPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFrecPago.SelectedIndexChanged

    End Sub

    Private Sub CBGerente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGerente.SelectedIndexChanged

    End Sub

    Private Sub DTPEmpresa_ValueChanged(sender As Object, e As EventArgs) Handles DTPEmpresa.ValueChanged

    End Sub
End Class
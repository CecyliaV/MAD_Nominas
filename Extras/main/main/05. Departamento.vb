Public Class Form5
    Public Temp As EnlaceBD
    Dim idGerTemp As Integer = 0
    Dim idFrecTemp As Integer = 0
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBGerente.DropDownStyle = ComboBoxStyle.DropDownList
        Temp = New EnlaceBD
        Temp.LoadGerente(CBGerente)


        If (CBGerente.Items.Count <> 0) Then
            CBGerente.SelectedIndex = 0
        End If


    End Sub

    Private Sub ApplyDept_Click(sender As Object, e As EventArgs) Handles ApplyDept.Click
        Temp = New EnlaceBD
        Dim data As New DataTable

        idGerTemp = Temp.GetIdFrecandGer(CBGerente.Text)
        Temp.AddDepartamento("I", TextBoxND.Text, TextBoxSBD.Text, idGerTemp)


        Me.Hide()
        GerenteForm.Show()
    End Sub

    Private Sub CBGerente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGerente.SelectedIndexChanged


    End Sub
End Class
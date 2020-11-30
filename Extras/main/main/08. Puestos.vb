Public Class Puestos
    Public Temp As EnlaceBD

    Private Sub AplyPuestos_Click(sender As Object, e As EventArgs) Handles AplyPuestos.Click
        Temp = New EnlaceBD
        Dim data As New DataTable


        Temp.AddPuesto("I", TB_NP.Text, TB_NSP.Text)

        Me.Hide()
        GerenteForm.Show()
    End Sub

    Private Sub BackPuesto_Click(sender As Object, e As EventArgs) Handles BackPuesto.Click

    End Sub

    Private Sub Puestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Puestos
    Public Temp As EnlaceBD
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TB_NP.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Temp = New EnlaceBD
        Dim data As New DataTable


        Temp.AddPuesto("I", TB_NP.Text, TB_NSP.Text)

    End Sub
End Class
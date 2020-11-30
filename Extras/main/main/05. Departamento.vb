Public Class Form5
    Public Temp As EnlaceBD

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBoxND.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Temp = New EnlaceBD
        Dim data As New DataTable


        Temp.AddDepartamento("I", TextBoxND.Text, TextBoxSBD.Text, Nothing)


    End Sub
End Class
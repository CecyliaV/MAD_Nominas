Public Class Form1
    'if (check 1 y 2 hasnt changed) Form2.Show() as below
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'if(this) Form4.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        'if (this) Form5.Show()
    End Sub

    Private Sub TBUser_TextChanged(sender As Object, e As EventArgs) Handles TBUser.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


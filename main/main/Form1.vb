Public Class Form1
    'if (check 1 y 2 hasnt changed) Form2.Show() as below
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'if(this) Form4.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'if (this) Form5.Show()
    End Sub
End Class


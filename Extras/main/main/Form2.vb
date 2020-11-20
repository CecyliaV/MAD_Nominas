Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MisDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisDatosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub IdEmpleado_TextChanged(sender As Object, e As EventArgs) Handles IdEmpleado.TextChanged
        IdEmpleado.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReporteHeadcounterToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class Form6
    Public Temp As EnlaceBD

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB_NPN.TextChanged

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            TB_NPP.Enabled = False
            TB_NPV.Enabled = True


        ElseIf RadioButton1.Checked = False Then

            TB_NPP.Enabled = True
            TB_NPV.Enabled = False

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Temp = New EnlaceBD
        Dim data As New DataTable

        If RadioButton1.Checked = True Then

            Temp.AddPercep("I", TB_NPN.Text, TB_NPV.Text, Nothing)


        ElseIf RadioButton2.Checked = True Then

            Temp.AddPercep("I", TB_NPN.Text, Nothing, TB_NPP.Text)


        End If

    End Sub
End Class
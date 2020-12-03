Public Class Deducciones
    Public Temp As EnlaceBD

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then

            TB_NDP.Enabled = False
            TB_NDV.Enabled = True


        ElseIf RadioButton4.Checked = False Then

            TB_NDP.Enabled = True
            TB_NDV.Enabled = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Temp = New EnlaceBD
        Dim data As New DataTable

        If RadioButton4.Checked = True Then

            Temp.AddDedu("I", TB_NDN.Text, TB_NDV.Text, Nothing)


        ElseIf RadioButton3.Checked = True Then

            Temp.AddDedu("I", TB_NDN.Text, Nothing, TB_NDP.Text)


        End If
    End Sub
End Class
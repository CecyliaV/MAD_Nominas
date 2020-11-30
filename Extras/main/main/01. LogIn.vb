Public Class LogIn
    'if (check 1 y 2 hasnt changed) Form2.Show() as below
    Public Temp As EnlaceBD


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Temp = New EnlaceBD
        Dim data As DataTable
        If (Temp.ValidaUser(TBUser.Text.Trim(), TBPass.Text.Trim())) Then
            If (Temp.ValidaAdmin(TBUser.Text.Trim(), TBPass.Text.Trim())) Then

                Me.Hide()
                GerenteForm.Show()

            Else

                Me.Hide()
                Form2.Show()
            End If
        Else
            MsgBox("Usuario o Contraseña no encontrados!")
        End If

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

    Private Sub TBPass_TextChanged(sender As Object, e As EventArgs) Handles TBPass.TextChanged

    End Sub

End Class





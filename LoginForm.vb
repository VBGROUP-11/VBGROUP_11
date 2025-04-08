Imports RegistrationForm
Public Class LoginForm
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Username As String = "GROUP11"
        Dim Password As String = "00000"
        Try
            If txtUsername.Text = Username And txtPassword.Text = Password Then
                Me.Hide()
                Dim Reg As New Form2() ' This instantiates Form2
                Reg.Show()
            Else
                MessageBox.Show("Invalid Username or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class

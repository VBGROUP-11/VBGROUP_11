Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If (ProgressBar1.Value = 100) Then

            Me.Hide()
            Dim Log = New LoginForm.LoginForm
            Log.Show()
            Timer1.Enabled = False




        End If
    End Sub
End Class

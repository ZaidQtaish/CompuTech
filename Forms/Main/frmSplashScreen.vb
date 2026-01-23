Public Class frmSplashScreen
    Private Sub tmrSplashScreen_Tick(sender As Object, e As EventArgs) Handles tmrSplashScreen.Tick
        tmrSplashScreen.Enabled = False
        Dim objFrmLogin As New Form1
        Me.Hide()
        objFrmLogin.Show()
    End Sub
End Class
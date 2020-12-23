Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            login.Show()

        End If
    End Sub
End Class
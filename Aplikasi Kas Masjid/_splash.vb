Public Class _splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        r2.Width += 40
        If r2.Width >= 350 Then
            Timer1.Stop()
            _login.Show()
            Me.Hide()
        End If
    End Sub
End Class
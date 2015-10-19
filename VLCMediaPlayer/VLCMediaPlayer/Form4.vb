Public Class frmPlayPause
    Private Sub OpacityTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpacityTimer.Tick
        Opacity -= 0.03
        If Opacity = 0 Then
            Me.Hide()
            Opacity = 100
            OpacityTimer.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub frmPlayPause_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmFullScreen.VLCv2.playlist.isPlaying Then
            Me.BackgroundImage = My.Resources.Play_Background
        Else
            Me.BackgroundImage = My.Resources.Pause_Background
        End If
        OpacityTimer.Start()
    End Sub
End Class
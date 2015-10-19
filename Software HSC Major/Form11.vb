Public Class frmDisableCaptionsDialog 'frmDisableCaptionsDialog code
    Dim RandomFlip As Boolean = False
    Private Sub frmDisableCaptionsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmDisableCaptionsDialog form Load code
        AcceptButton = btnOK 'Sets the ok button as the focused button
        FlipImageTimer.Start() 'Starts the flipimagetimer
    End Sub

    Private Sub FlipImageTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipImageTimer.Tick 'FlipImageTimer Tick code
        If RandomFlip = True Then 'Checks if the boolean variable is set to true
            picCaptions.BackgroundImage = My.Resources.TerrathedeGamesMenu_Captions
            RandomFlip = False 'Sets RandomFlip to False
        Else
            picCaptions.BackgroundImage = My.Resources.TerrathedeGamesMenu_NoCaptions
            RandomFlip = True 'Sets RandomFlip to True
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click 'btnOK Click code
        Me.Dispose() 'Closes the current form
        frmSettings.Show() 'Shows the "frmSettings" form
    End Sub
End Class
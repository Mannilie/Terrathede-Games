Public Class frmSplashScreen 'frmSplashScreen form code
    Dim file(10000) As String
    Dim MaxCounter As Integer
    Dim Counter As Integer = 1
    Dim Filename(10000) As String
    Dim AppPath As String = Application.StartupPath
    Dim fileNames = My.Computer.FileSystem.GetFiles(AppPath, FileIO.SearchOption.SearchAllSubDirectories)
    Private Sub ListFiles() 'ListFiles Subroutine code
        MaxCounter = fileNames.Count 'Sets the "MaxCounter" integer value to the amount of items in the "fileNames" array
        For i = 0 To MaxCounter - 1 'Executes a set of commands until the integer variable "i" is equal to the same value as the "MaxCounter" integer variable
            file(i) = fileNames(i) 'Writes the "fileNames" array's index of "i" to "file" array's index of "i"
        Next
        CleanString() 'Calls the "CleanString" subroutine
    End Sub
    Private Sub CleanString() 'CleanString Subroutine code
        For i = 0 To MaxCounter - 1 'Executes a set of commands until the integer variable "i" is equal to the same value as the "MaxCounter" integer variable
            file(i) = file(i).Substring(file(i).LastIndexOf("\") + 1) 'Writes the "fileNames" array's index of "i" to "file" array's index of "i" without the full file directory (using substring)
            Filename(i) = file(i) 'Writes the "fileNames" array's index of "i" to "file" array's index of "i"
        Next
        FileTimer.Start() 'Starts the "FileTimer" timer tick event
    End Sub
    Private Sub LoadSettings() 'LoadSettings Subroutine code
        If My.Settings.MusicAndSounds = True Then 'Checks if application setting's "MusicAndSounds" boolean variable is set to true
            frmMainMenu.btnMuteUnMute.Visible = True 'Removes the "btnMuteUnmute" button from the "frmMainMenu" form
            frmHangmanModeMenu.btnMuteUnmute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmHangmanModeMenu" form
            frmTicTacToeModeMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeModeMenu" form
            frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeSinglePlayer" form
            frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = True
            'frmTicTacToeVersus.btnMuteUnMute.Visible = True
        End If
        If My.Settings.SoundsOnly = True Then 'Checks if application setting's "SoundsOnly" boolean variable is set to true
            frmMainMenu.btnMuteUnMute.Visible = True 'Removes the "btnMuteUnmute" button from the "frmMainMenu" form
            frmHangmanModeMenu.btnMuteUnmute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmHangmanModeMenu" form
            frmTicTacToeModeMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeModeMenu" form
            frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeSinglePlayer" form
            frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeTwoPlayer" form
            'frmTicTacToeVersus.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button on the "frmTicTacToeVersus" form
            frmSettings.OCXMusicPlayer.URL = Nothing 'Clears the Media Player's playlist
        End If
        If My.Settings.MusicOnly = True Then 'Checks if application setting's "MusicOnly" boolean variable is set to true
            frmMainMenu.btnMuteUnMute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmMainMenu" form
            frmHangmanModeMenu.btnMuteUnmute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmHangmanModeMenu" form
            frmTicTacToeModeMenu.btnMuteUnMute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmTicTacToeModeMenu" form
            frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmTicTacToeSinglePlayer" form
            frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmTicTacToeTwoPlayer" form
            'frmTicTacToeVersus.btnMuteUnMute.Visible = False 'Removes the "btnMuteUnmute" button from the "frmTicTacVersus" form
        End If
    End Sub

    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmSplashScreen Form Load code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        With picLoadingGif 'Executes a set of commands regarding the "picLoadingGif" picture box
            .Image = My.Resources.Loader 'Changes the Image property of "picLoadingGif" to "Loader" in resources 
            .SizeMode = PictureBoxSizeMode.CenterImage 'Changes the SizeMode property of "picLoadingGif" to "CenterImage"
        End With
        DefaultFormTimer.Start() 'Starts the "DefaultFormTimer" timer tick event
        LoadSettings() 'Calls the "LoadSettings" subroutine
        ListFiles() 'Calls the "ListFiles" subroutine
    End Sub

    'Timers
    Private Sub DefaultFormTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultFormTimer.Tick 'DefaultFormTimer Timer Tick code
        For i = 0 To MaxCounter 'Executes a set of commands until the integer variable "i" is equal to the same value as the "MaxCounter" integer variable
            file(i) = "" 'Clears "file" array's index "i"
            Filename(i) = "" 'Clears "Filename" array's index "i"
        Next
        DefaultFormTimer.Stop() 'Stops the "DefaultFormTimer" timer tick event
        If My.Settings.DefaultSettings = True Then 'Checks if "DefaultSettings" boolean variable in application settings is set to True
            Me.Hide() 'Hides the form
            frmMainMenu.Show() 'Shows the "frmMainMenu" form
            Exit Sub 'Exits the subroutine
        End If
        If My.Settings.MainMenu = True Then 'Checks if "MainMenu" boolean variable in application settings is set to True
            Me.Hide() 'Hides the form
            frmMainMenu.Show() 'Shows the "frmMainMenu" form
        End If
        If My.Settings.HangMan = True Then 'Checks if "HangMan" boolean variable in application settings is set to True
            Me.Hide() 'Hides the form
            frmHangmanModeMenu.StartPosition = FormStartPosition.CenterScreen 'Sets the "frmHangManModeMenu" start position property to "CenterScreen", starting the form in the center of the screen
            frmHangmanModeMenu.Show() 'Shows the "frmHangManModeMenu" form
        End If
        If My.Settings.TicTacToe = True Then 'Checks if "TicTacToe" boolean variable in application settings is set to True
            Me.Hide() 'Hides the form
            frmTicTacToeModeMenu.StartPosition = FormStartPosition.CenterScreen 'Sets the "frmTicTacToeModeMenu" start position property to "CenterScreen", starting the form in the center of the screen
            frmTicTacToeModeMenu.Show() 'Shows the "frmTicTacToeModeMenu" form
        End If
    End Sub
    Private Sub FileTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileTimer.Tick 'FileTimer Timer Tick code
        Counter = Counter + 1 'Increments the "Counter" integer variable
        If Counter = MaxCounter Then 'Checks if the integer variable "Counter" is the same value as the integer variable "MaxCounter"
            lblFile.Text = "axvlc.dll" 'Changes the "lblFile" label text to "axvlc.dll"
            FileTimer.Stop() 'Stops the "FileTimer" timer tick event
        Else
            lblFile.Text = Filename(Counter) 'Writes the "Filename" array's index value "Counter" to the "lblFile" label
        End If
    End Sub






End Class
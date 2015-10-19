Imports System.IO 'Form makes reference to the "System.IO" namespacePublic Class frmSettings 'frmSettings Form Class
Public Class frmSettings 'frmGameSettings Form code
    Dim MaxCounter As Integer
    Dim Files(10000) As String
    Dim Toggle As Boolean = False
    Dim ToggleCounter As Integer = 6
    Dim CancelExit As Boolean = False
    Dim AppPath As String = Application.StartupPath
    Dim fileNames = My.Computer.FileSystem.GetFiles(AppPath & "\Music", FileIO.SearchOption.SearchAllSubDirectories)
    Const WM_NCLBUTTONDBLCLK As Integer = &HA3 'Declares constant variable "WM_NCLBUTTONDBLCLK" as an integer and assigns it's message "&HA3"
    Const WM_NCHITTEST As Integer = &H84 'Declares constant variable "WM_NCHITTEST" as an integer and assigns it's message "&H84"
    Const HTCLIENT As Integer = &H1 'Declares constant variable "HTCLIENT" as an integer and assigns it's message "&H1"
    Const HTCAPTION As Integer = &H2 'Declares constant variable "HTCAPTION" as an integer and assigns it's message "&H2"
    Protected Overrides Sub WndProc(ByRef Message As System.Windows.Forms.Message) 'The "WndProc" Function (Processing Windows Messages) Protected Override subroutine
        If Message.Msg = WM_NCLBUTTONDBLCLK Then Return 'Checks if the ID number for the message (Message.Msg) is "WM_NCLBUTTONDBLCLK" which is posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of the window
        MyBase.WndProc(Message) 'Returns the "WndProc(Message)" message to the subroutine for location
        Select Case Message.Msg 'Selects the "Message.Msg" message for the Case Else statement
            Case WM_NCHITTEST 'Checks if the message is sent to a window to determine which aspect of the window corresponds to a specific screen coordinate
                MyBase.WndProc(Message) 'Returns the "WndProc(Message)" message to the subroutine for location
                If Message.Result = HTCLIENT Then Message.Result = HTCAPTION 'Checks if the result of the "Message" function returns with "HTCLIENT" which is posted when the user's curser enters the client area, then changes the result to "HTCAPTION" which posts the message position to the title bar
                If Message.Msg = WM_NCLBUTTONDBLCLK Then Return 'Checks if the ID number for the message (Message.Msg) is "WM_NCLBUTTONDBLCLK" then returns the message to the subroutine
            Case Else
                MyBase.WndProc(Message) 'Returns the "WndProc(Message)" message to the subroutine for location
        End Select
    End Sub
    Private Sub frmsettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmSettings Form Load code
        LoadSettings() 'Calls the "LoadSettings" subroutine code
        MaxCounter = fileNames.count 'Sets "MaxCounter" integer variable to the maximum number in the "fileNames" string
        For x = 0 To MaxCounter - 1 'Executes a set of commands until the integer value "x" has reached the value of "MaxCounter"
            Files(x) = fileNames(x) 'Sets the "Files" array index value to "fileNames" index value 
            Files(x) = Files(x).Substring(Files(x).LastIndexOf("\") + 1) 'Erases the path directory in the string line index value "x" of "Files" (e.g, "c:\Users\" etc...)
        Next
        For i = 0 To MaxCounter - 1 'Executes a set of commands until the integer value "i" has reached the value of "MaxCounter"
            lstMusic.Items.Add(Files(i)) 'Adds the "Files" array index value "i" to the "lstMusic" list box
        Next
    End Sub
    Private Sub frmSettings_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate 'frmSettings Form Deactivate code
        If CancelExit = False Then 'Checks if the boolean variable "CancelExit" is set to False
            Me.Hide() 'Hides the form if the above statement is true
        End If
    End Sub
    Private Sub StopAllMouseMoveTimers() 'StopAllMouseMoveTimers subroutine code
        'Stops all MouseMoveTimers on all forms
        frmMainMenu.MouseMoveTimer.Stop()
        frmHangmanModeMenu.MouseMoveTimer.Stop()
        frmHangmanSinglePlayer.MouseMoveTimer.Stop()
        frmHangmanTwoPlayer.MouseMoveTimer.Stop()
        frmHangmanVersus.MouseMoveTimer.Stop()
        frmTicTacToeModeMenu.MouseMoveTimer.Stop()
        frmTicTacToeSinglePlayer.MouseMoveTimer.Stop()
        frmTicTacToeTwoPlayer.MouseMoveTimer.Stop()
    End Sub
    Private Sub StartAllMouseMoveTimers() 'StartAllMouseMoveTimers subroutine code
        'Starts all MouseMoveTimers on all forms
        frmMainMenu.MouseMoveTimer.Start()
        frmHangmanModeMenu.MouseMoveTimer.Start()
        frmHangmanSinglePlayer.MouseMoveTimer.Start()
        frmHangmanTwoPlayer.MouseMoveTimer.Start()
        frmHangmanVersus.MouseMoveTimer.Start()
        frmTicTacToeModeMenu.MouseMoveTimer.Start()
        frmTicTacToeSinglePlayer.MouseMoveTimer.Start()
        frmTicTacToeTwoPlayer.MouseMoveTimer.Start()
    End Sub
    'Listbox
    Private Sub lstMusic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMusic.SelectedIndexChanged 'lstMusic List box SelectedIndexChanged code
        btnPlay.BackColor = Color.Lime
        btnPlay.Enabled = True 'Enables the "btnPlay" button
        btnRemove.BackColor = Color.Firebrick 'Sets the "btnRemove" background color to Firebrick
        btnRemove.Enabled = True 'Enables the "btnRemove" button
    End Sub

    'Radio buttons
    Private Sub rbDefaultSettings_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbDefaultSettings.MouseUp 'rbDefaultSettings Radio Button MouseUp code
        My.Settings.DefaultSettings = True 'Sets the "DefaultSettings" boolean variable in the application settings to True
        My.Settings.Save() 'Saves settings to application
        lblDefaultSettingsInfo.BringToFront() 'Displays the "DefaultSettingsInfo" label showing information on this radio button's selection
        rbDefaultSettings.Checked = True
        rbMainMenu.Checked = True
        rbHangMan.Checked = False
        rbTicTacToe.Checked = False
        rbMusicAndSounds.Checked = True
        rbSoundsOnly.Checked = False
        rbMusicOnly.Checked = False
        cbDisableCaptions.Checked = False
        DisableAllButtons() 'Calls the "DisableRadioButtons" subroutine
    End Sub
    Private Sub rbCustomSettings_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbCustomSettings.MouseUp 'rCustomSettings Radio Button MouseUp code
        My.Settings.DefaultSettings = False 'Sets the "DefaultSettings" boolean variable in the application settings to False
        My.Settings.Save() 'Saves settings to application
        lblCustomSettingsInfo.BringToFront() 'Displays the "CustomSettingsInfo" label showing information on this radio button's selection
        EnableAllButtons() 'Calls the "EnableRadioButtons" subroutine
        LoadSettings() 'Calls the "LoadSettings" subroutine
    End Sub
    Private Sub rbMusicAndSounds_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbMusicAndSounds.MouseUp 'rbMusicAndSounds Radio Button MouseUp code
        bxSelectMusic.Enabled = True 'Enables the "bxSelectMusic" group box
        My.Settings.Mute = False 'Sets the boolean variable "Mute" in the application settings to True
        frmHangmanModeMenu.btnMuteUnmute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmHangManModeMenu" form
        frmMainMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmMainMenu" form
        frmTicTacToeModeMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeModeMenu" form
        frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeSinglePlayer" form
        frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeTwoPlayer" form
        OCXMusicPlayer.Ctlcontrols.play() 'Plays the song that's inside the "OCXMusicPlayer" OCX's URL
        OCXMusicPlayer.Ctlenabled = True  'Enables the "OCXMusicPlayer" Windows Media Player OCX (ActiveX Control)
        SaveAnimation() 'Calls the "SaveAnimation" subroutine
    End Sub
    Private Sub rbSoundsOnly_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbSoundsOnly.MouseUp 'rbSoundsOnly Radio Button MouseUp code
        bxSelectMusic.Enabled = False 'Disables the "bxSelectMusic" group box
        My.Settings.Mute = False 'Sets the boolean variable "Mute" in the application settings to True
        frmMainMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmMainMenu" form
        frmHangmanModeMenu.btnMuteUnmute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmHangManModeMenu" form
        frmTicTacToeModeMenu.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeModeMenu" form
        frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeSinglePlayer" form
        frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = True 'Shows the "btnMuteUnmute" button in the "frmTicTacToeTwoPlayer" form
        OCXMusicPlayer.Ctlcontrols.pause() 'Pauses the song that's inside the "OCXMusicPlayer" OCX's URL
        OCXMusicPlayer.Ctlenabled = False 'Disables the "OCXMusicPlayer" Windows Media Player OCX (ActiveX Control)
        SaveAnimation() 'Calls the "SaveAnimation" subroutine
    End Sub
    Private Sub rbMusicOnly_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbMusicOnly.MouseUp 'rbMusicOnly Radio Button MouseUp code
        bxSelectMusic.Enabled = True 'Enables the "bxSelectMusic" group box
        frmMainMenu.btnMuteUnMute.Visible = False 'Hides the "btnMuteUnmute" button in the "frmMainMenu" form
        frmHangmanModeMenu.btnMuteUnmute.Visible = False 'Hides the "btnMuteUnmute" button in the "frmHangManModeMenu" form
        frmTicTacToeModeMenu.btnMuteUnMute.Visible = False 'Hides the "btnMuteUnmute" button in the "frmTicTacToeModeMenu" form
        frmTicTacToeSinglePlayer.btnMuteUnMute.Visible = False 'Hides the "btnMuteUnmute" button in the "frmTicTacToeSinglePlayer" form
        frmTicTacToeTwoPlayer.btnMuteUnMute.Visible = False 'Hides the "btnMuteUnmute" button in the "frmTicTacToeTwoPlayer" form
        My.Settings.Mute = True 'Sets the boolean variable "Mute" in the application settings to True
        OCXMusicPlayer.Ctlcontrols.play() 'Plays the song that's inside the "OCXMusicPlayer" OCX's URL
        OCXMusicPlayer.Ctlenabled = True 'Enables the "OCXMusicPlayer" Windows Media Player OCX (ActiveX Control)
        SaveAnimation() 'Calls the "SaveAnimation" subroutine
    End Sub
    Private Sub cbDisableCaptions_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbDisableCaptions.MouseClick 'cbDisableCaptions MouseClick code
        If cbDisableCaptions.Checked = True Then
            HideAllLabels()
            StopAllMouseMoveTimers()
        Else
            StartAllMouseMoveTimers()
            frmMainMenu.MouseMoveTimer.Start() 'Starts the "MouseMoveTimer" only on the main menu because the main menu is the only form that doesnt refresh the "Load" event
        End If
        SaveAnimation() 'Calls the "SaveAnimation" subroutine
    End Sub
    Private Sub linklblWhatsThis_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles linklblWhatsThis.MouseClick 'linklblWhatsThis MouseClick code
        CancelExit = True 'Sets the "CancelExit" boolean variable to True
        frmMainMenu.player.Stream = My.Resources.Windows_Information
        frmMainMenu.player.Play()
        frmDisableCaptionsDialog.ShowDialog()
        CancelExit = False 'Sets the "CancelExit" boolean variable to False
    End Sub
    Private Sub rbMainMenu_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbTicTacToe.MouseUp, rbMainMenu.MouseUp, rbHangMan.MouseUp 'Mouse Up (all) RadioButton events code
        SaveAnimation() 'Calls the "SaveAnimation" subroutine
    End Sub

    'Buttons
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click 'btnPlay Button Click code
        Dim FullDirectory As String = AppPath & "\Music\" 'Declares "FullDirectory" as a private string containing a location to the Music Folder
        OCXMusicPlayer.URL = FullDirectory & lstMusic.SelectedItem 'Places the "FullDirectory" string in the Media Player OCX's URL with the selected list item
        OCXMusicPlayer.Ctlcontrols.play() 'Plays the URL item
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click 'btnRemove Button Click code
        CancelExit = True 'Sets the "CancelExit" boolean variable to True
        Dim MessageBoxResult As String 'Declares MessageBoxResult as a string
        MessageBoxResult = MsgBox("Are you sure you want to delete this media file from the list?", vbInformation + vbYesNo, "Remove Song") 'Sets the "MessageBoxResult" string as the user's decision to the msgbox 
        If MessageBoxResult = vbYes Then 'Checks if the user's decision in the msgbox was "Yes"
            Dim FullDirectory As String = AppPath & "\Music\" & lstMusic.SelectedItem 'Declares "FullDirectory" as a string with the "Music" file's directory as well as the user's selected List box item in "lstMusic"
            If lstMusic.SelectedItem = "Terrathede Games Theme Song - Adrenaline.mp3" Then 'Checks if the user tries to remove the selected item "Addrenaline.mp3" from the "lstMusic" list box
                MsgBox("You cannot delete this media file because it's properties are set to default") 'Tells the user that they cannot remove this specific file because it's a default list item
                CancelExit = False 'Sets the "CancelExit" boolean variable to False
                Exit Sub 'Exits the subroutine
            End If
            If File.Exists(FullDirectory) Then 'Checks if the path entered in the "FullDirectory" exists
                File.Delete(FullDirectory) 'Deletes the selected item using the full directory (FullDirectory string path)
                lstMusic.Items.Remove(lstMusic.SelectedItem) 'Removes the same item from the "lstMusic" list box
            End If
        End If
        CancelExit = False 'Sets the "CancelExit" boolean variable to False
    End Sub
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click 'btnImport Button Click code
        CancelExit = True 'Sets the "CancelExit" boolean variable to True
        Dim Open_File As New OpenFileDialog 'Declares "Open_File" as an OpenFileDialog box
        With Open_File 'Executes a set of commands regarding "Open_File"
            .Filter = "Media Files (*.mp3)|*.mp3" 'Sets the "Filter" to the appropriate file extension
            .FileName = "" 'Clears the "FileName" text box in the OpenFileDialog box
            .CheckFileExists = True 'Gets a value indicating whether the OpenFileDialog box displays a warning that the specified file does not exist 
        End With
        If Open_File.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Checks if the user has finished selecting the file 
            Dim Path As String 'Declares "Path" as a string variable
            Path = Open_File.FileName 'Writes the "FileName" from the "Open_File" OpenFileDialog to the "Path" string`
            Dim FullDirectory As String = AppPath & "\Music\" & Open_File.SafeFileName 'Declares "FullDirectory" as a string with the "Music" file's directory as well as the user's selected List box item in "lstMusic"
            If File.Exists(Path) And Not File.Exists(FullDirectory) Then 'Checks if the "Open_File" OpenFileDialog's "FileName" path exists and the "FullDirectory" (with the selected list item) does not exist in the same file path.
                File.Copy(Path, FullDirectory) 'Copy's the "FullDirectory" file to the file "Path"
                lstMusic.Items.Add(Open_File.SafeFileName) 'Adds the new media file (.mp3) to the "lstMusic" list box
            Else
                MsgBox("You have already added this media file to the list.") 'Tells the user that the media file already exists if the user has tried to enter the same media file to the list
            End If
        End If
        CancelExit = False 'Sets the "CancelExit" boolean variable to False
    End Sub
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed 'Changes the background image of the close button when the mouse is down
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted 'Changes the background image of the close button to highlighted when the curser enters the button
        If My.Settings.Mute = False Then 'Checks if the user wants the sounds muted on all forms (using the mute button)
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave 'btnClose Button MouseLeave code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the close button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp 'btnClose Button MouseUp code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the close button's background image to the original image when the mouse is set to up
        If My.Settings.Mute = False Then  'Checks if the user wants the sounds muted on all forms (using the mute button)
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        LoadSettings() 'Calls the "LoadSettings" subroutine
        If cbDisableCaptions.Checked = True Then
            StopAllMouseMoveTimers()
        Else
            frmMainMenu.MouseMoveTimer.Start() 'Starts the "MouseMoveTimer" only on the main menu because the main menu is the only form that doesnt refresh the "Load" event
        End If
        Me.Hide() 'Hides the form
    End Sub

    'Private Subs
    Private Sub LoadSettings() 'LoadSettings Subroutine code
        If My.Settings.DefaultSettings = True Then  'Checks if the boolean variable "DefaultSettings" in application settings is set to True
            rbDefaultSettings.Checked = True 'Checks the "rbDefaultSettings" RadioButton
            rbMainMenu.Checked = True 'Checks the "rbMainMenu" RadioButton
            rbHangMan.Checked = False 'De-selects the "rbHangMan" RadioButton
            rbTicTacToe.Checked = False 'De-selects the "rbTicTacToe" RadioButton
            rbMusicAndSounds.Checked = True 'Checks the "rbMusicAndSounds" RadioButton
            rbSoundsOnly.Checked = False 'De-selects the "rbSoundsOnly" RadioButton
            rbMusicOnly.Checked = False 'De-selects the "rbMusicOnly" RadioButton
            DisableAllButtons()
            lblDefaultSettingsInfo.BringToFront() 'Displays the "DefaultWordList" label showing information on this radio button's selection
            Exit Sub 'Exits the subroutine if the above If statement returns true
        Else
            rbCustomSettings.Checked = True 'Checks the "rbCustomSettings" RadioButton if the above If statement returns false
            lblCustomSettingsInfo.BringToFront() 'Displays the "CustomWordList" label showing information on this radio button's selection
        End If
        If My.Settings.MainMenu = True Then 'Checks if the boolean variable "MainMenu" in application settings is set to True
            rbMainMenu.Checked = True 'Checks the "rbMainMenu" RadioButton
        Else
            rbMainMenu.Checked = False 'De-selects the "rbMainMenu" RadioButton
        End If
        If My.Settings.HangMan = True Then 'Checks if the boolean variable "HangMan" in application settings is set to True
            rbHangMan.Checked = True 'Checks the "rbHangMan" RadioButton
        Else
            rbHangMan.Checked = False 'De-selects the "rbHangMan" RadioButton
        End If
        If My.Settings.TicTacToe = True Then 'Checks if the boolean variable "TicTacToe" in application settings is set to True
            rbTicTacToe.Checked = True 'Checks the "rbTicTacToe" RadioButton
        Else
            rbTicTacToe.Checked = False 'De-selects the "rbTicTacToe" RadioButton
        End If
        If My.Settings.MusicAndSounds = True Then 'Checks if the boolean variable "MusicAndSounds" in application settings is set to True
            rbMusicAndSounds.Checked = True 'Checks the "rbMusicAndSounds" RadioButton
        Else
            rbMusicAndSounds.Checked = False 'De-selects the "rbMusicAndSounds" RadioButton
        End If
        If My.Settings.SoundsOnly = True Then 'Checks if the boolean variable "SoundsOnly" in application settings is set to True
            rbSoundsOnly.Checked = True 'Checks the "rbSoundOnly" RadioButton
            bxSelectMusic.Enabled = False 'Disables the "bxSelectMusic" group box
            OCXMusicPlayer.URL = Nothing 'Clears the "OCXMusicPlayer" Windows Media Player  OCX (ActiveX control)
            OCXMusicPlayer.Ctlenabled = False 'Disables the "OCXMusicPlayer" Windows Media Player OCX (ActiveX control)
        Else
            rbSoundsOnly.Checked = False 'De-selects the "rbMainMenu" RadioButton
        End If
        If My.Settings.MusicOnly = True Then 'Checks if the boolean variable "MusicOnly" in application settings is set to True
            rbMusicOnly.Checked = True 'Checks the "rbMusicOnly" RadioButton
        Else
            rbMusicOnly.Checked = False 'De-selects the "rbMusicOnly" RadioButton
        End If
        If My.Settings.DisableCaptions = True Then 'Checks if the boolean variable "DisableCaptions" in application settings is set to True
            cbDisableCaptions.Checked = True 'Checks the "cbDisableCaptions" Checkbox
        Else
            cbDisableCaptions.Checked = False 'Checks the "cbDisableCaptions" Checkbox
        End If
    End Sub
    Private Sub SaveSettings() 'SaveSettings Subroutine code
        If rbMainMenu.Checked = True Then 'Checks if the "rbMainMenu" radio button is checked
            My.Settings.MainMenu = True 'Sets "MainMenu" boolean variable in application settings to True
        Else
            My.Settings.MainMenu = False 'Sets "MainMenu" boolean variable in application settings to False
        End If
        If rbHangMan.Checked = True Then 'Checks if the "rbHangMan" radio button is checked
            My.Settings.HangMan = True 'Sets "HangMan" boolean variable in application settings to True
        Else
            My.Settings.HangMan = False 'Sets "HangMan" boolean variable in application settings to False
        End If
        If rbTicTacToe.Checked = True Then 'Checks if the "rbTicTacToe" radio button is checked
            My.Settings.TicTacToe = True 'Sets "TicTacToe" boolean variable in application settings to True
        Else
            My.Settings.TicTacToe = False 'Sets "TicTacToe" boolean variable in application settings to False
        End If
        If rbMusicAndSounds.Checked = True Then 'Checks if the "rbMusicAndSounds" radio button is checked
            My.Settings.MusicAndSounds = True 'Sets "MusicAndSounds" boolean variable in application settings to True
        Else
            My.Settings.MusicAndSounds = False 'Sets "MusicAndSounds" boolean variable in application settings to False
        End If
        If rbSoundsOnly.Checked = True Then 'Checks if the "rbSoundsOnly" radio button is checked
            My.Settings.SoundsOnly = True 'Sets "SoundsOnly" boolean variable in application settings to True
        Else
            My.Settings.SoundsOnly = False 'Sets "SoundsOnly" boolean variable in application settings to False
        End If
        If rbMusicOnly.Checked = True Then 'Checks if the "rbMusicOnly" radio button is checked
            My.Settings.MusicOnly = True 'Sets "MusicOnly" boolean variable in application settings to True
        Else
            My.Settings.MusicOnly = False 'Sets "MusicOnly" boolean variable in application settings to False
        End If
        If cbDisableCaptions.Checked = True Then 'Checks if the "cbDisableCaptions" radio button is checked
            My.Settings.DisableCaptions = True 'Sets "DisableCaptions" boolean variable in application settings to True
        Else
            My.Settings.DisableCaptions = False 'Sets "DisableCaptions" boolean variable in application settings to False
        End If
        My.Settings.Save() 'Saves the application's settings
    End Sub
    Private Sub SaveAnimation() 'SaveAnimation Subroutine code
        SaveSettings() 'Calls 
        picSaveGif.Visible = True 'Shows the save picture box gif animation
        picGreenTick.Visible = False 'Hides the green tick picture box from the form
        lblSettingsSaved.Text = "Saving Settings..." 'Sets the "lblSettingsSaved" label's text to "Saving Settings..."
        With picSaveGif 'Executes a set of commands regarding the "picSaveGif" picture box
            .Image = My.Resources.LoadingScreen 'Sets the "picSaveGif" picture box's image to the gif file in resources
            .SizeMode = PictureBoxSizeMode.CenterImage 'Changes the "SizeMode" of the image module in the picture box
        End With
        SaveTimer.Start() 'Starts "SaveTimer" Timer 
    End Sub
    Private Sub DisableAllButtons() 'DisableSettings Subroutine code
        rbMainMenu.Enabled = False 'Disables the "rbMainMenu" RadioButton
        rbHangMan.Enabled = False 'Disables the "rbHangMan" RadioButton
        rbTicTacToe.Enabled = False 'Disables the "rbTicTacToe" RadioButton
        rbMusicAndSounds.Enabled = False 'Disables the "rbMusicAndSounds" RadioButton
        rbSoundsOnly.Enabled = False 'Disables the "rbSoundsOnly" RadioButton
        rbMusicOnly.Enabled = False 'Disables the "rbMusicOnly" RadioButton
        cbDisableCaptions.Enabled = False 'Disables the "cbDisableCaptions" CheckBox
    End Sub
    Private Sub EnableAllButtons() 'EnableSettings Subroutine code
        rbMainMenu.Enabled = True 'Enables the "rbMainMenu" RadioButton
        rbHangMan.Enabled = True 'Enables the "rbHangMan" RadioButton
        rbTicTacToe.Enabled = True 'Enables the "rbTicTacToe" RadioButton
        rbMusicAndSounds.Enabled = True 'Enables the "rbMusicAndSounds" RadioButton
        rbSoundsOnly.Enabled = True 'Enables the "rbSoundsOnly" RadioButton
        rbMusicOnly.Enabled = True 'Enables the "rbMusicOnly" RadioButton
        cbDisableCaptions.Enabled = True 'Enables the "cbDisableCaptions" CheckBox
    End Sub
    Private Sub SaveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTimer.Tick 'SaveTimer Timer Tick code
        picGreenTick.Visible = True 'Shows the green tick "picGreenTick" picture box
        picSaveGif.Visible = False 'Shows the "picSaveGif" picture box gif animation
        lblSettingsSaved.Text = "Settings Saved." 'Sets the "lblSettingsSaved" label's text to "Game Settings Saved."
        SaveTimer.Stop()  'Stops "SaveTimer" Timer 
    End Sub
    Private Sub lstMusic_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMusic.MouseDoubleClick  'lstMusic list box MouseDoubleClick code
        Call btnPlay_Click(Nothing, Nothing) 'Calls the "btnPlay" click event
    End Sub

    Private Sub HideAllLabels() 'SaveSettiHideAllLabelsngs Subroutine code
        'Hides all labels on all forms that are next to a button
        frmMainMenu.lblInfo.Visible = False
        frmMainMenu.lblMute.Visible = False
        frmMainMenu.lblSettings.Visible = False
        frmHangmanModeMenu.lblMainMenu.Visible = False
        frmHangmanModeMenu.lblInfo.Visible = False
        frmHangmanModeMenu.lblMute.Visible = False
        frmHangmanModeMenu.lblGameSettings.Visible = False
        frmTicTacToeModeMenu.lblMainMenu.Visible = False
        frmTicTacToeModeMenu.lblInfo.Visible = False
        frmTicTacToeModeMenu.lblMute.Visible = False
        frmTicTacToeModeMenu.lblSettings.Visible = False
        frmTicTacToeSinglePlayer.lblLeaveGame.Visible = False
        frmTicTacToeSinglePlayer.lblInfo.Visible = False
        frmTicTacToeSinglePlayer.lblMute.Visible = False
        frmTicTacToeSinglePlayer.lblSettings.Visible = False
        frmTicTacToeTwoPlayer.lblLeaveGame.Visible = False
        frmTicTacToeTwoPlayer.lblInfo.Visible = False
        frmTicTacToeTwoPlayer.lblMute.Visible = False
        frmTicTacToeTwoPlayer.lblSettings.Visible = False
    End Sub
End Class

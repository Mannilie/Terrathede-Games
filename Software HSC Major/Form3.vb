Public Class frmHangmanModeMenu 'frmHangmanModeMenu form code
    Dim AppPath As String = Application.StartupPath
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
    Private Sub GetPlayerNames() 'GetPlayerNames Private Sub code
        If frmMainMenu.PlayerFlag = True Then
            Dim MessageBoxResult As String
            MessageBoxResult = MsgBox("Player One: " & frmMainMenu.PlayerOne & vbCrLf & "Player Two: " & frmMainMenu.PlayerTwo & vbCrLf & vbCrLf & "Would you like to use the same player names?", vbYesNo + vbInformation, "Player Names") 'Checks if there were names already entered into the application before
            If MessageBoxResult = vbNo Then
                frmMainMenu.PlayerFlag = False 'Sets PlayerFlag to False
                frmMainMenu.FirstPlayer = False 'Sets FirstPlayer to False
                frmMainMenu.SecondPlayer = False 'Sets SecondPlayer to False
            End If
        End If
        If frmMainMenu.FirstPlayer = False Then 'Checks if FirstPlayer is set to false
            Dim FirstPlayerInputBoxResult As String
            FirstPlayerInputBoxResult = InputBox("Player One, please enter your name:", "Player One", "Enter Your Name Here") 'Prompts the user for Player One's Name
            If FirstPlayerInputBoxResult = "Enter Your Name Here" Then
                MsgBox("You have not entered a name. Please enter your name to continue", vbInformation, "Invalid Name")  'Tells the user if the name entered is invalid
                Exit Sub
            End If
            If FirstPlayerInputBoxResult = "" Then 'Checks if the input box is empty
                Exit Sub
            Else
                frmMainMenu.PlayerOne = FirstPlayerInputBoxResult
                frmMainMenu.FirstPlayer = True
            End If
        End If
        If frmMainMenu.FirstPlayer = False Then
            Exit Sub
        End If
        If frmMainMenu.SecondPlayer = False Then
            Dim SecondPlayerInputBoxResult As String
            SecondPlayerInputBoxResult = InputBox("Player Two, please enter your name:", "Player Two", "Enter Your Name Here") 'Prompts the user for Player Two's Name
            If SecondPlayerInputBoxResult = "Enter Your Name Here" Then
                MsgBox("You have not entered a name. Please enter your name to continue", vbInformation, "Invalid Name") 'Tells the user if the name entered is invalid
                Exit Sub
            End If
            If SecondPlayerInputBoxResult = "" Then 'Checks if the input box is empty
                Exit Sub
            Else
                frmMainMenu.PlayerTwo = SecondPlayerInputBoxResult
                frmMainMenu.SecondPlayer = True
            End If
        End If
        If frmMainMenu.FirstPlayer = False Then
            Exit Sub
        End If
        frmMainMenu.PlayerFlag = True
    End Sub
    Private Sub btnMuteUnMute_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnmute.MouseUp 'btnMuteUnmute MouseUp code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            My.Settings.Mute = True 'Sets the "Mute" variable in application settings to True
            lblMute.Text = "UnMute Sounds"
            btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button
        Else
            My.Settings.Mute = False 'Sets the "Mute" variable in application settings to False
            lblMute.Text = "Mute Sounds"
            btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button
        End If
        My.Settings.Save()
    End Sub
    Private Sub btnMuteUnMute_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnmute.MouseDown 'btnMuteUnmute MouseDown code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button_Pushed
        Else
            btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button_Pushed
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnmute.MouseEnter 'btnMuteUnmute MouseEnter code
        lblMute.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
            btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        Else
            btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnmute.MouseLeave 'btnMuteUnmute MouseLeave code
        lblMute.Visible = False
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button 'Changes the background image of the mute button to highlighted when the curser enters the button
        Else
            btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button 'Changes the background image of the mute button to highlighted when the curser enters the button
        End If
    End Sub
    'Minimize 
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown 'btnMuteUnmute MouseDown code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter 'btnMinimize MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave 'btnMinimize MouseLeave code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp 'btnMinimize MouseUp code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" picturebox's background to another image in resources
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed 'Changes the "btnClose" picturebox's background to another image in resources
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted 'Changes the "btnClose" picturebox's background to another image in resources
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave 'btnClose Button Mouseleave code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the mouse is set to up
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp 'btnClose Button MouseUp code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Dim MessageBoxResult As String 'Declares "MessageboxResult" as a string
        MessageBoxResult = MsgBox("Are you sure you want to close the program?", vbInformation + vbYesNo, "Close") 'Prompts the user before closing the program
        If MessageBoxResult = vbYes Then 'Checks if the user's decision from the message box was "Yes"
            End 'Closes the application
        End If
    End Sub
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        lblInfo.Visible = True 'Shows the "lblInfo" label
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave 'btnInfo Button MouseLeave code
        lblInfo.Visible = False 'Hides the "lblInfo" label
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp 'btnInfo Button MouseUp code
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" picturebox's background to another image in resources
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Dim ProcessDirectory As String = AppPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    'Return
    Private Sub btnReturn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseDown 'btnReturn Button MouseDown code
        btnReturn.BackgroundImage = My.Resources.Return_Button_Pushed 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseEnter 'btnReturn Button MouseEnter code
        lblMainMenu.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnReturn.BackgroundImage = My.Resources.Return_Button_Highlighted 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseLeave 'btnReturn Button MouseLeave code
        lblMainMenu.Visible = False
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnReturn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseUp 'btnReturn Button MouseUp code
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
        frmMainMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmMainMenu" form's location to the current form's location
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "sound_FormReturning" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
            frmMainMenu.btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Changes the "btnMuteUnMute" picturebox's background to another image in resources
        Else
            frmMainMenu.btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Changes the "btnMuteUnMute" picturebox's background to another image in resources
        End If
        frmMainMenu.Show() 'Shows the "frmMainMenu" form
        Me.Dispose() 'Closes the current form
    End Sub
    Private Sub btnSettings_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnGameSettings.MouseDown 'btnGameSettings Button MouseDown code
        btnGameSettings.BackgroundImage = My.Resources.GameSettings_Button_Pushed 'Changes the "btnGameSettings" picturebox's background to another image in resources
    End Sub
    Private Sub btnSettings_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGameSettings.MouseEnter 'btnGameSettings Button MouseEnter code
        lblGameSettings.Visible = True
        btnGameSettings.BackgroundImage = My.Resources.GameSettings_Button_Highlighted 'Changes the "btnGameSettings" picturebox's background to another image in resources
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGameSettings.MouseLeave 'btnGameSettings Button MouseLeave code
        lblGameSettings.Visible = False
        btnGameSettings.BackgroundImage = My.Resources.GameSettings_Button 'Changes the "btnGameSettings" picturebox's background to another image in resources
    End Sub
    Private Sub btnSettings_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnGameSettings.MouseUp 'btnGameSettings Button MouseUp code
        btnGameSettings.BackgroundImage = My.Resources.GameSettings_Button 'Changes the "btnGameSettings" picturebox's background to another image in resources
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        frmGameSettings.Show() 'Shows the "frmGameSettings" form
    End Sub
    'SinglePlayer
    Private Sub btnSinglePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSinglePlayer.Click 'btnSelectSinglePlayer Button Click code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.Hide()
        frmHangmanSinglePlayer.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanSinglePlayer" form's location to the current form's location
        frmHangmanSinglePlayer.Show() 'Shows the "frmHangmanSinglePlayer" form
    End Sub
    'TwoPlayer
    Private Sub btnTwoPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTwoPlayer.Click 'btnSelectTwoPlayer Button Click code
        GetPlayerNames()
        If frmMainMenu.FirstPlayer = False Or frmMainMenu.SecondPlayer = False Then
            Exit Sub
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.Hide()
        frmHangmanTwoPlayer.lblPlayerOne.Text = frmMainMenu.PlayerOne
        frmHangmanTwoPlayer.lblPlayerTwo.Text = frmMainMenu.PlayerTwo
        frmHangmanTwoPlayer.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the location of the "frmHangmanTwoPlayer" form to the current form's location
        frmHangmanTwoPlayer.Show() 'Shows the "frmHangmanTwoPlayer" form
    End Sub
    'Versus
    Private Sub btnSelectVersus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectVersus.Click 'btnSelectVersus button click event code
        GetPlayerNames() 'Calls the "GetPlayerNames" subroutine
        If frmMainMenu.FirstPlayer = False Or frmMainMenu.SecondPlayer = False Then 'Checks if both players have entered their names
            Exit Sub 'Exits the subroutine
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.Hide() 'Hides the current form
        frmHangmanVersus.lblPlayerOne.Text = frmMainMenu.PlayerOne
        frmHangmanVersus.lblPlayerTwo.Text = frmMainMenu.PlayerTwo
        frmHangmanVersus.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the location of the "frmHangmanVersus" form to the current form's location
        frmHangmanVersus.Show() 'Shows the "frmHangmanVersus" form
    End Sub

    'Timers
    Private Sub SoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundTimer.Tick 'SoundTimer Tick code
        frmMainMenu.btnClose.Enabled = True
        frmMainMenu.btnMaximize.Enabled = True
        frmMainMenu.btnMinimize.Enabled = True
        SoundTimer.Stop()
    End Sub

    Private Sub frmHangmanModeMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmHangmanModeMenu form Load code
        If My.Settings.DisableCaptions = False Then
            MouseMoveTimer.Start()
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            lblMute.Text = "Mute Sounds"
            btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button
        Else
            lblMute.Text = "UnMute Sounds"
            btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button
        End If
    End Sub
    Dim CaptionCounter As Integer
    Dim CurrentMousePosition As String
    Dim OpacityCounter As Integer
    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then  'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblMainMenu.Visible = False 'Hides the "lblMainMenu" label
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblMute.Visible = False 'Hides the "lblMute" label
                lblGameSettings.Visible = False 'Hides the "lblGameSettings" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblMainMenu.Visible = True  'Shows the "lblMainMenu" label
            lblInfo.Visible = True  'Shows the "lblInfo" label
            lblGameSettings.Visible = True  'Shows the "lblGameSettings" label
            If btnMuteUnmute.Visible = True Then 'Checks if the "btnMuteUnMute" picturebox is showing
                lblMute.Visible = True  'Shows the "lblMute" label
            End If
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick  'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub
End Class
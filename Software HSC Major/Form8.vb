Public Class frmTicTacToeModeMenu 'frmTicTacToeModeMenu
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
    Private Sub btnPlay1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSinglePlayer.Click 'btnSelectSinglePlayer click code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
            frmTicTacToeSinglePlayer.btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
            frmTicTacToeSinglePlayer.btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.Hide()
        frmTicTacToeSinglePlayer.Location = New Point(Me.Location.X - 119, Me.Location.Y) 'Sets the "frmTicTacToeSinglePlayer" form's location to the current form's location
        frmTicTacToeSinglePlayer.Show() 'Shows the "frmTicTacToeSinglePlayer" form
    End Sub
    'Mute/Unmute Button Events
    Private Sub btnMuteUnMute_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseUp  'btnMuteUnMute MouseUp code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            My.Settings.Mute = True 'Sets the "Mute" variable in application settings to True
            lblMute.Text = "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        Else
            My.Settings.Mute = False 'Sets the "Mute" variable in application settings to False
            lblMute.Text = "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        End If
        My.Settings.Save()
    End Sub
    Private Sub btnMuteUnMute_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseDown 'btnMuteUnMute MouseDown code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Pushed
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Pushed
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseEnter 'btnMuteUnMute MouseEnter code
        lblMute.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseLeave 'btnMuteUnMute MouseLeave code
        lblMute.Visible = False
        If My.Settings.Mute = False Then 'Checks if "Mute" variable is set to False
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Changes the background image of the mute button to highlighted when the curser enters the button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Changes the background image of the mute button to highlighted when the curser enters the button
        End If
    End Sub
    'Minimize Button Events
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown 'btnMinimize MouseDown code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter 'btnMinimize MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave 'btnMinimize MouseLeave code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp 'btnMinimize MouseUp code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Exit Button Events
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted
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
    'Info Button Events
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        lblInfo.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave 'btnInfo Button MouseLeave code
        lblInfo.Visible = False
        btnInfo.BackgroundImage = My.Resources.Info_Button
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp 'btnInfo Button MouseUp code
        btnInfo.BackgroundImage = My.Resources.Info_Button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Dim ProcessDirectory As String = AppPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    'Return Button Events
    Private Sub btnReturn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseDown 'btnReturn Button MouseDown code
        btnReturn.BackgroundImage = My.Resources.Return_Button_Pushed
    End Sub
    Private Sub btnReturn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseEnter 'btnReturn Button MouseEnter code
        lblMainMenu.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnReturn.BackgroundImage = My.Resources.Return_Button_Highlighted
    End Sub
    Private Sub btnReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseLeave 'btnReturn Button MouseLeave code
        lblMainMenu.Visible = False
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnReturn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseUp 'btnReturn Button MouseUp code
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
        frmMainMenu.Location = New Point(Me.Location.X - 119, Me.Location.Y)  'Sets the "frmMainMenu" form's location to the current form's location
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormReturning
            frmMainMenu.player.Play() 'Plays the sound file
            frmMainMenu.lblMute.Text = "Mute Sounds"
            frmMainMenu.btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        Else
            frmMainMenu.lblMute.Text = "UnMute Sounds"
            frmMainMenu.btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        End If
        frmMainMenu.Show() 'Shows the "frmMainMenu" form
        Me.Close()
    End Sub
    Private Sub btnSettings_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseDown 'btnSettings Button MouseDown code
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Pushed
    End Sub
    Private Sub btnSettings_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseEnter  'btnSettings Button MouseEnter code
        lblSettings.Visible = True
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Highlighted
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseLeave 'btnSettings Button MouseLeave code
        lblSettings.Visible = False
        btnSettings.BackgroundImage = My.Resources.Settings_Button
    End Sub
    Private Sub btnSettings_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseUp 'btnSettings Button MouseUp code
        btnSettings.BackgroundImage = My.Resources.Settings_Button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        frmSettings.Show() 'Shows the "frmSettings" form
    End Sub
    Private Sub frmTicTacToeModeMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmTicTacToeModeMenu form Load code
        If My.Settings.DisableCaptions = False Then
            MouseMoveTimer.Start()
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            lblMute.Text = "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        Else
            lblMute.Text = "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        End If
    End Sub
    Private Sub GetPlayerNames() 'GetPlayerNames subroutine code
        If frmMainMenu.PlayerFlag = True Then
            Dim MessageBoxResult As String
            MessageBoxResult = MsgBox("Player One: " & frmMainMenu.PlayerOne & vbCrLf & "Player Two: " & frmMainMenu.PlayerTwo & vbCrLf & vbCrLf & "Would you like to use the same player names?", vbYesNo + vbInformation, "Player Names")
            If MessageBoxResult = vbNo Then
                frmMainMenu.PlayerFlag = False
                frmMainMenu.FirstPlayer = False
                frmMainMenu.SecondPlayer = False
            End If
        End If
        If frmMainMenu.FirstPlayer = False Then
            Dim FirstPlayerInputBoxResult As String
            FirstPlayerInputBoxResult = InputBox("Player One, please enter your name:", "Player One", "Enter Your Name Here")
            If FirstPlayerInputBoxResult = "Enter Your Name Here" Then
                MsgBox("You have not entered a name. Please enter your name to continue", vbInformation, "Invalid Name")
                Exit Sub
            End If
            If FirstPlayerInputBoxResult = "" Then
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
            SecondPlayerInputBoxResult = InputBox("Player Two, please enter your name:", "Player Two", "Enter Your Name Here")
            If SecondPlayerInputBoxResult = "Enter Your Name Here" Then
                MsgBox("You have not entered a name. Please enter your name to continue", vbInformation, "Invalid Name")
                Exit Sub
            End If
            If SecondPlayerInputBoxResult = "" Then
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
    Private Sub btnTwoPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTwoPlayer.Click 'btnSelectTwoPlayer Click code
        GetPlayerNames()
        If frmMainMenu.FirstPlayer = False Or frmMainMenu.SecondPlayer = False Then
            Exit Sub
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormOpening 'Sets the soundplayer to the "FormOpening" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        frmTicTacToeTwoPlayer.lblPlayerOne.Text = frmMainMenu.PlayerOne
        frmTicTacToeTwoPlayer.lblPlayerTwo.Text = frmMainMenu.PlayerTwo
        Me.Hide()
        frmTicTacToeTwoPlayer.Location = New Point(Me.Location.X - 119, Me.Location.Y) 'Sets the "frmTicTacToeTwoPlayer" form's location to the current form's location
        frmTicTacToeTwoPlayer.Show() 'Shows the "frmTicTacToeTwoPlayer" form
    End Sub
    Dim CaptionCounter As Integer
    Dim CurrentMousePosition As String
    Dim OpacityCounter As Integer
    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then 'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblMainMenu.Visible = False 'Hides the "lblMainMenu" label
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblMute.Visible = False 'Hides the "lblMute" label
                lblSettings.Visible = False 'Hides the "lblSettings" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblMainMenu.Visible = True 'Shows the "lblMainMenu" label
            lblInfo.Visible = True 'Shows the "lblInfo" label
            lblSettings.Visible = True 'Shows the "lblSettings" label
            If btnMuteUnMute.Visible = True Then
                lblMute.Visible = True 'Shows the "lblMute" label
            End If
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub
End Class



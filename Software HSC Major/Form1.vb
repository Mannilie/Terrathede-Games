Imports System.IO 'Form makes reference to the "System.IO" namespace
Public Class frmMainMenu 'frmMainMenu Form Class
    Public PlayerFlag As Boolean = False
    Public FirstPlayer As Boolean = False
    Public SecondPlayer As Boolean = False
    Public PlayerOne As String
    Public PlayerTwo As String
    Public WithEvents player As New System.Media.SoundPlayer
    Dim AppPath As String = Application.StartupPath
    Dim CurrentMousePosition As String
    Dim OpacityCounter As Integer
    Dim CaptionCounter As Integer
    Dim FullMusicDirectory As String = Application.StartupPath & "\Music\"
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
    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmMainMenu Form Load code
        If My.Settings.DisableCaptions = False Then 'Checks if the application setting's boolean variable "DisableCaptions" is set to false
            MouseMoveTimer.Start() 'Starts the "MouseMoveTimer" timer
        End If
        If My.Settings.Mute = False Then 'Checks if the user wants the sounds to be muted on all form
            lblMute.Text = "Mute Sounds" 'Sets the "lblMute" label to "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Sets the "btnMuteUnmute" background image to specified file in resources
        Else
            lblMute.Text = "UnMute Sounds" 'Sets the "lblMute" label to "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Sets the "btnMuteUnmute" background image to specified file in resources
        End If
    End Sub
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown 'btnMinimize Button MouseDown code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed 'Changes the background image of the "btnMinimize" button when the mouse is down
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter 'btnMinimize Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted 'Changes the background image of the "btnMinimize" button to highlighted when the curser enters the button
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave 'btnMinimize Button MouseLeave code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp 'btnMinimize Button MouseUp code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        Me.WindowState = FormWindowState.Minimized 'Minimizes the form by changing the form's "FormWindowState" properties to "Minimized"
    End Sub
    'Exit 
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed  'Changes the background image of the "btnClose" button when the mouse is down
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted 'Changes the background image of the close button to highlighted when the curser enters the button
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave 'btnClose Button MouseLeave code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp 'btnClose Button MouseUp code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        Dim MessageBoxResult As String 'Declares "MessageboxResult" as a string
        MessageBoxResult = MsgBox("Are you sure you want to close the program?", vbInformation + vbYesNo, "Close") 'Prompts the user before closing the program
        If MessageBoxResult = vbYes Then 'Checks if the user's decision from the message box was "Yes"
            End 'Closes the application
        End If
    End Sub
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed 'Changes the background image of the "btnInfo" button when the mouse is down
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        lblInfo.Visible = True 'Shows the "lblInfo" label when mouse enters the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted 'Changes the background image of the info button to highlighted when the curser enters the button
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave 'btnInfo Button MouseLeave code
        lblInfo.Visible = False 'Hides the "lblInfo" label when mouse leaves the picture box
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp 'btnInfo Button MouseUp code
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        Dim ProcessDirectory As String = AppPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    Private Sub btnSettings_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseDown 'btnSettings Button MouseDown code
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Pushed  'Changes the background image of the "btnSettings" button when the mouse is down
    End Sub
    Private Sub btnSettings_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseEnter 'btnSettings Button MouseEnter code
        lblSettings.Visible = True 'Shows the "lblSettings" label when mouse enters the picture box
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Highlighted 'Changes the background image of the settings button to highlighted when the curser enters the button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseLeave 'btnSettings Button MouseLeave code
        lblSettings.Visible = False 'Hides the "lblSettings" label when mouse leaves the picture box
        btnSettings.BackgroundImage = My.Resources.Settings_Button 'Changes the "btnSettings" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnSettings_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseUp 'btnSettings Button MouseUp code
        btnSettings.BackgroundImage = My.Resources.Settings_Button 'Changes the "btnSettings" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "FormSelect" WAV file in the resources
            player.Play() 'Plays the sound file
        End If
        frmSettings.Show() 'Shows the "frmSettings" form
    End Sub
    Private Sub btnMuteUnMute_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseUp 'btnMuteUnMute Button MouseUp code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            My.Settings.Mute = True 'Sets the application setting's boolean variable "Mute" to true
            lblMute.Text = "UnMute Sounds" 'Sets the "lblMute" label's text value to "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Sets the "btnMuteUnmute" picturebox's background image to "UnMute_Button" in resources
        Else
            My.Settings.Mute = False 'Sets the "Mute" variable in application settings to false
            lblMute.Text = "Mute Sounds" 'Sets the "lblMute" label's text value to "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Sets the "btnMuteUnmute" picturebox's background image to "Mute_Button" in resources
        End If
        My.Settings.Save() 'Saves the application settings
    End Sub
    Private Sub btnMuteUnMute_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseDown 'btnMuteUnMute Button MouseDown code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Pushed 'Sets the "btnMuteUnmute" picturebox's background image to "UnMute_Button_Pushed" in resources
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Pushed 'Sets the "btnMuteUnmute" picturebox's background image to "Mute_Button_Pushed" in resources
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseEnter 'btnMuteUnMute Button MouseEnter code
        lblMute.Visible = True 'Shows the "lblMute" label
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            player.Play() 'Plays the sound file
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Highlighted 'Changes the background image of the mute button to highlighted when the curser enters the button
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseLeave 'btnMuteUnMute Button MouseLeave code
        lblMute.Visible = False 'Shows the "lblMute" label
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Changes the background image of the mute button to original image when the curser leaves the button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Changes the background image of the mute button to original image when the curser leaves the button
        End If
    End Sub
    'Hangman
    Private Sub btnHangMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHangMan.Click 'btnHangMan Button Click code
        frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormOpening 'Sets the player's stream to the "sound_FormOpening" WAV file in resources
            player.Play() 'Plays the sound file
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Changes the background image of the mute button to original image when the curser leaves the button
            frmHangmanModeMenu.btnMuteUnmute.BackgroundImage = My.Resources.UnMute_Button 'Sets the frmHangmanModeMenu's "btnMuteUnMute" picturebox's background image to "UnMute_Button" in resources
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Changes the background image of the mute button to original image when the curser leaves the button
            frmHangmanModeMenu.btnMuteUnmute.BackgroundImage = My.Resources.Mute_Button 'Sets the frmHangmanModeMenu's "btnMuteUnMute" picturebox's background image to "Mute_Button" in resources
        End If
        Me.Hide() 'Hides the current form
        frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
    End Sub
    Private Sub btnTicTacToe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicTacToe.Click 'btnTicTacToe Button Click code
        frmTicTacToeModeMenu.Location = New Point(Me.Location.X + 119, Me.Location.Y) 'Sets the "frmTicTacToeModeMenu" form's location to the current form's location
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            player.Stream = My.Resources.sound_FormOpening 'Sets the player's stream to the "sound_FormOpening" WAV file in resources
            player.Play() 'Plays the sound file
            frmTicTacToeModeMenu.lblMute.Text = "Mute Sounds" 'Sets the "lblMute" label's text value to "UnMute Sounds"
            frmTicTacToeModeMenu.btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button  'Changes the background image of the mute button to original image when the curser leaves the button
        Else
            frmTicTacToeModeMenu.lblMute.Text = "UnMute Sounds" 'Sets the "lblMute" label's text value to "Mute Sounds"
            frmTicTacToeModeMenu.btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button  'Changes the background image of the mute button to original image when the curser leaves the button
        End If
        Me.Hide() 'Hides the form
        frmTicTacToeModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
    End Sub
    'VLCMediaPlayer
    Private Sub btnVLCMediaPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVLCMediaPlayer.Click 'btnVLCMediaPlayer Button Click code
        Dim ProcessDirectory As String = AppPath & "\VLCMediaPlayer" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "VLCMediaPlayer.exe"
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the VLCMediaPlayer.exe (executable file)
    End Sub

    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then 'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblMute.Visible = False 'Hides the "lblMute" label
                lblSettings.Visible = False 'Hides the "lblSettings" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblSettings.Visible = True 'Shows the "lblSettings" label
            lblInfo.Visible = True 'Shows the "lblInfo" label
            If btnMuteUnMute.Visible = True Then 'Checks if the "btnMuteUnMute" picturebox is showing
                lblMute.Visible = True 'Shows the "lblMute" label
            End If
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub






























































End Class

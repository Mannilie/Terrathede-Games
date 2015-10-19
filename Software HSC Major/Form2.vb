Public Class frmHangmanVersus 'frmGameSettings form code
    Dim rand As New Random
    Dim Reader As IO.StreamReader
    Dim EndOfList As Integer
    Dim CurrentLetter As String
    Dim GameTime As Integer = 60
    Dim TokenTime As Integer = 1
    Dim SoundTime As Integer = 2
    Dim Winner As Boolean = False
    Dim Toggle As Boolean = False
    Dim ExitFlag As Boolean = True
    Dim BothLose As Boolean = False
    Dim BeepSound As Boolean = False
    Dim PlayerToken As Boolean = False
    Dim PlayerOneChances As Integer = 7
    Dim PlayerTwoChances As Integer = 7
    Dim CountDownCounter As Integer = 6
    Dim PlayerOneTokenNo As Integer = 0
    Dim PlayerTwoTokenNo As Integer = 0
    Dim CaptionCounter As Integer
    Dim CurrentMousePosition As String
    Dim OpacityCounter As Integer
    Dim CurrentPlayer As Boolean = True
    Dim NotCurrentPlayer As Boolean = True
    Dim PlayerWithToken As String = "No One"
    Dim appPath As String = Application.StartupPath()
    Dim word As String = ""
    Friend WithEvents beep As New System.Media.SoundPlayer
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
    Private Function PlayerOne_GetImage(ByVal bounds As Size) As Image 'PlayerOne_GetImage Private Function code
        Dim img As New Bitmap(bounds.Width, bounds.Height)
        If CurrentPlayer = True Then 'Checks if current player is player one
            If PlayerOneChances < 0 Then
                img = My.Resources.HangMan_CurrentPlayer_10
            End If
            If PlayerOneChances >= 0 Then
                img = My.Resources.HangMan_CurrentPlayer_10
            End If
            If PlayerOneChances > 1 Then
                img = My.Resources.HangMan_CurrentPlayer_9
            End If
            If PlayerOneChances > 2 Then
                img = My.Resources.HangMan_CurrentPlayer_8
            End If
            If PlayerOneChances > 3 Then
                img = My.Resources.HangMan_CurrentPlayer_7
            End If
            If PlayerOneChances > 4 Then
                img = My.Resources.HangMan_CurrentPlayer_6
            End If
            If PlayerOneChances > 5 Then
                img = My.Resources.HangMan_CurrentPlayer_5
            End If
            If PlayerOneChances > 6 Then
                img = My.Resources.HangMan_CurrentPlayer_4
            End If
            If PlayerOneChances > 7 Then
                img = My.Resources.HangMan_CurrentPlayer_3
            End If
            If PlayerOneChances > 8 Then
                img = My.Resources.HangMan_CurrentPlayer_2
            End If
            If PlayerOneChances > 9 Then
                img = My.Resources.HangMan_CurrentPlayer_1
            End If
            If PlayerOneChances > 10 Then
                img = My.Resources.HangMan_CurrentPlayer_0
            End If
            If PlayerOneChances > 11 Then
                img = My.Resources.HangMan_CurrentPlayer
            End If
        Else
            If PlayerOneChances < 0 Then
                img = My.Resources.HangMan_Player_10
            End If
            If PlayerOneChances >= 0 Then
                img = My.Resources.HangMan_Player_10
            End If
            If PlayerOneChances > 1 Then
                img = My.Resources.HangMan_Player_9
            End If
            If PlayerOneChances > 2 Then
                img = My.Resources.HangMan_Player_8
            End If
            If PlayerOneChances > 3 Then
                img = My.Resources.HangMan_Player_7
            End If
            If PlayerOneChances > 4 Then
                img = My.Resources.HangMan_Player_6
            End If
            If PlayerOneChances > 5 Then
                img = My.Resources.HangMan_Player_5
            End If
            If PlayerOneChances > 6 Then
                img = My.Resources.HangMan_Player_4
            End If
            If PlayerOneChances > 7 Then
                img = My.Resources.HangMan_Player_3
            End If
            If PlayerOneChances > 8 Then
                img = My.Resources.HangMan_Player_2
            End If
            If PlayerOneChances > 9 Then
                img = My.Resources.HangMan_Player_1
            End If
            If PlayerOneChances > 10 Then
                img = My.Resources.HangMan_Player_0
            End If
            If PlayerOneChances > 11 Then
                img = My.Resources.HangMan_Player
            End If
        End If
        Return img 'Returns the image
    End Function
    Private Function PlayerTwo_GetImage(ByVal bounds As Size) As Image 'PlayerTwo_GetImage Private Function code
        Dim img As New Bitmap(bounds.Width, bounds.Height)
        If NotCurrentPlayer = True Then 'Checks if the Player Two is the current player
            If PlayerTwoChances < 0 Then
                img = My.Resources.HangMan_CurrentPlayer_10
            End If
            If PlayerTwoChances >= 0 Then
                img = My.Resources.HangMan_CurrentPlayer_10
            End If
            If PlayerTwoChances > 1 Then
                img = My.Resources.HangMan_CurrentPlayer_9
            End If
            If PlayerTwoChances > 2 Then
                img = My.Resources.HangMan_CurrentPlayer_8
            End If
            If PlayerTwoChances > 3 Then
                img = My.Resources.HangMan_CurrentPlayer_7
            End If
            If PlayerTwoChances > 4 Then
                img = My.Resources.HangMan_CurrentPlayer_6
            End If
            If PlayerTwoChances > 5 Then
                img = My.Resources.HangMan_CurrentPlayer_5
            End If
            If PlayerTwoChances > 6 Then
                img = My.Resources.HangMan_CurrentPlayer_4
            End If
            If PlayerTwoChances > 7 Then
                img = My.Resources.HangMan_CurrentPlayer_3
            End If
            If PlayerTwoChances > 8 Then
                img = My.Resources.HangMan_CurrentPlayer_2
            End If
            If PlayerTwoChances > 9 Then
                img = My.Resources.HangMan_CurrentPlayer_1
            End If
            If PlayerTwoChances > 10 Then
                img = My.Resources.HangMan_CurrentPlayer_0
            End If
            If PlayerTwoChances > 11 Then
                img = My.Resources.HangMan_CurrentPlayer
            End If
        Else
            If PlayerTwoChances < 0 Then
                img = My.Resources.HangMan_Player_10
            End If
            If PlayerTwoChances >= 0 Then
                img = My.Resources.HangMan_Player_10
            End If
            If PlayerTwoChances > 1 Then
                img = My.Resources.HangMan_Player_9
            End If
            If PlayerTwoChances > 2 Then
                img = My.Resources.HangMan_Player_8
            End If
            If PlayerTwoChances > 3 Then
                img = My.Resources.HangMan_Player_7
            End If
            If PlayerTwoChances > 4 Then
                img = My.Resources.HangMan_Player_6
            End If
            If PlayerTwoChances > 5 Then
                img = My.Resources.HangMan_Player_5
            End If
            If PlayerTwoChances > 6 Then
                img = My.Resources.HangMan_Player_4
            End If
            If PlayerTwoChances > 7 Then
                img = My.Resources.HangMan_Player_3
            End If
            If PlayerTwoChances > 8 Then
                img = My.Resources.HangMan_Player_2
            End If
            If PlayerTwoChances > 9 Then
                img = My.Resources.HangMan_Player_1
            End If
            If PlayerTwoChances > 10 Then
                img = My.Resources.HangMan_Player_0
            End If
            If PlayerTwoChances > 11 Then
                img = My.Resources.HangMan_Player
            End If
        End If
        Return img 'Returns the image
    End Function
    Function GuessedLetter(ByVal Letter As String) 'GuessedLetter Function code
        Dim ReturnLetter As Boolean = False
        Dim x As Integer
        For i = 0 To word.Length - 1
            If word.Substring(i, 1) = Letter.ToLower Then
                x = i
                x = x + 1
                Mid(lblGuess.Text, x, 1) = Letter
                ReturnLetter = True
            End If
        Next i
        Return ReturnLetter
    End Function
    Private Sub Guess() 'Guess Private Sub code
        lblGameTime.Focus() 'Focuses on the label
        PicPlayerOne.BackgroundImage = Nothing 'Clears the Image
        PicPlayerTwo.BackgroundImage = Nothing 'Clears the Image
        If Toggle = False Then 'Checks if Toggle is set to false
            If GuessedLetter(CurrentLetter) = False Then
                PlayerOneChances = PlayerOneChances - 1
                CurrentPlayer = False
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size)
                NotCurrentPlayer = True
                Toggle = True 'Set's "Toggle" to true
                PicPlayerTwo.BackgroundImage = PlayerTwo_GetImage(PicPlayerTwo.Size)
            Else
                CurrentPlayer = True
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size)
                NotCurrentPlayer = False
                Toggle = False
                PicPlayerTwo.BackgroundImage = PlayerTwo_GetImage(PicPlayerTwo.Size)
            End If
            If word.ToUpper = lblGuess.Text.ToUpper Then
                If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
                    If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                        frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                        frmMainMenu.player.Play() 'Plays the sound file
                    End If
                    lblGuess.ForeColor = Color.Lime
                    lblGuess.Text = word.ToUpper
                End If
                PlayerOneTokenNo = PlayerOneTokenNo + 1
                If PlayerOneTokenNo > 4 Then
                    GetTokens() 'Calls the "GetTokensRestart" subroutine
                    StopTimers() 'Calls the "StopTimers" subroutine
                    PlayerOneTokenNo = 0 'Sets "PlayerOneTokenNo" to 0
                    PlayerTwoTokenNo = 0 'Sets "PlayerTwoTokenNo" to 0
                    Restart() 'Calls the "Restart" subroutine
                    DisableLetters() 'Calls the "DisableLetters" subroutine
                    DisableButtons() 'Calls the "DisableButtons" subroutine
                    ButtonEnableTimer.Start() 'Starts ButtonEnableTimer
                    Winner = True 'Set's "Winner" to true
                    WinnerSoundTimer.Start() 'Starts WinnerSoundTimer
                    PicPlayerOne.Image = My.Resources.Hangman_Player_One_Winner
                    PicPlayerTwo.Image = My.Resources.Hangman_Player_Two_Loser
                    Exit Sub
                End If
                PlayerOneChances = 7 'Sets "PlayerOneChances" to 7
                PlayerTwoChances = 7 'Sets "PlayerTwoChances" to 7
                PlayerToken = True
                GetTokens() 'Calls the "GetTokensRestart" subroutine
                StopTimers() 'Calls the "StopTimers" subroutine
                DisableLetters() 'Calls the "DisableLetters" subroutine
                WinnerSoundTimer.Start() 'Starts WinnerSoundTimer
                PicPlayerOne.Image = My.Resources.Hangman_Token
                PlayerWithToken = "Player 1"
                TokenTimer.Start() 'Starts TokenTimer
                Exit Sub
            End If
        Else
            If GuessedLetter(CurrentLetter) = False Then
                PlayerTwoChances = PlayerTwoChances - 1
                CurrentPlayer = True  'Set's "CurrentPlayer" to true
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size) 'Retrieves the image from the function
                Toggle = False  'Set's "Toggle" to False
                NotCurrentPlayer = False  'Set's "NotCurrentPlayer" to False
                PicPlayerTwo.BackgroundImage = PlayerTwo_GetImage(PicPlayerTwo.Size) 'Retrieves the image from the function
            Else
                CurrentPlayer = False 'Set's "CurrentPlayer" to False
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size) 'Retrieves the image from the function
                Toggle = True 'Set's "Toggle" to true
                NotCurrentPlayer = True 'Set's "NotCurrentPlayer" to true
                PicPlayerTwo.BackgroundImage = PlayerTwo_GetImage(PicPlayerTwo.Size) 'Retrieves the image from the function
            End If
            If word.ToUpper = lblGuess.Text.ToUpper Then 'Checks if the player got the word correct
                If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
                    If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                        frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                        frmMainMenu.player.Play() 'Plays the sound file
                    End If
                    lblGuess.ForeColor = Color.Lime 'Changes the color of the label
                    lblGuess.Text = word.ToUpper 'Displays the word in the label
                End If
                PlayerTwoTokenNo = PlayerTwoTokenNo + 1 'Increments PlayerTwoTokenNo
                If PlayerTwoTokenNo > 4 Then 'Checks if PlayerTwoTokenNo is greater than 4
                    StopTimers() 'Calls the "StopTimers" subroutine
                    GetTokens() 'Calls the "GetTokens" subroutine
                    PlayerOneTokenNo = 0 'Sets PlayerOneTokenNo to 0
                    PlayerTwoTokenNo = 0 'Sets PlayerTwoTokenNo to 0
                    Restart() 'Calls the "Restart" subroutine
                    DisableLetters() 'Calls the "DisableLetters" subroutine
                    DisableButtons() 'Calls the "DisableButtons" subroutine
                    ButtonEnableTimer.Start()
                    Winner = True 'Set's "Winner" to true
                    WinnerSoundTimer.Start()
                    PicPlayerOne.Image = My.Resources.Hangman_Player_One_loser
                    PicPlayerTwo.Image = My.Resources.Hangman_Player_Two_Winner
                    Exit Sub
                End If
                PlayerOneChances = 7 'Sets "PlayerOneChances" to 7
                PlayerTwoChances = 7 'Sets "PlayerTwoChances" to 7
                PlayerToken = True 'Set's "PlayerToken" to true
                GetTokens()  'Calls the "GetTokens" subroutine
                StopTimers()  'Calls the "StopTimers" subroutine
                DisableLetters()  'Calls the "DisableLetters" subroutine
                WinnerSoundTimer.Start()
                PicPlayerTwo.Image = My.Resources.Hangman_Token
                PlayerWithToken = "Player 2"
                TokenTimer.Start()
                Exit Sub
            End If
        End If
        If PlayerOneChances = 1 And PlayerTwoChances = 1 Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_rejected
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            PlayerOneChances = 7 'Sets "PlayerOneChances" to 7
            PlayerTwoChances = 7 'Sets "PlayerTwoChances" to 7
            BothLose = True 'Set's "BothLose" to true
            StopTimers()  'Calls the "StopTimers" subroutine
            DisableLetters()  'Calls the "DisableLetters" subroutine
            WinnerSoundTimer.Start()
            picWrongArrow.Visible = True 'Shows the picturebox
            lblGuess.ForeColor = Color.Maroon 'Changes the label's color to maroon
            lblGuess.Text = word.ToUpper 'Changes the label's case to upper
            TokenTimer.Start() 'Starts TokenTimer
            Exit Sub 'Exits subroutine
        End If
    End Sub
    Private Sub GetTokens()
        If PlayerOneTokenNo > 0 Then
            Player1_GoldToken1.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerOneTokenNo > 1 Then
            Player1_GoldToken2.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerOneTokenNo > 2 Then
            Player1_GoldToken3.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerOneTokenNo > 3 Then
            Player1_GoldToken4.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerOneTokenNo > 4 Then
            Player1_GoldToken5.BackgroundImage = My.Resources.Gold_Token
        End If

        If PlayerTwoTokenNo > 0 Then
            Player2_GoldToken1.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerTwoTokenNo > 1 Then
            Player2_GoldToken2.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerTwoTokenNo > 2 Then
            Player2_GoldToken3.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerTwoTokenNo > 3 Then
            Player2_GoldToken4.BackgroundImage = My.Resources.Gold_Token
        End If
        If PlayerTwoTokenNo > 4 Then
            Player2_GoldToken5.BackgroundImage = My.Resources.Gold_Token
        End If
    End Sub
    Private Sub DisableButtons() 'DisableButtons subroutine code
        btnStart.Enabled = False
        btnReturn.Enabled = False
        btnInfo.Enabled = False
        btnClose.Enabled = False
        btnMinimize.Enabled = False
    End Sub
    Private Sub EnableLetters() 'EnableLetters subroutine code
        'Changes back color of all buttons to Silver
        btnA.BackColor = Color.Silver
        btnB.BackColor = Color.Silver
        btnC.BackColor = Color.Silver
        btnD.BackColor = Color.Silver
        btnE.BackColor = Color.Silver
        btnF.BackColor = Color.Silver
        btnG.BackColor = Color.Silver
        btnH.BackColor = Color.Silver
        btnI.BackColor = Color.Silver
        btnJ.BackColor = Color.Silver
        btnK.BackColor = Color.Silver
        btnL.BackColor = Color.Silver
        btnM.BackColor = Color.Silver
        btnN.BackColor = Color.Silver
        btnO.BackColor = Color.Silver
        btnP.BackColor = Color.Silver
        btnQ.BackColor = Color.Silver
        btnR.BackColor = Color.Silver
        btnS.BackColor = Color.Silver
        btnT.BackColor = Color.Silver
        btnU.BackColor = Color.Silver
        btnV.BackColor = Color.Silver
        btnW.BackColor = Color.Silver
        btnX.BackColor = Color.Silver
        btnY.BackColor = Color.Silver
        btnZ.BackColor = Color.Silver
        'Re-enables all of the buttons
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True
    End Sub
    Private Sub DisableLetters() 'DisableLetters subroutine code
        'Changes back color of all buttons to DimGray
        btnA.BackColor = Color.DimGray
        btnB.BackColor = Color.DimGray
        btnC.BackColor = Color.DimGray
        btnD.BackColor = Color.DimGray
        btnE.BackColor = Color.DimGray
        btnF.BackColor = Color.DimGray
        btnG.BackColor = Color.DimGray
        btnH.BackColor = Color.DimGray
        btnI.BackColor = Color.DimGray
        btnJ.BackColor = Color.DimGray
        btnK.BackColor = Color.DimGray
        btnL.BackColor = Color.DimGray
        btnM.BackColor = Color.DimGray
        btnN.BackColor = Color.DimGray
        btnO.BackColor = Color.DimGray
        btnP.BackColor = Color.DimGray
        btnQ.BackColor = Color.DimGray
        btnR.BackColor = Color.DimGray
        btnS.BackColor = Color.DimGray
        btnT.BackColor = Color.DimGray
        btnU.BackColor = Color.DimGray
        btnV.BackColor = Color.DimGray
        btnW.BackColor = Color.DimGray
        btnX.BackColor = Color.DimGray
        btnY.BackColor = Color.DimGray
        btnZ.BackColor = Color.DimGray
        'Disables all of the buttons
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False
    End Sub
    Private Sub ClearTokens() 'ClearTokens subroutine code
        'Obtains the image from resources for pictureboxes below
        Player1_GoldToken1.BackgroundImage = My.Resources.No_Token
        Player1_GoldToken2.BackgroundImage = My.Resources.No_Token
        Player1_GoldToken3.BackgroundImage = My.Resources.No_Token
        Player1_GoldToken4.BackgroundImage = My.Resources.No_Token
        Player1_GoldToken5.BackgroundImage = My.Resources.No_Token
        Player2_GoldToken1.BackgroundImage = My.Resources.No_Token
        Player2_GoldToken2.BackgroundImage = My.Resources.No_Token
        Player2_GoldToken3.BackgroundImage = My.Resources.No_Token
        Player2_GoldToken4.BackgroundImage = My.Resources.No_Token
        Player2_GoldToken5.BackgroundImage = My.Resources.No_Token
    End Sub
    Private Sub Restart() 'Restart subroutine code
        PicPlayerOne.Image = Nothing 'Clears picture box
        PicPlayerTwo.Image = Nothing 'Clears picture box
        PicPlayerOne.BackgroundImage = My.Resources.HangMan_Player
        PicPlayerTwo.BackgroundImage = My.Resources.HangMan_Player
        lblGameTime.ForeColor = Color.Black 'Changes label's forecolor to black
        lblGameTime.Text = "01:00" 'Changes label's text
        lblGuess.Text = "Getting Word..." 'Changes label's text
        ClearTokens() 'Calls the "ClearTokens" subroutine
        GetTokens() 'Calls the "GetTokens" subroutine
        StopTimers() 'Calls the "StopTimers" subroutine
        DisableLetters() 'Calls the "DisableLetters" subroutine
        btnStart.Visible = True 'Shows start button
        lblGuess.Visible = False 'Hides guess label
    End Sub
    Private Sub GameStart() 'GameStart subroutine code
        BeepSound = False 'Set's "BeepSound" variable to false
        picWrongArrow.Visible = False 'Hides picturebox
        lblGuess.ForeColor = Color.Black 'Changes label's forecolor to black
        EnableLetters() 'Calls the "EnableLetters" subroutine
        EndOfList = lstWords.Items.Count
        GetTokens() 'Calls the "GetTokens" subroutine
        PicPlayerOne.Image = Nothing
        PicPlayerTwo.Image = Nothing
        PicPlayerOne.BackgroundImage = My.Resources.HangMan_CurrentPlayer_4
        PicPlayerTwo.BackgroundImage = My.Resources.HangMan_Player_4
        GameTimer.Start() 'Starts GameTimer
        GameTime = 60 'Sets GameTime to 60
        lblGameTime.Text = "01:00" 'Changes label's text
        lblGuess.Text = "" 'Clears label's text
        word = lstWords.Items.Item(rand.Next(0, EndOfList)) 'Gets next random word
        word = word.ToLower 'Sets the random word to lowercase
        For i = 0 To word.Length - 1 'Executes a set of commands a certain amount of times
            If word(i) = " " Then 'Checks for spaces in the word
                lblGuess.Text &= " " 'Changes label's text
            Else
                lblGuess.Text &= "-" 'Changes label's text
            End If
        Next i
        PlayerOneChances = 7 'Sets "PlayerOneChances" to 7
        PlayerTwoChances = 7 'Sets "PlayerOneChances" to 7
        CurrentPlayer = True 'Set's "CurrentPlayer" to True
        NotCurrentPlayer = True 'Set's "NotCurrentPlayer" to True
        CurrentLetter = "" 'Clears label's text
    End Sub
    Private Sub StopTimers() 'StopTimers subroutine code
        GameTimer.Stop() 'Stops the "GameTimer"
        BeepTimer.Stop() 'Stops the "BeepTimer"
        ColorTimer.Stop() 'Stops the "ColorTimer"
        CountDownTimer.Stop() 'Stops the "CountDownTimer"
        TokenTimer.Stop() 'Stops the "TokenTimer"
        WinnerSoundTimer.Stop() 'Stops the "WinnerSoundTimer"
        ButtonEnableTimer.Stop() 'Stops the "ButtonEnableTimer"
        lblGameTime.ForeColor = Color.Black 'Changes label's forecolor to black
    End Sub

    Private Sub frmHangmanVersus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress 'frmHangmanVersus Keypress event code
        If Asc(e.KeyChar) = 13 And btnStart.Visible = True Then 'Checks if "enter key" has been pushed
            btnStart_MouseUp(Nothing, Nothing) 'Calls the btnstart button's MouseUp event
        End If
        If (Asc(e.KeyChar) = 65 Or Asc(e.KeyChar) = 97) And btnA.Enabled = True Then 'Checks if the button pressed on the keyboard is either "A" or "a" and checks if the button is enabled
            btnA_Click(Nothing, Nothing) 'Calls the "btnA_Click" event
        ElseIf (Asc(e.KeyChar) = 66 Or Asc(e.KeyChar) = 98) And btnB.Enabled = True Then 'Checks if the button pressed on the keyboard is either "B" or "b" and checks if the button is enabled
            btnB_Click(Nothing, Nothing) 'Calls the "btnB_Click" event
        ElseIf (Asc(e.KeyChar) = 67 Or Asc(e.KeyChar) = 99) And btnC.Enabled = True Then 'Checks if the button pressed on the keyboard is either "C" or "c" and checks if the button is enabled
            btnC_Click(Nothing, Nothing) 'Calls the "btnC_Click" event
        ElseIf (Asc(e.KeyChar) = 68 Or Asc(e.KeyChar) = 100) And btnD.Enabled = True Then 'Checks if the button pressed on the keyboard is either "D" or "d" and checks if the button is enabled
            btnD_Click(Nothing, Nothing) 'Calls the "btnD_Click" event
        ElseIf (Asc(e.KeyChar) = 69 Or Asc(e.KeyChar) = 101) And btnE.Enabled = True Then 'Checks if the button pressed on the keyboard is either "E" or "e" and checks if the button is enabled
            btnE_Click(Nothing, Nothing) 'Calls the "btnE_Click" event
        ElseIf (Asc(e.KeyChar) = 70 Or Asc(e.KeyChar) = 102) And btnF.Enabled = True Then 'Checks if the button pressed on the keyboard is either "F" or "f" and checks if the button is enabled
            btnF_Click(Nothing, Nothing) 'Calls the "btnF_Click" event
        ElseIf (Asc(e.KeyChar) = 71 Or Asc(e.KeyChar) = 103) And btnG.Enabled = True Then 'Checks if the button pressed on the keyboard is either "G" or "g" and checks if the button is enabled
            btnG_Click(Nothing, Nothing) 'Calls the "btnG_Click" event
        ElseIf (Asc(e.KeyChar) = 72 Or Asc(e.KeyChar) = 104) And btnH.Enabled = True Then 'Checks if the button pressed on the keyboard is either "H" or "h" and checks if the button is enabled
            btnH_Click(Nothing, Nothing) 'Calls the "btnH_Click" event
        ElseIf (Asc(e.KeyChar) = 73 Or Asc(e.KeyChar) = 105) And btnI.Enabled = True Then 'Checks if the button pressed on the keyboard is either "I" or "i" and checks if the button is enabled
            btnI_Click(Nothing, Nothing) 'Calls the "btnI_Click" event
        ElseIf (Asc(e.KeyChar) = 74 Or Asc(e.KeyChar) = 106) And btnJ.Enabled = True Then 'Checks if the button pressed on the keyboard is either "J" or "j" and checks if the button is enabled
            btnJ_Click(Nothing, Nothing) 'Calls the "btnJ_Click" event
        ElseIf (Asc(e.KeyChar) = 75 Or Asc(e.KeyChar) = 107) And btnK.Enabled = True Then 'Checks if the button pressed on the keyboard is either "K" or "k" and checks if the button is enabled
            btnK_Click(Nothing, Nothing) 'Calls the "btnK_Click" event
        ElseIf (Asc(e.KeyChar) = 76 Or Asc(e.KeyChar) = 108) And btnL.Enabled = True Then 'Checks if the button pressed on the keyboard is either "L" or "l" and checks if the button is enabled
            btnL_Click(Nothing, Nothing) 'Calls the "btnL_Click" event
        ElseIf (Asc(e.KeyChar) = 77 Or Asc(e.KeyChar) = 109) And btnM.Enabled = True Then 'Checks if the button pressed on the keyboard is either "M" or "m" and checks if the button is enabled
            btnM_Click(Nothing, Nothing) 'Calls the "btnM_Click" event
        ElseIf (Asc(e.KeyChar) = 78 Or Asc(e.KeyChar) = 110) And btnN.Enabled = True Then 'Checks if the button pressed on the keyboard is either "N" or "n" and checks if the button is enabled
            btnN_Click(Nothing, Nothing) 'Calls the "btnN_Click" event
        ElseIf (Asc(e.KeyChar) = 79 Or Asc(e.KeyChar) = 111) And btnO.Enabled = True Then 'Checks if the button pressed on the keyboard is either "O" or "o" and checks if the button is enabled
            btnO_Click(Nothing, Nothing) 'Calls the "btnO_Click" event
        ElseIf (Asc(e.KeyChar) = 80 Or Asc(e.KeyChar) = 112) And btnP.Enabled = True Then 'Checks if the button pressed on the keyboard is either "P" or "p" and checks if the button is enabled
            btnP_Click(Nothing, Nothing) 'Calls the "btnP_Click" event
        ElseIf (Asc(e.KeyChar) = 81 Or Asc(e.KeyChar) = 113) And btnQ.Enabled = True Then 'Checks if the button pressed on the keyboard is either "Q" or "q" and checks if the button is enabled
            btnQ_Click(Nothing, Nothing) 'Calls the "btnQ_Click" event
        ElseIf (Asc(e.KeyChar) = 82 Or Asc(e.KeyChar) = 114) And btnR.Enabled = True Then 'Checks if the button pressed on the keyboard is either "R" or "r" and checks if the button is enabled
            btnR_Click(Nothing, Nothing) 'Calls the "btnR_Click" event
        ElseIf (Asc(e.KeyChar) = 83 Or Asc(e.KeyChar) = 115) And btnS.Enabled = True Then 'Checks if the button pressed on the keyboard is either "S" or "s" and checks if the button is enabled
            btnS_Click(Nothing, Nothing) 'Calls the "btnS_Click" event
        ElseIf (Asc(e.KeyChar) = 84 Or Asc(e.KeyChar) = 116) And btnT.Enabled = True Then 'Checks if the button pressed on the keyboard is either "T" or "t" and checks if the button is enabled
            btnT_Click(Nothing, Nothing) 'Calls the "btnT_Click" event
        ElseIf (Asc(e.KeyChar) = 85 Or Asc(e.KeyChar) = 117) And btnU.Enabled = True Then 'Checks if the button pressed on the keyboard is either "U" or "u" and checks if the button is enabled
            btnU_Click(Nothing, Nothing) 'Calls the "btnU_Click" event
        ElseIf (Asc(e.KeyChar) = 86 Or Asc(e.KeyChar) = 118) And btnV.Enabled = True Then 'Checks if the button pressed on the keyboard is either "V" or "v" and checks if the button is enabled
            btnV_Click(Nothing, Nothing) 'Calls the "btnV_Click" event
        ElseIf (Asc(e.KeyChar) = 87 Or Asc(e.KeyChar) = 119) And btnW.Enabled = True Then 'Checks if the button pressed on the keyboard is either "W" or "w" and checks if the button is enabled
            btnW_Click(Nothing, Nothing) 'Calls the "btnW_Click" event
        ElseIf (Asc(e.KeyChar) = 88 Or Asc(e.KeyChar) = 120) And btnX.Enabled = True Then 'Checks if the button pressed on the keyboard is either "X" or "x" and checks if the button is enabled
            btnX_Click(Nothing, Nothing) 'Calls the "btnX_Click" event
        ElseIf (Asc(e.KeyChar) = 89 Or Asc(e.KeyChar) = 121) And btnY.Enabled = True Then 'Checks if the button pressed on the keyboard is either "Y" or "y" and checks if the button is enabled
            btnY_Click(Nothing, Nothing) 'Calls the "btnY_Click" event
        ElseIf (Asc(e.KeyChar) = 90 Or Asc(e.KeyChar) = 122) And btnZ.Enabled = True Then 'Checks if the button pressed on the keyboard is either "Z" or "z" and checks if the button is enabled
            btnZ_Click(Nothing, Nothing) 'Calls the "btnZ_Click" event
        End If
    End Sub
    Private Sub frmHangmanVersus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmHangmanVersus form load event code
        If My.Settings.DisableCaptions = False Then 'Checks if the application setting's boolean variable "DisableCaptions" is set to False
            MouseMoveTimer.Start() 'Starts MouseMoveTimer
        End If
        DisableLetters() 'Calls the "DisableLetters" subroutine
        If My.Settings.HangmanDefaultGameList = False Then 'Checks if the application setting's boolean variable "HangmanDefaultGameList" is set to False
            Dim rand As New Random
            Reader = New IO.StreamReader(appPath & "\CustomWordList.txt") 'Streams the reader in the directory of "CustomWordList.txt"
            While (Reader.Peek() > -1)
                lstWords.Items.Add(Reader.ReadLine) 'Adds the readline of the text document to the listbox
            End While
            Reader.Close()
        Else
            Dim rand As New Random
            Reader = New IO.StreamReader(appPath & "\DefaultWordList.txt") 'Streams the reader in the directory of "DefaultWordList.txt"
            While (Reader.Peek() > -1)
                lstWords.Items.Add(Reader.ReadLine) 'Adds the readline of the text document to the listbox
            End While
            Reader.Close() 'Closes the reader
        End If
        EndOfList = lstWords.Items.Count 'Sets the end of the list to the mount of items in the listbox
    End Sub
    Private Sub btnStart_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnStart.MouseDown 'btnStart Button MouseDown code
        btnStart.BackgroundImage = My.Resources.Start_Button_Pushed 'Changes the background image of the "btnStart" button when the mouse is down
    End Sub
    Private Sub btnStart_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseEnter 'btnStart Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnStart.BackgroundImage = My.Resources.Start_Button_Highlighted 'Changes the background image of the "btnStart" button to highlighted when the curser enters the button
    End Sub
    Private Sub btnStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseLeave 'btnStart Button MouseLeave code
        btnStart.BackgroundImage = My.Resources.Start_Button 'Changes the "btnStart" button's background image to the original image when the mouse is set to up
    End Sub
    Private Sub btnStart_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnStart.MouseUp 'btnStart Button MouseUp code
        btnStart.BackgroundImage = My.Resources.Start_Button 'Changes the "btnStart" button's background image to the original image when the mouse is set to up
        PicPlayerOne.BackgroundImage = My.Resources.HangMan_Player
        PicPlayerTwo.BackgroundImage = My.Resources.HangMan_Player
        CountDownTimer.Start()
        PicPlayerOne.Image = My.Resources.Hangman_Five
        PicPlayerTwo.Image = My.Resources.Hangman_Five
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnStart.Visible = False
        lblGuess.Visible = True
        ExitFlag = False
    End Sub
    'Close
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
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
    'Minimize
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" picturebox's background to another image in resources
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" picturebox's background to another image in resources
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        Me.WindowState = FormWindowState.Minimized 'Minimizes current form
    End Sub
    'Info
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        lblInfo.Visible = True
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave 'btnInfo Button MouseLeave code
        lblInfo.Visible = False
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" picturebox's background to another image in resources
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp 'btnInfo Button MouseUp code
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" picturebox's background to another image in resources
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        Dim ProcessDirectory As String = appPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    'Return
    Private Sub btnReturn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseDown 'btnReturn Button MouseDown code
        btnReturn.BackgroundImage = My.Resources.Return_Button_Pushed 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseEnter 'btnReturn Button MouseEnter code
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        lblLeaveGame.Visible = True
        btnReturn.BackgroundImage = My.Resources.Return_Button_Highlighted 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseLeave 'btnReturn Button MouseLeave code
        lblLeaveGame.Visible = False
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnReturn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseUp 'btnReturn Button MouseUp code
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
        If ExitFlag = True Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            Restart()
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
            Exit Sub
        End If
        Dim MessageBoxResult As String
        MessageBoxResult = MsgBox("Are you sure you wish to exit the game?", vbYesNo, "Exit Game")
        If MessageBoxResult = vbYes Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            Restart()
            ExitFlag = True
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
        End If
    End Sub

    'Alphabet 
    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click 'btnA button mouse click event
        btnA.BackColor = Color.DimGray 'Sets the "btnA" button's backcolor to DimGray
        btnA.Enabled = False 'Disables the "btnA" button
        CurrentLetter = "A" 'Sets the "CurrentLetter" string variable to "A"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click 'btnB button mouse click event
        btnB.BackColor = Color.DimGray 'Sets the "btnB" button's backcolor to DimGray
        btnB.Enabled = False 'Disables the "btnB" button
        CurrentLetter = "B" 'Sets the "CurrentLetter" string variable to "B"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click 'btnC button mouse click event
        btnC.BackColor = Color.DimGray 'Sets the "btnC" button's backcolor to DimGray
        btnC.Enabled = False 'Disables the "btnC" button
        CurrentLetter = "C" 'Sets the "CurrentLetter" string variable to "C"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click 'btnD button mouse click event
        btnD.BackColor = Color.DimGray 'Sets the "btnD" button's backcolor to DimGray
        btnD.Enabled = False 'Disables the "btnD" button
        CurrentLetter = "D" 'Sets the "CurrentLetter" string variable to "D"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click 'btnE button mouse click event
        btnE.BackColor = Color.DimGray 'Sets the "btnE" button's backcolor to DimGray
        btnE.Enabled = False 'Disables the "btnE" button
        CurrentLetter = "E" 'Sets the "CurrentLetter" string variable to "E"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click 'btnF button mouse click event
        btnF.BackColor = Color.DimGray 'Sets the "btnF" button's backcolor to DimGray
        btnF.Enabled = False 'Disables the "btnF" button
        CurrentLetter = "F" 'Sets the "CurrentLetter" string variable to "F"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click 'btnG button mouse click event
        btnG.BackColor = Color.DimGray 'Sets the "btnG" button's backcolor to DimGray
        btnG.Enabled = False 'Disables the "btnG" button
        CurrentLetter = "G" 'Sets the "CurrentLetter" string variable to "G"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click 'btnH button mouse click event
        btnH.BackColor = Color.DimGray 'Sets the "btnH" button's backcolor to DimGray
        btnH.Enabled = False 'Disables the "btnH" button
        CurrentLetter = "H" 'Sets the "CurrentLetter" string variable to "H"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click 'btnI button mouse click event
        btnI.BackColor = Color.DimGray 'Sets the "btnI" button's backcolor to DimGray
        btnI.Enabled = False 'Disables the "btnI" button
        CurrentLetter = "I" 'Sets the "CurrentLetter" string variable to "I"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click 'btnJ button mouse click event
        btnJ.BackColor = Color.DimGray 'Sets the "btnJ" button's backcolor to DimGray
        btnJ.Enabled = False 'Disables the "btnJ" button
        CurrentLetter = "J" 'Sets the "CurrentLetter" string variable to "J"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click 'btnK button mouse click event
        btnK.BackColor = Color.DimGray 'Sets the "btnK" button's backcolor to DimGray
        btnK.Enabled = False 'Disables the "btnK" button
        CurrentLetter = "K" 'Sets the "CurrentLetter" string variable to "K"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click 'btnL button mouse click event
        btnL.BackColor = Color.DimGray 'Sets the "btnL" button's backcolor to DimGray
        btnL.Enabled = False 'Disables the "btnL" button
        CurrentLetter = "L" 'Sets the "CurrentLetter" string variable to "L"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click 'btnM button mouse click event
        btnM.BackColor = Color.DimGray 'Sets the "btnM" button's backcolor to DimGray
        btnM.Enabled = False 'Disables the "btnM" button
        CurrentLetter = "M" 'Sets the "CurrentLetter" string variable to "M"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click 'btnN button mouse click event
        btnN.BackColor = Color.DimGray 'Sets the "btnN" button's backcolor to DimGray
        btnN.Enabled = False 'Disables the "btnN" button
        CurrentLetter = "N" 'Sets the "CurrentLetter" string variable to "N"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click 'btnO button mouse click event
        btnO.BackColor = Color.DimGray 'Sets the "btnO" button's backcolor to DimGray
        btnO.Enabled = False 'Disables the "btnO" button
        CurrentLetter = "O" 'Sets the "CurrentLetter" string variable to "O"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click 'btnP button mouse click event
        btnP.BackColor = Color.DimGray 'Sets the "btnP" button's backcolor to DimGray
        btnP.Enabled = False 'Disables the "btnP" button
        CurrentLetter = "P" 'Sets the "CurrentLetter" string variable to "P"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click 'btnQ button mouse click event
        btnQ.BackColor = Color.DimGray 'Sets the "btnQ" button's backcolor to DimGray
        btnQ.Enabled = False 'Disables the "btnQ" button
        CurrentLetter = "Q" 'Sets the "CurrentLetter" string variable to "Q"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click 'btnR button mouse click event
        btnR.BackColor = Color.DimGray 'Sets the "btnR" button's backcolor to DimGray
        btnR.Enabled = False 'Disables the "btnR" button
        CurrentLetter = "R" 'Sets the "CurrentLetter" string variable to "R"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click 'btnS button mouse click event
        btnS.BackColor = Color.DimGray 'Sets the "btnS" button's backcolor to DimGray
        btnS.Enabled = False 'Disables the "btnS" button
        CurrentLetter = "S" 'Sets the "CurrentLetter" string variable to "S"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click 'btnT button mouse click event
        btnT.BackColor = Color.DimGray 'Sets the "btnT" button's backcolor to DimGray
        btnT.Enabled = False 'Disables the "btnT" button
        CurrentLetter = "T" 'Sets the "CurrentLetter" string variable to "T"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click 'btnU button mouse click event
        btnU.BackColor = Color.DimGray 'Sets the "btnU" button's backcolor to DimGray
        btnU.Enabled = False 'Disables the "btnU" button
        CurrentLetter = "U" 'Sets the "CurrentLetter" string variable to "U"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click 'btnV button mouse click event
        btnV.BackColor = Color.DimGray 'Sets the "btnV" button's backcolor to DimGray
        btnV.Enabled = False 'Disables the "btnV" button
        CurrentLetter = "V" 'Sets the "CurrentLetter" string variable to "V"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click 'btnW button mouse click event
        btnW.BackColor = Color.DimGray 'Sets the "btnW" button's backcolor to DimGray
        btnW.Enabled = False 'Disables the "btnW" button
        CurrentLetter = "W" 'Sets the "CurrentLetter" string variable to "W"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click 'btnX button mouse click event
        btnX.BackColor = Color.DimGray 'Sets the "btnX" button's backcolor to DimGray
        btnX.Enabled = False 'Disables the "btnX" button
        CurrentLetter = "X" 'Sets the "CurrentLetter" string variable to "X"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click 'btnY button mouse click event
        btnY.BackColor = Color.DimGray 'Sets the "btnY" button's backcolor to DimGray
        btnY.Enabled = False 'Disables the "btnY" button
        CurrentLetter = "Y" 'Sets the "CurrentLetter" string variable to "Y"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click 'btnZ button mouse click event
        btnZ.BackColor = Color.DimGray 'Sets the "btnZ" button's backcolor to DimGray
        btnZ.Enabled = False 'Disables the "btnZ" button
        CurrentLetter = "Z" 'Sets the "CurrentLetter" string variable to "Z"
        Guess() 'Calls the "Guess" subroutine
    End Sub
    Private Sub btnA_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnZ.MouseUp, btnY.MouseUp, btnX.MouseUp, btnW.MouseUp, btnV.MouseUp, btnU.MouseUp, btnT.MouseUp, btnS.MouseUp, btnR.MouseUp, btnQ.MouseUp, btnP.MouseUp, btnO.MouseUp, btnN.MouseUp, btnM.MouseUp, btnL.MouseUp, btnK.MouseUp, btnJ.MouseUp, btnI.MouseUp, btnH.MouseUp, btnG.MouseUp, btnF.MouseUp, btnE.MouseUp, btnD.MouseUp, btnC.MouseUp, btnB.MouseUp, btnA.MouseUp
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_select2
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
    End Sub
    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick
        GameTime = GameTime - 1
        lblGameTime.Text = GameTime.ToString("00:00")
        If GameTime = 30 Then
            BeepTimer.Start()
        End If
        If GameTime = 29 Then
            BeepSound = True 'Sets "BeepSound" variable to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                beep.Stream = My.Resources.wagermatchend_converted
                beep.Play()
            End If
        End If
        If GameTime < 1 Then
            BeepTimer.Stop() 'Stops BeepTimer
            GameTimer.Stop() 'Stops GameTimer
        End If
        If GameTime = 0 Then
            BeepSound = False 'Sets "BeepSound" variable to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_rejected
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            PlayerOneChances = 7 'Sets PlayerOneChances to 7
            PlayerTwoChances = 7 'Sets PlayerTwoChances to 7
            BothLose = True 'Sets the boolean variable BothLose to True
            StopTimers() 'Calls the StopTimers subroutine
            DisableLetters() 'Calls the StopTimers subroutine
            WinnerSoundTimer.Start() 'Starts WinnerSoundTimer
            picWrongArrow.Visible = True 'Hides picturebox
            lblGuess.ForeColor = Color.Maroon
            lblGuess.Text = word.ToUpper
            TokenTimer.Start() 'Starts timer
        End If
    End Sub
    Private Sub BeepTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeepTimer.Tick 'BeepTimer Tick code
        ColorTimer.Start() 'Starts ColorTimer
        BeepTimer.Stop() 'Stops BeepTimer
    End Sub
    Private Sub ColorTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTimer.Tick 'ColorTimer Tick code
        If lblGameTime.ForeColor = Color.Black Then
            lblGameTime.ForeColor = Color.Red
        Else
            lblGameTime.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CountDownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountDownTimer.Tick 'CountDownTimer Tick code
        CountDownCounter = CountDownCounter - 1
        If CountDownCounter = 5 Then
            PicPlayerOne.Image = My.Resources.Hangman_Four
            PicPlayerTwo.Image = My.Resources.Hangman_Four
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 4 Then
            PicPlayerOne.Image = My.Resources.Hangman_Three
            PicPlayerTwo.Image = My.Resources.Hangman_Three
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 3 Then
            PicPlayerOne.Image = My.Resources.Hangman_Two
            PicPlayerTwo.Image = My.Resources.Hangman_Two
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 2 Then
            PicPlayerOne.Image = My.Resources.Hangman_One
            PicPlayerTwo.Image = My.Resources.Hangman_One
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 1 Then
            PicPlayerOne.Image = Nothing
            PicPlayerTwo.Image = Nothing
            GameStart()
            CountDownTimer.Stop()
            CountDownCounter = 6
        End If
    End Sub
    Private Sub TokenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TokenTimer.Tick 'TokenTimer Tick code
        TokenTime = TokenTime - 1
        SoundTime = SoundTime - 1
        If PlayerWithToken = "Player 1" Then
            PicPlayerOne.Image = My.Resources.Hangman_Token
        End If
        If PlayerWithToken = "Player 2" Then
            PicPlayerTwo.Image = My.Resources.Hangman_Token
        End If
        If TokenTime = 0 And PlayerToken = True Then
            PlayerToken = False 'Sets PlayerToken to False
            PlayerWithToken = "No One"
            PicPlayerOne.Image = Nothing
            PicPlayerTwo.Image = Nothing
            GameStart()  'Calls the GameStart subroutine
            TokenTime = 1
            TokenTimer.Stop() 'Stops TokenTimer
        End If
        If SoundTime = 0 Then 'Checks if SoundTime is 0
            PlayerWithToken = "No One"
            PicPlayerOne.Image = Nothing
            PicPlayerTwo.Image = Nothing
            GameStart() 'Calls the GameStart subroutine
            SoundTime = 2
            TokenTimer.Stop() 'Stops TokenTimer
        End If
    End Sub
    Private Sub WinnerSoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinnerSoundTimer.Tick
        If Winner = False Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            ButtonEnableTimer.Start() 'Starts ButtonEnableTimer
            WinnerSoundTimer.Stop() 'Stops WinnerSoundTimer
            Winner = False 'Sets Winner to False
        Else
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_setback
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            WinnerSoundTimer.Stop() 'Stops WinnerSoundTimer
            Winner = False 'Sets Winner to False
        End If
        If BothLose = True Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_rejected
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            BothLose = False 'Sets BothLose to False
            WinnerSoundTimer.Stop() 'Stops WinnerSoundTimer
        End If
    End Sub
    Private Sub ButtonEnableTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnableTimer.Tick
        btnStart.Enabled = True
        btnReturn.Enabled = True
        btnInfo.Enabled = True
        btnClose.Enabled = True
        btnMinimize.Enabled = True
    End Sub

    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then 'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()  'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblLeaveGame.Visible = False 'Hides the "lblLeaveGame" label
                lblInfo.Visible = False 'Hides the "lblInfo" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblLeaveGame.Visible = True 'Shows the "lblLeaveGame" label
            lblInfo.Visible = True 'Shows the "lblInfo" label
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub
End Class
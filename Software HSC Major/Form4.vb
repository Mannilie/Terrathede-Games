Public Class frmHangmanTwoPlayer 'frmHangmanTwoPlayer form code
    Dim Alphabet As String
    Dim Word As String = ""
    Dim WordEntered As String
    Dim CurrentLetter As String
    Dim Toggle As Boolean = False
    Dim ExitFlag As Boolean = True
    Dim BeepSound As Boolean = False
    Dim PlayerFlash As Boolean = False
    Dim DisplayToken As Boolean = False
    Dim PlayerOneTokenNo As Integer = 0
    Dim PlayerTwoTokenNo As Integer = 0
    Dim CountDownCounter As Integer = 6
    Dim PlayerOneGuesses As Integer = 10
    Dim PlayerTwoGuesses As Integer = 10
    Dim SwitchedPlayer As Boolean = False
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
    Public Function PlayerOne_GetImage(ByVal bounds As Size) As Image 'PlayerOne_GetImage function code
        'Draw each piece of the man,
        'as applicable
        Dim img As New Bitmap(bounds.Width, bounds.Height)
        If PlayerOneGuesses = 0 Then
            img = My.Resources.HangMan_CurrentPlayer_10
        End If
        If PlayerOneGuesses > 0 Then
            img = My.Resources.HangMan_CurrentPlayer_8
        End If
        If PlayerOneGuesses > 1 Then
            img = My.Resources.HangMan_CurrentPlayer_7
        End If
        If PlayerOneGuesses > 2 Then
            img = My.Resources.HangMan_CurrentPlayer_6
        End If
        If PlayerOneGuesses > 3 Then
            img = My.Resources.HangMan_CurrentPlayer_5
        End If
        If PlayerOneGuesses > 4 Then
            img = My.Resources.HangMan_CurrentPlayer_4
        End If

        'Release the Graphics object
        'Return the image
        Return img

    End Function
    Public Function PlayerTwo_GetImage(ByVal bounds As Size) As Image 'PlayerTwo_GetImage function code
        Dim img As New Bitmap(bounds.Width, bounds.Height)
        If PlayerTwoGuesses = 0 Then
            img = My.Resources.HangMan_CurrentPlayer_10
        End If
        If PlayerTwoGuesses > 0 Then
            img = My.Resources.HangMan_CurrentPlayer_8
        End If
        If PlayerTwoGuesses > 1 Then
            img = My.Resources.HangMan_CurrentPlayer_7
        End If
        If PlayerTwoGuesses > 2 Then
            img = My.Resources.HangMan_CurrentPlayer_6
        End If
        If PlayerTwoGuesses > 3 Then
            img = My.Resources.HangMan_CurrentPlayer_5
        End If
        If PlayerTwoGuesses > 4 Then
            img = My.Resources.HangMan_CurrentPlayer_4
        End If
        Return img
    End Function
    Function CurrentGuess(ByVal Letter As String) 'CurrentGuess function code
        Dim ReturnValid As Boolean = False
        Dim Index As Integer
        For i = 0 To Word.Length - 1
            If Word.Substring(i, 1) = Letter.ToUpper Then
                Index = i
                Index = Index + 1
                Mid(lblGuess.Text, Index, 1) = Letter
                ReturnValid = True
            End If
        Next i
        Return ReturnValid
    End Function
    Public Sub Guess() 'Guess subroutine code
        lblGuess.Focus() 'Focuses on the "lblGuess" label
        picGameStatus.BackgroundImage = Nothing
        If SwitchedPlayer = False Then
            If CurrentGuess(CurrentLetter) = False Then
                PlayerOneGuesses = PlayerOneGuesses - 1
                GetLives() 'Calls the GetLives subroutine
                picGameStatus.BackgroundImage = PlayerOne_GetImage(picGameStatus.Size)
                If PlayerOneGuesses = 1 Then
                    lblPlayerOneLives.Text = PlayerOneGuesses & " Life Remaining"
                Else
                    lblPlayerOneLives.Text = PlayerOneGuesses & " Lives Remaining"
                End If
            Else
                picGameStatus.BackgroundImage = PlayerOne_GetImage(picGameStatus.Size)
            End If
            If Word.ToUpper = lblGuess.Text.ToUpper Then
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                    frmMainMenu.player.Play() 'Plays the sound file
                End If
                lblGuess.ForeColor = Color.Lime
                lblGuess.Text = Word.ToUpper 'Converts all characters in the "lblGuess" label to UPPERCASE
                DisplayTimer.Start()
            End If
            If PlayerOneGuesses < 1 Then
                lblGuess.ForeColor = Color.Maroon 'Sets the "lblGuess" label's forecolor to Maroon
                lblGuess.Text = Word.ToUpper 'Converts all characters in the "lblGuess" label to UPPERCASE
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    frmMainMenu.player.Stream = My.Resources.sound_rejected
                    frmMainMenu.player.Play() 'Plays the sound file
                End If
                DisplayTimer.Start()
            End If
        Else
            If CurrentGuess(CurrentLetter) = False Then
                PlayerTwoGuesses = PlayerTwoGuesses - 1
                GetLives() 'Calls the GetLives subroutine
                picGameStatus.BackgroundImage = PlayerTwo_GetImage(picGameStatus.Size)
                If PlayerTwoGuesses = 1 Then
                    lblPlayerTwoLives.Text = PlayerTwoGuesses & " Life Remaining"
                Else
                    lblPlayerTwoLives.Text = PlayerTwoGuesses & " Lives Remaining"
                End If
            Else
                picGameStatus.BackgroundImage = PlayerTwo_GetImage(picGameStatus.Size)
            End If
            If Word.ToUpper = lblGuess.Text.ToUpper Then
                lblGuess.ForeColor = Color.Lime
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    frmMainMenu.player.Stream = My.Resources.sound_FormSelect
                    frmMainMenu.player.Play() 'Plays the sound file
                    CheckWinner() 'Calls the CheckWinner subroutine
                    Exit Sub
                End If
            End If
            If PlayerTwoGuesses < PlayerOneGuesses Then
                lblGuess.ForeColor = Color.Maroon 'Sets the "lblGuess" label's forecolor to Maroon
                lblGuess.Text = Word.ToUpper 'Converts all characters in the "lblGuess" label to UPPERCASE
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    frmMainMenu.player.Stream = My.Resources.sound_rejected
                    frmMainMenu.player.Play() 'Plays the sound file
                End If
                CheckWinner() 'Calls the CheckWinner subroutine
                Exit Sub
            End If
            If PlayerTwoGuesses < 1 Then
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    frmMainMenu.player.Stream = My.Resources.sound_rejected
                    frmMainMenu.player.Play() 'Plays the sound file
                End If
                CheckWinner() 'Calls the CheckWinner subroutine
            End If
        End If
    End Sub

    Public Sub CheckWinner() 'CheckWinner subroutine code
        If PlayerOneTokenNo = 5 Then
            GetTokens()
            picGameStatus.Image = My.Resources.HangMan_GameOver
            PicPlayerOneStatus.Image = My.Resources.Hangman_Player_One_Winner
            PicPlayerTwoStatus.Image = My.Resources.Hangman_Player_Two_Loser
            PlayerOneTokenNo = 0
            NewGame()
            Exit Sub
        End If
        If PlayerTwoTokenNo = 5 Then
            GetTokens()
            picGameStatus.Image = My.Resources.HangMan_GameOver
            PicPlayerOneStatus.Image = My.Resources.Hangman_Player_One_loser
            PicPlayerTwoStatus.Image = My.Resources.Hangman_Player_Two_Winner
            PlayerTwoTokenNo = 0
            NewGame()
            Exit Sub
        End If
        If PlayerOneGuesses = PlayerTwoGuesses Then
            picGameStatus.Image = My.Resources.HangMan_Draw
            frmMainMenu.player.Stream = My.Resources.sound_rejected
            frmMainMenu.player.Play()
            WinnerTimer.Start()
            Exit Sub
        ElseIf PlayerOneGuesses > PlayerTwoGuesses Then
            PlayerOneTokenNo = PlayerOneTokenNo + 1
            DisplayToken = False
        ElseIf PlayerOneGuesses < PlayerTwoGuesses Then
            PlayerTwoTokenNo = PlayerTwoTokenNo + 1
            DisplayToken = True
        End If
        If DisplayToken = False Then
            DisableLetters() 'Calls the DisableLetters subroutine
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing
            frmMainMenu.player.Play()
            picPlayerOneToken.Visible = True
            GetTokens() 'Calls the GetTokens subroutine
            WinnerTimer.Start()
        Else
            DisableLetters() 'Calls the DisableLetters subroutine
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing
            frmMainMenu.player.Play()
            picPlayerTwoToken.Visible = True
            GetTokens() 'Calls the GetTokens subroutine
            WinnerTimer.Start()
        End If
    End Sub
    Public Sub SwitchPlayers() 'SwitchPlayers subroutine code
        StopTimers() 'Calls the StopTimers subroutine
        lblPlayerOneLives.ForeColor = Color.Black
        lblPlayerTwoLives.ForeColor = Color.Black
        If SwitchedPlayer = False Then
            SwitchedPlayer = True
        Else
            SwitchedPlayer = False
        End If
    End Sub
    Public Sub GetLives() 'GetLives subroutine code
        If SwitchedPlayer = False Then
            If PlayerOneGuesses < 1 Then
                Player1_Life1.BackgroundImage = My.Resources.No_Token
                LifeFlashTimer.Stop()
                lblPlayerOneLives.ForeColor = Color.Black
            End If
            If PlayerOneGuesses < 2 Then
                Player1_Life2.BackgroundImage = My.Resources.No_Token
                PlayerFlash = False
                LifeFlashTimer.Start()
            End If
            If PlayerOneGuesses < 3 Then
                Player1_Life3.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 4 Then
                Player1_Life4.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 5 Then
                Player1_Life5.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 6 Then
                Player1_Life6.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 7 Then
                Player1_Life7.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 8 Then
                Player1_Life8.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 9 Then
                Player1_Life9.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerOneGuesses < 10 Then
                Player1_Life10.BackgroundImage = My.Resources.No_Token
            End If
        Else
            If PlayerTwoGuesses < 1 Then
                Player2_Life1.BackgroundImage = My.Resources.No_Token
                lblPlayerTwoLives.ForeColor = Color.Black
            End If
            If PlayerTwoGuesses < 2 Then
                Player2_Life2.BackgroundImage = My.Resources.No_Token
                lblPlayerTwoLives.ForeColor = Color.Red
                PlayerFlash = True
                LifeFlashTimer.Start()
            End If
            If PlayerTwoGuesses < 3 Then
                Player2_Life3.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 4 Then
                Player2_Life4.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 5 Then
                Player2_Life5.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 6 Then
                Player2_Life6.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 7 Then
                Player2_Life7.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 8 Then
                Player2_Life8.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 9 Then
                Player2_Life9.BackgroundImage = My.Resources.No_Token
            End If
            If PlayerTwoGuesses < 10 Then
                Player2_Life10.BackgroundImage = My.Resources.No_Token
            End If
        End If
    End Sub
    Private Sub EnableLetters() 'EnableLetters subroutine code
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
    Public Sub ClearTokens() 'ClearTokens subroutine code
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
    Public Sub RestartLives() 'RestartLives subroutine code
        PlayerOneGuesses = 10
        PlayerTwoGuesses = 10
        Player1_Life1.BackgroundImage = My.Resources.LifeIcon
        Player1_Life2.BackgroundImage = My.Resources.LifeIcon
        Player1_Life3.BackgroundImage = My.Resources.LifeIcon
        Player1_Life4.BackgroundImage = My.Resources.LifeIcon
        Player1_Life5.BackgroundImage = My.Resources.LifeIcon
        Player1_Life6.BackgroundImage = My.Resources.LifeIcon
        Player1_Life7.BackgroundImage = My.Resources.LifeIcon
        Player1_Life8.BackgroundImage = My.Resources.LifeIcon
        Player1_Life9.BackgroundImage = My.Resources.LifeIcon
        Player1_Life10.BackgroundImage = My.Resources.LifeIcon
        Player2_Life1.BackgroundImage = My.Resources.LifeIcon
        Player2_Life2.BackgroundImage = My.Resources.LifeIcon
        Player2_Life3.BackgroundImage = My.Resources.LifeIcon
        Player2_Life4.BackgroundImage = My.Resources.LifeIcon
        Player2_Life5.BackgroundImage = My.Resources.LifeIcon
        Player2_Life6.BackgroundImage = My.Resources.LifeIcon
        Player2_Life7.BackgroundImage = My.Resources.LifeIcon
        Player2_Life8.BackgroundImage = My.Resources.LifeIcon
        Player2_Life9.BackgroundImage = My.Resources.LifeIcon
        Player2_Life10.BackgroundImage = My.Resources.LifeIcon
    End Sub
    Public Sub GetTokens() 'GetTokens subroutine code
        If DisplayToken = False Then
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
            lblPlayerOneTokens.Text = "Tokens: " & PlayerOneTokenNo
        Else
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
            lblPlayerTwoTokens.Text = "Tokens: " & PlayerTwoTokenNo
        End If
    End Sub
    Public Sub StopTimers() 'StopTimers subroutine code
        CountDownTimer.Stop() 'Stops CountDownTimer
        TokenTimer.Stop() 'Stops TokenTimer
        LifeFlashTimer.Stop() 'Stops LifeFlashTimer
    End Sub
    Public Sub Restart() 'Restart subroutine code
        picGameStatus.Image = Nothing
        StopTimers() 'Calls the StopTimers subroutine
        DisableLetters() 'Calls the DisableLetters subroutine
        btnStart.Visible = True
        lblGuess.Visible = False
        lblGuess.Text = "Game Starting..."
        'Changes the back color of all buttons
    End Sub
    Public Sub GameStart()
        Word = WordEntered
        BeepSound = False
        lblGuess.ForeColor = Color.Black
        EnableLetters() 'Calls the EnableLetters subroutine
        GetTokens() 'Calls the GetTokens subroutine
        picGameStatus.Image = Nothing
        picGameStatus.BackgroundImage = My.Resources.HangMan_CurrentPlayer_4
        For i = 0 To Word.Length - 1
            If Word(i) = " " Then
                lblGuess.Text &= " "
            Else
                lblGuess.Text &= "-"
            End If
        Next i
        CurrentLetter = ""
    End Sub
    Public Sub NewRound()
        RestartLives()  'Calls the RestartLives subroutine
        StopTimers()  'Calls the StopTimers subroutine
        DisableLetters()  'Calls the DisableLetters subroutine
        lblGuess.Visible = False 'Hides the label
        btnStart.Visible = True 'Shows the label
        lblPlayerOne.ForeColor = Color.Black
        lblPlayerTwo.ForeColor = Color.Black
        lblPlayerOneLives.Text = "10 Lives Remaining"
        lblPlayerTwoLives.Text = "10 Lives Remaining"
        PlayerOneGuesses = 10
        PlayerTwoGuesses = 10
        RestartLives()
        SwitchedPlayer = False
    End Sub
    Public Sub NewGame()
        StopTimers()
        DisableLetters()
        lblGuess.Visible = False
        btnStart.Visible = True
        lblGuess.Text = "Game Starting..."
        PlayerOneTokenNo = 0
        PlayerTwoTokenNo = 0
        lblPlayerOneTokens.Text = "Tokens: 0"
        lblPlayerTwoTokens.Text = "Tokens: 0"
        PlayerOneGuesses = 10
        PlayerTwoGuesses = 10
        lblPlayerOneLives.Text = "10 Lives Remaining"
        lblPlayerTwoLives.Text = "10 Lives Remaining"
        SwitchedPlayer = False
    End Sub

    Private Sub frmHangmanTwoPlayer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 13 And btnStart.Visible = True Then
            btnStart_MouseUp(Nothing, Nothing)
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
    'Buttons
    'Minimize
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Start
    Private Sub btnStart_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnStart.MouseDown 'btnStart Button MouseDown code
        btnStart.BackgroundImage = My.Resources.Start_Button_Pushed 'Changes the background image of the "btnStart" button when the mouse is down
    End Sub
    Private Sub btnStart_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseEnter 'btnStart Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnStart.BackgroundImage = My.Resources.Start_Button_Highlighted 'Changes the background image of the "btnStart" button to highlighted when the curser enters the button
    End Sub
    Private Sub btnStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseLeave 'btnStart Button MouseLeave code
        btnStart.BackgroundImage = My.Resources.Start_Button 'Changes the "btnStart" button's background image to the original image when the mouse is set to up
    End Sub
    Private Sub btnStart_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnStart.MouseUp 'btnStart Button MouseUp code
        btnStart.BackgroundImage = My.Resources.Start_Button 'Changes the "btnStart" button's background image to the original image when the mouse is set to up
        If SwitchedPlayer = False Then
            Dim InputBoxResult As String
            InputBoxResult = InputBox(lblPlayerTwo.Text & ", please enter a word for " & lblPlayerOne.Text & " to guess.", "Enter Word", "Enter Your Word Here")
            If InputBoxResult = "Enter Your Word Here" Or InputBoxResult = "" Then
                Exit Sub
            End If
            WordEntered = InputBoxResult.ToUpper
            Dim Valid As Boolean = True
            For a = 1 To 26
                If InputBoxResult.Contains(lstSymbol.Items(a)) Then
                    Valid = False
                End If
                If Valid = False Then
                    Exit For
                End If
            Next
            If Valid = False Then
                MsgBox("The word you entered is invalid. Words entered must contain alphabetical letters only. Please re-enter your word again.", vbExclamation + vbOKOnly, "Invalid Word")
                btnStart_MouseUp(sender, e)
                Exit Sub
            End If
            WordEntered = InputBoxResult.ToUpper
            picGameStatus.BackgroundImage = My.Resources.HangMan_Player
        Else
            Dim InputBoxResult As String
            InputBoxResult = InputBox(lblPlayerOne.Text & ", please enter a word for " & lblPlayerTwo.Text & " to guess.", "Enter Word", "Enter Your Word Here")
            If InputBoxResult = "Enter Your Word Here" Or InputBoxResult = "" Then
                Exit Sub
            End If
            WordEntered = InputBoxResult.ToUpper
            Dim Valid As Boolean = True
            For a = 1 To 26
                If InputBoxResult.Contains(lstSymbol.Items(a)) Then
                    Valid = False
                End If
                If Valid = False Then
                    Exit For
                End If
            Next
            If Valid = False Then
                MsgBox("The word you entered is invalid. Words entered must contain alphabetical letters only. Please re-enter your word again.", vbExclamation + vbOKOnly, "Invalid Word")
                btnStart_MouseUp(sender, e)
                Exit Sub
            End If
            WordEntered = InputBoxResult.ToUpper
            picGameStatus.BackgroundImage = My.Resources.HangMan_Player
        End If
        CountDownTimer.Start()
        picGameStatus.Image = My.Resources.Hangman_Five
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnStart.Visible = False
        lblGuess.Visible = True
        ExitFlag = False
        Word = WordEntered
    End Sub
    'Close
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If BeepSound = False Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
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
    'Info
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        If BeepSound = False Then
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        lblInfo.Visible = True
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave
        lblInfo.Visible = False
        btnInfo.BackgroundImage = My.Resources.Info_Button
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp 'btnInfo Button MouseUp code
        btnInfo.BackgroundImage = My.Resources.Info_Button
        If My.Settings.Mute = False Then
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Dim ProcessDirectory As String = AppPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    'Return
    Private Sub btnReturn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseDown 'btnReturn Button MouseDown code
        btnReturn.BackgroundImage = My.Resources.Return_Button_Pushed
    End Sub
    Private Sub btnReturn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseEnter 'btnReturn Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        lblLeaveGame.Visible = True
        btnReturn.BackgroundImage = My.Resources.Return_Button_Highlighted
    End Sub
    Private Sub btnReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseLeave 'btnReturn Button MouseLeave code
        lblLeaveGame.Visible = False
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnReturn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseUp 'btnReturn Button MouseUp code
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
        If ExitFlag = True Then 'Checks if ExitFlag is set to True
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
            Exit Sub
        End If
        Dim MessageBoxResult As String
        MessageBoxResult = MsgBox("Are you sure you wish to exit the game?", vbYesNo, "Exit Game") 'Prompts the user if they wish to exit game
        If MessageBoxResult = vbYes Then
            lblPlayerOneLives.Text = "10 Lives Remaining" 'Displays "10 Lives Remaining" in lblPlayerOneLives label
            lblPlayerOneLives.Text = "10 Lives Remaining" 'Displays "10 Lives Remaining" in lblPlayerOneLives label
            PlayerOneGuesses = 10 'Sets PlayerOneGuesses to 10
            PlayerTwoGuesses = 10 'Sets PlayerTwoGuesses to 10
            CountDownCounter = 6 'Sets CountDownCounter to 10
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
            ExitFlag = True 'Sets ExitFlag to True
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
    'Alphabet Sounds
    Private Sub btnA_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnZ.MouseUp, btnY.MouseUp, btnX.MouseUp, btnW.MouseUp, btnV.MouseUp, btnU.MouseUp, btnT.MouseUp, btnS.MouseUp, btnR.MouseUp, btnQ.MouseUp, btnP.MouseUp, btnO.MouseUp, btnN.MouseUp, btnM.MouseUp, btnL.MouseUp, btnK.MouseUp, btnJ.MouseUp, btnI.MouseUp, btnH.MouseUp, btnG.MouseUp, btnF.MouseUp, btnE.MouseUp, btnD.MouseUp, btnC.MouseUp, btnB.MouseUp, btnA.MouseUp
        If BeepSound = False Then 'Checks if "BeepSound" variable is set to false
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_select2
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
    End Sub
    Private Sub LifeFlashTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LifeFlashTimer.Tick 'LifeFlashTimer Timer tick code
        If PlayerFlash = False Then
            If lblPlayerOneLives.ForeColor = Color.Black Then
                lblPlayerOneLives.ForeColor = Color.Red
            Else
                lblPlayerOneLives.ForeColor = Color.Black
            End If
        Else
            If lblPlayerTwoLives.ForeColor = Color.Black Then
                lblPlayerTwoLives.ForeColor = Color.Red
            Else
                lblPlayerTwoLives.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub CountDownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountDownTimer.Tick 'CountDownTimer Timer tick code
        CountDownCounter = CountDownCounter - 1
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        If CountDownCounter = 5 Then 'Checks if the CountDownCounter is set to 5
            picGameStatus.Image = My.Resources.Hangman_Four
        End If
        If CountDownCounter = 4 Then 'Checks if the CountDownCounter is set to 4
            picGameStatus.Image = My.Resources.Hangman_Three
        End If
        If CountDownCounter = 3 Then 'Checks if the CountDownCounter is set to 3
            picGameStatus.Image = My.Resources.Hangman_Two
        End If
        If CountDownCounter = 2 Then 'Checks if the CountDownCounter is set to 2
            picGameStatus.Image = My.Resources.Hangman_One
        End If
        If CountDownCounter = 1 Then 'Checks if the CountDownCounter is set to 1
            EnableLetters()  'Calls the EnableLetters subroutine
            picGameStatus.Image = Nothing 'Clears picturebox
            lblGuess.Text = "" 'Clears lblGuess label 
            GameStart()  'Calls the GameStart subroutine
            CountDownTimer.Stop() 'Stops CountDownTimer
            CountDownCounter = 6 'Sets CountDownCounter to 6
        End If
    End Sub
    Private Sub frmHangmanTwoPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmHangmanTwoPlayer form load code
        If My.Settings.DisableCaptions = False Then
            MouseMoveTimer.Start() 'Starts the MouseMoveTimer
        End If
        DisableLetters() 'Calls the DisableLetters subroutine
    End Sub
    Private Sub DisplayTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayTimer.Tick 'DisplayTimer Timer tick code
        GetLives() 'Calls the DisableLetters subroutine
        SwitchPlayers() 'Calls the SwitchPlayers subroutine
        Restart() 'Calls the Restart subroutine
        lblGuess.ForeColor = Color.Black
        picPlayerOneToken.Visible = False
        picPlayerTwoToken.Visible = False
        picGameStatus.Image = Nothing
        DisplayTimer.Stop() 'Stops the "DisplayTimer" timer tick event
    End Sub

    Private Sub WinnerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinnerTimer.Tick 'WinnerTimer Timer tick code
        Restart()
        NewRound()
        lblGuess.ForeColor = Color.Black
        picPlayerOneToken.Visible = False
        picPlayerTwoToken.Visible = False
        picGameStatus.Image = Nothing
        WinnerTimer.Stop() 'Stops the "DisplayTimer" timer tick event
    End Sub
    Dim CaptionCounter As Integer
    Dim CurrentMousePosition As String
    Dim OpacityCounter As Integer
    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then 'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()  'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblLeaveGame.Visible = False 'Hides the "lblLeaveGame" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()  'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblInfo.Visible = True 'Shows the "lblInfo" label
            lblLeaveGame.Visible = True 'Shows the "lblLeaveGame" label
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub
End Class


Public Class frmHangmanSinglePlayer 'frmHangmanSinglePlayer form code
    Dim word As String = ""
    Dim Reader As IO.StreamReader
    Dim EndOfList As Integer
    Dim CurrentLetter As String
    Dim OpacityCounter As Integer
    Dim CaptionCounter As Integer
    Dim Correct As Boolean = False
    Dim ExitFlag As Boolean = True
    Dim CorrectWords As Integer = 0
    Dim InCorrectWords As Integer = 0
    Dim CurrentMousePosition As String
    Dim CountDownCounter As Integer = 6
    Dim PlayerOneChances As Integer = 12
    Dim appPath As String = Application.StartupPath()
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

    Function GuessedLetter(ByVal letter As String)
        Dim ReturnLetter As Boolean = False
        Dim WordIndex As Integer
        For SubstringIndex = 0 To word.Length - 1
            If word.Substring(SubstringIndex, 1) = letter.ToLower Then
                WordIndex = SubstringIndex
                WordIndex = WordIndex + 1
                Mid(lblGuess.Text, WordIndex, 1) = letter
                ReturnLetter = True
            End If
        Next SubstringIndex
        Return ReturnLetter
    End Function

    Public Function PlayerOne_GetImage(ByVal bounds As Size) As Image
        'Draw each piece of the man,
        'as applicable
        Dim img As New Bitmap(bounds.Width, bounds.Height)
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
        'Release the Graphics object
        'Return the image
        Return img

    End Function
    Public Sub Guess()
        Try
            lblGuess.Focus()
            PicPlayerOne.BackgroundImage = Nothing
            If GuessedLetter(CurrentLetter) = False Then
                PlayerOneChances = PlayerOneChances - 1
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size)
            Else
                PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size)
            End If
            If word.ToUpper = lblGuess.Text.ToUpper Then
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    lblGuess.ForeColor = Color.Lime 'Sets the "lblGuess" label's forecolor to Lime
                    lblGuess.Text = word.ToUpper 'Converts all characters in the "lblGuess" label to UPPERCASE
                    WinnerSoundTimer.Start() 'Starts the "WinnerSoundTimer" timer's tick event
                End If
                PicPlayerOne.Image = My.Resources.HangMan_Correct
                DisableLetters()
                lstCorrect.Items.Add(word.ToUpper)
                CorrectWords = CorrectWords + 1
                bxCorrectWords.Text = "Correct Words: " & CorrectWords
                GameTimer.Start()
            End If
            If PlayerOneChances <= 1 Then
                If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                    lblGuess.ForeColor = Color.Maroon 'Sets the "lblGuess" label's forecolor to Maroon
                    lblGuess.Text = word.ToUpper 'Converts all characters in the "lblGuess" label to UPPERCASE
                    picWrongArrow.Visible = True 'Shows the "picWrongArrow" picture box
                    LoserSoundTimer.Start() 'Starts the "LoserSoundTimer" timer's tick event
                End If
                PicPlayerOne.Image = My.Resources.HangMan_Wrong
                PicPlayerOne.BackgroundImage = My.Resources.HangMan_CurrentPlayer_10
                DisableLetters()
                lstIncorrect.Items.Add(word.ToUpper)
                InCorrectWords = InCorrectWords + 1
                bxIncorrectWords.Text = "InCorrect Words: " & InCorrectWords
                GameTimer.Start()
            End If
        Catch ex As Exception
            MsgBox("Error: Please report this to Emmanuel Vaccaro")
        End Try
    End Sub
    Private Sub EnableLetters() 'EnableLetters Private Sub code
        'Changes all of the button's backcolor to Silver
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
    Private Sub DisableLetters()
        'Changes all of the button's backcolor to DimGray
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
    Public Sub GameStart()
        ExitFlag = False
        Dim rand As New Random
        picWrongArrow.Visible = False
        lblGuess.ForeColor = Color.Black
        EnableLetters()
        EndOfList = lstWords.Items.Count
        PicPlayerOne.Image = Nothing
        PicPlayerOne.BackgroundImage = My.Resources.HangMan_CurrentPlayer
        lblGuess.Text = ""
        word = lstWords.Items.Item(rand.Next(0, EndOfList))
        word = word.ToLower
        For i = 0 To word.Length - 1
            If word(i) = " " Then
                lblGuess.Text &= " "
            Else
                lblGuess.Text &= "-"
            End If
        Next i
        PlayerOneChances = 12
        PicPlayerOne.BackgroundImage = PlayerOne_GetImage(PicPlayerOne.Size)
        CurrentLetter = ""
    End Sub
    Private Sub frmHangmanSinglePlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DisableCaptions = False Then
            MouseMoveTimer.Start()
        End If
        DisableLetters()
        If My.Settings.HangmanDefaultGameList = False Then
            Dim rand As New Random
            Reader = New IO.StreamReader(appPath & "\CustomWordList.txt")
            While (Reader.Peek() > -1)
                lstWords.Items.Add(Reader.ReadLine)
            End While
            Reader.Close()
        Else
            Dim rand As New Random
            Reader = New IO.StreamReader(appPath & "\DefaultWordList.txt")
            While (Reader.Peek() > -1)
                lstWords.Items.Add(Reader.ReadLine)
            End While
            Reader.Close()
        End If
        EndOfList = lstWords.Items.Count 'Changes the "EndOfList" integer to the ammount of words in the "lstWords" listbox
    End Sub
    Private Sub frmHangmanSinglePlayer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
        Me.WindowState = FormWindowState.Minimized 'Minimizes the form
    End Sub
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
        PicPlayerOne.BackgroundImage = My.Resources.HangMan_Player
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnStart.Visible = False
        lblGuess.Visible = True
        GameStart()
    End Sub
    'Close
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
    'Info
    Private Sub btnInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseDown 'btnInfo Button MouseDown code
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        lblInfo.Visible = True
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
        Dim ProcessDirectory As String = appPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    'Return
    Private Sub btnReturn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseDown 'btnReturn Button MouseDown code
        btnReturn.BackgroundImage = My.Resources.Return_Button_Pushed 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseEnter 'btnReturn Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        lblLeaveGame.Visible = True 'Shows the label
        btnReturn.BackgroundImage = My.Resources.Return_Button_Highlighted 'Changes the "btnReturn" picturebox's background to another image in resources
    End Sub
    Private Sub btnReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.MouseLeave 'btnReturn Button MouseLeave code
        lblLeaveGame.Visible = False 'Hides the label
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnReturn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReturn.MouseUp 'btnReturn Button MouseUp code
        btnReturn.BackgroundImage = My.Resources.Return_Button 'Changes the "btnReturn" button's background image to the original image when the curser has left the picture box
        If ExitFlag = True Then 'Checks if "ExitFlag" is set to True
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
            Exit Sub 'Exits the subroutine
        End If
        Dim MessageBoxResult As String 'Declares "MessageBoxResult" as a string
        MessageBoxResult = MsgBox("Are you sure you wish to exit the game?", vbYesNo, "Exit Game") 'Prompts the user if they wish to exit the game
        If MessageBoxResult = vbYes Then 'Checks if the messagebox selection returns "vbYes"
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            ExitFlag = True 'Sets the boolean variable "ExitFlag" to True
            frmHangmanModeMenu.Location = New Point(Me.Location.X, Me.Location.Y) 'Sets the "frmHangmanModeMenu" form's location to the current form's location
            frmHangmanModeMenu.Show() 'Shows the "frmHangmanModeMenu" form
            Me.Dispose() 'Closes the current form
        End If
    End Sub
    'Alphabet Buttons
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
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_select2 'Sets the soundplayer to the "sound_select2" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub CountDownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountDownTimer.Tick
        CountDownCounter = CountDownCounter - 1 'Counts down the variable "CountDownCounter"
        If CountDownCounter = 5 Then 'Checks if the variable "CountDownCounter" is equal to 5
            PicPlayerOne.Image = My.Resources.Hangman_Four
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "sound_FormSelect" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 4 Then 'Checks if the variable "CountDownCounter" is equal to 4
            PicPlayerOne.Image = My.Resources.Hangman_Three
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "sound_FormSelect" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 3 Then 'Checks if the variable "CountDownCounter" is equal to 3
            PicPlayerOne.Image = My.Resources.Hangman_Two
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "sound_FormSelect" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 2 Then 'Checks if the variable "CountDownCounter" is equal to 2
            PicPlayerOne.Image = My.Resources.Hangman_One
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "sound_FormSelect" WAV file in the resources
                frmMainMenu.player.Play() 'Plays the sound file
            End If
        End If
        If CountDownCounter = 1 Then 'Checks if the variable "CountDownCounter" is equal to 1
            PicPlayerOne.Image = Nothing
            GameStart() 'Calls the "GameStart" subroutine
            CountDownTimer.Stop() 'Stops the "CountDownTimer" timer
            CountDownCounter = 6 'CountDownCounter is set to 6
        End If
    End Sub
    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick 'GameTimer Timer Tick code
        PicPlayerOne.Image = Nothing
        GameStart() 'Calls the "GameStart" subroutine
        GameTimer.Stop() 'Stops the "GameTimer" timer
    End Sub
    Private Sub WinnerSoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinnerSoundTimer.Tick 'WinnerSoundTimer Timer Tick code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "sound_FormSelect" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        WinnerSoundTimer.Stop() 'Stops the "WinnerSoundTimer" timer's event
    End Sub
    Private Sub LoserSoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoserSoundTimer.Tick 'LoserSoundTimer Timer Tick code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_rejected 'Sets the soundplayer to the "sound_rejected" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        LoserSoundTimer.Stop() 'Stops the "LoserSoundTimer" timer's event
    End Sub
    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick 'MouseMoveTimer Timer Tick code
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then 'Checks if the mouse's location on the screen is the same as it was before using the string variable "CurrentMousePosition
            CaptionTimer.Start() 'Starts "CaptionTimer" timer
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        Else
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            If CaptionCounter > 3 Then 'Checks if the "CaptionCounter" integer value is greater than 3
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblLeaveGame.Visible = False 'Hides the "lblLeaveGame" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop()  'Stops the "CaptionTimer" timer
            lblInfo.Visible = True 'Shows the "lblInfo" label
            lblLeaveGame.Visible = True 'Shows the "lblLeaveGame" label
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1 'Increments "CaptionCounter" integer variable
    End Sub

End Class
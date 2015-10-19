Public Class frmTicTacToeSinglePlayer 'frmTicTacToeSinglePlayer form code
    Dim TopLeft As String
    Dim TopRight As String
    Dim TopCenter As String
    Dim MiddleLeft As String
    Dim BottomLeft As String
    Dim MiddleRight As String
    Dim BottomRight As String
    Dim list As New ArrayList
    Dim MiddleCenter As String
    Dim BottomCenter As String
    Dim WinningPlayer As String
    Dim Draw As Boolean = False
    Dim Chosen As Boolean = False
    Dim Winner As Boolean = False
    Dim ExitFlag As Boolean = True
    Dim PlayerOne As Boolean = True
    Dim Countdowntimer As Integer = 9
    Dim PlayerOneTokenNo As Integer = 0
    Dim WonRound As Boolean = False 'Checks if a player has won the game or not
    Dim PlayerTwoWinner As Boolean = False
    Dim PlayerOneWinner As Boolean = False
    Dim ComputerPlayerTokenNo As Integer = 0
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
    Private Sub ComputerPlayer() 'ComputerPlayer Subroutine code
        While Chosen = False 'Executes a set of commands while the boolean variable "Chosen" is equal to false
            Dim RandomNumber As New Random 'Declares "RandomNumber" as a new random value generator
            Dim Index As Integer 'Declares "Index" as an integer variable
            Dim ChosenNumber As Integer 'Declares "ChosenNumber" as an integer variable
            If list.Count <= 0 Then 'Checks if there are no words in the "list" list box
                Exit Sub 'Exits the subroutine
            End If
            Index = RandomNumber.Next(0, list.Count - 1) 'Assigns the next "RandomNumber" of the available list items to the "Index" variable
            ChosenNumber = list(Index) 'Gets the chosen number from the "list" list box "index"
            list.RemoveAt(Index) 'Removes the "ChosenNumber" index from the "list" list box
            If ChosenNumber = 1 Then 'Checks if "ChosenNumber" is 1
                Call btnTopLeft_MouseUp(Nothing, Nothing) 'Calls the "btnTopLeft" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 2 Then 'Checks if "ChosenNumber" is 2
                Call btnTopCenter_MouseUp(Nothing, Nothing) 'Calls the "btnTopCenter" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 3 Then 'Checks if "ChosenNumber" is 3
                Call btnTopRight_MouseUp(Nothing, Nothing) 'Calls the "btnTopRight" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 4 Then 'Checks if "ChosenNumber" is 4
                Call btnMiddleLeft_MouseUp(Nothing, Nothing) 'Calls the "btnMiddleLeft" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 5 Then 'Checks if "ChosenNumber" is 5
                Call btnMiddleCenter_MouseUp(Nothing, Nothing) 'Calls the "btnMiddleCenter" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 6 Then 'Checks if "ChosenNumber" is 6
                Call btnMiddleRight_MouseUp(Nothing, Nothing) 'Calls the "btnMiddleRight" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 7 Then 'Checks if "ChosenNumber" is 7
                Call btnBottomLeft_MouseUp(Nothing, Nothing) 'Calls the "btnBottomLeft" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 8 Then 'Checks if "ChosenNumber" is 8
                Call btnBottomCenter_MouseUp(Nothing, Nothing) 'Calls the "btnBottomCenter" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            ElseIf ChosenNumber = 9 Then 'Checks if "ChosenNumber" is 9
                Call btnBottomRight_MouseUp(Nothing, Nothing) 'Calls the "btnBottomRight" MouseUp event
                Chosen = True 'Sets the boolean variable "Chosen" to True
            End If
        End While
        PlayerOne = True 'Sets the boolean variable "PlayerOne" to True
        Chosen = False 'Sets the boolean variable "Chosen" to False
    End Sub
    Private Sub TokenSoundStream() 'TokenSoundStream Subroutine code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub CheckPlayerOneTurn() 'CheckPlayerOneTurn Subroutine code
        ExitFlag = False 'Sets the boolean variable "ExitFlag" to False
        WonRound = False 'Sets the boolean variable "WonRound" to False
        Draw = False 'Sets the boolean variable "Draw" to False
        If TopLeft = "X" And MiddleCenter = "X" And BottomRight = "X" Then 'Checks if the "TopLeft","MiddleCenter" and "BottomRight" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopLeft = "X" And TopCenter = "X" And TopRight = "X" Then 'Checks if the "TopLeft","TopCenter" and "TopRight" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf MiddleLeft = "X" And MiddleCenter = "X" And MiddleRight = "X" Then 'Checks if the "MiddleLeft","MiddleCenter" and "MiddleRight" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf BottomLeft = "X" And BottomCenter = "X" And BottomRight = "X" Then 'Checks if the "BottomLeft","BottomCenter" and "BottomRight" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopLeft = "X" And MiddleLeft = "X" And BottomLeft = "X" Then 'Checks if the "TopLeft","MiddleLeft" and "BottomLeft" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopCenter = "X" And MiddleCenter = "X" And BottomCenter = "X" Then 'Checks if the "TopCenter","MiddleCenter" and "BottomCenter" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopRight = "X" And MiddleRight = "X" And BottomRight = "X" Then 'Checks if the "TopRight","MiddleRight" and "BottomRight" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopRight = "X" And MiddleCenter = "X" And BottomLeft = "X" Then 'Checks if the "TopRight","MiddleCenter" and "BottomLeft" strings are "X"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        End If
        If WonRound = True Then 'Checks if the boolean variable "WonRound" is set to True
            PlayerOneTokenNo = PlayerOneTokenNo + 1 'Increments the "PlayerOneTokenNo" integer variable
            TokenSoundStream() 'Calls the "TokenSoundStream" subroutine
            DisplayPlayerOneWinner() 'Calls the "DisplayPlayerOneWinner" subroutine
            GetTokens() 'Calls the "GetTokens" subroutine
            CheckDraw() 'Calls the "CheckDraw" subroutine
            If Draw = True Then 'Checks if the boolean variable "Draw" is set to true
                Draw = False 'Sets the boolean variable "Draw" to False
            End If
        Else
            PlayerOne = False 'Sets the boolean variable "PlayerOne" to False
            Chosen = False 'Sets the boolean variable "Chosen" to False
            CheckDraw() 'Calls the "CheckDraw" subroutine
            ComputerPlayer() 'Calls the "ComputerPlayer" subroutine
        End If
    End Sub
    Private Sub CheckComputerPlayerTurn() 'CheckComputerPlayerTurn Subroutine code
        ExitFlag = False 'Sets the boolean variable "ExitFlag" to False
        WonRound = False 'Sets the boolean variable "WonRound" to False
        Draw = False 'Sets the boolean variable "Draw" to False
        If TopLeft = "O" And MiddleCenter = "O" And BottomRight = "O" Then 'Checks if the "TopLeft","MiddleCenter" and "BottomRight" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopLeft = "O" And TopCenter = "O" And TopRight = "O" Then 'Checks if the "TopLeft","TopCenter" and "TopRight" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf MiddleLeft = "O" And MiddleCenter = "O" And MiddleRight = "O" Then 'Checks if the "MiddleLeft","MiddleCenter" and "MiddleRight" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf BottomLeft = "O" And BottomCenter = "O" And BottomRight = "O" Then 'Checks if the "BottomLeft","BottomCenter" and "BottomRight" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopLeft = "O" And MiddleLeft = "O" And BottomLeft = "O" Then 'Checks if the "TopLeft","MiddleLeft" and "BottomLeft" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopCenter = "O" And MiddleCenter = "O" And BottomCenter = "O" Then 'Checks if the "TopCenter","MiddleCenter" and "BottomCenter" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopRight = "O" And MiddleRight = "O" And BottomRight = "O" Then 'Checks if the "TopRight","MiddleRight" and "BottomRight" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        ElseIf TopRight = "O" And MiddleCenter = "O" And BottomLeft = "O" Then 'Checks if the "TopRight","MiddleCenter" and "BottomLeft" strings are "O"
            WonRound = True 'Sets the boolean variable "WonRound" to True
        End If
        If WonRound = True Then 'Checks if the boolean variable "WonRound" to True
            ComputerPlayerTokenNo = ComputerPlayerTokenNo + 1 'Increments the "ComputerPlayerTokenNo" integer variable
            TokenSoundStream() 'Calls the "TokenSoundStream" subroutine
            DisplayPlayerTwoWinner() 'Calls the "DisplayPlayerTwoWinner" subroutine
            GetTokens() 'Calls the "GetTokens" subroutine
        End If
        PlayerOne = True 'Sets the boolean variable "PlayerOne" to True
        Chosen = False 'Sets the boolean variable "Chosen" to False
        CheckDraw() 'Calls the "CheckDraw" subroutine
    End Sub
    Private Sub DisplayPlayerOneWinner() 'DisplayPlayerOneWinner Subroutine code
        DisableButtons() 'Calls the "DisableButtons" subroutine
        picPlayerOneToken.Visible = True 'Shows the "picPlayerOneToken" picture box
        DisplayTimer.Start() 'Starts the "DisplayTimer" timer tick event
    End Sub
    Private Sub DisplayPlayerTwoWinner() 'DisplayPlayerTwoWinner Subroutine code
        DisableButtons() 'Calls the "DisableButtons" subroutine
        picComputerPlayerToken.Visible = True 'Shows the "picComputerPlayerToken" picture box
        DisplayTimer.Start() 'Starts the "DisplayTimer" timer tick event
    End Sub
    Private Sub DisableButtons() 'DisableButtons Subroutine code
        picTopLeft.Enabled = False 'Disables the "btnTopLeft" button
        picMiddleLeft.Enabled = False 'Disables the "btnMiddleLeft" button
        picBottomLeft.Enabled = False 'Disables the "btnBottomLeft" button
        picTopCenter.Enabled = False 'Disables the "btnTopCenter" button
        picMiddleCenter.Enabled = False 'Disables the "btnMiddleCenter" button
        picBottomCenter.Enabled = False 'Disables the "btnBottomCenter" button
        picTopRight.Enabled = False 'Disables the "btnTopRight" button
        picMiddleRight.Enabled = False 'Disables the "btnMiddleRight" button
        picBottomRight.Enabled = False 'Disables the "btnBottomRight" button
    End Sub
    Private Sub EnableButtons() 'EnableButtons Subroutine code
        picTopLeft.Enabled = True 'Enables the "btnTopLeft" button
        picMiddleLeft.Enabled = True 'Enables the "btnMiddleLeft" button
        picBottomLeft.Enabled = True 'Enables the "btnBottomLeft" button
        picTopCenter.Enabled = True 'Enables the "btnTopCenter" button
        picMiddleCenter.Enabled = True 'Enables the "btnMiddleCenter" button
        picBottomCenter.Enabled = True 'Enables the "btnBottomCenter" button
        picTopRight.Enabled = True 'Enables the "btnTopRight" button
        picMiddleRight.Enabled = True 'Enables the "btnMiddleRight" button
        picBottomRight.Enabled = True 'Enables the "btnBottomRight" button
    End Sub
    Private Sub RefreshGame() 'RefreshGame Subroutine code
        DisableButtons() 'Calls the "DisableButtons" subroutine
        WriteList() 'Calls the "WriteList" subroutine
        ClearBoard() 'Calls the "ClearBoard" subroutine
        ClearBoardStrings() 'Calls the "ClearBoardStrings" subroutine
        EnableButtons() 'Calls the "EnableButtons" subroutine
        ResetBooleans() 'Calls the "ResetBooleans" subroutine
    End Sub
    Private Sub RestartGame() 'RestartGame Subroutine code
        WriteList() 'Calls the "WriteList" subroutine
        ClearBoard() 'Calls the "ClearBoard" subroutine
        ClearBoardStrings() 'Calls the "ClearBoardStrings" subroutine
        ClearTokens() 'Calls the "ClearTokens" subroutine
        ResetBooleans() 'Calls the "ResetBooleans" subroutine
        EnableButtons() 'Calls the "EnableButtons" subroutine
        PlayerOneTokenNo = 0 'Sets the integer variable "PlayerOneTokenNo" to 0
        ComputerPlayerTokenNo = 0 'Sets the integer variable "ComputerPlayerTokenNo" to 0
        lblPlayerOneTokens.Text = "Tokens: 0"
        lblComputerPlayerTokens.Text = "Tokens: 0"
        picTicTacToeWinner.Visible = False 'Hides the "picTicTacToeWinner" picture box
    End Sub
    Private Sub ResetBooleans() 'ResetBooleans Subroutine code
        Chosen = False 'Sets the boolean variable "Chosen" to False
        PlayerOne = True 'Sets the boolean variable "PlayerOne" to True
        Draw = False 'Sets the boolean variable "Draw" to False
        PlayerTwoWinner = False 'Sets the boolean variable "PlayerTwoWinner" to False
        PlayerOneWinner = False 'Sets the boolean variable "PlayerOneWinner" to False
    End Sub
    Private Sub ClearBoardStrings() 'ClearBoardStrings Subroutine code
        TopLeft = "" 'Clears the value of the string variable "Topleft"
        MiddleLeft = "" 'Clears the value of the string variable "MiddleLeft"
        BottomLeft = "" 'Clears the value of the string variable "BottomLeft"
        TopCenter = "" 'Clears the value of the string variable "TopCenter"
        MiddleCenter = "" 'Clears the value of the string variable "MiddleCenter"
        BottomCenter = "" 'Clears the value of the string variable "BottomCenter"
        TopRight = "" 'Clears the value of the string variable "TopRight"
        MiddleRight = "" 'Clears the value of the string variable "MiddleRight"
        BottomRight = "" 'Clears the value of the string variable "BottomRight"
    End Sub
    Private Sub ClearBoard() 'ClearBoard Subroutine code
        picTopLeft.BackgroundImage = Nothing 'Sets the "picTopLeft" picture box's background image to Nothing
        picMiddleLeft.BackgroundImage = Nothing 'Sets the "picMiddleLeft" picture box's background image to Nothing
        picBottomLeft.BackgroundImage = Nothing 'Sets the "picBottomLeft" picture box's background image to Nothing
        picTopCenter.BackgroundImage = Nothing 'Sets the "picTopCenter" picture box's background image to Nothing
        picMiddleCenter.BackgroundImage = Nothing 'Sets the "picMiddleCenter" picture box's background image to Nothing
        picBottomCenter.BackgroundImage = Nothing 'Sets the "picBottomCenter" picture box's background image to Nothing
        picTopRight.BackgroundImage = Nothing 'Sets the "picTopRight" picture box's background image to Nothing
        picMiddleRight.BackgroundImage = Nothing 'Sets the "picMiddleRight" picture box's background image to Nothing
        picBottomRight.BackgroundImage = Nothing 'Sets the "picBottomRight" picture box's background image to Nothing
    End Sub
    Private Sub ClearTokens() 'ClearTokens Subroutine code
        picPlayer1_GoldToken1.BackgroundImage = My.Resources.No_Token 'Sets the "picPlayer1_GoldToken1" picture box's background image to the "No_Token" image in resources
        picPlayer1_GoldToken2.BackgroundImage = My.Resources.No_Token 'Sets the "picPlayer1_GoldToken2" picture box's background image to the "No_Token" image in resources
        picPlayer1_GoldToken3.BackgroundImage = My.Resources.No_Token 'Sets the "picPlayer1_GoldToken3" picture box's background image to the "No_Token" image in resources
        picPlayer1_GoldToken4.BackgroundImage = My.Resources.No_Token 'Sets the "picPlayer1_GoldToken4" picture box's background image to the "No_Token" image in resources
        picPlayer1_GoldToken5.BackgroundImage = My.Resources.No_Token 'Sets the "picPlayer1_GoldToken5" picture box's background image to the "No_Token" image in resources
        picComputerPlayer_GoldToken1.BackgroundImage = My.Resources.No_Token 'Sets the "picComputerPlayer_GoldToken1" picture box's background image to the "No_Token" image in resources
        picComputerPlayer_GoldToken2.BackgroundImage = My.Resources.No_Token 'Sets the "picComputerPlayer_GoldToken2" picture box's background image to the "No_Token" image in resources
        picComputerPlayer_GoldToken3.BackgroundImage = My.Resources.No_Token 'Sets the "picComputerPlayer_GoldToken3" picture box's background image to the "No_Token" image in resources
        picComputerPlayer_GoldToken4.BackgroundImage = My.Resources.No_Token 'Sets the "picComputerPlayer_GoldToken4" picture box's background image to the "No_Token" image in resources
        picComputerPlayer_GoldToken5.BackgroundImage = My.Resources.No_Token 'Sets the "picComputerPlayer_GoldToken5" picture box's background image to the "No_Token" image in resources
    End Sub
    Private Sub WriteList() 'WriteList Subroutine code
        list.Clear() 'Clears the "list" list box
        For i = 1 To 10 'Executes a set of commands 10 times (1-10)
            list.Add(i) 'Adds the numbers (1-10) to the "list" list box's collection
        Next i
    End Sub
    Private Sub GetTokens() 'GetTokens Subroutine code
        If PlayerOneTokenNo > 0 Then 'Checks if the integer variable "PlayerOneTokenNo" is greater than 0
            picPlayer1_GoldToken1.BackgroundImage = My.Resources.Gold_Token 'Sets the "picPlayer1_GoldToken1" picture box's background image to the "Gold_Token" image in resources
        End If
        If PlayerOneTokenNo > 1 Then 'Checks if the integer variable "PlayerOneTokenNo" is greater than 1
            picPlayer1_GoldToken2.BackgroundImage = My.Resources.Gold_Token 'Sets the "picPlayer1_GoldToken2" picture box's background image to the "Gold_Token" image in resources
        End If
        If PlayerOneTokenNo > 2 Then 'Checks if the integer variable "PlayerOneTokenNo" is greater than 2
            picPlayer1_GoldToken3.BackgroundImage = My.Resources.Gold_Token 'Sets the "picPlayer1_GoldToken3" picture box's background image to the "Gold_Token" image in resources
        End If
        If PlayerOneTokenNo > 3 Then 'Checks if the integer variable "PlayerOneTokenNo" is greater than 3
            picPlayer1_GoldToken4.BackgroundImage = My.Resources.Gold_Token 'Sets the "picPlayer1_GoldToken4" picture box's background image to the "Gold_Token" image in resources
        End If
        If PlayerOneTokenNo > 4 Then 'Checks if the integer variable "PlayerOneTokenNo" is greater than 4
            picPlayer1_GoldToken5.BackgroundImage = My.Resources.Gold_Token 'Sets the "picPlayer1_GoldToken5" picture box's background image to the "Gold_Token" image in resources
        End If
        lblPlayerOneTokens.Text = "Tokens: " & PlayerOneTokenNo
        If ComputerPlayerTokenNo > 0 Then 'Checks if the integer variable "ComputerPlayerTokenNo" is greater than 0
            picComputerPlayer_GoldToken1.BackgroundImage = My.Resources.Gold_Token 'Sets the "picComputerPlayer_GoldToken1" picture box's background image to the "Gold_Token" image in resources
        End If
        If ComputerPlayerTokenNo > 1 Then 'Checks if the integer variable "ComputerPlayerTokenNo" is greater than 1
            picComputerPlayer_GoldToken2.BackgroundImage = My.Resources.Gold_Token 'Sets the "picComputerPlayer_GoldToken2" picture box's background image to the "Gold_Token" image in resources
        End If
        If ComputerPlayerTokenNo > 2 Then 'Checks if the integer variable "ComputerPlayerTokenNo" is greater than 2
            picComputerPlayer_GoldToken3.BackgroundImage = My.Resources.Gold_Token 'Sets the "picComputerPlayer_GoldToken3" picture box's background image to the "Gold_Token" image in resources
        End If
        If ComputerPlayerTokenNo > 3 Then 'Checks if the integer variable "ComputerPlayerTokenNo" is greater than 3
            picComputerPlayer_GoldToken4.BackgroundImage = My.Resources.Gold_Token 'Sets the "picComputerPlayer_GoldToken4" picture box's background image to the "Gold_Token" image in resources
        End If
        If ComputerPlayerTokenNo > 4 Then 'Checks if the integer variable "ComputerPlayerTokenNo" is greater than 4
            picComputerPlayer_GoldToken5.BackgroundImage = My.Resources.Gold_Token 'Sets the "picComputerPlayer_GoldToken5" picture box's background image to the "Gold_Token" image in resources
        End If
        lblComputerPlayerTokens.Text = "Tokens: " & ComputerPlayerTokenNo
    End Sub
    Private Sub CheckDraw() 'CheckDraw Subroutine code
        If WonRound = False And picTopLeft.Enabled = False And picMiddleLeft.Enabled = False And picBottomLeft.Enabled = False And picTopCenter.Enabled = False And picMiddleCenter.Enabled = False And picBottomCenter.Enabled = False And picTopRight.Enabled = False And picMiddleRight.Enabled = False And picBottomRight.Enabled = False Then 'Checks if all the pictureboxes are disabled
            Draw = True 'Sets the boolean variable "Draw" to True
        End If
        CheckWinner() 'Calls the "CheckWinner" subroutine
    End Sub
    Private Sub CheckWinner() 'CheckWinner Subroutine code
        If PlayerOneTokenNo = 5 Then
            GetTokens() 'Calls the "GetTokens" subroutine
            PlayerOneTokenNo = 0
            ComputerPlayerTokenNo = 0
            Winner = True 'Sets the boolean variable "Winner" to True
            PlayerOneWinner = True 'Sets the boolean variable "PlayerOneWinner" to True
        ElseIf ComputerPlayerTokenNo = 5 Then
            GetTokens() 'Calls the "GetTokens" subroutine
            Winner = True 'Sets the boolean variable "Winner" to True
            PlayerTwoWinner = True 'Sets the boolean variable "PlayerTwoWinner" to True
        End If
        DisplayWinner() 'Calls the "DisplayWinner" subroutine
        If Draw = True Then 'Checks if the boolean variable "Draw" is set to True
            DisableButtons() 'Calls the "DisableButtons" subroutine
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_rejected
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            picTicTacToeWinner.BackgroundImage = My.Resources.Player_Draw 'Changes the "picTicTacToeWinner" picture box's background image to "Player_Draw" in resources
            picTicTacToeWinner.Visible = True 'Shows the "picTicTacToeWinner" picture box
            DisplayTimer.Start() 'Starts the "DisplayTimer" timer tick event
        End If
    End Sub
    Private Sub DisplayWinner() 'DisplayWinner Subroutine code
        If Winner = True Then 'Checks if a player has won the game
            DisplayTimer.Stop() 'Stops the "DisplayTimer" timer tick event
            picPlayerOneToken.Visible = False 'Hides the "picPlayerOneToken" picturebox
            picComputerPlayerToken.Visible = False 'Hides the "picComputerPlayerToken" picturebox
            If PlayerOneWinner = True Then 'Checks if player one has won the game
                WinnerSoundTimer.Start() 'Starts the sound timer tick event
                picTicTacToeWinner.Visible = True 'Makes the display visible
                picTicTacToeWinner.BackgroundImage = My.Resources.Player_One_Wins 'Changes the image to "Player one has won the game!"
            ElseIf PlayerTwoWinner = True Then 'Checks if player Two has won the game. In this case, the computer player
                WinnerSoundTimer.Start() 'Starts the sound timer tick event
                picTicTacToeWinner.Visible = True 'Makes the display visible
                picTicTacToeWinner.BackgroundImage = My.Resources.Computer_Player_Wins 'Changes the image to "Computer player has won the game!"
            End If
            btnStart.Visible = True 'Shows the "btnStart" button
        End If
    End Sub
    Private Sub DisplayTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayTimer.Tick 'DisplayTimer Timer tick code
        RefreshGame() 'Calls the "RefreshGame" subroutine
        Draw = False  'Sets the boolean variable "Draw" to True
        picTicTacToeWinner.Visible = False 'Hides the "picTicTacToeWinner" picturebox
        picPlayerOneToken.Visible = False 'Hides the "picPlayerOneToken" picturebox
        picComputerPlayerToken.Visible = False 'Hides the "picComputerPlayerToken" picturebox
        DisplayTimer.Stop() 'Stops the "DisplayTimer" timer tick event
    End Sub
    Private Sub WinnerSoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinnerSoundTimer.Tick 'WinnerSoundTimer Timer tick code
        If Winner = False Then  'Checks if there is a winner
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
                frmMainMenu.player.Play() 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            End If
            WinnerSoundTimer.Stop() 'Stops the "WinnerSoundTimer" timer tick event
            Winner = False  'Sets the boolean variable "Winner" to False
        Else
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_setback
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            Winner = False 'Sets the boolean variable "Winner" to False
            WinnerSoundTimer.Stop() 'Stops the "WinnerSoundTimer" timer tick event
        End If
        If Draw = True Then 'Checks if there is a draw
            If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
                frmMainMenu.player.Stream = My.Resources.sound_rejected
                frmMainMenu.player.Play() 'Plays the sound file
            End If
            Draw = False 'Sets the boolean variable "Draw" to False
            WinnerSoundTimer.Stop() 'Stops the "WinnerSoundTimer" timer tick event
        End If
    End Sub
    Private Sub frmTicTacToeSinglePlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmTicTacToeSingleplayer Form Load code
        If My.Settings.DisableCaptions = False Then
            MouseMoveTimer.Start()
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            lblMute.Text = "Mute Sounds" 'Sets the "lblMute" label to "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button 'Sets the "btnMuteUnmute" background image to specified file in resources
        Else
            lblMute.Text = "UnMute Sounds" 'Sets the "lblMute" label to "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button 'Sets the "btnMuteUnmute" background image to specified file in resources
        End If
        DisableButtons() 'Calls the "DisableButtons" subroutine
        picTicTacToeWinner.BackgroundImage = My.Resources.Press_Start 'Changes the image to "Press Start"
        picTicTacToeWinner.Visible = True 'Shows the "picTicTacToeWinner" picture box
        list.Clear() 'Clears the "list" list box
        For i = 1 To 10 'Executes a set of commands 10 times (1-10)
            list.Add(i) 'Adds the numbers (1-10) to the "list" list box's collection
        Next i
    End Sub
    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown 'btnMinimize Button MouseDown code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed 'Changes the background image of the "btnMinimize" button when the mouse is down
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter 'btnMinimize Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted 'Changes the background image of the "btnMinimize" button to highlighted when the curser enters the button
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave 'btnMinimize Button MouseLeave code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp 'btnMinimize Button MouseUp code
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button 'Changes the "btnMinimize" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormMinimizing 'Sets the soundplayer to the "FormMinimizing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.WindowState = FormWindowState.Minimized 'Minimizes the form by changing the form's "FormWindowState" properties to "Minimized"
    End Sub
    'Exit
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed 'Changes the background image of the "btnClose" button when the mouse is down
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted 'Changes the background image of the close button to highlighted when the curser enters the button
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
        btnInfo.BackgroundImage = My.Resources.Info_Button_Pushed 'Changes the background image of the "btnInfo" button when the mouse is down
    End Sub
    Private Sub btnInfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter 'btnInfo Button MouseEnter code
        lblInfo.Visible = True 'Shows the "lblInfo" label when mouse enters the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "MouseScrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        btnInfo.BackgroundImage = My.Resources.Info_Button_Highlighted 'Changes the background image of the info button to highlighted when the curser enters the button
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave 'btnInfo Button MouseLeave code
        lblInfo.Visible = False 'Hides the "lblInfo" label when mouse leaves the picture box
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnInfo.MouseUp
        btnInfo.BackgroundImage = My.Resources.Info_Button 'Changes the "btnInfo" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Dim ProcessDirectory As String = AppPath & "\Information.ppsx" 'Declares "ProcessDirectory" as a string and sets the string value to the path of the "Information.ppsx" file
        System.Diagnostics.Process.Start(ProcessDirectory) 'Starts the slide show
    End Sub
    Private Sub btnSettings_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseDown 'btnSettings Button MouseDown code
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Pushed 'Changes the background image of the "btnSettings" button when the mouse is down
    End Sub
    Private Sub btnSettings_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseEnter 'btnSettings Button MouseEnter code
        lblSettings.Visible = True 'Shows the "lblSettings" label when mouse enters the picture box
        btnSettings.BackgroundImage = My.Resources.Settings_Button_Highlighted 'Changes the background image of the settings button to highlighted when the curser enters the button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.MouseLeave 'btnSettings Button MouseLeave code
        lblSettings.Visible = False 'Hides the "lblSettings" label when mouse leaves the picture box
        btnSettings.BackgroundImage = My.Resources.Settings_Button 'Changes the "btnSettings" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnSettings_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSettings.MouseUp 'btnSettings Button MouseUp code
        btnSettings.BackgroundImage = My.Resources.Settings_Button 'Changes the "btnSettings" button's background image to the original image when the curser has left the picture box
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        frmSettings.Show() 'Shows the "frmSettings" form
    End Sub
    'MuteUnMute
    Private Sub btnMuteUnMute_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseUp 'btnMuteUnMute Button MouseUp code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            My.Settings.Mute = True 'Sets the "Mute" variable in application settings to True
            lblMute.Text = "UnMute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        Else
            My.Settings.Mute = False 'Sets the "Mute" variable in application settings to False
            lblMute.Text = "Mute Sounds"
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMuteUnMute.MouseDown 'btnMuteUnMute Button MouseDown code
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Pushed
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Pushed
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseEnter 'btnMuteUnMute Button MouseEnter code
        lblMute.Visible = True
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button_Highlighted
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button_Highlighted
        End If
    End Sub
    Private Sub btnMuteUnMute_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMuteUnMute.MouseLeave 'btnMuteUnMute Button MouseLeave code
        lblMute.Visible = False
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        Else
            btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        End If
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
        If ExitFlag = False Then
            Dim MessageBoxResult As String
            MessageBoxResult = MsgBox("Are you sure you wish to exit the game?", vbYesNo, "Exit Game")
            If MessageBoxResult = vbYes Then
                ExitFlag = True
            End If
        End If
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormReturning 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
            frmTicTacToeModeMenu.lblMute.Text = "Mute Sounds"
            frmTicTacToeModeMenu.btnMuteUnMute.BackgroundImage = My.Resources.Mute_Button
        Else
            frmTicTacToeModeMenu.lblMute.Text = "UnMute Sounds"
            frmTicTacToeModeMenu.btnMuteUnMute.BackgroundImage = My.Resources.UnMute_Button
        End If
        frmTicTacToeModeMenu.Location = New Point(Me.Location.X + 119, Me.Location.Y)
        frmTicTacToeModeMenu.Show() 'Shows the "frmTicTacToeModeMenu" form
        Me.Dispose() 'Closes the current form
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
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormSelect
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        picTicTacToeWinner.Visible = False
        btnStart.Visible = False
        RestartGame()
    End Sub

    'Picture Boxes
    Private Sub btnTopLeft_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopLeft.MouseUp  'btnpicTopLeftStart MouseUp code
        If PlayerOne = True Then
            picTopLeft.Enabled = False
            picTopLeft.BackgroundImage = My.Resources.TicTacToe_X1
            TopLeft = "X"
            list.Remove(1) 'Removes Number 1 from list 
            CheckPlayerOneTurn()
        Else
            picTopLeft.Enabled = False
            picTopLeft.BackgroundImage = My.Resources.TicTacToe_O
            TopLeft = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnTopCenter_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopCenter.MouseUp 'picTopCenter MouseUp code
        If PlayerOne = True Then
            picTopCenter.Enabled = False
            picTopCenter.BackgroundImage = My.Resources.TicTacToe_X1
            TopCenter = "X"
            list.Remove(2) 'Removes Number 2 from list 
            CheckPlayerOneTurn()
        Else
            picTopCenter.Enabled = False
            picTopCenter.BackgroundImage = My.Resources.TicTacToe_O
            TopCenter = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnTopRight_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopRight.MouseUp 'picTopRight MouseUp code
        If PlayerOne = True Then
            picTopRight.Enabled = False
            picTopRight.BackgroundImage = My.Resources.TicTacToe_X1
            TopRight = "X"
            list.Remove(3) 'Removes Number 3 from list 
            CheckPlayerOneTurn()
        Else
            picTopRight.Enabled = False
            picTopRight.BackgroundImage = My.Resources.TicTacToe_O
            TopRight = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnMiddleLeft_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleLeft.MouseUp 'picMiddleLeft MouseUp code
        If PlayerOne = True Then
            picMiddleLeft.Enabled = False
            picMiddleLeft.BackgroundImage = My.Resources.TicTacToe_X1
            MiddleLeft = "X"
            list.Remove(4) 'Removes Number 4 from list 
            CheckPlayerOneTurn()
        Else
            picMiddleLeft.Enabled = False
            picMiddleLeft.BackgroundImage = My.Resources.TicTacToe_O
            MiddleLeft = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnMiddleCenter_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleCenter.MouseUp 'picMiddleCenter MouseUp code
        If PlayerOne = True Then
            picMiddleCenter.BackgroundImage = My.Resources.TicTacToe_X1
            MiddleCenter = "X"
            list.Remove(5) 'Removes Number 5 from list 
            CheckPlayerOneTurn()
            picMiddleCenter.Enabled = False
        Else
            picMiddleCenter.Enabled = False
            picMiddleCenter.BackgroundImage = My.Resources.TicTacToe_O
            MiddleCenter = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnMiddleRight_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleRight.MouseUp 'picMiddleCenter MouseUp code
        If PlayerOne = True Then
            picMiddleRight.Enabled = False
            picMiddleRight.BackgroundImage = My.Resources.TicTacToe_X1
            MiddleRight = "X"
            list.Remove(6) 'Removes Number 6 from list 
            CheckPlayerOneTurn()
        Else
            picMiddleRight.Enabled = False
            picMiddleRight.BackgroundImage = My.Resources.TicTacToe_O
            MiddleRight = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnBottomLeft_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomLeft.MouseUp 'picBottomLeft MouseUp code
        If PlayerOne = True Then
            picBottomLeft.Enabled = False
            picBottomLeft.BackgroundImage = My.Resources.TicTacToe_X1
            BottomLeft = "X"
            list.Remove(7) 'Removes Number 7 from list 
            CheckPlayerOneTurn()
        Else
            picBottomLeft.Enabled = False
            picBottomLeft.BackgroundImage = My.Resources.TicTacToe_O
            BottomLeft = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnBottomCenter_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomCenter.MouseUp 'picBottomCenter MouseUp code
        If PlayerOne = True Then
            picBottomCenter.Enabled = False
            picBottomCenter.BackgroundImage = My.Resources.TicTacToe_X1
            BottomCenter = "X"
            list.Remove(8) 'Removes Number 8 from list 
            CheckPlayerOneTurn()
        Else
            picBottomCenter.Enabled = False
            picBottomCenter.BackgroundImage = My.Resources.TicTacToe_O
            BottomCenter = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub btnBottomRight_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomRight.MouseUp 'picBottomRight MouseUp code
        If PlayerOne = True Then
            picBottomRight.Enabled = False
            picBottomRight.BackgroundImage = My.Resources.TicTacToe_X1
            BottomRight = "X"
            list.Remove(9) 'Removes Number 9 from list  
            CheckPlayerOneTurn()
        Else
            picBottomRight.Enabled = False
            picBottomRight.BackgroundImage = My.Resources.TicTacToe_O
            BottomRight = "O"
            CheckComputerPlayerTurn()
        End If
    End Sub
    Private Sub picTopLeft_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopLeft.MouseEnter 'picTopLeft MouseEnter code
        If PlayerOne = True Then
            picTopLeft.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picTopLeft_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopLeft.MouseLeave 'picTopLeft MouseLeave code
        picTopLeft.Image = Nothing
    End Sub
    Private Sub picTopCenter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopCenter.MouseEnter 'picBottomRight MouseUp code
        If PlayerOne = True Then
            picTopCenter.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picTopCenter_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopCenter.MouseLeave 'picTopCenter MouseLeave code
        picTopCenter.Image = Nothing
    End Sub
    'Top Right
    Private Sub picTopRight_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopRight.MouseEnter 'picTopRight MouseEnter code
        If PlayerOne = True Then
            picTopRight.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picTopRight_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTopRight.MouseLeave 'picTopRight MouseLeave code
        picTopRight.Image = Nothing
    End Sub
    'Middle Left
    Private Sub picMiddleLeft_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleLeft.MouseEnter 'picMiddleLeft MouseEnter code
        If PlayerOne = True Then
            picMiddleLeft.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picMiddleLeft_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMiddleLeft.MouseLeave 'picMiddleLeft MouseLeave code
        picMiddleLeft.Image = Nothing
    End Sub
    'Middle Center
    Private Sub picMiddlecenter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleCenter.MouseEnter 'picMiddleLeft MouseLeave code
        If PlayerOne = True Then
            picMiddleCenter.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picMiddleCenter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMiddleCenter.MouseLeave 'picMiddleLeft MouseLeave code
        picMiddleCenter.Image = Nothing
    End Sub
    'Middle Right
    Private Sub picMiddleRight_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiddleRight.MouseEnter 'picMiddleRight MouseEnter code
        If PlayerOne = True Then
            picMiddleRight.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picMiddleRight_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMiddleRight.MouseLeave 'picMiddleRight MouseLeave code
        picMiddleRight.Image = Nothing
    End Sub
    'Bottom Left
    Private Sub picBottomLeft_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomLeft.MouseEnter 'picBottomLeft MouseEnter code
        If PlayerOne = True Then
            picBottomLeft.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picBottomLeft_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBottomLeft.MouseLeave 'picBottomLeft MouseLeave code
        picBottomLeft.Image = Nothing
    End Sub
    'Bottom Center
    Private Sub picBottomCenter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomCenter.MouseEnter 'picBottomCenter MouseEnter code
        If PlayerOne = True Then
            picBottomCenter.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picBottomCenter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBottomCenter.MouseLeave 'picBottomCenter MouseLeave code
        picBottomCenter.Image = Nothing
    End Sub
    'Bottom Right
    Private Sub picBottomRight_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBottomRight.MouseEnter 'picBottomRight MouseEnter code
        If PlayerOne = True Then
            picBottomRight.Image = My.Resources.Selected_Box_Green()
        End If
    End Sub
    Private Sub picBottomRight_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBottomRight.MouseLeave 'picBottomRight MouseLeave code
        picBottomRight.Image = Nothing
    End Sub

    Private Sub frmTicTacToeSinglePlayer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress 'frmTicTacToeSinglePlayer form KeyPress code
        If Asc(e.KeyChar) = 13 And btnStart.Visible = True Then
            btnStart_MouseUp(Nothing, Nothing)
        End If
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
                lblLeaveGame.Visible = False 'Hides the "lblLeaveGame" label
                lblInfo.Visible = False 'Hides the "lblInfo" label
                lblMute.Visible = False 'Hides the "lblMute" label
                lblSettings.Visible = False 'Hides the "lblSettings" label
            End If
            CaptionCounter = 0 'Sets the "CaptionCounter" integer value to 0
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString() 'Sets the "CurrentMousePosition" string variable to the same number aas the location of the mouse
        End If
        If CaptionCounter > 5 Then 'Checks if the "CaptionCounter" integer value is greater than 5
            CaptionTimer.Stop() 'Stops the "CaptionTimer" timer
            lblLeaveGame.Visible = True 'Shows the "lblLeaveGame" label
            lblInfo.Visible = True 'Shows the "lblInfo" label
            lblSettings.Visible = True 'Shows the "lblSettings" label
            If btnMuteUnMute.Visible = True Then 'Checks if the "btnMuteUnMute" picturebox is showing
                lblMute.Visible = True 'Shows the "lblMute" label
            End If
        End If
    End Sub
    Private Sub CaptionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptionTimer.Tick 'CaptionTimer Timer Tick code
        CaptionCounter = CaptionCounter + 1  'Increments "CaptionCounter" integer variable
    End Sub

End Class

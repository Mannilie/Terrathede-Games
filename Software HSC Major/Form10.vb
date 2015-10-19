Imports System.IO 'Form makes reference to the "System.IO" namespace
Public Class frmGameSettings 'frmGameSettings form code
    Dim Word As String
    Dim Reader As IO.StreamReader
    Dim Valid As Boolean = True
    Dim SelectedIndex As Integer
    Dim DefaultArray(10000) As String
    Dim DefaultRandomArray(10) As String
    Dim NotValid As Boolean = False
    Dim ValidWord As Boolean = False
    Dim ClearList As Boolean = False
    Dim CancelExit As Boolean = False
    Dim Filenum As Integer = FreeFile() 'Declares "Filenum" as an integer variable obtaining the next available file number using "FreeFile()"
    Dim txtwords As System.IO.StreamReader
    Dim FileWriter As System.IO.StreamWriter
    Dim appPath As String = Application.StartupPath() 'Gets the path of where the application started from (file specified)
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
    Private Sub ValidTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidTimer.Tick 'ValidTimer Timer Tick code
        SelectedIndex = lstWordList.SelectedIndex 'Sets the SelectedIndex variable to the selected item in the listbox
        If My.Settings.HangmanDefaultGameList = False Then 'Checks if the "HangmanDefaultGameList" boolean variable in application settings is set to False
            If lblWordsAdded.Text <= 10 Then 'Checks if the label has the number "10" or below is displayed.
                lblWordsAdded.ForeColor = Color.DarkRed 'Sets the label's text color to Dark Red
                btnRemove.Enabled = False 'Disables remove button
                btnRemove.BackColor = Color.Gray 'Sets the remove button's background color to gray
            Else 'Executes a set of commands if the list box contains more than 10 words
                lblWordsAdded.ForeColor = Color.Black 'Sets the label's text color to Black
                btnRemove.Enabled = True 'Enables the remove button
                btnRemove.BackColor = Color.Firebrick 'Sets the remove button's background color to Firebrick
            End If
        End If
        If txtWord.Text.Length < 3 Then 'Checks if the user's entered word's length is less than 3 characters
            picValid.BackgroundImage = Nothing 'The green or red tick is not shown if the word's length is below 3 characters 
            NotValid = True 'The "NotValid" boolean variable is set to true
        Else
            Valid = True 'Sets "Valid" boolean variable to True
            If txtWord.Text.Length > 21 Then 'Checks if the entered word length is greater than 21 characters
                Valid = False  'Sets "Valid" boolean variable to False
            End If
            For Symbol = 1 To 27 'Repeates execution of commands 27 times
                If txtWord.Text.Contains(lstSymbol.Items(Symbol)) Then 'Checks the invisible symbol listbox for characters to compare with the user's entered word
                    Valid = False 'Sets "Valid" boolean variable to false
                End If
                If Valid = False Then 'Checks if the "Valid" boolean variable is set to false
                    Exit For 'Exits the For statement immediately
                End If
            Next
            For Number = 0 To 9 'Executes set of commands 10 times (0-9)
                If txtWord.Text.Contains(Number) Then 'Checks if the user has entered numbers into the textbox
                    Valid = False 'Sets "Valid" boolean variable to false
                End If
                If Valid = False Then 'Checks if the boolean variable has been set to false
                    Exit For 'Exits the For Next statement
                End If
            Next
            If Valid = False Then 'Checks if the boolean variable has been set to false
                picValid.BackgroundImage = My.Resources.Red_Cross 'Changes the picturebox's background image to a red cross
                NotValid = True 'Sets boolean variable "Not Valid" to true
                Valid = True 'Sets boolean variable "Valid" to true so that the timer can start whole execution every tick
            Else
                picValid.BackgroundImage = My.Resources.Green_Tick 'Changes the picturebox's background image to a green tick
                NotValid = False 'Sets boolean variable "Not Valid" to false
                Valid = True 'Sets boolean variable "Valid" to true so that the timer can start whole execution every tick
            End If
        End If
    End Sub
    Private Sub txtword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWord.KeyPress 'txtWord Textbox Keypress code
        ValidTimer.Start() 'Starts ValidTimer
        If Asc(e.KeyChar) = 13 Then 'Checks if the enter key has been pressed
            Call btnInsert_Click(Nothing, Nothing) 'Calls the insert button's click event handler
        End If
    End Sub
    Private Sub txtWord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWord.KeyDown 'txtWord Textbox KeyDown code
        If e.KeyCode = Keys.Up Then 'Checks if the up arrow key has been pressed whilst the textbox is focused
            If lstWordList.SelectedIndex < 1 Then 'Checks if the selected word's index is below 1
                Exit Sub 'Exits the sub if the above statement is true
            Else
                lstWordList.SelectedIndex = SelectedIndex - 1  'Changes selection to the next word up in the listbox
            End If
        End If
        If e.KeyCode = Keys.Down Then 'Checks if the down arrow key has been pressed whilst the textbox is focused
            If lstWordList.SelectedIndex > lstWordList.Items.Count - 2 Then 'Checks if the selected word is the last one in the list
                Exit Sub 'Exits the sub if the above statement is true
            Else
                lstWordList.SelectedIndex = SelectedIndex + 1 'Changes selection to the next word down in the listbox
            End If
        End If
    End Sub
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown 'btnClose Button MouseDown code
        btnClose.BackgroundImage = My.Resources.Close_Button_Pushed 'Changes the background image of the "btnClose" button when the mouse is down
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter 'btnClose Button MouseEnter code
        btnClose.BackgroundImage = My.Resources.Close_Button_Highlighted 'Changes the background image of the "btnClose" button to highlighted when the curser enters the button
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_MouseScrollover 'Sets the soundplayer to the "Scrollover" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave 'btnClose Button Mouseleave code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the curser has left the picture box
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp 'btnClose Button MouseUp code
        btnClose.BackgroundImage = My.Resources.Close_Button 'Changes the "btnClose" button's background image to the original image when the mouse is set to up
        If My.Settings.Mute = False Then 'Checks if "Mute" variable in application settings is set to false
            frmMainMenu.player.Stream = My.Resources.sound_FormClosing 'Sets the soundplayer to the "FormClosing" WAV file in the resources
            frmMainMenu.player.Play() 'Plays the sound file
        End If
        Me.Hide() 'Hides the form once the "Close" button has been pressed
    End Sub
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click 'btnInsert Button Click code
        CancelExit = True 'The CancelExit flag is set to true so that the messageboxes doesn't close the form upon deactivating
        If txtWord.Text = "" Then 'Checks if the textbox is empty
            MsgBox("You have not yet entered a word. Please enter a valid word into the text box to proceed.", vbInformation, "Invalid Word") 'Prompts the user to enter a word into the textbox
            CancelExit = False 'Sets the boolean variable back to False
            txtWord.Focus() 'Places the curser into the text box
        ElseIf NotValid = True Then 'Checks if the boolean variable "Not Valid" is set to true
            MsgBox("The word you have entered is invalid. Valid words must consist of only alphabetical characters. Do not add any symbols or numbered values. The length of the word must be between 3 to 21 characters Please try again.", vbExclamation, "Invalid Word") 'Prompts the user to enter a valid word
            CancelExit = False 'Sets the boolean variable back to False
            txtWord.Focus() 'Places the curser into the text box
        Else
            SaveAnimation() 'Calls the "SaveAnimation" subroutine
            Word = StrConv(txtWord.Text, VbStrConv.ProperCase) 'Converts the word in the textbox to lowercase except for the first character and places the word into the "Word" string variable
            Word = Word.Trim() 'Removes white spaces from the "Word" string
            Do While Word.IndexOf("  ") <> -1 'Executes a set of commands until there are no more double spaces in the "Word" string
                Word = Word.Replace("  ", " ") 'Replaces every double space is one space only
            Loop
            FileWriter = File.AppendText("CustomWordList.txt") 'FileWriter is told to append text into the text document "CustomWordList"
            FileWriter.WriteLine(Word) 'FileWriter writes word in the "Word" string into the text document
            FileWriter.Close() 'closes the File Writer
            GetCustomWordList() 'Calls the "GetCustomWordListtxt" subroutine
            txtWord.Text = "" 'Clears the textbox
            lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
            CancelExit = False 'Sets the "CancelExit" boolean variable back to true
            txtWord.Focus() 'Places the curser into the text box
        End If
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click 'btnRemove Button Click code
        If lstWordList.SelectedIndex = -1 Then 'Checks if nothing has been selected in the list box
            Exit Sub 'Exits the click event
        Else
            SaveAnimation() 'Calls the "SaveAnimation" subroutine
            lstWordList.Items.RemoveAt(lstWordList.SelectedIndex) 'Removes selected item from the list
            File.WriteAllText(appPath & "\CustomWordList.txt", "") 'Clears the entire text document
            FileWriter = File.AppendText("CustomWordList.txt") 'FileWriter is told to append text into the text document "CustomWordList"
            For i = 0 To lstWordList.Items.Count - 1 'Executes commands several times until the value of "i" reaches the maximum count of the words in the listbox
                FileWriter.WriteLine(lstWordList.Items(i)) 'Writes the new set of words in the listbox to the text document
            Next
            FileWriter.Close() 'closes the File Writer
            lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
            lstWordList.SelectedIndex = SelectedIndex - 1 'Sets the selected word in the listbox to the one it was originally, other than moving to the next word down in the listbox
            txtWord.Focus() 'Places the curser into the text box
        End If
    End Sub
    Private Sub btnCleanList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleanList.Click 'btnCleanList Button Click code
        CancelExit = True 'The CancelExit flag is set to true so that the messageboxes doesn't close the form upon deactivating
        Dim MessageBoxResult As String 'Declares "MessageboxResult" as a string
        MessageBoxResult = MsgBox("Are you sure you want to clean the list? Note: This will add 10 random words from the default list to the custom list.", vbYesNo + vbInformation, "Clear All") 'The "MessageBoxResult" variable gathers the user's decision from the message box, whether it be yes/no
        txtWord.Focus() 'Places the curser into the text box
        If MessageBoxResult = vbYes Then 'Checks if the user's decision from the message box was "Yes"
            SaveAnimation() 'Calls the "SaveAnimation" subroutine
            GetDefaultWords() 'Calls the "GetDefaultWords" subroutine
            lstWordList.Items.Clear() 'Clears all items in the listbox
            FileOpen(Filenum, appPath & "\CustomWordList.txt", OpenMode.Output) 'Opens the next available file in the destination specified with "write" access
            FileClose() 'Closes the file immediately, erasing all of its contents
            For i = 0 To 9 'Executes a set of commands 10 times (0-9)
                FileWriter = File.AppendText("CustomWordList.txt") 'Sets "FileWriter" variable to appendtext of the "CustomWordList" text document
                FileWriter.WriteLine(DefaultRandomArray(i)) 'Adds words line-by-line in the text document through "DefaultArray" as well as the index of the word in the array
                FileWriter.Close() 'closes the File Writer
                lstWordList.Items.Add(DefaultRandomArray(i)) 'Adds the word with the index "i" in the "DefaultArray" to the "Word" list box
            Next
            lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
        End If
        CancelExit = False 'The CancelExit flag is set back to False
    End Sub
    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click 'btnReplace Button Click code
        CancelExit = True 'The CancelExit flag is set to true so that the messageboxes doesn't close the form upon deactivating
        If lstWordList.SelectedIndex = -1 Then 'Checks if nothing is selected in the listbox
            MsgBox("Please select the word you wish to replace.", vbExclamation + vbOKOnly, "Word not selected") 'Displays messagebox prompting the user to select a word in the listbox
            CancelExit = False 'The CancelExit flag is set back to false
            txtWord.Focus() 'Places the curser into the text box
        ElseIf txtWord.Text = "" Then 'Checks if the textbox is empty
            MsgBox("You have not yet entered a word. Please enter a valid word into the text box to proceed.", vbInformation, "Invalid Word") 'Prompts the user to enter a word into the textbox
            CancelExit = False 'The CancelExit flag is set back to false
            txtWord.Focus() 'Places the curser into the text box
        ElseIf NotValid = True Then 'Checks if the "NotValid" variable has been set to True, meaning that the word is not valid
            MsgBox("The word or letter you have entered is invalid. Please insert a valid word to replace your selected word." & vbCrLf & vbCrLf & "Selected Word: " & lstWordList.SelectedItem & vbCrLf & "Invalid word entered: " & txtWord.Text, vbExclamation + vbOKOnly, "Invalid Word") 'Displays a messagebox prompting the user to enter a valid word. This also displays the incorrect word that the user has entered
            CancelExit = False 'The CancelExit flag is set back to false
            txtWord.Focus() 'Places the curser into the text box
        Else
            SaveAnimation() 'Calls the "SaveAnimation" subroutine
            lstWordList.Items.RemoveAt(SelectedIndex) 'Removes the selected word in the listbox
            Word = StrConv(txtWord.Text, VbStrConv.ProperCase) 'Converts all the characters in the textbox to lowercase except for the first character and places it inside the "Word" string variable
            lstWordList.Items.Insert(SelectedIndex, Word) 'Inserts "Word" string variable into selected index of the listbox
            OverwriteCustomWordList() 'Calls the Overwrite CustomWordList subroutine
            lstWordList.SelectedIndex = SelectedIndex 'Sets the selected word in the listbox to the one it was originally, other than moving to the next word down in the listbox
            txtWord.Text = "" 'Clears the textbox
            txtWord.Focus() 'Focuses on the textbox
            CancelExit = False 'The CancelExit flag is set back to false
        End If
        txtWord.Focus() 'Focuses on the textbox regardless if the above is true or not
    End Sub
    Private Sub GetDefaultWords() 'DefaultWords Subroutine code
        Reader = New IO.StreamReader(appPath & "\DefaultWordList.txt") 'Reader collects information from the "DefaultWordList" text document
        Dim RandomNumber As New Random 'Declares "RandomNumber" as a random integer value
        Dim WordCounter As Integer = 0 'Declares "WordCounter" as an Integer value
        Dim WordIndex As Integer 'Declares "WordIndex" as an integer value
        While (Reader.Peek() > -1) 'Executes a set of commands until the "Reader" stream reader has reached the end of the text document
            DefaultArray(WordCounter) = Reader.ReadLine 'Adds words to the index value of "DefaultArray" from the Reader's line in the text document
            WordCounter = WordCounter + 1 'Increments "WordCounter"
        End While
        For Words = 0 To 9 'Executes a set of tommands 10 times (0-9)
            WordIndex = RandomNumber.Next(1, WordCounter) 'Sets the "WordIndex" integer to the next random value from "1" to "WordCounter"
            DefaultRandomArray(Words) = DefaultArray(WordIndex) 'Sets the "Words" index of "DefaultRandomArray" to the next random number in "DefaultArray" in a set of 10
        Next
        Reader.Close() 'Closes the streamreader
    End Sub
    Private Sub GetDefaultWordList() 'GetDefaultWordList Subroutine code
        lstWordList.Items.Clear() 'Clears the word list box
        Reader = New IO.StreamReader(appPath & "\DefaultWordList.txt") 'Reader collects information from the "DefaultWordList" text document
        While (Reader.Peek() > -1) 'Reads the file until the end of the text document has been reached
            lstWordList.Items.Add(Reader.ReadLine) 'Adds words to the listbox from the text document line-by-line
        End While
        Reader.Close() 'Closes the streamreader
        lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
    End Sub
    Private Sub DisableButtons() 'DisableButtons Subroutine code
        txtWord.Enabled = False 'Disables text box
        btnInsert.Enabled = False 'Disables insert button
        btnReplace.Enabled = False 'Disables replace button
        btnRemove.Enabled = False 'Disables remove button
        btnCleanList.Enabled = False 'Disables clean list button
        btnInsert.BackColor = Color.Gray 'Sets the background color of insert button to gray
        btnReplace.BackColor = Color.Gray 'Sets the background color of replace button to gray
        btnRemove.BackColor = Color.Gray 'Sets the background color of remove button to gray
        btnCleanList.BackColor = Color.Gray 'Sets the background color of clean list button to gray
    End Sub
    Private Sub EnableButtons() 'EnableButtons Subroutine code
        txtWord.Enabled = True 'Enables text box
        btnInsert.Enabled = True 'Enables insert button 
        btnReplace.Enabled = True 'Enables replace button
        btnCleanList.Enabled = True 'Enables clean list button
        If Not lstWordList.Items.Count <= 10 Then 'Checks how many words are displayed in the word listbox.
            btnRemove.Enabled = True 'Enabled the remove button if the above statement is true.
            btnRemove.BackColor = Color.Firebrick 'The remove button's color is set to firebrick, showing that it is enabled
        End If
        btnInsert.BackColor = Color.LimeGreen 'Sets the insert button's background color to LimeGreen
        btnReplace.BackColor = Color.Orange 'Sets the replace button's background color to orange
        btnCleanList.BackColor = Color.SteelBlue 'Sets Clean List button's color is set to SteelBlue.
    End Sub
    Private Sub GetCustomWordList() 'GetCustomWordList Subroutine code
        lstWordList.Items.Clear() 'Clears the list box
        Reader = New IO.StreamReader(appPath & "\CustomWordList.txt") 'Reader set to read off of the "CustomWordList" text document
        While (Reader.Peek() > -1) 'Executes commands until the reader has reached the end of the file
            lstWordList.Items.Add(Reader.ReadLine) 'Adds words to the listbox that the reader has read line-by-line
        End While
        Reader.Close() 'Closes the streamreader
        lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
    End Sub
    Private Sub OverwriteCustomWordList() 'OverwriteCustomWordList Subroutine code
        FileOpen(Filenum, appPath & "\CustomWordList.txt", OpenMode.Output) 'Opens the next available file in the destination specified with "write" access
        FileClose()  'Closes the file immediately, erasing all of its contents
        For i = 0 To lstWordList.Items.Count - 1 'Executes set of commands until the integer "i" is equal to the amount of words in the list box
            FileWriter = File.AppendText("CustomWordList.txt") 'Sets "FileWriter" variable to appendtext of the "CustomWordList" text document
            FileWriter.WriteLine(lstWordList.Items(i)) 'Adds words line-by-line in the text document through "DefaultArray" as well as the index of the word in the array
            FileWriter.Close() 'closes the File Writer
        Next
    End Sub
    Private Sub frmGameSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown 'frmSettings Form KeyDown code
        If e.KeyCode = 46 Then 'Traps the Delete "KeyCode" instead of using Ascii value 127
            If btnRemove.Enabled = False Then 'Checks if the "btnRemove" button is enabled
                CancelExit = True 'The CancelExit flag is set to true so that the messagebox doesn't close the form upon deactivating
                If rbDefaultList.Checked = True Then 'Checks if the "rbDefaultList" radio button is selected
                    MsgBox("You cannot delete any words from the default word list.", vbExclamation + vbOKOnly, "Invalid Function") 'The Messagebox notifies the user that they cannot delete words from the default word list if they press delete
                Else
                    MsgBox("You cannot delete anymore words. You are only allowed a minimum of 10 words.", vbExclamation + vbOKOnly, "Invalid Function") 'The Messagebox notifies the user that they cannot delete anymore words if the list only contains 10 words
                End If
                CancelExit = False 'The CancelExit flag is set back to false
            Else
                Call btnRemove_Click(Nothing, Nothing) 'Clicks the remove button
            End If
        End If
    End Sub
    Private Sub frmGameSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'frmGameSettings Form Load code
        If My.Settings.HangmanDefaultGameList = True Then 'Checks the if the boolean variable in application settings "HangmanDefaultGameList" is set as true
            DisableButtons() 'Calls the "DisableButtons" subroutine
            rbDefaultList.Checked = True 'Selects the "Default List" radio button if the above statement is true
            lblDefaultWordListInfo.BringToFront() 'Displays the "DefaultWordList" label showing information on this radio button's selection
            GetDefaultWordList() 'Calls the "GetDefaultWordListtxt" subroutine
        Else 'Executes a set of commands if the "If statement" is false
            EnableButtons() 'Calls the "EnableButtons" subroutine
            rbCustomList.Checked = True 'Selects the "Custom List" radio button
            lblCustomWordListInfo.BringToFront() 'Displays the "CustomWordList" label showing information on this radio button's selection
            GetCustomWordList() 'Calls the "GetCustomWordListtxt" subroutine
        End If
        ValidTimer.Start() 'Starts "ValidTimer"
        GetDefaultWords() 'Calls the "DefaultWords" subroutine
    End Sub
    Private Sub frmSettings_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate 'frmSettings Form Deactivate code
        If CancelExit = False Then 'Checks if the "CancelExit" boolean variable is set to false
            Me.Dispose() 'Closes the form
        End If
    End Sub
    Private Sub rbDefaultList_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbDefaultList.MouseUp 'rbDefaultList Radio Button MouseDown code
        lblWordsAdded.ForeColor = Color.Black 'Sets the "lblWordsAdded" label's forecolor to black
        ValidTimer.Stop() 'Stops the valid timer when the "DefaultList" radio button has been checked
        lblDefaultWordListInfo.BringToFront()  'Displays the "lblDefaultWordListInfo" label showing information on this radio button's selection
        GetDefaultWordList() 'Calls the "GetDefaultWordListtxt" subroutine
        DisableButtons() 'Calls the "DisableButtons" subroutine
        lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
        SaveSettings() 'Calls the "SaveSettings" subroutine
    End Sub
    Private Sub rbCustomList_Mouseup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbCustomList.MouseUp 'rbCustomList Radio Button MouseDown code
        ValidTimer.Start() 'Starts the valid timer when the "CustomList" radio button has been checked
        lblCustomWordListInfo.BringToFront() 'Displays the "lblCustomWordListInfo" label showing information on this radio button's selection
        GetCustomWordList() 'Calls the "GetCustomWordListtxt" subroutine
        EnableButtons() 'Calls the "EnableButtons" subroutine
        SaveSettings() 'Calls the "SaveSettings" subroutine
        lblWordsAdded.Text = lstWordList.Items.Count 'Sets the label with the index of the amount of words that have been added to the list box
    End Sub

    Private Sub SaveSettings() 'SaveSettings Subroutine code
        If rbDefaultList.Checked = True Then 'Checks if the "rbDefaultList" radio button is checked
            My.Settings.HangmanDefaultGameList = True 'Sets the application settings variable "HangmanDefaultGameList" to True
        ElseIf rbCustomList.Checked = True Then 'Checks if the "rbCustomList" radio button is checked
            My.Settings.HangmanDefaultGameList = False 'Sets the application settings variable "HangmanDefaultGameList" to False
        End If
        My.Settings.Save() 'Saves settings to application
    End Sub
    Private Sub SaveAnimation() 'SaveAnimation Subroutine code
        picSaveGif.Visible = True 'Shows the save picture box gif animation
        PicGreenTick.Visible = False 'Hides the green tick picture box from the form
        lblGameSettingsSaved.Text = "Saving Settings..." 'Sets the "lblGameSettingsSaved" label's text to "Saving Settings..."
        With picSaveGif 'Executes a set of commands regarding the "picSaveGif" picture box
            .Image = My.Resources.LoadingScreen 'Sets the "picSaveGif" picture box's image to the gif file in resources
            .SizeMode = PictureBoxSizeMode.CenterImage 'Changes the "SizeMode" of the image module in the picture box
        End With
        SaveTimer.Start() 'Starts "SaveTimer" Timer 
    End Sub
    Private Sub SaveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTimer.Tick 'SaveTimer Tick Subroutine code
        PicGreenTick.Visible = True 'Shows the green tick "picGreenTick" picture box
        picSaveGif.Visible = False 'Hides the "picSaveGif" picture box gif animation
        lblGameSettingsSaved.Text = "Game Settings Saved." 'Sets the "lblGameSettingsSaved" label's text to "Game Settings Saved."
        SaveTimer.Stop()  'Stops "SaveTimer" Timer 
    End Sub
End Class

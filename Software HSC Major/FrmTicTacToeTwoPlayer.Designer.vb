<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToeTwoPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicTacToeTwoPlayer))
        Me.lblPlayerTwo = New System.Windows.Forms.Label()
        Me.lblPlayerOne = New System.Windows.Forms.Label()
        Me.lblMute = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bxCorrectWords = New System.Windows.Forms.GroupBox()
        Me.picPlayerOneStatus = New System.Windows.Forms.PictureBox()
        Me.picPlayerOneMarker = New System.Windows.Forms.PictureBox()
        Me.picPlayer1_GoldToken3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1_GoldToken5 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1_GoldToken4 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1_GoldToken2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1_GoldToken1 = New System.Windows.Forms.PictureBox()
        Me.lblPlayerOneTokens = New System.Windows.Forms.Label()
        Me.DisplayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WinnerSoundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblLeaveGame = New System.Windows.Forms.Label()
        Me.bxIncorrectWords = New System.Windows.Forms.GroupBox()
        Me.picPlayerTwoStatus = New System.Windows.Forms.PictureBox()
        Me.picComputerPlayer_GoldToken3 = New System.Windows.Forms.PictureBox()
        Me.picComputerPlayer_GoldToken5 = New System.Windows.Forms.PictureBox()
        Me.picComputerPlayer_GoldToken4 = New System.Windows.Forms.PictureBox()
        Me.picComputerPlayer_GoldToken2 = New System.Windows.Forms.PictureBox()
        Me.picComputerPlayer_GoldToken1 = New System.Windows.Forms.PictureBox()
        Me.lblPlayerTwoTokens = New System.Windows.Forms.Label()
        Me.picComputerPlayerMarker = New System.Windows.Forms.PictureBox()
        Me.picTopLeft = New System.Windows.Forms.PictureBox()
        Me.picTicTacToeWinner = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.PictureBox()
        Me.btnMuteUnMute = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picMiddleCenter = New System.Windows.Forms.PictureBox()
        Me.picMiddleLeft = New System.Windows.Forms.PictureBox()
        Me.picBottomLeft = New System.Windows.Forms.PictureBox()
        Me.picBottomCenter = New System.Windows.Forms.PictureBox()
        Me.picBottomRight = New System.Windows.Forms.PictureBox()
        Me.picMiddleRight = New System.Windows.Forms.PictureBox()
        Me.picTopRight = New System.Windows.Forms.PictureBox()
        Me.picTopCenter = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CaptionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bxCorrectWords.SuspendLayout()
        CType(Me.picPlayerOneStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerOneMarker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1_GoldToken3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1_GoldToken5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1_GoldToken4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1_GoldToken2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1_GoldToken1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bxIncorrectWords.SuspendLayout()
        CType(Me.picPlayerTwoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayer_GoldToken3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayer_GoldToken5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayer_GoldToken4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayer_GoldToken2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayer_GoldToken1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerPlayerMarker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTicTacToeWinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiddleCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiddleLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiddleRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlayerTwo
        '
        Me.lblPlayerTwo.AutoEllipsis = True
        Me.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTwo.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTwo.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerTwo.Location = New System.Drawing.Point(1035, 180)
        Me.lblPlayerTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTwo.Name = "lblPlayerTwo"
        Me.lblPlayerTwo.Size = New System.Drawing.Size(379, 46)
        Me.lblPlayerTwo.TabIndex = 165
        Me.lblPlayerTwo.Text = "Player Two"
        Me.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlayerOne
        '
        Me.lblPlayerOne.AutoEllipsis = True
        Me.lblPlayerOne.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerOne.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOne.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerOne.Location = New System.Drawing.Point(27, 180)
        Me.lblPlayerOne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerOne.Name = "lblPlayerOne"
        Me.lblPlayerOne.Size = New System.Drawing.Size(379, 46)
        Me.lblPlayerOne.TabIndex = 164
        Me.lblPlayerOne.Text = "Player One"
        Me.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMute
        '
        Me.lblMute.BackColor = System.Drawing.Color.Transparent
        Me.lblMute.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMute.Location = New System.Drawing.Point(92, 849)
        Me.lblMute.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMute.Name = "lblMute"
        Me.lblMute.Size = New System.Drawing.Size(199, 33)
        Me.lblMute.TabIndex = 169
        Me.lblMute.Text = "Mute Sounds"
        Me.lblMute.Visible = False
        '
        'lblSettings
        '
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(1131, 849)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(216, 33)
        Me.lblSettings.TabIndex = 167
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSettings.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Tic Tac Toe - Two Player"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'bxCorrectWords
        '
        Me.bxCorrectWords.BackColor = System.Drawing.Color.Transparent
        Me.bxCorrectWords.Controls.Add(Me.picPlayerOneStatus)
        Me.bxCorrectWords.Controls.Add(Me.picPlayerOneMarker)
        Me.bxCorrectWords.Controls.Add(Me.picPlayer1_GoldToken3)
        Me.bxCorrectWords.Controls.Add(Me.picPlayer1_GoldToken5)
        Me.bxCorrectWords.Controls.Add(Me.picPlayer1_GoldToken4)
        Me.bxCorrectWords.Controls.Add(Me.picPlayer1_GoldToken2)
        Me.bxCorrectWords.Controls.Add(Me.picPlayer1_GoldToken1)
        Me.bxCorrectWords.Controls.Add(Me.lblPlayerOneTokens)
        Me.bxCorrectWords.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxCorrectWords.ForeColor = System.Drawing.Color.Lime
        Me.bxCorrectWords.Location = New System.Drawing.Point(27, 229)
        Me.bxCorrectWords.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxCorrectWords.Name = "bxCorrectWords"
        Me.bxCorrectWords.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxCorrectWords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bxCorrectWords.Size = New System.Drawing.Size(379, 357)
        Me.bxCorrectWords.TabIndex = 162
        Me.bxCorrectWords.TabStop = False
        '
        'picPlayerOneStatus
        '
        Me.picPlayerOneStatus.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerOneStatus.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Token_Player
        Me.picPlayerOneStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerOneStatus.Location = New System.Drawing.Point(13, 151)
        Me.picPlayerOneStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerOneStatus.Name = "picPlayerOneStatus"
        Me.picPlayerOneStatus.Size = New System.Drawing.Size(352, 198)
        Me.picPlayerOneStatus.TabIndex = 173
        Me.picPlayerOneStatus.TabStop = False
        Me.picPlayerOneStatus.Visible = False
        '
        'picPlayerOneMarker
        '
        Me.picPlayerOneMarker.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerOneMarker.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.TicTacToe_X1
        Me.picPlayerOneMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayerOneMarker.Location = New System.Drawing.Point(127, 198)
        Me.picPlayerOneMarker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerOneMarker.Name = "picPlayerOneMarker"
        Me.picPlayerOneMarker.Size = New System.Drawing.Size(120, 122)
        Me.picPlayerOneMarker.TabIndex = 131
        Me.picPlayerOneMarker.TabStop = False
        '
        'picPlayer1_GoldToken3
        '
        Me.picPlayer1_GoldToken3.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1_GoldToken3.BackgroundImage = CType(resources.GetObject("picPlayer1_GoldToken3.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer1_GoldToken3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer1_GoldToken3.Location = New System.Drawing.Point(157, 92)
        Me.picPlayer1_GoldToken3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayer1_GoldToken3.Name = "picPlayer1_GoldToken3"
        Me.picPlayer1_GoldToken3.Size = New System.Drawing.Size(64, 59)
        Me.picPlayer1_GoldToken3.TabIndex = 83
        Me.picPlayer1_GoldToken3.TabStop = False
        '
        'picPlayer1_GoldToken5
        '
        Me.picPlayer1_GoldToken5.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1_GoldToken5.BackgroundImage = CType(resources.GetObject("picPlayer1_GoldToken5.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer1_GoldToken5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer1_GoldToken5.Location = New System.Drawing.Point(301, 92)
        Me.picPlayer1_GoldToken5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayer1_GoldToken5.Name = "picPlayer1_GoldToken5"
        Me.picPlayer1_GoldToken5.Size = New System.Drawing.Size(64, 59)
        Me.picPlayer1_GoldToken5.TabIndex = 81
        Me.picPlayer1_GoldToken5.TabStop = False
        '
        'picPlayer1_GoldToken4
        '
        Me.picPlayer1_GoldToken4.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1_GoldToken4.BackgroundImage = CType(resources.GetObject("picPlayer1_GoldToken4.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer1_GoldToken4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer1_GoldToken4.Location = New System.Drawing.Point(229, 92)
        Me.picPlayer1_GoldToken4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayer1_GoldToken4.Name = "picPlayer1_GoldToken4"
        Me.picPlayer1_GoldToken4.Size = New System.Drawing.Size(64, 59)
        Me.picPlayer1_GoldToken4.TabIndex = 82
        Me.picPlayer1_GoldToken4.TabStop = False
        '
        'picPlayer1_GoldToken2
        '
        Me.picPlayer1_GoldToken2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1_GoldToken2.BackgroundImage = CType(resources.GetObject("picPlayer1_GoldToken2.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer1_GoldToken2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer1_GoldToken2.Location = New System.Drawing.Point(85, 92)
        Me.picPlayer1_GoldToken2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayer1_GoldToken2.Name = "picPlayer1_GoldToken2"
        Me.picPlayer1_GoldToken2.Size = New System.Drawing.Size(64, 59)
        Me.picPlayer1_GoldToken2.TabIndex = 84
        Me.picPlayer1_GoldToken2.TabStop = False
        '
        'picPlayer1_GoldToken1
        '
        Me.picPlayer1_GoldToken1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1_GoldToken1.BackgroundImage = CType(resources.GetObject("picPlayer1_GoldToken1.BackgroundImage"), System.Drawing.Image)
        Me.picPlayer1_GoldToken1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer1_GoldToken1.Location = New System.Drawing.Point(13, 92)
        Me.picPlayer1_GoldToken1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayer1_GoldToken1.Name = "picPlayer1_GoldToken1"
        Me.picPlayer1_GoldToken1.Size = New System.Drawing.Size(64, 59)
        Me.picPlayer1_GoldToken1.TabIndex = 85
        Me.picPlayer1_GoldToken1.TabStop = False
        '
        'lblPlayerOneTokens
        '
        Me.lblPlayerOneTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerOneTokens.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOneTokens.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerOneTokens.Location = New System.Drawing.Point(7, 41)
        Me.lblPlayerOneTokens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerOneTokens.Name = "lblPlayerOneTokens"
        Me.lblPlayerOneTokens.Size = New System.Drawing.Size(359, 48)
        Me.lblPlayerOneTokens.TabIndex = 86
        Me.lblPlayerOneTokens.Text = "Tokens: 0"
        '
        'DisplayTimer
        '
        Me.DisplayTimer.Interval = 1000
        '
        'WinnerSoundTimer
        '
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(1193, 44)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(156, 32)
        Me.lblInfo.TabIndex = 144
        Me.lblInfo.Text = "Information"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblInfo.Visible = False
        '
        'lblLeaveGame
        '
        Me.lblLeaveGame.BackColor = System.Drawing.Color.Transparent
        Me.lblLeaveGame.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaveGame.Location = New System.Drawing.Point(87, 47)
        Me.lblLeaveGame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeaveGame.Name = "lblLeaveGame"
        Me.lblLeaveGame.Size = New System.Drawing.Size(156, 32)
        Me.lblLeaveGame.TabIndex = 143
        Me.lblLeaveGame.Text = "Leave Game"
        Me.lblLeaveGame.Visible = False
        '
        'bxIncorrectWords
        '
        Me.bxIncorrectWords.BackColor = System.Drawing.Color.Transparent
        Me.bxIncorrectWords.Controls.Add(Me.picPlayerTwoStatus)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayer_GoldToken3)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayer_GoldToken5)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayer_GoldToken4)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayer_GoldToken2)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayer_GoldToken1)
        Me.bxIncorrectWords.Controls.Add(Me.lblPlayerTwoTokens)
        Me.bxIncorrectWords.Controls.Add(Me.picComputerPlayerMarker)
        Me.bxIncorrectWords.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxIncorrectWords.ForeColor = System.Drawing.Color.DarkRed
        Me.bxIncorrectWords.Location = New System.Drawing.Point(1035, 229)
        Me.bxIncorrectWords.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxIncorrectWords.Name = "bxIncorrectWords"
        Me.bxIncorrectWords.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxIncorrectWords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bxIncorrectWords.Size = New System.Drawing.Size(379, 357)
        Me.bxIncorrectWords.TabIndex = 163
        Me.bxIncorrectWords.TabStop = False
        '
        'picPlayerTwoStatus
        '
        Me.picPlayerTwoStatus.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerTwoStatus.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Token_Player
        Me.picPlayerTwoStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerTwoStatus.Location = New System.Drawing.Point(15, 151)
        Me.picPlayerTwoStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerTwoStatus.Name = "picPlayerTwoStatus"
        Me.picPlayerTwoStatus.Size = New System.Drawing.Size(352, 198)
        Me.picPlayerTwoStatus.TabIndex = 140
        Me.picPlayerTwoStatus.TabStop = False
        Me.picPlayerTwoStatus.Visible = False
        '
        'picComputerPlayer_GoldToken3
        '
        Me.picComputerPlayer_GoldToken3.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayer_GoldToken3.BackgroundImage = CType(resources.GetObject("picComputerPlayer_GoldToken3.BackgroundImage"), System.Drawing.Image)
        Me.picComputerPlayer_GoldToken3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerPlayer_GoldToken3.Location = New System.Drawing.Point(159, 92)
        Me.picComputerPlayer_GoldToken3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayer_GoldToken3.Name = "picComputerPlayer_GoldToken3"
        Me.picComputerPlayer_GoldToken3.Size = New System.Drawing.Size(64, 59)
        Me.picComputerPlayer_GoldToken3.TabIndex = 89
        Me.picComputerPlayer_GoldToken3.TabStop = False
        '
        'picComputerPlayer_GoldToken5
        '
        Me.picComputerPlayer_GoldToken5.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayer_GoldToken5.BackgroundImage = CType(resources.GetObject("picComputerPlayer_GoldToken5.BackgroundImage"), System.Drawing.Image)
        Me.picComputerPlayer_GoldToken5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerPlayer_GoldToken5.Location = New System.Drawing.Point(303, 92)
        Me.picComputerPlayer_GoldToken5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayer_GoldToken5.Name = "picComputerPlayer_GoldToken5"
        Me.picComputerPlayer_GoldToken5.Size = New System.Drawing.Size(64, 59)
        Me.picComputerPlayer_GoldToken5.TabIndex = 87
        Me.picComputerPlayer_GoldToken5.TabStop = False
        '
        'picComputerPlayer_GoldToken4
        '
        Me.picComputerPlayer_GoldToken4.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayer_GoldToken4.BackgroundImage = CType(resources.GetObject("picComputerPlayer_GoldToken4.BackgroundImage"), System.Drawing.Image)
        Me.picComputerPlayer_GoldToken4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerPlayer_GoldToken4.Location = New System.Drawing.Point(231, 92)
        Me.picComputerPlayer_GoldToken4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayer_GoldToken4.Name = "picComputerPlayer_GoldToken4"
        Me.picComputerPlayer_GoldToken4.Size = New System.Drawing.Size(64, 59)
        Me.picComputerPlayer_GoldToken4.TabIndex = 88
        Me.picComputerPlayer_GoldToken4.TabStop = False
        '
        'picComputerPlayer_GoldToken2
        '
        Me.picComputerPlayer_GoldToken2.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayer_GoldToken2.BackgroundImage = CType(resources.GetObject("picComputerPlayer_GoldToken2.BackgroundImage"), System.Drawing.Image)
        Me.picComputerPlayer_GoldToken2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerPlayer_GoldToken2.Location = New System.Drawing.Point(87, 92)
        Me.picComputerPlayer_GoldToken2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayer_GoldToken2.Name = "picComputerPlayer_GoldToken2"
        Me.picComputerPlayer_GoldToken2.Size = New System.Drawing.Size(64, 59)
        Me.picComputerPlayer_GoldToken2.TabIndex = 90
        Me.picComputerPlayer_GoldToken2.TabStop = False
        '
        'picComputerPlayer_GoldToken1
        '
        Me.picComputerPlayer_GoldToken1.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayer_GoldToken1.BackgroundImage = CType(resources.GetObject("picComputerPlayer_GoldToken1.BackgroundImage"), System.Drawing.Image)
        Me.picComputerPlayer_GoldToken1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerPlayer_GoldToken1.Location = New System.Drawing.Point(15, 92)
        Me.picComputerPlayer_GoldToken1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayer_GoldToken1.Name = "picComputerPlayer_GoldToken1"
        Me.picComputerPlayer_GoldToken1.Size = New System.Drawing.Size(64, 59)
        Me.picComputerPlayer_GoldToken1.TabIndex = 91
        Me.picComputerPlayer_GoldToken1.TabStop = False
        '
        'lblPlayerTwoTokens
        '
        Me.lblPlayerTwoTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTwoTokens.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTwoTokens.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerTwoTokens.Location = New System.Drawing.Point(8, 41)
        Me.lblPlayerTwoTokens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTwoTokens.Name = "lblPlayerTwoTokens"
        Me.lblPlayerTwoTokens.Size = New System.Drawing.Size(359, 48)
        Me.lblPlayerTwoTokens.TabIndex = 92
        Me.lblPlayerTwoTokens.Text = "Tokens: 0"
        '
        'picComputerPlayerMarker
        '
        Me.picComputerPlayerMarker.BackColor = System.Drawing.Color.Transparent
        Me.picComputerPlayerMarker.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.TicTacToe_O
        Me.picComputerPlayerMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picComputerPlayerMarker.Location = New System.Drawing.Point(128, 198)
        Me.picComputerPlayerMarker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picComputerPlayerMarker.Name = "picComputerPlayerMarker"
        Me.picComputerPlayerMarker.Size = New System.Drawing.Size(120, 122)
        Me.picComputerPlayerMarker.TabIndex = 132
        Me.picComputerPlayerMarker.TabStop = False
        '
        'picTopLeft
        '
        Me.picTopLeft.BackColor = System.Drawing.Color.Transparent
        Me.picTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picTopLeft.Location = New System.Drawing.Point(479, 194)
        Me.picTopLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTopLeft.Name = "picTopLeft"
        Me.picTopLeft.Size = New System.Drawing.Size(120, 122)
        Me.picTopLeft.TabIndex = 155
        Me.picTopLeft.TabStop = False
        '
        'picTicTacToeWinner
        '
        Me.picTicTacToeWinner.BackColor = System.Drawing.Color.Transparent
        Me.picTicTacToeWinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picTicTacToeWinner.Location = New System.Drawing.Point(424, 158)
        Me.picTicTacToeWinner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTicTacToeWinner.Name = "picTicTacToeWinner"
        Me.picTicTacToeWinner.Size = New System.Drawing.Size(591, 486)
        Me.picTicTacToeWinner.TabIndex = 171
        Me.picTicTacToeWinner.TabStop = False
        Me.picTicTacToeWinner.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Start_Button
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Location = New System.Drawing.Point(663, 684)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 98)
        Me.btnStart.TabIndex = 172
        Me.btnStart.TabStop = False
        '
        'btnMuteUnMute
        '
        Me.btnMuteUnMute.BackColor = System.Drawing.Color.Transparent
        Me.btnMuteUnMute.BackgroundImage = CType(resources.GetObject("btnMuteUnMute.BackgroundImage"), System.Drawing.Image)
        Me.btnMuteUnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMuteUnMute.Location = New System.Drawing.Point(16, 828)
        Me.btnMuteUnMute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMuteUnMute.Name = "btnMuteUnMute"
        Me.btnMuteUnMute.Size = New System.Drawing.Size(69, 64)
        Me.btnMuteUnMute.TabIndex = 168
        Me.btnMuteUnMute.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Settings_Button
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Location = New System.Drawing.Point(1356, 828)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(69, 64)
        Me.btnSettings.TabIndex = 166
        Me.btnSettings.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1440, 876)
        Me.PictureBox2.TabIndex = 170
        Me.PictureBox2.TabStop = False
        '
        'picMiddleCenter
        '
        Me.picMiddleCenter.BackColor = System.Drawing.Color.Transparent
        Me.picMiddleCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picMiddleCenter.Location = New System.Drawing.Point(649, 350)
        Me.picMiddleCenter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMiddleCenter.Name = "picMiddleCenter"
        Me.picMiddleCenter.Size = New System.Drawing.Size(120, 122)
        Me.picMiddleCenter.TabIndex = 154
        Me.picMiddleCenter.TabStop = False
        '
        'picMiddleLeft
        '
        Me.picMiddleLeft.BackColor = System.Drawing.Color.Transparent
        Me.picMiddleLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picMiddleLeft.Location = New System.Drawing.Point(479, 350)
        Me.picMiddleLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMiddleLeft.Name = "picMiddleLeft"
        Me.picMiddleLeft.Size = New System.Drawing.Size(120, 122)
        Me.picMiddleLeft.TabIndex = 157
        Me.picMiddleLeft.TabStop = False
        '
        'picBottomLeft
        '
        Me.picBottomLeft.BackColor = System.Drawing.Color.Transparent
        Me.picBottomLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBottomLeft.Location = New System.Drawing.Point(479, 496)
        Me.picBottomLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBottomLeft.Name = "picBottomLeft"
        Me.picBottomLeft.Size = New System.Drawing.Size(120, 122)
        Me.picBottomLeft.TabIndex = 153
        Me.picBottomLeft.TabStop = False
        '
        'picBottomCenter
        '
        Me.picBottomCenter.BackColor = System.Drawing.Color.Transparent
        Me.picBottomCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBottomCenter.Location = New System.Drawing.Point(649, 496)
        Me.picBottomCenter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBottomCenter.Name = "picBottomCenter"
        Me.picBottomCenter.Size = New System.Drawing.Size(120, 122)
        Me.picBottomCenter.TabIndex = 152
        Me.picBottomCenter.TabStop = False
        '
        'picBottomRight
        '
        Me.picBottomRight.BackColor = System.Drawing.Color.Transparent
        Me.picBottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBottomRight.Location = New System.Drawing.Point(820, 496)
        Me.picBottomRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBottomRight.Name = "picBottomRight"
        Me.picBottomRight.Size = New System.Drawing.Size(120, 122)
        Me.picBottomRight.TabIndex = 151
        Me.picBottomRight.TabStop = False
        '
        'picMiddleRight
        '
        Me.picMiddleRight.BackColor = System.Drawing.Color.Transparent
        Me.picMiddleRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picMiddleRight.Location = New System.Drawing.Point(815, 348)
        Me.picMiddleRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMiddleRight.Name = "picMiddleRight"
        Me.picMiddleRight.Size = New System.Drawing.Size(120, 122)
        Me.picMiddleRight.TabIndex = 149
        Me.picMiddleRight.TabStop = False
        '
        'picTopRight
        '
        Me.picTopRight.BackColor = System.Drawing.Color.Transparent
        Me.picTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picTopRight.Location = New System.Drawing.Point(820, 194)
        Me.picTopRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTopRight.Name = "picTopRight"
        Me.picTopRight.Size = New System.Drawing.Size(120, 122)
        Me.picTopRight.TabIndex = 150
        Me.picTopRight.TabStop = False
        '
        'picTopCenter
        '
        Me.picTopCenter.BackColor = System.Drawing.Color.Transparent
        Me.picTopCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picTopCenter.Location = New System.Drawing.Point(649, 194)
        Me.picTopCenter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTopCenter.Name = "picTopCenter"
        Me.picTopCenter.Size = New System.Drawing.Size(120, 122)
        Me.picTopCenter.TabIndex = 158
        Me.picTopCenter.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Minimize_Button
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Location = New System.Drawing.Point(1163, -4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 31)
        Me.btnMinimize.TabIndex = 145
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Maximize_Button_Disabled
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Location = New System.Drawing.Point(1231, -4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(75, 31)
        Me.btnMaximize.TabIndex = 146
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Close_Button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1301, -4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 31)
        Me.btnClose.TabIndex = 147
        Me.btnClose.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Info_Button
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Location = New System.Drawing.Point(1357, 32)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(69, 64)
        Me.btnInfo.TabIndex = 142
        Me.btnInfo.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Return_Button
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.Location = New System.Drawing.Point(16, 31)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(69, 64)
        Me.btnReturn.TabIndex = 141
        Me.btnReturn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.TicTacToe_FormBackground
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1440, 0)
        Me.PictureBox1.TabIndex = 140
        Me.PictureBox1.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.HangMan_Player
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(1029, 239)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(379, 363)
        Me.PictureBox11.TabIndex = 161
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.HangMan_Player
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(21, 239)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(379, 363)
        Me.PictureBox12.TabIndex = 160
        Me.PictureBox12.TabStop = False
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'CaptionTimer
        '
        '
        'frmTicTacToeTwoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.TicTacToe_Board
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 907)
        Me.Controls.Add(Me.picTicTacToeWinner)
        Me.Controls.Add(Me.lblPlayerTwo)
        Me.Controls.Add(Me.lblPlayerOne)
        Me.Controls.Add(Me.picTopLeft)
        Me.Controls.Add(Me.lblMute)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnMuteUnMute)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bxCorrectWords)
        Me.Controls.Add(Me.picMiddleCenter)
        Me.Controls.Add(Me.picMiddleLeft)
        Me.Controls.Add(Me.picBottomLeft)
        Me.Controls.Add(Me.picBottomCenter)
        Me.Controls.Add(Me.picBottomRight)
        Me.Controls.Add(Me.picMiddleRight)
        Me.Controls.Add(Me.picTopRight)
        Me.Controls.Add(Me.picTopCenter)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblLeaveGame)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bxIncorrectWords)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTicTacToeTwoPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tic Tac Toe - Two Player"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bxCorrectWords.ResumeLayout(False)
        CType(Me.picPlayerOneStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerOneMarker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1_GoldToken3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1_GoldToken5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1_GoldToken4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1_GoldToken2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1_GoldToken1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bxIncorrectWords.ResumeLayout(False)
        CType(Me.picPlayerTwoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayer_GoldToken3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayer_GoldToken5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayer_GoldToken4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayer_GoldToken2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayer_GoldToken1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerPlayerMarker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTicTacToeWinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiddleCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiddleLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiddleRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayerTwoStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerTwo As System.Windows.Forms.Label
    Friend WithEvents lblPlayerOne As System.Windows.Forms.Label
    Friend WithEvents picComputerPlayer_GoldToken3 As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerPlayer_GoldToken5 As System.Windows.Forms.PictureBox
    Friend WithEvents picTopLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1_GoldToken5 As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerPlayer_GoldToken4 As System.Windows.Forms.PictureBox
    Friend WithEvents picTicTacToeWinner As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerPlayer_GoldToken2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMute As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1_GoldToken3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMuteUnMute As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1_GoldToken4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picPlayerOneStatus As System.Windows.Forms.PictureBox
    Friend WithEvents bxCorrectWords As System.Windows.Forms.GroupBox
    Friend WithEvents picPlayer1_GoldToken2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1_GoldToken1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerOneTokens As System.Windows.Forms.Label
    Friend WithEvents DisplayTimer As System.Windows.Forms.Timer
    Friend WithEvents WinnerSoundTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picMiddleCenter As System.Windows.Forms.PictureBox
    Friend WithEvents picMiddleLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picBottomLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerPlayerMarker As System.Windows.Forms.PictureBox
    Friend WithEvents picBottomCenter As System.Windows.Forms.PictureBox
    Friend WithEvents picBottomRight As System.Windows.Forms.PictureBox
    Friend WithEvents picMiddleRight As System.Windows.Forms.PictureBox
    Friend WithEvents picTopRight As System.Windows.Forms.PictureBox
    Friend WithEvents picTopCenter As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblLeaveGame As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturn As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bxIncorrectWords As System.Windows.Forms.GroupBox
    Friend WithEvents picComputerPlayer_GoldToken1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerTwoTokens As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerOneMarker As System.Windows.Forms.PictureBox
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents CaptionTimer As System.Windows.Forms.Timer
End Class

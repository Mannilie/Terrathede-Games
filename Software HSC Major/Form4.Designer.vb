<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangmanTwoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangmanTwoPlayer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picGameStatus = New System.Windows.Forms.PictureBox()
        Me.Player1_GoldToken1 = New System.Windows.Forms.PictureBox()
        Me.Player1_GoldToken2 = New System.Windows.Forms.PictureBox()
        Me.Player1_GoldToken3 = New System.Windows.Forms.PictureBox()
        Me.Player1_GoldToken4 = New System.Windows.Forms.PictureBox()
        Me.Player1_GoldToken5 = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblLeaveGame = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.PictureBox()
        Me.bxLetters = New System.Windows.Forms.GroupBox()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.lblPlayerOneTokens = New System.Windows.Forms.Label()
        Me.lblPlayerOneLives = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.bxPlayer1 = New System.Windows.Forms.GroupBox()
        Me.picPlayerOneToken = New System.Windows.Forms.PictureBox()
        Me.Player1_Life8 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life10 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life9 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life7 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life6 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life3 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life5 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life4 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life2 = New System.Windows.Forms.PictureBox()
        Me.Player1_Life1 = New System.Windows.Forms.PictureBox()
        Me.PicPlayerOneStatus = New System.Windows.Forms.PictureBox()
        Me.bxPlayer2 = New System.Windows.Forms.GroupBox()
        Me.picPlayerTwoToken = New System.Windows.Forms.PictureBox()
        Me.Player2_Life8 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life10 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life9 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life7 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life6 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life3 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life5 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life4 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life2 = New System.Windows.Forms.PictureBox()
        Me.Player2_Life1 = New System.Windows.Forms.PictureBox()
        Me.Player2_GoldToken3 = New System.Windows.Forms.PictureBox()
        Me.Player2_GoldToken5 = New System.Windows.Forms.PictureBox()
        Me.Player2_GoldToken4 = New System.Windows.Forms.PictureBox()
        Me.Player2_GoldToken2 = New System.Windows.Forms.PictureBox()
        Me.Player2_GoldToken1 = New System.Windows.Forms.PictureBox()
        Me.lblPlayerTwoLives = New System.Windows.Forms.Label()
        Me.lblPlayerTwoTokens = New System.Windows.Forms.Label()
        Me.PicPlayerTwoStatus = New System.Windows.Forms.PictureBox()
        Me.CountDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lstSymbol = New System.Windows.Forms.ListBox()
        Me.lblPlayerOne = New System.Windows.Forms.Label()
        Me.lblPlayerTwo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LifeFlashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TokenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WinnerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CaptionTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_GoldToken1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_GoldToken2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_GoldToken3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_GoldToken4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_GoldToken5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bxLetters.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bxPlayer1.SuspendLayout()
        CType(Me.picPlayerOneToken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1_Life1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayerOneStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bxPlayer2.SuspendLayout()
        CType(Me.picPlayerTwoToken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_Life1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_GoldToken3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_GoldToken5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_GoldToken4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_GoldToken2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2_GoldToken1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayerTwoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1440, 878)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'picGameStatus
        '
        Me.picGameStatus.BackColor = System.Drawing.Color.Transparent
        Me.picGameStatus.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.HangMan_Player
        Me.picGameStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picGameStatus.Location = New System.Drawing.Point(412, 98)
        Me.picGameStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picGameStatus.Name = "picGameStatus"
        Me.picGameStatus.Size = New System.Drawing.Size(616, 523)
        Me.picGameStatus.TabIndex = 64
        Me.picGameStatus.TabStop = False
        '
        'Player1_GoldToken1
        '
        Me.Player1_GoldToken1.BackColor = System.Drawing.Color.Transparent
        Me.Player1_GoldToken1.BackgroundImage = CType(resources.GetObject("Player1_GoldToken1.BackgroundImage"), System.Drawing.Image)
        Me.Player1_GoldToken1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_GoldToken1.Location = New System.Drawing.Point(15, 94)
        Me.Player1_GoldToken1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_GoldToken1.Name = "Player1_GoldToken1"
        Me.Player1_GoldToken1.Size = New System.Drawing.Size(64, 59)
        Me.Player1_GoldToken1.TabIndex = 70
        Me.Player1_GoldToken1.TabStop = False
        '
        'Player1_GoldToken2
        '
        Me.Player1_GoldToken2.BackColor = System.Drawing.Color.Transparent
        Me.Player1_GoldToken2.BackgroundImage = CType(resources.GetObject("Player1_GoldToken2.BackgroundImage"), System.Drawing.Image)
        Me.Player1_GoldToken2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_GoldToken2.Location = New System.Drawing.Point(87, 94)
        Me.Player1_GoldToken2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_GoldToken2.Name = "Player1_GoldToken2"
        Me.Player1_GoldToken2.Size = New System.Drawing.Size(64, 59)
        Me.Player1_GoldToken2.TabIndex = 69
        Me.Player1_GoldToken2.TabStop = False
        '
        'Player1_GoldToken3
        '
        Me.Player1_GoldToken3.BackColor = System.Drawing.Color.Transparent
        Me.Player1_GoldToken3.BackgroundImage = CType(resources.GetObject("Player1_GoldToken3.BackgroundImage"), System.Drawing.Image)
        Me.Player1_GoldToken3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_GoldToken3.Location = New System.Drawing.Point(159, 94)
        Me.Player1_GoldToken3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_GoldToken3.Name = "Player1_GoldToken3"
        Me.Player1_GoldToken3.Size = New System.Drawing.Size(64, 59)
        Me.Player1_GoldToken3.TabIndex = 68
        Me.Player1_GoldToken3.TabStop = False
        '
        'Player1_GoldToken4
        '
        Me.Player1_GoldToken4.BackColor = System.Drawing.Color.Transparent
        Me.Player1_GoldToken4.BackgroundImage = CType(resources.GetObject("Player1_GoldToken4.BackgroundImage"), System.Drawing.Image)
        Me.Player1_GoldToken4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_GoldToken4.Location = New System.Drawing.Point(231, 94)
        Me.Player1_GoldToken4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_GoldToken4.Name = "Player1_GoldToken4"
        Me.Player1_GoldToken4.Size = New System.Drawing.Size(64, 59)
        Me.Player1_GoldToken4.TabIndex = 67
        Me.Player1_GoldToken4.TabStop = False
        '
        'Player1_GoldToken5
        '
        Me.Player1_GoldToken5.BackColor = System.Drawing.Color.Transparent
        Me.Player1_GoldToken5.BackgroundImage = CType(resources.GetObject("Player1_GoldToken5.BackgroundImage"), System.Drawing.Image)
        Me.Player1_GoldToken5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_GoldToken5.Location = New System.Drawing.Point(303, 94)
        Me.Player1_GoldToken5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_GoldToken5.Name = "Player1_GoldToken5"
        Me.Player1_GoldToken5.Size = New System.Drawing.Size(64, 59)
        Me.Player1_GoldToken5.TabIndex = 65
        Me.Player1_GoldToken5.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(1193, 47)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(156, 33)
        Me.lblInfo.TabIndex = 75
        Me.lblInfo.Text = "Information"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblInfo.Visible = False
        '
        'lblLeaveGame
        '
        Me.lblLeaveGame.BackColor = System.Drawing.Color.Transparent
        Me.lblLeaveGame.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaveGame.Location = New System.Drawing.Point(87, 49)
        Me.lblLeaveGame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeaveGame.Name = "lblLeaveGame"
        Me.lblLeaveGame.Size = New System.Drawing.Size(156, 33)
        Me.lblLeaveGame.TabIndex = 74
        Me.lblLeaveGame.Text = "Leave Game"
        Me.lblLeaveGame.Visible = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImage = CType(resources.GetObject("btnInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Location = New System.Drawing.Point(1357, 32)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(69, 64)
        Me.btnInfo.TabIndex = 73
        Me.btnInfo.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.Location = New System.Drawing.Point(12, 32)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(69, 64)
        Me.btnReturn.TabIndex = 72
        Me.btnReturn.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Start_Button
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Location = New System.Drawing.Point(664, 613)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 98)
        Me.btnStart.TabIndex = 78
        Me.btnStart.TabStop = False
        '
        'bxLetters
        '
        Me.bxLetters.BackColor = System.Drawing.Color.Transparent
        Me.bxLetters.Controls.Add(Me.btnX)
        Me.bxLetters.Controls.Add(Me.btnW)
        Me.bxLetters.Controls.Add(Me.btnV)
        Me.bxLetters.Controls.Add(Me.btnU)
        Me.bxLetters.Controls.Add(Me.btnT)
        Me.bxLetters.Controls.Add(Me.btnS)
        Me.bxLetters.Controls.Add(Me.btnY)
        Me.bxLetters.Controls.Add(Me.btnZ)
        Me.bxLetters.Controls.Add(Me.btnQ)
        Me.bxLetters.Controls.Add(Me.btnP)
        Me.bxLetters.Controls.Add(Me.btnO)
        Me.bxLetters.Controls.Add(Me.btnM)
        Me.bxLetters.Controls.Add(Me.btnN)
        Me.bxLetters.Controls.Add(Me.btnL)
        Me.bxLetters.Controls.Add(Me.btnK)
        Me.bxLetters.Controls.Add(Me.btnJ)
        Me.bxLetters.Controls.Add(Me.btnR)
        Me.bxLetters.Controls.Add(Me.btnI)
        Me.bxLetters.Controls.Add(Me.btnH)
        Me.bxLetters.Controls.Add(Me.btnG)
        Me.bxLetters.Controls.Add(Me.btnF)
        Me.bxLetters.Controls.Add(Me.btnE)
        Me.bxLetters.Controls.Add(Me.btnD)
        Me.bxLetters.Controls.Add(Me.btnC)
        Me.bxLetters.Controls.Add(Me.btnB)
        Me.bxLetters.Controls.Add(Me.btnA)
        Me.bxLetters.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxLetters.Location = New System.Drawing.Point(133, 702)
        Me.bxLetters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxLetters.Name = "bxLetters"
        Me.bxLetters.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxLetters.Size = New System.Drawing.Size(1185, 165)
        Me.bxLetters.TabIndex = 76
        Me.bxLetters.TabStop = False
        Me.bxLetters.Text = "Choose the letter from below"
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Silver
        Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Location = New System.Drawing.Point(731, 116)
        Me.btnX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(123, 37)
        Me.btnX.TabIndex = 26
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnW
        '
        Me.btnW.BackColor = System.Drawing.Color.Silver
        Me.btnW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW.Location = New System.Drawing.Point(601, 116)
        Me.btnW.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(123, 37)
        Me.btnW.TabIndex = 25
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = False
        '
        'btnV
        '
        Me.btnV.BackColor = System.Drawing.Color.Silver
        Me.btnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.Location = New System.Drawing.Point(472, 116)
        Me.btnV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(123, 37)
        Me.btnV.TabIndex = 24
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = False
        '
        'btnU
        '
        Me.btnU.BackColor = System.Drawing.Color.Silver
        Me.btnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Location = New System.Drawing.Point(343, 116)
        Me.btnU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(123, 37)
        Me.btnU.TabIndex = 23
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = False
        '
        'btnT
        '
        Me.btnT.BackColor = System.Drawing.Color.Silver
        Me.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.Location = New System.Drawing.Point(213, 116)
        Me.btnT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(123, 37)
        Me.btnT.TabIndex = 22
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.Silver
        Me.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.Location = New System.Drawing.Point(84, 116)
        Me.btnS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(123, 37)
        Me.btnS.TabIndex = 21
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnY
        '
        Me.btnY.BackColor = System.Drawing.Color.Silver
        Me.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnY.Location = New System.Drawing.Point(860, 116)
        Me.btnY.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(123, 37)
        Me.btnY.TabIndex = 20
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = False
        '
        'btnZ
        '
        Me.btnZ.BackColor = System.Drawing.Color.Silver
        Me.btnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZ.Location = New System.Drawing.Point(989, 116)
        Me.btnZ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(123, 37)
        Me.btnZ.TabIndex = 19
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = False
        '
        'btnQ
        '
        Me.btnQ.BackColor = System.Drawing.Color.Silver
        Me.btnQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQ.Location = New System.Drawing.Point(919, 73)
        Me.btnQ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(123, 37)
        Me.btnQ.TabIndex = 18
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.BackColor = System.Drawing.Color.Silver
        Me.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP.Location = New System.Drawing.Point(789, 73)
        Me.btnP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(123, 37)
        Me.btnP.TabIndex = 17
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'btnO
        '
        Me.btnO.BackColor = System.Drawing.Color.Silver
        Me.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnO.Location = New System.Drawing.Point(660, 73)
        Me.btnO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(123, 37)
        Me.btnO.TabIndex = 16
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.Silver
        Me.btnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM.Location = New System.Drawing.Point(401, 73)
        Me.btnM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(123, 37)
        Me.btnM.TabIndex = 15
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'btnN
        '
        Me.btnN.BackColor = System.Drawing.Color.Silver
        Me.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnN.Location = New System.Drawing.Point(531, 73)
        Me.btnN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(123, 37)
        Me.btnN.TabIndex = 15
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnL
        '
        Me.btnL.BackColor = System.Drawing.Color.Silver
        Me.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnL.Location = New System.Drawing.Point(272, 73)
        Me.btnL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(123, 37)
        Me.btnL.TabIndex = 14
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = False
        '
        'btnK
        '
        Me.btnK.BackColor = System.Drawing.Color.Silver
        Me.btnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnK.Location = New System.Drawing.Point(143, 73)
        Me.btnK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(123, 37)
        Me.btnK.TabIndex = 13
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = False
        '
        'btnJ
        '
        Me.btnJ.BackColor = System.Drawing.Color.Silver
        Me.btnJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJ.Location = New System.Drawing.Point(13, 73)
        Me.btnJ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(123, 37)
        Me.btnJ.TabIndex = 12
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.Silver
        Me.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR.Location = New System.Drawing.Point(1048, 73)
        Me.btnR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(123, 37)
        Me.btnR.TabIndex = 11
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnI
        '
        Me.btnI.BackColor = System.Drawing.Color.Silver
        Me.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnI.Location = New System.Drawing.Point(1048, 28)
        Me.btnI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(123, 37)
        Me.btnI.TabIndex = 10
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = False
        '
        'btnH
        '
        Me.btnH.BackColor = System.Drawing.Color.Silver
        Me.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnH.Location = New System.Drawing.Point(919, 28)
        Me.btnH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(123, 37)
        Me.btnH.TabIndex = 9
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = False
        '
        'btnG
        '
        Me.btnG.BackColor = System.Drawing.Color.Silver
        Me.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG.Location = New System.Drawing.Point(789, 28)
        Me.btnG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(123, 37)
        Me.btnG.TabIndex = 8
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = False
        '
        'btnF
        '
        Me.btnF.BackColor = System.Drawing.Color.Silver
        Me.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF.Location = New System.Drawing.Point(660, 28)
        Me.btnF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(123, 37)
        Me.btnF.TabIndex = 7
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = False
        '
        'btnE
        '
        Me.btnE.BackColor = System.Drawing.Color.Silver
        Me.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnE.Location = New System.Drawing.Point(531, 28)
        Me.btnE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(123, 37)
        Me.btnE.TabIndex = 6
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Silver
        Me.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Location = New System.Drawing.Point(401, 28)
        Me.btnD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(123, 37)
        Me.btnD.TabIndex = 5
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Silver
        Me.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Location = New System.Drawing.Point(272, 28)
        Me.btnC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(123, 37)
        Me.btnC.TabIndex = 4
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.Silver
        Me.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Location = New System.Drawing.Point(143, 28)
        Me.btnB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(123, 37)
        Me.btnB.TabIndex = 3
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Silver
        Me.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Location = New System.Drawing.Point(13, 28)
        Me.btnA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(123, 37)
        Me.btnA.TabIndex = 2
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'lblGuess
        '
        Me.lblGuess.BackColor = System.Drawing.Color.Transparent
        Me.lblGuess.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.Location = New System.Drawing.Point(0, 625)
        Me.lblGuess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(1440, 73)
        Me.lblGuess.TabIndex = 77
        Me.lblGuess.Text = "Game Starting..."
        Me.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGuess.Visible = False
        '
        'lblPlayerOneTokens
        '
        Me.lblPlayerOneTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerOneTokens.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOneTokens.Location = New System.Drawing.Point(8, 42)
        Me.lblPlayerOneTokens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerOneTokens.Name = "lblPlayerOneTokens"
        Me.lblPlayerOneTokens.Size = New System.Drawing.Size(359, 48)
        Me.lblPlayerOneTokens.TabIndex = 80
        Me.lblPlayerOneTokens.Text = "Tokens: 0"
        '
        'lblPlayerOneLives
        '
        Me.lblPlayerOneLives.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerOneLives.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOneLives.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerOneLives.Location = New System.Drawing.Point(8, 169)
        Me.lblPlayerOneLives.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerOneLives.Name = "lblPlayerOneLives"
        Me.lblPlayerOneLives.Size = New System.Drawing.Size(352, 48)
        Me.lblPlayerOneLives.TabIndex = 90
        Me.lblPlayerOneLives.Text = "10 Lives Remaining"
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Location = New System.Drawing.Point(1163, -4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 32)
        Me.btnMinimize.TabIndex = 92
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
        Me.btnMaximize.Size = New System.Drawing.Size(75, 32)
        Me.btnMaximize.TabIndex = 93
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1301, -4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 94
        Me.btnClose.TabStop = False
        '
        'bxPlayer1
        '
        Me.bxPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.bxPlayer1.Controls.Add(Me.picPlayerOneToken)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life8)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life10)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life9)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life7)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life6)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life3)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life5)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life4)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life2)
        Me.bxPlayer1.Controls.Add(Me.Player1_Life1)
        Me.bxPlayer1.Controls.Add(Me.Player1_GoldToken3)
        Me.bxPlayer1.Controls.Add(Me.Player1_GoldToken5)
        Me.bxPlayer1.Controls.Add(Me.Player1_GoldToken4)
        Me.bxPlayer1.Controls.Add(Me.Player1_GoldToken2)
        Me.bxPlayer1.Controls.Add(Me.Player1_GoldToken1)
        Me.bxPlayer1.Controls.Add(Me.lblPlayerOneLives)
        Me.bxPlayer1.Controls.Add(Me.lblPlayerOneTokens)
        Me.bxPlayer1.Controls.Add(Me.PicPlayerOneStatus)
        Me.bxPlayer1.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxPlayer1.ForeColor = System.Drawing.Color.Black
        Me.bxPlayer1.Location = New System.Drawing.Point(25, 178)
        Me.bxPlayer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxPlayer1.Name = "bxPlayer1"
        Me.bxPlayer1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bxPlayer1.Size = New System.Drawing.Size(379, 357)
        Me.bxPlayer1.TabIndex = 77
        Me.bxPlayer1.TabStop = False
        '
        'picPlayerOneToken
        '
        Me.picPlayerOneToken.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerOneToken.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Token_Player
        Me.picPlayerOneToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerOneToken.Location = New System.Drawing.Point(15, 155)
        Me.picPlayerOneToken.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerOneToken.Name = "picPlayerOneToken"
        Me.picPlayerOneToken.Size = New System.Drawing.Size(352, 198)
        Me.picPlayerOneToken.TabIndex = 140
        Me.picPlayerOneToken.TabStop = False
        Me.picPlayerOneToken.Visible = False
        '
        'Player1_Life8
        '
        Me.Player1_Life8.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life8.BackgroundImage = CType(resources.GetObject("Player1_Life8.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life8.Location = New System.Drawing.Point(159, 287)
        Me.Player1_Life8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life8.Name = "Player1_Life8"
        Me.Player1_Life8.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life8.TabIndex = 99
        Me.Player1_Life8.TabStop = False
        '
        'Player1_Life10
        '
        Me.Player1_Life10.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life10.BackgroundImage = CType(resources.GetObject("Player1_Life10.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life10.Location = New System.Drawing.Point(303, 287)
        Me.Player1_Life10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life10.Name = "Player1_Life10"
        Me.Player1_Life10.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life10.TabIndex = 97
        Me.Player1_Life10.TabStop = False
        '
        'Player1_Life9
        '
        Me.Player1_Life9.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life9.BackgroundImage = CType(resources.GetObject("Player1_Life9.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life9.Location = New System.Drawing.Point(231, 287)
        Me.Player1_Life9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life9.Name = "Player1_Life9"
        Me.Player1_Life9.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life9.TabIndex = 98
        Me.Player1_Life9.TabStop = False
        '
        'Player1_Life7
        '
        Me.Player1_Life7.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life7.BackgroundImage = CType(resources.GetObject("Player1_Life7.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life7.Location = New System.Drawing.Point(87, 287)
        Me.Player1_Life7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life7.Name = "Player1_Life7"
        Me.Player1_Life7.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life7.TabIndex = 100
        Me.Player1_Life7.TabStop = False
        '
        'Player1_Life6
        '
        Me.Player1_Life6.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life6.BackgroundImage = CType(resources.GetObject("Player1_Life6.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life6.Location = New System.Drawing.Point(15, 287)
        Me.Player1_Life6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life6.Name = "Player1_Life6"
        Me.Player1_Life6.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life6.TabIndex = 101
        Me.Player1_Life6.TabStop = False
        '
        'Player1_Life3
        '
        Me.Player1_Life3.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life3.BackgroundImage = CType(resources.GetObject("Player1_Life3.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life3.Location = New System.Drawing.Point(159, 220)
        Me.Player1_Life3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life3.Name = "Player1_Life3"
        Me.Player1_Life3.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life3.TabIndex = 93
        Me.Player1_Life3.TabStop = False
        '
        'Player1_Life5
        '
        Me.Player1_Life5.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life5.BackgroundImage = CType(resources.GetObject("Player1_Life5.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life5.Location = New System.Drawing.Point(303, 220)
        Me.Player1_Life5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life5.Name = "Player1_Life5"
        Me.Player1_Life5.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life5.TabIndex = 91
        Me.Player1_Life5.TabStop = False
        '
        'Player1_Life4
        '
        Me.Player1_Life4.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life4.BackgroundImage = CType(resources.GetObject("Player1_Life4.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life4.Location = New System.Drawing.Point(231, 220)
        Me.Player1_Life4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life4.Name = "Player1_Life4"
        Me.Player1_Life4.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life4.TabIndex = 92
        Me.Player1_Life4.TabStop = False
        '
        'Player1_Life2
        '
        Me.Player1_Life2.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life2.BackgroundImage = CType(resources.GetObject("Player1_Life2.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life2.Location = New System.Drawing.Point(87, 220)
        Me.Player1_Life2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life2.Name = "Player1_Life2"
        Me.Player1_Life2.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life2.TabIndex = 94
        Me.Player1_Life2.TabStop = False
        '
        'Player1_Life1
        '
        Me.Player1_Life1.BackColor = System.Drawing.Color.Transparent
        Me.Player1_Life1.BackgroundImage = CType(resources.GetObject("Player1_Life1.BackgroundImage"), System.Drawing.Image)
        Me.Player1_Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1_Life1.Location = New System.Drawing.Point(15, 220)
        Me.Player1_Life1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1_Life1.Name = "Player1_Life1"
        Me.Player1_Life1.Size = New System.Drawing.Size(64, 59)
        Me.Player1_Life1.TabIndex = 95
        Me.Player1_Life1.TabStop = False
        '
        'PicPlayerOneStatus
        '
        Me.PicPlayerOneStatus.Location = New System.Drawing.Point(3, 20)
        Me.PicPlayerOneStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicPlayerOneStatus.Name = "PicPlayerOneStatus"
        Me.PicPlayerOneStatus.Size = New System.Drawing.Size(373, 336)
        Me.PicPlayerOneStatus.TabIndex = 96
        Me.PicPlayerOneStatus.TabStop = False
        '
        'bxPlayer2
        '
        Me.bxPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.bxPlayer2.Controls.Add(Me.picPlayerTwoToken)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life8)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life10)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life9)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life7)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life6)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life3)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life5)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life4)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life2)
        Me.bxPlayer2.Controls.Add(Me.Player2_Life1)
        Me.bxPlayer2.Controls.Add(Me.Player2_GoldToken3)
        Me.bxPlayer2.Controls.Add(Me.Player2_GoldToken5)
        Me.bxPlayer2.Controls.Add(Me.Player2_GoldToken4)
        Me.bxPlayer2.Controls.Add(Me.Player2_GoldToken2)
        Me.bxPlayer2.Controls.Add(Me.Player2_GoldToken1)
        Me.bxPlayer2.Controls.Add(Me.lblPlayerTwoLives)
        Me.bxPlayer2.Controls.Add(Me.lblPlayerTwoTokens)
        Me.bxPlayer2.Controls.Add(Me.PicPlayerTwoStatus)
        Me.bxPlayer2.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxPlayer2.ForeColor = System.Drawing.Color.DarkRed
        Me.bxPlayer2.Location = New System.Drawing.Point(1035, 178)
        Me.bxPlayer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxPlayer2.Name = "bxPlayer2"
        Me.bxPlayer2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bxPlayer2.Size = New System.Drawing.Size(379, 357)
        Me.bxPlayer2.TabIndex = 91
        Me.bxPlayer2.TabStop = False
        '
        'picPlayerTwoToken
        '
        Me.picPlayerTwoToken.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerTwoToken.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Token_Player
        Me.picPlayerTwoToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerTwoToken.Location = New System.Drawing.Point(15, 155)
        Me.picPlayerTwoToken.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerTwoToken.Name = "picPlayerTwoToken"
        Me.picPlayerTwoToken.Size = New System.Drawing.Size(352, 198)
        Me.picPlayerTwoToken.TabIndex = 141
        Me.picPlayerTwoToken.TabStop = False
        Me.picPlayerTwoToken.Visible = False
        '
        'Player2_Life8
        '
        Me.Player2_Life8.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life8.BackgroundImage = CType(resources.GetObject("Player2_Life8.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life8.Location = New System.Drawing.Point(159, 287)
        Me.Player2_Life8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life8.Name = "Player2_Life8"
        Me.Player2_Life8.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life8.TabIndex = 100
        Me.Player2_Life8.TabStop = False
        '
        'Player2_Life10
        '
        Me.Player2_Life10.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life10.BackgroundImage = CType(resources.GetObject("Player2_Life10.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life10.Location = New System.Drawing.Point(303, 287)
        Me.Player2_Life10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life10.Name = "Player2_Life10"
        Me.Player2_Life10.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life10.TabIndex = 98
        Me.Player2_Life10.TabStop = False
        '
        'Player2_Life9
        '
        Me.Player2_Life9.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life9.BackgroundImage = CType(resources.GetObject("Player2_Life9.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life9.Location = New System.Drawing.Point(231, 287)
        Me.Player2_Life9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life9.Name = "Player2_Life9"
        Me.Player2_Life9.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life9.TabIndex = 99
        Me.Player2_Life9.TabStop = False
        '
        'Player2_Life7
        '
        Me.Player2_Life7.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life7.BackgroundImage = CType(resources.GetObject("Player2_Life7.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life7.Location = New System.Drawing.Point(87, 287)
        Me.Player2_Life7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life7.Name = "Player2_Life7"
        Me.Player2_Life7.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life7.TabIndex = 101
        Me.Player2_Life7.TabStop = False
        '
        'Player2_Life6
        '
        Me.Player2_Life6.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life6.BackgroundImage = CType(resources.GetObject("Player2_Life6.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life6.Location = New System.Drawing.Point(15, 287)
        Me.Player2_Life6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life6.Name = "Player2_Life6"
        Me.Player2_Life6.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life6.TabIndex = 102
        Me.Player2_Life6.TabStop = False
        '
        'Player2_Life3
        '
        Me.Player2_Life3.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life3.BackgroundImage = CType(resources.GetObject("Player2_Life3.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life3.Location = New System.Drawing.Point(159, 220)
        Me.Player2_Life3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life3.Name = "Player2_Life3"
        Me.Player2_Life3.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life3.TabIndex = 93
        Me.Player2_Life3.TabStop = False
        '
        'Player2_Life5
        '
        Me.Player2_Life5.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life5.BackgroundImage = CType(resources.GetObject("Player2_Life5.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life5.Location = New System.Drawing.Point(303, 220)
        Me.Player2_Life5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life5.Name = "Player2_Life5"
        Me.Player2_Life5.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life5.TabIndex = 91
        Me.Player2_Life5.TabStop = False
        '
        'Player2_Life4
        '
        Me.Player2_Life4.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life4.BackgroundImage = CType(resources.GetObject("Player2_Life4.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life4.Location = New System.Drawing.Point(231, 220)
        Me.Player2_Life4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life4.Name = "Player2_Life4"
        Me.Player2_Life4.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life4.TabIndex = 92
        Me.Player2_Life4.TabStop = False
        '
        'Player2_Life2
        '
        Me.Player2_Life2.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life2.BackgroundImage = CType(resources.GetObject("Player2_Life2.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life2.Location = New System.Drawing.Point(87, 220)
        Me.Player2_Life2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life2.Name = "Player2_Life2"
        Me.Player2_Life2.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life2.TabIndex = 94
        Me.Player2_Life2.TabStop = False
        '
        'Player2_Life1
        '
        Me.Player2_Life1.BackColor = System.Drawing.Color.Transparent
        Me.Player2_Life1.BackgroundImage = CType(resources.GetObject("Player2_Life1.BackgroundImage"), System.Drawing.Image)
        Me.Player2_Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_Life1.Location = New System.Drawing.Point(15, 220)
        Me.Player2_Life1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_Life1.Name = "Player2_Life1"
        Me.Player2_Life1.Size = New System.Drawing.Size(64, 59)
        Me.Player2_Life1.TabIndex = 95
        Me.Player2_Life1.TabStop = False
        '
        'Player2_GoldToken3
        '
        Me.Player2_GoldToken3.BackColor = System.Drawing.Color.Transparent
        Me.Player2_GoldToken3.BackgroundImage = CType(resources.GetObject("Player2_GoldToken3.BackgroundImage"), System.Drawing.Image)
        Me.Player2_GoldToken3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_GoldToken3.Location = New System.Drawing.Point(159, 94)
        Me.Player2_GoldToken3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_GoldToken3.Name = "Player2_GoldToken3"
        Me.Player2_GoldToken3.Size = New System.Drawing.Size(64, 59)
        Me.Player2_GoldToken3.TabIndex = 68
        Me.Player2_GoldToken3.TabStop = False
        '
        'Player2_GoldToken5
        '
        Me.Player2_GoldToken5.BackColor = System.Drawing.Color.Transparent
        Me.Player2_GoldToken5.BackgroundImage = CType(resources.GetObject("Player2_GoldToken5.BackgroundImage"), System.Drawing.Image)
        Me.Player2_GoldToken5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_GoldToken5.Location = New System.Drawing.Point(303, 94)
        Me.Player2_GoldToken5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_GoldToken5.Name = "Player2_GoldToken5"
        Me.Player2_GoldToken5.Size = New System.Drawing.Size(64, 59)
        Me.Player2_GoldToken5.TabIndex = 65
        Me.Player2_GoldToken5.TabStop = False
        '
        'Player2_GoldToken4
        '
        Me.Player2_GoldToken4.BackColor = System.Drawing.Color.Transparent
        Me.Player2_GoldToken4.BackgroundImage = CType(resources.GetObject("Player2_GoldToken4.BackgroundImage"), System.Drawing.Image)
        Me.Player2_GoldToken4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_GoldToken4.Location = New System.Drawing.Point(231, 94)
        Me.Player2_GoldToken4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_GoldToken4.Name = "Player2_GoldToken4"
        Me.Player2_GoldToken4.Size = New System.Drawing.Size(64, 59)
        Me.Player2_GoldToken4.TabIndex = 67
        Me.Player2_GoldToken4.TabStop = False
        '
        'Player2_GoldToken2
        '
        Me.Player2_GoldToken2.BackColor = System.Drawing.Color.Transparent
        Me.Player2_GoldToken2.BackgroundImage = CType(resources.GetObject("Player2_GoldToken2.BackgroundImage"), System.Drawing.Image)
        Me.Player2_GoldToken2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_GoldToken2.Location = New System.Drawing.Point(87, 94)
        Me.Player2_GoldToken2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_GoldToken2.Name = "Player2_GoldToken2"
        Me.Player2_GoldToken2.Size = New System.Drawing.Size(64, 59)
        Me.Player2_GoldToken2.TabIndex = 69
        Me.Player2_GoldToken2.TabStop = False
        '
        'Player2_GoldToken1
        '
        Me.Player2_GoldToken1.BackColor = System.Drawing.Color.Transparent
        Me.Player2_GoldToken1.BackgroundImage = CType(resources.GetObject("Player2_GoldToken1.BackgroundImage"), System.Drawing.Image)
        Me.Player2_GoldToken1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2_GoldToken1.Location = New System.Drawing.Point(15, 94)
        Me.Player2_GoldToken1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2_GoldToken1.Name = "Player2_GoldToken1"
        Me.Player2_GoldToken1.Size = New System.Drawing.Size(64, 59)
        Me.Player2_GoldToken1.TabIndex = 70
        Me.Player2_GoldToken1.TabStop = False
        '
        'lblPlayerTwoLives
        '
        Me.lblPlayerTwoLives.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTwoLives.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTwoLives.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerTwoLives.Location = New System.Drawing.Point(8, 169)
        Me.lblPlayerTwoLives.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTwoLives.Name = "lblPlayerTwoLives"
        Me.lblPlayerTwoLives.Size = New System.Drawing.Size(352, 48)
        Me.lblPlayerTwoLives.TabIndex = 90
        Me.lblPlayerTwoLives.Text = "10 Lives Remaining"
        '
        'lblPlayerTwoTokens
        '
        Me.lblPlayerTwoTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTwoTokens.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTwoTokens.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerTwoTokens.Location = New System.Drawing.Point(8, 42)
        Me.lblPlayerTwoTokens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTwoTokens.Name = "lblPlayerTwoTokens"
        Me.lblPlayerTwoTokens.Size = New System.Drawing.Size(359, 48)
        Me.lblPlayerTwoTokens.TabIndex = 80
        Me.lblPlayerTwoTokens.Text = "Tokens: 0"
        '
        'PicPlayerTwoStatus
        '
        Me.PicPlayerTwoStatus.Location = New System.Drawing.Point(1, 20)
        Me.PicPlayerTwoStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicPlayerTwoStatus.Name = "PicPlayerTwoStatus"
        Me.PicPlayerTwoStatus.Size = New System.Drawing.Size(373, 336)
        Me.PicPlayerTwoStatus.TabIndex = 97
        Me.PicPlayerTwoStatus.TabStop = False
        '
        'CountDownTimer
        '
        Me.CountDownTimer.Interval = 1000
        '
        'lstSymbol
        '
        Me.lstSymbol.FormattingEnabled = True
        Me.lstSymbol.ItemHeight = 16
        Me.lstSymbol.Items.AddRange(New Object() {"Symbol", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "[", "]", "{", "}", "\", "|", "'", """", ":", ";", "?", "/", ".", ",", ">", "<", "`", "~"})
        Me.lstSymbol.Location = New System.Drawing.Point(1144, 505)
        Me.lstSymbol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSymbol.Name = "lstSymbol"
        Me.lstSymbol.Size = New System.Drawing.Size(159, 116)
        Me.lstSymbol.TabIndex = 95
        Me.lstSymbol.Visible = False
        '
        'lblPlayerOne
        '
        Me.lblPlayerOne.AutoEllipsis = True
        Me.lblPlayerOne.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerOne.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOne.Location = New System.Drawing.Point(25, 149)
        Me.lblPlayerOne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerOne.Name = "lblPlayerOne"
        Me.lblPlayerOne.Size = New System.Drawing.Size(379, 46)
        Me.lblPlayerOne.TabIndex = 96
        Me.lblPlayerOne.Text = "Player One"
        Me.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlayerTwo
        '
        Me.lblPlayerTwo.AutoEllipsis = True
        Me.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerTwo.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTwo.Location = New System.Drawing.Point(1035, 149)
        Me.lblPlayerTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerTwo.Name = "lblPlayerTwo"
        Me.lblPlayerTwo.Size = New System.Drawing.Size(379, 46)
        Me.lblPlayerTwo.TabIndex = 97
        Me.lblPlayerTwo.Text = "Player Two"
        Me.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.HangMan_Player
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(25, 190)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(379, 363)
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.HangMan_Player
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1035, 190)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(379, 363)
        Me.PictureBox3.TabIndex = 99
        Me.PictureBox3.TabStop = False
        '
        'LifeFlashTimer
        '
        '
        'TokenTimer
        '
        Me.TokenTimer.Interval = 2000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Hangman - Two Player"
        '
        'DisplayTimer
        '
        Me.DisplayTimer.Interval = 1000
        '
        'WinnerTimer
        '
        Me.WinnerTimer.Interval = 1000
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'CaptionTimer
        '
        '
        'frmHangmanTwoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 907)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picGameStatus)
        Me.Controls.Add(Me.lblPlayerTwo)
        Me.Controls.Add(Me.lblPlayerOne)
        Me.Controls.Add(Me.bxPlayer2)
        Me.Controls.Add(Me.bxPlayer1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.bxLetters)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblLeaveGame)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstSymbol)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHangmanTwoPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hangman - Two Player"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_GoldToken1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_GoldToken2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_GoldToken3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_GoldToken4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_GoldToken5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bxLetters.ResumeLayout(False)
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bxPlayer1.ResumeLayout(False)
        CType(Me.picPlayerOneToken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1_Life1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayerOneStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bxPlayer2.ResumeLayout(False)
        CType(Me.picPlayerTwoToken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_Life1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_GoldToken3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_GoldToken5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_GoldToken4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_GoldToken2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2_GoldToken1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayerTwoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picGameStatus As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_GoldToken1 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_GoldToken2 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_GoldToken3 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_GoldToken4 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_GoldToken5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblLeaveGame As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturn As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.PictureBox
    Friend WithEvents bxLetters As System.Windows.Forms.GroupBox
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents btnW As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnY As System.Windows.Forms.Button
    Friend WithEvents btnZ As System.Windows.Forms.Button
    Friend WithEvents btnQ As System.Windows.Forms.Button
    Friend WithEvents btnP As System.Windows.Forms.Button
    Friend WithEvents btnO As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents btnK As System.Windows.Forms.Button
    Friend WithEvents btnJ As System.Windows.Forms.Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents btnI As System.Windows.Forms.Button
    Friend WithEvents btnH As System.Windows.Forms.Button
    Friend WithEvents btnG As System.Windows.Forms.Button
    Friend WithEvents btnF As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents lblPlayerOneTokens As System.Windows.Forms.Label
    Friend WithEvents lblPlayerOneLives As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents bxPlayer1 As System.Windows.Forms.GroupBox
    Friend WithEvents Player1_Life3 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life5 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life4 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life2 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life1 As System.Windows.Forms.PictureBox
    Friend WithEvents bxPlayer2 As System.Windows.Forms.GroupBox
    Friend WithEvents Player2_Life3 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life5 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life4 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life2 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life1 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_GoldToken3 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_GoldToken5 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_GoldToken4 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_GoldToken2 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_GoldToken1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerTwoLives As System.Windows.Forms.Label
    Friend WithEvents lblPlayerTwoTokens As System.Windows.Forms.Label
    Friend WithEvents CountDownTimer As System.Windows.Forms.Timer
    Friend WithEvents lstSymbol As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayerTwo As System.Windows.Forms.Label
    Friend WithEvents lblPlayerOne As System.Windows.Forms.Label
    Friend WithEvents PicPlayerOneStatus As System.Windows.Forms.PictureBox
    Friend WithEvents PicPlayerTwoStatus As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life8 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life10 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life9 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life7 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1_Life6 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life8 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life10 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life9 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life7 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2_Life6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LifeFlashTimer As System.Windows.Forms.Timer
    Friend WithEvents TokenTimer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DisplayTimer As System.Windows.Forms.Timer
    Friend WithEvents picPlayerOneToken As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerTwoToken As System.Windows.Forms.PictureBox
    Friend WithEvents WinnerTimer As System.Windows.Forms.Timer
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents CaptionTimer As System.Windows.Forms.Timer
End Class

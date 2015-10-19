<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangmanModeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangmanModeMenu))
        Me.boxHangMan = New System.Windows.Forms.PictureBox()
        Me.boxTicTacToe = New System.Windows.Forms.PictureBox()
        Me.boxMediaPlayer = New System.Windows.Forms.PictureBox()
        Me.btnSelectSinglePlayer = New System.Windows.Forms.Button()
        Me.btnSelectVersus = New System.Windows.Forms.Button()
        Me.btnSelectTwoPlayer = New System.Windows.Forms.Button()
        Me.lblMediaPlayerDescription = New System.Windows.Forms.Label()
        Me.lblTicTacToeDescription = New System.Windows.Forms.Label()
        Me.lblHangmanDescription = New System.Windows.Forms.Label()
        Me.picHangMan = New System.Windows.Forms.PictureBox()
        Me.picMediaPlayer = New System.Windows.Forms.PictureBox()
        Me.lblMediaPlayer = New System.Windows.Forms.Label()
        Me.lblTicTacToe = New System.Windows.Forms.Label()
        Me.lblHangMan = New System.Windows.Forms.Label()
        Me.picTicTacToe = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SoundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.PictureBox()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnMuteUnmute = New System.Windows.Forms.PictureBox()
        Me.lblMute = New System.Windows.Forms.Label()
        Me.lblGameSettings = New System.Windows.Forms.Label()
        Me.btnGameSettings = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CaptionTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMuteUnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGameSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxHangMan
        '
        Me.boxHangMan.BackColor = System.Drawing.Color.Transparent
        Me.boxHangMan.BackgroundImage = CType(resources.GetObject("boxHangMan.BackgroundImage"), System.Drawing.Image)
        Me.boxHangMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxHangMan.Location = New System.Drawing.Point(61, 144)
        Me.boxHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxHangMan.Name = "boxHangMan"
        Me.boxHangMan.Size = New System.Drawing.Size(413, 677)
        Me.boxHangMan.TabIndex = 22
        Me.boxHangMan.TabStop = False
        '
        'boxTicTacToe
        '
        Me.boxTicTacToe.BackColor = System.Drawing.Color.Transparent
        Me.boxTicTacToe.BackgroundImage = CType(resources.GetObject("boxTicTacToe.BackgroundImage"), System.Drawing.Image)
        Me.boxTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxTicTacToe.Location = New System.Drawing.Point(516, 144)
        Me.boxTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxTicTacToe.Name = "boxTicTacToe"
        Me.boxTicTacToe.Size = New System.Drawing.Size(413, 677)
        Me.boxTicTacToe.TabIndex = 23
        Me.boxTicTacToe.TabStop = False
        '
        'boxMediaPlayer
        '
        Me.boxMediaPlayer.BackColor = System.Drawing.Color.Transparent
        Me.boxMediaPlayer.BackgroundImage = CType(resources.GetObject("boxMediaPlayer.BackgroundImage"), System.Drawing.Image)
        Me.boxMediaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxMediaPlayer.Location = New System.Drawing.Point(972, 144)
        Me.boxMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxMediaPlayer.Name = "boxMediaPlayer"
        Me.boxMediaPlayer.Size = New System.Drawing.Size(413, 677)
        Me.boxMediaPlayer.TabIndex = 24
        Me.boxMediaPlayer.TabStop = False
        '
        'btnSelectSinglePlayer
        '
        Me.btnSelectSinglePlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectSinglePlayer.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSinglePlayer.Location = New System.Drawing.Point(259, 734)
        Me.btnSelectSinglePlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectSinglePlayer.Name = "btnSelectSinglePlayer"
        Me.btnSelectSinglePlayer.Size = New System.Drawing.Size(196, 53)
        Me.btnSelectSinglePlayer.TabIndex = 58
        Me.btnSelectSinglePlayer.Text = "Select"
        Me.btnSelectSinglePlayer.UseVisualStyleBackColor = False
        '
        'btnSelectVersus
        '
        Me.btnSelectVersus.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectVersus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectVersus.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectVersus.Location = New System.Drawing.Point(1168, 734)
        Me.btnSelectVersus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectVersus.Name = "btnSelectVersus"
        Me.btnSelectVersus.Size = New System.Drawing.Size(196, 53)
        Me.btnSelectVersus.TabIndex = 57
        Me.btnSelectVersus.Text = "Select"
        Me.btnSelectVersus.UseVisualStyleBackColor = False
        '
        'btnSelectTwoPlayer
        '
        Me.btnSelectTwoPlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectTwoPlayer.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTwoPlayer.Location = New System.Drawing.Point(713, 734)
        Me.btnSelectTwoPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectTwoPlayer.Name = "btnSelectTwoPlayer"
        Me.btnSelectTwoPlayer.Size = New System.Drawing.Size(196, 53)
        Me.btnSelectTwoPlayer.TabIndex = 56
        Me.btnSelectTwoPlayer.Text = "Select"
        Me.btnSelectTwoPlayer.UseVisualStyleBackColor = False
        '
        'lblMediaPlayerDescription
        '
        Me.lblMediaPlayerDescription.BackColor = System.Drawing.Color.White
        Me.lblMediaPlayerDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediaPlayerDescription.Location = New System.Drawing.Point(1001, 571)
        Me.lblMediaPlayerDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMediaPlayerDescription.Name = "lblMediaPlayerDescription"
        Me.lblMediaPlayerDescription.Size = New System.Drawing.Size(355, 170)
        Me.lblMediaPlayerDescription.TabIndex = 55
        Me.lblMediaPlayerDescription.Text = "Go head-to-head with your friends in a relentless game of Hangman. You have 1 min" & _
    "ute to guess each word. The player with the correct word receives a token. The f" & _
    "irst to 5 gold tokens wins the game!"
        '
        'lblTicTacToeDescription
        '
        Me.lblTicTacToeDescription.BackColor = System.Drawing.Color.White
        Me.lblTicTacToeDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToeDescription.Location = New System.Drawing.Point(549, 571)
        Me.lblTicTacToeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToeDescription.Name = "lblTicTacToeDescription"
        Me.lblTicTacToeDescription.Size = New System.Drawing.Size(355, 159)
        Me.lblTicTacToeDescription.TabIndex = 54
        Me.lblTicTacToeDescription.Text = resources.GetString("lblTicTacToeDescription.Text")
        '
        'lblHangmanDescription
        '
        Me.lblHangmanDescription.BackColor = System.Drawing.Color.White
        Me.lblHangmanDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangmanDescription.Location = New System.Drawing.Point(104, 571)
        Me.lblHangmanDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangmanDescription.Name = "lblHangmanDescription"
        Me.lblHangmanDescription.Size = New System.Drawing.Size(337, 159)
        Me.lblHangmanDescription.TabIndex = 53
        Me.lblHangmanDescription.Text = "Feel like playing a solid game of Hangman? Well then, this is the game mode for y" & _
    "ou. Guess as many words as you can and enjoy an endless game of hangman. After a" & _
    "ll, nothing beats the classics! "
        '
        'picHangMan
        '
        Me.picHangMan.BackColor = System.Drawing.Color.Black
        Me.picHangMan.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_SinglePlayer
        Me.picHangMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHangMan.Location = New System.Drawing.Point(65, 230)
        Me.picHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picHangMan.Name = "picHangMan"
        Me.picHangMan.Size = New System.Drawing.Size(404, 321)
        Me.picHangMan.TabIndex = 52
        Me.picHangMan.TabStop = False
        '
        'picMediaPlayer
        '
        Me.picMediaPlayer.BackColor = System.Drawing.Color.Black
        Me.picMediaPlayer.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_Versus
        Me.picMediaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMediaPlayer.Location = New System.Drawing.Point(976, 230)
        Me.picMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMediaPlayer.Name = "picMediaPlayer"
        Me.picMediaPlayer.Size = New System.Drawing.Size(404, 321)
        Me.picMediaPlayer.TabIndex = 51
        Me.picMediaPlayer.TabStop = False
        '
        'lblMediaPlayer
        '
        Me.lblMediaPlayer.AutoSize = True
        Me.lblMediaPlayer.BackColor = System.Drawing.Color.White
        Me.lblMediaPlayer.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediaPlayer.Location = New System.Drawing.Point(1000, 178)
        Me.lblMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMediaPlayer.Name = "lblMediaPlayer"
        Me.lblMediaPlayer.Size = New System.Drawing.Size(97, 36)
        Me.lblMediaPlayer.TabIndex = 50
        Me.lblMediaPlayer.Text = "Versus"
        '
        'lblTicTacToe
        '
        Me.lblTicTacToe.AutoSize = True
        Me.lblTicTacToe.BackColor = System.Drawing.Color.White
        Me.lblTicTacToe.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToe.Location = New System.Drawing.Point(549, 178)
        Me.lblTicTacToe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToe.Name = "lblTicTacToe"
        Me.lblTicTacToe.Size = New System.Drawing.Size(166, 36)
        Me.lblTicTacToe.TabIndex = 49
        Me.lblTicTacToe.Text = "Two Player"
        '
        'lblHangMan
        '
        Me.lblHangMan.AutoSize = True
        Me.lblHangMan.BackColor = System.Drawing.Color.White
        Me.lblHangMan.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangMan.Location = New System.Drawing.Point(91, 178)
        Me.lblHangMan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangMan.Name = "lblHangMan"
        Me.lblHangMan.Size = New System.Drawing.Size(181, 36)
        Me.lblHangMan.TabIndex = 48
        Me.lblHangMan.Text = "Single Player"
        '
        'picTicTacToe
        '
        Me.picTicTacToe.BackColor = System.Drawing.Color.White
        Me.picTicTacToe.BackgroundImage = CType(resources.GetObject("picTicTacToe.BackgroundImage"), System.Drawing.Image)
        Me.picTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTicTacToe.Location = New System.Drawing.Point(520, 230)
        Me.picTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTicTacToe.Name = "picTicTacToe"
        Me.picTicTacToe.Size = New System.Drawing.Size(404, 321)
        Me.picTicTacToe.TabIndex = 47
        Me.picTicTacToe.TabStop = False
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
        Me.btnMinimize.TabIndex = 59
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
        Me.btnMaximize.TabIndex = 60
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
        Me.btnClose.TabIndex = 61
        Me.btnClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1440, 875)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'SoundTimer
        '
        Me.SoundTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 36)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Select Game Mode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Hangman - Modes"
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
        Me.btnInfo.TabIndex = 68
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
        Me.btnReturn.TabIndex = 69
        Me.btnReturn.TabStop = False
        '
        'lblMainMenu
        '
        Me.lblMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMenu.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(87, 49)
        Me.lblMainMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(156, 33)
        Me.lblMainMenu.TabIndex = 71
        Me.lblMainMenu.Text = "Main Menu"
        Me.lblMainMenu.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(1193, 47)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(156, 33)
        Me.lblInfo.TabIndex = 72
        Me.lblInfo.Text = "Information"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblInfo.Visible = False
        '
        'btnMuteUnmute
        '
        Me.btnMuteUnmute.BackColor = System.Drawing.Color.Transparent
        Me.btnMuteUnmute.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.UnMute_Button
        Me.btnMuteUnmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMuteUnmute.Location = New System.Drawing.Point(16, 828)
        Me.btnMuteUnmute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMuteUnmute.Name = "btnMuteUnmute"
        Me.btnMuteUnmute.Size = New System.Drawing.Size(69, 64)
        Me.btnMuteUnmute.TabIndex = 77
        Me.btnMuteUnmute.TabStop = False
        '
        'lblMute
        '
        Me.lblMute.BackColor = System.Drawing.Color.Transparent
        Me.lblMute.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMute.Location = New System.Drawing.Point(93, 843)
        Me.lblMute.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMute.Name = "lblMute"
        Me.lblMute.Size = New System.Drawing.Size(224, 33)
        Me.lblMute.TabIndex = 79
        Me.lblMute.Text = "Mute Sounds"
        Me.lblMute.Visible = False
        '
        'lblGameSettings
        '
        Me.lblGameSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblGameSettings.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameSettings.Location = New System.Drawing.Point(1131, 846)
        Me.lblGameSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGameSettings.Name = "lblGameSettings"
        Me.lblGameSettings.Size = New System.Drawing.Size(216, 33)
        Me.lblGameSettings.TabIndex = 81
        Me.lblGameSettings.Text = "Game Settings"
        Me.lblGameSettings.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblGameSettings.Visible = False
        '
        'btnGameSettings
        '
        Me.btnGameSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnGameSettings.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.GameSettings_Button
        Me.btnGameSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGameSettings.Location = New System.Drawing.Point(1355, 828)
        Me.btnGameSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGameSettings.Name = "btnGameSettings"
        Me.btnGameSettings.Size = New System.Drawing.Size(69, 64)
        Me.btnGameSettings.TabIndex = 80
        Me.btnGameSettings.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(516, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(413, 58)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Hangman"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(65, 144)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(520, 144)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox3.TabIndex = 130
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(976, 144)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox4.TabIndex = 131
        Me.PictureBox4.TabStop = False
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'CaptionTimer
        '
        '
        'frmHangmanModeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 907)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblGameSettings)
        Me.Controls.Add(Me.btnGameSettings)
        Me.Controls.Add(Me.lblMute)
        Me.Controls.Add(Me.btnMuteUnmute)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectSinglePlayer)
        Me.Controls.Add(Me.btnSelectVersus)
        Me.Controls.Add(Me.btnSelectTwoPlayer)
        Me.Controls.Add(Me.lblMediaPlayerDescription)
        Me.Controls.Add(Me.lblTicTacToeDescription)
        Me.Controls.Add(Me.lblHangmanDescription)
        Me.Controls.Add(Me.picHangMan)
        Me.Controls.Add(Me.picMediaPlayer)
        Me.Controls.Add(Me.lblMediaPlayer)
        Me.Controls.Add(Me.lblTicTacToe)
        Me.Controls.Add(Me.lblHangMan)
        Me.Controls.Add(Me.picTicTacToe)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.boxHangMan)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.boxTicTacToe)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.boxMediaPlayer)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHangmanModeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hangman - Modes"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMuteUnmute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGameSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents boxTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents boxMediaPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnSelectSinglePlayer As System.Windows.Forms.Button
    Friend WithEvents btnSelectVersus As System.Windows.Forms.Button
    Friend WithEvents btnSelectTwoPlayer As System.Windows.Forms.Button
    Friend WithEvents lblMediaPlayerDescription As System.Windows.Forms.Label
    Friend WithEvents lblTicTacToeDescription As System.Windows.Forms.Label
    Friend WithEvents lblHangmanDescription As System.Windows.Forms.Label
    Friend WithEvents picHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents picMediaPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents lblMediaPlayer As System.Windows.Forms.Label
    Friend WithEvents lblTicTacToe As System.Windows.Forms.Label
    Friend WithEvents lblHangMan As System.Windows.Forms.Label
    Friend WithEvents picTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SoundTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturn As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnMuteUnmute As System.Windows.Forms.PictureBox
    Friend WithEvents lblMute As System.Windows.Forms.Label
    Friend WithEvents lblGameSettings As System.Windows.Forms.Label
    Friend WithEvents btnGameSettings As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents CaptionTimer As System.Windows.Forms.Timer
End Class

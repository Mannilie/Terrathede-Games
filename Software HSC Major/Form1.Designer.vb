<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.boxTicTacToe = New System.Windows.Forms.PictureBox()
        Me.boxMediaPlayer = New System.Windows.Forms.PictureBox()
        Me.picTicTacToe = New System.Windows.Forms.PictureBox()
        Me.lblHangMan = New System.Windows.Forms.Label()
        Me.lblTicTacToe = New System.Windows.Forms.Label()
        Me.lblMediaPlayer = New System.Windows.Forms.Label()
        Me.picMediaPlayer = New System.Windows.Forms.PictureBox()
        Me.picHangMan = New System.Windows.Forms.PictureBox()
        Me.lblHangmanDescription = New System.Windows.Forms.Label()
        Me.lblTicTacToeDescription = New System.Windows.Forms.Label()
        Me.lblMediaPlayerDescription = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTicTacToe = New System.Windows.Forms.Button()
        Me.btnVLCMediaPlayer = New System.Windows.Forms.Button()
        Me.btnHangMan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.CloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnMuteUnMute = New System.Windows.Forms.PictureBox()
        Me.lblMute = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.DefaultFormTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MusicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RepeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.boxHangMan = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CaptionTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnMinimize.TabIndex = 14
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
        Me.btnMaximize.TabIndex = 15
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
        Me.btnClose.TabIndex = 16
        Me.btnClose.TabStop = False
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
        Me.boxTicTacToe.TabIndex = 20
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
        Me.boxMediaPlayer.TabIndex = 21
        Me.boxMediaPlayer.TabStop = False
        '
        'picTicTacToe
        '
        Me.picTicTacToe.BackColor = System.Drawing.Color.Black
        Me.picTicTacToe.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.TicTacToe_Background
        Me.picTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTicTacToe.Location = New System.Drawing.Point(520, 230)
        Me.picTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTicTacToe.Name = "picTicTacToe"
        Me.picTicTacToe.Size = New System.Drawing.Size(404, 321)
        Me.picTicTacToe.TabIndex = 29
        Me.picTicTacToe.TabStop = False
        '
        'lblHangMan
        '
        Me.lblHangMan.AutoSize = True
        Me.lblHangMan.BackColor = System.Drawing.Color.White
        Me.lblHangMan.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangMan.Location = New System.Drawing.Point(91, 178)
        Me.lblHangMan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangMan.Name = "lblHangMan"
        Me.lblHangMan.Size = New System.Drawing.Size(144, 36)
        Me.lblHangMan.TabIndex = 31
        Me.lblHangMan.Text = "Hangman"
        '
        'lblTicTacToe
        '
        Me.lblTicTacToe.AutoSize = True
        Me.lblTicTacToe.BackColor = System.Drawing.Color.White
        Me.lblTicTacToe.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToe.Location = New System.Drawing.Point(549, 178)
        Me.lblTicTacToe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToe.Name = "lblTicTacToe"
        Me.lblTicTacToe.Size = New System.Drawing.Size(169, 36)
        Me.lblTicTacToe.TabIndex = 32
        Me.lblTicTacToe.Text = "Tic Tac Toe"
        '
        'lblMediaPlayer
        '
        Me.lblMediaPlayer.AutoSize = True
        Me.lblMediaPlayer.BackColor = System.Drawing.Color.White
        Me.lblMediaPlayer.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediaPlayer.Location = New System.Drawing.Point(1000, 178)
        Me.lblMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMediaPlayer.Name = "lblMediaPlayer"
        Me.lblMediaPlayer.Size = New System.Drawing.Size(252, 36)
        Me.lblMediaPlayer.TabIndex = 33
        Me.lblMediaPlayer.Text = "VLC Media Player"
        '
        'picMediaPlayer
        '
        Me.picMediaPlayer.BackColor = System.Drawing.Color.Black
        Me.picMediaPlayer.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.MediaPlayer
        Me.picMediaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMediaPlayer.Location = New System.Drawing.Point(976, 230)
        Me.picMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMediaPlayer.Name = "picMediaPlayer"
        Me.picMediaPlayer.Size = New System.Drawing.Size(404, 321)
        Me.picMediaPlayer.TabIndex = 34
        Me.picMediaPlayer.TabStop = False
        '
        'picHangMan
        '
        Me.picHangMan.BackColor = System.Drawing.Color.Black
        Me.picHangMan.BackgroundImage = CType(resources.GetObject("picHangMan.BackgroundImage"), System.Drawing.Image)
        Me.picHangMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHangMan.Location = New System.Drawing.Point(65, 230)
        Me.picHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picHangMan.Name = "picHangMan"
        Me.picHangMan.Size = New System.Drawing.Size(404, 321)
        Me.picHangMan.TabIndex = 35
        Me.picHangMan.TabStop = False
        '
        'lblHangmanDescription
        '
        Me.lblHangmanDescription.BackColor = System.Drawing.Color.White
        Me.lblHangmanDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangmanDescription.Location = New System.Drawing.Point(104, 571)
        Me.lblHangmanDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangmanDescription.Name = "lblHangmanDescription"
        Me.lblHangmanDescription.Size = New System.Drawing.Size(337, 132)
        Me.lblHangmanDescription.TabIndex = 36
        Me.lblHangmanDescription.Text = "Do you think you have what it takes to guess that word? Come and verse your frien" & _
    "ds or other players in a gripping game of Hangman!"
        '
        'lblTicTacToeDescription
        '
        Me.lblTicTacToeDescription.BackColor = System.Drawing.Color.White
        Me.lblTicTacToeDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToeDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTicTacToeDescription.Location = New System.Drawing.Point(549, 571)
        Me.lblTicTacToeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToeDescription.Name = "lblTicTacToeDescription"
        Me.lblTicTacToeDescription.Size = New System.Drawing.Size(355, 132)
        Me.lblTicTacToeDescription.TabIndex = 37
        Me.lblTicTacToeDescription.Text = "Ready to launch an all-out and strategic battle to see who is the best? Verse you" & _
    "r friends or computer players at a classical and intense game of Tic Tac Toe!"
        '
        'lblMediaPlayerDescription
        '
        Me.lblMediaPlayerDescription.BackColor = System.Drawing.Color.White
        Me.lblMediaPlayerDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediaPlayerDescription.Location = New System.Drawing.Point(1001, 571)
        Me.lblMediaPlayerDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMediaPlayerDescription.Name = "lblMediaPlayerDescription"
        Me.lblMediaPlayerDescription.Size = New System.Drawing.Size(355, 142)
        Me.lblMediaPlayerDescription.TabIndex = 38
        Me.lblMediaPlayerDescription.Text = "Feel the need to unwind and listen to your favourite tunes whilst playing your fa" & _
    "vourite games? Try our exclusive custom HD, audio filtered VLC Media Player."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1440, 876)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'btnTicTacToe
        '
        Me.btnTicTacToe.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTicTacToe.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicTacToe.Location = New System.Drawing.Point(713, 734)
        Me.btnTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTicTacToe.Name = "btnTicTacToe"
        Me.btnTicTacToe.Size = New System.Drawing.Size(196, 53)
        Me.btnTicTacToe.TabIndex = 44
        Me.btnTicTacToe.Text = "Play"
        Me.btnTicTacToe.UseVisualStyleBackColor = False
        '
        'btnVLCMediaPlayer
        '
        Me.btnVLCMediaPlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVLCMediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVLCMediaPlayer.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVLCMediaPlayer.Location = New System.Drawing.Point(1168, 734)
        Me.btnVLCMediaPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVLCMediaPlayer.Name = "btnVLCMediaPlayer"
        Me.btnVLCMediaPlayer.Size = New System.Drawing.Size(196, 53)
        Me.btnVLCMediaPlayer.TabIndex = 45
        Me.btnVLCMediaPlayer.Text = "Open"
        Me.btnVLCMediaPlayer.UseVisualStyleBackColor = False
        '
        'btnHangMan
        '
        Me.btnHangMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHangMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHangMan.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHangMan.Location = New System.Drawing.Point(259, 734)
        Me.btnHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHangMan.Name = "btnHangMan"
        Me.btnHangMan.Size = New System.Drawing.Size(196, 53)
        Me.btnHangMan.TabIndex = 46
        Me.btnHangMan.Text = "Play"
        Me.btnHangMan.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Terrathede Games - Main Menu"
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
        Me.btnInfo.TabIndex = 70
        Me.btnInfo.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(516, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 58)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Main Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(1193, 47)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(156, 33)
        Me.lblInfo.TabIndex = 73
        Me.lblInfo.Text = "Information"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblInfo.Visible = False
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
        Me.btnSettings.TabIndex = 74
        Me.btnSettings.TabStop = False
        '
        'CloseTimer
        '
        Me.CloseTimer.Interval = 1000
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
        Me.btnMuteUnMute.TabIndex = 76
        Me.btnMuteUnMute.TabStop = False
        '
        'lblMute
        '
        Me.lblMute.BackColor = System.Drawing.Color.Transparent
        Me.lblMute.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMute.ForeColor = System.Drawing.Color.Black
        Me.lblMute.Location = New System.Drawing.Point(93, 846)
        Me.lblMute.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMute.Name = "lblMute"
        Me.lblMute.Size = New System.Drawing.Size(199, 33)
        Me.lblMute.TabIndex = 77
        Me.lblMute.Text = "Mute Sounds"
        Me.lblMute.Visible = False
        '
        'lblSettings
        '
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.Black
        Me.lblSettings.Location = New System.Drawing.Point(1132, 846)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(216, 33)
        Me.lblSettings.TabIndex = 75
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSettings.Visible = False
        '
        'DefaultFormTimer
        '
        Me.DefaultFormTimer.Interval = 5000
        '
        'MusicTimer
        '
        Me.MusicTimer.Interval = 5000
        '
        'RepeatTimer
        '
        Me.RepeatTimer.Interval = 1000
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
        Me.boxHangMan.TabIndex = 19
        Me.boxHangMan.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(65, 144)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(520, 144)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox3.TabIndex = 129
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(976, 144)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox4.TabIndex = 130
        Me.PictureBox4.TabStop = False
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'CaptionTimer
        '
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 907)
        Me.Controls.Add(Me.lblMute)
        Me.Controls.Add(Me.btnMuteUnMute)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.picTicTacToe)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.picMediaPlayer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHangMan)
        Me.Controls.Add(Me.btnVLCMediaPlayer)
        Me.Controls.Add(Me.btnTicTacToe)
        Me.Controls.Add(Me.lblMediaPlayerDescription)
        Me.Controls.Add(Me.lblTicTacToeDescription)
        Me.Controls.Add(Me.lblHangmanDescription)
        Me.Controls.Add(Me.picHangMan)
        Me.Controls.Add(Me.lblMediaPlayer)
        Me.Controls.Add(Me.lblTicTacToe)
        Me.Controls.Add(Me.lblHangMan)
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
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terrathede Games - Main Menu"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents boxTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents boxMediaPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents lblHangMan As System.Windows.Forms.Label
    Friend WithEvents lblTicTacToe As System.Windows.Forms.Label
    Friend WithEvents lblMediaPlayer As System.Windows.Forms.Label
    Friend WithEvents picMediaPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents lblHangmanDescription As System.Windows.Forms.Label
    Friend WithEvents lblTicTacToeDescription As System.Windows.Forms.Label
    Friend WithEvents lblMediaPlayerDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExitTimer As System.Windows.Forms.Timer
    Friend WithEvents SoundTimer As System.Windows.Forms.Timer
    Friend WithEvents btnTicTacToe As System.Windows.Forms.Button
    Friend WithEvents btnVLCMediaPlayer As System.Windows.Forms.Button
    Friend WithEvents btnHangMan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents CloseTimer As System.Windows.Forms.Timer
    Friend WithEvents btnMuteUnMute As System.Windows.Forms.PictureBox
    Friend WithEvents lblMute As System.Windows.Forms.Label
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents DefaultFormTimer As System.Windows.Forms.Timer
    Friend WithEvents MusicTimer As System.Windows.Forms.Timer
    Friend WithEvents RepeatTimer As System.Windows.Forms.Timer
    Friend WithEvents boxHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents CaptionTimer As System.Windows.Forms.Timer

End Class

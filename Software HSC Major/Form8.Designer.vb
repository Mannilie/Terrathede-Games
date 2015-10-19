<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToeModeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicTacToeModeMenu))
        Me.lblMute = New System.Windows.Forms.Label()
        Me.btnMuteUnMute = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.picTicTacToe = New System.Windows.Forms.PictureBox()
        Me.btnSelectSinglePlayer = New System.Windows.Forms.Button()
        Me.btnSelectTwoPlayer = New System.Windows.Forms.Button()
        Me.lblTicTacToeDescription = New System.Windows.Forms.Label()
        Me.lblHangmanDescription = New System.Windows.Forms.Label()
        Me.picHangMan = New System.Windows.Forms.PictureBox()
        Me.lblHangMan = New System.Windows.Forms.Label()
        Me.boxHangMan = New System.Windows.Forms.PictureBox()
        Me.boxTicTacToe = New System.Windows.Forms.PictureBox()
        Me.lblTicTacToe = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CaptionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSettings = New System.Windows.Forms.Label()
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMute
        '
        Me.lblMute.BackColor = System.Drawing.Color.Transparent
        Me.lblMute.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMute.Location = New System.Drawing.Point(93, 846)
        Me.lblMute.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMute.Name = "lblMute"
        Me.lblMute.Size = New System.Drawing.Size(199, 33)
        Me.lblMute.TabIndex = 83
        Me.lblMute.Text = "Mute Sounds"
        Me.lblMute.Visible = False
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
        Me.btnMuteUnMute.TabIndex = 82
        Me.btnMuteUnMute.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Settings_Button
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Location = New System.Drawing.Point(1039, 828)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(69, 64)
        Me.btnSettings.TabIndex = 80
        Me.btnSettings.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(875, 42)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(156, 33)
        Me.lblInfo.TabIndex = 79
        Me.lblInfo.Text = "Information"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblInfo.Visible = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImage = CType(resources.GetObject("btnInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Location = New System.Drawing.Point(1039, 30)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(69, 64)
        Me.btnInfo.TabIndex = 78
        Me.btnInfo.TabStop = False
        '
        'picTicTacToe
        '
        Me.picTicTacToe.BackColor = System.Drawing.Color.Black
        Me.picTicTacToe.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Two_Players
        Me.picTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTicTacToe.Location = New System.Drawing.Point(627, 230)
        Me.picTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTicTacToe.Name = "picTicTacToe"
        Me.picTicTacToe.Size = New System.Drawing.Size(404, 321)
        Me.picTicTacToe.TabIndex = 84
        Me.picTicTacToe.TabStop = False
        '
        'btnSelectSinglePlayer
        '
        Me.btnSelectSinglePlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectSinglePlayer.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSinglePlayer.Location = New System.Drawing.Point(292, 734)
        Me.btnSelectSinglePlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectSinglePlayer.Name = "btnSelectSinglePlayer"
        Me.btnSelectSinglePlayer.Size = New System.Drawing.Size(196, 53)
        Me.btnSelectSinglePlayer.TabIndex = 94
        Me.btnSelectSinglePlayer.Text = "Select"
        Me.btnSelectSinglePlayer.UseVisualStyleBackColor = False
        '
        'btnSelectTwoPlayer
        '
        Me.btnSelectTwoPlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectTwoPlayer.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTwoPlayer.Location = New System.Drawing.Point(820, 734)
        Me.btnSelectTwoPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectTwoPlayer.Name = "btnSelectTwoPlayer"
        Me.btnSelectTwoPlayer.Size = New System.Drawing.Size(196, 53)
        Me.btnSelectTwoPlayer.TabIndex = 92
        Me.btnSelectTwoPlayer.Text = "Select"
        Me.btnSelectTwoPlayer.UseVisualStyleBackColor = False
        '
        'lblTicTacToeDescription
        '
        Me.lblTicTacToeDescription.BackColor = System.Drawing.Color.White
        Me.lblTicTacToeDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToeDescription.Location = New System.Drawing.Point(656, 571)
        Me.lblTicTacToeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToeDescription.Name = "lblTicTacToeDescription"
        Me.lblTicTacToeDescription.Size = New System.Drawing.Size(355, 149)
        Me.lblTicTacToeDescription.TabIndex = 90
        Me.lblTicTacToeDescription.Text = "Play against your friends in a ""Neck and Neck"" stategic game of Tic Tac Toe! Very" & _
    " similar to single player Tic Tac Toe, the first person to reach 5 golden tokens" & _
    " wins the game!"
        '
        'lblHangmanDescription
        '
        Me.lblHangmanDescription.BackColor = System.Drawing.Color.White
        Me.lblHangmanDescription.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangmanDescription.Location = New System.Drawing.Point(137, 571)
        Me.lblHangmanDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangmanDescription.Name = "lblHangmanDescription"
        Me.lblHangmanDescription.Size = New System.Drawing.Size(337, 149)
        Me.lblHangmanDescription.TabIndex = 89
        Me.lblHangmanDescription.Text = "Play against the computer player in a head-to-head strategic game of Tic Tac Toe!" & _
    " Beware of the computer player. The first player to reach 5 golden tokens wins t" & _
    "he game!"
        '
        'picHangMan
        '
        Me.picHangMan.BackColor = System.Drawing.Color.Black
        Me.picHangMan.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Single_Player
        Me.picHangMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHangMan.Location = New System.Drawing.Point(99, 230)
        Me.picHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picHangMan.Name = "picHangMan"
        Me.picHangMan.Size = New System.Drawing.Size(404, 321)
        Me.picHangMan.TabIndex = 88
        Me.picHangMan.TabStop = False
        '
        'lblHangMan
        '
        Me.lblHangMan.AutoSize = True
        Me.lblHangMan.BackColor = System.Drawing.Color.White
        Me.lblHangMan.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangMan.Location = New System.Drawing.Point(124, 178)
        Me.lblHangMan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHangMan.Name = "lblHangMan"
        Me.lblHangMan.Size = New System.Drawing.Size(181, 36)
        Me.lblHangMan.TabIndex = 85
        Me.lblHangMan.Text = "Single Player"
        '
        'boxHangMan
        '
        Me.boxHangMan.BackColor = System.Drawing.Color.Transparent
        Me.boxHangMan.BackgroundImage = CType(resources.GetObject("boxHangMan.BackgroundImage"), System.Drawing.Image)
        Me.boxHangMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxHangMan.Location = New System.Drawing.Point(95, 144)
        Me.boxHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxHangMan.Name = "boxHangMan"
        Me.boxHangMan.Size = New System.Drawing.Size(413, 677)
        Me.boxHangMan.TabIndex = 95
        Me.boxHangMan.TabStop = False
        '
        'boxTicTacToe
        '
        Me.boxTicTacToe.BackColor = System.Drawing.Color.Transparent
        Me.boxTicTacToe.BackgroundImage = CType(resources.GetObject("boxTicTacToe.BackgroundImage"), System.Drawing.Image)
        Me.boxTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxTicTacToe.Location = New System.Drawing.Point(623, 144)
        Me.boxTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxTicTacToe.Name = "boxTicTacToe"
        Me.boxTicTacToe.Size = New System.Drawing.Size(413, 677)
        Me.boxTicTacToe.TabIndex = 96
        Me.boxTicTacToe.TabStop = False
        '
        'lblTicTacToe
        '
        Me.lblTicTacToe.AutoSize = True
        Me.lblTicTacToe.BackColor = System.Drawing.Color.White
        Me.lblTicTacToe.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicTacToe.Location = New System.Drawing.Point(656, 178)
        Me.lblTicTacToe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicTacToe.Name = "lblTicTacToe"
        Me.lblTicTacToe.Size = New System.Drawing.Size(166, 36)
        Me.lblTicTacToe.TabIndex = 98
        Me.lblTicTacToe.Text = "Two Player"
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
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Select Game Mode:"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMenu.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(87, 47)
        Me.lblMainMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(156, 33)
        Me.lblMainMenu.TabIndex = 101
        Me.lblMainMenu.Text = "Main Menu"
        Me.lblMainMenu.Visible = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.Location = New System.Drawing.Point(16, 31)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(69, 64)
        Me.btnReturn.TabIndex = 100
        Me.btnReturn.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Location = New System.Drawing.Point(843, -4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 32)
        Me.btnMinimize.TabIndex = 102
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Maximize_Button_Disabled
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Location = New System.Drawing.Point(911, -4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(75, 32)
        Me.btnMaximize.TabIndex = 103
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(981, -4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 104
        Me.btnClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1123, 878)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Tic Tac Toe - Modes"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(375, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 58)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Tic Tac Toe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(99, 144)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(627, 144)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(404, 655)
        Me.PictureBox3.TabIndex = 130
        Me.PictureBox3.TabStop = False
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'CaptionTimer
        '
        '
        'lblSettings
        '
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(815, 846)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(216, 33)
        Me.lblSettings.TabIndex = 81
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSettings.Visible = False
        '
        'frmTicTacToeModeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Background_TicTacToe
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 907)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTicTacToe)
        Me.Controls.Add(Me.picTicTacToe)
        Me.Controls.Add(Me.btnSelectSinglePlayer)
        Me.Controls.Add(Me.btnSelectTwoPlayer)
        Me.Controls.Add(Me.lblTicTacToeDescription)
        Me.Controls.Add(Me.lblHangmanDescription)
        Me.Controls.Add(Me.picHangMan)
        Me.Controls.Add(Me.lblHangMan)
        Me.Controls.Add(Me.lblMute)
        Me.Controls.Add(Me.btnMuteUnMute)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.boxHangMan)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.boxTicTacToe)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTicTacToeModeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tic Tac Toe - Modes"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.btnMuteUnMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxTicTacToe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMute As System.Windows.Forms.Label
    Friend WithEvents btnMuteUnMute As System.Windows.Forms.PictureBox
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents picTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents btnSelectSinglePlayer As System.Windows.Forms.Button
    Friend WithEvents btnSelectTwoPlayer As System.Windows.Forms.Button
    Friend WithEvents lblTicTacToeDescription As System.Windows.Forms.Label
    Friend WithEvents lblHangmanDescription As System.Windows.Forms.Label
    Friend WithEvents picHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents lblHangMan As System.Windows.Forms.Label
    Friend WithEvents boxHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents boxTicTacToe As System.Windows.Forms.PictureBox
    Friend WithEvents lblTicTacToe As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents CaptionTimer As System.Windows.Forms.Timer
    Friend WithEvents lblSettings As System.Windows.Forms.Label
End Class

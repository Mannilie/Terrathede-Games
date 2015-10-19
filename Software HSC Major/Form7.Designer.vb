<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bxSelectMusic = New System.Windows.Forms.GroupBox()
        Me.OCXMusicPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lstMusic = New System.Windows.Forms.ListBox()
        Me.rbTicTacToe = New System.Windows.Forms.RadioButton()
        Me.rbHangMan = New System.Windows.Forms.RadioButton()
        Me.rbMainMenu = New System.Windows.Forms.RadioButton()
        Me.picSaveGif = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rbSoundsOnly = New System.Windows.Forms.RadioButton()
        Me.rbMusicOnly = New System.Windows.Forms.RadioButton()
        Me.rbMusicAndSounds = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RepeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FocusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDefaultSettingsInfo = New System.Windows.Forms.Label()
        Me.lblCustomSettingsInfo = New System.Windows.Forms.Label()
        Me.rbCustomSettings = New System.Windows.Forms.RadioButton()
        Me.rbDefaultSettings = New System.Windows.Forms.RadioButton()
        Me.SaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSettingsSaved = New System.Windows.Forms.Label()
        Me.picGreenTick = New System.Windows.Forms.PictureBox()
        Me.cbDisableCaptions = New System.Windows.Forms.CheckBox()
        Me.linklblWhatsThis = New System.Windows.Forms.LinkLabel()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bxSelectMusic.SuspendLayout()
        CType(Me.OCXMusicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaveGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picGreenTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.MinimizeButton3
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Enabled = False
        Me.btnMinimize.Location = New System.Drawing.Point(431, -4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 32)
        Me.btnMinimize.TabIndex = 17
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Maximize_Button_Disabled
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Enabled = False
        Me.btnMaximize.Location = New System.Drawing.Point(499, -4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(75, 32)
        Me.btnMaximize.TabIndex = 18
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(569, -4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 19
        Me.btnClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(717, 485)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'bxSelectMusic
        '
        Me.bxSelectMusic.BackColor = System.Drawing.Color.Transparent
        Me.bxSelectMusic.Controls.Add(Me.OCXMusicPlayer)
        Me.bxSelectMusic.Controls.Add(Me.btnRemove)
        Me.bxSelectMusic.Controls.Add(Me.btnImport)
        Me.bxSelectMusic.Controls.Add(Me.btnPlay)
        Me.bxSelectMusic.Controls.Add(Me.lstMusic)
        Me.bxSelectMusic.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxSelectMusic.Location = New System.Drawing.Point(275, 146)
        Me.bxSelectMusic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxSelectMusic.Name = "bxSelectMusic"
        Me.bxSelectMusic.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bxSelectMusic.Size = New System.Drawing.Size(413, 290)
        Me.bxSelectMusic.TabIndex = 84
        Me.bxSelectMusic.TabStop = False
        Me.bxSelectMusic.Text = "Select Music:"
        '
        'OCXMusicPlayer
        '
        Me.OCXMusicPlayer.Enabled = True
        Me.OCXMusicPlayer.Location = New System.Drawing.Point(10, 231)
        Me.OCXMusicPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OCXMusicPlayer.Name = "OCXMusicPlayer"
        Me.OCXMusicPlayer.OcxState = CType(resources.GetObject("OCXMusicPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.OCXMusicPlayer.Size = New System.Drawing.Size(294, 45)
        Me.OCXMusicPlayer.TabIndex = 94
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Gray
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(284, 85)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(109, 37)
        Me.btnRemove.TabIndex = 84
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(284, 181)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(109, 37)
        Me.btnImport.TabIndex = 80
        Me.btnImport.Text = "Import..."
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Gray
        Me.btnPlay.Enabled = False
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(284, 41)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(109, 37)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lstMusic
        '
        Me.lstMusic.BackColor = System.Drawing.Color.Gray
        Me.lstMusic.FormattingEnabled = True
        Me.lstMusic.HorizontalScrollbar = True
        Me.lstMusic.ItemHeight = 25
        Me.lstMusic.Location = New System.Drawing.Point(11, 41)
        Me.lstMusic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstMusic.Name = "lstMusic"
        Me.lstMusic.Size = New System.Drawing.Size(256, 154)
        Me.lstMusic.TabIndex = 81
        '
        'rbTicTacToe
        '
        Me.rbTicTacToe.AutoSize = True
        Me.rbTicTacToe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTicTacToe.Location = New System.Drawing.Point(8, 102)
        Me.rbTicTacToe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbTicTacToe.Name = "rbTicTacToe"
        Me.rbTicTacToe.Size = New System.Drawing.Size(123, 29)
        Me.rbTicTacToe.TabIndex = 87
        Me.rbTicTacToe.TabStop = True
        Me.rbTicTacToe.Text = "Tic Tac Toe"
        Me.rbTicTacToe.UseVisualStyleBackColor = True
        '
        'rbHangMan
        '
        Me.rbHangMan.AutoSize = True
        Me.rbHangMan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHangMan.Location = New System.Drawing.Point(8, 65)
        Me.rbHangMan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbHangMan.Name = "rbHangMan"
        Me.rbHangMan.Size = New System.Drawing.Size(121, 29)
        Me.rbHangMan.TabIndex = 86
        Me.rbHangMan.TabStop = True
        Me.rbHangMan.Text = "Hang Man"
        Me.rbHangMan.UseVisualStyleBackColor = True
        '
        'rbMainMenu
        '
        Me.rbMainMenu.AutoSize = True
        Me.rbMainMenu.Checked = True
        Me.rbMainMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMainMenu.Location = New System.Drawing.Point(8, 28)
        Me.rbMainMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMainMenu.Name = "rbMainMenu"
        Me.rbMainMenu.Size = New System.Drawing.Size(130, 29)
        Me.rbMainMenu.TabIndex = 85
        Me.rbMainMenu.TabStop = True
        Me.rbMainMenu.Text = "Main Menu"
        Me.rbMainMenu.UseVisualStyleBackColor = True
        '
        'picSaveGif
        '
        Me.picSaveGif.BackColor = System.Drawing.Color.Transparent
        Me.picSaveGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSaveGif.Location = New System.Drawing.Point(641, 448)
        Me.picSaveGif.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picSaveGif.Name = "picSaveGif"
        Me.picSaveGif.Size = New System.Drawing.Size(53, 49)
        Me.picSaveGif.TabIndex = 89
        Me.picSaveGif.TabStop = False
        Me.picSaveGif.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.rbHangMan)
        Me.GroupBox4.Controls.Add(Me.rbMainMenu)
        Me.GroupBox4.Controls.Add(Me.rbTicTacToe)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(37, 146)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(217, 146)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Load by Default:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(521, 164)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 37)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(521, 164)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 37)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'rbSoundsOnly
        '
        Me.rbSoundsOnly.AutoSize = True
        Me.rbSoundsOnly.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSoundsOnly.Location = New System.Drawing.Point(8, 60)
        Me.rbSoundsOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbSoundsOnly.Name = "rbSoundsOnly"
        Me.rbSoundsOnly.Size = New System.Drawing.Size(139, 29)
        Me.rbSoundsOnly.TabIndex = 89
        Me.rbSoundsOnly.Text = "Sounds Only"
        Me.rbSoundsOnly.UseVisualStyleBackColor = True
        '
        'rbMusicOnly
        '
        Me.rbMusicOnly.AutoSize = True
        Me.rbMusicOnly.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMusicOnly.Location = New System.Drawing.Point(8, 95)
        Me.rbMusicOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMusicOnly.Name = "rbMusicOnly"
        Me.rbMusicOnly.Size = New System.Drawing.Size(127, 29)
        Me.rbMusicOnly.TabIndex = 90
        Me.rbMusicOnly.Text = "Music Only"
        Me.rbMusicOnly.UseVisualStyleBackColor = True
        '
        'rbMusicAndSounds
        '
        Me.rbMusicAndSounds.AutoSize = True
        Me.rbMusicAndSounds.Checked = True
        Me.rbMusicAndSounds.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMusicAndSounds.Location = New System.Drawing.Point(8, 27)
        Me.rbMusicAndSounds.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMusicAndSounds.Name = "rbMusicAndSounds"
        Me.rbMusicAndSounds.Size = New System.Drawing.Size(187, 29)
        Me.rbMusicAndSounds.TabIndex = 91
        Me.rbMusicAndSounds.TabStop = True
        Me.rbMusicAndSounds.Text = "Music and Sounds"
        Me.rbMusicAndSounds.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rbMusicAndSounds)
        Me.GroupBox3.Controls.Add(Me.rbMusicOnly)
        Me.GroupBox3.Controls.Add(Me.rbSoundsOnly)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(37, 300)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(217, 137)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Play:"
        '
        'RepeatTimer
        '
        Me.RepeatTimer.Interval = 1
        '
        'FocusTimer
        '
        Me.FocusTimer.Interval = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblDefaultSettingsInfo)
        Me.GroupBox1.Controls.Add(Me.lblCustomSettingsInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(285, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 96)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information:"
        '
        'lblDefaultSettingsInfo
        '
        Me.lblDefaultSettingsInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultSettingsInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultSettingsInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDefaultSettingsInfo.Location = New System.Drawing.Point(9, 21)
        Me.lblDefaultSettingsInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefaultSettingsInfo.Name = "lblDefaultSettingsInfo"
        Me.lblDefaultSettingsInfo.Size = New System.Drawing.Size(340, 69)
        Me.lblDefaultSettingsInfo.TabIndex = 117
        Me.lblDefaultSettingsInfo.Text = "The options in the ""Load by Default"" and ""Play"" categories cannot be changed. Not" & _
    "e: You can still play music in the list below."
        '
        'lblCustomSettingsInfo
        '
        Me.lblCustomSettingsInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomSettingsInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomSettingsInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomSettingsInfo.Location = New System.Drawing.Point(13, 21)
        Me.lblCustomSettingsInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomSettingsInfo.Name = "lblCustomSettingsInfo"
        Me.lblCustomSettingsInfo.Size = New System.Drawing.Size(336, 69)
        Me.lblCustomSettingsInfo.TabIndex = 118
        Me.lblCustomSettingsInfo.Text = "Choose from a variety of different custom settings below. Note: Any changes you m" & _
    "ake to the settings will be saved."
        '
        'rbCustomSettings
        '
        Me.rbCustomSettings.AutoSize = True
        Me.rbCustomSettings.BackColor = System.Drawing.Color.Transparent
        Me.rbCustomSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomSettings.Location = New System.Drawing.Point(79, 96)
        Me.rbCustomSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbCustomSettings.Name = "rbCustomSettings"
        Me.rbCustomSettings.Size = New System.Drawing.Size(169, 29)
        Me.rbCustomSettings.TabIndex = 120
        Me.rbCustomSettings.Text = "Custom Settings"
        Me.rbCustomSettings.UseVisualStyleBackColor = False
        '
        'rbDefaultSettings
        '
        Me.rbDefaultSettings.AutoSize = True
        Me.rbDefaultSettings.BackColor = System.Drawing.Color.Transparent
        Me.rbDefaultSettings.Checked = True
        Me.rbDefaultSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDefaultSettings.Location = New System.Drawing.Point(80, 59)
        Me.rbDefaultSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbDefaultSettings.Name = "rbDefaultSettings"
        Me.rbDefaultSettings.Size = New System.Drawing.Size(166, 29)
        Me.rbDefaultSettings.TabIndex = 119
        Me.rbDefaultSettings.TabStop = True
        Me.rbDefaultSettings.Text = "Default Settings"
        Me.rbDefaultSettings.UseVisualStyleBackColor = False
        '
        'SaveTimer
        '
        Me.SaveTimer.Interval = 3000
        '
        'lblSettingsSaved
        '
        Me.lblSettingsSaved.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsSaved.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblSettingsSaved.Location = New System.Drawing.Point(369, 460)
        Me.lblSettingsSaved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSettingsSaved.Name = "lblSettingsSaved"
        Me.lblSettingsSaved.Size = New System.Drawing.Size(259, 28)
        Me.lblSettingsSaved.TabIndex = 122
        Me.lblSettingsSaved.Text = "Settings Saved."
        Me.lblSettingsSaved.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picGreenTick
        '
        Me.picGreenTick.BackColor = System.Drawing.Color.Transparent
        Me.picGreenTick.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Green_Tick
        Me.picGreenTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picGreenTick.Location = New System.Drawing.Point(641, 448)
        Me.picGreenTick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picGreenTick.Name = "picGreenTick"
        Me.picGreenTick.Size = New System.Drawing.Size(53, 49)
        Me.picGreenTick.TabIndex = 123
        Me.picGreenTick.TabStop = False
        '
        'cbDisableCaptions
        '
        Me.cbDisableCaptions.AutoSize = True
        Me.cbDisableCaptions.BackColor = System.Drawing.Color.Transparent
        Me.cbDisableCaptions.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cbDisableCaptions.Location = New System.Drawing.Point(44, 459)
        Me.cbDisableCaptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDisableCaptions.Name = "cbDisableCaptions"
        Me.cbDisableCaptions.Size = New System.Drawing.Size(175, 29)
        Me.cbDisableCaptions.TabIndex = 124
        Me.cbDisableCaptions.Text = "Disable Captions"
        Me.cbDisableCaptions.UseVisualStyleBackColor = False
        '
        'linklblWhatsThis
        '
        Me.linklblWhatsThis.AutoSize = True
        Me.linklblWhatsThis.BackColor = System.Drawing.Color.Transparent
        Me.linklblWhatsThis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.linklblWhatsThis.Location = New System.Drawing.Point(225, 462)
        Me.linklblWhatsThis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linklblWhatsThis.Name = "linklblWhatsThis"
        Me.linklblWhatsThis.Size = New System.Drawing.Size(28, 23)
        Me.linklblWhatsThis.TabIndex = 125
        Me.linklblWhatsThis.TabStop = True
        Me.linklblWhatsThis.Text = "(?)"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Settings_Window1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 514)
        Me.Controls.Add(Me.bxSelectMusic)
        Me.Controls.Add(Me.linklblWhatsThis)
        Me.Controls.Add(Me.cbDisableCaptions)
        Me.Controls.Add(Me.picGreenTick)
        Me.Controls.Add(Me.lblSettingsSaved)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbCustomSettings)
        Me.Controls.Add(Me.rbDefaultSettings)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.picSaveGif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bxSelectMusic.ResumeLayout(False)
        CType(Me.OCXMusicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaveGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picGreenTick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bxSelectMusic As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents rbTicTacToe As System.Windows.Forms.RadioButton
    Friend WithEvents rbHangMan As System.Windows.Forms.RadioButton
    Friend WithEvents rbMainMenu As System.Windows.Forms.RadioButton
    Friend WithEvents picSaveGif As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lstMusic As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rbSoundsOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rbMusicOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rbMusicAndSounds As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RepeatTimer As System.Windows.Forms.Timer
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents FocusTimer As System.Windows.Forms.Timer
    Friend WithEvents OCXMusicPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomSettingsInfo As System.Windows.Forms.Label
    Friend WithEvents lblDefaultSettingsInfo As System.Windows.Forms.Label
    Friend WithEvents rbCustomSettings As System.Windows.Forms.RadioButton
    Friend WithEvents rbDefaultSettings As System.Windows.Forms.RadioButton
    Friend WithEvents SaveTimer As System.Windows.Forms.Timer
    Friend WithEvents lblSettingsSaved As System.Windows.Forms.Label
    Friend WithEvents picGreenTick As System.Windows.Forms.PictureBox
    Friend WithEvents cbDisableCaptions As System.Windows.Forms.CheckBox
    Friend WithEvents linklblWhatsThis As System.Windows.Forms.LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstSymbol = New System.Windows.Forms.ListBox()
        Me.ValidTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picValid = New System.Windows.Forms.PictureBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbDefaultList = New System.Windows.Forms.RadioButton()
        Me.rbCustomList = New System.Windows.Forms.RadioButton()
        Me.lblDefaultWordListInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCustomWordListInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCleanList = New System.Windows.Forms.Button()
        Me.lstWordList = New System.Windows.Forms.ListBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.lblWordsAdded = New System.Windows.Forms.Label()
        Me.PicGreenTick = New System.Windows.Forms.PictureBox()
        Me.lblGameSettingsSaved = New System.Windows.Forms.Label()
        Me.picSaveGif = New System.Windows.Forms.PictureBox()
        Me.SaveTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picValid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicGreenTick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaveGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Game Settings"
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
        Me.btnMinimize.TabIndex = 98
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
        Me.btnMaximize.TabIndex = 99
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
        Me.btnClose.TabIndex = 100
        Me.btnClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(717, 485)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'lstSymbol
        '
        Me.lstSymbol.FormattingEnabled = True
        Me.lstSymbol.ItemHeight = 16
        Me.lstSymbol.Items.AddRange(New Object() {"Symbol", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "[", "]", "{", "}", "\", "|", "'", """", ":", ";", "?", "/", ".", ",", ">", "<", "`", "~"})
        Me.lstSymbol.Location = New System.Drawing.Point(397, 62)
        Me.lstSymbol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSymbol.Name = "lstSymbol"
        Me.lstSymbol.Size = New System.Drawing.Size(223, 356)
        Me.lstSymbol.TabIndex = 96
        Me.lstSymbol.Visible = False
        '
        'ValidTimer
        '
        Me.ValidTimer.Interval = 1
        '
        'picValid
        '
        Me.picValid.BackColor = System.Drawing.Color.Transparent
        Me.picValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picValid.Location = New System.Drawing.Point(641, 176)
        Me.picValid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picValid.Name = "picValid"
        Me.picValid.Size = New System.Drawing.Size(40, 37)
        Me.picValid.TabIndex = 86
        Me.picValid.TabStop = False
        '
        'txtWord
        '
        Me.txtWord.Enabled = False
        Me.txtWord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(473, 181)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(159, 27)
        Me.txtWord.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Gray
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(473, 305)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(160, 37)
        Me.btnRemove.TabIndex = 84
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Gray
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(473, 217)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(160, 37)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 436)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Words added:"
        '
        'rbDefaultList
        '
        Me.rbDefaultList.AutoSize = True
        Me.rbDefaultList.BackColor = System.Drawing.Color.Transparent
        Me.rbDefaultList.Checked = True
        Me.rbDefaultList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDefaultList.Location = New System.Drawing.Point(84, 58)
        Me.rbDefaultList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbDefaultList.Name = "rbDefaultList"
        Me.rbDefaultList.Size = New System.Drawing.Size(171, 29)
        Me.rbDefaultList.TabIndex = 115
        Me.rbDefaultList.TabStop = True
        Me.rbDefaultList.Text = "Default word list"
        Me.rbDefaultList.UseVisualStyleBackColor = False
        '
        'rbCustomList
        '
        Me.rbCustomList.AutoSize = True
        Me.rbCustomList.BackColor = System.Drawing.Color.Transparent
        Me.rbCustomList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCustomList.Location = New System.Drawing.Point(83, 95)
        Me.rbCustomList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbCustomList.Name = "rbCustomList"
        Me.rbCustomList.Size = New System.Drawing.Size(174, 29)
        Me.rbCustomList.TabIndex = 116
        Me.rbCustomList.Text = "Custom word list"
        Me.rbCustomList.UseVisualStyleBackColor = False
        '
        'lblDefaultWordListInfo
        '
        Me.lblDefaultWordListInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultWordListInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultWordListInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDefaultWordListInfo.Location = New System.Drawing.Point(9, 21)
        Me.lblDefaultWordListInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefaultWordListInfo.Name = "lblDefaultWordListInfo"
        Me.lblDefaultWordListInfo.Size = New System.Drawing.Size(340, 69)
        Me.lblDefaultWordListInfo.TabIndex = 117
        Me.lblDefaultWordListInfo.Text = "This list contains many different words with lengths ranging from 3-10 characters" & _
    ". Note: You cannot edit the default word list. "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblCustomWordListInfo)
        Me.GroupBox1.Controls.Add(Me.lblDefaultWordListInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(289, 42)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 96)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information:"
        '
        'lblCustomWordListInfo
        '
        Me.lblCustomWordListInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomWordListInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomWordListInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomWordListInfo.Location = New System.Drawing.Point(13, 21)
        Me.lblCustomWordListInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomWordListInfo.Name = "lblCustomWordListInfo"
        Me.lblCustomWordListInfo.Size = New System.Drawing.Size(336, 69)
        Me.lblCustomWordListInfo.TabIndex = 118
        Me.lblCustomWordListInfo.Text = "In this list, you can insert, replace, remove and clean the word list for hang ma" & _
    "n. Note: Alphabetical letters are only permitted. "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Word List:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(468, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Add word:"
        '
        'btnCleanList
        '
        Me.btnCleanList.BackColor = System.Drawing.Color.Gray
        Me.btnCleanList.Enabled = False
        Me.btnCleanList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCleanList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanList.Location = New System.Drawing.Point(473, 395)
        Me.btnCleanList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCleanList.Name = "btnCleanList"
        Me.btnCleanList.Size = New System.Drawing.Size(160, 37)
        Me.btnCleanList.TabIndex = 122
        Me.btnCleanList.Text = "Clean List"
        Me.btnCleanList.UseVisualStyleBackColor = False
        '
        'lstWordList
        '
        Me.lstWordList.BackColor = System.Drawing.Color.Gray
        Me.lstWordList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWordList.FormattingEnabled = True
        Me.lstWordList.HorizontalScrollbar = True
        Me.lstWordList.ItemHeight = 25
        Me.lstWordList.Location = New System.Drawing.Point(43, 181)
        Me.lstWordList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstWordList.Name = "lstWordList"
        Me.lstWordList.Size = New System.Drawing.Size(421, 229)
        Me.lstWordList.TabIndex = 81
        '
        'btnReplace
        '
        Me.btnReplace.BackColor = System.Drawing.Color.Gray
        Me.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplace.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplace.Location = New System.Drawing.Point(473, 261)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(160, 37)
        Me.btnReplace.TabIndex = 123
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = False
        '
        'lblWordsAdded
        '
        Me.lblWordsAdded.BackColor = System.Drawing.Color.Transparent
        Me.lblWordsAdded.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordsAdded.Location = New System.Drawing.Point(175, 436)
        Me.lblWordsAdded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWordsAdded.Name = "lblWordsAdded"
        Me.lblWordsAdded.Size = New System.Drawing.Size(291, 25)
        Me.lblWordsAdded.TabIndex = 124
        Me.lblWordsAdded.Text = "0"
        '
        'PicGreenTick
        '
        Me.PicGreenTick.BackColor = System.Drawing.Color.Transparent
        Me.PicGreenTick.BackgroundImage = CType(resources.GetObject("PicGreenTick.BackgroundImage"), System.Drawing.Image)
        Me.PicGreenTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicGreenTick.Location = New System.Drawing.Point(641, 448)
        Me.PicGreenTick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicGreenTick.Name = "PicGreenTick"
        Me.PicGreenTick.Size = New System.Drawing.Size(53, 49)
        Me.PicGreenTick.TabIndex = 126
        Me.PicGreenTick.TabStop = False
        '
        'lblGameSettingsSaved
        '
        Me.lblGameSettingsSaved.BackColor = System.Drawing.Color.Transparent
        Me.lblGameSettingsSaved.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGameSettingsSaved.Location = New System.Drawing.Point(369, 460)
        Me.lblGameSettingsSaved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGameSettingsSaved.Name = "lblGameSettingsSaved"
        Me.lblGameSettingsSaved.Size = New System.Drawing.Size(259, 28)
        Me.lblGameSettingsSaved.TabIndex = 125
        Me.lblGameSettingsSaved.Text = "Game Settings Saved."
        Me.lblGameSettingsSaved.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picSaveGif
        '
        Me.picSaveGif.BackColor = System.Drawing.Color.Transparent
        Me.picSaveGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSaveGif.Location = New System.Drawing.Point(641, 448)
        Me.picSaveGif.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picSaveGif.Name = "picSaveGif"
        Me.picSaveGif.Size = New System.Drawing.Size(53, 49)
        Me.picSaveGif.TabIndex = 127
        Me.picSaveGif.TabStop = False
        Me.picSaveGif.Visible = False
        '
        'SaveTimer
        '
        Me.SaveTimer.Interval = 3000
        '
        'frmGameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.Settings_Window1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 514)
        Me.Controls.Add(Me.lblGameSettingsSaved)
        Me.Controls.Add(Me.lblWordsAdded)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnCleanList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbCustomList)
        Me.Controls.Add(Me.rbDefaultList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.picValid)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lstWordList)
        Me.Controls.Add(Me.PicGreenTick)
        Me.Controls.Add(Me.picSaveGif)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstSymbol)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGameSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Settings"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicGreenTick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaveGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstSymbol As System.Windows.Forms.ListBox
    Friend WithEvents ValidTimer As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picValid As System.Windows.Forms.PictureBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents rbDefaultList As System.Windows.Forms.RadioButton
    Friend WithEvents rbCustomList As System.Windows.Forms.RadioButton
    Friend WithEvents lblDefaultWordListInfo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomWordListInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCleanList As System.Windows.Forms.Button
    Friend WithEvents lstWordList As System.Windows.Forms.ListBox
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblWordsAdded As System.Windows.Forms.Label
    Friend WithEvents PicGreenTick As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameSettingsSaved As System.Windows.Forms.Label
    Friend WithEvents picSaveGif As System.Windows.Forms.PictureBox
    Friend WithEvents SaveTimer As System.Windows.Forms.Timer
End Class

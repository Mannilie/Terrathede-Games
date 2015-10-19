<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMediaPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMediaPlayer))
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.VLCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tbMediaTrackbar = New System.Windows.Forms.TrackBar()
        Me.txtCurrent = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.tbVolumeTrackbar = New System.Windows.Forms.TrackBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.msImportSongs = New System.Windows.Forms.ToolStripMenuItem()
        Me.msImportMovies = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.frmMoveCancelTool = New System.Windows.Forms.PictureBox()
        Me.btnPlayPause = New System.Windows.Forms.PictureBox()
        Me.lstSongsDGV = New System.Windows.Forms.DataGridView()
        Me.lstSongs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frmTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnFullscreen = New System.Windows.Forms.PictureBox()
        Me.pbImport = New System.Windows.Forms.ProgressBar()
        Me.btnPrevious = New System.Windows.Forms.PictureBox()
        Me.VLCv2 = New AxAXVLC.AxVLCPlugin2()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMediaTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVolumeTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMoveCancelTool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSongsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFullscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Black
        Me.PictureBox7.Location = New System.Drawing.Point(1052, 71)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(1, 684)
        Me.PictureBox7.TabIndex = 62
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Location = New System.Drawing.Point(1425, 65)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 842)
        Me.PictureBox5.TabIndex = 60
        Me.PictureBox5.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(991, 798)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(36, 20)
        Me.txtTotal.TabIndex = 55
        Me.txtTotal.Text = "--:--"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(1052, 63)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1, 716)
        Me.PictureBox3.TabIndex = 54
        Me.PictureBox3.TabStop = False
        '
        'VLCTimer
        '
        '
        'tbMediaTrackbar
        '
        Me.tbMediaTrackbar.AutoSize = False
        Me.tbMediaTrackbar.BackColor = System.Drawing.SystemColors.GrayText
        Me.tbMediaTrackbar.Location = New System.Drawing.Point(76, 794)
        Me.tbMediaTrackbar.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMediaTrackbar.Name = "tbMediaTrackbar"
        Me.tbMediaTrackbar.Size = New System.Drawing.Size(907, 31)
        Me.tbMediaTrackbar.TabIndex = 52
        Me.tbMediaTrackbar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'txtCurrent
        '
        Me.txtCurrent.AutoSize = True
        Me.txtCurrent.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(28, 798)
        Me.txtCurrent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(36, 20)
        Me.txtCurrent.TabIndex = 51
        Me.txtCurrent.Text = "--:--"
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Location = New System.Drawing.Point(1231, -4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(75, 32)
        Me.btnMaximize.TabIndex = 44
        Me.btnMaximize.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.GrayText
        Me.PictureBox6.Location = New System.Drawing.Point(1041, 66)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(13, 688)
        Me.PictureBox6.TabIndex = 61
        Me.PictureBox6.TabStop = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'tbVolumeTrackbar
        '
        Me.tbVolumeTrackbar.AutoSize = False
        Me.tbVolumeTrackbar.BackColor = System.Drawing.SystemColors.GrayText
        Me.tbVolumeTrackbar.LargeChange = 10
        Me.tbVolumeTrackbar.Location = New System.Drawing.Point(981, 161)
        Me.tbVolumeTrackbar.Margin = New System.Windows.Forms.Padding(4)
        Me.tbVolumeTrackbar.Maximum = 100
        Me.tbVolumeTrackbar.Name = "tbVolumeTrackbar"
        Me.tbVolumeTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbVolumeTrackbar.Size = New System.Drawing.Size(60, 530)
        Me.tbVolumeTrackbar.SmallChange = 10
        Me.tbVolumeTrackbar.TabIndex = 56
        Me.tbVolumeTrackbar.TickFrequency = 5
        Me.tbVolumeTrackbar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbVolumeTrackbar.Value = 100
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'lblVolume
        '
        Me.lblVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblVolume.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblVolume.CausesValidation = False
        Me.lblVolume.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVolume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(981, 140)
        Me.lblVolume.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(60, 18)
        Me.lblVolume.TabIndex = 58
        Me.lblVolume.Text = "100%"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1412, 30)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msImportSongs, Me.msImportMovies})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(44, 26)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'msImportSongs
        '
        Me.msImportSongs.Name = "msImportSongs"
        Me.msImportSongs.Size = New System.Drawing.Size(189, 26)
        Me.msImportSongs.Text = "Import Songs..."
        '
        'msImportMovies
        '
        Me.msImportMovies.Enabled = False
        Me.msImportMovies.Name = "msImportMovies"
        Me.msImportMovies.Size = New System.Drawing.Size(189, 26)
        Me.msImportMovies.Text = "Import Movies..."
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Location = New System.Drawing.Point(1161, -4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 32)
        Me.btnMinimize.TabIndex = 43
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1301, -4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 45
        Me.btnClose.TabStop = False
        '
        'frmMoveCancelTool
        '
        Me.frmMoveCancelTool.BackColor = System.Drawing.Color.Transparent
        Me.frmMoveCancelTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.frmMoveCancelTool.Location = New System.Drawing.Point(0, 34)
        Me.frmMoveCancelTool.Margin = New System.Windows.Forms.Padding(4)
        Me.frmMoveCancelTool.Name = "frmMoveCancelTool"
        Me.frmMoveCancelTool.Size = New System.Drawing.Size(1440, 873)
        Me.frmMoveCancelTool.TabIndex = 46
        Me.frmMoveCancelTool.TabStop = False
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPlayPause.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Play_Button
        Me.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayPause.Location = New System.Drawing.Point(41, 832)
        Me.btnPlayPause.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(37, 42)
        Me.btnPlayPause.TabIndex = 63
        Me.btnPlayPause.TabStop = False
        '
        'lstSongsDGV
        '
        Me.lstSongsDGV.AllowUserToAddRows = False
        Me.lstSongsDGV.AllowUserToDeleteRows = False
        Me.lstSongsDGV.AllowUserToResizeColumns = False
        Me.lstSongsDGV.AllowUserToResizeRows = False
        Me.lstSongsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSongsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.lstSongsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.lstSongsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.lstSongsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lstSongs})
        Me.lstSongsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lstSongsDGV.EnableHeadersVisualStyles = False
        Me.lstSongsDGV.GridColor = System.Drawing.Color.Black
        Me.lstSongsDGV.Location = New System.Drawing.Point(1052, 63)
        Me.lstSongsDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSongsDGV.MultiSelect = False
        Me.lstSongsDGV.Name = "lstSongsDGV"
        Me.lstSongsDGV.ReadOnly = True
        Me.lstSongsDGV.RowHeadersVisible = False
        Me.lstSongsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lstSongsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.lstSongsDGV.Size = New System.Drawing.Size(373, 716)
        Me.lstSongsDGV.TabIndex = 50
        '
        'lstSongs
        '
        Me.lstSongs.HeaderText = "Songs:"
        Me.lstSongs.Name = "lstSongs"
        Me.lstSongs.ReadOnly = True
        Me.lstSongs.Width = 283
        '
        'frmTitle
        '
        Me.frmTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.frmTitle.AutoEllipsis = True
        Me.frmTitle.BackColor = System.Drawing.Color.Transparent
        Me.frmTitle.CausesValidation = False
        Me.frmTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTitle.Location = New System.Drawing.Point(12, 9)
        Me.frmTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.frmTitle.Name = "frmTitle"
        Me.frmTitle.Size = New System.Drawing.Size(536, 18)
        Me.frmTitle.TabIndex = 49
        Me.frmTitle.Text = "VLC Media Player"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnNext.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Next_Button
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(189, 832)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 42)
        Me.btnNext.TabIndex = 66
        Me.btnNext.TabStop = False
        '
        'btnFullscreen
        '
        Me.btnFullscreen.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnFullscreen.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fullscreen_Button
        Me.btnFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFullscreen.Location = New System.Drawing.Point(972, 830)
        Me.btnFullscreen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(69, 44)
        Me.btnFullscreen.TabIndex = 67
        Me.btnFullscreen.TabStop = False
        '
        'pbImport
        '
        Me.pbImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbImport.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.pbImport.Location = New System.Drawing.Point(1052, 33)
        Me.pbImport.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImport.Name = "pbImport"
        Me.pbImport.Size = New System.Drawing.Size(373, 30)
        Me.pbImport.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbImport.TabIndex = 68
        Me.pbImport.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPrevious.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Previous_Button
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.Location = New System.Drawing.Point(119, 832)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(63, 42)
        Me.btnPrevious.TabIndex = 70
        Me.btnPrevious.TabStop = False
        '
        'VLCv2
        '
        Me.VLCv2.Enabled = True
        Me.VLCv2.Location = New System.Drawing.Point(15, 58)
        Me.VLCv2.Margin = New System.Windows.Forms.Padding(4)
        Me.VLCv2.Name = "VLCv2"
        Me.VLCv2.OcxState = CType(resources.GetObject("VLCv2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLCv2.Size = New System.Drawing.Size(959, 719)
        Me.VLCv2.TabIndex = 72
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Black
        Me.PictureBox8.Location = New System.Drawing.Point(13, 63)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1412, 1)
        Me.PictureBox8.TabIndex = 73
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(1052, 778)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(373, 1)
        Me.PictureBox4.TabIndex = 74
        Me.PictureBox4.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.GrayText
        Me.PictureBox10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(1052, 778)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(373, 117)
        Me.PictureBox10.TabIndex = 76
        Me.PictureBox10.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(1052, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 1)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'frmMainMediaPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.VLCBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 907)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lstSongsDGV)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.pbImport)
        Me.Controls.Add(Me.btnFullscreen)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.tbMediaTrackbar)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.tbVolumeTrackbar)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.frmTitle)
        Me.Controls.Add(Me.VLCv2)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.frmMoveCancelTool)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMediaPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VLC Media Player"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMediaTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVolumeTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMoveCancelTool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSongsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFullscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents VLCTimer As System.Windows.Forms.Timer
    Friend WithEvents tbMediaTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents txtCurrent As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents tbVolumeTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents frmMoveCancelTool As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents lstSongsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents frmTitle As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msImportSongs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNext As System.Windows.Forms.PictureBox
    Friend WithEvents btnFullscreen As System.Windows.Forms.PictureBox
    Friend WithEvents pbImport As System.Windows.Forms.ProgressBar
    Friend WithEvents msImportMovies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrevious As System.Windows.Forms.PictureBox
    Friend WithEvents VLCv2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstSongs As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

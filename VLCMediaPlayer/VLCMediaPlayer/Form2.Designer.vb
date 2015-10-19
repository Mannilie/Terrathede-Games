<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaximized
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaximized))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msImportSongs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportMoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.tbMediaTrackbar = New System.Windows.Forms.TrackBar()
        Me.txtCurrent = New System.Windows.Forms.Label()
        Me.VLCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.frmTitle = New System.Windows.Forms.Label()
        Me.VLCv2 = New AxAXVLC.AxVLCPlugin2()
        Me.pbImport = New System.Windows.Forms.ProgressBar()
        Me.lstSongsDGV = New System.Windows.Forms.DataGridView()
        Me.lstSongs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbVolumebar = New System.Windows.Forms.TrackBar()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.VolumeBarCountDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picVLCRight = New System.Windows.Forms.PictureBox()
        Me.btnPrevious = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnPlayPause = New System.Windows.Forms.PictureBox()
        Me.picDataGridViewBottom = New System.Windows.Forms.PictureBox()
        Me.picListControls = New System.Windows.Forms.PictureBox()
        Me.picDatagridViewLeft = New System.Windows.Forms.PictureBox()
        Me.MenuStripBlackBar = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.frmMoveTool = New System.Windows.Forms.PictureBox()
        Me.picBlocker = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.tbMediaTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSongsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVolumebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVLCRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDataGridViewBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picListControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDatagridViewLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuStripBlackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMoveTool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(32, 38)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1411, 30)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msImportSongs, Me.ImportMoviesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'msImportSongs
        '
        Me.msImportSongs.Name = "msImportSongs"
        Me.msImportSongs.Size = New System.Drawing.Size(189, 26)
        Me.msImportSongs.Text = "Import Songs..."
        '
        'ImportMoviesToolStripMenuItem
        '
        Me.ImportMoviesToolStripMenuItem.Enabled = False
        Me.ImportMoviesToolStripMenuItem.Name = "ImportMoviesToolStripMenuItem"
        Me.ImportMoviesToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ImportMoviesToolStripMenuItem.Text = "Import Movies..."
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(995, 602)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(36, 20)
        Me.txtTotal.TabIndex = 44
        Me.txtTotal.Text = "--:--"
        '
        'tbMediaTrackbar
        '
        Me.tbMediaTrackbar.AutoSize = False
        Me.tbMediaTrackbar.BackColor = System.Drawing.SystemColors.GrayText
        Me.tbMediaTrackbar.Location = New System.Drawing.Point(80, 598)
        Me.tbMediaTrackbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMediaTrackbar.Name = "tbMediaTrackbar"
        Me.tbMediaTrackbar.Size = New System.Drawing.Size(907, 31)
        Me.tbMediaTrackbar.TabIndex = 43
        Me.tbMediaTrackbar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'txtCurrent
        '
        Me.txtCurrent.AutoSize = True
        Me.txtCurrent.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(32, 602)
        Me.txtCurrent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(36, 20)
        Me.txtCurrent.TabIndex = 42
        Me.txtCurrent.Text = "--:--"
        '
        'VLCTimer
        '
        '
        'frmTitle
        '
        Me.frmTitle.AutoSize = True
        Me.frmTitle.BackColor = System.Drawing.Color.Transparent
        Me.frmTitle.CausesValidation = False
        Me.frmTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTitle.Location = New System.Drawing.Point(9, 5)
        Me.frmTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.frmTitle.Name = "frmTitle"
        Me.frmTitle.Size = New System.Drawing.Size(123, 20)
        Me.frmTitle.TabIndex = 37
        Me.frmTitle.Text = "VLC Media Player"
        '
        'VLCv2
        '
        Me.VLCv2.Enabled = True
        Me.VLCv2.Location = New System.Drawing.Point(18, 73)
        Me.VLCv2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VLCv2.Name = "VLCv2"
        Me.VLCv2.OcxState = CType(resources.GetObject("VLCv2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLCv2.Size = New System.Drawing.Size(795, 497)
        Me.VLCv2.TabIndex = 45
        '
        'pbImport
        '
        Me.pbImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbImport.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.pbImport.Location = New System.Drawing.Point(1052, 46)
        Me.pbImport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbImport.Name = "pbImport"
        Me.pbImport.Size = New System.Drawing.Size(373, 30)
        Me.pbImport.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbImport.TabIndex = 80
        Me.pbImport.Visible = False
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
        Me.lstSongsDGV.Location = New System.Drawing.Point(1052, 46)
        Me.lstSongsDGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSongsDGV.MultiSelect = False
        Me.lstSongsDGV.Name = "lstSongsDGV"
        Me.lstSongsDGV.ReadOnly = True
        Me.lstSongsDGV.RowHeadersVisible = False
        Me.lstSongsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lstSongsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.lstSongsDGV.Size = New System.Drawing.Size(373, 634)
        Me.lstSongsDGV.TabIndex = 78
        '
        'lstSongs
        '
        Me.lstSongs.HeaderText = "Songs:"
        Me.lstSongs.Name = "lstSongs"
        Me.lstSongs.ReadOnly = True
        Me.lstSongs.Width = 283
        '
        'tbVolumebar
        '
        Me.tbVolumebar.AutoSize = False
        Me.tbVolumebar.BackColor = System.Drawing.SystemColors.GrayText
        Me.tbVolumebar.LargeChange = 10
        Me.tbVolumebar.Location = New System.Drawing.Point(812, 105)
        Me.tbVolumebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbVolumebar.Maximum = 100
        Me.tbVolumebar.Name = "tbVolumebar"
        Me.tbVolumebar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbVolumebar.Size = New System.Drawing.Size(60, 486)
        Me.tbVolumebar.SmallChange = 10
        Me.tbVolumebar.TabIndex = 0
        Me.tbVolumebar.TickFrequency = 5
        Me.tbVolumebar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbVolumebar.Value = 100
        '
        'lblVolume
        '
        Me.lblVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblVolume.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblVolume.CausesValidation = False
        Me.lblVolume.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVolume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(812, 86)
        Me.lblVolume.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(60, 18)
        Me.lblVolume.TabIndex = 87
        Me.lblVolume.Text = "100%"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VolumeBarCountDownTimer
        '
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'picVLCRight
        '
        Me.picVLCRight.BackColor = System.Drawing.Color.Black
        Me.picVLCRight.Location = New System.Drawing.Point(719, 97)
        Me.picVLCRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picVLCRight.Name = "picVLCRight"
        Me.picVLCRight.Size = New System.Drawing.Size(1, 684)
        Me.picVLCRight.TabIndex = 91
        Me.picVLCRight.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPrevious.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Previous_Button
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.Location = New System.Drawing.Point(95, 794)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(63, 42)
        Me.btnPrevious.TabIndex = 90
        Me.btnPrevious.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnNext.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Next_Button
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(165, 794)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 42)
        Me.btnNext.TabIndex = 89
        Me.btnNext.TabStop = False
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPlayPause.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Play_Button
        Me.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayPause.Location = New System.Drawing.Point(17, 794)
        Me.btnPlayPause.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(37, 42)
        Me.btnPlayPause.TabIndex = 88
        Me.btnPlayPause.TabStop = False
        '
        'picDataGridViewBottom
        '
        Me.picDataGridViewBottom.BackColor = System.Drawing.Color.Black
        Me.picDataGridViewBottom.Location = New System.Drawing.Point(1052, 754)
        Me.picDataGridViewBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picDataGridViewBottom.Name = "picDataGridViewBottom"
        Me.picDataGridViewBottom.Size = New System.Drawing.Size(373, 1)
        Me.picDataGridViewBottom.TabIndex = 83
        Me.picDataGridViewBottom.TabStop = False
        '
        'picListControls
        '
        Me.picListControls.BackColor = System.Drawing.SystemColors.GrayText
        Me.picListControls.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled
        Me.picListControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picListControls.Location = New System.Drawing.Point(1053, 729)
        Me.picListControls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picListControls.Name = "picListControls"
        Me.picListControls.Size = New System.Drawing.Size(373, 116)
        Me.picListControls.TabIndex = 82
        Me.picListControls.TabStop = False
        '
        'picDatagridViewLeft
        '
        Me.picDatagridViewLeft.BackColor = System.Drawing.Color.Black
        Me.picDatagridViewLeft.Location = New System.Drawing.Point(1052, 38)
        Me.picDatagridViewLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picDatagridViewLeft.Name = "picDatagridViewLeft"
        Me.picDatagridViewLeft.Size = New System.Drawing.Size(1, 716)
        Me.picDatagridViewLeft.TabIndex = 79
        Me.picDatagridViewLeft.TabStop = False
        '
        'MenuStripBlackBar
        '
        Me.MenuStripBlackBar.BackColor = System.Drawing.Color.Black
        Me.MenuStripBlackBar.Location = New System.Drawing.Point(439, 242)
        Me.MenuStripBlackBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MenuStripBlackBar.Name = "MenuStripBlackBar"
        Me.MenuStripBlackBar.Size = New System.Drawing.Size(900, 1)
        Me.MenuStripBlackBar.TabIndex = 84
        Me.MenuStripBlackBar.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(0, 844)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1437, 1)
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3.Location = New System.Drawing.Point(0, 845)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1437, 1)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 846)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1437, 33)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.Location = New System.Drawing.Point(1248, -3)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(72, 32)
        Me.btnMaximize.TabIndex = 32
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1315, -3)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 33
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1179, -3)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(71, 32)
        Me.btnMinimize.TabIndex = 31
        Me.btnMinimize.TabStop = False
        '
        'frmMoveTool
        '
        Me.frmMoveTool.BackColor = System.Drawing.Color.Transparent
        Me.frmMoveTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.frmMoveTool.Location = New System.Drawing.Point(0, 0)
        Me.frmMoveTool.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.frmMoveTool.Name = "frmMoveTool"
        Me.frmMoveTool.Size = New System.Drawing.Size(1437, 33)
        Me.frmMoveTool.TabIndex = 34
        Me.frmMoveTool.TabStop = False
        '
        'picBlocker
        '
        Me.picBlocker.BackColor = System.Drawing.SystemColors.GrayText
        Me.picBlocker.Location = New System.Drawing.Point(932, 0)
        Me.picBlocker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBlocker.Name = "picBlocker"
        Me.picBlocker.Size = New System.Drawing.Size(37, 879)
        Me.picBlocker.TabIndex = 85
        Me.picBlocker.TabStop = False
        '
        'frmMaximized
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1437, 879)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.picVLCRight)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.picDataGridViewBottom)
        Me.Controls.Add(Me.picListControls)
        Me.Controls.Add(Me.picDatagridViewLeft)
        Me.Controls.Add(Me.MenuStripBlackBar)
        Me.Controls.Add(Me.lstSongsDGV)
        Me.Controls.Add(Me.pbImport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.tbMediaTrackbar)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.frmTitle)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.frmMoveTool)
        Me.Controls.Add(Me.picBlocker)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.tbVolumebar)
        Me.Controls.Add(Me.VLCv2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMaximized"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VLC Media Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.tbMediaTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSongsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVolumebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVLCRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDataGridViewBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picListControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDatagridViewLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuStripBlackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMoveTool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msImportSongs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents tbMediaTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents txtCurrent As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents VLCTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents frmTitle As System.Windows.Forms.Label
    Friend WithEvents btnMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents frmMoveTool As System.Windows.Forms.PictureBox
    Friend WithEvents VLCv2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents picDatagridViewLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbImport As System.Windows.Forms.ProgressBar
    Friend WithEvents lstSongsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents picListControls As System.Windows.Forms.PictureBox
    Friend WithEvents picDataGridViewBottom As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStripBlackBar As System.Windows.Forms.PictureBox
    Friend WithEvents picBlocker As System.Windows.Forms.PictureBox
    Friend WithEvents tbVolumebar As System.Windows.Forms.TrackBar
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents ImportMoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrevious As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents VolumeBarCountDownTimer As System.Windows.Forms.Timer
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents picVLCRight As System.Windows.Forms.PictureBox
    Friend WithEvents lstSongs As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

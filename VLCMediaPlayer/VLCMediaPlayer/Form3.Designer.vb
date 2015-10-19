<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFullScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFullScreen))
        Me.timerToolbarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.frmTitle = New System.Windows.Forms.Label()
        Me.MouseMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VolumeBarCounterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.toolTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.Label()
        Me.VLCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VLCv2 = New AxAXVLC.AxVLCPlugin2()
        Me.btnCloseFullscreen = New System.Windows.Forms.PictureBox()
        Me.btnPlayPause = New System.Windows.Forms.PictureBox()
        Me.TopBlackBar = New System.Windows.Forms.PictureBox()
        Me.TopWhiteBar = New System.Windows.Forms.PictureBox()
        Me.TopTaskBar = New System.Windows.Forms.PictureBox()
        Me.BottomBlackbar = New System.Windows.Forms.PictureBox()
        Me.BottomWhitebar = New System.Windows.Forms.PictureBox()
        Me.BottomTaskBar = New System.Windows.Forms.PictureBox()
        Me.btnPrevious = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseFullscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopBlackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopWhiteBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomBlackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomWhitebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerToolbarTimer
        '
        Me.timerToolbarTimer.Interval = 1000
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.SystemColors.GrayText
        Me.TrackBar2.LargeChange = 10
        Me.TrackBar2.Location = New System.Drawing.Point(1092, 167)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(45, 417)
        Me.TrackBar2.SmallChange = 10
        Me.TrackBar2.TabIndex = 37
        Me.TrackBar2.TickFrequency = 5
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar2.Value = 50
        '
        'frmTitle
        '
        Me.frmTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.frmTitle.AutoSize = True
        Me.frmTitle.BackColor = System.Drawing.SystemColors.GrayText
        Me.frmTitle.CausesValidation = False
        Me.frmTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTitle.Location = New System.Drawing.Point(10, 6)
        Me.frmTitle.Name = "frmTitle"
        Me.frmTitle.Size = New System.Drawing.Size(99, 15)
        Me.frmTitle.TabIndex = 47
        Me.frmTitle.Text = "VLC Media Player"
        '
        'MouseMoveTimer
        '
        Me.MouseMoveTimer.Interval = 10
        '
        'VolumeBarCounterTimer
        '
        '
        'lblVolume
        '
        Me.lblVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblVolume.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblVolume.CausesValidation = False
        Me.lblVolume.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVolume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(1092, 152)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(45, 15)
        Me.lblVolume.TabIndex = 48
        Me.lblVolume.Text = "50%"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.GrayText
        Me.TrackBar1.Location = New System.Drawing.Point(76, 663)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(863, 25)
        Me.TrackBar1.TabIndex = 39
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'toolTimer
        '
        Me.toolTimer.Interval = 1000
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(936, 709)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(30, 15)
        Me.txtTotal.TabIndex = 40
        Me.txtTotal.Text = "--:--"
        '
        'txtCurrent
        '
        Me.txtCurrent.AutoSize = True
        Me.txtCurrent.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(214, 709)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(30, 15)
        Me.txtCurrent.TabIndex = 38
        Me.txtCurrent.Text = "--:--"
        '
        'VLCTimer
        '
        '
        'VLCv2
        '
        Me.VLCv2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.VLCv2.Enabled = True
        Me.VLCv2.Location = New System.Drawing.Point(250, 167)
        Me.VLCv2.Name = "VLCv2"
        Me.VLCv2.OcxState = CType(resources.GetObject("VLCv2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLCv2.Size = New System.Drawing.Size(636, 398)
        Me.VLCv2.TabIndex = 49
        '
        'btnCloseFullscreen
        '
        Me.btnCloseFullscreen.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnCloseFullscreen.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Close_Fullscreen_Button
        Me.btnCloseFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseFullscreen.Location = New System.Drawing.Point(1073, 688)
        Me.btnCloseFullscreen.Name = "btnCloseFullscreen"
        Me.btnCloseFullscreen.Size = New System.Drawing.Size(52, 36)
        Me.btnCloseFullscreen.TabIndex = 68
        Me.btnCloseFullscreen.TabStop = False
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPlayPause.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Play_Button
        Me.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayPause.Location = New System.Drawing.Point(13, 690)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(28, 34)
        Me.btnPlayPause.TabIndex = 64
        Me.btnPlayPause.TabStop = False
        '
        'TopBlackBar
        '
        Me.TopBlackBar.BackColor = System.Drawing.Color.Black
        Me.TopBlackBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBlackBar.Location = New System.Drawing.Point(0, 28)
        Me.TopBlackBar.Name = "TopBlackBar"
        Me.TopBlackBar.Size = New System.Drawing.Size(1137, 1)
        Me.TopBlackBar.TabIndex = 46
        Me.TopBlackBar.TabStop = False
        '
        'TopWhiteBar
        '
        Me.TopWhiteBar.BackColor = System.Drawing.Color.White
        Me.TopWhiteBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopWhiteBar.Location = New System.Drawing.Point(0, 27)
        Me.TopWhiteBar.Name = "TopWhiteBar"
        Me.TopWhiteBar.Size = New System.Drawing.Size(1137, 1)
        Me.TopWhiteBar.TabIndex = 45
        Me.TopWhiteBar.TabStop = False
        '
        'TopTaskBar
        '
        Me.TopTaskBar.BackColor = System.Drawing.SystemColors.GrayText
        Me.TopTaskBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopTaskBar.Location = New System.Drawing.Point(0, 0)
        Me.TopTaskBar.Name = "TopTaskBar"
        Me.TopTaskBar.Size = New System.Drawing.Size(1137, 27)
        Me.TopTaskBar.TabIndex = 44
        Me.TopTaskBar.TabStop = False
        '
        'BottomBlackbar
        '
        Me.BottomBlackbar.BackColor = System.Drawing.Color.Black
        Me.BottomBlackbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomBlackbar.Location = New System.Drawing.Point(0, 660)
        Me.BottomBlackbar.Name = "BottomBlackbar"
        Me.BottomBlackbar.Size = New System.Drawing.Size(1137, 1)
        Me.BottomBlackbar.TabIndex = 43
        Me.BottomBlackbar.TabStop = False
        '
        'BottomWhitebar
        '
        Me.BottomWhitebar.BackColor = System.Drawing.Color.White
        Me.BottomWhitebar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomWhitebar.Location = New System.Drawing.Point(0, 661)
        Me.BottomWhitebar.Name = "BottomWhitebar"
        Me.BottomWhitebar.Size = New System.Drawing.Size(1137, 1)
        Me.BottomWhitebar.TabIndex = 42
        Me.BottomWhitebar.TabStop = False
        '
        'BottomTaskBar
        '
        Me.BottomTaskBar.BackColor = System.Drawing.SystemColors.GrayText
        Me.BottomTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomTaskBar.Location = New System.Drawing.Point(0, 662)
        Me.BottomTaskBar.Name = "BottomTaskBar"
        Me.BottomTaskBar.Size = New System.Drawing.Size(1137, 69)
        Me.BottomTaskBar.TabIndex = 41
        Me.BottomTaskBar.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPrevious.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Previous_Button
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.Location = New System.Drawing.Point(59, 690)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(47, 34)
        Me.btnPrevious.TabIndex = 92
        Me.btnPrevious.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnNext.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Next_Button
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(112, 690)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(47, 34)
        Me.btnNext.TabIndex = 91
        Me.btnNext.TabStop = False
        '
        'frmFullScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1137, 731)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCloseFullscreen)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.frmTitle)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TopBlackBar)
        Me.Controls.Add(Me.TopWhiteBar)
        Me.Controls.Add(Me.TopTaskBar)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.BottomBlackbar)
        Me.Controls.Add(Me.BottomWhitebar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.BottomTaskBar)
        Me.Controls.Add(Me.VLCv2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFullScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VLC Media Player"
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLCv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseFullscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopBlackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopWhiteBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomBlackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomWhitebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerToolbarTimer As System.Windows.Forms.Timer
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents frmTitle As System.Windows.Forms.Label
    Friend WithEvents TopBlackBar As System.Windows.Forms.PictureBox
    Friend WithEvents TopWhiteBar As System.Windows.Forms.PictureBox
    Friend WithEvents MouseMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents TopTaskBar As System.Windows.Forms.PictureBox
    Friend WithEvents VolumeBarCounterTimer As System.Windows.Forms.Timer
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents BottomBlackbar As System.Windows.Forms.PictureBox
    Friend WithEvents toolTimer As System.Windows.Forms.Timer
    Friend WithEvents BottomWhitebar As System.Windows.Forms.PictureBox
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents txtCurrent As System.Windows.Forms.Label
    Friend WithEvents BottomTaskBar As System.Windows.Forms.PictureBox
    Friend WithEvents VLCTimer As System.Windows.Forms.Timer
    Friend WithEvents VLCv2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnPlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseFullscreen As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrevious As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.PictureBox
End Class

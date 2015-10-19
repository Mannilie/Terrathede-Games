Public Class frmFullScreen
    Public User As String = SystemInformation.UserName
    Public CurrentPlaylist As String
    Public TogglePlayPause As Boolean = False
    Dim ScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Taskbar As Integer = My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
                If m.Msg = WM_NCLBUTTONDBLCLK Then Return
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub Form4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Timertool > 1 Then
            If Asc(e.KeyChar) = 32 Then
                If VLCv2.playlist.isPlaying Then
                    btnPlayPause.BackgroundImage = My.Resources.Play_Button
                Else
                    btnPlayPause.BackgroundImage = My.Resources.Pause_Button
                End If
                btnPlayPause_MouseUp(Nothing, Nothing)
            End If
            If Asc(e.KeyChar) = 27 Then
                If VLCv2.playlist.isPlaying = False Then
                    frmMainMediaPlayer.player.Stream = My.Resources._exit
                    frmMainMediaPlayer.player.Play()
                    Me.Hide()
                    frmMainMediaPlayer.Show()
                    Exit Sub
                End If
                frmMainMediaPlayer.player.Stream = My.Resources._exit
                frmMainMediaPlayer.player.Play()
                toolTimer.Stop()
                Timertool = 0
                Me.Hide()
                VLCTimer.Stop()
                toolTimer.Stop()
                MouseMoveTimer.Stop()
                timerToolbarTimer.Stop()
                ToolbarTimer = 0
                frmMainMediaPlayer.VLCTimer.Start()
                frmMainMediaPlayer.tbVolumeTrackbar.Value = Me.TrackBar2.Value
                frmMainMediaPlayer.VLCv2.Volume = Me.TrackBar2.Value
                frmMainMediaPlayer.lblVolume.Text = Me.TrackBar2.Value & "%"
                frmMaximized.VLCv2.playlist.add(frmMainMediaPlayer.CurrentPlaylist)
                frmMainMediaPlayer.VLCv2.playlist.play()
                frmMainMediaPlayer.VLCv2.input.Time = TrackBar1.Value + 175
                frmMainMediaPlayer.tbVolumeTrackbar.Focus()
                frmMainMediaPlayer.Show()
                VLCv2.playlist.stop()
            End If
        End If
    End Sub

    Dim Timertool As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMainMediaPlayer.VLCv2.playlist.isPlaying Then
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        Else
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
        End If
        Me.Location = New Point(0, 0)
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - Taskbar)
        VLCv2.Location = New Point(0, 0)
        VLCv2.Size = New Size(ScreenWidth, ScreenHeight - Taskbar)
        frmTitle.Location = New Point(3, 3)
        TrackBar1.Location = New Point(50, ScreenHeight - Taskbar - 68)
        TrackBar2.Location = New Point(ScreenWidth, ScreenHeight / 8 - Taskbar)
        TrackBar2.Size = New Size(45, ScreenHeight / 8 * 5 - Taskbar)
        TrackBar1.Size = New Size(ScreenWidth - 100, ScreenHeight - Taskbar)
        TopTaskBar.Size = New Size(ScreenWidth, 22)
        lblVolume.Location = New Point(ScreenWidth, ScreenHeight / 8 * 2 - 15)
        BottomTaskBar.Size = New Size(ScreenWidth, 69)
        txtCurrent.Location = New Point(20, ScreenHeight - Taskbar - 63)
        txtTotal.Location = New Point(ScreenWidth - 40, ScreenHeight - Taskbar - 63)
        btnPlayPause.Location = New Point(20, ScreenHeight - Taskbar - (87 / 2))
        btnPrevious.Location = New Point(80, ScreenHeight - Taskbar - (87 / 2))
        btnNext.Location = New Point(133, ScreenHeight - Taskbar - (87 / 2))
        btnCloseFullscreen.Location = New Point(ScreenWidth - 50, ScreenHeight - Taskbar - (87 / 2))
        TrackBar2.Focus()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        VLCv2.input.Time = TrackBar1.Value
    End Sub


    Dim infoTimer As System.Windows.Forms.Timer
    Dim status As System.Windows.Forms.Label
    Private Enum InputState
        IDLE = 0
        OPENING = 1
        BUFFERING = 2
        PLAYING = 3
        PAUSED = 4
        STOPPING = 5
        ENDED = 6
        ERRORSTATE = 7
    End Enum
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VLCTimer.Tick
        Dim state As InputState = DirectCast(VLCv2.input.state, InputState)
        Select Case state
            Case InputState.IDLE, InputState.OPENING, InputState.BUFFERING
                Exit Select
            Case InputState.PLAYING
                Dim title As String = System.IO.Path.GetFileName(VLCv2.mediaDescription.title)
                Dim current As TimeSpan = TimeSpan.FromMilliseconds(VLCv2.input.Time)
                Dim total As TimeSpan = TimeSpan.FromMilliseconds(VLCv2.input.Length)
                Dim pos As Double = VLCv2.input.Position
                If title.Contains("_") Then
                    title = title.Replace("_", " ")
                End If
                frmMainMediaPlayer.frmTitle.Text = "VLC Media Player - " & title
                frmMaximized.frmTitle.Text = "VLC Media Player - " & title
                frmTitle.Text = "VLC Media Player - " & title
                frmMainMediaPlayer.Text = "VLC Media Player - " & title
                frmMaximized.Text = "VLC Media Player - " & title
                Me.Text = "VLC Media Player - " & title
                txtCurrent.Text = current.Minutes & ":" & current.Seconds.ToString("00")
                txtTotal.Text = total.Minutes & ":" & total.Seconds.ToString("00")
                Try
                    TrackBar1.Maximum = VLCv2.input.Length
                    TrackBar1.Value = VLCv2.input.Time
                Catch ex As Exception
                End Try
                Exit Select
            Case InputState.ENDED
                btnNext_MouseUp(Nothing, Nothing)
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolTimer.Tick
        Timertool = Timertool + 1
    End Sub
    Dim CurrentMousePosition As String
    Dim ToolbarTimer As Integer
    Dim VolumeBarCountdown As Integer = ScreenWidth - 46
    Dim VolumeBarCounter As Integer = 0
    Dim TitleCountdown As Integer = 3
    Dim TopTaskbarCountdown As Integer = 22
    Dim BottomTrackBarCountdown As Integer = ScreenHeight - Taskbar - 68
    Dim BottomTaskBarCountdown As Integer = ScreenHeight - Taskbar - 69
    Dim BottomToolBarCountdown As Integer = ScreenHeight - Taskbar - 63
    Dim ButtonCountdown As Integer = ScreenHeight - Taskbar - 43
    Dim Paused As Boolean = False
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick
        TrackBar2.Focus()
        If Me.PointToClient(Control.MousePosition).ToString() = CurrentMousePosition Then
            timerToolbarTimer.Start()
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()
        ElseIf Me.ClientRectangle.Contains(PointToClient(Cursor.Position)) = False Then
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()
        Else
            timerToolbarTimer.Stop()
            ToolbarTimer = 0
            TitleCountdown = 3
            TopTaskbarCountdown = 22
            BottomTrackBarCountdown = ScreenHeight - Taskbar - 68
            BottomTaskBarCountdown = 69
            BottomToolBarCountdown = ScreenHeight - Taskbar - 63
            ButtonCountdown = ScreenHeight - Taskbar - 43
            TrackBar1.Location = New Point(50, ScreenHeight - Taskbar - 68)
            TopTaskBar.Size = New Size(ScreenWidth, 22)
            BottomTaskBar.Size = New Size(ScreenWidth, 69)
            txtCurrent.Location = New Point(20, ScreenHeight - Taskbar - 63)
            txtTotal.Location = New Point(ScreenWidth - 40, ScreenHeight - Taskbar - 63)
            frmTitle.Location = New Point(3, 3)
            btnPlayPause.Location = New Point(20, ScreenHeight - Taskbar - (87 / 2))
            btnPrevious.Location = New Point(80, ScreenHeight - Taskbar - (87 / 2))
            btnNext.Location = New Point(133, ScreenHeight - Taskbar - (87 / 2))
            btnCloseFullscreen.Location = New Point(ScreenWidth - 50, ScreenHeight - Taskbar - (87 / 2))
            CurrentMousePosition = Me.PointToClient(Control.MousePosition).ToString()
            TopWhiteBar.Visible = True
            TopBlackBar.Visible = True
            BottomBlackbar.Visible = True
            BottomWhitebar.Visible = True
        End If
        If ToolbarTimer > 1 Then
            TitleCountdown = TitleCountdown - 1
            TopTaskbarCountdown = TopTaskbarCountdown - 1
            BottomTrackBarCountdown = BottomTrackBarCountdown + 2
            BottomTaskBarCountdown = BottomTaskBarCountdown - 2
            BottomToolBarCountdown = BottomToolBarCountdown + 2
            ButtonCountdown = ButtonCountdown + 2
            TopTaskBar.Size = New Size(ScreenWidth, TopTaskbarCountdown)
            BottomTaskBar.Size = New Size(ScreenWidth, BottomTaskBarCountdown)
            TrackBar1.Location = New Point(50, BottomTrackBarCountdown)
            txtCurrent.Location = New Point(20, BottomToolBarCountdown)
            txtTotal.Location = New Point(ScreenWidth - 40, BottomToolBarCountdown)
            frmTitle.Location = New Point(3, TitleCountdown)
            btnPlayPause.Location = New Point(20, ButtonCountdown)
            btnPrevious.Location = New Point(80, ButtonCountdown)
            btnNext.Location = New Point(133, ButtonCountdown)
            btnCloseFullscreen.Location = New Point(ScreenWidth - 50, ButtonCountdown)
            If TopTaskbarCountdown < 0 Then
                TopWhiteBar.Visible = False
                TopBlackBar.Visible = False
            End If
            If BottomTaskBarCountdown < 0 Then
                BottomBlackbar.Visible = False
                BottomWhitebar.Visible = False
            End If
        End If
        If VolumeBarCounter > 10 Then
            VolumeBarCountdown = VolumeBarCountdown + 1
            TrackBar2.Location = New Point(VolumeBarCountdown, ScreenHeight / 14 * 3 - Taskbar)
            lblVolume.Location = New Point(VolumeBarCountdown, ScreenHeight / 14 * 3 - Taskbar - 15)
            If VolumeBarCountdown > ScreenWidth + 1 Then
                VolumeBarCountdown = ScreenWidth - 46
                VolumeBarCounter = 0
                VolumeBarCounterTimer.Stop()
            End If
        End If
    End Sub
   

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerToolbarTimer.Tick
        ToolbarTimer = ToolbarTimer + 1
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        VLCv2.Volume = TrackBar2.Value
        lblVolume.Text = TrackBar2.Value & "%"
        TrackBar2.Location = New Point(ScreenWidth - 45, ScreenHeight / 14 * 3 - Taskbar)
        lblVolume.Location = New Point(ScreenWidth - 45, ScreenHeight / 14 * 3 - Taskbar - 15)
        VolumeBarCounter = 0
        VolumeBarCountdown = ScreenWidth - 46
        VolumeBarCounterTimer.Start()
    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeBarCounterTimer.Tick
        VolumeBarCounter = VolumeBarCounter + 1
    End Sub

    Private Sub btnPlayPause_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlayPause.MouseDown
        If TogglePlayPause = True Then
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        Else
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
        End If
    End Sub

    Private Sub btnPlayPause_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayPause.MouseEnter
        If TogglePlayPause = True Then
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button_Highlighted
        Else
            btnPlayPause.BackgroundImage = My.Resources.Play_Button_Highlighted
        End If
    End Sub

    Private Sub btnPlayPause_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayPause.MouseLeave
        If TogglePlayPause = True Then
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        Else
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
        End If
    End Sub
    Private Sub btnPlayPause_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlayPause.MouseUp
        Dim AppPath As String = Application.StartupPath
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Try
            If TogglePlayPause = True Then
                btnPlayPause.BackgroundImage = My.Resources.Play_Button
                TogglePlayPause = False
                VLCv2.playlist.togglePause()
            Else
                btnPlayPause.BackgroundImage = My.Resources.Pause_Button
                TogglePlayPause = True
                VLCv2.playlist.add("file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value)
                CurrentPlaylist = "file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.play()
                VLCTimer.Start()
                VLCv2.playlist.togglePause()
            End If
        Catch ex As Exception
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            TogglePlayPause = False
            frmMainMediaPlayer.msImportSongs_click(Nothing, Nothing)
        End Try
        frmPlayPause.ShowDialog()
    End Sub


    Private Sub btnCloseFullscreen_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCloseFullscreen.MouseDown
        btnCloseFullscreen.BackgroundImage = My.Resources.Close_Fullscreen_Button
    End Sub

    Private Sub btnCloseFullscreen_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseFullscreen.MouseEnter
        btnCloseFullscreen.BackgroundImage = My.Resources.Close_Fullscreen_Button_highlighted
    End Sub

    Private Sub btnCloseFullscreen_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseFullscreen.MouseLeave
        btnCloseFullscreen.BackgroundImage = My.Resources.Close_Fullscreen_Button
    End Sub

    Private Sub btnCloseFullscreen_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCloseFullscreen.MouseUp
        btnCloseFullscreen.BackgroundImage = My.Resources.Close_Fullscreen_Button
        If TogglePlayPause = False Then
            frmMainMediaPlayer.btnPlayPause.BackgroundImage = My.Resources.Play_Button
            frmMainMediaPlayer.TogglePlayPause = False
        Else
            frmMainMediaPlayer.btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            frmMainMediaPlayer.TogglePlayPause = True
        End If
        frmMainMediaPlayer.VLCv2.playlist.clear()
        frmMainMediaPlayer.player.Stream = My.Resources.back
        frmMainMediaPlayer.player.Play()
        If TogglePlayPause = False Then
            Timertool = 0
            VLCTimer.Stop()
            toolTimer.Stop()
            MouseMoveTimer.Stop()
            timerToolbarTimer.Stop()
            ToolbarTimer = 0
            Me.VLCv2.playlist.stop()
            frmMainMediaPlayer.VLCv2.playlist.clear()
            Try
                frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
            Catch ex As Exception
            End Try
            frmMainMediaPlayer.VLCTimer.Start()
            frmMainMediaPlayer.VLCv2.Volume = TrackBar2.Value
            frmMainMediaPlayer.tbVolumeTrackbar.Value = TrackBar2.Value
            frmMainMediaPlayer.VLCv2.input.Time = Me.TrackBar1.Value + 175
            frmMainMediaPlayer.Show()
            VLCv2.playlist.stop()
            Me.Hide()
        Else
            Timertool = 0
            VLCTimer.Stop()
            toolTimer.Stop()
            MouseMoveTimer.Stop()
            timerToolbarTimer.Stop()
            ToolbarTimer = 0
            Me.VLCv2.playlist.stop()
            frmMainMediaPlayer.VLCv2.playlist.clear()
            frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
            frmMainMediaPlayer.VLCTimer.Start()
            frmMainMediaPlayer.VLCv2.Volume = TrackBar2.Value
            frmMainMediaPlayer.tbVolumeTrackbar.Value = TrackBar2.Value
            frmMainMediaPlayer.VLCv2.playlist.play()
            frmMainMediaPlayer.VLCv2.input.Time = Me.TrackBar1.Value + 175
            frmMainMediaPlayer.Show()
            VLCv2.playlist.stop()
            Me.Hide()
        End If
    End Sub

    Private Sub btnPrevious_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrevious.MouseDown
        btnPrevious.BackgroundImage = My.Resources.Previous_Button
    End Sub
    Private Sub btnPrevious_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.MouseEnter
        btnPrevious.BackgroundImage = My.Resources.Previous_Button_Highlighted
    End Sub
    Private Sub btnPrevious_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.MouseLeave
        btnPrevious.BackgroundImage = My.Resources.Previous_Button
    End Sub
    Private Sub btnPrevious_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrevious.MouseUp
        CurrentMousePosition = 1
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        btnPrevious.BackgroundImage = My.Resources.Previous_Button
        VLCTimer.Stop()
        VLCv2.playlist.stop()
        VLCv2.playlist.clear()
        frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        TogglePlayPause = True
        If TrackBar1.Value <= 5000 Then
            If frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index = 0 Then
                frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.lstSongsDGV.Rows.Count - 1
                frmMainMediaPlayer.lstSongsDGV.ClearSelection()
                frmMainMediaPlayer.lstSongsDGV.CurrentCell = frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
                frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
                VLCv2.playlist.clear()
                frmMainMediaPlayer.Media = frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                If frmMainMediaPlayer.Media.Contains(".mp4") Or frmMainMediaPlayer.Media.Contains(".wmv") Or frmMainMediaPlayer.Media.Contains(".avi") Then
                    CurrentPlaylist = "file:///" & FullMediaDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                    VLCv2.playlist.add(CurrentPlaylist)
                    VLCv2.playlist.play()
                    VLCTimer.Start()
                    Exit Sub
                End If
                CurrentPlaylist = "file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                VLCTimer.Start()
                Exit Sub
            Else
                frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.SongIndex - 1
                frmMainMediaPlayer.lstSongsDGV.ClearSelection()
                frmMainMediaPlayer.lstSongsDGV.CurrentCell = frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
                frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
                frmMainMediaPlayer.Media = frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                If frmMainMediaPlayer.Media.Contains(".mp4") Or frmMainMediaPlayer.Media.Contains(".wmv") Or frmMainMediaPlayer.Media.Contains(".avi") Then
                    CurrentPlaylist = "file:///" & FullMediaDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                    VLCv2.playlist.add(CurrentPlaylist)
                    VLCv2.playlist.play()
                    VLCTimer.Start()
                    Exit Sub
                End If
                CurrentPlaylist = "file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
            End If
            VLCTimer.Start()
        Else
            VLCv2.playlist.stop()
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
            VLCTimer.Start()
        End If
    End Sub

    Private Sub btnNext_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseDown
        btnNext.BackgroundImage = My.Resources.Next_Button
    End Sub
    Private Sub btnNext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.MouseEnter
        btnNext.BackgroundImage = My.Resources.Next_Button_Highlighted
    End Sub
    Private Sub btnNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.MouseLeave
        btnNext.BackgroundImage = My.Resources.Next_Button
    End Sub
    Private Sub btnNext_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseUp
        CurrentMousePosition = 1
        btnNext.BackgroundImage = My.Resources.Next_Button
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        VLCv2.playlist.stop()
        VLCv2.playlist.clear()
        VLCTimer.Start()
        frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index
        If frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index = frmMainMediaPlayer.lstSongsDGV.Rows.Count - 1 Then
            frmMainMediaPlayer.SongIndex = 0
            frmMainMediaPlayer.lstSongsDGV.ClearSelection()
            frmMainMediaPlayer.lstSongsDGV.CurrentCell = frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
            frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
            VLCv2.playlist.clear()
            frmMainMediaPlayer.Media = frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
            If frmMainMediaPlayer.Media.Contains(".mp4") Or frmMainMediaPlayer.Media.Contains(".wmv") Or frmMainMediaPlayer.Media.Contains(".avi") Then
                CurrentPlaylist = "file:///" & FullMediaDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                Exit Sub
            End If
            CurrentPlaylist = "file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
            Exit Sub
        Else
            frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.SongIndex + 1
            frmMainMediaPlayer.lstSongsDGV.ClearSelection()
            frmMainMediaPlayer.lstSongsDGV.CurrentCell = frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
            frmMainMediaPlayer.lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
            frmMainMediaPlayer.Media = frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
            If frmMainMediaPlayer.Media.Contains(".mp4") Or frmMainMediaPlayer.Media.Contains(".wmv") Or frmMainMediaPlayer.Media.Contains(".avi") Then
                CurrentPlaylist = "file:///" & FullMediaDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                Exit Sub
            End If
            CurrentPlaylist = "file:///" & FullDirectory & frmMainMediaPlayer.lstSongsDGV.Item(0, frmMainMediaPlayer.lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
        End If
    End Sub


    Private Sub TrackBar2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TrackBar2.KeyDown
        If e.KeyCode = Keys.Right Then
            e.Handled = True
        End If
        If e.KeyCode = Keys.Left Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmFullScreen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            btnNext_MouseUp(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Left Then
            btnPrevious_MouseUp(Nothing, Nothing)
        End If
    End Sub


End Class

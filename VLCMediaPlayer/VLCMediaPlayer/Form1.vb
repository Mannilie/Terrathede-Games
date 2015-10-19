Imports System.IO
Public Class frmMainMediaPlayer
    'Variables
    Public User As String = SystemInformation.UserName
    Public AppPath As String = Application.StartupPath
    Public Files(10000) As String
    Public MaxCounter As Integer
    Public Songs(100000) As String
    Public SongIndex As Integer
    Public Media As String
    Public TogglePlayPause As Boolean = False
    Dim CloseTimer As Integer
    Dim infoTimer As System.Windows.Forms.Timer
    Dim status As System.Windows.Forms.Label
    Dim MediaFileString(10000) As String
    Dim BrowserFile As String
    Dim SongName As String
    Dim SongTitle As String
    Dim DeleteNumber As Integer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public WithEvents player As New System.Media.SoundPlayer
    Dim ToggleOff As Boolean = False
    Dim ScreenExit As Boolean = False
    Public CurrentPlaylist As String
    Dim VolumeBarCountdown As Integer = 736
    Dim VolumeBarCounter As Integer = 0
    Dim ScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Taskbar As Integer = My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height

    Private Sub btnMinimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Pushed
    End Sub
    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button_Highlighted
    End Sub
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
    End Sub
    Private Sub btnMinimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseUp
        btnMinimize.BackgroundImage = My.Resources.Minimize_Button
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Maximize Button Events
    Private Sub btnMaximize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMaximize.MouseDown
        btnMaximize.BackgroundImage = My.Resources.Maximize_Button_Pushed
    End Sub
    Private Sub btnMaximize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaximize.MouseEnter
        btnMaximize.BackgroundImage = My.Resources.Maximize_Button_Highlighted
    End Sub
    Private Sub btnMaximize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaximize.MouseLeave
        btnMaximize.BackgroundImage = My.Resources.Maximize_Button
    End Sub
    Private Sub btnMaximize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMaximize.MouseUp
        If TogglePlayPause = False Then
            frmMaximized.btnPlayPause.BackgroundImage = My.Resources.Play_Button
            frmMaximized.TogglePlayPause = False
        Else
            frmMaximized.btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            frmMaximized.TogglePlayPause = True
        End If
        player.Stream = My.Resources._select
        player.Play()
        frmMaximized.CurrentPlaylist = CurrentPlaylist
        frmMaximized.GetMediaFiles()
        frmMaximized.VolumeBarCountDownTimer.Start()
        If VLCv2.playlist.isPlaying = False Then
            If Not CurrentPlaylist = "" Then
                frmMaximized.VLCv2.playlist.clear()
                frmMaximized.VLCv2.playlist.add(CurrentPlaylist)
                frmMaximized.VLCv2.input.Time = tbMediaTrackbar.Value + 175
                Me.VLCv2.playlist.stop()
                Me.Hide()
                frmMaximized.VolumeBarCountDownTimer.Start()
                frmMaximized.MouseMoveTimer.Start()
                frmMaximized.Show()
                Exit Sub
            Else
                Me.VLCv2.playlist.stop()
                Me.Hide()
                frmMaximized.VolumeBarCountDownTimer.Start()
                frmMaximized.MouseMoveTimer.Start()
                frmMaximized.Show()
                Exit Sub
            End If
        End If
        Me.VLCv2.playlist.stop()
        frmMaximized.VLCv2.playlist.clear()
        frmMaximized.VLCv2.playlist.add(CurrentPlaylist)
        frmMaximized.VLCTimer.Start()
        frmMaximized.MouseMoveTimer.Start()
        frmMaximized.VLCv2.Volume = tbVolumeTrackbar.Value
        frmMaximized.tbVolumebar.Value = tbVolumeTrackbar.Value
        frmMaximized.VLCv2.playlist.play()
        frmMaximized.VLCv2.input.Time = Me.tbMediaTrackbar.Value + 175
        frmMaximized.Show()
        VLCv2.playlist.stop()
        Me.Hide()
    End Sub

    'Exit Button Events
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.Exit_Button_Pushed
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.Exit_Button_Highlighted
        ScreenExit = True
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.Exit_Button
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.Exit_Button
        End
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 32 Then
            If VLCv2.playlist.isPlaying Then
                btnPlayPause.BackgroundImage = My.Resources.Play_Button
            Else
                btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            End If
            btnPlayPause_MouseUp(Nothing, Nothing)
        End If
    End Sub
    Public Sub GetMediaFiles()
        Dim fileNames = My.Computer.FileSystem.GetFiles("C:\Users\" + User + "\Music\Terrathede Games Music", FileIO.SearchOption.SearchAllSubDirectories)
        lstSongsDGV.Rows.Clear()
        MaxCounter = fileNames.count
        For x = 0 To MaxCounter - 1
            Files(x) = fileNames(x)
            Files(x) = Files(x).Substring(Files(x).LastIndexOf("\") + 1)
            Songs(x) = fileNames(x)
        Next
        For i = 0 To MaxCounter - 1
            lstSongsDGV.Rows.Add(Files(i))
        Next
    End Sub


    Private Sub FrmMainMediaPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists("C:\Users\" + User + "\Music\Terrathede Games Music")) Then
            System.IO.Directory.CreateDirectory("C:\Users\" + User + "\Music\Terrathede Games Music")
        End If
        GetMediaFiles()
        Timer2.Start()
        Timer3.Start()
        Me.TransparencyKey = Me.BackColor
    End Sub
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
    Private Sub VLCTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles VLCTimer.Tick
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
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
                SongTitle = title
                frmFullScreen.frmTitle.Text = "VLC Media Player - " & title
                frmMaximized.frmTitle.Text = "VLC Media Player - " & title
                frmTitle.Text = "VLC Media Player - " & title
                frmFullScreen.Text = "VLC Media Player - " & title
                frmMaximized.Text = "VLC Media Player - " & title
                Me.Text = "VLC Media Player - " & title
                txtCurrent.Text = current.Minutes & ":" & current.Seconds.ToString("00")
                txtTotal.Text = total.Minutes & ":" & total.Seconds.ToString("00")
                Try
                    tbMediaTrackbar.Maximum = VLCv2.input.Length
                    tbMediaTrackbar.Value = VLCv2.input.Time
                Catch ex As Exception
                End Try
                Exit Select
            Case InputState.ENDED
                btnNext_MouseUp(Nothing, Nothing)
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMediaTrackbar.Scroll
        VLCv2.input.Time = tbMediaTrackbar.Value
    End Sub
    Private Sub frmMoveTool_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMoveCancelTool.DoubleClick
        btnMaximize_MouseUp(sender, e)
    End Sub

    Private Sub frmTitle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmTitle.DoubleClick
        btnMaximize_MouseUp(sender, e)
    End Sub


    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVolumeTrackbar.Scroll
        lblVolume.Text = tbVolumeTrackbar.Value & "%"
        VLCv2.Volume = tbVolumeTrackbar.Value
        tbVolumeTrackbar.Location = New Point(736, 131)
        lblVolume.Location = New Point(736, 116)
        VolumeBarCounter = 0
        VolumeBarCountdown = 736
        Timer2.Start()
    End Sub

    Private Sub btnFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If TogglePlayPause = False Then
            frmFullScreen.btnPlayPause.BackgroundImage = My.Resources.Play_Button
            frmFullScreen.TogglePlayPause = False
        Else
            frmFullScreen.btnPlayPause.BackgroundImage = My.Resources.Pause_Button

            frmFullScreen.TogglePlayPause = True
        End If
        player.Stream = My.Resources._select
        player.Play()
        If VLCv2.playlist.isPlaying = False Then
            player.Stream = My.Resources._select
            player.Play()
            Me.Hide()
            frmFullScreen.VLCTimer.Start()
            frmFullScreen.toolTimer.Start()
            frmFullScreen.Show()
            Exit Sub
        End If
        frmFullScreen.CurrentPlaylist = CurrentPlaylist
        VLCTimer.Stop()
        frmFullScreen.toolTimer.Start()
        frmFullScreen.VLCv2.playlist.clear()
        frmFullScreen.VLCv2.playlist.add(CurrentPlaylist)
        frmFullScreen.VLCTimer.Start()
        frmFullScreen.MouseMoveTimer.Start()
        frmFullScreen.timerToolbarTimer.Start()
        frmFullScreen.VLCv2.Volume = tbVolumeTrackbar.Value
        frmFullScreen.TrackBar2.Value = tbVolumeTrackbar.Value
        frmFullScreen.VLCv2.playlist.play()
        frmFullScreen.VLCv2.input.Time = Me.tbMediaTrackbar.Value + 175
        frmFullScreen.Show()
        VLCv2.playlist.stop()
        Me.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        VolumeBarCounter = VolumeBarCounter + 1
        If VolumeBarCounter > 100 Then
            VolumeBarCountdown = VolumeBarCountdown + 1
            tbVolumeTrackbar.Location = New Point(VolumeBarCountdown, 131)
            lblVolume.Location = New Point(VolumeBarCountdown, 131 - 15)
            If VolumeBarCountdown > ScreenWidth + 1 Then
                VolumeBarCountdown = ScreenWidth - 46
                VolumeBarCounter = 0
                Timer2.Stop()
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If btnFullScreen.Focused = True Then
            Exit Sub
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Me.Close()
        frmMaximized.Close()
    End Sub

    Public Sub msImportSongs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msImportSongs.Click
        Dim Open_File As New OpenFileDialog
        With Open_File
            .Filter = "Media Files (*.wmv;*.m4a;*.mp3;)|*.wmv;*.m4a;*.mp3;)"
            .FileName = ""
            .Multiselect = True
        End With
        Dim CurrentSong As String
        If Open_File.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
            pbImport.Visible = True
            Dim destination As String
            Dim path As String
            path = Open_File.FileName
            Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\" & Open_File.SafeFileName
            pbImport.Value = 0
            pbImport.Maximum = Open_File.FileNames.Count
            If Open_File.FileNames.Count = 1 Then
                For i = 0 To lstSongsDGV.Rows.Count - 1
                    If Open_File.SafeFileNames(0) = lstSongsDGV.Item(0, i).Value Then
                        lstSongsDGV.Refresh()
                        lstSongsDGV.CurrentCell = lstSongsDGV.Rows(i).Cells(0)
                        lstSongsDGV.Rows(i).Selected = True
                        CurrentSong = Open_File.FileNames(0)
                        CurrentPlaylist = "file:///" & CurrentSong
                        VLCv2.playlist.add(CurrentPlaylist)
                        VLCv2.playlist.play()
                        btnPlayPause.BackgroundImage = My.Resources.Play_Button
                        TogglePlayPause = False
                        Exit Sub
                    End If
                Next
            End If
            If Open_File.FileNames.Count > 60 Then
                Dim MessageBoxResult As String
                MessageBoxResult = MsgBox("You are currently importing " & Open_File.FileNames.Count & " Media Files to the program. It is recommended to move the files over to 'Terrathede Games Music' In the 'Music' folder of your system. Note: Select 'No' to proceed with copying the files to the folder." & vbCrLf & vbCrLf & "Would you like to move the files?", vbYesNoCancel + vbInformation, "Media Files")
                If MessageBoxResult = vbYes Then
                    While pbImport.Value < pbImport.Maximum
                        destination = "C:\Users\" + User + "\Music\Terrathede Games Music\" & Open_File.SafeFileNames(pbImport.Value)
                        path = Open_File.FileNames(pbImport.Value)
                        If File.Exists(path) And Not File.Exists(destination) Then
                            File.Move(path, destination)
                            lstSongsDGV.Rows.Add(Open_File.SafeFileNames(pbImport.Value))
                            lstSongsDGV.Refresh()
                        End If
                        pbImport.Value = pbImport.Value + 1
                    End While
                    destination = FullDirectory
                    If File.Exists(path) And Not File.Exists(destination) Then
                        File.Move(path, destination)
                        lstSongsDGV.Rows.Add(Open_File.SafeFileName)
                        ToggleOff = True
                        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
                        CurrentPlaylist = "file:///" & Open_File.FileName
                        frmMaximized.VLCv2.playlist.add(CurrentPlaylist)
                        VLCv2.playlist.stop()
                        VLCv2.playlist.items.clear()
                        VLCv2.playlist.add("File:///" & Open_File.FileName)
                        VLCv2.playlist.play()
                        VLCTimer.Start()
                        lstSongsDGV.Rows.Add(SongTitle)
                        lstSongsDGV.Refresh()
                    End If
                    pbImport.Visible = False
                    btnPlayPause.BackgroundImage = My.Resources.Play_Button
                    TogglePlayPause = False
                    Exit Sub
                End If
            End If
            While pbImport.Value < pbImport.Maximum
                destination = "C:\Users\" + User + "\Music\Terrathede Games Music\" & Open_File.SafeFileNames(pbImport.Value)
                path = Open_File.FileNames(pbImport.Value)
                If File.Exists(path) And Not File.Exists(destination) Then
                    File.Copy(path, destination)
                    lstSongsDGV.Rows.Add(Open_File.SafeFileNames(pbImport.Value))
                    lstSongsDGV.Refresh()
                End If
                pbImport.Value = pbImport.Value + 1
            End While
            destination = FullDirectory
            If File.Exists(path) And Not File.Exists(destination) Then
                File.Copy(path, destination)
                lstSongsDGV.Rows.Add(Open_File.SafeFileName)
                lstSongsDGV.Refresh()
                ToggleOff = True
                btnPlayPause.BackgroundImage = My.Resources.Pause_Button
                CurrentPlaylist = "file:///" & Open_File.FileName
                frmMaximized.VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.stop()
                VLCv2.playlist.items.clear()
                VLCv2.playlist.add("File:///" & Open_File.FileName)
                VLCv2.playlist.play()
                VLCTimer.Start()
                lstSongsDGV.Rows.Add(SongTitle)
            End If
            pbImport.Visible = False
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
            TogglePlayPause = False
        End If
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
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Try
            If TogglePlayPause = True Then
                btnPlayPause.BackgroundImage = My.Resources.Play_Button
                TogglePlayPause = False
                VLCv2.playlist.togglePause()
            Else
                btnPlayPause.BackgroundImage = My.Resources.Pause_Button
                TogglePlayPause = True
                VLCv2.playlist.add("file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value)
                CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.play()
                VLCv2.input.Time = tbMediaTrackbar.Value
                VLCTimer.Start()
                VLCv2.playlist.togglePause()
            End If
        Catch ex As Exception
            btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            TogglePlayPause = False
            msImportSongs_click(Nothing, Nothing)
        End Try
    End Sub

    Private Sub btnFullscreen_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFullscreen.MouseDown
        btnFullscreen.BackgroundImage = My.Resources.Fullscreen_Button
    End Sub
    Private Sub btnFullscreen_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullscreen.MouseEnter
        btnFullscreen.BackgroundImage = My.Resources.Fullscreen_Button_Highlighted1
    End Sub
    Private Sub btnFullscreen_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFullscreen.MouseLeave
        btnFullscreen.BackgroundImage = My.Resources.Fullscreen_Button
    End Sub
    Private Sub btnFullscreen_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFullscreen.MouseUp
        btnFullscreen.BackgroundImage = My.Resources.Fullscreen_Button
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
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        btnPrevious.BackgroundImage = My.Resources.Previous_Button
        VLCTimer.Stop()
        VLCv2.playlist.stop()
        VLCv2.playlist.clear()
        SongIndex = lstSongsDGV.CurrentRow.Index
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        TogglePlayPause = True
        If tbMediaTrackbar.Value <= 5000 Then
            If lstSongsDGV.CurrentRow.Index = 0 Then
                SongIndex = lstSongsDGV.Rows.Count - 1
                lstSongsDGV.ClearSelection()
                lstSongsDGV.CurrentCell = lstSongsDGV.Rows(SongIndex).Cells(0)
                lstSongsDGV.Rows(SongIndex).Selected = True
                VLCv2.playlist.clear()
                Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
                    CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                    VLCv2.playlist.add(CurrentPlaylist)
                    VLCv2.playlist.play()
                    VLCTimer.Start()
                    Exit Sub
                End If
                CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                VLCTimer.Start()
                Exit Sub
            Else
                SongIndex = SongIndex - 1
                lstSongsDGV.ClearSelection()
                lstSongsDGV.CurrentCell = lstSongsDGV.Rows(SongIndex).Cells(0)
                lstSongsDGV.Rows(SongIndex).Selected = True
                Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
                    CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                    VLCv2.playlist.add(CurrentPlaylist)
                    VLCv2.playlist.play()
                    VLCTimer.Start()
                    Exit Sub
                End If
                CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
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
        btnNext.BackgroundImage = My.Resources.Next_Button
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        VLCv2.playlist.stop()
        VLCv2.playlist.clear()
        SongIndex = lstSongsDGV.CurrentRow.Index
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        TogglePlayPause = True
        If lstSongsDGV.CurrentRow.Index = lstSongsDGV.Rows.Count - 1 Then
            SongIndex = 0
            lstSongsDGV.ClearSelection()
            lstSongsDGV.CurrentCell = lstSongsDGV.Rows(SongIndex).Cells(0)
            lstSongsDGV.Rows(SongIndex).Selected = True
            VLCv2.playlist.clear()
            Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
                CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                Exit Sub
            End If
            CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.clear()
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
            Exit Sub
        Else
            SongIndex = SongIndex + 1
            lstSongsDGV.ClearSelection()
            lstSongsDGV.CurrentCell = lstSongsDGV.Rows(SongIndex).Cells(0)
            lstSongsDGV.Rows(SongIndex).Selected = True
            Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
                CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
                VLCv2.playlist.clear()
                VLCv2.playlist.add(CurrentPlaylist)
                VLCv2.playlist.play()
                Exit Sub
            End If
            CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.clear()
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
        End If
    End Sub

    Private Sub DataGridView1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSongsDGV.MouseEnter
        lstSongsDGV.Focus()
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSongsDGV.MouseLeave
        tbVolumeTrackbar.Focus()
    End Sub

    Private Sub TrackBar1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMediaTrackbar.MouseLeave
        tbVolumeTrackbar.Focus()
    End Sub
    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstSongsDGV.MouseDoubleClick
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        TogglePlayPause = True
        VLCTimer.Start()
        VLCv2.playlist.clear()
        Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
        If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
            CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
            Exit Sub
        End If
        CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
        VLCv2.playlist.add(CurrentPlaylist)
        VLCv2.playlist.play()
    End Sub

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

    Private Sub frmMainMediaPlayer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            btnNext_MouseUp(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Left Then
            btnPrevious_MouseUp(Nothing, Nothing)
        End If
    End Sub

    Private Sub tbVolumeTrackbar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbVolumeTrackbar.KeyDown
        If e.KeyCode = Keys.Right Then
            e.Handled = True
        End If
        If e.KeyCode = Keys.Left Then
            e.Handled = True
        End If
    End Sub
End Class


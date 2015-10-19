Imports System.IO
Public Class frmMaximized
    Public User As String = SystemInformation.UserName
    Public CurrentPlaylist As String
    Public TogglePlayPause As Boolean = False
    Dim SongIndex As Integer
    Dim SongTitle As String
    Dim Media As String
    Dim AppPath As String = Application.StartupPath
    Dim ScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    'Minimize Button Events
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
        VLCv2.Refresh()
        If TogglePlayPause = False Then
            frmMainMediaPlayer.btnPlayPause.BackgroundImage = My.Resources.Play_Button
            frmMainMediaPlayer.TogglePlayPause = False
        Else
            frmMainMediaPlayer.btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            frmMainMediaPlayer.TogglePlayPause = True
        End If
        player.Stream = My.Resources.back
        player.Play()
        frmMainMediaPlayer.GetMediaFiles()
        frmMainMediaPlayer.CurrentPlaylist = CurrentPlaylist
        frmMainMediaPlayer.VLCv2.Volume = tbVolumebar.Value
        frmMainMediaPlayer.tbVolumeTrackbar.Value = tbVolumebar.Value
        If VLCv2.playlist.isPlaying = False Then
            If Not CurrentPlaylist = "" Then
                frmMainMediaPlayer.VLCv2.playlist.clear()
                frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
                frmMainMediaPlayer.VLCv2.input.Time = tbMediaTrackbar.Value + 175
                Me.VLCv2.playlist.stop()
                Me.Hide()
                frmMainMediaPlayer.Show()
                Exit Sub
            Else
                Me.VLCv2.playlist.stop()
                Me.Hide()
                frmMainMediaPlayer.Show()
                Exit Sub
            End If
        End If
        Me.VLCv2.playlist.stop()
        frmMainMediaPlayer.VLCv2.playlist.clear()
        frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
        frmMainMediaPlayer.VLCTimer.Start()
        frmMainMediaPlayer.VLCv2.Volume = tbVolumebar.Value
        frmMainMediaPlayer.tbVolumeTrackbar.Value = tbVolumebar.Value
        frmMainMediaPlayer.VLCv2.playlist.play()
        frmMainMediaPlayer.VLCv2.input.Time = Me.tbMediaTrackbar.Value + 175
        frmMainMediaPlayer.Show()
        VLCv2.playlist.stop()
        Me.Hide()
    End Sub
    Private Sub lstSongsDGV_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstSongsDGV.MouseDoubleClick
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        VLCTimer.Start()
        VLCv2.playlist.clear()
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        TogglePlayPause = True
        If lstSongsDGV.Rows.Count <= 0 Then
            Exit Sub
        End If
        Media = lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
        If Media.Contains(".mp4") Or Media.Contains(".wmv") Or Media.Contains(".avi") Then
            CurrentPlaylist = "file:///" & FullMediaDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
            VLCv2.playlist.add(CurrentPlaylist)
            VLCv2.playlist.play()
            Exit Sub
        End If
        CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
        frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
        VLCv2.playlist.add(CurrentPlaylist)
        VLCv2.playlist.play()
    End Sub
    'Exit Button Events
    Private Sub btnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.Exit_Button_Pushed
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.Exit_Button_Highlighted
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.Exit_Button
    End Sub
    Private Sub btnClose_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.Exit_Button
        Me.Close()
        frmMainMediaPlayer.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ScreenWidth = 1920 And ScreenHeight = 1080 Then
            BackgroundImage = My.Resources.Resolution_1920x1080_2
        End If
        If ScreenWidth = 1280 And ScreenHeight = 800 Then
            BackgroundImage = My.Resources.Resolution_1280x800_2
        End If
        If ScreenWidth = 1366 And ScreenHeight = 768 Then
            BackgroundImage = My.Resources.Resolution_1366x768_2
        End If
        If ScreenWidth = 1024 And ScreenHeight = 768 Then

        End If
        Dim Taskbar As Integer
        Taskbar = My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height
        Me.Location = New Point(0, 0)
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - Taskbar)
        frmTitle.Location = New Point(10, 3)
        MenuStrip1.Size = New Size(ScreenWidth, 24)
        MenuStrip1.Location = New Point(0, 23)
        MenuStripBlackBar.Location = New Point(0, 47)
        MenuStripBlackBar.Size = New Size(ScreenWidth, 1)
        VLCv2.Location = New Point(5, 53)
        'Volume bars
        tbVolumebar.Location = New Point(ScreenWidth - 330, ScreenHeight / 8 + Taskbar)
        tbVolumebar.Size = New Size(45, ScreenHeight / 8 * 5 - Taskbar)

        lblVolume.Location = New Point(ScreenWidth - 330, ScreenHeight / 8 + Taskbar - 15)
        pbImport.Location = New Point(ScreenWidth - 280, 23)
        picBlocker.Location = New Point(ScreenWidth - 285, 0)
        picBlocker.Size = New Size(ScreenWidth / 2, ScreenHeight)
        picVLCRight.Location = New Point(ScreenWidth - 286, 53)
        picVLCRight.Size = New Size(1, ScreenHeight - 216)
        'Buttons
        btnPlayPause.Location = New Point(20, ScreenHeight - Taskbar - 77)
        btnPrevious.Location = New Point(80, ScreenHeight - Taskbar - 77)
        btnNext.Location = New Point(133, ScreenHeight - Taskbar - 77)
        'Others
        VLCv2.Size = New Size(ScreenWidth - 291, ScreenHeight - 216)
        lstSongsDGV.Location = New Point(ScreenWidth - 280, 47)
        lstSongsDGV.Size = New Size(280, ScreenHeight - 210)
        picDatagridViewLeft.Location = New Point(ScreenWidth - 280, 47)
        picDatagridViewLeft.Size = New Size(1, ScreenHeight - 210)
        picDataGridViewBottom.Location = New Point(ScreenWidth - 280, ScreenHeight - 123 - Taskbar)
        picListControls.Location = New Point(ScreenWidth - 280, ScreenHeight - 123 - Taskbar)
        btnClose.Location = New Point(ScreenWidth - 115, -3)
        btnMaximize.Location = New Point(ScreenWidth - 167, -3)
        btnMinimize.Location = New Point(ScreenWidth - 217, -3)
        tbMediaTrackbar.Location = New Point(47, ScreenHeight - 148)
        tbMediaTrackbar.Size = New Size(ScreenWidth - 386, 25)
        txtCurrent.Location = New Point(11, ScreenHeight - 146)
        txtTotal.Location = New Point(ScreenWidth - 331, ScreenHeight - 146)
        GetMediaFiles()
        tbVolumebar.Focus()
        VLCv2.Refresh()
    End Sub
    Public Sub GetMediaFiles()
        Dim fileNames = My.Computer.FileSystem.GetFiles("C:\Users\" + User + "\Music\Terrathede Games Music", FileIO.SearchOption.SearchAllSubDirectories)
        lstSongsDGV.Rows.Clear()
        frmMainMediaPlayer.MaxCounter = fileNames.Count
        For x = 0 To frmMainMediaPlayer.MaxCounter - 1
            frmMainMediaPlayer.Files(x) = fileNames(x)
            frmMainMediaPlayer.Files(x) = frmMainMediaPlayer.Files(x).Substring(frmMainMediaPlayer.Files(x).LastIndexOf("\") + 1)
            frmMainMediaPlayer.Songs(x) = fileNames(x)
        Next
        For i = 0 To frmMainMediaPlayer.MaxCounter - 1
            lstSongsDGV.Rows.Add(frmMainMediaPlayer.Files(i))
        Next
    End Sub
    Public WithEvents player As New System.Media.SoundPlayer

    Private Sub frmMoveTool_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmMoveTool.DoubleClick
        btnMaximize_MouseUp(sender, e)
    End Sub

    Private Sub frmTitle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmTitle.DoubleClick
        btnMaximize_MouseUp(sender, e)
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
    Private Sub VLCTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles VLCTimer.Tick
        Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
        Dim FullMediaDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\"
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
                frmFullScreen.frmTitle.Text = "VLC Media Player - " & title
                frmTitle.Text = "VLC Media Player - " & title
                frmMainMediaPlayer.Text = "VLC Media Player - " & title
                frmFullScreen.Text = "VLC Media Player - " & title
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

    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 32 Then
            If VLCv2.playlist.isPlaying Then
                btnPlayPause.BackgroundImage = My.Resources.Play_Button
            Else
                btnPlayPause.BackgroundImage = My.Resources.Pause_Button
            End If
            btnPlayPause_MouseUp(Nothing, Nothing)
        End If
        If Asc(e.KeyChar) = 33 Then
            frmMainMediaPlayer.player.Stream = My.Resources._exit
            frmMainMediaPlayer.player.Play()
            VLCv2.playlist.stop()
            frmMainMediaPlayer.VLCv2.playlist.play()
            VLCTimer.Stop()
            frmMainMediaPlayer.VLCTimer.Start()
            frmMainMediaPlayer.VLCv2.input.Time = tbMediaTrackbar.Value + 100
            Me.Hide()
            frmMainMediaPlayer.Show()
        End If
    End Sub
    Private Sub msImportSongs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msImportSongs.Click
        Dim Open_File As New OpenFileDialog
        With Open_File
            .Filter = "Media Files (*.wmv;*.m4a;*.mp3;)|*.wmv;*.m4a;*.mp3;)"
            .FileName = ""
            .Multiselect = True
        End With
        Dim CurrentSong As String
        If Open_File.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnPlayPause.BackgroundImage = My.Resources.Play_Button
            TogglePlayPause = False
            Dim destination As String
            Dim path As String
            path = Open_File.FileName
            Dim FullDirectory As String = "C:\Users\" + User + "\Music\Terrathede Games Music\" & Open_File.SafeFileName
            pbImport.Value = 0
            pbImport.Maximum = Open_File.FileNames.Count
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
                        CurrentPlaylist = "file:///" & Open_File.FileName
                        frmMainMediaPlayer.VLCv2.playlist.add(CurrentPlaylist)
                        VLCv2.playlist.stop()
                        VLCv2.playlist.items.clear()
                        VLCv2.playlist.add("File:///" & Open_File.FileName)
                        VLCv2.playlist.play()
                        VLCTimer.Start()
                        lstSongsDGV.Rows.Add(SongTitle)
                        lstSongsDGV.Refresh()
                    End If
                    pbImport.Visible = False
                    Exit Sub
                End If
            End If
            If Open_File.FileNames.Count = 1 Then
                For i = 0 To lstSongsDGV.Rows.Count - 1
                    If Open_File.SafeFileNames(0) = lstSongsDGV.Item(0, i).Value Then
                        lstSongsDGV.Refresh()
                        lstSongsDGV.CurrentCell = lstSongsDGV.Rows(i).Cells(0)
                        lstSongsDGV.Rows(i).Selected = True
                        CurrentSong = Open_File.FileNames(0)
                        frmMainMediaPlayer.CurrentPlaylist = "file:///" & CurrentSong
                        VLCv2.playlist.add(frmMainMediaPlayer.CurrentPlaylist)
                        VLCv2.playlist.play()
                        frmMainMediaPlayer.GetMediaFiles()
                        pbImport.Visible = False
                        Me.Enabled = True
                        Exit Sub
                    End If
                Next
            End If
            pbImport.Visible = True
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
                frmMainMediaPlayer.CurrentPlaylist = "file:///" & Open_File.FileName
                frmMainMediaPlayer.VLCv2.playlist.add(frmMainMediaPlayer.CurrentPlaylist)
                VLCv2.playlist.stop()
                VLCv2.playlist.items.clear()
                VLCv2.playlist.add("File:///" & Open_File.FileName)
                VLCv2.playlist.play()
                VLCTimer.Start()
                lstSongsDGV.Rows.Add(SongTitle)
                lstSongsDGV.Refresh()
            Else
            End If
            pbImport.Visible = False
            frmMainMediaPlayer.GetMediaFiles()
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
        btnPlayPause.BackgroundImage = My.Resources.Pause_Button
        TogglePlayPause = True
        frmMainMediaPlayer.SongIndex = lstSongsDGV.CurrentRow.Index
        If lstSongsDGV.CurrentRow.Index = lstSongsDGV.Rows.Count - 1 Then
            frmMainMediaPlayer.SongIndex = 0
            lstSongsDGV.ClearSelection()
            lstSongsDGV.CurrentCell = lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
            lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
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
            Exit Sub
        Else
            frmMainMediaPlayer.SongIndex = frmMainMediaPlayer.SongIndex + 1
            lstSongsDGV.ClearSelection()
            lstSongsDGV.CurrentCell = lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Cells(0)
            lstSongsDGV.Rows(frmMainMediaPlayer.SongIndex).Selected = True
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
        End If
        CurrentPlaylist = "file:///" & FullDirectory & lstSongsDGV.Item(0, lstSongsDGV.CurrentRow.Index).Value
    End Sub
    Dim VolumeBarCountdown As Integer = ScreenWidth - 330
    Dim VolumeBarCounter As Integer = 0
    Dim Taskbar As Integer = My.Computer.Screen.Bounds.Height - My.Computer.Screen.WorkingArea.Height
    Private Sub VolumeBarCountDownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeBarCountDownTimer.Tick
        VolumeBarCounter = VolumeBarCounter + 1
    End Sub

    Private Sub tbVolumebar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVolumebar.Scroll
        VLCv2.Volume = tbVolumebar.Value
        lblVolume.Text = tbVolumebar.Value & "%"
        tbVolumebar.Location = New Point(ScreenWidth - 330, ScreenHeight / 8 + Taskbar)
        lblVolume.Location = New Point(ScreenWidth - 330, ScreenHeight / 8 + Taskbar - 15)
        VolumeBarCountdown = ScreenWidth - 330
        VolumeBarCounter = 0
        VolumeBarCountDownTimer.Start()
    End Sub

    Private Sub MouseMoveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseMoveTimer.Tick
        If VolumeBarCounter > 10 Then
            VolumeBarCountdown = VolumeBarCountdown + 1
            tbVolumebar.Location = New Point(VolumeBarCountdown, ScreenHeight / 8 + Taskbar)
            lblVolume.Location = New Point(VolumeBarCountdown, ScreenHeight / 8 + Taskbar - 15)
            If VolumeBarCountdown > ScreenWidth + 1 Then
                VolumeBarCountdown = ScreenWidth - 330
                VolumeBarCounter = 0
                VolumeBarCountDownTimer.Stop()
            End If
        End If
    End Sub

    Private Sub lstSongsDGV_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSongsDGV.MouseLeave
        tbVolumebar.Focus()
    End Sub
    Private Sub frmMaximized_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            btnNext_MouseUp(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Left Then
            btnPrevious_MouseUp(Nothing, Nothing)
        End If
    End Sub
    Private Sub lstSongsDGV_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSongsDGV.MouseEnter
        lstSongsDGV.Focus()
    End Sub

    Private Sub tbVolumebar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbVolumebar.KeyDown
        If e.KeyCode = Keys.Right Then
            e.Handled = True
        End If
        If e.KeyCode = Keys.Left Then
            e.Handled = True
        End If
    End Sub
End Class
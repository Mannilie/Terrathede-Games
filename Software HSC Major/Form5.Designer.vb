<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.FileTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblFile = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DefaultFormTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MusicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RepeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picLoadingGif = New System.Windows.Forms.PictureBox()
        CType(Me.picLoadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileTimer
        '
        Me.FileTimer.Interval = 20
        '
        'lblFile
        '
        Me.lblFile.AutoEllipsis = True
        Me.lblFile.BackColor = System.Drawing.Color.Transparent
        Me.lblFile.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblFile.ForeColor = System.Drawing.Color.Black
        Me.lblFile.Location = New System.Drawing.Point(449, 278)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(112, 26)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "\debug"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(365, 278)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loading..."
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 296)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Copyright© 2013 Terrathede Games™ Emmanuel Vaccaro"
        '
        'picLoadingGif
        '
        Me.picLoadingGif.BackColor = System.Drawing.Color.White
        Me.picLoadingGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLoadingGif.Location = New System.Drawing.Point(369, 299)
        Me.picLoadingGif.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picLoadingGif.Name = "picLoadingGif"
        Me.picLoadingGif.Size = New System.Drawing.Size(192, 12)
        Me.picLoadingGif.TabIndex = 3
        Me.picLoadingGif.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TerrathedeGames.My.Resources.Resources.SplashScreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(565, 318)
        Me.Controls.Add(Me.picLoadingGif)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSplashScreen"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terrathede Games"
        CType(Me.picLoadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileTimer As System.Windows.Forms.Timer
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefaultFormTimer As System.Windows.Forms.Timer
    Friend WithEvents MusicTimer As System.Windows.Forms.Timer
    Friend WithEvents RepeatTimer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picLoadingGif As System.Windows.Forms.PictureBox
End Class

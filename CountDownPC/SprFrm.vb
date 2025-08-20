Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Runtime.InteropServices


Public Class SprFrm


    Private Sub SprFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeUp()
        TimerCountdown()
    End Sub

    Sub TimerCountdown()
        FrmLb01.Text = "0"
        FrmTmr01.Start()
        AddHandler FrmTmr01.Tick, AddressOf CheckIdleTime

    End Sub
    Sub LoadMeUp()
        Me.WindowState = FormWindowState.Minimized
        Me.NI01.Text = "Bemz Style"
        Me.NI01.Icon = SystemIcons.Information
        Me.NI01.Visible = True
        Me.NI01.ContextMenuStrip = CMS01
    End Sub

    Private Sub SprFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            Me.NI01.Visible = True
            Me.Hide()
            '  Me.NI01.ShowBalloonTip(1000, "App Minimized", "The app is now running in the background.", ToolTipIcon.Info)
        End If
    End Sub

    Sub RestoreForm()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NI01.Visible = False
    End Sub

    Sub ExitForm()
        NI01.Visible = False
        Application.Exit()
    End Sub

    Private Sub SprFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.NI01.Visible = False
        Me.NI01.Dispose()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitForm()
    End Sub

    Private Sub NI01_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NI01.MouseDoubleClick
        RestoreForm()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        RestoreForm()
    End Sub

    Private Sub FrmTmr01_Tick(sender As Object, e As EventArgs) Handles FrmTmr01.Tick
        FrmLb01.Text = CInt(GetIdleTime())

    End Sub

    Private Sub CheckIdleTime(sender As Object, e As EventArgs)
        Dim idleTime As UInteger = GetIdleTime()
        Dim idleSeconds As Integer = CInt(idleTime / 1000)


        If idleSeconds > 9 Then
            RestoreForm()
            If idleSeconds > 10 Then
                MainFrm.Show()
            End If

        End If
    End Sub


    Private Function GetIdleTime() As UInteger
        Dim lastInput As New LASTINPUTINFO()
        lastInput.cbSize = CUInt(Marshal.SizeOf(lastInput))

        If GetLastInputInfo(lastInput) Then
            Dim tickCount As UInteger = GetTickCount()
            Return tickCount - lastInput.dwTime
        Else
            Return 0
        End If
    End Function

End Class
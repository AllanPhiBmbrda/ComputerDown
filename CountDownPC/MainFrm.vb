Imports System.ComponentModel

Public Class MainFrm

    Sub LabelMe()
        Lbl01.Text = "Ang Computer ba ito mamatay sa loob ng "
        Lbl02.Text = "60"
        Tmr01.Enabled = True
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMe()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Tmr01_Tick(sender As Object, e As EventArgs) Handles Tmr01.Tick
        Lbl02.Text = Val(Lbl02.Text) - 1

        If Lbl02.Text = -5 Then
            Tmr01.Enabled = False
            Me.Close()
        ElseIf Lbl02.Text = -1 Then
            ' Shutdown the computer in 0 seconds
            Process.Start("shutdown", "/s /t 0")
        Else
        End If
    End Sub

    Private Sub MainFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Tmr01.Enabled = False
        SprFrm.WindowState = FormWindowState.Minimized
    End Sub
End Class

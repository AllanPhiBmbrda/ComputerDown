<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SprFrm
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
        components = New ComponentModel.Container()
        NI01 = New NotifyIcon(components)
        CMS01 = New ContextMenuStrip(components)
        RestoreToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        Lbl02 = New Label()
        FrmTmr01 = New Timer(components)
        FrmLb01 = New Label()
        CMS01.SuspendLayout()
        SuspendLayout()
        ' 
        ' NI01
        ' 
        NI01.Text = "NotifyIcon1"
        NI01.Visible = True
        ' 
        ' CMS01
        ' 
        CMS01.Items.AddRange(New ToolStripItem() {RestoreToolStripMenuItem, ExitToolStripMenuItem})
        CMS01.Name = "CMS01"
        CMS01.Size = New Size(114, 48)
        ' 
        ' RestoreToolStripMenuItem
        ' 
        RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        RestoreToolStripMenuItem.Size = New Size(113, 22)
        RestoreToolStripMenuItem.Text = "Restore"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(113, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Lbl02
        ' 
        Lbl02.AutoSize = True
        Lbl02.Font = New Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl02.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Lbl02.Location = New Point(109, 51)
        Lbl02.Name = "Lbl02"
        Lbl02.Size = New Size(395, 234)
        Lbl02.TabIndex = 4
        Lbl02.Text = "Welcome" & vbCrLf & "to" & vbCrLf & "BemzConnect"
        ' 
        ' FrmTmr01
        ' 
        FrmTmr01.Interval = 1000
        ' 
        ' FrmLb01
        ' 
        FrmLb01.AutoSize = True
        FrmLb01.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        FrmLb01.ForeColor = Color.Gray
        FrmLb01.Location = New Point(273, 315)
        FrmLb01.Name = "FrmLb01"
        FrmLb01.Size = New Size(59, 21)
        FrmLb01.TabIndex = 5
        FrmLb01.Text = "#Bemz"
        ' 
        ' SprFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 345)
        Controls.Add(FrmLb01)
        Controls.Add(Lbl02)
        MaximizeBox = False
        Name = "SprFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BemZ Connect"
        CMS01.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NI01 As NotifyIcon
    Friend WithEvents CMS01 As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl02 As Label
    Friend WithEvents FrmTmr01 As Timer
    Friend WithEvents FrmLb01 As Label
End Class

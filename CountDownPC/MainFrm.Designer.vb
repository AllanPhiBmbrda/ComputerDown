<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Lbl01 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        Lbl02 = New Label()
        Label2 = New Label()
        Tmr01 = New Timer(components)
        SuspendLayout()
        ' 
        ' Lbl01
        ' 
        Lbl01.AutoSize = True
        Lbl01.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl01.ForeColor = Color.Red
        Lbl01.Location = New Point(12, 27)
        Lbl01.Name = "Lbl01"
        Lbl01.Size = New Size(134, 39)
        Lbl01.TabIndex = 0
        Lbl01.Text = "BIG TEST"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.Location = New Point(201, 260)
        Button1.Name = "Button1"
        Button1.Size = New Size(222, 46)
        Button1.TabIndex = 1
        Button1.Text = "ITIGIL (STOP)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Candara", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(509, 327)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 14)
        Label1.TabIndex = 2
        Label1.Text = "By Bemz Computer"
        ' 
        ' Lbl02
        ' 
        Lbl02.AutoSize = True
        Lbl02.Font = New Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl02.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Lbl02.Location = New Point(233, 91)
        Lbl02.Name = "Lbl02"
        Lbl02.Size = New Size(148, 117)
        Lbl02.TabIndex = 3
        Lbl02.Text = "60"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(398, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 26)
        Label2.TabIndex = 4
        Label2.Text = "Segundo"
        ' 
        ' Tmr01
        ' 
        Tmr01.Interval = 1000
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 345)
        Controls.Add(Label2)
        Controls.Add(Lbl02)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Lbl01)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl01 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl02 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tmr01 As Timer

End Class

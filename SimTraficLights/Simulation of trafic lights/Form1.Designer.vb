<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.lblRed = New System.Windows.Forms.Label
        Me.lblOrange = New System.Windows.Forms.Label
        Me.lblGreen = New System.Windows.Forms.Label
        Me.Click = New System.Windows.Forms.Button
        Me.lblRed1 = New System.Windows.Forms.Label
        Me.lblOrange1 = New System.Windows.Forms.Label
        Me.lblGreen1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(24, 21)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(51, 41)
        Me.lblRed.TabIndex = 0
        Me.lblRed.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'lblOrange
        '
        Me.lblOrange.AutoSize = True
        Me.lblOrange.BackColor = System.Drawing.Color.White
        Me.lblOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrange.ForeColor = System.Drawing.Color.Red
        Me.lblOrange.Location = New System.Drawing.Point(24, 85)
        Me.lblOrange.Name = "lblOrange"
        Me.lblOrange.Size = New System.Drawing.Size(51, 41)
        Me.lblOrange.TabIndex = 1
        Me.lblOrange.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.BackColor = System.Drawing.Color.White
        Me.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreen.ForeColor = System.Drawing.Color.Red
        Me.lblGreen.Location = New System.Drawing.Point(24, 146)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(51, 41)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'Click
        '
        Me.Click.Location = New System.Drawing.Point(85, 202)
        Me.Click.Name = "Click"
        Me.Click.Size = New System.Drawing.Size(53, 28)
        Me.Click.TabIndex = 3
        Me.Click.Text = "Click"
        Me.Click.UseVisualStyleBackColor = True
        '
        'lblRed1
        '
        Me.lblRed1.AutoSize = True
        Me.lblRed1.BackColor = System.Drawing.Color.Red
        Me.lblRed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRed1.ForeColor = System.Drawing.Color.Red
        Me.lblRed1.Location = New System.Drawing.Point(282, 30)
        Me.lblRed1.Name = "lblRed1"
        Me.lblRed1.Size = New System.Drawing.Size(51, 41)
        Me.lblRed1.TabIndex = 5
        Me.lblRed1.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'lblOrange1
        '
        Me.lblOrange1.AutoSize = True
        Me.lblOrange1.BackColor = System.Drawing.Color.White
        Me.lblOrange1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrange1.ForeColor = System.Drawing.Color.Red
        Me.lblOrange1.Location = New System.Drawing.Point(282, 85)
        Me.lblOrange1.Name = "lblOrange1"
        Me.lblOrange1.Size = New System.Drawing.Size(51, 41)
        Me.lblOrange1.TabIndex = 6
        Me.lblOrange1.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'lblGreen1
        '
        Me.lblGreen1.AutoSize = True
        Me.lblGreen1.BackColor = System.Drawing.Color.White
        Me.lblGreen1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreen1.ForeColor = System.Drawing.Color.Red
        Me.lblGreen1.Location = New System.Drawing.Point(282, 146)
        Me.lblGreen1.Name = "lblGreen1"
        Me.lblGreen1.Size = New System.Drawing.Size(51, 41)
        Me.lblGreen1.TabIndex = 7
        Me.lblGreen1.Text = "            " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'Timer1
        '
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(282, 209)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(49, 21)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(282, 236)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(49, 21)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 262)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblGreen1)
        Me.Controls.Add(Me.lblOrange1)
        Me.Controls.Add(Me.lblRed1)
        Me.Controls.Add(Me.Click)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblOrange)
        Me.Controls.Add(Me.lblRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblOrange As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents Click As System.Windows.Forms.Button
    Friend WithEvents lblRed1 As System.Windows.Forms.Label
    Friend WithEvents lblOrange1 As System.Windows.Forms.Label
    Friend WithEvents lblGreen1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button

End Class

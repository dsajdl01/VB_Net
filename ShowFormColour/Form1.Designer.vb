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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.hsbRed = New System.Windows.Forms.HScrollBar
        Me.hsbGreen = New System.Windows.Forms.HScrollBar
        Me.hsbBlue = New System.Windows.Forms.HScrollBar
        Me.txtRed = New System.Windows.Forms.TextBox
        Me.txtGreen = New System.Windows.Forms.TextBox
        Me.txtBlue = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(2, 2, 20, 2)
        Me.Label1.Size = New System.Drawing.Size(72, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2)
        Me.Label2.Size = New System.Drawing.Size(74, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2, 2, 16, 2)
        Me.Label3.Size = New System.Drawing.Size(72, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        '
        'hsbRed
        '
        Me.hsbRed.Location = New System.Drawing.Point(124, 66)
        Me.hsbRed.Maximum = 259
        Me.hsbRed.Name = "hsbRed"
        Me.hsbRed.Size = New System.Drawing.Size(299, 30)
        Me.hsbRed.TabIndex = 3
        '
        'hsbGreen
        '
        Me.hsbGreen.Location = New System.Drawing.Point(122, 134)
        Me.hsbGreen.Maximum = 259
        Me.hsbGreen.Name = "hsbGreen"
        Me.hsbGreen.Size = New System.Drawing.Size(299, 30)
        Me.hsbGreen.TabIndex = 4
        '
        'hsbBlue
        '
        Me.hsbBlue.Location = New System.Drawing.Point(122, 208)
        Me.hsbBlue.Maximum = 259
        Me.hsbBlue.Name = "hsbBlue"
        Me.hsbBlue.Size = New System.Drawing.Size(299, 30)
        Me.hsbBlue.TabIndex = 5
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(450, 64)
        Me.txtRed.Multiline = True
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(35, 32)
        Me.txtRed.TabIndex = 6
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(450, 134)
        Me.txtGreen.Multiline = True
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(35, 30)
        Me.txtGreen.TabIndex = 7
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(450, 208)
        Me.txtBlue.Multiline = True
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(35, 30)
        Me.txtBlue.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 279)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.hsbBlue)
        Me.Controls.Add(Me.hsbGreen)
        Me.Controls.Add(Me.hsbRed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change the form's colour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hsbRed As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbGreen As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbBlue As System.Windows.Forms.HScrollBar
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox

End Class

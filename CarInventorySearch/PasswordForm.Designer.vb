<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.txtSecond = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblRegNumber = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(181, 27)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(136, 20)
        Me.txtFirst.TabIndex = 0
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(181, 67)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(136, 20)
        Me.txtSecond.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add new password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Confirm our new password:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(230, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 59)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRegNumber
        '
        Me.lblRegNumber.AutoSize = True
        Me.lblRegNumber.Location = New System.Drawing.Point(39, 148)
        Me.lblRegNumber.Name = "lblRegNumber"
        Me.lblRegNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblRegNumber.TabIndex = 5
        Me.lblRegNumber.Text = "Label3"
        Me.lblRegNumber.Visible = False
        '
        'PasswordForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 195)
        Me.Controls.Add(Me.lblRegNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "PasswordForm"
        Me.Text = "PasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblRegNumber As System.Windows.Forms.Label
End Class

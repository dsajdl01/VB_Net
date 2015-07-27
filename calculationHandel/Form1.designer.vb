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
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.txtFirstNo = New System.Windows.Forms.TextBox
        Me.txtSecondNo = New System.Windows.Forms.TextBox
        Me.lblResult = New System.Windows.Forms.Label
        Me.btnClearNo = New System.Windows.Forms.Button
        Me.ckbPlus = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckbDiv = New System.Windows.Forms.CheckBox
        Me.ckbMinus = New System.Windows.Forms.CheckBox
        Me.ckbMult = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(301, 179)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 46)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear List Box"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(311, 245)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(62, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(15, 137)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(262, 121)
        Me.lstOutput.TabIndex = 9
        '
        'txtFirstNo
        '
        Me.txtFirstNo.Location = New System.Drawing.Point(12, 63)
        Me.txtFirstNo.Name = "txtFirstNo"
        Me.txtFirstNo.Size = New System.Drawing.Size(72, 20)
        Me.txtFirstNo.TabIndex = 10
        '
        'txtSecondNo
        '
        Me.txtSecondNo.Location = New System.Drawing.Point(195, 63)
        Me.txtSecondNo.Name = "txtSecondNo"
        Me.txtSecondNo.Size = New System.Drawing.Size(63, 20)
        Me.txtSecondNo.TabIndex = 11
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(261, 95)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Padding = New System.Windows.Forms.Padding(1, 1, 15, 5)
        Me.lblResult.Size = New System.Drawing.Size(57, 28)
        Me.lblResult.TabIndex = 12
        Me.lblResult.Text = "1    "
        Me.lblResult.Visible = False
        '
        'btnClearNo
        '
        Me.btnClearNo.Location = New System.Drawing.Point(61, 103)
        Me.btnClearNo.Name = "btnClearNo"
        Me.btnClearNo.Size = New System.Drawing.Size(160, 23)
        Me.btnClearNo.TabIndex = 13
        Me.btnClearNo.Text = "Clear No. in tex box"
        Me.btnClearNo.UseVisualStyleBackColor = True
        Me.btnClearNo.Visible = False
        '
        'ckbPlus
        '
        Me.ckbPlus.AutoSize = True
        Me.ckbPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPlus.Location = New System.Drawing.Point(6, 32)
        Me.ckbPlus.Name = "ckbPlus"
        Me.ckbPlus.Size = New System.Drawing.Size(38, 24)
        Me.ckbPlus.TabIndex = 14
        Me.ckbPlus.Text = "+"
        Me.ckbPlus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbDiv)
        Me.GroupBox1.Controls.Add(Me.ckbMinus)
        Me.GroupBox1.Controls.Add(Me.ckbMult)
        Me.GroupBox1.Controls.Add(Me.ckbPlus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(90, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 90)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ariththmetic Operations"
        '
        'ckbDiv
        '
        Me.ckbDiv.AutoSize = True
        Me.ckbDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbDiv.Location = New System.Drawing.Point(52, 57)
        Me.ckbDiv.Name = "ckbDiv"
        Me.ckbDiv.Size = New System.Drawing.Size(33, 24)
        Me.ckbDiv.TabIndex = 16
        Me.ckbDiv.Text = "/"
        Me.ckbDiv.UseVisualStyleBackColor = True
        '
        'ckbMinus
        '
        Me.ckbMinus.AutoSize = True
        Me.ckbMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbMinus.Location = New System.Drawing.Point(51, 32)
        Me.ckbMinus.Name = "ckbMinus"
        Me.ckbMinus.Size = New System.Drawing.Size(34, 24)
        Me.ckbMinus.TabIndex = 16
        Me.ckbMinus.Text = "-"
        Me.ckbMinus.UseVisualStyleBackColor = True
        '
        'ckbMult
        '
        Me.ckbMult.AutoSize = True
        Me.ckbMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbMult.Location = New System.Drawing.Point(6, 59)
        Me.ckbMult.Name = "ckbMult"
        Me.ckbMult.Size = New System.Drawing.Size(35, 24)
        Me.ckbMult.TabIndex = 16
        Me.ckbMult.Text = "*"
        Me.ckbMult.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 269)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClearNo)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtSecondNo)
        Me.Controls.Add(Me.txtFirstNo)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "Chap.4 Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents txtFirstNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNo As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnClearNo As System.Windows.Forms.Button
    Friend WithEvents ckbPlus As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbDiv As System.Windows.Forms.CheckBox
    Friend WithEvents ckbMinus As System.Windows.Forms.CheckBox
    Friend WithEvents ckbMult As System.Windows.Forms.CheckBox

End Class

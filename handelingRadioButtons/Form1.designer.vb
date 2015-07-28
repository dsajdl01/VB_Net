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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdb3 = New System.Windows.Forms.RadioButton
        Me.rdb2 = New System.Windows.Forms.RadioButton
        Me.rdb1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.txtA = New System.Windows.Forms.TextBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.txtC = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb3)
        Me.GroupBox1.Controls.Add(Me.rdb2)
        Me.GroupBox1.Controls.Add(Me.rdb1)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expression"
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Location = New System.Drawing.Point(16, 113)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(66, 17)
        Me.rdb3.TabIndex = 2
        Me.rdb3.TabStop = True
        Me.rdb3.Text = "B Mod C"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Location = New System.Drawing.Point(15, 72)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(66, 17)
        Me.rdb2.TabIndex = 1
        Me.rdb2.TabStop = True
        Me.rdb2.Text = "A - C / B"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Location = New System.Drawing.Point(15, 32)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(67, 17)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "A + B - C"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Result"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(171, 211)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(36, 15)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "         "
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(39, 57)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 6
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(39, 97)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 7
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(39, 139)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 262)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox

End Class

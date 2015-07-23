<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeChanges
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
        Me.btnAddChanges = New System.Windows.Forms.Button
        Me.txtAddPrice = New System.Windows.Forms.TextBox
        Me.txtAddMade = New System.Windows.Forms.TextBox
        Me.txtAddYear = New System.Windows.Forms.TextBox
        Me.lblAddRegNum = New System.Windows.Forms.Label
        Me.txtAddModel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRecord = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRecord)
        Me.GroupBox1.Controls.Add(Me.btnAddChanges)
        Me.GroupBox1.Controls.Add(Me.txtAddPrice)
        Me.GroupBox1.Controls.Add(Me.txtAddMade)
        Me.GroupBox1.Controls.Add(Me.txtAddYear)
        Me.GroupBox1.Controls.Add(Me.lblAddRegNum)
        Me.GroupBox1.Controls.Add(Me.txtAddModel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Changes"
        '
        'btnAddChanges
        '
        Me.btnAddChanges.Location = New System.Drawing.Point(613, 48)
        Me.btnAddChanges.Name = "btnAddChanges"
        Me.btnAddChanges.Size = New System.Drawing.Size(75, 58)
        Me.btnAddChanges.TabIndex = 10
        Me.btnAddChanges.Text = "Made Changes"
        Me.btnAddChanges.UseVisualStyleBackColor = True
        '
        'txtAddPrice
        '
        Me.txtAddPrice.Location = New System.Drawing.Point(460, 106)
        Me.txtAddPrice.Name = "txtAddPrice"
        Me.txtAddPrice.Size = New System.Drawing.Size(115, 21)
        Me.txtAddPrice.TabIndex = 9
        '
        'txtAddMade
        '
        Me.txtAddMade.Location = New System.Drawing.Point(460, 48)
        Me.txtAddMade.Name = "txtAddMade"
        Me.txtAddMade.Size = New System.Drawing.Size(100, 21)
        Me.txtAddMade.TabIndex = 8
        '
        'txtAddYear
        '
        Me.txtAddYear.Location = New System.Drawing.Point(325, 105)
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(78, 21)
        Me.txtAddYear.TabIndex = 7
        '
        'lblAddRegNum
        '
        Me.lblAddRegNum.AutoSize = True
        Me.lblAddRegNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddRegNum.Enabled = False
        Me.lblAddRegNum.Location = New System.Drawing.Point(182, 48)
        Me.lblAddRegNum.Name = "lblAddRegNum"
        Me.lblAddRegNum.Padding = New System.Windows.Forms.Padding(0, 0, 35, 5)
        Me.lblAddRegNum.Size = New System.Drawing.Size(37, 22)
        Me.lblAddRegNum.TabIndex = 6
        '
        'txtAddModel
        '
        Me.txtAddModel.Location = New System.Drawing.Point(76, 105)
        Me.txtAddModel.Name = "txtAddModel"
        Me.txtAddModel.Size = New System.Drawing.Size(117, 21)
        Me.txtAddModel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "manufacture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register Number"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(6, 150)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(0, 15)
        Me.lblRecord.TabIndex = 11
        Me.lblRecord.Visible = False
        '
        'MakeChanges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 192)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MakeChanges"
        Me.Text = "MakeChanges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddChanges As System.Windows.Forms.Button
    Friend WithEvents txtAddPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAddMade As System.Windows.Forms.TextBox
    Friend WithEvents txtAddYear As System.Windows.Forms.TextBox
    Friend WithEvents lblAddRegNum As System.Windows.Forms.Label
    Friend WithEvents txtAddModel As System.Windows.Forms.TextBox
    Friend WithEvents lblRecord As System.Windows.Forms.Label
End Class

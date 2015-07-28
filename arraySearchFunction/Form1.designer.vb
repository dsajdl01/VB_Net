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
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.lstNumber = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblDisplaySearch = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblHightest = New System.Windows.Forms.Label
        Me.lblSmallest = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblMean = New System.Windows.Forms.Label
        Me.lblMult = New System.Windows.Forms.Label
        Me.lblSum = New System.Windows.Forms.Label
        Me.btlShow = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(64, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 47)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to array"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(105, 51)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(51, 22)
        Me.txtNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDisplay)
        Me.GroupBox2.Controls.Add(Me.lstNumber)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(312, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 198)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(22, 120)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 47)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Array"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.ItemHeight = 16
        Me.lstNumber.Location = New System.Drawing.Point(149, 21)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(108, 164)
        Me.lstNumber.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnFind)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.lblDisplaySearch)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(30, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(202, 31)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(92, 47)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find number"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(100, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(51, 22)
        Me.txtSearch.TabIndex = 2
        '
        'lblDisplaySearch
        '
        Me.lblDisplaySearch.AutoSize = True
        Me.lblDisplaySearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySearch.Location = New System.Drawing.Point(342, 31)
        Me.lblDisplaySearch.Name = "lblDisplaySearch"
        Me.lblDisplaySearch.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblDisplaySearch.Size = New System.Drawing.Size(78, 18)
        Me.lblDisplaySearch.TabIndex = 1
        Me.lblDisplaySearch.Text = "            "
        Me.lblDisplaySearch.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 48)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Find"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(715, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(790, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Quit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.lblHightest)
        Me.GroupBox4.Controls.Add(Me.lblSmallest)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(30, 358)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(554, 118)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hightest and Smallest Number in arrey"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(387, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 49)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblHightest
        '
        Me.lblHightest.AutoSize = True
        Me.lblHightest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHightest.Location = New System.Drawing.Point(229, 70)
        Me.lblHightest.Name = "lblHightest"
        Me.lblHightest.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblHightest.Size = New System.Drawing.Size(34, 18)
        Me.lblHightest.TabIndex = 3
        Me.lblHightest.Text = " "
        Me.lblHightest.Visible = False
        '
        'lblSmallest
        '
        Me.lblSmallest.AutoSize = True
        Me.lblSmallest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSmallest.Location = New System.Drawing.Point(229, 40)
        Me.lblSmallest.Name = "lblSmallest"
        Me.lblSmallest.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblSmallest.Size = New System.Drawing.Size(34, 18)
        Me.lblSmallest.TabIndex = 2
        Me.lblSmallest.Text = " "
        Me.lblSmallest.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "The hightest number is"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Smallest number is"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btlShow)
        Me.GroupBox5.Controls.Add(Me.lblSum)
        Me.GroupBox5.Controls.Add(Me.lblMult)
        Me.GroupBox5.Controls.Add(Me.lblMean)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(636, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(213, 408)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Colculation Array"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 32)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "The Multiplacion of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the arrey is"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 32)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "The Mean of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the Array is"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "The Sum of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the Arrey is"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMean.Location = New System.Drawing.Point(51, 195)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblMean.Size = New System.Drawing.Size(34, 18)
        Me.lblMean.TabIndex = 3
        Me.lblMean.Text = " "
        Me.lblMean.Visible = False
        '
        'lblMult
        '
        Me.lblMult.AutoSize = True
        Me.lblMult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMult.Location = New System.Drawing.Point(51, 288)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblMult.Size = New System.Drawing.Size(34, 18)
        Me.lblMult.TabIndex = 4
        Me.lblMult.Text = " "
        Me.lblMult.Visible = False
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Location = New System.Drawing.Point(51, 89)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lblSum.Size = New System.Drawing.Size(34, 18)
        Me.lblSum.TabIndex = 5
        Me.lblSum.Text = " "
        Me.lblSum.Visible = False
        '
        'btlShow
        '
        Me.btlShow.Location = New System.Drawing.Point(84, 323)
        Me.btlShow.Name = "btlShow"
        Me.btlShow.Size = New System.Drawing.Size(75, 59)
        Me.btlShow.TabIndex = 6
        Me.btlShow.Text = "Show"
        Me.btlShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 488)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDisplaySearch As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lstNumber As System.Windows.Forms.ListBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHightest As System.Windows.Forms.Label
    Friend WithEvents lblSmallest As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btlShow As System.Windows.Forms.Button
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblMult As System.Windows.Forms.Label
    Friend WithEvents lblMean As System.Windows.Forms.Label

End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbMake = New System.Windows.Forms.ComboBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtRegNumber = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblNumber = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstHead = New System.Windows.Forms.ListBox
        Me.lstListCar = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnDisplayYear = New System.Windows.Forms.Button
        Me.CmbSearchModel = New System.Windows.Forms.ComboBox
        Me.txtMaxValue = New System.Windows.Forms.TextBox
        Me.txtMinValue = New System.Windows.Forms.TextBox
        Me.txtSearchYear = New System.Windows.Forms.TextBox
        Me.btnDisplayModel = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnDisplayRegNumber = New System.Windows.Forms.Button
        Me.comSearchRegNum = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnChanges = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnPrints = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMake)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.txtRegNumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Car Model"
        '
        'cmbMake
        '
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"BMW", "Bugatti", "Cadillac", "Citroen", "Fiat", "Ferrari", "Ford", "Honda ", "Hyundai", "Kia", "Mazda", "Mini ", "Mitsubishi", "Morgan", "Nissan", "Opel", "Peugeot", "Porsche", "Renault", "Skoda", "Suzuki", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMake.Location = New System.Drawing.Point(475, 28)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 23)
        Me.cmbMake.TabIndex = 11
        Me.cmbMake.Text = "Audi"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(641, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 51)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(496, 61)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 21)
        Me.txtPrice.TabIndex = 9
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012"})
        Me.cmbYear.Location = New System.Drawing.Point(353, 63)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(63, 23)
        Me.cmbYear.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(82, 67)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(153, 21)
        Me.txtModel.TabIndex = 7
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Location = New System.Drawing.Point(146, 28)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(117, 21)
        Me.txtRegNumber.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "manufacture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Make"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reg. Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Number of cars in the fiel"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(256, 135)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Padding = New System.Windows.Forms.Padding(0, 0, 10, 4)
        Me.lblNumber.Size = New System.Drawing.Size(28, 22)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstHead)
        Me.GroupBox2.Controls.Add(Me.lstListCar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 270)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display file of cars"
        '
        'lstHead
        '
        Me.lstHead.FormattingEnabled = True
        Me.lstHead.ItemHeight = 15
        Me.lstHead.Location = New System.Drawing.Point(6, 21)
        Me.lstHead.Name = "lstHead"
        Me.lstHead.Size = New System.Drawing.Size(735, 19)
        Me.lstHead.TabIndex = 1
        '
        'lstListCar
        '
        Me.lstListCar.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListCar.FormattingEnabled = True
        Me.lstListCar.ItemHeight = 17
        Me.lstListCar.Location = New System.Drawing.Point(6, 39)
        Me.lstListCar.Name = "lstListCar"
        Me.lstListCar.Size = New System.Drawing.Size(735, 225)
        Me.lstListCar.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.btnDisplayYear)
        Me.GroupBox3.Controls.Add(Me.CmbSearchModel)
        Me.GroupBox3.Controls.Add(Me.txtMaxValue)
        Me.GroupBox3.Controls.Add(Me.txtMinValue)
        Me.GroupBox3.Controls.Add(Me.txtSearchYear)
        Me.GroupBox3.Controls.Add(Me.btnDisplayModel)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnDisplayRegNumber)
        Me.GroupBox3.Controls.Add(Me.comSearchRegNum)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(776, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 398)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 26)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Maximum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 26)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Minimum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(181, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 67)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Display car by price"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDisplayYear
        '
        Me.btnDisplayYear.Location = New System.Drawing.Point(175, 209)
        Me.btnDisplayYear.Name = "btnDisplayYear"
        Me.btnDisplayYear.Size = New System.Drawing.Size(75, 57)
        Me.btnDisplayYear.TabIndex = 11
        Me.btnDisplayYear.Text = "Display car by year"
        Me.btnDisplayYear.UseVisualStyleBackColor = True
        '
        'CmbSearchModel
        '
        Me.CmbSearchModel.FormattingEnabled = True
        Me.CmbSearchModel.Items.AddRange(New Object() {"BMW", "Bugatti", "Cadillac", "Citroen", "Fiat", "Ferrari", "Ford", "Honda ", "Hyundai", "Kia", "Mazda", "Mini ", "Mitsubishi", "Morgan", "Nissan", "Opel", "Peugeot", "Porsche", "Renault", "Skoda", "Suzuki", "Toyota", "Volkswagen", "Volvo"})
        Me.CmbSearchModel.Location = New System.Drawing.Point(32, 167)
        Me.CmbSearchModel.Name = "CmbSearchModel"
        Me.CmbSearchModel.Size = New System.Drawing.Size(121, 23)
        Me.CmbSearchModel.TabIndex = 10
        Me.CmbSearchModel.Text = "Audi"
        '
        'txtMaxValue
        '
        Me.txtMaxValue.Location = New System.Drawing.Point(73, 346)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(86, 21)
        Me.txtMaxValue.TabIndex = 9
        Me.txtMaxValue.Text = "5000"
        '
        'txtMinValue
        '
        Me.txtMinValue.Location = New System.Drawing.Point(73, 313)
        Me.txtMinValue.Name = "txtMinValue"
        Me.txtMinValue.Size = New System.Drawing.Size(86, 21)
        Me.txtMinValue.TabIndex = 8
        Me.txtMinValue.Text = "250"
        '
        'txtSearchYear
        '
        Me.txtSearchYear.Location = New System.Drawing.Point(34, 245)
        Me.txtSearchYear.Name = "txtSearchYear"
        Me.txtSearchYear.Size = New System.Drawing.Size(91, 21)
        Me.txtSearchYear.TabIndex = 7
        '
        'btnDisplayModel
        '
        Me.btnDisplayModel.Location = New System.Drawing.Point(175, 141)
        Me.btnDisplayModel.Name = "btnDisplayModel"
        Me.btnDisplayModel.Size = New System.Drawing.Size(75, 49)
        Me.btnDisplayModel.TabIndex = 6
        Me.btnDisplayModel.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make"
        Me.btnDisplayModel.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Find car by particular price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Find car by particular price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Find car by year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Find car by make"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Find car by registration number"
        '
        'btnDisplayRegNumber
        '
        Me.btnDisplayRegNumber.Location = New System.Drawing.Point(175, 61)
        Me.btnDisplayRegNumber.Name = "btnDisplayRegNumber"
        Me.btnDisplayRegNumber.Size = New System.Drawing.Size(75, 54)
        Me.btnDisplayRegNumber.TabIndex = 1
        Me.btnDisplayRegNumber.Text = "Display Reg. Num"
        Me.btnDisplayRegNumber.UseVisualStyleBackColor = True
        '
        'comSearchRegNum
        '
        Me.comSearchRegNum.FormattingEnabled = True
        Me.comSearchRegNum.Location = New System.Drawing.Point(33, 75)
        Me.comSearchRegNum.Name = "comSearchRegNum"
        Me.comSearchRegNum.Size = New System.Drawing.Size(121, 23)
        Me.comSearchRegNum.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(606, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "List of cards"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnChanges
        '
        Me.btnChanges.Location = New System.Drawing.Point(610, 449)
        Me.btnChanges.Name = "btnChanges"
        Me.btnChanges.Size = New System.Drawing.Size(88, 23)
        Me.btnChanges.TabIndex = 6
        Me.btnChanges.Text = "Make Changes"
        Me.btnChanges.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 452)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(608, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "to make changes select car in the list box and press button ""Make Changes"" "
        '
        'btnPrints
        '
        Me.btnPrints.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrints.Location = New System.Drawing.Point(777, 426)
        Me.btnPrints.Name = "btnPrints"
        Me.btnPrints.Size = New System.Drawing.Size(66, 46)
        Me.btnPrints.TabIndex = 8
        Me.btnPrints.Text = "Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all cars"
        Me.btnPrints.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(858, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 46)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Preveiw print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all cars"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 480)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPrints)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnChanges)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRegNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstListCar As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbMake As System.Windows.Forms.ComboBox
    Friend WithEvents lstHead As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDisplayRegNumber As System.Windows.Forms.Button
    Friend WithEvents comSearchRegNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchModel As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaxValue As System.Windows.Forms.TextBox
    Friend WithEvents txtMinValue As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchYear As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayModel As System.Windows.Forms.Button
    Friend WithEvents btnDisplayYear As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnChanges As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnPrints As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class

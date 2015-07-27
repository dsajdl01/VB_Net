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
        Me.cmbContinent = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstCountries = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstCities = New System.Windows.Forms.ListBox
        Me.lblCapCity = New System.Windows.Forms.Label
        Me.btnKlick = New System.Windows.Forms.Button
        Me.lblTest = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblOutput = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCorect = New System.Windows.Forms.Label
        Me.lblIncorrect = New System.Windows.Forms.Label
        Me.lblPerc = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbContinent
        '
        Me.cmbContinent.FormattingEnabled = True
        Me.cmbContinent.Items.AddRange(New Object() {"Asia", "Australia, North & Central America", "South America", "Afrika", "Europa"})
        Me.cmbContinent.Location = New System.Drawing.Point(32, 47)
        Me.cmbContinent.Name = "cmbContinent"
        Me.cmbContinent.Size = New System.Drawing.Size(153, 21)
        Me.cmbContinent.TabIndex = 0
        Me.cmbContinent.Text = "Asia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Continent"
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.Location = New System.Drawing.Point(32, 109)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(153, 121)
        Me.lstCountries.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Country"
        '
        'lstCities
        '
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.Location = New System.Drawing.Point(245, 57)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(120, 173)
        Me.lstCities.TabIndex = 4
        '
        'lblCapCity
        '
        Me.lblCapCity.AutoSize = True
        Me.lblCapCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapCity.Location = New System.Drawing.Point(242, 18)
        Me.lblCapCity.Name = "lblCapCity"
        Me.lblCapCity.Size = New System.Drawing.Size(157, 13)
        Me.lblCapCity.TabIndex = 5
        Me.lblCapCity.Text = "What is the capital city of " & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'btnKlick
        '
        Me.btnKlick.Location = New System.Drawing.Point(389, 47)
        Me.btnKlick.Name = "btnKlick"
        Me.btnKlick.Size = New System.Drawing.Size(75, 46)
        Me.btnKlick.TabIndex = 6
        Me.btnKlick.Text = "Click"
        Me.btnKlick.UseVisualStyleBackColor = True
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(146, 252)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(10, 13)
        Me.lblTest.TabIndex = 7
        Me.lblTest.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Selected Country is"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Selected City is"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(324, 252)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(10, 13)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = " "
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(16, 283)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Padding = New System.Windows.Forms.Padding(0, 0, 25, 8)
        Me.lblOutput.Size = New System.Drawing.Size(27, 30)
        Me.lblOutput.TabIndex = 11
        Me.lblOutput.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Your correst " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "answers are :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Your incorrect " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "answers are:"
        '
        'lblCorect
        '
        Me.lblCorect.AutoSize = True
        Me.lblCorect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorect.Location = New System.Drawing.Point(408, 153)
        Me.lblCorect.Name = "lblCorect"
        Me.lblCorect.Padding = New System.Windows.Forms.Padding(0, 0, 10, 3)
        Me.lblCorect.Size = New System.Drawing.Size(31, 25)
        Me.lblCorect.TabIndex = 14
        Me.lblCorect.Text = "0"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(408, 240)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Padding = New System.Windows.Forms.Padding(0, 0, 10, 3)
        Me.lblIncorrect.Size = New System.Drawing.Size(31, 25)
        Me.lblIncorrect.TabIndex = 15
        Me.lblIncorrect.Text = "0"
        '
        'lblPerc
        '
        Me.lblPerc.AutoSize = True
        Me.lblPerc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerc.Location = New System.Drawing.Point(408, 307)
        Me.lblPerc.Name = "lblPerc"
        Me.lblPerc.Padding = New System.Windows.Forms.Padding(0, 0, 10, 3)
        Me.lblPerc.Size = New System.Drawing.Size(31, 25)
        Me.lblPerc.TabIndex = 16
        Me.lblPerc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(374, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Your persentage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of success "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 21)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Quit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 354)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPerc)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.btnKlick)
        Me.Controls.Add(Me.lblCapCity)
        Me.Controls.Add(Me.lstCities)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstCountries)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbContinent)
        Me.Name = "Form1"
        Me.Text = "Test of Countries and Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbContinent As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCountries As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCities As System.Windows.Forms.ListBox
    Friend WithEvents lblCapCity As System.Windows.Forms.Label
    Friend WithEvents btnKlick As System.Windows.Forms.Button
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCorect As System.Windows.Forms.Label
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblPerc As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

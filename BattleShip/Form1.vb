Public Class Form1
    ' Declering global variables
    Dim lblColomn(5) As Label
    Dim lblRow(5) As Label
    Dim lblFild(35) As Label
    Dim lblHead(0) As Label
    Dim EasyHit() As String = {"No", "No", "Yes", "No", "No", "No", "No", "No", "Yes", "No", "No", "No", "Yes", "No", "No"}
    Dim MediumHit(,) As String = {{"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "No", "No", "Yes"}, {"No", "No", "No", "No", "No", "Yes"}, {"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "Yes", "No", "No"}}
    Dim HardHit(,) As String = {{"No", "No", "No", "No", "No", "No"}, {"No", "No", "Yes", "No", "No", "No"}, {"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "No", "No", "No"}, {"No", "No", "No", "No", "No", "No"}}
    Dim Count, Number, Rows, Columns As Short
    Dim CurrentHit, Result As Boolean
    Dim f As New Font("Arial", 14, FontStyle.Bold)
    Dim h As New Font("Tahoma", 16, FontStyle.Bold)
    Dim Boxes As DialogResult
    Dim Str As String = Space(18) & "YOU WIN THE GAME!!!" & vbNewLine
    Dim EasyTime, MediumTime, HardTime As Integer
    Dim Good, Worst, MidGood, MidWorst, HardGood, HardWorst As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' give head text to form
        lblHead(0) = lblText
        lblHead(0).Text = "Battle Ships"
        lblHead(0).Font = h
        lblHead(0).ForeColor = Color.IndianRed


        ' control array for column as label
        lblColomn(0) = lbl1
        lblColomn(1) = lbl2
        lblColomn(2) = lbl3
        lblColomn(3) = lbl4
        lblColomn(4) = lbl5
        lblColomn(5) = lbl6

        ' give numver to each column
        For i As Short = 0 To 5
            lblColomn(i).Text = i + 1
            lblColomn(i).Font = f
        Next

        'Control array for row as label
        lblRow(0) = lblA
        lblRow(1) = lblB
        lblRow(2) = lblC
        lblRow(3) = lblD
        lblRow(4) = lblE
        lblRow(5) = lblF

        'Gives letter to each row
        For z As Short = 0 To 5
            If z = 0 Then
                lblRow(z).Text = "A"
            ElseIf z = 1 Then
                lblRow(z).Text = "B"
            ElseIf z = 2 Then
                lblRow(z).Text = "C"
            ElseIf z = 3 Then
                lblRow(z).Text = "D"
            ElseIf z = 4 Then
                lblRow(4).Text = "E"
            ElseIf z = 5 Then
                lblRow(z).Text = "F"
            End If
            ' give to letter font what contain variable f
            For y As Short = 0 To 5
                lblRow(y).Font = f
            Next
        Next

        'Control array for each fild as label
        lblFild(0) = lblA1
        lblFild(1) = lblA2
        lblFild(2) = lblA3
        lblFild(3) = lblA4
        lblFild(4) = lblA5
        lblFild(5) = lblA6
        lblFild(6) = lblB1
        lblFild(7) = lblB2
        lblFild(8) = lblB3
        lblFild(9) = lblB4
        lblFild(10) = lblB5
        lblFild(11) = lblB6
        lblFild(12) = lblC1
        lblFild(13) = lblC2
        lblFild(14) = lblC3
        lblFild(15) = lblC4
        lblFild(16) = lblC5
        lblFild(17) = lblC6
        lblFild(18) = lblD1
        lblFild(19) = lblD2
        lblFild(20) = lblD3
        lblFild(21) = lblD4
        lblFild(22) = lblD5
        lblFild(23) = lblD6
        lblFild(24) = lblF1
        lblFild(25) = lblF2
        lblFild(26) = lblF3
        lblFild(27) = lblF4
        lblFild(28) = lblF5
        lblFild(29) = lblF6
        lblFild(30) = lblE1
        lblFild(31) = lblE2
        lblFild(32) = lblE3
        lblFild(33) = lblE4
        lblFild(34) = lblE5
        lblFild(35) = lblE6
        'Declare variable font
        Dim r As New Font("Arial", 20, FontStyle.Bold)
        'give to each fild letter x, color, bord style and all filds will be enabled 
        For x As Short = 0 To 35
            lblFild(x).Text = " X "
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Font = r
            lblFild(x).BorderStyle = BorderStyle.FixedSingle
            lblFild(x).Enabled = False
        Next


    End Sub

    Private Sub rdbEasy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEasy.CheckedChanged, rdbMedium.CheckedChanged, rdbHard.CheckedChanged

        ' Control of radio buttons that give lavel 
        For b As Short = 0 To 35
            lblFild(b).Enabled = False
            lblFild(b).Text = " X "
            lblFild(b).BackColor = Color.LightGray
            lblFild(b).BorderStyle = BorderStyle.FixedSingle
        Next
        If rdbEasy.Checked = True Then ' deal only with easy level

            ' Hide Number 5, 6 and letters E, F when easy level is true
            lbl5.Visible = False
            lbl6.Visible = False
            lblE.Visible = False
            lblF.Visible = False
            'Hide files E1 to E6, F1 to F6
            lblE1.Visible = False
            lblE2.Visible = False
            lblE3.Visible = False
            lblE4.Visible = False
            lblE5.Visible = False
            lblE6.Visible = False
            lblF1.Visible = False
            lblF2.Visible = False
            lblF3.Visible = False
            lblF4.Visible = False
            lblF5.Visible = False
            lblF6.Visible = False
            ' Hide files A5, A6, B5, B6, C6, C5, D5 and D6 
            lblA5.Visible = False
            lblA6.Visible = False
            lblB5.Visible = False
            lblB6.Visible = False
            lblC5.Visible = False
            lblC6.Visible = False
            lblD5.Visible = False
            lblD6.Visible = False

        ElseIf rdbMedium.Checked = True Then ' deal with medium level only
            ' Show all files
            For b As Short = 0 To 35
                lblFild(b).Enabled = False
                lblFild(b).Text = " X "
                lblFild(b).BackColor = Color.LightGray
                lblFild(b).BorderStyle = BorderStyle.FixedSingle
                lblFild(b).Visible = True
            Next b
            ' show row numbers
            For z As Short = 0 To 5
                lblRow(z).Visible = True
            Next z
            'Show columns letters
            For i As Short = 0 To 5
                lblColomn(i).Visible = True
            Next i

        ElseIf rdbHard.Checked = True Then 'deal with hard level only
            For b As Short = 0 To 35 ' show all files
                lblFild(b).Enabled = False
                lblFild(b).Text = " X "
                lblFild(b).BackColor = Color.LightGray
                lblFild(b).BorderStyle = BorderStyle.FixedSingle
                lblFild(b).Visible = True
            Next b
            ' show letters in row
            For z As Short = 0 To 5
                lblRow(z).Visible = True
            Next z
            ' show numbers in columns
            For i As Short = 0 To 5
                lblColomn(i).Visible = True
            Next i

        End If
        timer1.Enabled = False ' stop time to count
        lblHit.Visible = False ' hide hit results
        lblTime.Text = 0    ' give to time stop value zero
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        ' when start butten is pres
        timer1.Enabled = True ' start time to count
        timer1.Interval = 1000 ' interval in time to 1000 as one second to change
        lblTime.Text = 0    ' give to time value zero
        For x As Short = 0 To 35 ' for loop deal with all filds
            lblFild(x).Enabled = True   ' make all filds enabled
            lblFild(x).Text = " X "     ' give filds text letter x 
            lblFild(x).BackColor = Color.LightGray   ' give to fild back ground color light grey
            Count = 0 ' initially count variable to zero
        Next x
    End Sub

    Private Sub lblA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA1.Click
        ' When A1 fild is press
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 0
        Number = 0
        If rdbEasy.Checked = True Then ' Deal with easy A1 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblA1.BackColor = Color.Azure
                lblHit.Visible = True
                lblA1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(7) = "Yes"
                    EasyHit(12) = "Yes"
                    EasyHit(14) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then  ' Deal with medium level A1 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA1.BackColor = Color.Azure
                lblHit.Visible = True
                lblA1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 1) = "Yes"
                    MediumHit(3, 4) = "Yes"
                    MediumHit(1, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then ' Deal with hard level A1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA1.BackColor = Color.Azure
                lblHit.Visible = True
                lblA1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA2.Click
        ' Deal with A2 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 1
        Number = 1
        If rdbEasy.Checked = True Then 'Deal with easy level A2 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblA2.BackColor = Color.Azure
                lblHit.Visible = True
                lblA2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(1) = "Yes"
                    EasyHit(11) = "Yes"
                    EasyHit(14) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then 'Deal with medium level A2 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA2.BackColor = Color.Azure
                lblHit.Visible = True
                lblA2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(0, 5) = "Yes"
                    MediumHit(2, 2) = "Yes"
                    MediumHit(4, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA2.BackColor = Color.Azure
                lblHit.Visible = True
                lblA2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub

    Private Sub lblA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA3.Click
        'Deal with A3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 2
        Number = 2
        If rdbEasy.Checked = True Then  ' deal only with easy Level A3 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblA3.BackColor = Color.Azure
                lblA3.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(2) = "Yes"
                    EasyHit(13) = "Yes"
                    EasyHit(8) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then    ' deal only with mudium Level A3 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA3.BackColor = Color.Azure
                lblHit.Visible = True
                lblA3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 2) = "Yes"
                    MediumHit(2, 5) = "Yes"
                    MediumHit(5, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then  ' deal only with hard Level A3 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA3.BackColor = Color.Azure
                lblHit.Visible = True
                lblA3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA4.Click
        ' Deal with A4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 3
        Number = 3
        If rdbEasy.Checked = True Then  ' deal only with easy level A4 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblA4.BackColor = Color.Azure
                lblA4.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(1) = "Yes"
                    EasyHit(9) = "Yes"
                    EasyHit(12) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then    ' deal only with medium level A4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA4.BackColor = Color.Azure
                lblHit.Visible = True
                lblA4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 0) = "Yes"
                    MediumHit(2, 1) = "Yes"
                    MediumHit(1, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level A4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA4.BackColor = Color.Azure
                lblHit.Visible = True
                lblA4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblA5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA5.Click
        ' deal with A5 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 4
        If rdbMedium.Checked = True Then        'Deal only with medium level A5 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA5.BackColor = Color.Azure
                lblHit.Visible = True
                lblA5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 1) = "Yes"
                    MediumHit(3, 5) = "Yes"
                    MediumHit(0, 1) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'Deal only with hard level A5 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA5.BackColor = Color.Azure
                lblHit.Visible = True
                lblA5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 3) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblA6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA6.Click
        'Deal with A6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 0
        Columns = 5
        If rdbMedium.Checked = True Then        ' deal only with medium level A6 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA6.BackColor = Color.Azure
                lblHit.Visible = True
                lblA6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 0) = "Yes"
                    MediumHit(1, 3) = "Yes"
                    MediumHit(4, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level A6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblA6.BackColor = Color.Azure
                lblHit.Visible = True
                lblA6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblA6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB1.Click
        ' deal thiw B1 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 0
        Number = 4
        If rdbEasy.Checked = True Then      'deal only with easy level in B1 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblB1.BackColor = Color.Azure
                lblB1.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(2) = "Yes"
                    EasyHit(5) = "Yes"
                    EasyHit(10) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        'deal only with medium level in B1 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB1.BackColor = Color.Azure
                lblHit.Visible = True
                lblB1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 3) = "Yes"
                    MediumHit(5, 4) = "Yes"
                    MediumHit(0, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'deal only with hard level in B1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB1.BackColor = Color.Azure
                lblHit.Visible = True
                lblB1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If

        End If
    End Sub
    Private Sub lblB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB2.Click
        ' deal with B2 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 1
        Number = 5
        If rdbEasy.Checked = True Then      ' deal only with easy level in B2 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblB2.BackColor = Color.Azure
                lblB2.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(3) = "Yes"
                    EasyHit(6) = "Yes"
                    EasyHit(14) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then    ' deal only with medium level in B2 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB2.BackColor = Color.Azure
                lblHit.Visible = True
                lblB2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 5) = "Yes"
                    MediumHit(3, 2) = "Yes"
                    MediumHit(5, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          ' deal only with hard level in B2 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB2.BackColor = Color.Azure
                lblHit.Visible = True
                lblB2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB3.Click
        ' deal with B3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 2
        Number = 6
        If rdbEasy.Checked = True Then      ' deal only with easy level in B3 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblB3.BackColor = Color.Azure
                lblB3.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(4) = "Yes"
                    EasyHit(12) = "Yes"
                    EasyHit(13) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then   ' deal only with medium level in B3 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB3.BackColor = Color.Azure
                lblHit.Visible = True
                lblB3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 0) = "Yes"
                    MediumHit(3, 3) = "Yes"
                    MediumHit(0, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in B3 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB3.BackColor = Color.Azure
                lblHit.Visible = True
                lblB3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblB4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB4.Click
        ' deal with B4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 3
        Number = 7
        If rdbEasy.Checked = True Then      'deal only with easy level in B4 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblB4.BackColor = Color.Azure
                lblB4.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(3) = "Yes"
                    EasyHit(4) = "Yes"
                    EasyHit(9) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then          'deal only with medium level in B4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB4.BackColor = Color.Azure
                lblHit.Visible = True
                lblB4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 0) = "Yes"
                    MediumHit(5, 3) = "Yes"
                    MediumHit(0, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then        'deal only with hard level in B4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB4.BackColor = Color.Azure
                lblHit.Visible = True
                lblB4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 3) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblB5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB5.Click
        ' deal with B5 fild
        lblHit.Visible = False
        lblHit.BackColor = Color.WhiteSmoke
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 4
        If rdbMedium.Checked = True Then        'deal only with medium level in B4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB5.BackColor = Color.Azure
                lblHit.Visible = True
                lblB5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(0, 0) = "Yes"
                    MediumHit(4, 2) = "Yes"
                    MediumHit(2, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If

        ElseIf rdbHard.Checked = True Then      'deal only with hard level in B4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB5.BackColor = Color.Azure
                lblHit.Visible = True
                lblB5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblB6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblB6.Click
        ' deal with B6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 1
        Columns = 5
        If rdbMedium.Checked = True Then        'deal only with medium level in B6 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB6.BackColor = Color.Azure
                lblHit.Visible = True
                lblB6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 0) = "Yes"
                    MediumHit(5, 1) = "Yes"
                    MediumHit(4, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'deal only with hard level in B6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblB6.BackColor = Color.Azure
                lblHit.Visible = True
                lblB6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblB6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC1.Click
        ' deal with C1 fild
        lblHit.Visible = False
        lblHit.BackColor = Color.WhiteSmoke
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 0
        Number = 8
        If rdbEasy.Checked = True Then      ' deal only with easy level in C1 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblC1.BackColor = Color.Azure
                lblC1.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(7) = "Yes"
                    EasyHit(9) = "Yes"
                    EasyHit(14) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in C1 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC1.BackColor = Color.Azure
                lblHit.Visible = True
                lblC1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 5) = "Yes"
                    MediumHit(4, 1) = "Yes"
                    MediumHit(2, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in C1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC1.BackColor = Color.Azure
                lblHit.Visible = True
                lblC1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC2.Click
        ' deal with C2 fild
        lblHit.Visible = False
        lblHit.BackColor = Color.WhiteSmoke
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 1
        If rdbEasy.Checked = True Then      ' deal only with easy level in C2 fild
            Number = 9
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblC2.BackColor = Color.Azure
                lblC2.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(2) = "Yes"
                    EasyHit(9) = "Yes"
                    EasyHit(13) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in C2 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC2.BackColor = Color.Azure
                lblHit.Visible = True
                lblC2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 2) = "Yes"
                    MediumHit(1, 4) = "Yes"
                    MediumHit(0, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in C2 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC2.BackColor = Color.Azure
                lblHit.Visible = True
                lblC2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC3.Click
        ' deal with C3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 2
        Number = 10
        If rdbEasy.Checked = True Then      ' deal only with easy level in C3 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblC3.BackColor = Color.Azure
                lblC3.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(6) = "Yes"
                    EasyHit(8) = "Yes"
                    EasyHit(12) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in C3 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC3.BackColor = Color.Azure
                lblHit.Visible = True
                lblC3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 0) = "Yes"
                    MediumHit(5, 1) = "Yes"
                    MediumHit(4, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in C3 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC3.BackColor = Color.Azure
                lblHit.Visible = True
                lblC3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC4.Click
        ' deal with C4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 3
        Number = 11
        If rdbEasy.Checked = True Then          'deal only with easy level in C4 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblC4.BackColor = Color.Azure
                lblC4.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(5) = "Yes"
                    EasyHit(9) = "Yes"
                    EasyHit(12) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then          'deal only with medium level in C4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC4.BackColor = Color.Azure
                lblHit.Visible = True
                lblC4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 1) = "Yes"
                    MediumHit(0, 5) = "Yes"
                    MediumHit(4, 0) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then        'deal only with hard level in C4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC4.BackColor = Color.Azure
                lblHit.Visible = True
                lblC4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC5.Click
        ' deal with C5 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 4
        If rdbMedium.Checked = True Then        ' deal only with medium level in C5 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC5.BackColor = Color.Azure
                lblHit.Visible = True
                lblC5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 5) = "Yes"
                    MediumHit(0, 0) = "Yes"
                    MediumHit(2, 0) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in C5 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC5.BackColor = Color.Azure
                lblHit.Visible = True
                lblC5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 3) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblC6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC6.Click
        ' deal with C6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 2
        Columns = 5
        If rdbMedium.Checked = True Then        ' deal only with medium level in C6 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC6.BackColor = Color.Azure
                lblHit.Visible = True
                lblC6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 5) = "Yes"
                    MediumHit(3, 2) = "Yes"
                    MediumHit(4, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in C6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblC6.BackColor = Color.Azure
                lblHit.Visible = True
                lblC6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 3) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblC6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD1.Click
        ' deal with D1 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 0
        Number = 12
        If rdbEasy.Checked = True Then      'deal only with easy level in D1 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblD1.BackColor = Color.Azure
                lblD1.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(4) = "Yes"
                    EasyHit(7) = "Yes"
                    EasyHit(14) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        'deal only with medium level in D1 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD1.BackColor = Color.Azure
                lblHit.Visible = True
                lblD1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 1) = "Yes"
                    MediumHit(3, 5) = "Yes"
                    MediumHit(5, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'deal only with hard level in D1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD1.BackColor = Color.Azure
                lblHit.Visible = True
                lblD1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblD2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD2.Click
        ' deal with D2 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 1
        Number = 13
        If rdbEasy.Checked = True Then      ' deal only with easy level in D2 fild 
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblD2.BackColor = Color.Azure
                lblD2.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(2) = "Yes"
                    EasyHit(6) = "Yes"
                    EasyHit(10) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If

                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in D2 fild 
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD2.BackColor = Color.Azure
                lblHit.Visible = True
                lblD2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 2) = "Yes"
                    MediumHit(0, 4) = "Yes"
                    MediumHit(0, 1) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in D2 fild 
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD2.BackColor = Color.Azure
                lblHit.Visible = True
                lblD2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblD3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD3.Click
        ' deal with D3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 2
        Number = 14
        If rdbEasy.Checked = True Then      ' deal only with easy level in D3 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblD3.BackColor = Color.Azure
                lblD3.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit(Number) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(1) = "Yes"
                    EasyHit(8) = "Yes"
                    EasyHit(13) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in D3 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD3.BackColor = Color.Azure
                lblHit.Visible = True
                lblD3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 3) = "Yes"
                    MediumHit(4, 1) = "Yes"
                    MediumHit(1, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in D3 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD3.BackColor = Color.Azure
                lblHit.Visible = True
                lblD3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblD4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD4.Click
        ' deal with D4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 3
        Number = 15
        If rdbEasy.Checked = True Then      ' deal only with easy level in D4 fild
            CurrentHit = (EasyProcess(Number))
            If CurrentHit = True Then
                lblD4.BackColor = Color.Azure
                lblD4.Text = "  * "
                lblHit.Visible = True
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                EasyHit((Number) - 1) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    EasyHit(4) = "Yes"
                    EasyHit(9) = "Yes"
                    EasyHit(11) = "Yes"
                    timer1.Enabled = False
                    EasyTime = lblTime.Text
                    If Worst = 0 Then
                        Good = EasyTime
                        Worst = EasyTime
                    End If
                    If Worst < EasyTime Then
                        Worst = EasyTime
                    ElseIf Good > EasyTime Then
                        Good = EasyTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbMedium.Checked = True Then        ' deal only with medium level in D4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD4.BackColor = Color.Azure
                lblHit.Visible = True
                lblD4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(0, 3) = "Yes"
                    MediumHit(3, 1) = "Yes"
                    MediumHit(5, 0) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      ' deal only with hard level in D4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD4.BackColor = Color.Azure
                lblHit.Visible = True
                lblD4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub

    Private Sub lblD5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD5.Click
        ' deal with D5 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 4
        If rdbMedium.Checked = True Then        ' deal only with medium level in D5 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD5.BackColor = Color.Azure
                lblHit.Visible = True
                lblD5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 0) = "Yes"
                    MediumHit(3, 4) = "Yes"
                    MediumHit(5, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then       ' deal only with hard level in D5 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD5.BackColor = Color.Azure
                lblHit.Visible = True
                lblD5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblD6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblD6.Click
        ' deal with D6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 3
        Columns = 5
        If rdbMedium.Checked = True Then        ' Deal only with medium level in D6 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD6.BackColor = Color.Azure
                lblHit.Visible = True
                lblD6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 3) = "Yes"
                    MediumHit(0, 0) = "Yes"
                    MediumHit(1, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          ' Deal only with hard level in D6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblD6.BackColor = Color.Azure
                lblHit.Visible = True
                lblD6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblD6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE1.Click
        ' deal with E1 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 0
        If rdbMedium.Checked = True Then            ' Deal only with medium level in E1 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE1.BackColor = Color.Azure
                lblHit.Visible = True
                lblE1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 4) = "Yes"
                    MediumHit(1, 1) = "Yes"
                    MediumHit(0, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          ' Deal only with medium level in E1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE1.BackColor = Color.Azure
                lblHit.Visible = True
                lblE1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE2.Click
        ' deal with E2 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 1
        If rdbMedium.Checked = True Then        ' Deal only with medium level in E2 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE2.BackColor = Color.Azure
                lblHit.Visible = True
                lblE2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 0) = "Yes"
                    MediumHit(0, 2) = "Yes"
                    MediumHit(2, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          ' Deal only with hard level in E2 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE2.BackColor = Color.Azure
                lblHit.Visible = True
                lblE2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 5) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE3.Click
        ' deal with E3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 2
        If rdbMedium.Checked = True Then            ' Deal only with medium level in E3 fild
            Number = 26
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE3.BackColor = Color.Azure
                lblHit.Visible = True
                lblE3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 0) = "Yes"
                    MediumHit(5, 4) = "Yes"
                    MediumHit(1, 0) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          ' Deal only with hard level in E3 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE3.BackColor = Color.Azure
                lblHit.Visible = True
                lblE3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 3) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE4.Click
        'Deal with E4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 3
        If rdbMedium.Checked = True Then        'deal only with medium level in E4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE4.BackColor = Color.Azure
                lblHit.Visible = True
                lblE4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 2) = "Yes"
                    MediumHit(3, 4) = "Yes"
                    MediumHit(2, 1) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'deal only with hard level in E4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE4.BackColor = Color.Azure
                lblHit.Visible = True
                lblE4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE5.Click
        ' deal with E5 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 4
        If rdbMedium.Checked = True Then        'deal only with medium level in E5 fild
            Number = 28
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE5.BackColor = Color.Azure
                lblHit.Visible = True
                lblE5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 5) = "Yes"
                    MediumHit(5, 1) = "Yes"
                    MediumHit(1, 2) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in E5 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE5.BackColor = Color.Azure
                lblHit.Visible = True
                lblE5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(5, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblE6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblE6.Click
        ' deal with E6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 4
        Columns = 5
        If rdbMedium.Checked = True Then            'deal only with medium level in E6 fild
            Number = 29
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE6.BackColor = Color.Azure
                lblHit.Visible = True
                lblE6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(1, 5) = "Yes"
                    MediumHit(4, 3) = "Yes"
                    MediumHit(3, 2) = "Yes"
                    timer1.Enabled = False
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    MediumTime = lblTime.Text
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in E6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblE6.BackColor = Color.Azure
                lblHit.Visible = True
                lblE6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 2) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblE6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF1.Click
        ' deal with F1 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 0
        If rdbMedium.Checked = True Then            'deal only with medium level in F1 fild
            Number = 30
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF1.BackColor = Color.Azure
                lblHit.Visible = True
                lblF1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 4) = "Yes"
                    MediumHit(1, 3) = "Yes"
                    MediumHit(4, 1) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in F1 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF1.BackColor = Color.Azure
                lblHit.Visible = True
                lblF1.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(1, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF1.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF2.Click
        ' deal with F1 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 1
        If rdbMedium.Checked = True Then        'deal only with medium level in F2 fild
            Number = 31
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF2.BackColor = Color.Azure
                lblHit.Visible = True
                lblF2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(5, 3) = "Yes"
                    MediumHit(0, 3) = "Yes"
                    MediumHit(2, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then      'deal only with hard level in F2 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF2.BackColor = Color.Azure
                lblHit.Visible = True
                lblF2.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(3, 0) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF2.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF3.Click
        ' deal with F3 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 2
        If rdbMedium.Checked = True Then        'deal only with medium level in F3 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF3.BackColor = Color.Azure
                lblHit.Visible = True
                lblF3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 0) = "Yes"
                    MediumHit(1, 4) = "Yes"
                    MediumHit(3, 3) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in F2 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF3.BackColor = Color.Azure
                lblHit.Visible = True
                lblF3.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF3.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF4.Click
        ' deal with F4 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 3
        If rdbMedium.Checked = True Then            'deal only with medium level in F4 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF4.BackColor = Color.Azure
                lblHit.Visible = True
                lblF4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(4, 2) = "Yes"
                    MediumHit(2, 0) = "Yes"
                    MediumHit(0, 4) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in F4 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF4.BackColor = Color.Azure
                lblHit.Visible = True
                lblF4.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(2, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF4.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF5.Click
        ' deal with F5 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 4
        If rdbMedium.Checked = True Then        'deal only with medium level in F5 fild
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF5.BackColor = Color.Azure
                lblHit.Visible = True
                lblF5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(3, 1) = "Yes"
                    MediumHit(2, 4) = "Yes"
                    MediumHit(5, 5) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in F5 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF5.BackColor = Color.Azure
                lblHit.Visible = True
                lblF5.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(0, 4) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF5.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Private Sub lblF6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblF6.Click
        ' deal with F6 fild
        lblHit.BackColor = Color.WhiteSmoke
        lblHit.Visible = False
        For x As Short = 0 To 35
            lblFild(x).BackColor = Color.LightGray
            lblFild(x).Text = " X "
        Next
        Rows = 5
        Columns = 5
        If rdbMedium.Checked = True Then      'deal only with medium level in F6 fild
            Number = 35
            CurrentHit = (MediumProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF6.BackColor = Color.Azure
                lblHit.Visible = True
                lblF6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                MediumHit(Rows, Columns) = "No"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    MediumHit(2, 2) = "Yes"
                    MediumHit(1, 5) = "Yes"
                    MediumHit(4, 1) = "Yes"
                    timer1.Enabled = False
                    MediumTime = lblTime.Text
                    If MidWorst = 0 Then
                        MidGood = MediumTime
                        MidWorst = MediumTime
                    End If
                    If MidWorst < MediumTime Then
                        MidWorst = MediumTime
                    ElseIf MidGood > MediumTime Then
                        MidGood = MediumTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        ElseIf rdbHard.Checked = True Then          'deal only with hard level in F6 fild
            CurrentHit = (HardProcess(Rows, Columns))
            If CurrentHit = True Then
                lblF6.BackColor = Color.Azure
                lblHit.Visible = True
                lblF6.Text = "  * "
                lblHit.Text = (" You Hit! ")
                lblHit.Font = f
                lblHit.ForeColor = Color.Red
                lblHit.BackColor = Color.Azure
                Count += 1
                HardHit(Rows, Columns) = "No"
                HardHit(4, 1) = "Yes"
                If Count = 3 Then
                    lblHit.Text = " You win the game"
                    lblHit.Visible = True
                    lblHit.BackColor = Color.LightSkyBlue
                    lblHit.Font = h
                    timer1.Enabled = False
                    HardTime = lblTime.Text
                    If HardWorst = 0 Then
                        HardGood = HardTime
                        HardWorst = HardTime
                    End If
                    If HardWorst < HardTime Then
                        HardWorst = HardTime
                    ElseIf HardGood > HardTime Then
                        HardGood = HardTime
                    End If
                    For b As Short = 0 To 35
                        lblFild(b).Enabled = False
                    Next
                    Boxes = MessageBox.Show(Me, Str & vbNewLine & " Do you want to play another game (press Yes)" & vbNewLine & " or you want to quit (press No)", "Battle Ship Message", MessageBoxButtons.YesNo)
                    If Boxes = DialogResult.Yes Then
                        For b As Short = 0 To 35
                            lblFild(b).Text = " X "
                            lblFild(b).BackColor = Color.LightGray
                            lblHit.Visible = False
                        Next
                    Else
                        Me.Close()
                    End If
                End If
            Else
                lblF6.BackColor = Color.DimGray
                lblHit.Visible = True
                lblHit.Font = f
                lblHit.Text = "You Miss"
            End If
        End If
    End Sub
    Function EasyProcess(ByVal ArrayPosition As Integer)
        For g As Short = 0 To EasyHit.Length - 1
            If g = ArrayPosition Then
                If String.Compare(EasyHit(g), "Yes") = False Then
                    Result = True
                Else
                    Result = False
                End If
            End If
        Next g
        Return Result
    End Function
    Function MediumProcess(ByVal MediumFirstNum As Integer, ByVal MediumSecondNum As Integer)
        Dim B0 As Integer = MediumHit.GetUpperBound(0)
        Dim B1 As Integer = MediumHit.GetUpperBound(1)
        For k As Short = 0 To B0
            For z As Short = 0 To B1
                If k = MediumFirstNum And z = MediumSecondNum Then
                    If String.Compare(MediumHit(k, z), "Yes") = False Then
                        Result = True
                    Else
                        Result = False
                    End If
                End If
            Next z
        Next k
        Return Result
    End Function
    Function HardProcess(ByVal FirstNum As Integer, ByVal SecondNum As Integer)
        Dim Bound0 As Integer = HardHit.GetUpperBound(0)
        Dim Bound1 As Integer = HardHit.GetUpperBound(1)
        For y As Short = 0 To Bound0
            For x As Short = 0 To Bound1
                If y = FirstNum And x = SecondNum Then
                    If String.Compare(HardHit(y, x), "Yes") = False Then
                        Result = True
                    Else
                        Result = False
                    End If
                End If
            Next x
        Next y
        Return Result
    End Function
    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        lblTime.Text = lblTime.Text + 1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If rdbEasy.Checked = True Then
            lblTextTimeG.Text = "The best time for" & vbNewLine & Space(4) & "easy level is"
            lblTextTimeB.Text = "The worst time for" & vbNewLine & Space(4) & "easy level is"
            lblBest.Text = Good
            lblWorst.Text = Worst
        ElseIf rdbMedium.Checked = True Then
            lblTextTimeG.Text = "The best time for" & vbNewLine & Space(3) & "medium level is"
            lblTextTimeB.Text = "The worst time for" & vbNewLine & Space(3) & "medium level is"
            lblBest.Text = MidGood
            lblWorst.Text = MidWorst
        ElseIf rdbHard.Checked = True Then
            lblTextTimeG.Text = "The best time for" & vbNewLine & Space(4) & "hard level is"
            lblTextTimeB.Text = "The worst time for" & vbNewLine & Space(4) & "hard level is"
            lblBest.Text = HardGood
            lblWorst.Text = HardWorst
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Boxes = MessageBox.Show(Me, "Are you sure that you want to exit game, than press Yes" & vbNewLine & vbNewLine & "or press No, to stay", "Battle Ship Message", MessageBoxButtons.YesNo)
        If Boxes = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

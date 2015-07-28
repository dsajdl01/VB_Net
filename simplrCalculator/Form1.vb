Public Class Form1
    ' Declare global variables
    Dim lblNumber(10) As Label
    Dim lblArithmetic(4) As Label
    Dim lblText(0) As Label
    Dim lblOnOff(3) As Label
    Dim Str, Str1, Str2, Str3, Plus, Plus1, Plus2 As String
    Dim aa, bb, cc, dd, Result As Double
    Dim Count As Short
    Dim Check(2) As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Control array for numbers button on form 
        lblNumber(0) = lbl0
        lblNumber(1) = lbl1
        lblNumber(2) = lbl2
        lblNumber(3) = lbl3
        lblNumber(3) = lbl3
        lblNumber(4) = lbl4
        lblNumber(5) = lbl5
        lblNumber(6) = lbl6
        lblNumber(7) = lbl7
        lblNumber(8) = lbl8
        lblNumber(9) = lbl9
        lblNumber(10) = lblDot
        lblText(0) = lblTest

        ' Adding lables button into form give color and numbers
        For i As Integer = 0 To 10
            If i = 10 Then
                lblNumber(i).Text = "."
                lblNumber(i).BackColor = Color.Gray
                lblNumber(i).BorderStyle = BorderStyle.Fixed3D
            Else
                lblNumber(i).Text = i
                lblNumber(i).BackColor = Color.Gray
                lblNumber(i).BorderStyle = BorderStyle.Fixed3D
            End If
        Next

        ' Control array for arithmatic sign button in form
        lblArithmetic(0) = lblPlus
        lblArithmetic(1) = lblMinus
        lblArithmetic(2) = lblMult
        lblArithmetic(3) = lblDiv
        lblArithmetic(4) = lblEqual

        ' give arrithmetic labels sign and color
        For x As Integer = 0 To 4
            If x = 0 Then
                lblArithmetic(x).Text = "+"
                lblArithmetic(x).BackColor = Color.Silver
                lblArithmetic(x).BorderStyle = BorderStyle.Fixed3D
            ElseIf x = 1 Then
                lblArithmetic(x).Text = "-"
                lblArithmetic(x).BackColor = Color.Silver
                lblArithmetic(x).BorderStyle = BorderStyle.Fixed3D
            ElseIf x = 2 Then
                lblArithmetic(x).Text = "*"
                lblArithmetic(x).BackColor = Color.Silver
                lblArithmetic(x).BorderStyle = BorderStyle.Fixed3D
            ElseIf x = 3 Then
                lblArithmetic(x).Text = "/"
                lblArithmetic(x).BackColor = Color.Silver
                lblArithmetic(x).BorderStyle = BorderStyle.Fixed3D
            Else
                lblArithmetic(x).Text = "="
                lblArithmetic(x).BackColor = Color.Silver
                lblArithmetic(x).BorderStyle = BorderStyle.Fixed3D
            End If
        Next

        ' Control array for clear, quit and answer buttons labels
        lblOnOff(0) = lblC
        lblOnOff(1) = lblOff
        lblOnOff(2) = lblAnswer
        ' Give labels button color and text
        For z As Integer = 0 To 2
            If z = 0 Then
                lblOnOff(z).Text = "C"
                lblOnOff(z).BackColor = Color.White
                lblOnOff(z).BorderStyle = BorderStyle.FixedSingle
            ElseIf z = 1 Then
                lblOnOff(z).Text = "Off"
                lblOnOff(z).BackColor = Color.White
                lblOnOff(z).BorderStyle = BorderStyle.FixedSingle
            Else
                lblOnOff(z).Text = "Anwr:"
                lblOnOff(z).BackColor = Color.White
                lblOnOff(z).BorderStyle = BorderStyle.FixedSingle
            End If
            ' control Array that give text which appear as Arial 8 and bold style
            lblText(0).Text = "It would be accepted only 4 numbers to be added" & vbNewLine & Space(14) & "into the calculation in one time"
            Dim f As New Font("Arial", 8, FontStyle.Bold)
            lblText(0).Font = f
        Next
    End Sub

    Private Sub lbl0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl0.Click
        If Count = 0 Then
            Str = Str & 0
        ElseIf Count = 1 Then
            Str1 = Str1 & 0
        ElseIf Count = 2 Then
            Str2 = Str2 & 0
        Else
            Str3 = Str3 & 0
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click
        If Count = 0 Then
            Str = Str & 1
        ElseIf Count = 1 Then
            Str1 = Str1 & 1
        ElseIf Count = 2 Then
            Str2 = Str2 & 1
        Else
            Str3 = Str3 & 1
        End If
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl2.Click
        If Count = 0 Then
            Str = Str & 2
        ElseIf Count = 1 Then
            Str1 = Str1 & 2
        ElseIf Count = 2 Then
            Str2 = Str2 & 2
        Else
            Str3 = Str3 & 2
        End If
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl3.Click
        If Count = 0 Then
            Str = Str & 3
        ElseIf Count = 1 Then
            Str1 = Str1 & 3
        ElseIf Count = 2 Then
            Str2 = Str2 & 3
        Else
            Str3 = Str3 & 3
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl4.Click
        If Count = 0 Then
            Str = Str & 4
        ElseIf Count = 1 Then
            Str1 = Str1 & 4
        ElseIf Count = 2 Then
            Str2 = Str2 & 4
        Else
            Str3 = Str3 & 4
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl5.Click
        If Count = 0 Then
            Str = Str & 5
        ElseIf Count = 1 Then
            Str1 = Str1 & 5
        ElseIf Count = 2 Then
            Str2 = Str2 & 5
        Else
            Str3 = Str3 & 5
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lbl6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl6.Click
        If Count = 0 Then
            Str = Str & 6
        ElseIf Count = 1 Then
            Str1 = Str1 & 6
        ElseIf Count = 2 Then
            Str2 = Str2 & 6
        Else
            Str3 = Str3 & 6
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub
    Private Sub lbl7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl7.Click

        If Count = 0 Then
            Str = Str & 7
        ElseIf Count = 1 Then
            Str1 = Str1 & 7
        ElseIf Count = 2 Then
            Str2 = Str2 & 7
        Else
            Str3 = Str3 & 7
        End If

        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3

    End Sub

    Private Sub lbl8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl8.Click
        If Count = 0 Then
            Str = Str & 8
        ElseIf Count = 1 Then
            Str1 = Str1 & 8
        ElseIf Count = 2 Then
            Str2 = Str2 & 8
        Else
            Str3 = Str3 & 8
        End If
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub
    Private Sub lbl9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl9.Click
        If Count = 0 Then
            Str = Str & 9
        ElseIf Count = 1 Then
            Str1 = Str1 & 9
        ElseIf Count = 2 Then
            Str2 = Str2 & 9
        Else
            Str3 = Str3 & 9
        End If
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub
    Private Sub lblMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinus.Click
        ' add minus sign into output string
        Check(Count) = 50
        If Count = 0 Then
            Plus = " - "
        ElseIf Count = 1 Then
            Plus1 = " - "
        ElseIf Count = 2 Then
            Plus2 = " - "
            lblMult.Enabled = False
            lblDiv.Enabled = False
            lblPlus.Enabled = False
            lblMinus.Enabled = False
        Else
            MsgBox(" You neet to get result " & vbNewLine & " The System is able to hold four numbers", , "Warning Message")
        End If
        Count += 1
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3

    End Sub
    Private Sub lblDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDiv.Click
        '   Add division sign into output string
        Check(Count) = 150
        If Count = 0 Then
            Plus = " / "
        ElseIf Count = 1 Then
            Plus1 = " / "
        ElseIf Count = 2 Then
            Plus2 = " / "
            lblMult.Enabled = False
            lblDiv.Enabled = False
            lblPlus.Enabled = False
            lblMinus.Enabled = False
        Else
            MsgBox(" You neet to get result " & vbNewLine & " The System is able to hold four numbers", , "Warning Message")
        End If
        Count += 1
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub

    Private Sub lblPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlus.Click
        '    Add plus sign into output string
        Check(Count) = 55
        If Count = 0 Then
            Plus = " + "
        ElseIf Count = 1 Then
            Plus1 = " + "
        ElseIf Count = 2 Then
            Plus2 = " + "
            lblMult.Enabled = False
            lblDiv.Enabled = False
            lblPlus.Enabled = False
            lblMinus.Enabled = False
        Else
            MsgBox(" You neet to get result " & vbNewLine & " The System is able to hold four numbers", , "Warning Message")
        End If
        Count += 1
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3

    End Sub
    Private Sub lblMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMult.Click
        ' Add multiplacion sign into output string
        Check(Count) = 100
        If Count = 0 Then
            Plus = " * "
        ElseIf Count = 1 Then
            Plus1 = " * "
        ElseIf Count = 2 Then
            Plus2 = " * "
            lblMult.Enabled = False
            lblDiv.Enabled = False
            lblPlus.Enabled = False
            lblMinus.Enabled = False
        Else
            MsgBox(" You neet to get result " & vbNewLine & " The System is able to hold four numbers", , "Warning Message")
        End If
        Count += 1
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub
    Private Sub lblDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDot.Click
        ' Add dot (.) into string
        If Count = 0 Then
            Str = Str & "."
        ElseIf Count = 1 Then
            Str1 = Str1 & "."
        ElseIf Count = 2 Then
            Str2 = Str2 & "."
        Else
            Str3 = Str3 & "."
        End If
        txtNumbers.Text = Str & Plus & Str1 & Plus1 & Str2 & Plus2 & Str3
    End Sub
    Private Sub lblC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblC.Click
        ' Clear button clear all variables and set count into 0
        Str = ""
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Plus = ""
        Plus1 = ""
        Plus2 = ""
        txtNumbers.Text = "_"
        txtEqual.Text = 0
        Array.Clear(Check, Check.GetLowerBound(0), Check.Length)
        Count = 0
        lblMult.Enabled = True
        lblDiv.Enabled = True
        lblPlus.Enabled = True
        lblMinus.Enabled = True
    End Sub
    Private Sub lblOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOff.Click
        ' Closing down the program
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, "Are you sure that you want to quite pregram?", "Calculation swich off message", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lblEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEqual.Click
        ' Declaring adding numbers from string to doubles
        aa = CDbl(Val(Str))
        bb = CDbl(Val(Str1))
        cc = CDbl(Val(Str2))
        dd = CDbl(Val(Str3))

        ' Dealing with two added numbers

        If Check(0) = 55 Then
            Result = aa + bb
        ElseIf Check(0) = 50 Then
            Result = aa - bb
        ElseIf Check(0) = 100 Then
            Result = aa * bb
        ElseIf Check(0) = 150 Then
            Result = aa / bb
        End If

        '   Dealing with three added numbers

        If Check(1) = 55 Then
            If Check(0) = 55 And Check(1) = 55 Then
                Result = aa + bb + cc
            ElseIf Check(0) = 50 And Check(1) = 55 Then
                Result = aa - bb + cc
            ElseIf Check(0) = 100 And Check(1) = 55 Then
                Result = aa * bb + cc
            ElseIf Check(0) = 150 And Check(1) = 55 Then
                Result = aa / bb + cc
            End If
        ElseIf Check(1) = 50 Then
            If Check(0) = 55 And Check(1) = 50 Then
                Result = aa + bb - cc
            ElseIf Check(0) = 50 And Check(1) = 50 Then
                Result = aa - bb - cc
            ElseIf Check(0) = 100 And Check(1) = 50 Then
                Result = aa * bb - cc
            ElseIf Check(0) = 150 And Check(1) = 50 Then
                Result = aa / bb - cc
            End If
        ElseIf Check(1) = 100 Then
            If Check(0) = (55) And Check(1) = 100 Then
                Result = aa + bb * cc
            ElseIf Check(0) = 50 And Check(1) = 100 Then
                Result = aa - bb * cc
            ElseIf Check(0) = 100 And Check(1) = 100 Then
                Result = aa * bb * cc
            ElseIf Check(0) = 150 And Check(1) = 100 Then
                Result = aa / bb * cc
            End If
        ElseIf Check(1) = 150 Then
            If Check(0) = 150 And Check(1) = 150 Then
                Result = aa / bb / cc
            ElseIf Check(0) = 100 And Check(2) = 150 Then
                Result = aa * bb / cc
            ElseIf Check(0) = 50 And Check(2) = 150 Then
                Result = aa - bb / cc
            ElseIf Check(0) = 55 And Check(1) = 150 Then
                Result = aa + bb / cc
            End If
        End If

        ' Dealing with four added numbers:

        If Check(0) = 50 Or Check(1) = 150 And Check(2) = 55 Then
            If Check(0) = 150 And Check(1) = 150 And Check(2) = 55 Then
                Result = aa / bb / cc + dd
            ElseIf Check(0) = 55 And Check(1) = 150 And Check(2) = 55 Then
                Result = aa + bb / cc + dd
            ElseIf Check(0) = 50 And Check(1) = 150 And Check(2) = 55 Then
                Result = aa - bb / cc + dd
            ElseIf Check(0) = 100 And Check(1) = 150 And Check(2) = 55 Then
                Result = aa * bb / cc + dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 100 And Check(2) = 55 Then
            If Check(0) = 150 And Check(1) = 100 And Check(2) = 55 Then
                Result = aa / bb * cc + dd
            ElseIf Check(0) = 55 And Check(1) = 100 And Check(2) = 55 Then
                Result = aa + bb * cc + dd
            ElseIf Check(0) = 50 And Check(1) = 100 And Check(2) = 55 Then
                Result = aa - bb * cc + dd
            ElseIf Check(0) = 100 And Check(1) = 100 And Check(2) = 55 Then
                Result = aa * bb * cc + dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 55 And Check(2) = 55 Then
            If Check(0) = 150 And Check(1) = 55 And Check(2) = 55 Then
                Result = aa / bb + cc + dd
            ElseIf Check(0) = 55 And Check(1) = 55 And Check(2) = 55 Then
                Result = aa + bb + cc + dd
            ElseIf Check(0) = 50 And Check(1) = 55 And Check(2) = 55 Then
                Result = aa - bb + cc + dd
            ElseIf Check(0) = 100 And Check(1) = 55 And Check(2) = 55 Then
                Result = aa * bb + cc + dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 50 And Check(2) = 55 Then
            If Check(0) = 150 And Check(1) = 50 And Check(2) = 55 Then
                Result = aa / bb - cc + dd
            ElseIf Check(0) = 55 And Check(1) = 50 And Check(2) = 55 Then
                Result = aa + bb - cc + dd
            ElseIf Check(0) = 50 And Check(1) = 50 And Check(2) = 55 Then
                Result = aa - bb - cc + dd
            ElseIf Check(0) = 100 And Check(1) = 50 And Check(2) = 55 Then
                Result = aa * bb - cc + dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 150 And (2) = 50 Then
            If Check(0) = 150 And Check(1) = 150 And Check(2) = 50 Then
                Result = aa / bb / cc - dd
            ElseIf Check(0) = 55 And Check(1) = 150 And Check(2) = 50 Then
                Result = aa + bb / cc - dd
            ElseIf Check(0) = 50 And Check(1) = 150 And Check(2) = 50 Then
                Result = aa - bb / cc - dd
            ElseIf Check(0) = 100 And Check(1) = 150 And Check(2) = 50 Then
                Result = aa * bb / cc - dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 100 And Check(2) = 50 Then
            If Check(0) = 150 And Check(1) = 100 And Check(2) = 50 Then
                Result = aa / bb * cc - dd
            ElseIf Check(0) = 55 And Check(1) = 100 And Check(2) = 50 Then
                Result = aa + bb * cc - dd
            ElseIf Check(0) = 50 And Check(1) = 100 And Check(2) = 50 Then
                Result = aa - bb * cc - dd
            ElseIf Check(0) = 100 And Check(1) = 100 And Check(2) = 50 Then
                Result = aa * bb * cc - dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 55 And Check(2) - 50 Then
            If Check(0) = 150 And Check(1) = 55 And Check(2) = 50 Then
                Result = aa / bb + cc - dd
            ElseIf Check(0) = 55 And Check(1) = 55 And Check(2) = 50 Then
                Result = aa + bb + cc - dd
            ElseIf Check(0) = 50 And Check(1) = 55 And Check(2) = 50 Then
                Result = aa - bb + cc - dd
            ElseIf Check(0) = 100 And Check(1) = 55 And Check(2) = 50 Then
                Result = aa * bb + cc - dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 50 And Check(2) = 50 Then
            If Check(0) = 150 And Check(1) = 50 And Check(2) = 50 Then
                Result = aa / bb - cc - dd
            ElseIf Check(0) = 55 And Check(1) = 50 And Check(2) = 50 Then
                Result = aa + bb - cc - dd
            ElseIf Check(0) = 50 And Check(1) = 50 And Check(2) = 50 Then
                Result = aa - bb - cc - dd
            ElseIf Check(0) = 100 And Check(1) = 50 And Check(2) = 50 Then
                Result = aa * bb - cc - dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 150 And Check(2) = 100 Then
            If Check(0) = 150 And Check(1) = 150 And Check(2) = 100 Then
                Result = aa / bb / cc * dd
            ElseIf Check(0) = 55 And Check(1) = 150 And Check(2) = 100 Then
                Result = aa + bb / cc * dd
            ElseIf Check(0) = 50 And Check(1) = 150 And Check(2) = 100 Then
                Result = aa - bb / cc * dd
            ElseIf Check(0) = 100 And Check(1) = 150 And Check(2) = 100 Then
                Result = aa * bb / cc * dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 100 And Check(2) = 100 Then
            If Check(0) = 150 And Check(1) = 100 And Check(2) = 100 Then
                Result = aa / bb * cc * dd
            ElseIf Check(0) = 55 And Check(1) = 100 And Check(2) = 100 Then
                Result = aa + bb * cc * dd
            ElseIf Check(0) = 50 And Check(1) = 100 And Check(2) = 100 Then
                Result = aa - bb * cc * dd
            ElseIf Check(0) = 100 And Check(1) = 100 And Check(2) = 100 Then
                Result = aa * bb * cc * dd
            End If
        ElseIf Check(0) = 50 Or (Check(1) = 55 And Check(2) = 100) Then
            If Check(0) = 150 And Check(1) = 55 And Check(2) = 100 Then
                Result = aa / bb + cc * dd
            ElseIf Check(0) = 55 And Check(1) = 55 And Check(2) = 100 Then
                Result = aa + bb + cc * dd
            ElseIf Check(0) = 50 And Check(1) = 55 And Check(2) = 100 Then
                Result = aa - bb + cc * dd
            ElseIf Check(0) = 100 And Check(1) = 55 And Check(2) = 100 Then
                Result = aa * bb + cc * dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 50 And Check(2) - 100 Then
            If Check(0) = 150 And Check(1) = 50 And Check(2) = 100 Then
                Result = aa / bb - cc * dd
            ElseIf Check(0) = 55 And Check(1) = 50 And Check(2) = 100 Then
                Result = aa + bb - cc * dd
            ElseIf Check(0) = 50 And Check(1) = 50 And Check(2) = 100 Then
                Result = aa - bb - cc * dd
            ElseIf Check(0) = 100 And Check(1) = 50 And Check(2) = 100 Then
                Result = aa * bb - cc * dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 150 And Check(2) = 150 Then
            If Check(0) = 150 And Check(1) = 150 And Check(2) = 150 Then
                Result = aa / bb / cc / dd
            ElseIf Check(0) = 55 And Check(1) = 150 And Check(2) = 150 Then
                Result = aa + bb / cc / dd
            ElseIf Check(0) = 50 And Check(1) = 150 And Check(2) = 150 Then
                Result = aa - bb / cc / dd
            ElseIf Check(0) = 100 And Check(1) = 150 And Check(2) = 150 Then
                Result = aa * bb / cc / dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 100 And Check(2) = 150 Then
            If Check(0) = 150 And Check(1) = 100 And Check(2) = 150 Then
                Result = aa / bb * cc / dd
            ElseIf Check(0) = 55 And Check(1) = 100 And Check(2) = 150 Then
                Result = aa + bb * cc / dd
            ElseIf Check(0) = 50 And Check(1) = 100 And Check(2) = 150 Then
                Result = aa - bb * cc / dd
            ElseIf Check(0) = 100 And Check(1) = 100 And Check(2) = 150 Then
                Result = aa * bb * cc / dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 55 And Check(2) = 150 Then
            If Check(0) = 150 And Check(1) = 55 And Check(2) = 150 Then
                Result = aa / bb + cc / dd
            ElseIf Check(0) = 55 And Check(1) = 55 And Check(2) = 150 Then
                Result = aa + bb + cc / dd
            ElseIf Check(0) = 50 And Check(1) = 55 And Check(2) = 150 Then
                Result = aa - bb + cc / dd
            ElseIf Check(0) = 100 And Check(1) = 55 And Check(2) = 150 Then
                Result = aa * bb + cc / dd
            End If
        ElseIf Check(0) = 50 Or Check(1) = 50 And Check(2) = 150 Then
            If Check(0) = 150 And Check(1) = 50 And Check(2) = 150 Then
                Result = aa / bb - cc / dd
            ElseIf Check(0) = 55 And Check(1) = 50 And Check(2) = 150 Then
                Result = aa + bb - cc / dd
            ElseIf Check(0) = 50 And Check(1) = 50 And Check(2) = 150 Then
                Result = aa - bb - cc / dd
            ElseIf Check(0) = 100 And Check(1) = 50 And Check(2) = 150 Then
                Result = aa * bb - cc / dd
            End If
        End If
        MsgBox(Check(0) & ", " & Check(1) & ", " & Check(2))
        txtEqual.Text = Result
    End Sub

    Private Sub lblAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer.Click
        Str = Result
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Plus = ""
        Plus1 = ""
        Plus2 = ""
        txtNumbers.Text = Str
        txtEqual.Text = 0
        Array.Clear(Check, Check.GetLowerBound(0), Check.Length)
        Count = 0
        lblMult.Enabled = True
        lblDiv.Enabled = True
        lblPlus.Enabled = True
        lblMinus.Enabled = True
    End Sub
End Class

Public Class Form1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim Year, DaysJ, DaysF, A, B As Integer
        Dim YearA, YearB, YearC, Leap As Boolean
        Dim Months As String
        Year = CInt(txtYear.Text)
        YearA = (Year Mod 4 = 0)
        YearB = (Year Mod 100 <> 0)
        YearC = ((Year Mod 100 = 0) And (Year Mod 400 = 0))
        Leap = (YearA And (YearB Or YearC))
        btnClear.Visible = True
        If Leap = True Then
            With lstOutput.Items
                .Add("This year is " & Year & vbNewLine)
                .Add("It is leap year.")
                .Add("")
            End With
        Else
            With lstOutput.Items
                .Add("This year is " & Year)
                .Add("It is not leap year.")
                .Add(" ")
            End With
        End If

        For A = 1 To 1
            Months = "January"
            For DaysJ = 1 To 31
                lstOutput.Items.Add(DaysJ & "  " & Months)
            Next DaysJ
        Next A
        If Leap = True Then
            For B = 1 To 1
                Months = "February"
                For DaysF = 1 To 29
                    lstOutput.Items.Add(DaysF & "  " & Months)
                Next DaysF
            Next B
        Else
            For B = 1 To 1
                Months = "February"
                For DaysF = 1 To 28
                    lstOutput.Items.Add(DaysF & "  " & Months)
                Next DaysF
            Next B
        End If
        For B = 1 To 1
            Months = "March"
            For DaysF = 1 To 31
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "April"
            For DaysF = 1 To 30
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "May"
            For DaysF = 1 To 30
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "June"
            For DaysF = 1 To 30
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "July"
            For DaysF = 1 To 31
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "August"
            For DaysF = 1 To 30
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "September"
            For DaysF = 1 To 31
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "October"
            For DaysF = 1 To 31
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "November"
            For DaysF = 1 To 30
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
        For B = 1 To 1
            Months = "December"
            For DaysF = 1 To 31
                lstOutput.Items.Add(DaysF & "  " & Months)
            Next DaysF
        Next B
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
        txtYear.Clear()
        txtYear.Focus()
        btnClear.Visible = False
        btnShow.Enabled = False
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
        btnShow.Enabled = True
    End Sub
End Class

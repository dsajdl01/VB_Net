Public Class Form1
    Dim Filename As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filename = "Sales.txt"
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Name, Region As String
        Dim Amount As Short
        Dim Character As Char
        Dim Count, i As Short
        Dim Find As Boolean
        If txtName.Text = String.Empty Then
            MsgBox("The text box of the name is empty! Please add name.", , "Sale warning message")
            txtName.Focus()
            Exit Sub
        Else
            Name = txtName.Text
            Character = Name.Substring(0, 1)
            If Character = " " Then
                MsgBox("First character in name box is empty space. Please remove empty space.", , "Sale warning message")
                txtName.Focus()
                Exit Sub
            End If
            Count = 0
            For i = 0 To Name.Length - 1
                Character = Name.Substring(i)
                If Character = " " Then
                    Count = Count + 1
                End If
            Next i
            If Count >= 2 Then
                MsgBox("In name box are too many spaces! Add name and surname only with one space!" & vbNewLine & "David Smith", , "Sale Warning message")
                txtName.Focus()
                Exit Sub
            End If
        End If
        If cmbRegion.Text = String.Empty Then
            MsgBox("The combo box of the region is empty! Please select region.", , "Sale warning message")
            cmbRegion.Focus()
            Exit Sub
        Else
            Region = cmbRegion.Text
            Character = Region.Substring(0, 1)
            If Character = " " Then
                MsgBox("First character in region box is empty space. Please remove empty space.", , "Sale warning message")
                cmbRegion.Focus()
                Exit Sub
            End If
            Find = False
            For i = 0 To Region.Length - 1
                Character = Region.Substring(i)
                If Character = " " Then
                    Find = True
                End If
            Next i
            If Find = True Then
                MsgBox("In region combobox is appear spaces! Add only region without space!" & vbNewLine & "Eg:    North or SouthWest ", , "Sale Warning message")
                cmbRegion.Focus()
                Exit Sub
            End If
        End If
        If txtAmount.Text = String.Empty Then
            MsgBox("The text box of the amount is empty! Please add weekly amount of the person.", , "Sale warning message")
            txtAmount.Focus()
            Exit Sub
        Else
            Try
                Amount = txtAmount.Text
            Catch When Err.Number = 6
                MsgBox("Amount is out of the renge", , "Sale warning message")
                txtAmount.Focus()
                Exit Sub
            Catch When Err.Number = 13
                MsgBox("Amunt cannot contain character or signs", , "Sale warning message")
                txtAmount.Focus()
                Exit Sub
            End Try
        End If
        txtName.Clear()
        txtName.Focus()
        txtAmount.Clear()
        cmbRegion.Text = "North"
        FileOpen(1, Filename, OpenMode.Append)
        PrintLine(1, Name, Region, Amount)
        FileClose(1)
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Static Display As String
        FileOpen(1, Filename, OpenMode.Input)
        lstListOfSale.Items.Clear()
        Do While Not EOF(1)
            Input(1, Display)
            lstListOfSale.Items.Add(Display)
        Loop
        FileClose(1)
    End Sub

    Private Sub btnSalespersonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalespersonPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MyFont As New Font("Courier New", 12, FontStyle.Regular)
        Dim MyFontII As New Font("Courier New", 16, FontStyle.Bold)
        Dim MyFormat As String = "{0, -20}{1,-10}{2, -12}"
        Static Name, Region, LineToPrint, AmountStr, word, Line As String
        Dim x, y, Amount, FontHeight, Count As Integer
        Dim Character As Char
        x = 50
        y = 50
        FontHeight = MyFont.GetHeight(e.Graphics)
        e.Graphics.DrawString("Report on annual sales made by sales staff", MyFontII, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        LineToPrint = String.Format(MyFormat, "Saleperson", "Region", "Amount")
        e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        FileOpen(1, Filename, OpenMode.Input)
        Do While Not EOF(1)
            Input(1, Name)
            y = y + FontHeight
            Dim words As String() = Name.Split(New Char() {" "c})
            Line = ""
            For Each word In words
                If word = String.Empty Then

                Else
                    Line = Line & word & " "
                End If
            Next
            Count = 0
            Name = ""
            Region = ""
            AmountStr = ""
            For i As Short = 0 To Line.Length - 1
                Character = Line.Substring(i)
                If Character = " " Then
                    Count = Count + 1
                End If
                If Count <= 1 Then
                    Name = Name & Character
                ElseIf Count <= 2 Then
                    Region = Region & Character
                Else
                    AmountStr = AmountStr & Character
                End If
            Next i
            Amount = CInt(AmountStr)
            LineToPrint = String.Format(MyFormat, Name, Region, Format(Amount * 1000, "£#,##0"))
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
        Loop
        FileClose(1)
    End Sub

    Private Sub btnSalepersonPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalepersonPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnRegionPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegionPreview.Click
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim MyFont As New Font("Arial", 12, FontStyle.Regular)
        Dim MyTitleFont As New Font("Arial", 15, FontStyle.Bold Or FontStyle.Underline)
        Static Name, Region, RegionGroup, AmountStr, word, Line, DrowLine As String
        Dim x, y, r, RegionNumber, Amount, FontHeight, Count, Total As Integer
        Dim Character As Char
        Dim Find As Boolean = False
        x = 140
        y = 50
        FontHeight = MyFont.GetHeight(e.Graphics)
        e.Graphics.DrawString("Report on annual sale made by sales staff", MyTitleFont, Brushes.Black, x, y)
        x = 50
        y = y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        For RegionNumber = 1 To 5
            Select Case RegionNumber
                Case 1
                    RegionGroup = " East"
                Case 2
                    RegionGroup = " North"
                Case 3
                    RegionGroup = " South"
                Case 4
                    RegionGroup = " West"
                Case 5
                    RegionGroup = " NorthWest"
            End Select
            FileOpen(1, Filename, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, Name)
                Dim words As String() = Name.Split(New Char() {" "c})
                Line = ""
                For Each word In words
                    If word = String.Empty Then

                    Else
                        Line = Line & word & " "
                    End If
                Next
                Count = 0
                Name = ""
                Region = ""
                AmountStr = ""
                For i As Short = 0 To Line.Length - 1
                    Character = Line.Substring(i)
                    If Character = " " Then
                        Count = Count + 1
                    End If
                    If Count <= 1 Then
                        Name = Name & Character
                    ElseIf Count <= 2 Then
                        Region = Region & Character
                    End If
                Next i
                If Region = RegionGroup Then
                    e.Graphics.DrawString(RegionGroup, MyFont, Brushes.Black, x, y)
                    y = y + FontHeight
                    Exit Do
                End If
            Loop
            Do While Not EOF(1)
                Input(1, Name)
                'y = y + FontHeight
                Dim words As String() = Name.Split(New Char() {" "c})
                Line = ""
                For Each word In words
                    If word = String.Empty Then

                    Else
                        Line = Line & word & " "
                    End If
                Next
                Count = 0
                Name = ""
                Region = ""
                AmountStr = ""
                For i As Short = 0 To Line.Length - 1
                    Character = Line.Substring(i)
                    If Character = " " Then
                        Count = Count + 1
                    End If
                    If Count <= 1 Then
                        Name = Name & Character
                    ElseIf Count <= 2 Then
                        Region = Region & Character
                    Else
                        AmountStr = AmountStr & Character
                    End If
                Next i
                Amount = CInt(AmountStr)
                If Region = RegionGroup Then
                    x = 150
                    Total = Total + Amount
                    Find = True
                    e.Graphics.DrawString(Name, MyFont, Brushes.Black, x, y)
                    x = x + 360
                    e.Graphics.DrawString(Format(Amount * 1000, "£#,##0"), MyFont, Brushes.Black, x, y)
                    y = y + FontHeight
                End If
            Loop
            If Find = True Then
                DrowLine = ""
                For z As Short = 0 To 45
                    DrowLine = DrowLine & "_"
                Next
                x = 150
                y = y - 15
                e.Graphics.DrawString(DrowLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight
                e.Graphics.DrawString("Total sales for" & RegionGroup & " region", MyFont, Brushes.Black, x, y)
                If Total <= 999 Then
                    r = 0
                Else
                    r = 14
                End If
                x = x + 360 - r
                'y = y - 15
                'e.Graphics.DrawString(DrowLine, MyFont, Brushes.Black, x, y)
                'y = y + FontHeight
                e.Graphics.DrawString(Format(Total * 1000, "£#,##0"), MyFont, Brushes.Black, x, y)
                y = y + FontHeight
            End If
            Find = False
            FileClose(1)
            Total = 0
            x = 50
            y = y + FontHeight
        Next RegionNumber
    End Sub

    Private Sub btnRegionPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegionPrint.Click
        PrintDocument2.Print()
    End Sub
End Class

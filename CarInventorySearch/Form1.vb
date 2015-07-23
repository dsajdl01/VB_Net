Public Class Form1
    Dim Filename, FileForPassword As String
    Dim NumberOfCars As Short
    Dim MyCarFormat As String = "{0, -13}{1, -8}{2, -11}{3, -9}{4, -10}"

    Structure CarType
        <VBFixedString(8)> Dim RegNumber As String
        <VBFixedString(20)> Dim Made As String
        <VBFixedString(26)> Dim Model As String
        Dim Year As Short
        Dim Price As Decimal
    End Structure
    Dim OneCar As CarType

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyHead As String = "{0, -19}{1, -40}{2, -53}{3, -17}{4, -10}"
        Filename = "Cars.dat"
        FileForPassword = "Data.txt"
        'Dim RegNumberStr As String
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        NumberOfCars = LOF(1) / Len(OneCar)
        lblNumber.Text = NumberOfCars
        FileClose(1)
        lstHead.BackColor = Color.LightBlue
        lstHead.Items.Add(String.Format(MyHead, "Reg.Number", "| Make", "| Model", "| Year", "| Price"))

        Dim y As Integer
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        For y = 1 To NumberOfCars
            FileGet(1, OneCar)
            comSearchRegNum.Items.Add(OneCar.RegNumber)
        Next y
        FileClose(1)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim CheckCar As String
        Static Message As String
        Dim x As Short = 0
        Dim Space As Short = 0
        Static OneCar As CarType
        Dim Character As Char
        If txtRegNumber.Text = String.Empty Then
            MsgBox("The text box for registration number is empty, please enter the registration munber")
            txtRegNumber.Focus()
            Exit Sub
        Else
            CheckCar = txtRegNumber.Text
            Character = CheckCar.Substring(0, 1)
            If Character = " " Then
                MsgBox("First value in registration number is empty! It must start with any character or number", , "Add car error message")
                txtRegNumber.Focus()
                Exit Sub
            End If
            For Index As Short = 0 To CheckCar.Length - 1
                Character = CheckCar.Substring(Index)
                If Character = " " Then
                    Space += 1
                End If
                If CheckCar.Length = 9 And Space = 2 Then
                    Message = "  There are 7 characters, but too many spaces! There are 2 spaces." & vbNewLine
                    Message = Message & "                                Reduce one space, please "
                ElseIf CheckCar.Length = 8 And Space > 1 Then
                    Message = "There are 7 characters but too many spaces! There are " & Space & " spaces." & vbNewLine
                    Message = Message & "                                Reduce one space, please "
                ElseIf CheckCar.Length = 8 Then
                    If Space = 0 Then
                        Message = "            There are too many characters! It must be included one space."
                    Else
                        Message = "                     There are too many spaces! There are " & Space
                    End If
                ElseIf CheckCar.Length = 7 Then
                    Message = "                       There are 7 Characters but the space is missing"
                ElseIf CheckCar.Length < 7 Then
                    Message = "                         There are not enough characrers! Must be 7"
                Else
                    Message = "                     There are to many characters Must be only 7"
                End If
            Next
            If CheckCar.Length = 8 And Space = 1 Then
                FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
                Do While (Not EOF(1))
                    FileGet(1, OneCar)
                    If OneCar.RegNumber = CheckCar Then
                        x = 1
                    End If
                Loop
                FileClose(1)
                If x = 0 Then
                    OneCar.RegNumber = txtRegNumber.Text
                Else
                    MsgBox("Registration number " & CheckCar & " had already existed! ")
                    Exit Sub
                End If
            Else
                MsgBox("                           The register number is incorrect " & vbNewLine & "  Reg.number must have exactly 7 characret and one space only" & vbNewLine & vbNewLine & Message, , "Car list warning message")
                Exit Sub
            End If
        End If

        If cmbMake.Text = String.Empty Then
            MsgBox("Combo box of make car had not been selected, please select combo box")
            cmbMake.Focus()
            Exit Sub
        Else
            OneCar.Made = cmbMake.Text
            Character = OneCar.Made.Substring(0, 1)
            If Character = " " Then
                MsgBox("First value in make car text box is empty! It must start with any character or number", , "Car error message")
                cmbMake.Focus()
                Exit Sub
            End If
        End If
        If txtModel.Text = String.Empty Then
            MsgBox("The text box of the model cat had not been filled in, please enter model into text box.")
            txtModel.Focus()
            Exit Sub
        Else
            OneCar.Model = txtModel.Text
            Character = OneCar.Model.Substring(0, 1)
            If Character = " " Then
                MsgBox("First value in model text box is empty! It must start with any character or number", , "Car error message")
                txtModel.Focus()
                Exit Sub
            End If
        End If
        If cmbYear.Text = String.Empty Then
            MsgBox("Combo box, car production (year) had not been selected, please select year into combo box")
            cmbYear.Focus()
            Exit Sub
        Else
            OneCar.Year = cmbYear.Text
        End If
        If txtPrice.Text = String.Empty Then
            MsgBox("The text box, the price of the car had not been filled in, please enter the price of the car into text box")
            txtPrice.Focus()
            Exit Sub
        Else
            Try
                OneCar.Price = CDec(txtPrice.Text)
            Catch
                MsgBox("It is incorrect number! It may contain character or wrong decimal number", , "Price rent car warning message")
                txtPrice.Focus()
                Exit Sub
            End Try
        End If
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        FilePut(1, OneCar, NumberOfCars + 1)
        FileClose(1)
        NumberOfCars += 1
        lblNumber.Text = NumberOfCars
        txtRegNumber.Clear()
        txtRegNumber.Focus()
        cmbMake.Text = "Audi"
        txtModel.Clear()
        cmbYear.Text = 2012
        txtPrice.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim y As Integer
        lstListCar.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        For y = 1 To NumberOfCars
            FileGet(1, OneCar)
            lstListCar.Items.Add(String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
        Next y
        FileClose(1)
        lblNumber.Text = NumberOfCars
    End Sub

    Private Sub btnDisplayRegNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRegNumber.Click
        Dim SearchRegNum As String
        Dim x As String
        If comSearchRegNum.Text = String.Empty Then
            MsgBox("Combo box is empty. Please wtitte Register number that you wish to search", , "Car sale search message")
            Exit Sub
        Else
            SearchRegNum = comSearchRegNum.Text
        End If
        x = 0
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        Do While (Not EOF(1))
            FileGet(1, OneCar)
            If OneCar.RegNumber = SearchRegNum Then
                lstListCar.Items.Clear()
                lstListCar.Items.Add(String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                x = 1
            End If
        Loop
        FileClose(1)
        lblNumber.Text = x
        If x = 0 Then
            MsgBox("Register number do not exist in our database. Please check register number if is correct", , "Car sele search message")
        End If
    End Sub

    Private Sub btnDisplayModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayModel.Click
        Static SearchModel As String
        Dim Made As String
        Dim Find As Boolean = False
        Static Count As Short
        If CmbSearchModel.Text = String.Empty Then
            MsgBox("Combo box is empty. Please select or write model that you wish to search.", , "Car sale search message")
            Exit Sub
        Else
            SearchModel = CmbSearchModel.Text
            Made = CmbSearchModel.Text
        End If
        Count = 0
        Do
            SearchModel = SearchModel & " "
        Loop Until SearchModel.Length = 20
        lstListCar.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        Do While (Not EOF(1))
            FileGet(1, OneCar)
            If OneCar.Made = SearchModel Then
                lstListCar.Items.Add(String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                Find = True
                Count += 1
            End If
        Loop
        FileClose(1)
        lblNumber.Text = Count
        If Find = False Then
            MsgBox("There is not any car make by " & Made & " in our database")
        End If
    End Sub

    Private Sub btnDisplayYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayYear.Click
        Static SearchYear As Short
        Dim Find As Boolean = False
        Static Count As Short
        If txtSearchYear.Text = String.Empty Then
            MsgBox("Text box is empty. Please entry the year")
            txtSearchYear.Focus()
            Exit Sub
        Else
            Try
                SearchYear = txtSearchYear.Text
            Catch When Err.Number = 6
                MsgBox("The year is out of renge")
                txtSearchYear.Focus()
                Exit Sub
            Catch When Err.Number = 13
                MsgBox("The year contein character or .,/ or similar signs", , "Car error message")
                txtSearchYear.Focus()
                Exit Sub
            End Try
        End If
        Count = 0
        lstListCar.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        Do While (Not EOF(1))
            FileGet(1, OneCar)
            If OneCar.Year = SearchYear Then
                lstListCar.Items.Add(String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                Find = True
                Count += 1
            End If
        Loop
        FileClose(1)
        lblNumber.Text = Count
        If Find = False Then
            MsgBox("There is not any car with year " & SearchYear, , "Car sale search message.")
        End If
    End Sub

    Private Sub btnDisplayPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Static Min, Max As Integer
        Dim Find As Boolean = False
        Static Count As Short
        If txtMinValue.Text = String.Empty Then
            MsgBox("The text box is empty. Please enter value into text box")
            txtMinValue.Focus()
            Exit Sub
        ElseIf txtMaxValue.Text = String.Empty Then
            MsgBox("The text box is empty. Please enter value into text box")
            txtMaxValue.Focus()
            Exit Sub
        Else
            Try
                Max = txtMaxValue.Text
                Min = txtMinValue.Text
                If Max < Min Then
                    MsgBox("Your maximum price is smaller then minumum" & vbNewLine & "Please input prices other way round", , "Car error message")
                    txtMaxValue.Focus()
                    Exit Sub
                End If
            Catch When Err.Number = 6
                MsgBox("One or both enter prices are out of the range", , "Car error message")
                txtMaxValue.Focus()
                Exit Sub
            Catch When Err.Number = 13
                MsgBox("One or both enter prices are contain characters or , . / any different signs", , "Car error message")
                txtMaxValue.Focus()
                Exit Sub
            End Try
        End If
        Count = 0
        lstListCar.Items.Clear()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        Do While (Not EOF(1))
            FileGet(1, OneCar)
            If OneCar.Price <= Max And OneCar.Price >= Min Then
                lstListCar.Items.Add(String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                Find = True
                Count = Count + 1
            End If
        Loop
        FileClose(1)
        lblNumber.Text = Count
        If Find = False Then
            MsgBox("There is not any price of car that cost between " & Min & " and " & Max, , "Car sale search message.")
        End If
    End Sub

    Private Sub btnChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChanges.Click
        Static RegNumber As String
        Dim Character As Char
        Dim Count, NumberOfRecord As Short
        Dim SelectItems As String
        Dim SecondForm As New MakeChanges
        Dim ThirdForm As New PasswordForm

        If lstListCar.SelectedItem = String.Empty Then
            MsgBox("The item has not been selected. Please select item", , "Car error message")
            Exit Sub
        End If
        Static Password, InputPassword As String
        Dim Attempt As Integer
        Attempt = 0
        FileOpen(2, FileForPassword, OpenMode.Input)
        Do While Not EOF(2)
            Password = LineInput(2)
        Loop
        FileClose(2)
        Do
            Attempt += 1
            InputPassword = InputBox("Enter password. You have three attempt." & vbNewLine & " This is attempt number " & Attempt)
        Loop Until (Attempt = 3) Or (InputPassword = Password)
        If InputPassword = Password Then
            Dim Result As DialogResult
            Result = MessageBox.Show(Me, "This password is correct" & vbNewLine & vbNewLine & "Do you want to change password? then press yes " & vbNewLine & " or do you want to make changes on the selected car then press no", "Sale Car password message", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                SelectItems = lstListCar.SelectedItem
                Count = 0
                NumberOfRecord = 0
                RegNumber = ""
                For i As Short = 0 To SelectItems.Length
                    Character = SelectItems.Substring(i)
                    If Character = " " Then
                        Count += 1
                    End If
                    If Count < 2 Then
                        RegNumber = RegNumber & Character
                    End If
                Next
                ThirdForm.lblRegNumber.Text = RegNumber
                ThirdForm.Show()
                Exit Sub
            End If
        Else
            MsgBox("This Password is invalid")
            Exit Sub
        End If
        SelectItems = lstListCar.SelectedItem
        Count = 0
        NumberOfRecord = 0
        RegNumber = ""
        For i As Short = 0 To SelectItems.Length
            Character = SelectItems.Substring(i)
            If Character = " " Then
                Count += 1
            End If
            If Count < 2 Then
                RegNumber = RegNumber & Character
            End If
        Next
        SecondForm.Show()
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        Do While (Not EOF(1))
            FileGet(1, OneCar)
            NumberOfRecord = NumberOfRecord + 1
            If OneCar.RegNumber = RegNumber Then
                SecondForm.Show()
                SecondForm.lblAddRegNum.Text = OneCar.RegNumber
                SecondForm.txtAddMade.Text = OneCar.Made
                SecondForm.txtAddModel.Text = OneCar.Model
                SecondForm.txtAddPrice.Text = OneCar.Price
                SecondForm.txtAddYear.Text = OneCar.Year
                SecondForm.lblRecord.Text = NumberOfRecord
            End If
        Loop
        FileClose(1)
    End Sub

    Private Sub btnPrints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrints.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HeadMyFont As New Font("Courier New", 16, FontStyle.Bold Or FontStyle.Underline)
        Dim MyFont As New Font("Courier New", 12, FontStyle.Regular)
        Dim MyFontB As New Font("Courier New", 12, FontStyle.Bold Or FontStyle.Underline)
        Dim MyCarPrintFormat As String = "{0, -10}{1, -8}{2, -8}{3, -7}{4, -9}"
        Dim MyFootPrintFormat As String = "{0, -62}{1, -17}"
        Dim MyCarHeadPrintFormat As String = "{0, -10}{1, -20}{2, -26}{3, -7}{4, -12}{5,-1}"
        Dim x, y, FontHeight As Integer
        Static NumOfPage, Count As Integer
        Dim PrintLine As String
        Static Total As Double
        Dim Result As Boolean = False ' deal with page numbers
        x = 150
        y = 50
        Count = 0
        ' Header of the page
        FontHeight = MyFont.GetHeight(e.Graphics)
        e.Graphics.DrawString("Report of all sale cars in our store", HeadMyFont, Brushes.Black, x, y)
        y = y + FontHeight ' Print head line on each line where x is 150 and y is 69 it starts far left on top
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        x = 20 ' return x value to 20 
        y = y + FontHeight
        PrintLine = String.Format(MyCarHeadPrintFormat, "Reg.Num.", "Made", "Model", "Year", "Price", "_")
        e.Graphics.DrawString(PrintLine, MyFontB, Brushes.Black, x, y)
        y = y + FontHeight + 5 ' print header file on each page and increase y value
        Total = 0 ' initilase variable total to zero
        ' Main body of the page
        Select Case NumOfPage
            Case 0  ' if page number is 0 then deal with case 0
                FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
                For z As Short = 1 To NumberOfCars ' fot loop read through file from beginning to end
                    FileGet(1, OneCar)
                    Count = Count + 1  'count is increase by one 
                    If Count <= 50 Then ' if statment deal with records from 0 to 50
                        Total = Total + OneCar.Price ' count price
                        PrintLine = (String.Format(MyCarPrintFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                        e.Graphics.DrawString(PrintLine, MyFont, Brushes.Black, x, y) ' print records
                        y = y + FontHeight
                        If Count = NumberOfCars Then ' if statment deal if the last recort is identical to count number then enter if statment
                            e.HasMorePages = False ' no more pages to be print
                            FileClose(1) ' close file
                            Result = True ' change value result for true
                            Exit Select ' leave select case
                        End If
                    End If
                Next z
                e.HasMorePages = True ' to be more pages printing
                FileClose(1) ' close file,
            Case 1      'if page number is 0 then deal with case 0
                FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
                For z As Short = 1 To NumberOfCars
                    FileGet(1, OneCar)
                    Count = Count + 1
                    If Count >= 50 And Count <= 100 Then ' if statment deal with record from 50 to 100
                        Total = Total + OneCar.Price ' count total value of car price from 50 to 100 only
                        'PrintLine = (String.Format(MyCarFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                        PrintLine = (String.Format(MyCarPrintFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                        e.Graphics.DrawString(PrintLine, MyFont, Brushes.Black, x, y) ' print each record from 50 to 100
                        y = y + FontHeight ' increat y value
                        If Count = NumberOfCars Then       'if statment deal if the last recort is identical to count number then enter if statment
                            e.HasMorePages = False ' no more pages to be printed
                            FileClose(1) ' close file
                            Result = True ' change result value for true
                            Exit Select 'leave select case
                        End If
                    End If
                Next z
                e.HasMorePages = True ' more pages to be print
                FileClose(1) ' close file
            Case 2      'if page number is 0 then deal with case 0
                FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar)) ' open file
                For z As Short = 1 To NumberOfCars ' read through file from 0 to end of the file
                    FileGet(1, OneCar) ' get each record
                    Count = Count + 1 'increase value by one
                    If Count >= 100 Then ' if statment deal with record 100 and more
                        Total = Total + OneCar.Price 'count Value of record that are greater than 100 
                        PrintLine = (String.Format(MyCarPrintFormat, OneCar.RegNumber, OneCar.Made, OneCar.Model, OneCar.Year, Format(OneCar.Price, "Currency")))
                        e.Graphics.DrawString(PrintLine, MyFont, Brushes.Black, x, y) ' print records
                        y = y + FontHeight ' increase y value
                        If Count = NumberOfCars Then    'if statment deal if the last recort is identical to count number then enter if statment
                            e.HasMorePages = False ' no more pages to be print
                            FileClose(1) ' close file
                            Result = True ' give result true value
                            Exit Select ' leave select case
                        End If
                    End If
                Next z
                e.HasMorePages = False ' no more pages to be print but if thee are_
                'more record that 150 then another "select case 3" need to be created 
                FileClose(1) ' close file
        End Select ' end of select case
        PrintLine = ""  'initilise variable PrintLine to empty space
        For xx As Short = 0 To 55
            PrintLine = PrintLine & "_" ' give line to PrintLive variable
        Next xx
        y = y - 20
        'Footer of the page
        e.Graphics.DrawString(PrintLine, HeadMyFont, Brushes.Black, x, y) 'print Printline value
        y = y + FontHeight + 10
        PrintLine = (String.Format(MyFootPrintFormat, "Total value of the cars:", Format(Total, "Currency")))
        e.Graphics.DrawString(PrintLine, MyFont, Brushes.Black, x, y) ' print value of the cars
        NumOfPage = NumOfPage + 1 'increase page number 
        y = 1130
        x = 780
        e.Graphics.DrawString(NumOfPage, MyFont, Brushes.Black, x, y) 'Print page number 
        If Result = True Then ' If statment if the result is tru then page number gets value zero
            NumOfPage = 0
            Result = False ' give value of result to false
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class

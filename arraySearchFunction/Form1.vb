Public Class Form1
    Dim Numbers(4) As Integer        ' declare array variable as global variable
    Dim CurrentIndex As Integer = -1    ' current use subcript of the array

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim AddingNumber As Integer
        AddingNumber = txtNumber.Text
        If CurrentIndex = 4 Then        'if array is full show message(has 5 num. in it)
            MsgBox("The Array is FULL!")
            btnAdd.Enabled = False
            txtNumber.Enabled = False
        Else                            ' array is not full
            CurrentIndex += 1           ' move to next free subscript in array
            Numbers(CurrentIndex) = AddingNumber     ' store number in it
            txtNumber.Clear()   ' clear tex box for next number
            txtNumber.Focus()   ' and place cursor in it
            btnClear.Visible = True
        End If
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim Index As Integer
        lstNumber.Items.Clear()     ' clear content in the list box

        For Index = 0 To CurrentIndex ' it display each used subscript in array
            lstNumber.Items.Add(Numbers(Index))     ' in the list box
        Next Index
        txtNumber.Clear()
        txtNumber.Focus()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Dim SearchNum As Integer
        Dim Found As Boolean '= False ' Searching has nor started yet so Found should be false
        SearchNum = txtSearch.Text
        lblDisplaySearch.Visible = True
        Found = FindNumber(SearchNum, Numbers)

        'Do While (Found = False) And (Index <= CurrentIndex)
        ' one repetition of the loop processes one number in the array
        'If Numbers(Index) = SearchNum Then
        'Found = True
        'Else ' current subscript does not have number being searched for
        'Index += 1 ' so go to the next subscript in the array
        'End If
        'Loop
        If Found Then   ' found is equal to true
            lblDisplaySearch.Text = "The number " & SearchNum & " is in " & vbNewLine & "the array."
        Else            ' found in equal to false
            lblDisplaySearch.Text = "The number " & SearchNum & " In NOT in " & vbNewLine & "The array."
        End If
        txtSearch.Clear()
        txtSearch.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Array.Clear(Numbers, Numbers.GetLowerBound(0), Numbers.Length)
        CurrentIndex = -1
        txtNumber.Enabled = True
        txtNumber.Clear()
        txtNumber.Focus()
        lstNumber.Items.Clear()
        txtSearch.Clear()
        lblDisplaySearch.Visible = False
        btnClear.Visible = False
        btnAdd.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, "Are you sure that you want to quite pregram?", "Add Array and search for it", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lblSmallest.Visible = True
        lblHightest.Visible = True
        Dim Smallest, Hightest As Integer
        Smallest = TheSmallestNumber(Numbers)
        Hightest = TheHightestNumber(Numbers)
        lblSmallest.Text = Smallest
        lblHightest.Text = Hightest
    End Sub
    Private Sub btlShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlShow.Click
        lblSum.Visible = True
        lblMean.Visible = True
        lblMult.Visible = True
        Dim Sum, Mul As Integer
        Dim Average As Double
        Sum = SumNumber(Numbers)
        Mul = MultiplaceNumber(Numbers)
        Average = TheMeanNumber(Numbers)
        lblSum.Text = Sum
        lblMult.Text = Mul
        lblMean.Text = Average
    End Sub
    Public Function FindNumber(ByVal WantedNum As Integer, ByVal NumArray() As Integer) As Boolean
        Dim Index As Integer = 0
        Dim Found As Boolean = False

        Do While (Found = False) And (Index <= CurrentIndex)
            If NumArray(Index) = WantedNum Then
                Found = True
            Else
                Index += 1
            End If
        Loop
        If Found Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function TheSmallestNumber(ByVal SmallestArray() As Integer)
        Dim Small As Integer = 9999999
        For i As Integer = 0 To SmallestArray.Length - 1
            If Small > SmallestArray(i) Then
                Small = SmallestArray(i)
            End If
        Next i
        Return Small
    End Function
    Public Function TheHightestNumber(ByVal BigNumber() As Integer)
        Dim Big As Integer = 0
        For i As Integer = 0 To BigNumber.Length - 1
            If Big < BigNumber(i) Then
                Big = BigNumber(i)
            End If
        Next i
        Return Big
    End Function
    Public Function SumNumber(ByVal TheSumNum() As Integer)
        Dim SumIs As Integer = 0
        For i As Integer = 0 To TheSumNum.Length - 1
            SumIs = SumIs + TheSumNum(i)
        Next i
        Return SumIs
    End Function
    Public Function MultiplaceNumber(ByVal Total() As Integer)
        Dim MultTotal As Integer = 1
        For i As Integer = 0 To Total.Length - 1
            MultTotal = MultTotal * Total(i)
        Next i
        Return MultTotal
    End Function
    Public Function TheMeanNumber(ByVal MeanIs() As Integer)
        Dim AverageNum As Double = 0
        Dim Count, Average1 As Integer
        Count = 0
        For i As Integer = 0 To MeanIs.Length - 1
            Average1 = Average1 + MeanIs(i)
            Count += 1
        Next
        AverageNum = Average1 / Count
        Return AverageNum
    End Function

End Class

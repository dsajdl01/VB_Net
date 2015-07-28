Public Class Form1
    Dim Numbers(3) As Integer        ' declare array variable as global variable
    Dim CurrentIndex As Integer = -1    ' current use subcript of the array

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim AddingNumber As Integer
        AddingNumber = txtNumber.Text
        If CurrentIndex = 9 Then        'if array is full show message(has 5 num. in it)
            MsgBox("The Array is FULL!")
            btnAdd.Enabled = False
            txtNumber.Enabled = False
        ElseIf CurrentIndex >= 3 Then
            If CurrentIndex = 3 Then
                MsgBox("arrey was ReDim")
            End If
            ReDim Preserve Numbers(9)
            CurrentIndex += 1           ' move to next free subscript in array
            Numbers(CurrentIndex) = AddingNumber     ' store number in it
            txtNumber.Clear()   ' clear tex box for next number
            txtNumber.Focus()   ' and place cursor in it
            btnClear.Visible = True
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
        lblTest.Text = CurrentIndex & " x " & Index
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim Index As Integer = 0
        Dim Found As Boolean = False ' Searching has nor started yet so Found should be false
        Dim SearchNum As Integer
        SearchNum = txtSearch.Text
        lblDisplaySearch.Visible = True
        Do While (Found = False) And (Index <= CurrentIndex)
            ' one repetition of the loop processes one number in the array
            If Numbers(Index) = SearchNum Then
                Found = True
            Else ' current subscript does not have number being searched for
                Index += 1 ' so go to the next subscript in the array
            End If
        Loop
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
End Class

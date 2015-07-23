Public Class MakeChanges
    Dim Filename As String

    Structure CarType
        <VBFixedString(8)> Dim RegNumber As String
        <VBFixedString(20)> Dim Made As String
        <VBFixedString(26)> Dim Model As String
        Dim Year As Short
        Dim Price As Decimal
    End Structure
    Dim OneCar As CarType

    Private Sub MakeChanges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filename = "Cars.dat"
    End Sub

    Private Sub btnAddChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChanges.Click
        Dim NumRecord As Short
        Dim Character As Char
        NumRecord = lblRecord.Text
        OneCar.RegNumber = lblAddRegNum.Text
        If txtAddMade.Text = String.Empty Then
            MsgBox("Text box for made is empty. Please entry made of the car", , " Add Car error message")
            txtAddMade.Focus()
            Exit Sub
        Else
            OneCar.Made = txtAddMade.Text
            Character = OneCar.Made.Substring(0, 1)
            If Character = " " Then
                MsgBox("First value is empty! It must start with any character or number", , "Add car error message")
                txtAddMade.Focus()
                Exit Sub
            End If
        End If

        If txtAddModel.Text = String.Empty Then
            MsgBox("Text box for model is empty. Please entry model of the car", , " Add Car error message")
            txtAddModel.Focus()
            Exit Sub
        Else
            OneCar.Model = txtAddModel.Text
            Character = OneCar.Model.Substring(0, 1)
            If Character = " " Then
                MsgBox("First value is empty! It must start with any character or number", , "Add car error message")
                txtAddModel.Focus()
                Exit Sub
            End If
        End If
        Try
            OneCar.Year = txtAddYear.Text
        Catch When Err.Number = 6
            MsgBox("The number is out of range")
            txtAddYear.Focus()
            Exit Sub
        Catch When Err.Number = 13
            MsgBox("The number contain character")
            txtAddYear.Focus()
            Exit Sub
        End Try
        Try
            OneCar.Price = txtAddPrice.Text
        Catch When Err.Number = 6
            MsgBox("Number is out of the range")
            txtAddPrice.Focus()
            Exit Sub
        Catch When Err.Number = 13
            MsgBox("The number contain character")
            txtAddPrice.Focus()
            Exit Sub
        End Try
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        FilePut(1, OneCar, NumRecord)
        FileClose(1)
        Me.Close()
    End Sub
End Class
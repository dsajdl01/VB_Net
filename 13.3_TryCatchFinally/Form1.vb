Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Number As Short
        Dim TotalResult As Double
        Try
            Number = txtNumber.Text
            MsgBox("You entered a valid number")
            TotalResult = Number * Number - Number
            MsgBox(TotalResult)
        Catch
            MsgBox("You enterd an invalid number!!!")
            'Finally
            'MsgBox("This completes the simple error handling example")
        End Try
    End Sub
End Class

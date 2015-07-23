Public Class PasswordForm
    Dim Filename, FileForPassword As String
    Dim NumberOfCars As Short

    Structure CarType
        <VBFixedString(8)> Dim RegNumber As String
        <VBFixedString(20)> Dim Made As String
        <VBFixedString(26)> Dim Model As String
        Dim Year As Short
        Dim Price As Decimal
    End Structure
    Dim OneCar As CarType

    Private Sub PasswordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filename = "Cars.dat"
        FileForPassword = "Data.txt"
        FileOpen(1, Filename, OpenMode.Random, , , Len(OneCar))
        NumberOfCars = LOF(1) / Len(OneCar)
        FileClose(1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static First, Second, RegNumber As String
        Dim Character As Char
        Dim SecondForm As New MakeChanges
        Dim FirstForm As New Form1
        Dim Result As DialogResult
        Dim NumberOfRecord As Integer

        If txtFirst.Text = String.Empty Then
            MsgBox("The text box of the add password is empty." & vbNewLine & "Please add password more then five character", , "Sake care password message")
            txtFirst.Focus()
            Exit Sub
        Else
            First = txtFirst.Text
            For z As Short = 0 To First.Length - 1
                Character = First.Substring(z)
                If Character = " " Then
                    MsgBox("Password contain empty space, please remove any empty spase!", , "Sale car password message")
                    txtFirst.Focus()
                    Exit Sub
                End If
            Next
            If First.Length < 5 Then
                MsgBox("Password is to shor! It must be minimum 5 characters", , "Sale car password message.")
                txtFirst.Focus()
                Exit Sub
            End If
        End If
        If txtSecond.Text = String.Empty Then
            MsgBox("The text box of the re-entered password is empty." & vbNewLine & "Please re-enter your password more. It must be same password as it is in the first text box", , "Sake care password message")
            txtSecond.Focus()
            Exit Sub
        Else
            Second = txtSecond.Text
        End If
        If First = Second Then
            FileOpen(1, FileForPassword, OpenMode.Output)
            PrintLine(1, First)
            FileClose(1)
            Result = MessageBox.Show(Me, "Password has been changed" & vbNewLine & vbNewLine & "Do you want to show make change form and make changes on the selected car then press yes? ", "Sale car password message", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then

                RegNumber = lblRegNumber.Text
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
                Me.Close()
                Exit Sub
            Else
                Me.Close()
            End If
        Else
            MsgBox("Your password in the second box is not same as it is in the first box," & vbNewLine & " Please correct your password", , "Sale car password message")
            txtFirst.Focus()
            Exit Sub
        End If
    End Sub
End Class
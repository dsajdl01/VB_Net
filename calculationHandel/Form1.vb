Public Class Form1
    Dim First, Second, Result As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
        lblResult.Visible = False
        txtFirstNo.Clear()
        txtSecondNo.Clear()
        txtFirstNo.Focus()
        btnClear.Visible = False
        btnClearNo.Visible = False
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClearNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearNo.Click
        lblResult.Visible = False
        txtFirstNo.Clear()
        txtSecondNo.Clear()
        txtFirstNo.Focus()
        btnClearNo.Visible = False
    End Sub

    Private Sub ckbPlus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbPlus.CheckedChanged, ckbMinus.CheckedChanged, ckbMult.CheckedChanged, ckbDiv.CheckedChanged
        First = CDbl(txtFirstNo.Text)
        Second = CDbl(txtSecondNo.Text)
        lblResult.Visible = True
        btnClear.Visible = True
        btnClearNo.Visible = True
        If ckbPlus.Checked = True Then
            ckbMinus.Checked = False
            ckbMult.Checked = False
            ckbDiv.Checked = False
            Result = First + Second
            lblResult.Text = Result
            lstOutput.Items.Add(First & " + " & Second & " = " & Result)
        ElseIf ckbMinus.Checked = True Then
            ckbPlus.Checked = False
            ckbMult.Checked = False
            ckbDiv.Checked = False
            Result = First - Second
            lblResult.Text = Result
            lstOutput.Items.Add(First & " - " & Second & " = " & Result)
        ElseIf ckbMult.Checked = True Then
            ckbPlus.Checked = False
            ckbMinus.Checked = False
            ckbDiv.Checked = False
            Result = First * Second
            lblResult.Text = Result
            lstOutput.Items.Add(First & " * " & Second & " = " & Result)
        ElseIf ckbDiv.Checked = True Then
            ckbPlus.Checked = False
            ckbMult.Checked = False
            ckbMinus.Checked = False
            Result = First / Second
            lblResult.Text = Format(Result, "0,00")
            lstOutput.Items.Add(First & " / " & Second & " = " & Format(Result, "0.00"))
        End If
    End Sub
End Class

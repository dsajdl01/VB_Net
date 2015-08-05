Public Class Form1
    Dim Count, TimeCount As Integer

    Private Sub Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Click.Click

        Count = Count + 1
        If Count = 1 Then
            lblRed.BackColor = Color.Red
            lblOrange.BackColor = Color.Orange
            lblGreen.BackColor = Color.White
        ElseIf Count = 2 Then
            lblRed.BackColor = Color.White
            lblOrange.BackColor = Color.White
            lblGreen.BackColor = Color.LimeGreen
        ElseIf Count = 3 Then
            lblRed.BackColor = Color.White
            lblOrange.BackColor = Color.Orange
            lblGreen.BackColor = Color.White
        ElseIf Count = 4 Then
            lblRed.BackColor = Color.Red
            lblOrange.BackColor = Color.White
            lblGreen.BackColor = Color.White
            Count = 0
        End If

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        Timer1.Interval = 1000
        btnStop.Visible = True
        btnStart.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeCount = TimeCount + 1
        'lblOutput.Text = TimeCount
        If TimeCount <= 4 Then
            lblRed1.BackColor = Color.Red
            lblOrange1.BackColor = Color.Orange
            lblGreen1.BackColor = Color.White
        ElseIf TimeCount <= 11 Then
            lblRed1.BackColor = Color.White
            lblOrange1.BackColor = Color.White
            lblGreen1.BackColor = Color.LimeGreen
        ElseIf TimeCount <= 14 Then
            lblRed1.BackColor = Color.White
            lblOrange1.BackColor = Color.Orange
            lblGreen1.BackColor = Color.White
        ElseIf TimeCount <= 20 Then
            lblRed1.BackColor = Color.Red
            lblOrange1.BackColor = Color.White
            lblGreen1.BackColor = Color.White
        ElseIf TimeCount = 22 Then
            TimeCount = 0
        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStop.Visible = False
        btnStart.Visible = True
        Timer1.Enabled = False
    End Sub
End Class

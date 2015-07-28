Public Class Form1
    Dim A, B, C As String
    Dim aa, bb, cc, Result As Double
            
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb1.CheckedChanged, rdb2.CheckedChanged, rdb3.CheckedChanged
        If rdb1.Checked = True Then
            rdb2.Checked = False
            rdb3.Checked = False
            A = txtA.Text
            B = txtB.Text
            C = txtC.Text
            aa = CDbl(Val(A))
            bb = CDbl(Val(B))
            cc = CDbl(Val(C))
            Result = aa + bb - cc
            lblResult.Text = Format(Result, "0.00")
        ElseIf rdb2.Checked = True Then
            rdb1.Checked = False
            rdb3.Checked = False
            A = txtA.Text
            B = txtB.Text
            C = txtC.Text
            aa = CDbl(Val(A))
            bb = CDbl(Val(B))
            cc = CDbl(Val(C))
            Result = aa - bb / cc
            lblResult.Text = Format(Result, "0.00")
        ElseIf rdb3.Checked = True Then
            rdb1.Checked = False
            rdb2.Checked = False
            B = txtB.Text
            C = txtC.Text
            bb = CDbl(Val(B))
            cc = CDbl(Val(C))
            Result = bb Mod cc
            lblResult.Text = Format(Result, "0.00")
        Else
            lblResult.Text = " "
        End If
    End Sub
End Class

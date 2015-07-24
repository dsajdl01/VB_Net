Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub hsbRed_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbRed.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
        txtRed.Text = hsbRed.Value
    End Sub

    Private Sub hsbGreen_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbGreen.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
        txtGreen.Text = hsbGreen.Value
    End Sub

    Private Sub hsbBlue_Scroll_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbBlue.Scroll
        Me.BackColor = ColorTranslator.FromOle(RGB(hsbRed.Value, hsbGreen.Value, hsbBlue.Value))
        txtBlue.Text = hsbBlue.Value
    End Sub
End Class

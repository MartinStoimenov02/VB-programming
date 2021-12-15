Public Class Form5

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form28.Show()
        Form28.TextBox1.Text = "програма за тапети"
        Form28.TextBox2.Text = "0"
    End Sub
End Class
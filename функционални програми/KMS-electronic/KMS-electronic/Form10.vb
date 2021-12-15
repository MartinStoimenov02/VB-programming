Public Class Form10

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form28.Show()
        Form28.TextBox1.Text = "настолен компютър KMS"
        Form28.TextBox2.Text = "700"
    End Sub
End Class
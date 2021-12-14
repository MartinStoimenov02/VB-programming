Public Class Form1

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
        If (Label1.Text = 7) Or (Label2.Text = 7) Or (Label3.Text = 7) Then
            PictureBox1.Visible = True
        End If
    End Sub
End Class

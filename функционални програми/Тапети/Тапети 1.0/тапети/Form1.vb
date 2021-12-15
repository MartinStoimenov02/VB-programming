Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, h, a1, h1, a2, h2, S, c, c1, br As Double
        a = TextBox1.Text
        b = TextBox2.Text
        h = TextBox7.Text
        a1 = TextBox6.Text
        h1 = TextBox5.Text
        a2 = TextBox4.Text
        h2 = TextBox3.Text
        c = TextBox8.Text
        S = (2 * a * h + 2 * b * h) - ((a1 * h1) + (a2 * h2))
        br = S / 5
        br = Math.Ceiling(br)
        TextBox9.Text = br
        c1 = br * c
        c1 = Math.Round(c1, 2)
        TextBox10.Text = c1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
    End Sub
End Class


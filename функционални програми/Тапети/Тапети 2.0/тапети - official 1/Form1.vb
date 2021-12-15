Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, h, a1, h1, a2, h2, S, c, c1, br, d, pr, vr As Double
        Dim shir(20), vis(20) As Double
        Dim n, m, i As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        h = TextBox3.Text
        c = TextBox8.Text
        n = TextBox11.Text
        m = TextBox12.Text
        For i = 1 To n Step 1
            shir(i) = InputBox(a1, "въведи ширина на прозорец")
            vis(i) = InputBox(h1, "въведи височина на прозорец")
        Next
        For i = 1 To n Step 1
            d = shir(i) * vis(i)
            pr = d + pr
        Next
        d = 0
        For i = 1 To m Step 1
            shir(i) = InputBox(a2, "въведи ширина на вратата")
            vis(i) = InputBox(h2, "въведи височина на вратата")
        Next
        For i = 1 To m Step 1
            d = shir(i) * vis(i)
            vr = d + vr
        Next
        S = ((2 * a * h) + (2 * b * h)) - (pr + vr)
        TextBox4.Text = S
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
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
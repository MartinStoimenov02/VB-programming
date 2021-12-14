Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, i, s, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        s = TextBox3.Text
        For i = a To b Step s
            c = 1 / Math.Tan(i)
            ListBox1.Items.Add(i)
            ListBox2.Items.Add(Math.Sin(i))
            ListBox3.Items.Add(Math.Cos(i))
            ListBox4.Items.Add(Math.Tan(i))
            ListBox5.Items.Add(c)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
    End Sub

End Class

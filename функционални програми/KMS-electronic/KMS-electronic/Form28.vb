Public Class Form28
    Dim a, b, c, d, e As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label6.Visible = True
        a = Val(TextBox2.Text)
        b = Val(TextBox8.Text)
        c = a * b
        TextBox7.Text = c
        Form29.Show()
        Form29.ListBox1.Items.Add(TextBox1.Text)
        Form29.ListBox2.Items.Add(c)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
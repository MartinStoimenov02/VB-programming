Public Class Form29

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As Integer
        For Each Str As String In ListBox2.Items
            total = total + CInt(Str)
        Next
        TextBox1.Text = total
        Label6.Visible = True
    End Sub
End Class
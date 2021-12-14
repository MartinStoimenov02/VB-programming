Public Class Form1
    Private Sub Button18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button18.Click

    End Sub

    Private Sub Button28_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click,
Button6.Click, Button5.Click, Button48.Click, Button47.Click, Button46.Click,
Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click,
Button40.Click, Button4.Click, Button39.Click, Button38.Click, Button37.Click,
Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click,
Button31.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click,
Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click,
Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click,
Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click,
Button12.Click, Button11.Click, Button10.Click, Button1.Click

        If Button52.FlatStyle = FlatStyle.Flat Then
            TextBox1.Text = TextBox1.Text + sender.text
            Button52.PerformClick()
        Else
            TextBox1.Text = TextBox1.Text + sender.text
        End If

    End Sub

    Private Sub Button50_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button50.Click
        TextBox1.Text = TextBox1.Text & Environment.NewLine

    End Sub

    Private Sub Button27_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button27.Click
        TextBox1.Text = TextBox1.Text & "   "
    End Sub

    Private Sub Button54_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button54.Click
        TextBox1.Text = TextBox1.Text & " "
    End Sub

    Private Sub Button52_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button52.Click, Button53.Click

        If Button52.FlatStyle = FlatStyle.Flat Then
            Button52.FlatStyle = FlatStyle.Standard
            Button53.FlatStyle = FlatStyle.Standard
            For Each ctl As Control In Me.Controls
                If (ctl.Name.StartsWith("Button")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    btn.Text = btn.Text.ToLower
                    Button1.Text = "1"
                    Button2.Text = "2"
                    Button3.Text = "3"
                    Button4.Text = "4"
                    Button5.Text = "5"
                    Button6.Text = "6"
                    Button7.Text = "7"
                    Button8.Text = "8"
                    Button9.Text = "9"
                    Button10.Text = "0"
                    Button11.Text = "-"
                    Button12.Text = "="
                    Button13.Text = "`"
                    Button14.Text = "\"
                    Button15.Text = "]"
                    Button16.Text = "["
                    Button29.Text = "'"
                    Button30.Text = ";"
                    Button28.Text = "/"
                    Button40.Text = "."
                    Button41.Text = ","
                End If
            Next
        ElseIf Button52.FlatStyle = FlatStyle.Standard Then
            Button53.FlatStyle = FlatStyle.Flat
            Button52.FlatStyle = FlatStyle.Flat
            For Each ctl As Control In Me.Controls
                If (ctl.Name.StartsWith("Button")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    btn.Text = btn.Text.ToUpper
                    Button1.Text = "!"
                    Button2.Text = "@"
                    Button3.Text = "#"
                    Button4.Text = "$"
                    Button5.Text = "%"
                    Button6.Text = "^"
                    Button7.Text = "&"
                    Button8.Text = "*"
                    Button9.Text = "("
                    Button10.Text = ")"
                    Button11.Text = "_"
                    Button12.Text = "+"
                    Button13.Text = "~"
                    Button14.Text = "|"
                    Button15.Text = "}"
                    Button16.Text = "{"
                    Button29.Text = """"
                    Button30.Text = ":"
                    Button28.Text = "?"
                    Button40.Text = ">"
                    Button41.Text = "<"
                End If
            Next
        End If
    End Sub

    Private Sub Button49_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button49.Click
        If TextBox1.Text < " " Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
        Else
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
        End If

    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click

        If Button51.FlatStyle = FlatStyle.Flat Then
            Button51.FlatStyle = FlatStyle.Standard
            For Each ctl As Control In Me.Controls
                If (ctl.Name.StartsWith("Button")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    btn.Text = btn.Text.ToLower
                End If
            Next
        ElseIf Button51.FlatStyle = FlatStyle.Standard Then
            Button51.FlatStyle = FlatStyle.Flat
            For Each ctl As Control In Me.Controls
                If (ctl.Name.StartsWith("Button")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    btn.Text = btn.Text.ToUpper
                End If
            Next
        End If
    End Sub
End Class

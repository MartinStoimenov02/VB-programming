Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        Dim s, p As Double
        Dim h As String
        Dim k, q, l, g As String
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        k = "Figurata e triugulnik"
        q = "Figurata ne e triugulnik"
        l = "Triugulnika e ravnobedren"
        h = "Truugulnika e ravnostranen"
        g = "Triugulnika e raznostranen"
        If (a + b > c) And (b + c > a) And (a + c > b) Then
            ListBox1.Items.Add(k)
            If (a = b) Or (b = c) Or (a = c) Then
                ListBox1.Items.Add(l)
                p = (a + b + c) / 2
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
                s = Math.Round(s, 3)
                ListBox1.Items.Add(s)
            ElseIf (a = b) And (a = c) And (b = c) Then
                ListBox1.Items.Add(h)
                p = (a + b + c) / 2
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
                s = Math.Round(s, 3)
                ListBox1.Items.Add(s)
            ElseIf (a <> b) And (b <> c) And (a <> c) Then
                ListBox1.Items.Add(g)
                p = (a + b + c) / 2
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
                s = Math.Round(s, 3)
                ListBox1.Items.Add(s)
            End If
        Else
            ListBox1.Items.Add(q)
        End If

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g As Graphics
        g = Me.CreateGraphics
        g.Clear(Drawing.Color.FromName("Control"))
        Dim StartPoint, EndPoint, Pie As Integer
        StartPoint = 0
        If TextBox1.Text <> "" Then
            Pie = CInt(360 / Val(TextBox1.Text))
            EndPoint = Pie
            For i As Integer = 0 To Val(TextBox1.Text)
                g.FillPie(Brushes.Pink, 10, 50, 200, 200, CInt(StartPoint),
               CInt(EndPoint))

                StartPoint = EndPoint
                EndPoint += Pie
            Next
            For i As Integer = 0 To Val(TextBox1.Text)
                g.DrawPie(Pens.Purple, 10, 50, 200, 200, CInt(StartPoint),
               CInt(EndPoint))
                StartPoint = EndPoint


                EndPoint += Pie
            Next
        End If
    End Sub
End Class

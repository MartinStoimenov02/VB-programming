Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackColor = Color.Yellow
        Dim MyPen As New Pen(Color.Black)
        Dim g As Graphics = PictureBox1.CreateGraphics
        PictureBox1.ForeColor = System.Drawing.Color.Gray
        PictureBox1.Refresh()
        MyPen.Width = 8
        MyPen.Color = System.Drawing.Color.Red
        g.DrawArc(MyPen, 30, 10, 200, 140, 180, 180)
        MyPen.Color = System.Drawing.Color.Orange
        g.DrawArc(MyPen, 30, 18, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Yellow
        g.DrawArc(MyPen, 30, 26, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Green
        g.DrawArc(MyPen, 30, 34, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Blue
        g.DrawArc(MyPen, 30, 42, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Indigo
        g.DrawArc(MyPen, 30, 50, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Violet
        g.DrawArc(MyPen, 30, 58, 200, 150, 180, 180)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BackColor = Color.Blue
        Dim MyPen As New Pen(Color.Black)
        Dim g As Graphics = PictureBox1.CreateGraphics
        PictureBox1.ForeColor = System.Drawing.Color.Gray
        PictureBox1.Refresh()
        MyPen.Width = 8
        MyPen.Color = System.Drawing.Color.PapayaWhip
        g.DrawArc(MyPen, 30, 10, 200, 140, 180, 180)
        MyPen.Color = System.Drawing.Color.Violet
        g.DrawArc(MyPen, 30, 18, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Tomato
        g.DrawArc(MyPen, 30, 26, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Azure
        g.DrawArc(MyPen, 30, 34, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.Chocolate
        g.DrawArc(MyPen, 30, 42, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.ForestGreen
        g.DrawArc(MyPen, 30, 50, 200, 150, 180, 180)
        MyPen.Color = System.Drawing.Color.GreenYellow
        g.DrawArc(MyPen, 30, 58, 200, 150, 180, 180)
    End Sub
End Class

Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim masiv(2) As Point
        masiv(0) = New Point(240, 10)
        masiv(1) = New Point(60, 400)
        masiv(2) = New Point(430, 400)
        Dim masif(5) As Point
        masif(0) = New Point(180, 230)
        masif(1) = New Point(300, 230)
        masif(2) = New Point(360, 300)
        masif(3) = New Point(300, 360)
        masif(4) = New Point(180, 360)
        masif(5) = New Point(120, 300)
        Dim musiv(2) As Point
        musiv(0) = New Point(240, 240)
        musiv(1) = New Point(290, 350)
        musiv(2) = New Point(190, 350)
        Dim maziv(2) As Point
        maziv(0) = New Point(700, 110)
        maziv(1) = New Point(610, 290)
        maziv(2) = New Point(790, 290)
        e.Graphics.DrawLine(Pens.Blue, 0, 50, 50, 0)
        e.Graphics.DrawLine(Pens.Blue, 0, 70, 70, 0)
        e.Graphics.DrawLine(Pens.Blue, 10, 100000, 20, 0)
        e.Graphics.DrawLine(Pens.Blue, 30, 100000, 40, 0)
        e.Graphics.DrawPolygon(Pens.Black, masiv)
        e.Graphics.DrawPolygon(Pens.Black, masif)
        e.Graphics.DrawPolygon(Pens.Black, musiv)
        e.Graphics.DrawEllipse(Pens.Orange, 500, 10, 400, 400)
        e.Graphics.DrawRectangle(Pens.Pink, 600, 100, 200, 200)
        e.Graphics.DrawPolygon(Pens.ForestGreen, maziv)
        e.Graphics.DrawEllipse(Pens.Orange, 650, 200, 100, 80)

    End Sub
End Class

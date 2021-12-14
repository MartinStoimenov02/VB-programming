Public Class Form1
    Dim myPen As New Pen(Color.Gray)
    Dim bluePens As New Drawing.Pen(Color.Blue, 10)
    Dim myBrushes As New SolidBrush(Color.Red)

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.Gray, 10, 10, 150, 250)
        e.Graphics.DrawRectangle(Pens.Gray, 200, 10, 150, 250)
        e.Graphics.DrawLine(Pens.Gray, 160, 80, 200, 80)
        e.Graphics.DrawLine(Pens.Gray, 160, 160, 200, 160)
        e.Graphics.DrawEllipse(Pens.Red, 20, 30, 130, 80)
        e.Graphics.DrawEllipse(bluePens, 20, 140, 130, 80)
        e.Graphics.FillEllipse(Brushes.Red, 20, 140, 130, 80)
        e.Graphics.DrawEllipse(bluePens, 215, 120, 120, 120)
        e.Graphics.FillEllipse(Brushes.Red, 215, 120, 120, 120)
        myPen.DashStyle = Drawing.Drawing2D.DashStyle.Dot
        e.Graphics.DrawRectangle(myPen, 220, 30, 115, 50)
    End Sub
End Class

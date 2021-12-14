Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.Green, 10, 10, 200, 200)
        e.Graphics.DrawRectangle(Pens.Green, 30, 30, 160, 160)
        e.Graphics.DrawRectangle(Pens.Green, 50, 50, 120, 120)
        e.Graphics.DrawRectangle(Pens.Green, 70, 70, 80, 80)
        e.Graphics.DrawEllipse(Pens.Red, 300, 10, 200, 200)
        e.Graphics.DrawEllipse(Pens.Red, 320, 50, 160, 160)
        e.Graphics.DrawEllipse(Pens.Red, 340, 90, 120, 120)
        e.Graphics.DrawEllipse(Pens.Red, 360, 130, 80, 80)
        e.Graphics.DrawRectangle(Pens.Blue, 150, 300, 200, 200)
        e.Graphics.DrawRectangle(Pens.Blue, 120, 270, 60, 60)
        e.Graphics.DrawRectangle(Pens.Blue, 320, 270, 60, 60)
        e.Graphics.DrawRectangle(Pens.Blue, 120, 470, 60, 60)
        e.Graphics.DrawRectangle(Pens.Blue, 320, 470, 60, 60)
    End Sub
End Class

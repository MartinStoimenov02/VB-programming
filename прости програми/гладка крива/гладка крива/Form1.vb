Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.PaintEventArgs) Handles _
    MyBase.Paint
        Dim Pens, Penz As Pen
        Pens = New Pen(Drawing.Color.Green, 4)
        Penz = New Pen(Drawing.Color.Black, 2)
        Dim pts() As Point = {New Point(50, 50), New Point(250, 150), _
        New Point(150, 200), New Point(100, 90), New Point(50, 120) _
        }
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawCurve(Pens, pts)
        For i As Integer = 0 To pts.Length - 1
            e.Graphics.FillRectangle(Brushes.White, pts(i).X - 2, pts(i).Y - 2, 4, 4)
            e.Graphics.DrawRectangle(Penz, pts(i).X - 2, pts(i).Y - 2, 4, 4)
        Next i
    End Sub
End Class
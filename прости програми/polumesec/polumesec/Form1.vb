Public Class Form1
    Public Sub DrawMoon(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.Clear(Color.DarkBlue)
        e.Graphics.FillEllipse(Brushes.Yellow, 50, 50, 200, 200)
        e.Graphics.FillEllipse(Brushes.DarkBlue, 90, 60, 200, 200)
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        DrawMoon(sender, e)
    End Sub
End Class

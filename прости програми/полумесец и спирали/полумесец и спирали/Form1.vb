Public Class Form1
    Public Sub DrawMoon(ByVal sender As Object, ByVal e _
    As System.Windows.Forms.PaintEventArgs)
        e.Graphics.Clear(Color.DarkBlue)
        e.Graphics.FillEllipse(Brushes.Yellow, 50, 50, 200, 200)
        e.Graphics.FillEllipse(Brushes.DarkBlue, 90, 60, 200, 200)
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e _
    As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        DrawMoon(sender, e)
        DrawSpiral(sender, e)
    End Sub
    Public Sub DrawSpiral(ByVal sender As Object,
        ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim PI As Double = 3.14159265358979
        Dim Orientation As Double = 2.718281828
        Dim penSpiral As New Pen(System.Drawing.Color.Yellow)
        Dim cx As Integer
        Dim x As Integer
        Dim cy As Integer
        Dim y As Integer
        Dim rectSprial As New Rectangle(10, 10, 1600, 200)
        cx = rectSprial.Width / 2
        cy = rectSprial.Height / 2
        Dim a As Single
        Dim b As Single
        Dim i As Long
        Dim ang As Double
        a = 0.15
        b = 0.15
        For i = 0 To 10000
            ang = (PI / 720) * i
            x = cx + (a * (System.Math.Cos(ang)) *
            (Orientation ^ (b * ang)))
            y = cy - (a * (System.Math.Sin(ang)) *
            (Orientation ^ (b * ang)))
            e.Graphics.DrawLine(penSpiral, x, y, x + 1, y + 1)
        Next i
        Dim penspir As New Pen(System.Drawing.Color.Yellow)
        Dim rectSpr As New Rectangle(10, 10, 1600, 800)
        cx = rectSpr.Width / 2
        cy = rectSpr.Height / 2
        Dim j As Long
        Dim mng As Double
        a = 0.15
        b = 0.15
        For j = 0 To 10000
            mng = (PI / 720) * j
            x = cx + (a * (System.Math.Cos(mng)) *
            (Orientation ^ (b * mng)))
            y = cy - (a * (System.Math.Sin(mng)) *
            (Orientation ^ (b * mng)))
            e.Graphics.DrawLine(penspir, x, y, x + 1, y + 1)
        Next j
        Dim penspiri As New Pen(System.Drawing.Color.Yellow)
        Dim rectSpri As New Rectangle(10, 10, 200, 800)
        cx = rectSpri.Width / 2
        cy = rectSpri.Height / 2
        Dim k As Long
        Dim vng As Double
        a = 0.15
        b = 0.15
        For k = 0 To 10000
            vng = (PI / 720) * k
            x = cx + (a * (System.Math.Cos(vng)) *
            (Orientation ^ (b * vng)))
            y = cy - (a * (System.Math.Sin(vng)) *
            (Orientation ^ (b * vng)))
            e.Graphics.DrawLine(penspiri, x, y, x + 1, y + 1)
        Next k
    End Sub
End Class
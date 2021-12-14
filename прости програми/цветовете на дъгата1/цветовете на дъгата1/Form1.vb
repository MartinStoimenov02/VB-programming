Class Form1
    Private Function MapRainbowColor(ByVal value As Single,
    ByVal red_value As Single, ByVal blue_value As Single) _
    As Color
        ' Преобразуване в стойност между 0 и 1023.
        Dim int_value As Integer = Int(1023 * (value -
        red_value) / (blue_value - red_value))
        ' Съпоставяне на стойностите в различните цветови ленти.
        If (int_value < 256) Then
            ' От червено до жълто. (255, 0, 0) to (255, 255, 0).
            Return Color.FromArgb(255, int_value, 0)
        ElseIf (int_value < 512) Then
            ' От жълто до зелено. (255, 255, 0) to (0, 255, 0).
            int_value -= 256
            Return Color.FromArgb(255 - int_value, 255, 0)
        ElseIf (int_value < 768) Then
            ' От зелено до морско синьо. (0, 255, 0) to (0, 255, 255).
            int_value -= 512
            Return Color.FromArgb(0, 255, int_value)
        Else
            ' От морско синьо до синьо. (0, 255, 255) to (0, 0, 255).
            int_value -= 768
            Return Color.FromArgb(0, 255 - int_value, 255)
        End If
    End Function
    ' Изчертаване на цветовете на дъгата върху формата.
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim wid As Integer = Me.ClientSize.Width
        Dim hgt As Integer = Me.ClientSize.Height
        Dim hgt2 As Integer = Int(hgt / 3)
        Dim hgt3 As Integer = Int(hgt * 2 / 3)
        For x As Integer = 0 To wid - 1
            Using the_pen As New Pen(MapRainbowColor(x, 0, wid))
                e.Graphics.DrawLine(the_pen, x, 0, x, hgt2)
            End Using
            Using the_pen As New Pen(MapRainbowColor(x, wid, 0))
                e.Graphics.DrawLine(the_pen, x, hgt2, x, hgt3)
            End Using
            Using the_pen As New Pen(MapRainbowColor(x, 0, wid))
                e.Graphics.DrawLine(the_pen, x, hgt3, x, hgt)
            End Using
        Next x
    End Sub
End Class

Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.Clear(Me.BackColor)
        Dim graphics_path As New System.Drawing.Drawing2D.GraphicsPath
        Dim path_rect As New RectangleF(10, 40, Me.ClientSize.Width - 20, Me.ClientSize.Height - 100)
        graphics_path.AddEllipse(path_rect)
        e.Graphics.SetClip(graphics_path)
        Dim txt As String = "When in worry or in doubt run in " & "circles scream and shout... "
        For i As Integer = 1 To 6
            txt &= txt
        Next i
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Dim rect As New RectangleF(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        e.Graphics.DrawString(txt, Me.Font, Brushes.Black, rect)
    End Sub
End Class
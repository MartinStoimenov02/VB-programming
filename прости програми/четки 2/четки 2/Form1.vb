Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Dim RanNum As Integer
        RanNum = MyRandomGenerator.Next(0, 53)
        Dim g As Graphics
        g = Me.CreateGraphics
        g.Clear(Drawing.Color.FromName("Control"))
        Dim brush As New HatchBrush(RanNum, Color.Pink, Color.Blue)
        g.FillRectangle(brush, 0, 0, 300, 300)
    End Sub
End Class
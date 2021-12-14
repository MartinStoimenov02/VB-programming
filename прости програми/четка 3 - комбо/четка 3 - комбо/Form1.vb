Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Form1
    Dim SelectRadioButton As Integer = 1
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            SelectRadioButton = 1
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            SelectRadioButton = 2
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            SelectRadioButton = 3
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            SelectRadioButton = 4
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            SelectRadioButton = 5
        End If
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Dim g As Graphics
        g = Me.CreateGraphics
        g.Clear(Drawing.Color.White)
        Dim ColorA As System.Drawing.Color
        Select Case ComboBox1.SelectedIndex
            Case 0
                ColorA = Drawing.Color.Blue
            Case 1
                ColorA = Drawing.Color.Red
            Case 2
                ColorA = Drawing.Color.Green
            Case 3
                ColorA = Drawing.Color.Cyan
            Case 4
                ColorA = Drawing.Color.Magenta
            Case 5
                ColorA = Drawing.Color.Yellow
            Case 6
                ColorA = Drawing.Color.Purple
            Case 7
                ColorA = Drawing.Color.Brown
            Case Else
                ColorA = Drawing.Color.Black
        End Select
        Dim ColorB As System.Drawing.Color
        Select Case ComboBox2.SelectedIndex
            Case 0
                ColorB = Drawing.Color.Blue
            Case 1
                ColorB = Drawing.Color.Red
            Case 2
                ColorB = Drawing.Color.Green
            Case 3
                ColorB = Drawing.Color.Cyan
            Case 4
                ColorB = Drawing.Color.Magenta
            Case 5
                ColorB = Drawing.Color.Yellow
            Case 6
                ColorB = Drawing.Color.Purple
            Case 7
                ColorB = Drawing.Color.Brown
            Case Else
                ColorB = Drawing.Color.Black
        End Select
        Select Case SelectRadioButton
            Case 1
                Dim SolidBrush As New SolidBrush(ColorA)
                g.FillRectangle(SolidBrush, 10, 160, 200, 200)
            Case 2
                Dim HatchBrush As New HatchBrush(4, ColorA, ColorB)
                g.FillRectangle(HatchBrush, 10, 160, 200, 200)
            Case 3
                Dim MyImage As Image = Image.FromFile("email.gif")
                Dim TextureBrush As New TextureBrush(MyImage)
                g.FillRectangle(TextureBrush, 10, 160, 200, 200)
            Case 4
                Dim LinearGradientBrush As New LinearGradientBrush(New Point(10, 10), New Point(40, 40), ColorA, ColorB)
                g.FillRectangle(LinearGradientBrush, 10, 160, 200, 200)
            Case 5
                Dim points() As Point = {New Point(10, 160), New Point(10, 200), New Point(260, 200)}
                Dim PathGradientBrush As New PathGradientBrush(points)
                g.FillRectangle(PathGradientBrush, 10, 160, 200, 200)
        End Select
    End Sub

    Private Sub Form1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Dim RanNum As Integer
        RanNum = MyRandomGenerator.Next(0, 53)
        Dim g As Graphics
        g = Me.CreateGraphics
        g.Clear(Drawing.Color.FromName("Control"))
        Dim brush As New HatchBrush(RanNum, Color.Pink, Color.Blue)
        g.FillRectangle(brush, 215, 160, 200, 200)
    End Sub
End Class
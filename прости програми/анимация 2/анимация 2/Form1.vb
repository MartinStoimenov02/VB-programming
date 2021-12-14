Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer5.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox4.Left = PictureBox4.Left + 5
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox3.Left = PictureBox3.Left + 25
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If PictureBox3.Left >= 230 Then
            Timer2.Enabled = False
            PictureBox3.Top = PictureBox3.Top - 50
            PictureBox3.Left = PictureBox3.Left + 50
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        PictureBox2.Left = PictureBox2.Left + 25
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If PictureBox2.Left >= 230 Then
            Timer2.Enabled = False
            PictureBox2.Top = PictureBox2.Top - 50
            PictureBox2.Left = PictureBox2.Left + 50
            Timer4.Enabled = True
        End If
    End Sub
End Class
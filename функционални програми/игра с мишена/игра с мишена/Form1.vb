Public Class Form1
    Dim Hits As Integer = 0
    Dim Total As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Timer1.Interval = 900
            PictureBox1.Width = 40
            PictureBox1.Height = 40
        End If
        If RadioButton2.Checked = True Then
            Timer1.Interval = 850
            PictureBox1.Width = 35
            PictureBox1.Height = 35
        End If
        If RadioButton3.Checked = True Then
            Timer1.Interval = 800
            PictureBox1.Width = 30
            PictureBox1.Height = 30
        End If
        Hits = 0
        Total = 0
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Dim RandomX As Integer
        Dim RandomY As Integer
        RandomX = MyRandomGenerator.Next(1, 550)
        RandomY = MyRandomGenerator.Next(1, 250)
        PictureBox1.SetBounds(RandomX, RandomY, Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)
        Total = Total + 1
        TextBox2.Text = Total
        Me.BackColor = Color.Gray
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Hits = Hits + 1
        TextBox1.Text = Hits
        Me.BackColor = Color.Red
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class


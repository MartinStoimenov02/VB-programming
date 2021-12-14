Public Class Form1
    Dim RanNum As Integer = 0
    Dim Wins As Integer = 0
    Dim Losses As Integer = 0
    Dim winpro As Double = 0
    Dim lospro As Double = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Dim RanNum As Integer
        RanNum = MyRandomGenerator.Next(0, 2)
        If RanNum = 0 Then
            TextBox2.Text = "Ези"
        ElseIf RanNum = 1 Then
            TextBox2.Text = "Тура"
        End If
        If TextBox1.Text = TextBox2.Text Then
            Wins = Wins + 1
        Else
            Losses = Losses + 1
        End If
        TextBox3.Text = Wins
        TextBox4.Text = Losses
        winpro = (Wins / (Wins + Losses)) * 100
        lospro = (Losses / (Wins + Losses)) * 100
        TextBox5.Text = winpro
        TextBox6.Text = lospro
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.Text = "Тура"
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Text = "Ези"
        End If
    End Sub
End Class

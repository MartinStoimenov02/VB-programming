Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim B, S, P, H, V, a, ha As Double
        n = TextBox1.Text
        If n < 3 Then
            End
        ElseIf n = 3 Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            a = Val(TextBox2.Text)
            ha = Val(TextBox3.Text)
            B = (a * ha) / 2
        ElseIf n = 4 Then
            TextBox2.Visible = True
            a = Val(TextBox2.Text)
            B = a ^ 2
        ElseIf n > 4 Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            a = Val(TextBox2.Text)
            ha = Val(TextBox3.Text)
            B = (n * a * ha) / 2
        End If
        TextBox4.Visible = True
        H = Val(TextBox4.Text)
        P = n * a
        S = P * H + 2 * B
        V = B * H
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox5.Text = S
        TextBox6.Text = V
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("времето свърши!")
            End
        End If
    End Sub
End Class

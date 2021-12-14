Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("времето свърши!")
            End
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        GroupBox1.Visible = True
        Dim r, C, S As Double
        Const P = 3.14
        r = Val(TextBox1.Text)
        C = 2 * P * r
        S = P * (r ^ 2)
        TextBox2.Text = C
        TextBox3.Text = S

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        GroupBox2.Visible = True
        Dim a, b, P1, S1 As Double
        a = Val(TextBox4.Text)
        b = Val(TextBox5.Text)
        P1 = 2 * a + 2 * b
        S1 = a * b
        TextBox6.Text = P1
        TextBox7.Text = S1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Start()
        GroupBox3.Visible = True
        Dim V2, S2, a1, b1, c1 As Double
        a1 = Val(TextBox8.Text)
        b1 = Val(TextBox9.Text)
        c1 = Val(TextBox10.Text)
        S2 = 2 * (a1 * b1 + b1 * c1)
        V2 = a1 * b1 * c1
        TextBox11.Text = S2
        TextBox12.Text = V2

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
    End Sub
End Class

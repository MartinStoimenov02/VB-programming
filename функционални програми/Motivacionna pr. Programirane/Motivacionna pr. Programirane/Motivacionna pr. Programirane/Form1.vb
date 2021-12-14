Public Class Form1
    Dim TotalPoints As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TotalPoints = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        TextBox7.Text = TotalPoints
        If TotalPoints > 40 Then
            TextBox8.Text = "Интересът Ви към програмирането е несигурен. Може би трябва да запишете курс по програмиране, за да научите повече за него."
        End If
        If TotalPoints > 19 And TotalPoints < 40 Then
            TextBox8.Text = "Интересът Ви към програмирането е несигурен. Може би трябва да запишете курс по програмиране, за да научите повече за него."
        End If
        If TotalPoints < 20 Then
            TextBox8.Text = "Трябва да изберете друг път за професионално развитие. Програмирането може би не е за вас. По-добре запишете курс по бизнес управление, история или политика."
        End If
    End Sub
End Class

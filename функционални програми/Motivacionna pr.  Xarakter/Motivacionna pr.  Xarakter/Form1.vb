Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TotalPoints As Integer = 0
        TotalPoints = Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text)
        TextBox14.Text = TotalPoints
        If TotalPoints > 40 Then
            TextBox15.Text = "Аналитичен ум, който трудно се решава да промени навиците си. Обвързва се много бавно и предпазливо. Понякога е студен, но е толерантен."


        End If
        If TotalPoints > 19 And TotalPoints < 40 Then
            TextBox15.Text = "Доста рядко срещана комбинация. Хората, които я проявяват, са комуникативни и имат мек характер."


        End If
        If TotalPoints < 20 Then
            TextBox15.Text = "Силни емоции, изявен индивидуализъм, често дори егоизъм и голям инат. Тези хора не забравят какво се е случило в миналото, напротив – склонни са да го интерпретират по нови начини."


        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class

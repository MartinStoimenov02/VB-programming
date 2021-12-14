Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim day As Byte
        day = Val(TextBox1.Text)
        Select Case ComboBox1.Text
            Case "Януари"
                If day < 21 Then
                    TextBox2.Text = "Козирог"
                ElseIf day >= 21 And day <= 31 Then
                    TextBox2.Text = "Водолей"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Февруари"
                If day < 20 Then
                    TextBox2.Text = "Водолей"
                ElseIf day >= 20 And day <= 29 Then
                    TextBox2.Text = "Риби"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Март"
                If day < 21 Then
                    TextBox2.Text = "Риби"
                ElseIf day >= 21 And day <= 31 Then
                    TextBox2.Text = "Овен"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Април"
                If day < 21 Then
                    TextBox2.Text = "Овен"
                ElseIf day >= 21 And day <= 30 Then
                    TextBox2.Text = "Телец"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Май"
                If day < 22 Then
                    TextBox2.Text = "Телец"
                ElseIf day >= 22 And day <= 31 Then
                    TextBox2.Text = "Близнаци"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Юни"
                If day < 22 Then
                    TextBox2.Text = "Близнаци"
                ElseIf day >= 22 And day <= 30 Then
                    TextBox2.Text = "Рак"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Юли"
                If day < 23 Then
                    TextBox2.Text = "Рак"
                ElseIf day >= 23 And day <= 31 Then
                    TextBox2.Text = "Лъв"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Август"
                If day < 24 Then
                    TextBox2.Text = "Лъв"
                ElseIf day >= 24 And day <= 31 Then
                    TextBox2.Text = "Дева"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Септември"
                If day < 24 Then
                    TextBox2.Text = "Дева"
                ElseIf day >= 24 And day <= 30 Then
                    TextBox2.Text = "Везни"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Октомври"
                If day < 24 Then
                    TextBox2.Text = "Везни"
                ElseIf day >= 24 And day <= 31 Then
                    TextBox2.Text = "Скорпион"
                Else
                    TextBox2.Text = "грешка"
                End If
            Case "Ноември"
                If day < 23 Then
                    TextBox2.Text = "Скорпион"
                ElseIf day >= 23 And day <= 30 Then
                    TextBox2.Text = "Водолей"
                Else
                    TextBox2.Text = "Стрелец"
                End If
            Case "Декември"
                If day < 20 Then
                    TextBox2.Text = "Стрелец"
                ElseIf day >= 20 And day <= 31 Then
                    TextBox2.Text = "Козирог"
                Else
                    TextBox2.Text = "грешка"
                End If
        End Select
    End Sub
End Class

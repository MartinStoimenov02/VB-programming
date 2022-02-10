Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, i, f, g, h, j As Integer
        a = Int((2 * Rnd()) + 1)
        b = Int((2 * Rnd()) + 1)
        j = Int((10 * Rnd()) + 1)
        If a = 1 Then
            a = 0
            If b = 1 Then
                b = 100
                c = 200
                d = 100
                f = 0
                g = 200
                h = 200
                i = 200
            ElseIf b = 2 Then
                b = 200
                c = 200
                d = 100
                f = 0
                g = 100
                h = 200
                i = 200
            End If
        ElseIf a = 2 Then
            a = 200
            If b = 1 Then
                b = 100
                c = 0
                d = 100
                f = 0
                g = 200
                h = 200
                i = 200
            ElseIf b = 2 Then
                b = 200
                c = 0
                d = 100
                f = 0
                g = 200
                h = 200
                i = 100
            End If
        End If
        Button1.Location = New Point(a, b)
        Button2.Location = New Point(c, d)
        Button3.Location = New Point(f, g)
        Button4.Location = New Point(h, i)
        If j = 1 Then
            Label1.Text = "В кой град и коя година е създаден българският завод 'РЕСПРОМ' (Велико Търново)?"
            Button1.Text = "Търново, 1960 г."
            Button2.Text = "Правец, 1972 г."
            Button3.Text = "Пловдив, 1962 г."
            Button4.Text = "Варна, 1968 г."
        ElseIf j = 2 Then
            Label1.Text = "Какво произвежда българската фирма 'БАЛКАНТОН'?"
            Button1.Text = "Мизукални носители"
            Button2.Text = "Грамофони"
            Button3.Text = "Усилватели"
            Button4.Text = "Телевизори"
        ElseIf j = 3 Then
            Label1.Text = "В заводите на коя българска компания и през коя година, започва производството на радиокасетофон 'ОКТАВА'?"
            Button1.Text = "Велико Търново, 1975 г."
            Button2.Text = "Перла, 1960 г."
            Button3.Text = "Велико Търново, 1960 г."
            Button4.Text = "Балкантон, 1975 г."
        ElseIf j = 4 Then
            Label1.Text = "Кой е първият български телевизор и от коя година е?"
            Button1.Text = "Опера, 1960 г."
            Button2.Text = "Велико Търново, 1975 г."
            Button3.Text = "Орион, 1958 г."
            Button4.Text = "Голдстар, 1945 г."
        ElseIf j = 5 Then
            Label1.Text = "По модел на кой модел чуждестранни компютри е направен 'ПРАВЕЦ 8С?"
            Button1.Text = "Apple II"
            Button2.Text = "Apple I"
            Button3.Text = "Commodore 64"
            Button4.Text = "Друг"
        ElseIf j = 6 Then
            Label1.Text = "През 1985 г.в дн. ТУ, София се произвежда първия компютър, служещ за обучение ЕМК. Какво ознава съкращението?"
            Button1.Text = "Едноплатков микрокомпютър"
            Button2.Text = "Едноличен малък компютър"
            Button3.Text = "Електро-магнитен компютър"
            Button4.Text = "Евтин малък компютър"
        ElseIf j = 7 Then
            Label1.Text = "Коя фирма, произвеждаща от 20-ти век готварски печки, продължава и до днес?"
            Button1.Text = "Раховец"
            Button2.Text = "Елдом"
            Button3.Text = "Дипломат"
            Button4.Text = "Мечта"
        ElseIf j = 8 Then
            Label1.Text = "Елпром Варна произвежда първият български бойлер ЕБО. През коя година?"
            Button1.Text = "1960 г."
            Button2.Text = "1964 г."
            Button3.Text = "1958 г."
            Button4.Text = "1968 г."
        ElseIf j = 9 Then
            Label1.Text = "През 1965 г. Елпром Варна произвежда 'ЛЪЧ'. Какво представлява?"
            Button1.Text = "Отоплителна печка"
            Button2.Text = "Бойлер"
            Button3.Text = "Готварска печка"
            Button4.Text = "Друго"
        ElseIf j = 10 Then
            Label1.Text = "През на 70-те югославско предприятие дава лиценз на българия за производство на пералня 'ПЕРЛА'. В кой завод?"
            Button1.Text = "Елпром, Варна"
            Button2.Text = "Респром, Търново"
            Button3.Text = "Правец"
            Button4.Text = "Друг"
        ElseIf j = 11 Then
            Label1.Text = "През 1965 г. е създаден първия български калкулатор. Кой е той?"
            Button1.Text = "Елка-6521"
            Button2.Text = "Елка-1300"
            Button3.Text = "Касио"
            Button4.Text = "Шарп"
        ElseIf j = 12 Then
            Label1.Text = "Правец 82 е направен по копие на?"
            Button1.Text = "Apple I"
            Button2.Text = "Apple II"
            Button3.Text = "Commodore 64"
            Button4.Text = "Друг"
        ElseIf j = 13 Then
            Label1.Text = "Какво значи съкращението ИМКО?"
            Button1.Text = "Индивидуален Микро-компютър"
            Button2.Text = "Иван Марангозов копирал оригинала"
            Button3.Text = "Индустриален международен конкурс по оптика"
            Button4.Text = "Индивидуална машина за копиране"
        ElseIf j = 13 Then
            Label1.Text = "Какво значи съкращението ИМКО?"
            Button1.Text = "Индивидуален Микро-компютър"
            Button2.Text = "Иван Марангозов копирал оригинала"
            Button3.Text = "Индустриален международен конкурс по оптика"
            Button4.Text = "Индивидуална машина за копиране"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        form2.show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        form2.show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        form2.show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

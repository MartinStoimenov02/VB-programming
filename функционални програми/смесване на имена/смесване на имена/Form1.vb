Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a(9) As String
        Dim b(9) As String
        Dim c(9) As String
        a(0) = "Мартин"
        a(1) = "Крум"
        a(2) = "Анастасий"
        a(3) = "Ивелин"
        a(4) = "Йоан"
        a(5) = "Христо"
        a(6) = "Радослав"
        a(7) = "Кристиян"
        a(8) = "Ник"
        a(9) = "Георги"
        b(0) = "Георгиев"
        b(1) = "Радославов"
        b(2) = "Иванов"
        b(3) = "Йовков"
        b(4) = "Димитров"
        b(5) = "Борисов"
        b(6) = "Пламенов"
        b(7) = "Костадинов"
        b(8) = "Иванов"
        b(9) = "Петков"
        c(0) = "Стоименов"
        c(1) = "Султов"
        c(2) = "Севов"
        c(3) = "Джантов"
        c(4) = "Митрев"
        c(5) = "Борисов"
        c(6) = "Тодоров"
        c(7) = "Христов"
        c(8) = "Райчев"
        c(9) = "Петров"
        Dim d As String
        Dim h As String
        Dim f As String
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
        If Label1.Text = 0 Then
            d = a(0)
        ElseIf Label1.Text = 1 Then
            d = a(1)
        ElseIf Label1.Text = 2 Then
            d = a(2)
        ElseIf Label1.Text = 3 Then
            d = a(3)
        ElseIf Label1.Text = 4 Then
            d = a(4)
        ElseIf Label1.Text = 5 Then
            d = a(5)
        ElseIf Label1.Text = 6 Then
            d = a(6)
        ElseIf Label1.Text = 7 Then
            d = a(7)
        ElseIf Label1.Text = 8 Then
            d = a(8)
        ElseIf Label1.Text = 9 Then
            d = a(9)
        End If
        If Label2.Text = 0 Then
            h = b(0)
        ElseIf Label2.Text = 1 Then
            h = b(1)
        ElseIf Label2.Text = 2 Then
            h = b(2)
        ElseIf Label2.Text = 3 Then
            h = b(3)
        ElseIf Label2.Text = 4 Then
            h = b(4)
        ElseIf Label2.Text = 5 Then
            h = b(5)
        ElseIf Label2.Text = 6 Then
            h = b(6)
        ElseIf Label2.Text = 7 Then
            h = b(7)
        ElseIf Label2.Text = 8 Then
            h = b(8)
        ElseIf Label2.Text = 9 Then
            h = b(9)
        End If
        If Label3.Text = 0 Then
            f = c(0)
        ElseIf Label3.Text = 1 Then
            f = c(1)
        ElseIf Label3.Text = 2 Then
            f = c(2)
        ElseIf Label3.Text = 3 Then
            f = c(3)
        ElseIf Label3.Text = 4 Then
            f = c(4)
        ElseIf Label3.Text = 5 Then
            f = c(5)
        ElseIf Label3.Text = 6 Then
            f = c(6)
        ElseIf Label3.Text = 7 Then
            f = c(7)
        ElseIf Label3.Text = 8 Then
            f = c(8)
        ElseIf Label3.Text = 9 Then
            f = c(9)
        End If
        TextBox1.Text = d & h & f
    End Sub
End Class


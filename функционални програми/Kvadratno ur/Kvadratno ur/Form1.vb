Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label12.Visible = False
    End Sub

    Private Sub ИзчистиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзчистиToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label12.Visible = False
    End Sub

    Private Sub РестартирайToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РестартирайToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub ИзходToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзходToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        If (a = 0) Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = True
            Label8.Visible = True
            Label12.Visible = True
            Label7.Text = "Когато а=0, тогава квадратното уравнение става линейно"
            Label12.Text = b / a
        Else
            d = (b * b) - 4 * a * c
            Label1.Visible = True
            Label2.Visible = True
            Label2.Text = d
            If (d > 0) Then
                Label7.Visible = False
                Label8.Visible = False
                Label12.Visible = False
                Label3.Visible = True
                Label3.Text = "x1="
                Label4.Text = "x2="
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label5.Text = (-b + Math.Sqrt(d)) / (2 * a)
                Label6.Text = (-b - Math.Sqrt(d)) / (2 * a)
            End If
            If (d = 0) Then
                Label6.Visible = False
                Label4.Visible = True
                Label3.Visible = True
                Label5.Visible = True
                Label4.Text = "Когато d=0, тогава двата x са равни, тоест може да ги запишем и като един"
                Label5.Text = (-b) / (2 * a)
            End If
            If (d < 0) Then
                Label7.Visible = False
                Label8.Visible = False
                Label12.Visible = False
                Label3.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = False
                Label6.Visible = False
                Label3.Text = "Няма решение"
                Label4.Text = "Няма решение"
            End If
        End If
    End Sub
End Class

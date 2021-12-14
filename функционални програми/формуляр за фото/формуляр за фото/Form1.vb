Public Class Form1
    Dim P9, P10, P13, P15, Sum As Single
    Dim Br As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> " " Then
            P9 = 0.2 * Val(TextBox1.Text)
        Else
            P9 = 0
        End If
        If TextBox2.Text <> " " Then
            P10 = 0.25 * Val(TextBox2.Text)
        Else
            P10 = 0
        End If
        If TextBox3.Text <> " " Then
            P13 = 0.35 * Val(TextBox3.Text)
        Else
            P13 = 0
        End If
        If TextBox4.Text <> " " Then
            P15 = 0.55 * Val(TextBox4.Text)
        Else
            P15 = 0
        End If
        Sum = P9 + P10 + P13 + P15
        Br = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
        Label7.Text = FormatCurrency(Sum)
    End Sub
End Class

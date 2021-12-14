Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim InaRow As Integer = 0
        Dim Count As Integer = 0
        Dim RanNum As Integer = 0
        Dim MyRandomGenerator As System.Random
        MyRandomGenerator = New System.Random
        Count = 0
        InaRow = 0
        TextBox2.Text = ""
        Do Until InaRow = Val(TextBox1.Text)
            RanNum = MyRandomGenerator.Next(0, 2)
            Count = Count + 1
            If RanNum = 1 Then
                InaRow = InaRow + 1
            Else
                InaRow = 0
            End If
            If Count > 500000 Then
                MessageBox.Show("possible loop - 500,000 random numbers processed - program is ending")
                Exit Sub
            End If
        Loop
        TextBox2.Text = Count
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class

Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 80 Then
            MessageBox.Show("ОСТАВАТ 10 МИНУТИ!!!")
        End If
        If ProgressBar1.Value = 90 Then
            MessageBox.Show("ОСТАВАТ 5 МИНУТИ!!!")
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("ПОЧИВКА 10 МИНУТИ!!!")
            Timer2.Start()
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(-1)
        If ProgressBar1.Value = 20 Then
            MessageBox.Show("ОСТАВАТ 10 МИНУТИ!!!")
        End If
        If ProgressBar1.Value = 10 Then
            MessageBox.Show("ОСТАВАТ 5 МИНУТИ!!!")
        End If
        If ProgressBar1.Value = 0 Then
            Timer2.Stop()
            MessageBox.Show("ПОЧИВКА 10 МИНУТИ!!!")
            Timer1.Start()
        End If
    End Sub
End Class

Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim seconds As Integer = Now.Second
        Dim minutes As Integer = Now.Minute
        Dim hours As Integer = Now.Hour
        Time.Text = Now
    End Sub
End Class

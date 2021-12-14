Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim title As String
        Dim i As Integer
        Dim chisla(10) As Double
        For i = 1 To 10 Step 1
            title = "chislo" + CStr(i)
            chisla(i) = InputBox("chisla:", title)
            If (chisla(i) Mod 2 = 0) Or (chisla(i) Mod 3 = 0) Or (chisla(i) Mod 5 = 0) Or (chisla(i) < 2) Then
            Else
                ListBox1.Items.Add(chisla(i))
            End If
            If (chisla(i) = 2) Or (chisla(i) = 3) Or (chisla(i) = 5) Then
                ListBox1.Items.Add(chisla(i))
            End If
        Next i
    End Sub
End Class

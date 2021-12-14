Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim k As Integer = 0
        Dim LoopStart As Integer = 0
        Dim LoopStop As Integer = 0
        Dim TotalDeposits As Single = 0
        Dim AnnualDeposit As Single = 0
        Dim InterestRate As Single = 0
        Dim IRAAccount As Single = 0
        Dim Profit As Single = 0
        Dim lihva As Single = 0
        ListBox1.Items.Add("Възраст" & " " & " " & "Депозит" & "   " & "Баланс" & "          " & "Печалба" & "   " & "данък" & vbNewLine & vbNewLine)
        LoopStart = Val(TextBox1.Text)
        LoopStop = Val(TextBox2.Text)
        AnnualDeposit = Val(TextBox3.Text)
        InterestRate = Val(TextBox4.Text) / 100
        For k = LoopStart To LoopStop
            TotalDeposits = TotalDeposits + AnnualDeposit
            IRAAccount = IRAAccount + AnnualDeposit
            IRAAccount = IRAAccount * (1 + InterestRate)
            Profit = IRAAccount - TotalDeposits
            lihva = Profit / 4
            ListBox1.Items.Add(k & "              " & FormatCurrency(TotalDeposits) & "    " & FormatCurrency(IRAAccount) & "     " & FormatCurrency(Profit) & "    " & FormatCurrency(lihva) & vbNewLine)
        Next
    End Sub
End Class
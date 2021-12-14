Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stt, nvt, stv, nvv, dn, nst, varh, konst, ost, dos,
            nos, vos, konsv, pit, prom, pitos, promos, osv, pr, max, min, a, os As Double
        stt = TextBox1.Text
        nvt = TextBox2.Text
        stv = TextBox11.Text
        nvv = TextBox12.Text
        pr = TextBox21.Text
        konst = nvt - stt
        dn = konst / 2
        nst = konst / 3
        varh = konst / 6
        dn = Math.Round(dn, 0)
        nst = Math.Round(nst, 0)
        varh = Math.Round(varh, 0)
        TextBox9.Text = konst
        TextBox3.Text = dn
        TextBox4.Text = nst
        TextBox5.Text = varh
        dos = dn * 0.23
        dos = Math.Round(dos, 2)
        nos = nst * 0.13
        nos = Math.Round(nos, 2)
        vos = varh * 0.25
        vos = Math.Round(vos, 2)
        ost = dos + nos + vos
        ost = Math.Round(ost, 2)
        TextBox6.Text = dos
        TextBox7.Text = nos
        TextBox8.Text = vos
        TextBox10.Text = ost
        konsv = nvv - stv
        pit = konsv / 2
        prom = konsv / 2
        pitos = pit * 2.58
        promos = prom * 2.65
        osv = pitos + promos
        konsv = Math.Round(konsv, 0)
        pit = Math.Round(pit, 0)
        prom = Math.Round(prom, 0)
        pitos = Math.Round(pitos, 2)
        promos = Math.Round(promos, 2)
        osv = Math.Round(osv, 2)
        TextBox13.Text = pit
        TextBox14.Text = prom
        TextBox17.Text = konsv
        TextBox15.Text = pitos
        TextBox16.Text = promos
        TextBox18.Text = osv
        max = (pr / 10) + konst
        min = konst - (pr / 10)
        If min < konst > max Then
            a = 10000
        Else
            a = 0

        End If
        TextBox19.Text = a
        os = osv + ost + a
        TextBox20.Text = os
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

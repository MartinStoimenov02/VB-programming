Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Label4.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False


    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            PictureBox1.Top = PictureBox1.Top - 3
        End If
        If e.KeyCode = Keys.A Then
            PictureBox1.Left = PictureBox1.Left - 3
        End If
        If e.KeyCode = Keys.S Then
            PictureBox1.Top = PictureBox1.Top + 3
        End If
        If e.KeyCode = Keys.D Then
            PictureBox1.Left = PictureBox1.Left + 3
        End If
        If e.KeyCode = Keys.NumPad8 Then
            PictureBox2.Top = PictureBox2.Top - 3
        End If
        If e.KeyCode = Keys.NumPad4 Then
            PictureBox2.Left = PictureBox2.Left - 3
        End If
        If e.KeyCode = Keys.NumPad5 Then
            PictureBox2.Top = PictureBox2.Top + 3
        End If
        If e.KeyCode = Keys.NumPad6 Then
            PictureBox2.Left = PictureBox2.Left + 3
        End If
        If PictureBox1.Bounds.IntersectsWith(Label4.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label5.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label6.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label7.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label8.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label9.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label10.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label11.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label12.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label3.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label14.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label15.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label16.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label17.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label18.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label19.Bounds) Then
            MsgBox("Вие достигнахте докрая и спечелихте")
            Application.Exit()
        End If
        If PictureBox1.Bounds.IntersectsWith(Label20.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label21.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox1.Bounds.IntersectsWith(Label4.Bounds) Then
            PictureBox1.Top = 20
            PictureBox1.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If



        If PictureBox2.Bounds.IntersectsWith(Label4.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label5.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label6.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label7.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label8.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label9.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label10.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label11.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label12.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label3.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label14.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label15.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label16.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label17.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label18.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label19.Bounds) Then
            MsgBox("Вие достигнахте докрая и спечелихте")
            Application.Exit()
        End If
        If PictureBox2.Bounds.IntersectsWith(Label20.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label21.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If
        If PictureBox2.Bounds.IntersectsWith(Label4.Bounds) Then
            PictureBox2.Top = 20
            PictureBox2.Left = 10
            MsgBox("Вие докоснахте една от стените и започвате отначало със същото емоджи")
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Text = ""
        PictureBox2.Visible = False
        PictureBox1.Top = 20
        PictureBox1.Left = 10
        Label4.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Top = 20
        PictureBox2.Left = 10
        Label4.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
    End Sub
End Class

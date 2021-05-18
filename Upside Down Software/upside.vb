Public Class upside
    Function upsidedown_fun(ByVal got_text As String)
        Const number = 84
        Dim kiran(number) As String
        Dim upsid(number) As String
        Dim initail, added, appendd As String
        appendd = 0
        added = ""
        kiran = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " ", "&", "?", Chr(34), "!", ";", ".", "*", "(", ")", "+", "=", "-", "\", "~", "$", "<", ">", "/", "@", "'", ":"}
        upsid = {"ɐ", "q", "ɔ", "p", "ǝ", "ɟ", "ɓ", "ɥ", "ı", "ɾ", "ʞ", "l", "ɯ", "u", "o", "d", "b", "ɹ", "s", "ʇ", "n", "ʌ", "ʍ", "x", "ʎ", "z", "ɐ", "𐐒", "Ɔ", "ᗡ", "Ǝ", "Ⅎ", "ɓ", "H", "I", "ſ", "ʞ", "˥", "W", "N", "O", "Ԁ", "Ό", "ᴚ ", "S ", "⊥", "∩", "Λ", "M", "X", "⅄", "Z", "Ɩ", "ᘔ", "Ɛ", "ㄣ", "ϛ", "9", "ㄥ", "8", "6", "0", " ", "⅋", "¿", "„", "¡", "؛", "˙", "*", ")", "(", "+", "=", "-", "/", "~", "$", ">", "<", "\", "@", "‚", ":"}
        'DB068ㄥ9ϛㄣƐᘔƖ z ʎ x ʍ ʌ n ʇ s ɹ b d o u ɯ l ʞ ɾ ᴉ ɥ ƃ ɟ ǝ p ɔ q ɐ' Z ⅄ X M Λ ∩ ┴ S ᴚ Ό Ԁ O N W ˥ ʞ ' ſ I H פ Ⅎ Ǝ p Ɔ 𐐒 ∀ 	⅋‾¿¡„,˙'؛
        For i = 1 To Len(txt_nor.Text)
            initail = Mid(txt_nor.Text, i, 1)
            For j = 0 To (number - 1)
                If initail = kiran(j) Then
                    added = upsid(j) + added
                End If
            Next
        Next
        Return added
    End Function

    Private Sub Copy_to_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_to.Click
        If txt_upd.Text <> "" Then
            '  My.Computer.Network.DownloadFile("http://downloads.kiranpantha.com.np/uds.zip", "sth.zip")
            My.Computer.Clipboard.SetText(txt_upd.Text)
            MsgBox("The Text .Has Been Copied To the ClipBaord", vbInformation, "Copied!")
        Else
            MsgBox("No data avialable to copy", vbInformation, "Not Copied!")
        End If
    End Sub
    Private Sub close_img1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles close_img1.MouseHover
        close_img1.Image = My.Resources.bright_close1
    End Sub

    Private Sub close_img1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles close_img1.MouseLeave
        close_img1.Image = My.Resources.close1
    End Sub

    Private Sub close_img1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles close_img1.MouseMove
        close_img1.Image = My.Resources.bright_close1
    End Sub

    Private Sub close_img_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles close_img.MouseLeave
        close_img.Image = My.Resources.close
    End Sub

    Private Sub close_img_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles close_img.MouseMove
        close_img.Image = My.Resources.bright_close
    End Sub

    Private Sub Timer_upside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_upside.Tick
        txt_upd.Text = upsidedown_fun(txt_nor.Text)
    End Sub

    Private Sub close_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img.Click
        Me.Close()
        main.Close()
    End Sub

    Private Sub close_img1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_img1.Click
        Me.Close()
        main.Close()
    End Sub

    Private Sub open_about_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_about.Tick
        If Me.Width < 500 Then
            Me.Width = Me.Width + 2
        Else
            Pic_con.Visible = True
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub upside_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub upside_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
       move_window(sender, e)
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        move_window(sender, e)
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        move_window(sender, e)
    End Sub
    Sub move_window(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Kiran_xx.Text = "" Then
                Kiran_xx.Text = e.X
            End If
            If kiran_yy.Text = "" Then
                kiran_yy.Text = e.Y
            End If
            If Asc(Kiran_xx.Text) < e.X Then
                Me.Left = Me.Left + 1
            Else
                Me.Left = Me.Left - 1
            End If
            If Asc(kiran_yy.Text) < e.Y Then
                Me.Top = Me.Top + 1
            Else
                Me.Top = Me.Top - 1
            End If
            Kiran_xx.Text = e.X
            kiran_yy.Text = e.Y
        End If
    End Sub

    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        move_window(sender, e)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Pic_con_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_con.Click

    End Sub
End Class
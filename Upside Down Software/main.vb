Public Class main

    Private Sub open_next_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_next.Tick
        upside.Show()
        open_next.Enabled = False
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
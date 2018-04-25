Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As String
        Dim a, b, c, d As Double

        n = txtnama.Text
        a = txtnilai1.Text
        b = txtnilai2.Text
        c = txtnilai3.Text
        d = (a + b + c) / 3
        txtrata.Text = d
        If txtrata.Text > 80 Then
            txthadiah.Text = " Rp 10 jt"
        ElseIf txtrata.Text > 70 Then
            txthadiah.Text = " Rp 7.5 jt"
        Else
            txthadiah.Text = " Hanya Dapat Sertifikat"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtnama.Text = ""
        txtnilai1.Text = " "
        txtnilai2.Text = ""
        txtnilai3.Text = ""
        txtrata.Text = ""
        txthadiah.Text = " "
        txtnama.Focus()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class

Public Class Form2

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub



    Private Sub txthitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthitung.Click
        Dim a, b, c, d, z, f, g, h, total, bobot As Double
        a = txtnilaikecil.Text
        b = txtnilaibesar.Text
        c = txtnilaiuts.Text
        d = txtnilauas.Text
        z = txtbobotkecil.Text
        f = txtbobotbesar.Text
        g = txtbobotuts.Text
        h = txtbobotuas.Text

        total = ((a * z / 100) + (b * f / 100) + (c * g / 100) + (d * h / 100))
        bobot = (z + f + g + h)
        txttotal.Text = total
        bobot = (z + f + g + h)
        If bobot < "100" Then
            MsgBox("Bobot Salah")
            txttotal.Text = ""

        ElseIf bobot > "100" Then
            MsgBox("Bobot Salah")

            txttotal.Text = ""

        Else

            If txttotal.Text > 80 Then
                txtgrade.Text = " A"
            ElseIf txttotal.Text > 70 Then
                txtgrade.Text = " B"
            ElseIf txttotal.Text > 60 Then
                txtgrade.Text = " C"
            ElseIf txttotal.Text > 50 Then
                txtgrade.Text = " D"
            Else
                txtgrade.Text = "E"


            End If
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
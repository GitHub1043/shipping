Public Class Form1

    Private Sub btnShip_Click(sender As Object, e As EventArgs) Handles btnShip.Click
        '1) Variables
        Dim intAspar As Integer
        Dim intPacks As Integer
        Dim intLeft As Integer
        Const PACKSIZE As Integer = 12

        '2) Set Values
        intAspar = Val(txtAspar.Text)

        '3) Calculate
        intPacks = intAspar \ PACKSIZE
        intLeft = intAspar Mod PACKSIZE

        '4) Display
        lblPacks.Text = "Packs: " & intPacks
        lblLeft.Text = "Leftover: " & intLeft

    End Sub
End Class

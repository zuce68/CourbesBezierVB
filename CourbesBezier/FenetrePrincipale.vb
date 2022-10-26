Imports System.Math


Public Class FenetrePrincipale
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles plan.Click
        Dim em As MouseEventArgs
        em = e

        MessageBox.Show(em.X.ToString + ";" + em.Y.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myCourbe As New Courbe

        pointData.Items.Add("Pdéb : " + "[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]")
        pointData.Items.Add("Pfin : " + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]")
        pointData.Items.Add("Ptdéb : " + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]")
        pointData.Items.Add("Ptfin : " + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]")

        myCourbe.points(0, 0) = Xdeb.Value
        myCourbe.points(0, 1) = Ydeb.Value
        myCourbe.points(1, 0) = Xfin.Value
        myCourbe.points(1, 1) = Yfin.Value
        myCourbe.points(2, 0) = Xtdeb.Value
        myCourbe.points(2, 1) = Ytdeb.Value
        myCourbe.points(3, 0) = Xtfin.Value
        myCourbe.points(3, 1) = Ytfin.Value


        Dim pic As Bitmap = New System.Drawing.Bitmap(1000, 1000)
        Dim circleColor As New Color
        circleColor = randomColor()

        For Index As Integer = 0 To 3 Step 1
            Dim x1, y1, r1, r2 As Integer
            x1 = ((myCourbe.points(Index, 0) * 39) / 0.2) + 204
            y1 = 202 - ((myCourbe.points(Index, 1) * 39) / 0.2)
            r1 = 2
            r2 = 2

            Dim th As Double
            Dim nx, ny As Integer

            For th = 0 To 360 Step 0.5
                nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                pic.SetPixel(nx, ny, circleColor)
                plan.Image = pic
            Next th
        Next


    End Sub


    Private Function randomColor() As Color
        Dim rnd As New Random()
        Randomize()
        Return Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Function

    Private Sub pointData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pointData.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label10.Click

    End Sub
End Class

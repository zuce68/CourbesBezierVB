Imports System.Math


Public Class FenetrePrincipale
    Dim myCourbe As Courbe
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles plan.Click
        Dim em As MouseEventArgs
        em = e

        MessageBox.Show(em.X.ToString + ";" + em.Y.ToString)
    End Sub

    Private Sub plan_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles plan.Paint
        ''Calcul de la courbe 
        'If myCourbe IsNot Nothing Then

        '    Dim myGraph As Graphics
        '    Dim myPen As New Pen(Color.Red)
        '    Dim x1, y1 As Integer

        '    Dim xt(nbSegements.Value * 2), yt(nbSegements.Value * 2) As Decimal
        '    Dim pointeur, xBefore, yBefore As Integer
        '    pointeur = 0

        '    myGraph = plan.CreateGraphics()

        '    For t = 0 To 1 Step (1 / nbSegements.Value)
        '        xt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 0) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 0) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 0) + (t ^ 3) * myCourbe.points(1, 0)
        '        yt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 1) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 1) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 1) + (t ^ 3) * myCourbe.points(1, 1)

        '        x1 = ((xt(pointeur) * 39) / 0.2) + 204
        '        y1 = 202 - ((yt(pointeur) * 39) / 0.2)

        '        If pointeur > 0 Then
        '            xBefore = ((xt(pointeur - 1) * 39) / 0.2) + 204
        '            yBefore = 202 - ((yt(pointeur - 1) * 39) / 0.2)
        '            Dim point1 As New Point(xBefore, yBefore)
        '            Dim point2 As New Point(x1, y1)
        '            myGraph.DrawLine(myPen, point1, point2)
        '        End If

        '        pointeur += 1
        '    Next t

        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myCourbe = New Courbe

        Dim th As Double
        Dim nx, ny As Integer
        Dim pic As Bitmap = New System.Drawing.Bitmap(1000, 1000)
        Dim circleColor As New Color
        Dim x1, y1, r1, r2 As Integer



        Xdeb.Value = -0.1
        Ydeb.Value = 0.2
        Xfin.Value = 0.6
        Yfin.Value = -0.24
        Xtdeb.Value = 0.68
        Ytdeb.Value = 0.78
        Xtfin.Value = -0.15
        Ytfin.Value = 0.06


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

        circleColor = randomColor()

        For Index As Integer = 0 To 3 Step 1

            x1 = ((myCourbe.points(Index, 0) * 39) / 0.2) + 204
            y1 = 202 - ((myCourbe.points(Index, 1) * 39) / 0.2)
            r1 = 2
            r2 = 2



            For th = 0 To 360 Step 0.5
                nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                pic.SetPixel(nx, ny, circleColor)
                plan.Image = pic
            Next th
        Next



        Dim xt(nbSegements.Value * 2), yt(nbSegements.Value * 2) As Decimal
        Dim pointeur, xBefore, yBefore As Integer
        pointeur = 0
        r1 = 1
        r2 = 1

        For t = 0 To 1 Step (1 / nbSegements.Value)
            xt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 0) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 0) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 0) + (t ^ 3) * myCourbe.points(1, 0)
            yt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 1) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 1) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 1) + (t ^ 3) * myCourbe.points(1, 1)

            x1 = ((xt(pointeur) * 39) / 0.2) + 204
            y1 = 202 - ((yt(pointeur) * 39) / 0.2)

            For th = 0 To 360 Step 0.5
                nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                pic.SetPixel(nx, ny, circleColor)
                plan.Image = pic
            Next th

            pointeur += 1
        Next t








    End Sub


    Private Function randomColor() As Color
        Dim rnd As New Random()
        Randomize()
        Return Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Function

    Private Sub FenetrePrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
End Class

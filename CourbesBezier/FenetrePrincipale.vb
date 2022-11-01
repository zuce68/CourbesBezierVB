Imports System.Math


Public Class FenetrePrincipale

    Dim index As Integer
    Dim deb, fin, tdeb, tfin As Boolean

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles plan.Click
        Dim em As MouseEventArgs
        em = e
        Dim x, y As Decimal

        If deb = True Then
            Xdeb.Value = ((em.X - 204) * 0.2) / 39
            Ydeb.Value = -(((em.Y - 202) * 0.2) / 39)
        End If
        If fin = True Then
            Xfin.Value = ((em.X - 204) * 0.2) / 39
            Yfin.Value = -(((em.Y - 202) * 0.2) / 39)
        End If
        If tdeb = True Then
            Xtdeb.Value = ((em.X - 204) * 0.2) / 39
            Ytdeb.Value = -(((em.Y - 202) * 0.2) / 39)
        End If
        If tfin = True Then
            Xtfin.Value = ((em.X - 204) * 0.2) / 39
            Ytfin.Value = -(((em.Y - 202) * 0.2) / 39)
        End If

        deb = False
        fin = False
        tdeb = False
        tfin = False
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
    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        If index <> -1 Then
            'pointData.Items.Item(index) = "[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]" + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]" + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]" + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]"
            Dim myItem = pointData.Items.Item(index)
            myItem.Tag.points(0, 0) = Xdeb.Value
            myItem.Tag.points(0, 1) = Ydeb.Value
            myItem.Tag.points(1, 0) = Xfin.Value
            myItem.Tag.points(1, 1) = Yfin.Value
            myItem.Tag.points(2, 0) = Xtdeb.Value
            myItem.Tag.points(2, 1) = Ytdeb.Value
            myItem.Tag.points(3, 0) = Xtfin.Value
            myItem.Tag.points(3, 1) = Ytfin.Value
            myItem.Tag.segmentDefine = nbSegements.Value

            Afficher(myItem.Tag)

        End If
    End Sub

    Private Sub Afficher(myCourbe As Courbe)

        If myCourbe IsNot Nothing Then
            Dim th As Double
            Dim nx, ny As Integer
            Dim pic As Bitmap = New System.Drawing.Bitmap(1000, 1000)
            Dim x1, y1, r1, r2 As Integer

            For Index As Integer = 0 To 3 Step 1

                x1 = ((myCourbe.points(Index, 0) * 39) / 0.2) + 204
                y1 = 202 - ((myCourbe.points(Index, 1) * 39) / 0.2)
                r1 = 2
                r2 = 2



                For th = 0 To 360 Step 0.5
                    nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                    ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                    pic.SetPixel(nx, ny, myCourbe.colorDefine)
                    plan.Image = pic
                Next th
            Next



            Dim xt(myCourbe.segmentDefine * 2), yt(myCourbe.segmentDefine * 2) As Decimal
            Dim pointeur As Integer
            pointeur = 0
            r1 = 1
            r2 = 1

            For t = 0 To 1 Step (1 / myCourbe.segmentDefine)
                xt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 0) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 0) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 0) + (t ^ 3) * myCourbe.points(1, 0)
                yt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 1) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 1) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 1) + (t ^ 3) * myCourbe.points(1, 1)

                x1 = ((xt(pointeur) * 39) / 0.2) + 204
                y1 = 202 - ((yt(pointeur) * 39) / 0.2)

                For th = 0 To 360 Step 0.5
                    nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                    ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                    pic.SetPixel(nx, ny, myCourbe.colorDefine)
                    plan.Image = pic
                Next th

                pointeur += 1
            Next t

        End If
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim myCourbe As Courbe
        myCourbe = New Courbe

        Xdeb.Value = -0.1
        Ydeb.Value = 0.2
        Xfin.Value = 0.6
        Yfin.Value = -0.24
        Xtdeb.Value = 0.68
        Ytdeb.Value = 0.78
        Xtfin.Value = -0.15
        Ytfin.Value = 0.06
        nbSegements.Value = 100


        'pointData.Items.Add("[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]" + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]" + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]" + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]")



        myCourbe.points(0, 0) = Xdeb.Value
        myCourbe.points(0, 1) = Ydeb.Value
        myCourbe.points(1, 0) = Xfin.Value
        myCourbe.points(1, 1) = Yfin.Value
        myCourbe.points(2, 0) = Xtdeb.Value
        myCourbe.points(2, 1) = Ytdeb.Value
        myCourbe.points(3, 0) = Xtfin.Value
        myCourbe.points(3, 1) = Ytfin.Value
        myCourbe.segmentDefine = nbSegements.Value

        myCourbe.colorDefine = randomColor()

        Dim myItem = New ListViewItem

        myItem.Text = myCourbe.myPoints
        myItem.Tag = myCourbe
        myItem.BackColor = myCourbe.colorDefine



        pointData.Items.Add(myItem)


        Afficher(myCourbe)

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

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        fin = True
    End Sub

    Private Sub btnTdeb_Click(sender As Object, e As EventArgs) Handles btnTdeb.Click
        tdeb = True
    End Sub

    Private Sub btnTfin_Click(sender As Object, e As EventArgs) Handles btnTfin.Click
        tfin = True
    End Sub

    Private Sub pointData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pointData.ItemSelectionChanged

        Dim myItem As ListViewItem

        myItem = sender.FocusedItem

        Afficher(myItem.Tag)

        Xdeb.Value = myItem.Tag.points(0, 0)
        Ydeb.Value = myItem.Tag.points(0, 1)
        Xfin.Value = myItem.Tag.points(1, 0)
        Yfin.Value = myItem.Tag.points(1, 1)
        Xtdeb.Value = myItem.Tag.points(2, 0)
        Ytdeb.Value = myItem.Tag.points(2, 1)
        Xtfin.Value = myItem.Tag.points(3, 0)
        Ytfin.Value = myItem.Tag.points(3, 1)
        nbSegements.Value = myItem.Tag.segmentDefine

        index = myItem.Index

        modifier.Visible = True
        supprimer.Visible = True
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        If index <> -1 Then
            'pointData.Items.Item(index) = "[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]" + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]" + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]" + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]"
            pointData.Items.RemoveAt(index)

        End If
    End Sub

    Private Sub btnDeb_Click(sender As Object, e As EventArgs) Handles btnDeb.Click
        deb = True
    End Sub
End Class

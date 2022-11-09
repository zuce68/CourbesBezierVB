Imports System.IO
Imports System.Math
Imports System.Text
Imports System.Windows.Forms.VisualStyles

Public Class FenetrePrincipale

    Dim index As Integer
    Dim deb, fin, tdeb, tfin As Boolean
    Private Sub PictureBox1_Survol(sender As Object, e As EventArgs) Handles plan.MouseMove
        Dim em As MouseEventArgs
        em = e
        Dim x, y As Decimal
        x = ((em.X - 204) * 0.2) / 39
        y = -(((em.Y - 202) * 0.2) / 39)
        lblMouse.Text = "(" + x.ToString("N2") + "," + y.ToString("N2") + ")"
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles plan.Click
        Dim em As MouseEventArgs
        em = e

        If deb = True Then
            Xdeb.Value = ((em.X - 204) * 0.2) / 39
            Ydeb.Value = -(((em.Y - 202) * 0.2) / 39)
            modifier.PerformClick()
        End If
        If fin = True Then
            Xfin.Value = ((em.X - 204) * 0.2) / 39
            Yfin.Value = -(((em.Y - 202) * 0.2) / 39)
            modifier.PerformClick()
        End If
        If tdeb = True Then
            Xtdeb.Value = ((em.X - 204) * 0.2) / 39
            Ytdeb.Value = -(((em.Y - 202) * 0.2) / 39)
            modifier.PerformClick()
        End If
        If tfin = True Then
            Xtfin.Value = ((em.X - 204) * 0.2) / 39
            Ytfin.Value = -(((em.Y - 202) * 0.2) / 39)
            modifier.PerformClick()
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
        If index <> -1 And pointData.Items.Count > 0 Then

            'pointData.Items.Item(index) = "[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]" + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]" + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]" + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]"
            Dim myItem As ListViewItem
            myItem = pointData.Items.Item(index)


            myItem.Tag.points(0, 0) = Xdeb.Value
            myItem.Tag.points(0, 1) = Ydeb.Value
            myItem.Tag.points(1, 0) = Xfin.Value
            myItem.Tag.points(1, 1) = Yfin.Value
            myItem.Tag.points(2, 0) = Xtdeb.Value
            myItem.Tag.points(2, 1) = Ytdeb.Value
            myItem.Tag.points(3, 0) = Xtfin.Value
            myItem.Tag.points(3, 1) = Ytfin.Value
            myItem.Tag.segmentDefine = nbSegements.Value




            myItem.Text = myItem.Tag.myPoints

            If pbCouleur.BackColor <> myItem.Tag.colorDefine Then
                myItem.Tag.colorDefine = pbCouleur.BackColor
            End If

            myItem.BackColor = myItem.Tag.colorDefine

            pointData.Refresh()

            Afficher(myItem.Tag)



        End If
    End Sub

    Private Sub Afficher(myCourbe As Courbe)


        If showAll.Checked = False Then
            If myCourbe IsNot Nothing Then
                Dim th As Double
                Dim nx, ny As Integer
                Dim pic As Bitmap = New System.Drawing.Bitmap(1000, 1000)
                Dim x1, y1, r1, r2 As Integer



                For Index As Integer = 0 To 3 Step 1

                    x1 = ((myCourbe.points(Index, 0) * 39) / 0.2) + 204
                    y1 = 202 - ((myCourbe.points(Index, 1) * 39) / 0.2)
                    r1 = 3
                    r2 = 3

                    For th = 0 To 360 Step 0.5
                        nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                        ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                        pic.SetPixel(nx, ny, myCourbe.colorDefine)
                        plan.Image = pic
                    Next th

                    pic.SetPixel(x1, y1, myCourbe.colorDefine)
                    plan.Image = pic
                Next



                Dim xt(myCourbe.segmentDefine * 2), yt(myCourbe.segmentDefine * 2) As Decimal
                Dim pointeur As Integer
                Dim longueur As Decimal
                pointeur = 0
                r1 = 1
                r2 = 1

                For t = 0 To 1 Step (1 / myCourbe.segmentDefine)
                    xt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 0) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 0) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 0) + (t ^ 3) * myCourbe.points(1, 0)
                    yt(pointeur) = ((1 - t) ^ 3) * myCourbe.points(0, 1) + 3 * t * ((1 - t) ^ 2) * myCourbe.points(2, 1) + 3 * (t ^ 2) * (1 - t) * myCourbe.points(3, 1) + (t ^ 3) * myCourbe.points(1, 1)

                    x1 = ((xt(pointeur) * 39) / 0.2) + 204
                    y1 = 202 - ((yt(pointeur) * 39) / 0.2)


                    If pointeur > 0 Then
                        longueur += Sqrt((xt(pointeur) - xt(pointeur - 1)) ^ 2 + (yt(pointeur) - yt(pointeur - 1)) ^ 2)
                        segment(xt(pointeur - 1), yt(pointeur - 1), xt(pointeur), yt(pointeur), myCourbe.colorDefine, pic)
                    End If

                    For th = 0 To 360 Step 10
                        nx = x1 + 2.5 * Cos(th * 22 / 7 / 180)
                        ny = y1 + 2.5 * Sin(th * 22 / 7 / 180)
                        pic.SetPixel(nx, ny, myCourbe.colorDefine)
                        plan.Image = pic
                    Next th

                    pointeur += 1
                Next t

                lblLongueur.Text = longueur.ToString("N3")
            End If
        ElseIf showAll.Checked = True Then
            Dim th As Double
            Dim nx, ny As Integer
            Dim pic As Bitmap = New System.Drawing.Bitmap(1000, 1000)
            Dim x1, y1, r1, r2 As Integer

            For Each myItem As ListViewItem In pointData.Items

                Dim courbeInList As Courbe

                courbeInList = myItem.Tag

                For Index As Integer = 0 To 3 Step 1

                    x1 = ((courbeInList.points(Index, 0) * 39) / 0.2) + 204
                    y1 = 202 - ((courbeInList.points(Index, 1) * 39) / 0.2)
                    r1 = 3
                    r2 = 3

                    For th = 0 To 360 Step 0.5
                        nx = x1 + r1 * Cos(th * 22 / 7 / 180)
                        ny = y1 + r2 * Sin(th * 22 / 7 / 180)
                        pic.SetPixel(nx, ny, courbeInList.colorDefine)
                        plan.Image = pic
                    Next th

                    pic.SetPixel(x1, y1, courbeInList.colorDefine)
                    plan.Image = pic
                Next



                Dim xt(courbeInList.segmentDefine * 2), yt(courbeInList.segmentDefine * 2) As Decimal
                Dim pointeur As Integer
                Dim longueur As Decimal
                pointeur = 0
                r1 = 1
                r2 = 1

                For t = 0 To 1 Step (1 / courbeInList.segmentDefine)
                    xt(pointeur) = ((1 - t) ^ 3) * courbeInList.points(0, 0) + 3 * t * ((1 - t) ^ 2) * courbeInList.points(2, 0) + 3 * (t ^ 2) * (1 - t) * courbeInList.points(3, 0) + (t ^ 3) * courbeInList.points(1, 0)
                    yt(pointeur) = ((1 - t) ^ 3) * courbeInList.points(0, 1) + 3 * t * ((1 - t) ^ 2) * courbeInList.points(2, 1) + 3 * (t ^ 2) * (1 - t) * courbeInList.points(3, 1) + (t ^ 3) * courbeInList.points(1, 1)

                    x1 = ((xt(pointeur) * 39) / 0.2) + 204
                    y1 = 202 - ((yt(pointeur) * 39) / 0.2)


                    If pointeur > 0 Then
                        longueur += Sqrt((xt(pointeur) - xt(pointeur - 1)) ^ 2 + (yt(pointeur) - yt(pointeur - 1)) ^ 2)
                        segment(xt(pointeur - 1), yt(pointeur - 1), xt(pointeur), yt(pointeur), courbeInList.colorDefine, pic)
                    End If

                    For th = 0 To 360 Step 10
                        nx = x1 + 2.5 * Cos(th * 22 / 7 / 180)
                        ny = y1 + 2.5 * Sin(th * 22 / 7 / 180)
                        pic.SetPixel(nx, ny, courbeInList.colorDefine)
                        plan.Image = pic
                    Next th

                    pointeur += 1
                Next t

                lblLongueur.Text = longueur.ToString("N3")
            Next
        End If
    End Sub

    Private Sub segment(ByVal x1 As Decimal, ByVal y1 As Decimal, ByVal x2 As Decimal, ByVal y2 As Decimal, ByVal Color As Color, ByRef pic As Bitmap)

        Dim pix1, piy1, pix2, piy2 As Decimal
        Dim g As Graphics = Graphics.FromImage(pic)
        Dim pen1 As New Pen(Color, 2)

        pix1 = ((x1 * 39) / 0.2) + 204
        piy1 = 202 - ((y1 * 39) / 0.2)
        pix2 = ((x2 * 39) / 0.2) + 204
        piy2 = 202 - ((y2 * 39) / 0.2)

        g.DrawLine(pen1, Convert.ToInt32(pix1), Convert.ToInt32(piy1), Convert.ToInt32(pix2), Convert.ToInt32(piy2))

        plan.Image = pic

    End Sub



    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim myCourbe As Courbe
        myCourbe = New Courbe

        'nbSegements.Value = 100


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


        If pbCouleur.BackColor <> Color.White Then
            myCourbe.colorDefine = pbCouleur.BackColor
        Else
            myCourbe.colorDefine = randomColor()
        End If

        Dim myItem = New ListViewItem

        myItem.Text = myCourbe.myPoints
        myItem.Tag = myCourbe
        myItem.BackColor = myCourbe.colorDefine
        myItem.EnsureVisible()




        pointData.Items.Add(myItem)
        pointData.Select()

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

    Private Sub nbSegements_ValueChanged(sender As Object, e As EventArgs)
        modifier.PerformClick()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lblLongueur.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblMouse.Click

    End Sub

    Private Sub Label12_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCouleur.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pbCouleur.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub nbSegements_ValueChanged_1(sender As Object, e As EventArgs) Handles nbSegements.Click
        modifier.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub InfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem1.Click
        MessageBox.Show("© Courbe de Bézier - Télécom Physique Strasbourg - A.Dotte & P.Misiuk 2022", "Informations")
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog1 As New FolderBrowserDialog
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, saveFileDialog1.SelectedPath + "\" + TimeString.Replace(":", "_") + ".jpg")
            Dim size As Size = plan.Size
            Dim btmp As New Bitmap(size.Width, size.Height)
            Dim rect As New Rectangle(0, 0, size.Width, size.Height)
            plan.DrawToBitmap(btmp, rect)
            btmp.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
            MessageBox.Show("Exportation terminée")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gpPlan.Enter

    End Sub

    Private Sub showAll_CheckedChanged(sender As Object, e As EventArgs) Handles showAll.CheckedChanged
        plan.Image = Nothing
        Afficher(Nothing)
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
        Dim saveFileDialog1 As New FolderBrowserDialog
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, saveFileDialog1.SelectedPath + "\" + "Export_" + TimeString.Replace(":", "_") + ".txt")
            Dim fs As FileStream = File.Create(FileToSaveAs)
            For Each myItem As ListViewItem In pointData.Items
                ' Add text to the file.
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(myItem.Tag.myPoints + " " + myItem.Tag.colorDefine.ToString + "|" + myItem.Tag.segmentDefine.ToString & vbCrLf)
                fs.Write(info, 0, info.Length)
            Next
            fs.Close()
            MessageBox.Show("Exportation terminée")
        End If
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(openFileDialog.FileName)
            Dim stringReader As String
            pointData.Items.Clear()
            Do
                stringReader = fileReader.ReadLine()
                If stringReader <> Nothing Then
                    Try
                        Dim A, R, G, B As String
                        Dim myCourbe As New Courbe
                        A = stringReader.Split("Color")(1).Split("[A=")(1).Split(", R")(0).Replace("A=", "")
                        R = stringReader.Split("Color")(1).Split(",")(1).Replace("R=", "")
                        G = stringReader.Split("Color")(1).Split(",")(2).Replace("G=", "")
                        B = stringReader.Split("Color")(1).Split(",")(3).Split("]")(0).Replace("B=", "")
                        Dim colorFile As Color = Color.FromArgb(Integer.Parse(A), Integer.Parse(R), Integer.Parse(G), Integer.Parse(B))

                        myCourbe.points(0, 0) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(1).Split(";")(0))
                        myCourbe.points(0, 1) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(1).Split(";")(1).Replace("]", ""))
                        myCourbe.points(1, 0) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(2).Split(";")(0))
                        myCourbe.points(1, 1) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(2).Split(";")(1).Replace("]", ""))
                        myCourbe.points(2, 0) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(3).Split(";")(0))
                        myCourbe.points(2, 1) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(3).Split(";")(1).Replace("]", ""))
                        myCourbe.points(3, 0) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(4).Split(";")(0))
                        myCourbe.points(3, 1) = Decimal.Parse(stringReader.Split("Color")(0).Split("[")(4).Split(";")(1).Replace("]", ""))

                        myCourbe.segmentDefine = stringReader.Split("|")(1)



                        myCourbe.colorDefine = colorFile


                        Dim myItem = New ListViewItem

                        myItem.Text = myCourbe.myPoints
                        myItem.Tag = myCourbe
                        myItem.BackColor = myCourbe.colorDefine
                        myItem.EnsureVisible()


                        pointData.Items.Add(myItem)


                        Afficher(myCourbe)
                    Catch ex As Exception
                        MessageBox.Show("Import file error")
                        Exit Sub
                    End Try
                End If
            Loop Until stringReader Is Nothing
            fileReader.Close()

        End If
    End Sub

    Private Sub pointData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pointData.ItemSelectionChanged
        If pointData.SelectedItems.Count <> 0 Then
            Dim myItem As ListViewItem
            Dim indexes As ListView.SelectedIndexCollection = sender.SelectedIndices
            Dim noSegments As Integer
            If indexes.Count > 0 Then
                myItem = pointData.Items.Item(indexes(0))

                Xdeb.Value = myItem.Tag.points(0, 0)
                Ydeb.Value = myItem.Tag.points(0, 1)
                Xfin.Value = myItem.Tag.points(1, 0)
                Yfin.Value = myItem.Tag.points(1, 1)
                Xtdeb.Value = myItem.Tag.points(2, 0)
                Ytdeb.Value = myItem.Tag.points(2, 1)
                Xtfin.Value = myItem.Tag.points(3, 0)
                Ytfin.Value = myItem.Tag.points(3, 1)
                nbSegements.Value = myItem.Tag.segmentDefine
                pbCouleur.BackColor = myItem.Tag.colorDefine
                index = myItem.Index

                Afficher(myItem.Tag)

                modifier.Visible = True
                supprimer.Visible = True
            End If
        ElseIf pointData.SelectedItems.Count = 0 Then
            plan.Image = Nothing
            modifier.Visible = False
            pbCouleur.BackColor = Color.White
            supprimer.Visible = False
        End If
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Try
            If index <> -1 Then
                'pointData.Items.Item(index) = "[" + Xdeb.Value.ToString + ";" + Ydeb.Value.ToString + "]" + "[" + Xfin.Value.ToString + ";" + Yfin.Value.ToString + "]" + "[" + Xtdeb.Value.ToString + ";" + Ytdeb.Value.ToString + "]" + "[" + Xtfin.Value.ToString + ";" + Ytfin.Value.ToString + "]"
                pointData.Items.RemoveAt(index)
            End If
        Catch ex As Exception
            MessageBox.Show("Liste Vide")
        End Try
    End Sub

    Private Sub btnDeb_Click(sender As Object, e As EventArgs) Handles btnDeb.Click
        deb = True
    End Sub
End Class

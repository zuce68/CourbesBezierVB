﻿Public Class Courbe
    Public points(4, 2) As Decimal
    Private nbSegement As Integer
    Private color As Color

    Public Property segmentDefine As Integer
        Get

            Return nbSegement

        End Get

        Set(segement As Integer)

            nbSegement = segement

        End Set

    End Property
    Public Property colorDefine As Color

        Get

            Return color

        End Get

        Set(ByVal newColor As Color)

            color = newColor

        End Set

    End Property

    Public Property myPoints As String

        Get

            Return "[" + points(0, 0).ToString("N2") + ";" + points(0, 1).ToString("N2") + "]" + "[" + points(1, 0).ToString("N2") + ";" + points(1, 1).ToString("N2") + "]" + "[" + points(2, 0).ToString("N2") + ";" + points(2, 1).ToString("N2") + "]" + "[" + points(3, 0).ToString("N2") + ";" + points(3, 1).ToString("N2") + "]"

        End Get

        Set

        End Set


    End Property


End Class

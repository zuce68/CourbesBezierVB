Public Class Courbe
    Public points(4, 2) As Decimal
    Private nbSegement As Integer

    Public Property segmentDefine As Integer

        Get

            Return nbSegement

        End Get

        Set(ByVal segement As Integer)

            nbSegement = segement
            'RaiseEvent INotifyPropertyChanged_PropertyChanged(Me, New PropertyChangedEventArgs("Operation"))'

        End Set

    End Property

End Class

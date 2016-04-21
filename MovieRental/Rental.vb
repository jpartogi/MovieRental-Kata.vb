Public Class Rental
    Public Property Movie() As Movie
        Get
            Return m_Movie
        End Get
        Set
            m_Movie = Value
        End Set
    End Property
    Private m_Movie As Movie
    Public Property DaysRented() As Integer
        Get
            Return m_DaysRented
        End Get
        Set
            m_DaysRented = Value
        End Set
    End Property
    Private m_DaysRented As Integer

    Public Sub New(movie__1 As Movie, daysRented__2 As Integer)
        Movie = movie__1
        DaysRented = daysRented__2
    End Sub

End Class
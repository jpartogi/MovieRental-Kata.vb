Public Class Movie
    Public Const REGULAR As Integer = 0
    Public Const NEW_RELEASE As Integer = 1
    Public Const CHILDRENS As Integer = 2

    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set
            m_Title = Value
        End Set
    End Property
    Private m_Title As String
    Public Property PriceCode() As Integer
        Get
            Return m_PriceCode
        End Get
        Set
            m_PriceCode = Value
        End Set
    End Property
    Private m_PriceCode As Integer

    Public Sub New(title As String, priceCode As Integer)
        Me.Title = title
        Me.PriceCode = priceCode
    End Sub

End Class
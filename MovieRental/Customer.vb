Imports System
Imports System.Collections.Generic

Public Class Customer
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set
            m_Name = Value
        End Set
    End Property

    Private m_Name As String
    Public Rentals As New List(Of Rental)()

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Sub AddRental(rental As Rental)
        Rentals.Add(rental)
    End Sub

    Public Function Statement() As String
        Dim result As [String] = (Convert.ToString("Rental Record for ") & Me.Name) + vbLf
        Dim totalAmount As Double = 0
        Dim frequentRenterPoints As Integer = 0
        Dim rentalEnum As IEnumerator(Of Rental) = Rentals.GetEnumerator()

        ' determine amounts for each line
        While rentalEnum.MoveNext()
            Dim thisAmount As Double = 0
            Dim [each] As Rental = rentalEnum.Current

            Select Case [each].Movie.PriceCode
                Case Movie.REGULAR
                    thisAmount += 2
                    If [each].DaysRented > 2 Then
                        thisAmount += ([each].DaysRented - 2) * 1.5
                    End If
                    Exit Select
                Case Movie.NEW_RELEASE
                    thisAmount += [each].DaysRented * 3
                    Exit Select
                Case Movie.CHILDRENS
                    thisAmount += 1.5
                    If [each].DaysRented > 3 Then
                        thisAmount += ([each].DaysRented - 3) * 1.5
                    End If
                    Exit Select
            End Select

            ' frequent renter points
            frequentRenterPoints += 1

            ' add bonus for a two day new release rental
            If ([each].Movie.PriceCode = Movie.NEW_RELEASE) AndAlso [each].DaysRented > 1 Then
                frequentRenterPoints += 1
            End If

            ' show figures for this rental
            result += vbTab + [each].Movie.Title + vbTab + thisAmount.ToString() + vbLf
            totalAmount += thisAmount
        End While

        ' add footer lines
        result += "Amount owed is " + totalAmount.ToString() + vbLf
        result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points"

        Return result
    End Function
End Class
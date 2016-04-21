Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports MovieRental

<TestClass()> Public Class UnitTest

    <TestClass()> Public Class UnitTest

        <TestMethod()> Public Sub TestStatement()
            Dim movie__1 As New Movie("Transformer", Movie.REGULAR)

            Dim rental As New Rental(movie__1, 3)

            Dim customer As New Customer("jpartogi")
            customer.AddRental(rental)

            Dim statement As [String] = customer.Statement()
            StringAssert.Contains(statement, "Transformer")
        End Sub

    End Class

End Class
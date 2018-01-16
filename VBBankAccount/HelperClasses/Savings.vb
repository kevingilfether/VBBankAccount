Public Class Savings
    Inherits Account
    ' Minimum Balance, below which user cannot draw
    Private _acctMin As Double

    Public ReadOnly Property AcctMin()
        Get
            Return _acctMin
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal client As Client, ByVal balance As Double, ByVal acctMin As Double)
        Me._acctID = client.UserID
        Me._balance = balance
        Me._acctMin = acctMin

        Me._acctType = "Savings Account"
    End Sub

    Public Overrides Sub ViewBalance()
        Console.WriteLine("The account balance for {0}: {1} is ${2}.", _acctType, _acctID, Math.Round(_balance, 2))
    End Sub

    'Method to make sure that method is beyond allowed amount

    Public Overrides Function Withdraw(numWithdrawn As Double)
        Dim maxAllowedDraw As Double = _balance - _acctMin
        If (numWithdrawn > maxAllowedDraw) Then
            Console.WriteLine("Please try your withdrawal again, leaving at least ${0} in your account.", Math.Round(_acctMin, 2))
            Console.WriteLine("You may withdraw a maxmum of ${0} without making a new deposit.", Math.Round(maxAllowedDraw, 2))
            Return _balance
        Else
            Return MyBase.Withdraw(numWithdrawn)
        End If
    End Function

End Class

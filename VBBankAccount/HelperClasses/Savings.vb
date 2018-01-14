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
        Console.WriteLine("The  account balance for {0}: {1} is ${2}.", _acctType, _acctID, Math.Round(_balance, 2))
    End Sub
End Class

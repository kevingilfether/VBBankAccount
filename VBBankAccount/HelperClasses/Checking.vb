Public Class Checking
    Inherits Account

    Public Sub New()

    End Sub

    Public Sub New(ByVal client As Client, ByVal balance As Double)
        Me._acctID = client.UserID
        Me._balance = balance

        Me._acctType = "Checking Account"
    End Sub



    Public Overrides Sub ViewBalance()
        Console.WriteLine("The  account balance for {0}: {1} is ${2}.", _acctType, _acctID, Math.Round(_balance, 2))
    End Sub
End Class

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
        Console.WriteLine()
    End Sub
End Class

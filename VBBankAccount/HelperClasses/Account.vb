Public MustInherit Class Account

    Protected _acctID As Int32
    Protected _balance As Double
    Protected _acctType As String

    Public ReadOnly Property AcctID() As Int32
        Get
            Return _acctID
        End Get
    End Property

    Public ReadOnly Property Balance() As Double
        Get
            Return _balance
        End Get
    End Property

    Public ReadOnly Property AcctType() As String
        Get
            Return _acctType
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Overridable Function Deposit(ByVal numDeposited As Double)
        _balance += numDeposited
        Return _balance
    End Function

    Public Overridable Function Withdraw(ByVal numWithdrawn As Double)
        _balance -= numWithdrawn
        Return _balance
    End Function

    'Abstract ViewBalance()
    Public MustOverride Sub ViewBalance()

End Class

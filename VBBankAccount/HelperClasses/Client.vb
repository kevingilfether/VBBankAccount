Public Class Client
    'Class for a customer at the Bank

    'Fields
    Private _userID As Int32
    Private _acctName As String
    Private _userName As String

    'Properties
    Public Property UserID() As Int32
        Get
            Return _userID
        End Get
        Set(value As Int32)
            _userID = value
        End Set
    End Property

    Public Property AcctName() As String
        Get
            Return _acctName
        End Get
        Set(value As String)
            _acctName = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property


    'Constructors
    Public Sub New()

    End Sub

    Public Sub New(ByVal _userID As Int32, ByVal _acctName As String, ByVal _userName As String)
        Me._userID = _userID
        Me._acctName = _acctName
        Me._userName = _userName
    End Sub

    Public Sub ViewClientInfo()
        Console.WriteLine("{0} --- {1} --- {2}", _userName, _acctName, _userID)
    End Sub

End Class

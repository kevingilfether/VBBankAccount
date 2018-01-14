Public Class Client
    'Class for a customer at the Bank

    'Fields
    Private _userID As Int32
    Private _acctName As String
    Private _userName As String



    Public Property userID() As Int32
        Get
            Return _userID
        End Get
        Set(value As Int32)
            _userID = value
        End Set
    End Property


End Class

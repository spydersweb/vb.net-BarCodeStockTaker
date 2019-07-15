
Public Class Product

    Private _code As String
    Private _count As Integer

    Public Property Code()
        Get
            Return _code
        End Get
        Set(ByVal value)
            _code = value
        End Set
    End Property

    Public Property Count()
        Get
            Return _count
        End Get
        Set(ByVal value)
            _count = value
        End Set
    End Property

    Sub New(ByVal code As String, ByVal count As Integer)
        Me.Code = code
        Me.Count = count
    End Sub

End Class

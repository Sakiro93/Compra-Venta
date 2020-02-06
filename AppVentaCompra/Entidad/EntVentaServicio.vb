Public Class EntVentaServicio
    Private venserID As Integer
    Private venserIDServicio As Integer
    Sub New()
        Me.venserID = 0
        Me.venserIDServicio = 0
    End Sub
    Sub New(ByVal venserID As Integer, ByVal venserIDServicio As Integer)
        Me.venserID = venserID
        Me.venserIDServicio = venserIDServicio
    End Sub
    Public Property venser_ID() As Integer
        Get
            Return Me.venserID
        End Get
        Set(ByVal value As Integer)
            Me.venserID = value
        End Set
    End Property
    Public Property venser_IDServicio() As Integer
        Get
            Return Me.venserIDServicio
        End Get
        Set(ByVal value As Integer)
            Me.venserIDServicio = value
        End Set
    End Property
End Class

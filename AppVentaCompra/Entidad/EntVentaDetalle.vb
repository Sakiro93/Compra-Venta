Public Class EntVentaDetalle
    Private detID As Integer
    Private detIDAccesorio As Integer
    Private detCantidad As Integer
    Private detCosto As Double
    Sub New()
        Me.detID = 0
        Me.detIDAccesorio = 0
        Me.detCantidad = 0
        Me.detCosto = 0
    End Sub
    Sub New(ByVal detID As Integer, ByVal detIDAccesorio As Integer, ByVal detCantidad As Integer, ByVal detCosto As Double)
        Me.detID = detID
        Me.detIDAccesorio = detIDAccesorio
        Me.detCantidad = detCantidad
        Me.detCosto = detCosto
    End Sub
    Public Property det_ID() As Integer
        Get
            Return Me.detID
        End Get
        Set(ByVal value As Integer)
            Me.detID = value
        End Set
    End Property
    Public Property det_IDAccesorio() As Integer
        Get
            Return Me.detIDAccesorio
        End Get
        Set(ByVal value As Integer)
            Me.detIDAccesorio = value
        End Set
    End Property
    Public Property det_Cantidad() As Integer
        Get
            Return Me.detCantidad
        End Get
        Set(ByVal value As Integer)
            Me.detCantidad = value
        End Set
    End Property
    Public Property det_Costo() As Double
        Get
            Return Me.detCosto
        End Get
        Set(ByVal value As Double)
            Me.detCosto = value
        End Set
    End Property
End Class

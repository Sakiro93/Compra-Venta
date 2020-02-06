Public Class EntCompraInventario
    Private invID As Integer
    Private invIDAccesorio As Integer
    Private invCantidad As Integer
    Private invCosto As Double
 
    Sub New()
        Me.invID = 0
        Me.invIDAccesorio = 0
        Me.invCantidad = 0
        Me.invCosto = 0
    End Sub
    Sub New(ByVal invID As Integer, ByVal invIDAccesorio As Integer, ByVal invCantidad As Integer, ByVal invCosto As Double)
        Me.invID = invID
        Me.invIDAccesorio = invIDAccesorio
        Me.invCantidad = invCantidad
        Me.invCosto = invCosto
    End Sub
    Public Property inv_ID() As Integer
        Get
            Return Me.invID
        End Get
        Set(ByVal value As Integer)
            Me.invID = value
        End Set
    End Property
    Public Property inv_IDAccesorio() As Integer
        Get
            Return Me.invIDAccesorio
        End Get
        Set(ByVal value As Integer)
            Me.invIDAccesorio = value
        End Set
    End Property
    Public Property inv_Cantidad() As Integer
        Get
            Return Me.invCantidad
        End Get
        Set(ByVal value As Integer)
            Me.invCantidad = value
        End Set
    End Property
    Public Property inv_Costo() As Double
        Get
            Return Me.invCosto
        End Get
        Set(ByVal value As Double)
            Me.invCosto = value
        End Set
    End Property
End Class

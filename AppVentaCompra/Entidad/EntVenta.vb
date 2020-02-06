Public Class EntVenta
    Private venID As Integer
    Private venIDCliente As Integer
    Private venFecha As Date
    Private venSubtotal As Double
    Private venIva As Double
    Private venDescuento As Double
    Private venTotal As Double
    Sub New()
        Me.venID = 0
        Me.venIDCliente = 0
        Me.venFecha = Date.Now
        Me.venSubtotal = 0
        Me.venIva = 0
        Me.venDescuento = 0
        Me.venTotal = 0
    End Sub
    Sub New(ByVal venID As Integer, ByVal venIDCliente As Integer, ByVal venFecha As Date, ByVal venSubtotal As Double, ByVal venIva As Double, ByVal venDescuento As Double, ByVal venTotal As Double)
        Me.venID = venID
        Me.venIDCliente = venIDCliente
        Me.venFecha = venFecha
        Me.venSubtotal = venSubtotal
        Me.venIva = venIva
        Me.venDescuento = venDescuento
        Me.venTotal = venTotal
    End Sub
    Public Property ven_ID() As Integer
        Get
            Return Me.venID
        End Get
        Set(ByVal value As Integer)
            Me.venID = value
        End Set
    End Property
    Public Property ven_IDCliente() As Integer
        Get
            Return Me.venIDCliente
        End Get
        Set(ByVal value As Integer)
            Me.venIDCliente = value
        End Set
    End Property
    Public Property ven_Fecha() As Date
        Get
            Return Me.venFecha
        End Get
        Set(ByVal value As Date)
            Me.venFecha = value
        End Set
    End Property
   

    Public Property ven_Subtotal() As Double
        Get
            Return Me.venSubtotal
        End Get
        Set(ByVal value As Double)
            Me.venSubtotal = value
        End Set
    End Property

    Public Property ven_IVA() As Double
        Get
            Return Me.venIva
        End Get
        Set(ByVal value As Double)
            Me.venIva = value
        End Set
    End Property
    Public Property ven_Descuento() As Double
        Get
            Return Me.venDescuento
        End Get
        Set(ByVal value As Double)
            Me.venDescuento = value
        End Set
    End Property
    Public Property ven_Total() As Double
        Get
            Return Me.venTotal
        End Get
        Set(ByVal value As Double)
            Me.venTotal = value
        End Set
    End Property
End Class

Public Class EntCompra
    Private comID As Integer
    Private comFecha As Date
    Private comIDProveedor As Integer
    Private comSubtotal As Double
    Private comIva As Double
    Private comDescuento As Double
    Private comTotal As Double
    Sub New()
        Me.comID = 0
        Me.comFecha = Date.Now
        Me.comIDProveedor = 0
        Me.comSubtotal = 0
        Me.comIva = 0
        Me.comDescuento = 0
        Me.comTotal = 0
    End Sub
    Sub New(ByVal comID As Integer, ByVal comFecha As Date, ByVal comIDProveedor As Integer, ByVal comSubtotal As Double, ByVal comIva As Double, ByVal comDescuento As Double, ByVal comTotal As Double)
        Me.comID = comID
        Me.comFecha = comFecha
        Me.comIDProveedor = comIDProveedor
        Me.comSubtotal = comSubtotal
        Me.comIva = comIva
        Me.comDescuento = comDescuento
        Me.comTotal = comTotal
    End Sub
    Public Property com_ID() As Integer
        Get
            Return Me.comID
        End Get
        Set(ByVal value As Integer)
            Me.comID = value
        End Set
    End Property
    Public Property com_Fecha() As Date
        Get
            Return Me.comFecha
        End Get
        Set(ByVal value As Date)
            Me.comFecha = value
        End Set
    End Property
    Public Property com_IDProveedor() As Integer
        Get
            Return Me.comIDProveedor
        End Get
        Set(ByVal value As Integer)
            Me.comIDProveedor = value
        End Set
    End Property

    Public Property com_Subtotal() As Double
        Get
            Return Me.comSubtotal
        End Get
        Set(ByVal value As Double)
            Me.comSubtotal = value
        End Set
    End Property

    Public Property com_IVA() As Double
        Get
            Return Me.comIva
        End Get
        Set(ByVal value As Double)
            Me.comIva = value
        End Set
    End Property
    Public Property com_Descuento() As Double
        Get
            Return Me.comDescuento
        End Get
        Set(ByVal value As Double)
            Me.comDescuento = value
        End Set
    End Property
    Public Property com_Total() As Double
        Get
            Return Me.comTotal
        End Get
        Set(ByVal value As Double)
            Me.comTotal = value
        End Set
    End Property

End Class

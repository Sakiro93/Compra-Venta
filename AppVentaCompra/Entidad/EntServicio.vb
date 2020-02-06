Public Class EntServicio
    Private serID As Integer
    Private serDescripcion As String
    Private serPrecio As Double

    Sub New()
        Me.serID = 0
        Me.serDescripcion = ""
        Me.serPrecio = 0
    End Sub

    Sub New(ByVal serID As Integer, ByVal serDescripcion As String, ByVal serPrecio As Double)
        Me.serID = serID
        Me.serDescripcion = serDescripcion
        Me.serPrecio = serPrecio
    End Sub
    Public Property ser_ID() As Integer
        Get
            Return Me.serID
        End Get
        Set(ByVal value As Integer)
            Me.serID = value
        End Set
    End Property
    Public Property ser_Descripcion() As String
        Get
            Return Me.serDescripcion
        End Get
        Set(ByVal value As String)
            Me.serDescripcion = value
        End Set
    End Property
    Public Property ser_Precio() As Double
        Get
            Return Me.serPrecio
        End Get
        Set(ByVal value As Double)
            Me.serPrecio = value
        End Set
    End Property
End Class

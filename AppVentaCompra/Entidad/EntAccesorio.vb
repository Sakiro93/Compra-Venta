Public Class EntAccesorio
    Private accID As Integer
    Private accIDParte As Integer
    Private accNombre As String
    Private accStock As Integer
    Private accCosto As Double
    Private accPVP As Double
    Sub New()
        Me.accID = 0
        Me.accIDParte = 0
        Me.accNombre = ""
        Me.accStock = 0
        Me.accCosto = 0
        Me.accPVP = 0
    End Sub
    Sub New(ByVal accID As Integer, ByVal accIDParte As Integer, ByVal accNombre As String, ByVal accStock As Integer, ByVal accCosto As Double, ByVal accPVP As Double)
        Me.accID = accID
        Me.accIDParte = accIDParte
        Me.accNombre = accNombre
        Me.accStock = accStock
        Me.accCosto = accCosto
        Me.accPVP = accPVP
    End Sub
    Public Property acc_ID() As Integer
        Get
            Return Me.accID
        End Get
        Set(ByVal value As Integer)
            Me.accID = value
        End Set
    End Property
    Public Property acc_IDParte() As Integer
        Get
            Return Me.accIDParte
        End Get
        Set(ByVal value As Integer)
            Me.accIDParte = value
        End Set
    End Property
    Public Property acc_Nombre() As String
        Get
            Return Me.accNombre
        End Get
        Set(ByVal value As String)
            Me.accNombre = value
        End Set
    End Property
    Public Property acc_Stock() As Integer
        Get
            Return Me.accStock
        End Get
        Set(ByVal value As Integer)
            Me.accStock = value
        End Set
    End Property
    Public Property acc_Costo() As Double
        Get
            Return Me.accCosto
        End Get
        Set(ByVal value As Double)
            Me.accCosto = value
        End Set
    End Property
    Public Property acc_PVP() As Double
        Get
            Return Me.accPVP
        End Get
        Set(ByVal value As Double)
            Me.accPVP = value
        End Set
    End Property
End Class

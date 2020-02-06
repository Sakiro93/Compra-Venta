Public Class EntProveedor
    Private proID As Integer
    Private proRazonSocial As String
    Private proRuc As String
    Private proTelefono As String
    Private proEmail As String
    Private proDireccion As String

    Sub New()
        Me.proID = 0
        Me.proRazonSocial = ""
        Me.proRuc = ""
        Me.proTelefono = ""
        Me.proEmail = ""
        Me.proDireccion = ""
    End Sub

    Sub New(ByVal proID As Integer, ByVal proRazonSocial As String, ByVal proRuc As String,
            ByVal proTelefono As String, ByVal proEmail As String, ByVal proDireccion As String)
        Me.proID = proID
        Me.proRazonSocial = proRazonSocial
        Me.proRuc = proRuc
        Me.proTelefono = proTelefono
        Me.proEmail = proEmail
        Me.proDireccion = proDireccion
    End Sub

    Public Property pro_ID() As Integer
        Get
            Return Me.proID
        End Get
        Set(ByVal value As Integer)
            Me.proID = value
        End Set
    End Property

    Public Property pro_RazonSocial() As String
        Get
            Return Me.proRazonSocial
        End Get
        Set(ByVal value As String)
            Me.proRazonSocial = value
        End Set
    End Property

    Public Property pro_Ruc() As String
        Get
            Return Me.proRuc
        End Get
        Set(ByVal value As String)
            Me.proRuc = value
        End Set
    End Property

    Public Property pro_Telefono() As String
        Get
            Return Me.proTelefono
        End Get
        Set(ByVal value As String)
            Me.proTelefono = value
        End Set
    End Property

    Public Property pro_Email() As String
        Get
            Return Me.proEmail
        End Get
        Set(ByVal value As String)
            Me.proEmail = value
        End Set
    End Property

    Public Property pro_Direccion() As String
        Get
            Return Me.proDireccion
        End Get
        Set(ByVal value As String)
            Me.proDireccion = value
        End Set
    End Property
End Class

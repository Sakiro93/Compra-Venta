Public Class EntCliente
    Private cliID As Integer
    Private cliCedula As String
    Private cliNombres As String
    Private cliApellidos As String
    Private cliTelefono As String
    Private cliEmail As String
    Private cliDireccion As String
    Private cliSexo As Boolean
    Sub New()
        Me.cliID = 0
        Me.cliCedula = 0
        Me.cliNombres = ""
        Me.cliApellidos = ""
        Me.cliTelefono = ""
        Me.cliEmail = ""
        Me.cliDireccion = ""
        Me.cliSexo = 0
    End Sub

    Sub New(ByVal cliID As Integer, ByVal cliCedula As String, ByVal cliNombres As String, ByVal cliApellidos As String, ByVal cliTelefono As String,
            ByVal cliEmail As String, ByVal cliDireccion As String, ByVal cliSexo As Boolean)
        Me.cliID = cliID
        Me.cliCedula = cliCedula
        Me.cliNombres = cliNombres
        Me.cliApellidos = cliApellidos
        Me.cliTelefono = cliTelefono
        Me.cliEmail = cliEmail
        Me.cliDireccion = cliDireccion
        Me.cliSexo = cliSexo
    End Sub
    Public Property cli_ID() As Integer
        Get
            Return Me.cliID
        End Get
        Set(ByVal value As Integer)
            Me.cliID = value
        End Set
    End Property
    Public Property cli_Cedula() As String
        Get
            Return Me.cliCedula
        End Get
        Set(ByVal value As String)
            Me.cliCedula = value
        End Set
    End Property
    Public Property cli_Nombres() As String
        Get
            Return Me.cliNombres
        End Get
        Set(ByVal value As String)
            Me.cliNombres = value
        End Set
    End Property
    Public Property cli_Apellidos() As String
        Get
            Return Me.cliApellidos
        End Get
        Set(ByVal value As String)
            Me.cliApellidos = value
        End Set
    End Property
    Public Property cli_Telefono() As String
        Get
            Return Me.cliTelefono
        End Get
        Set(ByVal value As String)
            Me.cliTelefono = value
        End Set
    End Property
    Public Property cli_Email() As String
        Get
            Return Me.cliEmail
        End Get
        Set(ByVal value As String)
            Me.cliEmail = value
        End Set
    End Property
    Public Property cli_Direccion() As String
        Get
            Return Me.cliDireccion
        End Get
        Set(ByVal value As String)
            Me.cliDireccion = value
        End Set
    End Property
    Public Property cli_Sexo() As Boolean
        Get
            Return Me.cliSexo
        End Get
        Set(ByVal value As Boolean)
            Me.cliSexo = value
        End Set
    End Property
End Class

Public Class EntParte
    Private parID As Integer
    Private parDescripcion As String

    Sub New()
        Me.parID = 0
        Me.parDescripcion = ""
    End Sub

    Sub New(ByVal parID As Integer, ByVal parDescripcion As String)
        Me.parID = parID
        Me.parDescripcion = parDescripcion
    End Sub
    Public Property par_ID() As Integer
        Get
            Return Me.parID
        End Get
        Set(ByVal value As Integer)
            Me.parID = value
        End Set
    End Property
    Public Property par_Descripcion() As String
        Get
            Return Me.parDescripcion
        End Get
        Set(ByVal value As String)
            Me.parDescripcion = value
        End Set
    End Property
End Class

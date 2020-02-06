Public Class DetalleVenta
    Private Validacion As Validaciones = New Validaciones
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub limpiar()
        Validacion.LimpiarTodo(GBAccesorio)
        Validacion.LimpiarTodo(GBServicio)
    End Sub
    Public Sub cargarAccesorio(ByVal Buscar As String)
        DgAccesorio.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudDetVenta(Buscar, Cod)
        For fila = 0 To Tabla.Rows.Count - 1
            DgAccesorio.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8))
        Next
    End Sub
    Public Sub cargarServicio(ByVal Buscar As String)
        DgServicio.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudSer(Buscar, Cod)
        For fila = 0 To Tabla.Rows.Count - 1
            DgServicio.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6))
        Next
    End Sub
    Private Sub DetalleVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargarAccesorio(TxtBuscar.Text)
        cargarServicio(TxtBuscarServicio.Text)
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        cargarAccesorio(TxtBuscar.Text)
    End Sub

    Private Sub TxtBuscarServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarServicio.TextChanged
        cargarServicio(TxtBuscarServicio.Text)
    End Sub
End Class
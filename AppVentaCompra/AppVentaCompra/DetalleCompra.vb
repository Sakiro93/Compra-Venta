Public Class DetalleCompra
    Private Validacion As Validaciones = New Validaciones
    Public Sub limpiar()
        Validacion.LimpiarTodo(GBInventario)
    End Sub
    Public Sub cargarInventario(ByVal Buscar As String)
        DgInventario.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudInv(Buscar, Cod)
        For fila = 0 To Tabla.Rows.Count - 1
            DgInventario.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8))
        Next
    End Sub
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub DetalleCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargarInventario(TxtBuscar.Text)
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        cargarInventario(TxtBuscar.Text)
    End Sub
End Class
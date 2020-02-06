Public Class Historial
    Private Validacion As Validaciones = New Validaciones
    Public Sub limpiar()
        Validacion.LimpiarTodo(GBVenta)
        Validacion.LimpiarTodo(GBCompra)
    End Sub
    Public Sub cargarVenta(ByVal Buscar As String)
        DgVenta.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudVenta(Buscar)
        For fila = 0 To Tabla.Rows.Count - 1
            DgVenta.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11))
        Next
    End Sub
    Public Sub cargarCompra(ByVal Buscar As String)
        DgCompra.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudCompra(Buscar)
        For fila = 0 To Tabla.Rows.Count - 1
            DgCompra.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11))
        Next
    End Sub


    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargarCompra(TxtBuscarCompra.Text)
        cargarVenta(TxtBuscar.Text)
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        cargarVenta(TxtBuscar.Text)
    End Sub

    Private Sub TxtBuscarCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarCompra.TextChanged
        cargarCompra(TxtBuscarCompra.Text)
    End Sub

   
    Private Sub DgVenta_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgVenta.CellClick
        If DgVenta.SelectedRows.Count > 0 Then
            Ind = DgVenta.CurrentRow.Index
            Cod = DgVenta.Rows(Ind).Cells(0).Value
            If DgVenta.CurrentCell.ColumnIndex = 12 Then
                If (Cod > 0) Then
                    DetalleVenta.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub DgCompra_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgCompra.CellClick
        If DgCompra.SelectedRows.Count > 0 Then
            Ind = DgCompra.CurrentRow.Index
            Cod = DgCompra.Rows(Ind).Cells(0).Value
            If DgCompra.CurrentCell.ColumnIndex = 12 Then
                If (Cod > 0) Then
                    DetalleCompra.ShowDialog()
                End If
            End If
        End If
    End Sub
End Class
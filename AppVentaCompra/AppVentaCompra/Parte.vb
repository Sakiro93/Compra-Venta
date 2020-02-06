Imports Entidad

Public Class Parte
    Private Validacion As Validaciones = New Validaciones
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()

    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        Validacion.LimpiarGroupbox(GrupCliDatos)
        Validacion.LimpiarGroupbox(GrupCliReg)
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each par In Logicadatos.buscarPar(Buscar)
            Dg.Rows.Add(par.par_ID, par.par_Descripcion)
        Next
    End Sub
    Private Sub Parte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargar(TxtBuscar.Text.Trim())
        Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
        Validacion.Cargar_Botones(4, GrupOpciones)
        Validacion.Botones(1)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        Validacion.Habilitar_GroupBox(GrupCliDatos, 1)
        Validacion.Botones(2)
        grabarG = "N"
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim datos = New EntParte(Cod, TxtDescripcion.Text)
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Validacion.ValidaEntrada(ErrDatos, GrupCliDatos) Then
                If grabarG = "N" Then
                    Logicadatos.ingresarPar(datos)
                Else
                    Logicadatos.modificarPar(datos)
                End If
                limpiar()
                cargar(TxtBuscar.Text)
                Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
                Validacion.Botones(1)
            End If
        Else
            limpiar()
            Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
            Validacion.Botones(1)
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim datos = New EntParte(Cod, TxtDescripcion.Text)
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Logicadatos.eliminarPar(datos)
            limpiar()
            cargar(TxtBuscar.Text)
        End If
        Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
        Validacion.Botones(1)
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        grabarG = "M"
        Validacion.Habilitar_GroupBox(GrupCliDatos, 1)
        Validacion.Botones(4)
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        ErrDatos.Clear()
        Validacion.LimpiarGroupbox(GrupCliDatos)
        Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
        cargar(TxtBuscar.Text.Trim())
    End Sub

    Private Sub Dg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellClick
        If Dg.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            Ind = Dg.CurrentRow.Index
            Cod = Dg.Rows(Ind).Cells(0).Value
            If (Cod > 0) Then
                MostrarDatos(Ind)
            End If
            Validacion.Habilitar_GroupBox(GrupCliDatos, 2)
        End If
    End Sub
    Public Sub MostrarDatos(ByVal i As Integer)
        TxtDescripcion.Text = Dg.Rows(i).Cells(1).Value.ToString
        Validacion.Botones(3)
    End Sub
End Class
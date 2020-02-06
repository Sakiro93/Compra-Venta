Imports Entidad

Public Class Accesorio
    Private Validacion As Validaciones = New Validaciones
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()

    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        llenarCombos()
        Validacion.LimpiarGroupbox(GrupCliDatos)
        Validacion.LimpiarGroupbox(GrupCliReg)
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim par As String = ""
        If CmbParte.Items.Count > 0 Then
            For Each acc In Logicadatos.buscarAcc(Buscar)
                CmbParte.SelectedValue = acc.acc_IDParte
                par = CmbParte.Text
                Dg.Rows.Add(acc.acc_ID, par, acc.acc_Nombre, acc.acc_Stock, acc.acc_Costo, acc.acc_PVP)
            Next
        End If
        llenarCombos()
    End Sub
    Public Sub llenarCombos()
        Logicadatos.llenarCombo(0, CmbParte)
        If CmbParte.Items.Count < 1 Then
            CmbParte.Text = ""
        End If
    End Sub

    Private Sub Accesorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Validacion.ValidaEntrada(ErrDatos, GrupCliDatos) Then
                Dim datos = New EntAccesorio(Cod, CmbParte.SelectedValue, TxtNombre.Text, TxtStock.Text, TxtCosto.Text, TxtPVP.Text)
                If grabarG = "N" Then
                    Logicadatos.ingresarAcc(datos)
                Else
                    Logicadatos.modificarAcc(datos)
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
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim datos = New EntAccesorio(Cod, CmbParte.SelectedValue, TxtNombre.Text, TxtStock.Text, TxtCosto.Text, TxtPVP.Text)
            Logicadatos.eliminarAcc(datos)
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
        CmbParte.Text = Dg.Rows(i).Cells(1).Value.ToString
        TxtNombre.Text = Dg.Rows(i).Cells(2).Value.ToString
        TxtStock.Text = Dg.Rows(i).Cells(3).Value.ToString
        TxtCosto.Text = Dg.Rows(i).Cells(4).Value.ToString
        TxtPVP.Text = Dg.Rows(i).Cells(5).Value.ToString
        Validacion.Botones(3)
    End Sub

    Private Sub TxtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCosto.KeyPress
        Validacion.ValidarPrecio(e, TxtCosto)
    End Sub

    Private Sub TxtPVP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPVP.KeyPress
        Validacion.ValidarPrecio(e, TxtPVP)
    End Sub
End Class
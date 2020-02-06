Imports Entidad

Public Class Compra
    Private Validacion As Validaciones = New Validaciones
    Dim Bandera As Boolean
    Dim Subt As Double
    Dim valorIva As Double
    Dim IVA As Double
    Dim Descuento As Double
    Dim Total As Double
    Dim IDAccesorio As Double
    Dim DetTotal As Double
    Dim DetCantidad As Integer
    Private Sub Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        Validacion.Habilitar_GroupBox(GrupVentDatos, 2)
        Validacion.Habilitar_GroupBox(GrupVenReg, 2)
        Validacion.Cargar_Botones(3, GrupCatAcc)
        Validacion.Botones(5)
    End Sub
    Public Sub limpiar()
        Dg.Rows.Clear()
        ErrDatos.Clear()
        llenarCombos()
        Subt = 0
        IVA = 0
        valorIva = 0
        Descuento = 0
        Total = 0
        IDAccesorio = 0
        DetTotal = 0
        DetCantidad = 0
        Opc12.Checked = True
        Bandera = False
        btnVentEliminar.Enabled = False
        Validacion.LimpiarGroupbox(GrupVentDatos)
        Validacion.LimpiarGroupbox(GrupVenReg)
        txtCompDesc.Text = 0
        TxtVentCant.Text = 0
    End Sub
    Public Sub actualizarPrecio()
        If CmbAccesorio.Items.Count > 0 And Bandera Then
            IDAccesorio = CmbAccesorio.SelectedValue.ToString
            DetTotal = Convert.ToDouble(Logicadatos.buscarPrecioCantidad(0, IDAccesorio).Rows(0).Item(0).ToString)
            If TxtVentCant.Text <> "" Then
                DetCantidad = Convert.ToDouble(TxtVentCant.Text)
            Else
                DetCantidad = 0
            End If
            TextVentCosto.Text = DetTotal * DetCantidad
        End If
    End Sub
    Public Sub llenarCombos()
        Logicadatos.llenarCombo(1, cboProveedor)
        If cboProveedor.Items.Count < 1 Then
            cboProveedor.Text = ""
        End If
        Logicadatos.llenarCombo(2, CmbAccesorio)
        If CmbAccesorio.Items.Count < 1 Then
            CmbAccesorio.Text = ""
        End If
    End Sub

    Private Sub btnSeguirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguirComp.Click
        Me.Close()
    End Sub

    Private Sub BtnAddProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProveedor.Click
        Proveedor.ShowDialog()
        llenarCombos()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Validacion.Habilitar_GroupBox(GrupVentDatos, 1)
        Validacion.Habilitar_GroupBox(GrupVenReg, 1)
        Validacion.Botones(6)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Validacion.ValidaEntrada(ErrDatos, GrupVentDatos) And Dg.Rows.Count > 0 Then
                If txtCompDesc.Text >= 0 And txtCompDesc.Text <= 100 Then
                    Dim datos = New EntCompra(Cod, Date.Now, cboProveedor.SelectedValue, Subt, valorIva, Descuento, Total)
                    Logicadatos.ingresarCom(datos)
                    guardarDetalle()
                    limpiar()
                    Validacion.Habilitar_GroupBox(GrupVentDatos, 2)
                    Validacion.Habilitar_GroupBox(GrupVenReg, 2)
                    Validacion.Botones(5)
                Else
                    MessageBox.Show("El descuento no está en el límite.")
                End If
            End If
        Else
            limpiar()
            Validacion.Habilitar_GroupBox(GrupVentDatos, 2)
            Validacion.Habilitar_GroupBox(GrupVenReg, 2)
            Validacion.Botones(5)
        End If
    End Sub
    Public Sub guardarDetalle()
        For i As Integer = 0 To Dg.Rows.Count - 1
            Dim datos = New EntCompraInventario(0, Dg.Rows(i).Cells(0).Value, Dg.Rows(i).Cells(2).Value, Dg.Rows(i).Cells(3).Value)
            Logicadatos.ingresarComInv(datos)
        Next
    End Sub

    Private Sub Dg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellClick
        If Dg.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            Ind = Dg.CurrentRow.Index
            Cod = Dg.Rows(Ind).Cells(0).Value
            btnVentEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If IDAccesorio > 0 And DetTotal > 0 And DetCantidad > 0 Then
            If repetidos(IDAccesorio) = False Then
                Dg.Rows.Add(IDAccesorio, CmbAccesorio.Text, DetCantidad, TextVentCosto.Text)
                actualizarCabecera()
            Else
                MessageBox.Show("Accesorio Repetido, agregue uno diferente")
            End If
        End If
        btnVentEliminar.Enabled = False
    End Sub
    Public Function repetidos(ByVal id As Double) As Boolean
        For i As Integer = 0 To Dg.Rows.Count - 1
            If id = Dg.Rows(i).Cells(0).Value Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub CmbAccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAccesorio.SelectedIndexChanged
        actualizarPrecio()
    End Sub

    Private Sub CmbAccesorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAccesorio.Click
        Bandera = True
    End Sub

    Private Sub TxtVentCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVentCant.TextChanged
        actualizarPrecio()
    End Sub

    Private Sub btnVentEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentEliminar.Click
        If MessageBox.Show("¿Desea eliminar este dato del Detalle?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dg.Rows.RemoveAt(Ind)
            actualizarCabecera()
            btnVentEliminar.Enabled = False
        End If
    End Sub
    Public Sub actualizarCabecera()
        Subt = 0
        IVA = 0
        Descuento = 0
        Total = 0
        For i As Integer = 0 To Dg.Rows.Count - 1
            Subt += Dg.Rows(i).Cells(3).Value
        Next
        If Opc12.Checked Then
            IVA = 0.12
        End If
        Total = Subt + (Subt * IVA)
        valorIva = Subt * IVA
        If txtCompDesc.Text <> "" Then
            Descuento = (Total * Convert.ToDouble(txtCompDesc.Text)) / 100
        End If
        Total = Total - Descuento
        txtComptSub.Text = Subt
        txtCompTotal.Text = Math.Round(Total, 2)
    End Sub

    Private Sub OpcNinguna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcNinguna.CheckedChanged
        actualizarCabecera()
    End Sub

    Private Sub Opc12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opc12.CheckedChanged
        actualizarCabecera()
    End Sub

    Private Sub txtCompDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompDesc.TextChanged
        actualizarCabecera()
    End Sub

    Private Sub txtCompDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompDesc.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub

    Private Sub TxtVentCant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVentCant.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub
End Class
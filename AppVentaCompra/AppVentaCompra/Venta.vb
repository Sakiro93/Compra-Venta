Imports Entidad

Public Class Venta
    Private Validacion As Validaciones = New Validaciones
    Dim IndAcc As Integer
    Dim IndSer As Integer
    Dim CodAcc As Integer
    Dim CodSer As Integer
    Dim BanderaAcc As Boolean
    Dim BanderaSer As Boolean
    Dim IDAccesorio As Double
    Dim IDServicio As Double
    Dim SerTotal As Double
    Dim AccTotal As Double
    Dim AccStock As Integer
    Dim AccCantidad As Integer
    Dim Subt As Double
    Dim valorIva As Double
    Dim IVA As Double
    Dim Descuento As Double
    Dim Total As Double

    Private Sub btnSeguirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguirComp.Click
        Me.Close()
    End Sub
    Public Sub limpiar()
        CodAcc = 0
        CodSer = 0
        IndAcc = 0
        IndSer = 0
        BanderaAcc = False
        BanderaSer = False
        AccTotal = 0
        AccStock = 0
        SerTotal = 0
        AccCantidad = 0
        IDAccesorio = 0
        IDServicio = 0
        Subt = 0
        IVA = 0
        valorIva = 0
        Descuento = 0
        Total = 0
        DgAccesorio.Rows.Clear()
        DgServicio.Rows.Clear()
        ErrDatos.Clear()
        llenarCombos()
        btnEliminarAcc.Enabled = False
        btnEliminarSer.Enabled = False
        Validacion.LimpiarGroupbox(GrupVentDatos)
        Validacion.LimpiarGroupbox(GrupVenReg)
        TxtVentCant.Text = 0
        txtVentDesc.Text = 0
    End Sub
    Public Sub llenarCombos()
        Logicadatos.llenarCombo(3, cboCliente)
        If cboCliente.Items.Count < 1 Then
            cboCliente.Text = ""
        End If
        Logicadatos.llenarCombo(5, CmbAccesorio)
        If CmbAccesorio.Items.Count < 1 Then
            CmbAccesorio.Text = ""
        End If
        Logicadatos.llenarCombo(4, CmbServicio)
        If CmbServicio.Items.Count < 1 Then
            CmbServicio.Text = ""
        End If
    End Sub
    Public Sub actualizarPrecioAcc()
        AccStock = 0
        If CmbAccesorio.Items.Count > 0 And BanderaAcc Then
            IDAccesorio = CmbAccesorio.SelectedValue.ToString
            AccTotal = Convert.ToDouble(Logicadatos.buscarPrecioCantidad(1, IDAccesorio).Rows(0).Item(1).ToString)
            AccStock = Convert.ToDouble(Logicadatos.buscarPrecioCantidad(1, IDAccesorio).Rows(0).Item(0).ToString)
            If TxtVentCant.Text <> "" Then
                AccCantidad = Convert.ToDouble(TxtVentCant.Text)
            Else
                AccCantidad = 0
            End If
            TextAccTotal.Text = AccTotal * AccCantidad
        End If
    End Sub
    Public Sub actualizarPrecioSer()
        If CmbServicio.Items.Count > 0 And BanderaSer Then
            IDServicio = CmbServicio.SelectedValue.ToString
            SerTotal = Convert.ToDouble(Logicadatos.buscarPrecioCantidad(2, IDServicio).Rows(0).Item(0).ToString)
            TextSerCosto.Text = SerTotal
        End If
    End Sub
    Private Sub Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Validacion.Habilitar_GroupBox(GrupVentDatos, 2)
        Validacion.Habilitar_GroupBox(GrupVenReg, 2)
        limpiar()
        Validacion.Cargar_Botones(3, GrupCatAcc)
        Validacion.Botones(5)
    End Sub

    Private Sub BtnAddCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCliente.Click
        Cliente.ShowDialog()
        llenarCombos()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Validacion.Habilitar_GroupBox(GrupVentDatos, 1)
        Validacion.Habilitar_GroupBox(GrupVenReg, 1)
        Validacion.Botones(6)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Validacion.ValidaEntrada(ErrDatos, GrupVentDatos) And (DgServicio.Rows.Count > 0 Or DgAccesorio.Rows.Count > 0) Then
                If txtVentDesc.Text >= 0 And txtVentDesc.Text <= 100 Then
                    Dim datos = New EntVenta(Cod, cboCliente.SelectedValue, Date.Now, txtVentSub.Text, valorIva, Descuento, Total)
                    Logicadatos.ingresarVen(datos)
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
        If DgServicio.Rows.Count > 0 Then
            For i As Integer = 0 To DgServicio.Rows.Count - 1
                Dim datos = New EntVentaServicio(0, DgServicio.Rows(i).Cells(0).Value)
                Logicadatos.ingresarVenSer(datos)
            Next
        End If
        If DgAccesorio.Rows.Count > 0 Then
            For i As Integer = 0 To DgAccesorio.Rows.Count - 1
                Dim datos = New EntVentaDetalle(0, DgAccesorio.Rows(i).Cells(0).Value, DgAccesorio.Rows(i).Cells(2).Value, DgAccesorio.Rows(i).Cells(3).Value)
                Logicadatos.ingresarVenDet(datos)
            Next
        End If
    End Sub
    Public Sub actualizarCabecera()
        Subt = 0
        IVA = 0
        Descuento = 0
        Total = 0
        For i As Integer = 0 To DgAccesorio.Rows.Count - 1
            Subt += DgAccesorio.Rows(i).Cells(3).Value
        Next
        For i As Integer = 0 To DgServicio.Rows.Count - 1
            Subt += DgServicio.Rows(i).Cells(2).Value
        Next
        If Opc12.Checked Then
            IVA = 0.12
        End If
        Total = Subt + (Subt * IVA)
        valorIva = Subt * IVA
        If txtVentDesc.Text <> "" Then
            Descuento = (Total * Convert.ToDouble(txtVentDesc.Text)) / 100
        End If
        Total = Total - Descuento
        txtVentSub.Text = Subt
        txtVentTotal.Text = Math.Round(Total, 2)
    End Sub

    Private Sub btnAgregarAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAcc.Click
        If IDAccesorio > 0 And AccTotal > 0 And AccCantidad > 0 Then
            If Convert.ToDouble(TxtVentCant.Text) <= AccStock And Convert.ToDouble(TxtVentCant.Text) > 0 Then
                If repetidosAcc(IDAccesorio) = False Then
                    DgAccesorio.Rows.Add(IDAccesorio, CmbAccesorio.Text, AccCantidad, TextAccTotal.Text)
                    actualizarCabecera()
                Else
                    MessageBox.Show("Accesorio Repetido, agregue uno diferente")
                End If
            Else
                MessageBox.Show("La cantidad supera al Stock " + AccStock.ToString)
            End If
            
        End If
        btnEliminarAcc.Enabled = False
    End Sub
    Public Function repetidosAcc(ByVal id As Double) As Boolean
        For i As Integer = 0 To DgAccesorio.Rows.Count - 1
            If id = DgAccesorio.Rows(i).Cells(0).Value Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function repetidosSer(ByVal id As Double) As Boolean
        For i As Integer = 0 To DgServicio.Rows.Count - 1
            If id = DgServicio.Rows(i).Cells(0).Value Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub DgAccesorio_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgAccesorio.CellClick
        If DgAccesorio.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            IndAcc = DgAccesorio.CurrentRow.Index
            CodAcc = DgAccesorio.Rows(Ind).Cells(0).Value
            btnEliminarAcc.Enabled = True
        End If
    End Sub

    Private Sub DgServicio_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgServicio.CellClick
        If DgServicio.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            IndSer = DgServicio.CurrentRow.Index
            CodSer = DgServicio.Rows(Ind).Cells(0).Value
            btnEliminarSer.Enabled = True
        End If
    End Sub

    Private Sub CmbAccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAccesorio.SelectedIndexChanged
        actualizarPrecioAcc()
    End Sub

    Private Sub CmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbServicio.SelectedIndexChanged
        actualizarPrecioSer()
    End Sub

    Private Sub CmbAccesorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAccesorio.Click
        BanderaAcc = True
    End Sub

    Private Sub CmbServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbServicio.Click
        BanderaSer = True
    End Sub

    Private Sub TxtVentCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVentCant.TextChanged
        actualizarPrecioAcc()
    End Sub

    Private Sub btnEliminarAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAcc.Click
        If MessageBox.Show("¿Desea eliminar este dato del Detalle?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            DgAccesorio.Rows.RemoveAt(IndAcc)
            actualizarCabecera()
            btnEliminarAcc.Enabled = False
        End If
    End Sub

    Private Sub btnEliminarSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarSer.Click
        If MessageBox.Show("¿Desea eliminar este dato del Detalle?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            DgServicio.Rows.RemoveAt(IndSer)
            actualizarCabecera()
            btnEliminarSer.Enabled = False
        End If
    End Sub

    Private Sub btnAgregarSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSer.Click
        If IDServicio > 0 And SerTotal > 0 Then
            If repetidosSer(IDServicio) = False Then
                DgServicio.Rows.Add(IDServicio, CmbServicio.Text, SerTotal)
                actualizarCabecera()
            Else
                MessageBox.Show("Servicio Repetido, agregue uno diferente")
            End If
        End If
        btnEliminarAcc.Enabled = False
    End Sub

    Private Sub txtVentDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVentDesc.TextChanged
        actualizarCabecera()
    End Sub

    Private Sub Opc12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opc12.CheckedChanged
        actualizarCabecera()
    End Sub

    Private Sub OpcNinguna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcNinguna.CheckedChanged
        actualizarCabecera()
    End Sub

    Private Sub txtVentDesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVentDesc.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub

    Private Sub TxtVentCant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVentCant.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub
End Class
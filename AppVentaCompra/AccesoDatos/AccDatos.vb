Imports System.Data.SqlClient
Imports Entidad
Imports Interfaz

Public Class AccDatos
    Implements IntDatos
    Public Sub ClienteGrabar(ByVal opc As String, ByVal Cliente As EntCliente)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_CLIENTE"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Cliente.cli_ID
                .Add("@CEDULA", SqlDbType.VarChar).Value = Cliente.cli_Cedula
                .Add("@NOMBRES", SqlDbType.VarChar).Value = Cliente.cli_Nombres
                .Add("@APELLIDOS", SqlDbType.VarChar).Value = Cliente.cli_Apellidos
                .Add("@TELEFONO", SqlDbType.VarChar).Value = Cliente.cli_Telefono
                .Add("@EMAIL", SqlDbType.VarChar).Value = Cliente.cli_Email
                .Add("@DIRECCION", SqlDbType.VarChar).Value = Cliente.cli_Direccion
                .Add("@SEXO", SqlDbType.Bit).Value = Cliente.cli_Sexo
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Function buscarCli(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCliente) Implements Interfaz.IntDatos.buscarCli
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SELECT * FROM VW_CLIENTE WHERE IDCLIENTE LIKE '%" + filtro + "%' OR NOMBRES LIKE '%" + filtro + "%' OR CEDULA LIKE '%" + filtro + "%' ORDER BY IDCLIENTE"
        Dim LstCliente As New List(Of EntCliente)
        Dim Cliente As EntCliente
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Cliente = New EntCliente(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7))
            LstCliente.Add(Cliente)
        Next
        Return LstCliente
    End Function

    Public Sub ProveedorGrabar(ByVal opc As String, ByVal Proveedor As EntProveedor)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_PROVEEDOR"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Proveedor.pro_ID
                .Add("@RAZON", SqlDbType.VarChar).Value = Proveedor.pro_RazonSocial
                .Add("@RUC", SqlDbType.VarChar).Value = Proveedor.pro_Ruc
                .Add("@TELEFONO", SqlDbType.VarChar).Value = Proveedor.pro_Telefono
                .Add("@EMAIL", SqlDbType.VarChar).Value = Proveedor.pro_Email
                .Add("@DIRECCION", SqlDbType.VarChar).Value = Proveedor.pro_Direccion
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Function buscarPro(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntProveedor) Implements Interfaz.IntDatos.buscarPro
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SELECT * FROM VW_PROVEEDOR WHERE IDPROVEEDOR LIKE '%" + filtro + "%' OR RAZONSOCIAL LIKE '%" + filtro + "%' ORDER BY IDPROVEEDOR"
        Dim LstProveedor As New List(Of EntProveedor)
        Dim Proveedor As EntProveedor
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Proveedor = New EntProveedor(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstProveedor.Add(Proveedor)
        Next
        Return LstProveedor
    End Function

    Public Sub ServicioGrabar(ByVal opc As String, ByVal Servicio As EntServicio)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_SERVICIO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Servicio.ser_ID
                .Add("@DESCRIPCION", SqlDbType.VarChar).Value = Servicio.ser_Descripcion
                .Add("@PRECIO", SqlDbType.Real).Value = Servicio.ser_Precio
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Sub ParteGrabar(ByVal opc As String, ByVal Parte As EntParte)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_PARTE"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Parte.par_ID
                .Add("@DESCRIPCION", SqlDbType.VarChar).Value = Parte.par_Descripcion
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Sub eliminarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.eliminarCli
        ClienteGrabar("ELI", Cliente)
    End Sub

    Public Sub eliminarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.eliminarPro
        ProveedorGrabar("ELI", Proveedor)
    End Sub

    Public Sub ingresarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.ingresarCli
        ClienteGrabar("INS", Cliente)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.ingresarPro
        ProveedorGrabar("INS", Proveedor)
    End Sub

    Public Sub modificarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.modificarCli
        ClienteGrabar("MOD", Cliente)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.modificarPro
        ProveedorGrabar("MOD", Proveedor)
    End Sub

    Public Function buscarSer(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntServicio) Implements Interfaz.IntDatos.buscarSer
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SELECT * FROM VW_SERVICIO WHERE IDSERVICIO LIKE '%" + filtro + "%' OR DESCRIPCION LIKE '%" + filtro + "%' ORDER BY IDSERVICIO"
        Dim LstServicio As New List(Of EntServicio)
        Dim Servicio As EntServicio
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Servicio = New EntServicio(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Convert.ToDouble(Tabla.Rows(fila).Item(2).ToString))
            LstServicio.Add(Servicio)
        Next
        Return LstServicio
    End Function

    Public Sub eliminarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.eliminarSer
        ServicioGrabar("ELI", Servicio)
    End Sub

    Public Sub ingresarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.ingresarSer
        ServicioGrabar("INS", Servicio)
    End Sub

    Public Sub modificarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.modificarSer
        ServicioGrabar("MOD", Servicio)
    End Sub

    Public Function buscarPar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntParte) Implements Interfaz.IntDatos.buscarPar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SELECT * FROM VW_PARTE WHERE IDPARTE LIKE '%" + filtro + "%' OR DESCRIPCION LIKE '%" + filtro + "%' ORDER BY IDPARTE"
        Dim LstParte As New List(Of EntParte)
        Dim Parte As EntParte
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Parte = New EntParte(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1))
            LstParte.Add(Parte)
        Next
        Return LstParte
    End Function

    Public Sub eliminarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.eliminarPar
        ParteGrabar("ELI", Parte)
    End Sub

    Public Sub ingresarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.ingresarPar
        ParteGrabar("INS", Parte)
    End Sub

    Public Sub modificarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.modificarPar
        ParteGrabar("MOD", Parte)
    End Sub

    Public Sub llenarCombo(ByVal opc As Integer, ByVal Combo As System.Windows.Forms.ComboBox) Implements Interfaz.IntDatos.llenarCombo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim ID As String = ""
        Dim Descripcion As String = ""
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT IDPARTE,DESCRIPCION FROM VW_PARTE ORDER BY IDPARTE"
                ID = "IDPARTE"
                Descripcion = "DESCRIPCION"
            Case 1
                cmd.CommandText = "SELECT IDPROVEEDOR,RAZONSOCIAL FROM VW_PROVEEDOR ORDER BY IDPROVEEDOR"
                ID = "IDPROVEEDOR"
                Descripcion = "RAZONSOCIAL"
            Case 2
                cmd.CommandText = "SELECT A.IDACCESORIO IDACCESORIO,(A.NOMBRE+': '+P.DESCRIPCION) NOMBRE FROM VW_ACCESORIO A, VW_PARTE P  WHERE P.IDPARTE=A.IDPARTE ORDER BY A.IDACCESORIO"
                ID = "IDACCESORIO"
                Descripcion = "NOMBRE"
            Case 3
                cmd.CommandText = "SELECT IDCLIENTE,CEDULA FROM VW_CLIENTE ORDER BY IDCLIENTE"
                ID = "IDCLIENTE"
                Descripcion = "CEDULA"
            Case 4
                cmd.CommandText = "SELECT IDSERVICIO,DESCRIPCION FROM VW_SERVICIO ORDER BY IDSERVICIO"
                ID = "IDSERVICIO"
                Descripcion = "DESCRIPCION"
            Case 5
                cmd.CommandText = "SELECT A.IDACCESORIO IDACCESORIO,(A.NOMBRE+': '+P.DESCRIPCION) NOMBRE FROM VW_ACCESORIO A, VW_PARTE P  WHERE P.IDPARTE=A.IDPARTE AND A.STOCK >0 ORDER BY A.IDACCESORIO"
                ID = "IDACCESORIO"
                Descripcion = "NOMBRE"
        End Select
        Dim Tabla As DataTable
        Tabla = sql.Consulta(cmd)
        Combo.DataSource = Tabla
        Combo.DisplayMember = Tabla.Columns(Descripcion).ToString
        Combo.ValueMember = Tabla.Columns(ID).ToString
    End Sub

    Public Sub AccesorioGrabar(ByVal opc As String, ByVal Accesorio As EntAccesorio)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_ACCESORIO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Accesorio.acc_ID
                .Add("@CODPARTE", SqlDbType.Int).Value = Accesorio.acc_IDParte
                .Add("@NOMBRE", SqlDbType.VarChar).Value = Accesorio.acc_Nombre
                .Add("@STOCK", SqlDbType.Int).Value = Accesorio.acc_Stock
                .Add("@COSTO", SqlDbType.Real).Value = Accesorio.acc_Costo
                .Add("@PVP", SqlDbType.Real).Value = Accesorio.acc_PVP
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Function buscarAcc(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntAccesorio) Implements Interfaz.IntDatos.buscarAcc
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SELECT * FROM VW_ACCESORIO WHERE IDACCESORIO LIKE '%" + filtro + "%' OR NOMBRE LIKE '%" + filtro + "%' ORDER BY IDACCESORIO"
        Dim LstAccesorio As New List(Of EntAccesorio)
        Dim Accesorio As EntAccesorio
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Accesorio = New EntAccesorio(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4).ToString, Tabla.Rows(fila).Item(5).ToString)
            LstAccesorio.Add(Accesorio)
        Next
        Return LstAccesorio
    End Function

    Public Sub eliminarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.eliminarAcc
        AccesorioGrabar("ELI", Accesorio)
    End Sub

    Public Sub ingresarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.ingresarAcc
        AccesorioGrabar("INS", Accesorio)
    End Sub

    Public Sub modificarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.modificarAcc
        AccesorioGrabar("MOD", Accesorio)
    End Sub

    Public Function buscarPrecioCantidad(ByVal opc As Integer, ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarPrecioCantidad
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim Tabla As DataTable = Nothing
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT PVP FROM VW_ACCESORIO WHERE IDACCESORIO = " + id
            Case 1
                cmd.CommandText = "SELECT STOCK,PVP FROM VW_ACCESORIO WHERE IDACCESORIO = " + id
            Case 2
                cmd.CommandText = "SELECT PRECIO FROM VW_SERVICIO WHERE IDSERVICIO = " + id
        End Select
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function

    Public Sub ingresarCom(ByVal Compra As Entidad.EntCompra) Implements Interfaz.IntDatos.ingresarCom
        CompraGrabar("INS", Compra)
    End Sub
    Public Sub CompraGrabar(ByVal opc As String, ByVal Compra As EntCompra)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_COMPRA"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Compra.com_ID
                .Add("@FECHA_REGISTRO", SqlDbType.Date).Value = Compra.com_Fecha
                .Add("@CODPROVEEDOR", SqlDbType.Int).Value = Compra.com_IDProveedor
                .Add("@SUBTOTAL", SqlDbType.Real).Value = Compra.com_Subtotal
                .Add("@IVA", SqlDbType.Real).Value = Compra.com_IVA
                .Add("@DESCUENTO", SqlDbType.Real).Value = Compra.com_Descuento
                .Add("@TOTAL", SqlDbType.Real).Value = Compra.com_Total
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub InventarioGrabar(ByVal opc As String, ByVal Inventario As EntCompraInventario)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_COMPRAINVENTARIO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@CODCOMPRA", SqlDbType.Int).Value = Inventario.inv_ID
                .Add("@CODACCESORIO", SqlDbType.Int).Value = Inventario.inv_IDAccesorio
                .Add("@CANTIDAD", SqlDbType.Int).Value = Inventario.inv_Cantidad
                .Add("@COSTO", SqlDbType.Real).Value = Inventario.inv_Costo
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Sub VentaGrabar(ByVal opc As String, ByVal Venta As EntVenta)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_VENTA"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = Venta.ven_ID
                .Add("@CODCLIENTE", SqlDbType.Int).Value = Venta.ven_IDCliente
                .Add("@FECHA_REGISTRO", SqlDbType.Date).Value = Venta.ven_Fecha
                .Add("@SUBTOTAL", SqlDbType.Real).Value = Venta.ven_Subtotal
                .Add("@IVA", SqlDbType.Real).Value = Venta.ven_IVA
                .Add("@DESCUENTO", SqlDbType.Real).Value = Venta.ven_Descuento
                .Add("@TOTAL", SqlDbType.Real).Value = Venta.ven_Total
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub DetalleGrabar(ByVal opc As String, ByVal Detalle As EntVentaDetalle)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_VENTADETALLE"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@CODVENTA", SqlDbType.Int).Value = Detalle.det_ID
                .Add("@CODACCESORIO", SqlDbType.Int).Value = Detalle.det_IDAccesorio
                .Add("@CANTIDAD", SqlDbType.Int).Value = Detalle.det_Cantidad
                .Add("@COSTO", SqlDbType.Real).Value = Detalle.det_Costo
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub VentaServicioGrabar(ByVal opc As String, ByVal Servicio As EntVentaServicio)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_VENTASERVICIO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@CODVENTA", SqlDbType.Int).Value = Servicio.venser_ID
                .Add("@CODSERVICIO", SqlDbType.Int).Value = Servicio.venser_IDServicio
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub ingresarComInv(ByVal Inventario As Entidad.EntCompraInventario) Implements Interfaz.IntDatos.ingresarComInv
        InventarioGrabar("INS", Inventario)
    End Sub

    Public Sub ingresarVen(ByVal Venta As Entidad.EntVenta) Implements Interfaz.IntDatos.ingresarVen
        VentaGrabar("INS", Venta)
    End Sub

    Public Sub ingresarVenDet(ByVal Detalle As Entidad.EntVentaDetalle) Implements Interfaz.IntDatos.ingresarVenDet
        DetalleGrabar("INS", Detalle)
    End Sub

    Public Sub ingresarVenSer(ByVal Servicio As Entidad.EntVentaServicio) Implements Interfaz.IntDatos.ingresarVenSer
        VentaServicioGrabar("INS", Servicio)
    End Sub

    Public Function CargarHistorial(ByVal opc As String, ByVal filtro As String, ByVal id As Integer) As DataTable
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim Tabla As DataTable = Nothing
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_HISTORIAL"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@FILTRO", SqlDbType.VarChar).Value = filtro
                .Add("@ID", SqlDbType.VarChar).Value = id
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function

    Public Function buscarAudCompra(ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudCompra
        Return CargarHistorial(1, filtro, 0)
    End Function

    Public Function buscarAudDetVenta(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudDetVenta
        Return CargarHistorial(3, filtro, id)
    End Function

    Public Function buscarAudInv(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudInv
        Return CargarHistorial(2, filtro, id)
    End Function

    Public Function buscarAudSer(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudSer
        Return CargarHistorial(4, filtro, id)
    End Function

    Public Function buscarAudVenta(ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudVenta
        Return CargarHistorial(0, filtro, 0)
    End Function
End Class

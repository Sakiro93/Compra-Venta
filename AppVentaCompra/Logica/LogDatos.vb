Imports Interfaz
Imports AccesoDatos

Public Class LogDatos
    Implements IntDatos
    Dim logicadatos As New AccDatos()
    Public Function buscarCli(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCliente) Implements Interfaz.IntDatos.buscarCli
        Return logicadatos.buscarCli(filtro)
    End Function

    Public Function buscarPro(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntProveedor) Implements Interfaz.IntDatos.buscarPro
        Return logicadatos.buscarPro(filtro)
    End Function

    Public Sub eliminarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.eliminarCli
        logicadatos.eliminarCli(Cliente)
    End Sub

    Public Sub eliminarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.eliminarPro
        logicadatos.eliminarPro(Proveedor)
    End Sub

    Public Sub ingresarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.ingresarCli
        logicadatos.ingresarCli(Cliente)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.ingresarPro
        logicadatos.ingresarPro(Proveedor)
    End Sub

    Public Sub modificarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.modificarCli
        logicadatos.modificarCli(Cliente)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.modificarPro
        logicadatos.modificarPro(Proveedor)
    End Sub

    Public Function buscarSer(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntServicio) Implements Interfaz.IntDatos.buscarSer
        Return logicadatos.buscarSer(filtro)
    End Function

    Public Sub eliminarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.eliminarSer
        logicadatos.eliminarSer(Servicio)
    End Sub

    Public Sub ingresarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.ingresarSer
        logicadatos.ingresarSer(Servicio)
    End Sub

    Public Sub modificarSer(ByVal Servicio As Entidad.EntServicio) Implements Interfaz.IntDatos.modificarSer
        logicadatos.modificarSer(Servicio)
    End Sub

    Public Function buscarPar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntParte) Implements Interfaz.IntDatos.buscarPar
        Return logicadatos.buscarPar(filtro)
    End Function

    Public Sub eliminarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.eliminarPar
        logicadatos.eliminarPar(Parte)
    End Sub

    Public Sub ingresarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.ingresarPar
        logicadatos.ingresarPar(Parte)
    End Sub

    Public Sub modificarPar(ByVal Parte As Entidad.EntParte) Implements Interfaz.IntDatos.modificarPar
        logicadatos.modificarPar(Parte)
    End Sub

    Public Sub llenarCombo(ByVal opc As Integer, ByVal Combo As System.Windows.Forms.ComboBox) Implements Interfaz.IntDatos.llenarCombo
        logicadatos.llenarCombo(opc, Combo)
    End Sub

    Public Function buscarAcc(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntAccesorio) Implements Interfaz.IntDatos.buscarAcc
        Return logicadatos.buscarAcc(filtro)
    End Function

    Public Sub eliminarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.eliminarAcc
        logicadatos.eliminarAcc(Accesorio)
    End Sub

    Public Sub ingresarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.ingresarAcc
        logicadatos.ingresarAcc(Accesorio)
    End Sub

    Public Sub modificarAcc(ByVal Accesorio As Entidad.EntAccesorio) Implements Interfaz.IntDatos.modificarAcc
        logicadatos.modificarAcc(Accesorio)
    End Sub

    Public Function buscarPrecioCantidad(ByVal opc As Integer, ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarPrecioCantidad
        Return logicadatos.buscarPrecioCantidad(opc, id)
    End Function

    Public Sub ingresarCom(ByVal Compra As Entidad.EntCompra) Implements Interfaz.IntDatos.ingresarCom
        logicadatos.ingresarCom(Compra)
    End Sub

    Public Sub ingresarComInv(ByVal Inventario As Entidad.EntCompraInventario) Implements Interfaz.IntDatos.ingresarComInv
        logicadatos.ingresarComInv(Inventario)
    End Sub

    Public Sub ingresarVen(ByVal Venta As Entidad.EntVenta) Implements Interfaz.IntDatos.ingresarVen
        logicadatos.ingresarVen(Venta)
    End Sub

    Public Sub ingresarVenDet(ByVal Detalle As Entidad.EntVentaDetalle) Implements Interfaz.IntDatos.ingresarVenDet
        logicadatos.ingresarVenDet(Detalle)
    End Sub

    Public Sub ingresarVenSer(ByVal Servicio As Entidad.EntVentaServicio) Implements Interfaz.IntDatos.ingresarVenSer
        logicadatos.ingresarVenSer(Servicio)
    End Sub

    Public Function buscarAudCompra(ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudCompra
        Return logicadatos.buscarAudCompra(filtro)
    End Function

    Public Function buscarAudDetVenta(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudDetVenta
        Return logicadatos.buscarAudDetVenta(filtro, id)
    End Function

    Public Function buscarAudInv(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudInv
        Return logicadatos.buscarAudInv(filtro, id)
    End Function

    Public Function buscarAudSer(ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudSer
        Return logicadatos.buscarAudSer(filtro, id)
    End Function

    Public Function buscarAudVenta(ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudVenta
        Return logicadatos.buscarAudVenta(filtro)
    End Function
End Class

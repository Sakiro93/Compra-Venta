Imports Entidad

Public Interface IntDatos
    'Cliente'
    Sub ingresarCli(ByVal Cliente As EntCliente)
    Sub modificarCli(ByVal Cliente As EntCliente)
    Sub eliminarCli(ByVal Cliente As EntCliente)
    Function buscarCli(ByVal filtro As String) As List(Of EntCliente)
    'Proveedor'
    Sub ingresarPro(ByVal Proveedor As EntProveedor)
    Sub modificarPro(ByVal Proveedor As EntProveedor)
    Sub eliminarPro(ByVal Proveedor As EntProveedor)
    Function buscarPro(ByVal filtro As String) As List(Of EntProveedor)
    'Servicio'
    Sub ingresarSer(ByVal Servicio As EntServicio)
    Sub modificarSer(ByVal Servicio As EntServicio)
    Sub eliminarSer(ByVal Servicio As EntServicio)
    Function buscarSer(ByVal filtro As String) As List(Of EntServicio)
    'Parte'
    Sub ingresarPar(ByVal Parte As EntParte)
    Sub modificarPar(ByVal Parte As EntParte)
    Sub eliminarPar(ByVal Parte As EntParte)
    Function buscarPar(ByVal filtro As String) As List(Of EntParte)
    'Combo  
    Sub llenarCombo(ByVal opc As Integer, ByVal Combo As ComboBox)
    'Accesorio
    Sub ingresarAcc(ByVal Accesorio As EntAccesorio)
    Sub modificarAcc(ByVal Accesorio As EntAccesorio)
    Sub eliminarAcc(ByVal Accesorio As EntAccesorio)
    Function buscarAcc(ByVal filtro As String) As List(Of EntAccesorio)
    'Precio y Cantidad
    Function buscarPrecioCantidad(ByVal opc As Integer, ByVal id As String) As DataTable
    'Compra
    Sub ingresarCom(ByVal Compra As EntCompra)
    Sub ingresarComInv(ByVal Inventario As EntCompraInventario)
    'Venta
    Sub ingresarVen(ByVal Venta As EntVenta)
    Sub ingresarVenSer(ByVal Servicio As EntVentaServicio)
    Sub ingresarVenDet(ByVal Detalle As EntVentaDetalle)
    'Historial
    Function buscarAudVenta(ByVal filtro As String) As DataTable
    Function buscarAudCompra(ByVal filtro As String) As DataTable
    Function buscarAudSer(ByVal filtro As String, ByVal id As Integer) As DataTable
    Function buscarAudDetVenta(ByVal filtro As String, ByVal id As Integer) As DataTable
    Function buscarAudInv(ByVal filtro As String, ByVal id As Integer) As DataTable
End Interface

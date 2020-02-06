Public Class Menu
    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        Cliente.ShowDialog()
    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        Proveedor.ShowDialog()
    End Sub

    Private Sub BtnAccesorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccesorio.Click
        Accesorio.ShowDialog()
    End Sub

    Private Sub BtnServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServicio.Click
        Servicio.ShowDialog()
    End Sub

    Private Sub BtnParte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParte.Click
        Parte.ShowDialog()
    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click
        Venta.ShowDialog()
    End Sub

    Private Sub BtnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompra.Click
        Compra.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Historial.ShowDialog()
    End Sub
End Class
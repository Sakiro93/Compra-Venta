Imports Entidad

Public Class Cliente
    Private Validacion As Validaciones = New Validaciones
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        RBHombre.Checked = True
        Validacion.LimpiarGroupbox(GrupCliDatos)
        Validacion.LimpiarGroupbox(GrupCliReg)
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each cli In Logicadatos.buscarCli(Buscar)
            Dg.Rows.Add(cli.cli_ID, cli.cli_Cedula, cli.cli_Nombres, cli.cli_Apellidos, cli.cli_Telefono, cli.cli_Email, cli.cli_Direccion, If(cli.cli_Sexo, "Hombre", "Mujer"))
        Next
    End Sub
    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim datos = New EntCliente(Cod, TxtCliCedula.Text, TxtCliNom.Text, TxtCliApelli.Text, TxtCliTelefono.Text, TxtCliEmail.Text, TxtCliDirec.Text, RBHombre.Checked)
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Validacion.ValidaEntrada(ErrDatos, GrupCliDatos) Then
                If grabarG = "N" Then
                    Logicadatos.ingresarCli(datos)
                Else
                    Logicadatos.modificarCli(datos)
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
        Dim datos = New EntCliente(Cod, TxtCliCedula.Text, TxtCliNom.Text, TxtCliApelli.Text, TxtCliTelefono.Text, TxtCliEmail.Text, TxtCliDirec.Text, RBHombre.Checked)
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Compra y Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Logicadatos.eliminarCli(datos)
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
        TxtCliCedula.Text = Dg.Rows(i).Cells(1).Value.ToString
        TxtCliNom.Text = Dg.Rows(i).Cells(2).Value.ToString
        TxtCliApelli.Text = Dg.Rows(i).Cells(3).Value.ToString
        TxtCliTelefono.Text = Dg.Rows(i).Cells(4).Value.ToString
        TxtCliEmail.Text = Dg.Rows(i).Cells(5).Value.ToString
        TxtCliDirec.Text = Dg.Rows(i).Cells(6).Value.ToString
        If Dg.Rows(i).Cells(7).Value.ToString = "Hombre" Then
            RBHombre.Checked = True
        Else
            RBMujer.Checked = True
        End If
        Validacion.Botones(3)
    End Sub

    Private Sub TxtCliTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCliTelefono.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub

    Private Sub TxtCliApelli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCliApelli.KeyPress
        Validacion.ValidarLetras(e)
    End Sub

    Private Sub TxtCliNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCliNom.KeyPress
        Validacion.ValidarLetras(e)
    End Sub

    Private Sub TxtCliCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCliCedula.KeyPress
        Validacion.ValidarNumeros(e)
    End Sub

    Private Sub TxtCliEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCliEmail.KeyPress
        Validacion.ValidarEspacio(e)
    End Sub
End Class
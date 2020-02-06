Public Class Validaciones
    Dim Boton() As Button
    Dim con As Integer = 0
    '------------------Funciones---------------------'
    Public Sub Cargar_Botones(ByVal I As Integer, ByVal GB As GroupBox)
        ReDim Boton(I)
        Dim C As Integer = 0
        For Each Btn In GB.Controls
            If TypeOf Btn Is Button Then
                Boton(C) = Btn
                'MessageBox.Show(Btn.Name)
                C += 1
            End If
        Next
    End Sub
    Public Sub Botones(ByVal Opc As Integer)
        '1:Inicial, 2:Nuevo, 3:Click'
        '4:Inicial, 5:Nuevo'
        Select Case Opc
            Case 1
                Boton(0).Enabled = True 'Regresar'
                Boton(1).Enabled = False 'Modificar'
                Boton(2).Enabled = False 'Eliminar'
                Boton(3).Enabled = False 'Guardar'
                Boton(4).Enabled = True  'Nuevo'
            Case 2
                Boton(0).Enabled = False 'Regresar'
                Boton(1).Enabled = False 'Modificar'
                Boton(2).Enabled = False 'Eliminar'
                Boton(3).Enabled = True 'Guardar'
                Boton(4).Enabled = False  'Nuevo'
            Case 3
                Boton(0).Enabled = True 'Regresar'
                Boton(1).Enabled = True 'Modificar'
                Boton(2).Enabled = True 'Eliminar'
                Boton(3).Enabled = False 'Guardar'
                Boton(4).Enabled = True  'Nuevo'
            Case 4
                Boton(0).Enabled = True 'Regresar'
                Boton(1).Enabled = True 'Modificar'
                Boton(2).Enabled = True 'Eliminar'
                Boton(3).Enabled = True 'Guardar'
                Boton(4).Enabled = True  'Nuevo'
            Case 5
                Boton(0).Enabled = False 'Guardar'
                Boton(1).Enabled = True  'Nuevo'
                Boton(2).Enabled = True  'Regresar'
            Case 6
                Boton(0).Enabled = True  'Guardar'
                Boton(1).Enabled = False 'Nuevo'
                Boton(2).Enabled = False  'Regresar'

        End Select
    End Sub
    Public Sub Habilitar_GroupBox(ByVal GB As GroupBox, ByVal Opc As Integer)
        Select Case Opc
            Case 1
                GB.Enabled = True
            Case 2
                GB.Enabled = False
        End Select

    End Sub

    Public Sub LimpiarGroupbox(ByVal Grp As GroupBox)
        For Each C In Grp.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is DateTimePicker Then C = Date.Now
        Next
    End Sub
    Public Sub LimpiarTodo(ByVal Grp As GroupBox)
        For Each C In Grp.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.SelectedIndex = 0
            If TypeOf C Is DateTimePicker Then C = Date.Now
        Next
    End Sub

    Public Sub tooltip(ByVal TooMensaje As ToolTip, ByVal GB As GroupBox)
        For Each Btn In GB.Controls
            If TypeOf Btn Is Button Then
                If Btn.Text = "REGRESAR" Then
                    TooMensaje.SetToolTip(Btn, "Regresar a la Ventana Anterior")
                End If
                If Btn.Text = "NUEVO" Then
                    TooMensaje.SetToolTip(Btn, "Realizar un Nuevo Registro")
                End If
                If Btn.Text = "GUARDAR" Then
                    TooMensaje.SetToolTip(Btn, "Guardar Datos")
                End If
                If Btn.Text = "ELIMINAR" Then
                    TooMensaje.SetToolTip(Btn, "Eliminar Registro")
                End If
                If Btn.Text = "MODIFICAR" Then
                    TooMensaje.SetToolTip(Btn, "Modificar Registro")
                End If
                If Btn.Text = "AGREGAR" Then
                    TooMensaje.SetToolTip(Btn, "Agregar Articulo")
                End If
            End If
        Next

        TooMensaje.ToolTipTitle = "Sistema de Ventas de Mercadería"
        TooMensaje.ToolTipIcon = ToolTipIcon.None
        TooMensaje.BackColor = Color.Transparent
    End Sub

    '------------------Validaciones---------------------'
    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        err.Clear()
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                If C.Name <> "TxtEmail" And C.Name <> "TxtComentario" Then
                    err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                    er = False
                End If
            End If
            If TypeOf C Is ComboBox And C.Text = "" Then
                err.SetError(C, "No ha Seleccionado ninguna opcion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Public Sub ValidarLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Public Sub ValidarNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Public Sub ValidarPrecio(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal TxtPrecio As TextBox)
        If Not TxtPrecio.Text.Contains(",") Then
            con = 0
        End If
        If e.KeyChar = "," AndAlso Not TxtPrecio.Text.Contains(",") Then
            e.Handled = False
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso Not TxtPrecio.Text.Contains(",") Then
                e.Handled = True
            Else
                If TxtPrecio.Text.Contains(",") Then
                    If Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso con < 2 Then
                        con += 1
                    Else
                        If e.KeyChar = vbBack Then
                            con -= 1
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub ValidarEspacio(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.GrupOpciones = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GrupCliReg = New System.Windows.Forms.GroupBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GrupCliDatos = New System.Windows.Forms.GroupBox()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.TxtCliEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCliCedula = New System.Windows.Forms.TextBox()
        Me.TxtCliDirec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCliNom = New System.Windows.Forms.TextBox()
        Me.TxtCliApelli = New System.Windows.Forms.TextBox()
        Me.TxtCliTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GrupOpciones.SuspendLayout()
        Me.GrupCliReg.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupCliDatos.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrupOpciones
        '
        Me.GrupOpciones.BackColor = System.Drawing.Color.LightBlue
        Me.GrupOpciones.Controls.Add(Me.BtnRegresar)
        Me.GrupOpciones.Controls.Add(Me.BtnModificar)
        Me.GrupOpciones.Controls.Add(Me.BtnEliminar)
        Me.GrupOpciones.Controls.Add(Me.BtnGuardar)
        Me.GrupOpciones.Controls.Add(Me.BtnNuevo)
        Me.GrupOpciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupOpciones.Location = New System.Drawing.Point(716, 59)
        Me.GrupOpciones.Name = "GrupOpciones"
        Me.GrupOpciones.Size = New System.Drawing.Size(157, 491)
        Me.GrupOpciones.TabIndex = 44
        Me.GrupOpciones.TabStop = False
        Me.GrupOpciones.Text = "Opciones"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.White
        Me.BtnRegresar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = CType(resources.GetObject("BtnRegresar.Image"), System.Drawing.Image)
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(16, 346)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(125, 47)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(16, 269)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(125, 53)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(13, 198)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(125, 47)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(16, 125)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(125, 47)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.White
        Me.BtnNuevo.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 59)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(125, 47)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'GrupCliReg
        '
        Me.GrupCliReg.BackColor = System.Drawing.Color.LightBlue
        Me.GrupCliReg.Controls.Add(Me.Dg)
        Me.GrupCliReg.Controls.Add(Me.TxtBuscar)
        Me.GrupCliReg.Controls.Add(Me.Label8)
        Me.GrupCliReg.Location = New System.Drawing.Point(26, 324)
        Me.GrupCliReg.Name = "GrupCliReg"
        Me.GrupCliReg.Size = New System.Drawing.Size(669, 226)
        Me.GrupCliReg.TabIndex = 43
        Me.GrupCliReg.TabStop = False
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cedula, Me.Nombre, Me.Apellido, Me.Telefono, Me.Email, Me.Direccion, Me.Sexo})
        Me.Dg.Location = New System.Drawing.Point(6, 81)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(641, 120)
        Me.Dg.TabIndex = 7
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtBuscar.Location = New System.Drawing.Point(179, 22)
        Me.TxtBuscar.MaxLength = 20
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(182, 37)
        Me.TxtBuscar.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(33, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 47)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Buscar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrupCliDatos
        '
        Me.GrupCliDatos.BackColor = System.Drawing.Color.LightBlue
        Me.GrupCliDatos.Controls.Add(Me.RBMujer)
        Me.GrupCliDatos.Controls.Add(Me.RBHombre)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliEmail)
        Me.GrupCliDatos.Controls.Add(Me.Label7)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliCedula)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliDirec)
        Me.GrupCliDatos.Controls.Add(Me.Label4)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliNom)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliApelli)
        Me.GrupCliDatos.Controls.Add(Me.TxtCliTelefono)
        Me.GrupCliDatos.Controls.Add(Me.Label6)
        Me.GrupCliDatos.Controls.Add(Me.Label5)
        Me.GrupCliDatos.Controls.Add(Me.Label3)
        Me.GrupCliDatos.Controls.Add(Me.Label2)
        Me.GrupCliDatos.Controls.Add(Me.label1)
        Me.GrupCliDatos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupCliDatos.Location = New System.Drawing.Point(26, 59)
        Me.GrupCliDatos.Name = "GrupCliDatos"
        Me.GrupCliDatos.Size = New System.Drawing.Size(669, 259)
        Me.GrupCliDatos.TabIndex = 42
        Me.GrupCliDatos.TabStop = False
        Me.GrupCliDatos.Text = "INGRESE DATOS"
        '
        'RBMujer
        '
        Me.RBMujer.BackColor = System.Drawing.Color.LightBlue
        Me.RBMujer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMujer.Location = New System.Drawing.Point(390, 206)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(112, 22)
        Me.RBMujer.TabIndex = 55
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = False
        '
        'RBHombre
        '
        Me.RBHombre.BackColor = System.Drawing.Color.LightBlue
        Me.RBHombre.Checked = True
        Me.RBHombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBHombre.Location = New System.Drawing.Point(390, 173)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(112, 24)
        Me.RBHombre.TabIndex = 56
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = False
        '
        'TxtCliEmail
        '
        Me.TxtCliEmail.Location = New System.Drawing.Point(394, 50)
        Me.TxtCliEmail.MaxLength = 30
        Me.TxtCliEmail.Name = "TxtCliEmail"
        Me.TxtCliEmail.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliEmail.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "EMAIL"
        '
        'TxtCliCedula
        '
        Me.TxtCliCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliCedula.Location = New System.Drawing.Point(122, 50)
        Me.TxtCliCedula.MaxLength = 10
        Me.TxtCliCedula.Name = "TxtCliCedula"
        Me.TxtCliCedula.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliCedula.TabIndex = 52
        '
        'TxtCliDirec
        '
        Me.TxtCliDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliDirec.Location = New System.Drawing.Point(394, 106)
        Me.TxtCliDirec.MaxLength = 50
        Me.TxtCliDirec.Name = "TxtCliDirec"
        Me.TxtCliDirec.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliDirec.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "DIRECCION"
        '
        'TxtCliNom
        '
        Me.TxtCliNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliNom.Location = New System.Drawing.Point(122, 98)
        Me.TxtCliNom.MaxLength = 50
        Me.TxtCliNom.Name = "TxtCliNom"
        Me.TxtCliNom.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliNom.TabIndex = 48
        '
        'TxtCliApelli
        '
        Me.TxtCliApelli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliApelli.Location = New System.Drawing.Point(122, 149)
        Me.TxtCliApelli.MaxLength = 50
        Me.TxtCliApelli.Name = "TxtCliApelli"
        Me.TxtCliApelli.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliApelli.TabIndex = 47
        '
        'TxtCliTelefono
        '
        Me.TxtCliTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliTelefono.Location = New System.Drawing.Point(122, 202)
        Me.TxtCliTelefono.MaxLength = 10
        Me.TxtCliTelefono.Name = "TxtCliTelefono"
        Me.TxtCliTelefono.Size = New System.Drawing.Size(131, 26)
        Me.TxtCliTelefono.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "SEXO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CEDULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "NOMBRE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 152)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 18)
        Me.label1.TabIndex = 35
        Me.label1.Text = "APELLIDO"
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.SystemColors.Highlight
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTitulo.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(892, 42)
        Me.LblTitulo.TabIndex = 41
        Me.LblTitulo.Text = "MANTENIMIENTO CLIENTES"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 565)
        Me.Controls.Add(Me.GrupOpciones)
        Me.Controls.Add(Me.GrupCliReg)
        Me.Controls.Add(Me.GrupCliDatos)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GrupOpciones.ResumeLayout(False)
        Me.GrupCliReg.ResumeLayout(False)
        Me.GrupCliReg.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupCliDatos.ResumeLayout(False)
        Me.GrupCliDatos.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrupOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents GrupCliReg As System.Windows.Forms.GroupBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GrupCliDatos As System.Windows.Forms.GroupBox
    Friend WithEvents RBMujer As System.Windows.Forms.RadioButton
    Friend WithEvents RBHombre As System.Windows.Forms.RadioButton
    Friend WithEvents TxtCliEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCliCedula As System.Windows.Forms.TextBox
    Friend WithEvents TxtCliDirec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCliNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtCliApelli As System.Windows.Forms.TextBox
    Friend WithEvents TxtCliTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

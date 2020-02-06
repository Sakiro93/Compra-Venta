<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleVenta))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TC_Historial = New System.Windows.Forms.TabControl()
        Me.Accesorio = New System.Windows.Forms.TabPage()
        Me.GBAccesorio = New System.Windows.Forms.GroupBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgAccesorio = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.TabPage()
        Me.GBServicio = New System.Windows.Forms.GroupBox()
        Me.DgServicio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBuscarServicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TC_Historial.SuspendLayout()
        Me.Accesorio.SuspendLayout()
        Me.GBAccesorio.SuspendLayout()
        CType(Me.DgAccesorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Servicio.SuspendLayout()
        Me.GBServicio.SuspendLayout()
        CType(Me.DgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.SystemColors.Highlight
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTitulo.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(10, 18)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(929, 42)
        Me.LblTitulo.TabIndex = 46
        Me.LblTitulo.Text = "DETALLE VENTA"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TC_Historial
        '
        Me.TC_Historial.Controls.Add(Me.Accesorio)
        Me.TC_Historial.Controls.Add(Me.Servicio)
        Me.TC_Historial.Location = New System.Drawing.Point(17, 80)
        Me.TC_Historial.Name = "TC_Historial"
        Me.TC_Historial.SelectedIndex = 0
        Me.TC_Historial.Size = New System.Drawing.Size(922, 383)
        Me.TC_Historial.TabIndex = 47
        '
        'Accesorio
        '
        Me.Accesorio.BackColor = System.Drawing.Color.LightBlue
        Me.Accesorio.Controls.Add(Me.GBAccesorio)
        Me.Accesorio.Location = New System.Drawing.Point(4, 22)
        Me.Accesorio.Name = "Accesorio"
        Me.Accesorio.Padding = New System.Windows.Forms.Padding(3)
        Me.Accesorio.Size = New System.Drawing.Size(914, 357)
        Me.Accesorio.TabIndex = 0
        Me.Accesorio.Text = "Accesorio"
        '
        'GBAccesorio
        '
        Me.GBAccesorio.Controls.Add(Me.TxtBuscar)
        Me.GBAccesorio.Controls.Add(Me.Label8)
        Me.GBAccesorio.Controls.Add(Me.DgAccesorio)
        Me.GBAccesorio.Location = New System.Drawing.Point(6, 6)
        Me.GBAccesorio.Name = "GBAccesorio"
        Me.GBAccesorio.Size = New System.Drawing.Size(902, 345)
        Me.GBAccesorio.TabIndex = 0
        Me.GBAccesorio.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtBuscar.Location = New System.Drawing.Point(172, 27)
        Me.TxtBuscar.MaxLength = 20
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(182, 37)
        Me.TxtBuscar.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(26, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 47)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Buscar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgAccesorio
        '
        Me.DgAccesorio.AllowUserToAddRows = False
        Me.DgAccesorio.AllowUserToDeleteRows = False
        Me.DgAccesorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgAccesorio.BackgroundColor = System.Drawing.Color.White
        Me.DgAccesorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAccesorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAccesorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cedula, Me.Nombre, Me.Costo, Me.Sexo, Me.Hora, Me.Usuario, Me.Estacion, Me.Tipo})
        Me.DgAccesorio.Location = New System.Drawing.Point(29, 92)
        Me.DgAccesorio.Name = "DgAccesorio"
        Me.DgAccesorio.ReadOnly = True
        Me.DgAccesorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAccesorio.Size = New System.Drawing.Size(848, 232)
        Me.DgAccesorio.TabIndex = 11
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Accesorio"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Cantidad"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Fecha"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Estacion
        '
        Me.Estacion.HeaderText = "Estacion"
        Me.Estacion.Name = "Estacion"
        Me.Estacion.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Servicio
        '
        Me.Servicio.BackColor = System.Drawing.Color.LightBlue
        Me.Servicio.Controls.Add(Me.GBServicio)
        Me.Servicio.Location = New System.Drawing.Point(4, 22)
        Me.Servicio.Name = "Servicio"
        Me.Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.Servicio.Size = New System.Drawing.Size(914, 357)
        Me.Servicio.TabIndex = 1
        Me.Servicio.Text = "Servicio"
        '
        'GBServicio
        '
        Me.GBServicio.Controls.Add(Me.DgServicio)
        Me.GBServicio.Controls.Add(Me.TxtBuscarServicio)
        Me.GBServicio.Controls.Add(Me.Label1)
        Me.GBServicio.Location = New System.Drawing.Point(3, 6)
        Me.GBServicio.Name = "GBServicio"
        Me.GBServicio.Size = New System.Drawing.Size(905, 345)
        Me.GBServicio.TabIndex = 0
        Me.GBServicio.TabStop = False
        '
        'DgServicio
        '
        Me.DgServicio.AllowUserToAddRows = False
        Me.DgServicio.AllowUserToDeleteRows = False
        Me.DgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgServicio.BackgroundColor = System.Drawing.Color.White
        Me.DgServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.DgServicio.Location = New System.Drawing.Point(30, 94)
        Me.DgServicio.Name = "DgServicio"
        Me.DgServicio.ReadOnly = True
        Me.DgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgServicio.Size = New System.Drawing.Size(848, 232)
        Me.DgServicio.TabIndex = 17
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Estacion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'TxtBuscarServicio
        '
        Me.TxtBuscarServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtBuscarServicio.Location = New System.Drawing.Point(173, 27)
        Me.TxtBuscarServicio.MaxLength = 20
        Me.TxtBuscarServicio.Multiline = True
        Me.TxtBuscarServicio.Name = "TxtBuscarServicio"
        Me.TxtBuscarServicio.Size = New System.Drawing.Size(182, 37)
        Me.TxtBuscarServicio.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 47)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Buscar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.BtnRegresar)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 469)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 77)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.White
        Me.BtnRegresar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = CType(resources.GetObject("BtnRegresar.Image"), System.Drawing.Image)
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(395, 15)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(125, 47)
        Me.BtnRegresar.TabIndex = 47
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.TC_Historial)
        Me.Name = "DetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleVenta"
        Me.TC_Historial.ResumeLayout(False)
        Me.Accesorio.ResumeLayout(False)
        Me.GBAccesorio.ResumeLayout(False)
        Me.GBAccesorio.PerformLayout()
        CType(Me.DgAccesorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Servicio.ResumeLayout(False)
        Me.GBServicio.ResumeLayout(False)
        Me.GBServicio.PerformLayout()
        CType(Me.DgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents TC_Historial As System.Windows.Forms.TabControl
    Friend WithEvents Accesorio As System.Windows.Forms.TabPage
    Friend WithEvents Servicio As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents GBAccesorio As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DgAccesorio As System.Windows.Forms.DataGridView
    Friend WithEvents GBServicio As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscarServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgServicio As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

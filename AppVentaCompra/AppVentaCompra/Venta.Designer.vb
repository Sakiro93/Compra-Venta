<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.btnAgregarAcc = New System.Windows.Forms.Button()
        Me.btnEliminarAcc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrupVentDatos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAddCliente = New System.Windows.Forms.Button()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.GrupOpciones = New System.Windows.Forms.GroupBox()
        Me.OpcNinguna = New System.Windows.Forms.RadioButton()
        Me.Opc12 = New System.Windows.Forms.RadioButton()
        Me.txtVentTotal = New System.Windows.Forms.TextBox()
        Me.txtVentDesc = New System.Windows.Forms.TextBox()
        Me.lblVentTotal = New System.Windows.Forms.Label()
        Me.lblVentIva = New System.Windows.Forms.Label()
        Me.lblVentDesc = New System.Windows.Forms.Label()
        Me.lblVentCodCli = New System.Windows.Forms.Label()
        Me.txtVentSub = New System.Windows.Forms.TextBox()
        Me.lblVentSub = New System.Windows.Forms.Label()
        Me.GrupVenReg = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextAccTotal = New System.Windows.Forms.TextBox()
        Me.btnEliminarSer = New System.Windows.Forms.Button()
        Me.btnAgregarSer = New System.Windows.Forms.Button()
        Me.DgServicio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgAccesorio = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accesorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextSerCosto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbAccesorio = New System.Windows.Forms.ComboBox()
        Me.LblVentCant2 = New System.Windows.Forms.Label()
        Me.LblVentCant = New System.Windows.Forms.Label()
        Me.TxtVentCant = New System.Windows.Forms.TextBox()
        Me.GrupCatAcc = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnSeguirComp = New System.Windows.Forms.Button()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GrupVentDatos.SuspendLayout()
        Me.GrupOpciones.SuspendLayout()
        Me.GrupVenReg.SuspendLayout()
        CType(Me.DgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAccesorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupCatAcc.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarAcc
        '
        Me.btnAgregarAcc.BackColor = System.Drawing.Color.Black
        Me.btnAgregarAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarAcc.FlatAppearance.BorderSize = 0
        Me.btnAgregarAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAcc.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAcc.ForeColor = System.Drawing.Color.White
        Me.btnAgregarAcc.Image = CType(resources.GetObject("btnAgregarAcc.Image"), System.Drawing.Image)
        Me.btnAgregarAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarAcc.Location = New System.Drawing.Point(44, 118)
        Me.btnAgregarAcc.Name = "btnAgregarAcc"
        Me.btnAgregarAcc.Size = New System.Drawing.Size(141, 56)
        Me.btnAgregarAcc.TabIndex = 4
        Me.btnAgregarAcc.Text = "AGREGAR"
        Me.btnAgregarAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarAcc.UseVisualStyleBackColor = False
        '
        'btnEliminarAcc
        '
        Me.btnEliminarAcc.BackColor = System.Drawing.Color.Black
        Me.btnEliminarAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarAcc.FlatAppearance.BorderSize = 0
        Me.btnEliminarAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarAcc.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarAcc.ForeColor = System.Drawing.Color.White
        Me.btnEliminarAcc.Image = CType(resources.GetObject("btnEliminarAcc.Image"), System.Drawing.Image)
        Me.btnEliminarAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarAcc.Location = New System.Drawing.Point(272, 118)
        Me.btnEliminarAcc.Name = "btnEliminarAcc"
        Me.btnEliminarAcc.Size = New System.Drawing.Size(141, 56)
        Me.btnEliminarAcc.TabIndex = 0
        Me.btnEliminarAcc.Text = "ELIMINAR"
        Me.btnEliminarAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarAcc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 43)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Realizar Venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrupVentDatos
        '
        Me.GrupVentDatos.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupVentDatos.Controls.Add(Me.Label5)
        Me.GrupVentDatos.Controls.Add(Me.BtnAddCliente)
        Me.GrupVentDatos.Controls.Add(Me.cboCliente)
        Me.GrupVentDatos.Controls.Add(Me.GrupOpciones)
        Me.GrupVentDatos.Controls.Add(Me.txtVentTotal)
        Me.GrupVentDatos.Controls.Add(Me.txtVentDesc)
        Me.GrupVentDatos.Controls.Add(Me.lblVentTotal)
        Me.GrupVentDatos.Controls.Add(Me.lblVentIva)
        Me.GrupVentDatos.Controls.Add(Me.lblVentDesc)
        Me.GrupVentDatos.Controls.Add(Me.lblVentCodCli)
        Me.GrupVentDatos.Controls.Add(Me.txtVentSub)
        Me.GrupVentDatos.Controls.Add(Me.lblVentSub)
        Me.GrupVentDatos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupVentDatos.Location = New System.Drawing.Point(12, 56)
        Me.GrupVentDatos.Name = "GrupVentDatos"
        Me.GrupVentDatos.Size = New System.Drawing.Size(806, 136)
        Me.GrupVentDatos.TabIndex = 52
        Me.GrupVentDatos.TabStop = False
        Me.GrupVentDatos.Text = "INGRESE DATOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "%"
        '
        'BtnAddCliente
        '
        Me.BtnAddCliente.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddCliente.Image = CType(resources.GetObject("BtnAddCliente.Image"), System.Drawing.Image)
        Me.BtnAddCliente.Location = New System.Drawing.Point(338, 30)
        Me.BtnAddCliente.Name = "BtnAddCliente"
        Me.BtnAddCliente.Size = New System.Drawing.Size(53, 38)
        Me.BtnAddCliente.TabIndex = 18
        Me.BtnAddCliente.UseVisualStyleBackColor = False
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(129, 35)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(183, 25)
        Me.cboCliente.TabIndex = 17
        '
        'GrupOpciones
        '
        Me.GrupOpciones.Controls.Add(Me.OpcNinguna)
        Me.GrupOpciones.Controls.Add(Me.Opc12)
        Me.GrupOpciones.Location = New System.Drawing.Point(558, 26)
        Me.GrupOpciones.Name = "GrupOpciones"
        Me.GrupOpciones.Size = New System.Drawing.Size(170, 39)
        Me.GrupOpciones.TabIndex = 14
        Me.GrupOpciones.TabStop = False
        '
        'OpcNinguna
        '
        Me.OpcNinguna.AutoSize = True
        Me.OpcNinguna.Location = New System.Drawing.Point(72, 13)
        Me.OpcNinguna.Name = "OpcNinguna"
        Me.OpcNinguna.Size = New System.Drawing.Size(86, 21)
        Me.OpcNinguna.TabIndex = 17
        Me.OpcNinguna.TabStop = True
        Me.OpcNinguna.Text = "Ninguna"
        Me.OpcNinguna.UseVisualStyleBackColor = True
        '
        'Opc12
        '
        Me.Opc12.AutoSize = True
        Me.Opc12.Checked = True
        Me.Opc12.Location = New System.Drawing.Point(9, 13)
        Me.Opc12.Name = "Opc12"
        Me.Opc12.Size = New System.Drawing.Size(57, 21)
        Me.Opc12.TabIndex = 16
        Me.Opc12.TabStop = True
        Me.Opc12.Text = "12%"
        Me.Opc12.UseVisualStyleBackColor = True
        '
        'txtVentTotal
        '
        Me.txtVentTotal.Enabled = False
        Me.txtVentTotal.Location = New System.Drawing.Point(610, 92)
        Me.txtVentTotal.Name = "txtVentTotal"
        Me.txtVentTotal.ReadOnly = True
        Me.txtVentTotal.Size = New System.Drawing.Size(99, 25)
        Me.txtVentTotal.TabIndex = 13
        '
        'txtVentDesc
        '
        Me.txtVentDesc.Location = New System.Drawing.Point(388, 92)
        Me.txtVentDesc.MaxLength = 3
        Me.txtVentDesc.Name = "txtVentDesc"
        Me.txtVentDesc.Size = New System.Drawing.Size(97, 25)
        Me.txtVentDesc.TabIndex = 12
        '
        'lblVentTotal
        '
        Me.lblVentTotal.AutoSize = True
        Me.lblVentTotal.Location = New System.Drawing.Point(542, 95)
        Me.lblVentTotal.Name = "lblVentTotal"
        Me.lblVentTotal.Size = New System.Drawing.Size(58, 17)
        Me.lblVentTotal.TabIndex = 11
        Me.lblVentTotal.Text = "TOTAL"
        '
        'lblVentIva
        '
        Me.lblVentIva.AutoSize = True
        Me.lblVentIva.Location = New System.Drawing.Point(490, 48)
        Me.lblVentIva.Name = "lblVentIva"
        Me.lblVentIva.Size = New System.Drawing.Size(34, 17)
        Me.lblVentIva.TabIndex = 10
        Me.lblVentIva.Text = "IVA"
        '
        'lblVentDesc
        '
        Me.lblVentDesc.AutoSize = True
        Me.lblVentDesc.Location = New System.Drawing.Point(279, 95)
        Me.lblVentDesc.Name = "lblVentDesc"
        Me.lblVentDesc.Size = New System.Drawing.Size(103, 17)
        Me.lblVentDesc.TabIndex = 8
        Me.lblVentDesc.Text = "DESCUENTO"
        '
        'lblVentCodCli
        '
        Me.lblVentCodCli.AutoSize = True
        Me.lblVentCodCli.Location = New System.Drawing.Point(6, 38)
        Me.lblVentCodCli.Name = "lblVentCodCli"
        Me.lblVentCodCli.Size = New System.Drawing.Size(73, 17)
        Me.lblVentCodCli.TabIndex = 6
        Me.lblVentCodCli.Text = "CLIENTE"
        '
        'txtVentSub
        '
        Me.txtVentSub.Enabled = False
        Me.txtVentSub.Location = New System.Drawing.Point(129, 92)
        Me.txtVentSub.Name = "txtVentSub"
        Me.txtVentSub.ReadOnly = True
        Me.txtVentSub.Size = New System.Drawing.Size(91, 25)
        Me.txtVentSub.TabIndex = 3
        '
        'lblVentSub
        '
        Me.lblVentSub.AutoSize = True
        Me.lblVentSub.Location = New System.Drawing.Point(6, 95)
        Me.lblVentSub.Name = "lblVentSub"
        Me.lblVentSub.Size = New System.Drawing.Size(90, 17)
        Me.lblVentSub.TabIndex = 1
        Me.lblVentSub.Text = "SUBTOTAL"
        '
        'GrupVenReg
        '
        Me.GrupVenReg.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupVenReg.Controls.Add(Me.Label4)
        Me.GrupVenReg.Controls.Add(Me.TextAccTotal)
        Me.GrupVenReg.Controls.Add(Me.btnEliminarSer)
        Me.GrupVenReg.Controls.Add(Me.btnAgregarSer)
        Me.GrupVenReg.Controls.Add(Me.DgServicio)
        Me.GrupVenReg.Controls.Add(Me.DgAccesorio)
        Me.GrupVenReg.Controls.Add(Me.btnEliminarAcc)
        Me.GrupVenReg.Controls.Add(Me.btnAgregarAcc)
        Me.GrupVenReg.Controls.Add(Me.CmbServicio)
        Me.GrupVenReg.Controls.Add(Me.Label3)
        Me.GrupVenReg.Controls.Add(Me.TextSerCosto)
        Me.GrupVenReg.Controls.Add(Me.Label2)
        Me.GrupVenReg.Controls.Add(Me.CmbAccesorio)
        Me.GrupVenReg.Controls.Add(Me.LblVentCant2)
        Me.GrupVenReg.Controls.Add(Me.LblVentCant)
        Me.GrupVenReg.Controls.Add(Me.TxtVentCant)
        Me.GrupVenReg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupVenReg.Location = New System.Drawing.Point(12, 197)
        Me.GrupVenReg.Name = "GrupVenReg"
        Me.GrupVenReg.Size = New System.Drawing.Size(806, 338)
        Me.GrupVenReg.TabIndex = 53
        Me.GrupVenReg.TabStop = False
        Me.GrupVenReg.Text = "DETALLE VENTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "TOTAL"
        '
        'TextAccTotal
        '
        Me.TextAccTotal.Enabled = False
        Me.TextAccTotal.Location = New System.Drawing.Point(310, 77)
        Me.TextAccTotal.Name = "TextAccTotal"
        Me.TextAccTotal.Size = New System.Drawing.Size(103, 25)
        Me.TextAccTotal.TabIndex = 54
        '
        'btnEliminarSer
        '
        Me.btnEliminarSer.BackColor = System.Drawing.Color.Black
        Me.btnEliminarSer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarSer.FlatAppearance.BorderSize = 0
        Me.btnEliminarSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarSer.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSer.ForeColor = System.Drawing.Color.White
        Me.btnEliminarSer.Image = CType(resources.GetObject("btnEliminarSer.Image"), System.Drawing.Image)
        Me.btnEliminarSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarSer.Location = New System.Drawing.Point(654, 118)
        Me.btnEliminarSer.Name = "btnEliminarSer"
        Me.btnEliminarSer.Size = New System.Drawing.Size(141, 56)
        Me.btnEliminarSer.TabIndex = 52
        Me.btnEliminarSer.Text = "ELIMINAR"
        Me.btnEliminarSer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarSer.UseVisualStyleBackColor = False
        '
        'btnAgregarSer
        '
        Me.btnAgregarSer.BackColor = System.Drawing.Color.Black
        Me.btnAgregarSer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarSer.FlatAppearance.BorderSize = 0
        Me.btnAgregarSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSer.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSer.ForeColor = System.Drawing.Color.White
        Me.btnAgregarSer.Image = CType(resources.GetObject("btnAgregarSer.Image"), System.Drawing.Image)
        Me.btnAgregarSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarSer.Location = New System.Drawing.Point(462, 118)
        Me.btnAgregarSer.Name = "btnAgregarSer"
        Me.btnAgregarSer.Size = New System.Drawing.Size(141, 56)
        Me.btnAgregarSer.TabIndex = 53
        Me.btnAgregarSer.Text = "AGREGAR"
        Me.btnAgregarSer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarSer.UseVisualStyleBackColor = False
        '
        'DgServicio
        '
        Me.DgServicio.AllowUserToAddRows = False
        Me.DgServicio.AllowUserToOrderColumns = True
        Me.DgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.DgServicio.Location = New System.Drawing.Point(462, 190)
        Me.DgServicio.MultiSelect = False
        Me.DgServicio.Name = "DgServicio"
        Me.DgServicio.ReadOnly = True
        Me.DgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgServicio.Size = New System.Drawing.Size(333, 132)
        Me.DgServicio.TabIndex = 51
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DgAccesorio
        '
        Me.DgAccesorio.AllowUserToAddRows = False
        Me.DgAccesorio.AllowUserToOrderColumns = True
        Me.DgAccesorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgAccesorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAccesorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Accesorio, Me.Cantidad, Me.Costo})
        Me.DgAccesorio.Location = New System.Drawing.Point(44, 190)
        Me.DgAccesorio.MultiSelect = False
        Me.DgAccesorio.Name = "DgAccesorio"
        Me.DgAccesorio.ReadOnly = True
        Me.DgAccesorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAccesorio.Size = New System.Drawing.Size(384, 132)
        Me.DgAccesorio.TabIndex = 50
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Accesorio
        '
        Me.Accesorio.HeaderText = "Accesorio"
        Me.Accesorio.Name = "Accesorio"
        Me.Accesorio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.HeaderText = "Total"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'CmbServicio
        '
        Me.CmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(539, 39)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(256, 25)
        Me.CmbServicio.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(459, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "SERVICIO"
        '
        'TextSerCosto
        '
        Me.TextSerCosto.Enabled = False
        Me.TextSerCosto.Location = New System.Drawing.Point(539, 82)
        Me.TextSerCosto.Name = "TextSerCosto"
        Me.TextSerCosto.Size = New System.Drawing.Size(138, 25)
        Me.TextSerCosto.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "COSTO"
        '
        'CmbAccesorio
        '
        Me.CmbAccesorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAccesorio.FormattingEnabled = True
        Me.CmbAccesorio.Location = New System.Drawing.Point(146, 39)
        Me.CmbAccesorio.Name = "CmbAccesorio"
        Me.CmbAccesorio.Size = New System.Drawing.Size(267, 25)
        Me.CmbAccesorio.TabIndex = 18
        '
        'LblVentCant2
        '
        Me.LblVentCant2.AutoSize = True
        Me.LblVentCant2.Location = New System.Drawing.Point(41, 77)
        Me.LblVentCant2.Name = "LblVentCant2"
        Me.LblVentCant2.Size = New System.Drawing.Size(88, 17)
        Me.LblVentCant2.TabIndex = 14
        Me.LblVentCant2.Text = "CANTIDAD"
        '
        'LblVentCant
        '
        Me.LblVentCant.AutoSize = True
        Me.LblVentCant.Location = New System.Drawing.Point(41, 42)
        Me.LblVentCant.Name = "LblVentCant"
        Me.LblVentCant.Size = New System.Drawing.Size(101, 17)
        Me.LblVentCant.TabIndex = 13
        Me.LblVentCant.Text = "ACCESORIO"
        '
        'TxtVentCant
        '
        Me.TxtVentCant.Location = New System.Drawing.Point(146, 77)
        Me.TxtVentCant.MaxLength = 3
        Me.TxtVentCant.Name = "TxtVentCant"
        Me.TxtVentCant.Size = New System.Drawing.Size(72, 25)
        Me.TxtVentCant.TabIndex = 11
        '
        'GrupCatAcc
        '
        Me.GrupCatAcc.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupCatAcc.Controls.Add(Me.BtnGuardar)
        Me.GrupCatAcc.Controls.Add(Me.BtnNuevo)
        Me.GrupCatAcc.Controls.Add(Me.btnSeguirComp)
        Me.GrupCatAcc.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupCatAcc.Location = New System.Drawing.Point(12, 541)
        Me.GrupCatAcc.Name = "GrupCatAcc"
        Me.GrupCatAcc.Size = New System.Drawing.Size(806, 88)
        Me.GrupCatAcc.TabIndex = 54
        Me.GrupCatAcc.TabStop = False
        Me.GrupCatAcc.Text = "ACCIONES"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Black
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(338, 26)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(125, 56)
        Me.BtnGuardar.TabIndex = 53
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Black
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(163, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(125, 56)
        Me.BtnNuevo.TabIndex = 52
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'btnSeguirComp
        '
        Me.btnSeguirComp.BackColor = System.Drawing.Color.Black
        Me.btnSeguirComp.FlatAppearance.BorderSize = 0
        Me.btnSeguirComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguirComp.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguirComp.ForeColor = System.Drawing.Color.White
        Me.btnSeguirComp.Image = CType(resources.GetObject("btnSeguirComp.Image"), System.Drawing.Image)
        Me.btnSeguirComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeguirComp.Location = New System.Drawing.Point(517, 25)
        Me.btnSeguirComp.Name = "btnSeguirComp"
        Me.btnSeguirComp.Size = New System.Drawing.Size(137, 56)
        Me.btnSeguirComp.TabIndex = 51
        Me.btnSeguirComp.Text = "REGRESAR"
        Me.btnSeguirComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeguirComp.UseVisualStyleBackColor = False
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(830, 636)
        Me.Controls.Add(Me.GrupCatAcc)
        Me.Controls.Add(Me.GrupVenReg)
        Me.Controls.Add(Me.GrupVentDatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.GrupVentDatos.ResumeLayout(False)
        Me.GrupVentDatos.PerformLayout()
        Me.GrupOpciones.ResumeLayout(False)
        Me.GrupOpciones.PerformLayout()
        Me.GrupVenReg.ResumeLayout(False)
        Me.GrupVenReg.PerformLayout()
        CType(Me.DgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAccesorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupCatAcc.ResumeLayout(False)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregarAcc As System.Windows.Forms.Button
    Friend WithEvents btnEliminarAcc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrupVentDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GrupOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents OpcNinguna As System.Windows.Forms.RadioButton
    Friend WithEvents Opc12 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVentTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtVentDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblVentTotal As System.Windows.Forms.Label
    Friend WithEvents lblVentIva As System.Windows.Forms.Label
    Friend WithEvents lblVentDesc As System.Windows.Forms.Label
    Friend WithEvents lblVentCodCli As System.Windows.Forms.Label
    Friend WithEvents txtVentSub As System.Windows.Forms.TextBox
    Friend WithEvents lblVentSub As System.Windows.Forms.Label
    Friend WithEvents GrupVenReg As System.Windows.Forms.GroupBox
    Friend WithEvents CmbAccesorio As System.Windows.Forms.ComboBox
    Friend WithEvents LblVentCant2 As System.Windows.Forms.Label
    Friend WithEvents LblVentCant As System.Windows.Forms.Label
    Friend WithEvents TxtVentCant As System.Windows.Forms.TextBox
    Friend WithEvents CmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextSerCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAddCliente As System.Windows.Forms.Button
    Friend WithEvents GrupCatAcc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSeguirComp As System.Windows.Forms.Button
    Friend WithEvents btnEliminarSer As System.Windows.Forms.Button
    Friend WithEvents btnAgregarSer As System.Windows.Forms.Button
    Friend WithEvents DgServicio As System.Windows.Forms.DataGridView
    Friend WithEvents DgAccesorio As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextAccTotal As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accesorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

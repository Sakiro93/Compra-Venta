<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GrupVentDatos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddProveedor = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.GrupOpciones = New System.Windows.Forms.GroupBox()
        Me.OpcNinguna = New System.Windows.Forms.RadioButton()
        Me.Opc12 = New System.Windows.Forms.RadioButton()
        Me.txtCompTotal = New System.Windows.Forms.TextBox()
        Me.txtCompDesc = New System.Windows.Forms.TextBox()
        Me.lblCompTotal = New System.Windows.Forms.Label()
        Me.lblComptIva = New System.Windows.Forms.Label()
        Me.lblCompDesc = New System.Windows.Forms.Label()
        Me.lblCompCodProv = New System.Windows.Forms.Label()
        Me.txtComptSub = New System.Windows.Forms.TextBox()
        Me.lblCompSub = New System.Windows.Forms.Label()
        Me.GrupVenReg = New System.Windows.Forms.GroupBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accesorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVentEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TextVentCosto = New System.Windows.Forms.TextBox()
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
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupCatAcc.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.YellowGreen
        Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTitulo.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(714, 57)
        Me.LblTitulo.TabIndex = 44
        Me.LblTitulo.Text = "COMPRAS"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrupVentDatos
        '
        Me.GrupVentDatos.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupVentDatos.Controls.Add(Me.Label1)
        Me.GrupVentDatos.Controls.Add(Me.BtnAddProveedor)
        Me.GrupVentDatos.Controls.Add(Me.cboProveedor)
        Me.GrupVentDatos.Controls.Add(Me.GrupOpciones)
        Me.GrupVentDatos.Controls.Add(Me.txtCompTotal)
        Me.GrupVentDatos.Controls.Add(Me.txtCompDesc)
        Me.GrupVentDatos.Controls.Add(Me.lblCompTotal)
        Me.GrupVentDatos.Controls.Add(Me.lblComptIva)
        Me.GrupVentDatos.Controls.Add(Me.lblCompDesc)
        Me.GrupVentDatos.Controls.Add(Me.lblCompCodProv)
        Me.GrupVentDatos.Controls.Add(Me.txtComptSub)
        Me.GrupVentDatos.Controls.Add(Me.lblCompSub)
        Me.GrupVentDatos.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupVentDatos.Location = New System.Drawing.Point(16, 70)
        Me.GrupVentDatos.Name = "GrupVentDatos"
        Me.GrupVentDatos.Size = New System.Drawing.Size(678, 152)
        Me.GrupVentDatos.TabIndex = 45
        Me.GrupVentDatos.TabStop = False
        Me.GrupVentDatos.Text = "INGRESE DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "%"
        '
        'BtnAddProveedor
        '
        Me.BtnAddProveedor.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddProveedor.Image = CType(resources.GetObject("BtnAddProveedor.Image"), System.Drawing.Image)
        Me.BtnAddProveedor.Location = New System.Drawing.Point(276, 43)
        Me.BtnAddProveedor.Name = "BtnAddProveedor"
        Me.BtnAddProveedor.Size = New System.Drawing.Size(53, 38)
        Me.BtnAddProveedor.TabIndex = 19
        Me.BtnAddProveedor.UseVisualStyleBackColor = False
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(113, 51)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(139, 24)
        Me.cboProveedor.TabIndex = 16
        '
        'GrupOpciones
        '
        Me.GrupOpciones.Controls.Add(Me.OpcNinguna)
        Me.GrupOpciones.Controls.Add(Me.Opc12)
        Me.GrupOpciones.Location = New System.Drawing.Point(477, 42)
        Me.GrupOpciones.Name = "GrupOpciones"
        Me.GrupOpciones.Size = New System.Drawing.Size(147, 39)
        Me.GrupOpciones.TabIndex = 14
        Me.GrupOpciones.TabStop = False
        '
        'OpcNinguna
        '
        Me.OpcNinguna.AutoSize = True
        Me.OpcNinguna.Location = New System.Drawing.Point(67, 15)
        Me.OpcNinguna.Name = "OpcNinguna"
        Me.OpcNinguna.Size = New System.Drawing.Size(70, 20)
        Me.OpcNinguna.TabIndex = 17
        Me.OpcNinguna.TabStop = True
        Me.OpcNinguna.Text = "Ninguna"
        Me.OpcNinguna.UseVisualStyleBackColor = True
        '
        'Opc12
        '
        Me.Opc12.AutoSize = True
        Me.Opc12.Checked = True
        Me.Opc12.Location = New System.Drawing.Point(6, 15)
        Me.Opc12.Name = "Opc12"
        Me.Opc12.Size = New System.Drawing.Size(50, 20)
        Me.Opc12.TabIndex = 16
        Me.Opc12.TabStop = True
        Me.Opc12.Text = "12%"
        Me.Opc12.UseVisualStyleBackColor = True
        '
        'txtCompTotal
        '
        Me.txtCompTotal.Enabled = False
        Me.txtCompTotal.Location = New System.Drawing.Point(555, 103)
        Me.txtCompTotal.Name = "txtCompTotal"
        Me.txtCompTotal.Size = New System.Drawing.Size(72, 24)
        Me.txtCompTotal.TabIndex = 13
        '
        'txtCompDesc
        '
        Me.txtCompDesc.Location = New System.Drawing.Point(335, 103)
        Me.txtCompDesc.MaxLength = 3
        Me.txtCompDesc.Name = "txtCompDesc"
        Me.txtCompDesc.Size = New System.Drawing.Size(52, 24)
        Me.txtCompDesc.TabIndex = 12
        Me.txtCompDesc.Text = "0"
        '
        'lblCompTotal
        '
        Me.lblCompTotal.AutoSize = True
        Me.lblCompTotal.Location = New System.Drawing.Point(460, 106)
        Me.lblCompTotal.Name = "lblCompTotal"
        Me.lblCompTotal.Size = New System.Drawing.Size(50, 16)
        Me.lblCompTotal.TabIndex = 11
        Me.lblCompTotal.Text = "TOTAL"
        '
        'lblComptIva
        '
        Me.lblComptIva.AutoSize = True
        Me.lblComptIva.Location = New System.Drawing.Point(395, 54)
        Me.lblComptIva.Name = "lblComptIva"
        Me.lblComptIva.Size = New System.Drawing.Size(32, 16)
        Me.lblComptIva.TabIndex = 10
        Me.lblComptIva.Text = "IVA"
        '
        'lblCompDesc
        '
        Me.lblCompDesc.AutoSize = True
        Me.lblCompDesc.Location = New System.Drawing.Point(244, 106)
        Me.lblCompDesc.Name = "lblCompDesc"
        Me.lblCompDesc.Size = New System.Drawing.Size(85, 16)
        Me.lblCompDesc.TabIndex = 8
        Me.lblCompDesc.Text = "DESCUENTO"
        '
        'lblCompCodProv
        '
        Me.lblCompCodProv.AutoSize = True
        Me.lblCompCodProv.Location = New System.Drawing.Point(16, 54)
        Me.lblCompCodProv.Name = "lblCompCodProv"
        Me.lblCompCodProv.Size = New System.Drawing.Size(83, 16)
        Me.lblCompCodProv.TabIndex = 6
        Me.lblCompCodProv.Text = "PROVEEDOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtComptSub
        '
        Me.txtComptSub.Enabled = False
        Me.txtComptSub.Location = New System.Drawing.Point(113, 103)
        Me.txtComptSub.Name = "txtComptSub"
        Me.txtComptSub.Size = New System.Drawing.Size(72, 24)
        Me.txtComptSub.TabIndex = 3
        '
        'lblCompSub
        '
        Me.lblCompSub.AutoSize = True
        Me.lblCompSub.Location = New System.Drawing.Point(16, 103)
        Me.lblCompSub.Name = "lblCompSub"
        Me.lblCompSub.Size = New System.Drawing.Size(75, 16)
        Me.lblCompSub.TabIndex = 1
        Me.lblCompSub.Text = "SUBTOTAL"
        '
        'GrupVenReg
        '
        Me.GrupVenReg.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupVenReg.Controls.Add(Me.Dg)
        Me.GrupVenReg.Controls.Add(Me.btnVentEliminar)
        Me.GrupVenReg.Controls.Add(Me.btnAgregar)
        Me.GrupVenReg.Controls.Add(Me.TextVentCosto)
        Me.GrupVenReg.Controls.Add(Me.Label2)
        Me.GrupVenReg.Controls.Add(Me.CmbAccesorio)
        Me.GrupVenReg.Controls.Add(Me.LblVentCant2)
        Me.GrupVenReg.Controls.Add(Me.LblVentCant)
        Me.GrupVenReg.Controls.Add(Me.TxtVentCant)
        Me.GrupVenReg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupVenReg.Location = New System.Drawing.Point(16, 239)
        Me.GrupVenReg.Name = "GrupVenReg"
        Me.GrupVenReg.Size = New System.Drawing.Size(678, 310)
        Me.GrupVenReg.TabIndex = 54
        Me.GrupVenReg.TabStop = False
        Me.GrupVenReg.Text = "DETALLE COMPRA"
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToOrderColumns = True
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Accesorio, Me.Cantidad, Me.Costo})
        Me.Dg.Location = New System.Drawing.Point(44, 157)
        Me.Dg.MultiSelect = False
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(583, 132)
        Me.Dg.TabIndex = 50
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
        'btnVentEliminar
        '
        Me.btnVentEliminar.BackColor = System.Drawing.Color.Black
        Me.btnVentEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentEliminar.FlatAppearance.BorderSize = 0
        Me.btnVentEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentEliminar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentEliminar.ForeColor = System.Drawing.Color.White
        Me.btnVentEliminar.Image = CType(resources.GetObject("btnVentEliminar.Image"), System.Drawing.Image)
        Me.btnVentEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentEliminar.Location = New System.Drawing.Point(486, 85)
        Me.btnVentEliminar.Name = "btnVentEliminar"
        Me.btnVentEliminar.Size = New System.Drawing.Size(141, 56)
        Me.btnVentEliminar.TabIndex = 0
        Me.btnVentEliminar.Text = "ELIMINAR"
        Me.btnVentEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Black
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(324, 85)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(141, 56)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'TextVentCosto
        '
        Me.TextVentCosto.Enabled = False
        Me.TextVentCosto.Location = New System.Drawing.Point(146, 121)
        Me.TextVentCosto.Name = "TextVentCosto"
        Me.TextVentCosto.Size = New System.Drawing.Size(76, 25)
        Me.TextVentCosto.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TOTAL"
        '
        'CmbAccesorio
        '
        Me.CmbAccesorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAccesorio.FormattingEnabled = True
        Me.CmbAccesorio.Location = New System.Drawing.Point(146, 39)
        Me.CmbAccesorio.Name = "CmbAccesorio"
        Me.CmbAccesorio.Size = New System.Drawing.Size(183, 25)
        Me.CmbAccesorio.TabIndex = 18
        '
        'LblVentCant2
        '
        Me.LblVentCant2.AutoSize = True
        Me.LblVentCant2.Location = New System.Drawing.Point(41, 85)
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
        Me.TxtVentCant.Location = New System.Drawing.Point(146, 82)
        Me.TxtVentCant.MaxLength = 3
        Me.TxtVentCant.Name = "TxtVentCant"
        Me.TxtVentCant.Size = New System.Drawing.Size(76, 25)
        Me.TxtVentCant.TabIndex = 11
        '
        'GrupCatAcc
        '
        Me.GrupCatAcc.BackColor = System.Drawing.Color.YellowGreen
        Me.GrupCatAcc.Controls.Add(Me.BtnGuardar)
        Me.GrupCatAcc.Controls.Add(Me.BtnNuevo)
        Me.GrupCatAcc.Controls.Add(Me.btnSeguirComp)
        Me.GrupCatAcc.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupCatAcc.Location = New System.Drawing.Point(16, 564)
        Me.GrupCatAcc.Name = "GrupCatAcc"
        Me.GrupCatAcc.Size = New System.Drawing.Size(678, 88)
        Me.GrupCatAcc.TabIndex = 55
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
        Me.BtnGuardar.Location = New System.Drawing.Point(277, 25)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(126, 26)
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
        Me.btnSeguirComp.Location = New System.Drawing.Point(447, 22)
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
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(714, 660)
        Me.Controls.Add(Me.GrupCatAcc)
        Me.Controls.Add(Me.GrupVenReg)
        Me.Controls.Add(Me.GrupVentDatos)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra"
        Me.GrupVentDatos.ResumeLayout(False)
        Me.GrupVentDatos.PerformLayout()
        Me.GrupOpciones.ResumeLayout(False)
        Me.GrupOpciones.PerformLayout()
        Me.GrupVenReg.ResumeLayout(False)
        Me.GrupVenReg.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupCatAcc.ResumeLayout(False)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GrupVentDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GrupOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents OpcNinguna As System.Windows.Forms.RadioButton
    Friend WithEvents Opc12 As System.Windows.Forms.RadioButton
    Friend WithEvents txtCompTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCompDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblCompTotal As System.Windows.Forms.Label
    Friend WithEvents lblComptIva As System.Windows.Forms.Label
    Friend WithEvents lblCompDesc As System.Windows.Forms.Label
    Friend WithEvents lblCompCodProv As System.Windows.Forms.Label
    Friend WithEvents txtComptSub As System.Windows.Forms.TextBox
    Friend WithEvents lblCompSub As System.Windows.Forms.Label
    Friend WithEvents GrupVenReg As System.Windows.Forms.GroupBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnVentEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents TextVentCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbAccesorio As System.Windows.Forms.ComboBox
    Friend WithEvents LblVentCant2 As System.Windows.Forms.Label
    Friend WithEvents LblVentCant As System.Windows.Forms.Label
    Friend WithEvents TxtVentCant As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddProveedor As System.Windows.Forms.Button
    Friend WithEvents GrupCatAcc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSeguirComp As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accesorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

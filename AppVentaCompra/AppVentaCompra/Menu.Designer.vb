<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnParte = New System.Windows.Forms.Button()
        Me.BtnServicio = New System.Windows.Forms.Button()
        Me.BtnAccesorio = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
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
        Me.LblTitulo.Size = New System.Drawing.Size(739, 57)
        Me.LblTitulo.TabIndex = 45
        Me.LblTitulo.Text = "Sistema de Venta y Compra"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnCompra)
        Me.GroupBox1.Controls.Add(Me.BtnVenta)
        Me.GroupBox1.Controls.Add(Me.BtnParte)
        Me.GroupBox1.Controls.Add(Me.BtnServicio)
        Me.GroupBox1.Controls.Add(Me.BtnAccesorio)
        Me.GroupBox1.Controls.Add(Me.BtnProveedor)
        Me.GroupBox1.Controls.Add(Me.BtnCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 385)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(236, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 92)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "HISTORIAL"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnCompra
        '
        Me.BtnCompra.BackColor = System.Drawing.Color.LightBlue
        Me.BtnCompra.FlatAppearance.BorderSize = 0
        Me.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompra.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.Image = CType(resources.GetObject("BtnCompra.Image"), System.Drawing.Image)
        Me.BtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompra.Location = New System.Drawing.Point(236, 277)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(186, 92)
        Me.BtnCompra.TabIndex = 59
        Me.BtnCompra.Text = "Compra"
        Me.BtnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCompra.UseVisualStyleBackColor = False
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnVenta.FlatAppearance.BorderSize = 0
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.Image = CType(resources.GetObject("BtnVenta.Image"), System.Drawing.Image)
        Me.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVenta.Location = New System.Drawing.Point(24, 158)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(160, 92)
        Me.BtnVenta.TabIndex = 58
        Me.BtnVenta.Text = "Venta"
        Me.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'BtnParte
        '
        Me.BtnParte.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnParte.FlatAppearance.BorderSize = 0
        Me.BtnParte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnParte.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParte.Image = CType(resources.GetObject("BtnParte.Image"), System.Drawing.Image)
        Me.BtnParte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnParte.Location = New System.Drawing.Point(24, 277)
        Me.BtnParte.Name = "BtnParte"
        Me.BtnParte.Size = New System.Drawing.Size(160, 92)
        Me.BtnParte.TabIndex = 57
        Me.BtnParte.Text = "Parte"
        Me.BtnParte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnParte.UseVisualStyleBackColor = False
        '
        'BtnServicio
        '
        Me.BtnServicio.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnServicio.FlatAppearance.BorderSize = 0
        Me.BtnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServicio.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnServicio.Image = CType(resources.GetObject("BtnServicio.Image"), System.Drawing.Image)
        Me.BtnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnServicio.Location = New System.Drawing.Point(467, 168)
        Me.BtnServicio.Name = "BtnServicio"
        Me.BtnServicio.Size = New System.Drawing.Size(186, 92)
        Me.BtnServicio.TabIndex = 56
        Me.BtnServicio.Text = "Servicio"
        Me.BtnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnServicio.UseVisualStyleBackColor = False
        '
        'BtnAccesorio
        '
        Me.BtnAccesorio.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAccesorio.FlatAppearance.BorderSize = 0
        Me.BtnAccesorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccesorio.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccesorio.Image = CType(resources.GetObject("BtnAccesorio.Image"), System.Drawing.Image)
        Me.BtnAccesorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccesorio.Location = New System.Drawing.Point(467, 41)
        Me.BtnAccesorio.Name = "BtnAccesorio"
        Me.BtnAccesorio.Size = New System.Drawing.Size(187, 92)
        Me.BtnAccesorio.TabIndex = 55
        Me.BtnAccesorio.Text = "Accesorio"
        Me.BtnAccesorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAccesorio.UseVisualStyleBackColor = False
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.LightBlue
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.Image = CType(resources.GetObject("BtnProveedor.Image"), System.Drawing.Image)
        Me.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedor.Location = New System.Drawing.Point(236, 41)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(188, 92)
        Me.BtnProveedor.TabIndex = 54
        Me.BtnProveedor.Text = "Proveedor"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(24, 41)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(160, 92)
        Me.BtnCliente.TabIndex = 53
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(739, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCompra As System.Windows.Forms.Button
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents BtnParte As System.Windows.Forms.Button
    Friend WithEvents BtnServicio As System.Windows.Forms.Button
    Friend WithEvents BtnAccesorio As System.Windows.Forms.Button
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

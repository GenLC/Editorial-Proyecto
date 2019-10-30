<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelCompleto = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSeleccionarLibro = New System.Windows.Forms.Button()
        Me.lblClienteSeleccionado = New System.Windows.Forms.Label()
        Me.cmdModificarFactura = New System.Windows.Forms.Button()
        Me.grpFactura = New System.Windows.Forms.GroupBox()
        Me.cmdAceptarFacturac = New System.Windows.Forms.Button()
        Me.chkEstadoFactura = New System.Windows.Forms.CheckBox()
        Me.cmdLimpiarFactura = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPuntoVenta = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox()
        Me.cmdAgregarCliente = New System.Windows.Forms.Button()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.grlClientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPrecio = New System.Windows.Forms.TextBox()
        Me.PanelResumen = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdFinalizar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.grlResumenVenta = New System.Windows.Forms.DataGridView()
        Me.ID_Libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelCompleto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpFactura.SuspendLayout()
        Me.grpCliente.SuspendLayout()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelResumen.SuspendLayout()
        CType(Me.grlResumenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCompleto
        '
        Me.PanelCompleto.AutoSize = True
        Me.PanelCompleto.Controls.Add(Me.GroupBox1)
        Me.PanelCompleto.Controls.Add(Me.cmdModificarFactura)
        Me.PanelCompleto.Controls.Add(Me.grpFactura)
        Me.PanelCompleto.Controls.Add(Me.cmdAgregarCliente)
        Me.PanelCompleto.Controls.Add(Me.grpCliente)
        Me.PanelCompleto.Controls.Add(Me.Panel2)
        Me.PanelCompleto.Location = New System.Drawing.Point(0, 0)
        Me.PanelCompleto.Name = "PanelCompleto"
        Me.PanelCompleto.Size = New System.Drawing.Size(1050, 562)
        Me.PanelCompleto.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionarLibro)
        Me.GroupBox1.Controls.Add(Me.lblClienteSeleccionado)
        Me.GroupBox1.Location = New System.Drawing.Point(633, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 322)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGREGAR AL CARRITO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Seleccionar Libros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Cliente Seleccionado:"
        '
        'cmdSeleccionarLibro
        '
        Me.cmdSeleccionarLibro.Image = Global.Editorial_Proyecto.My.Resources.Resources.shopping_cart
        Me.cmdSeleccionarLibro.Location = New System.Drawing.Point(244, 180)
        Me.cmdSeleccionarLibro.Name = "cmdSeleccionarLibro"
        Me.cmdSeleccionarLibro.Size = New System.Drawing.Size(125, 83)
        Me.cmdSeleccionarLibro.TabIndex = 35
        Me.cmdSeleccionarLibro.UseVisualStyleBackColor = True
        '
        'lblClienteSeleccionado
        '
        Me.lblClienteSeleccionado.AutoSize = True
        Me.lblClienteSeleccionado.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteSeleccionado.Location = New System.Drawing.Point(238, 60)
        Me.lblClienteSeleccionado.Name = "lblClienteSeleccionado"
        Me.lblClienteSeleccionado.Size = New System.Drawing.Size(26, 32)
        Me.lblClienteSeleccionado.TabIndex = 34
        Me.lblClienteSeleccionado.Text = "-"
        '
        'cmdModificarFactura
        '
        Me.cmdModificarFactura.Location = New System.Drawing.Point(499, 122)
        Me.cmdModificarFactura.Name = "cmdModificarFactura"
        Me.cmdModificarFactura.Size = New System.Drawing.Size(110, 92)
        Me.cmdModificarFactura.TabIndex = 31
        Me.cmdModificarFactura.Text = "Modificar Factura"
        Me.cmdModificarFactura.UseVisualStyleBackColor = True
        '
        'grpFactura
        '
        Me.grpFactura.Controls.Add(Me.cmdAceptarFacturac)
        Me.grpFactura.Controls.Add(Me.chkEstadoFactura)
        Me.grpFactura.Controls.Add(Me.cmdLimpiarFactura)
        Me.grpFactura.Controls.Add(Me.Label5)
        Me.grpFactura.Controls.Add(Me.Label4)
        Me.grpFactura.Controls.Add(Me.txtCompNum)
        Me.grpFactura.Controls.Add(Me.Label3)
        Me.grpFactura.Controls.Add(Me.Label2)
        Me.grpFactura.Controls.Add(Me.txtPuntoVenta)
        Me.grpFactura.Controls.Add(Me.dtFecha)
        Me.grpFactura.Controls.Add(Me.cboTipoFactura)
        Me.grpFactura.Location = New System.Drawing.Point(12, 82)
        Me.grpFactura.Name = "grpFactura"
        Me.grpFactura.Size = New System.Drawing.Size(481, 161)
        Me.grpFactura.TabIndex = 6
        Me.grpFactura.TabStop = False
        Me.grpFactura.Text = "Factura"
        '
        'cmdAceptarFacturac
        '
        Me.cmdAceptarFacturac.Location = New System.Drawing.Point(353, 89)
        Me.cmdAceptarFacturac.Name = "cmdAceptarFacturac"
        Me.cmdAceptarFacturac.Size = New System.Drawing.Size(110, 43)
        Me.cmdAceptarFacturac.TabIndex = 12
        Me.cmdAceptarFacturac.Text = "Aceptar"
        Me.cmdAceptarFacturac.UseVisualStyleBackColor = True
        '
        'chkEstadoFactura
        '
        Me.chkEstadoFactura.AutoSize = True
        Me.chkEstadoFactura.Location = New System.Drawing.Point(245, 33)
        Me.chkEstadoFactura.Name = "chkEstadoFactura"
        Me.chkEstadoFactura.Size = New System.Drawing.Size(98, 17)
        Me.chkEstadoFactura.TabIndex = 11
        Me.chkEstadoFactura.Text = "Estado Factura"
        Me.chkEstadoFactura.UseVisualStyleBackColor = True
        '
        'cmdLimpiarFactura
        '
        Me.cmdLimpiarFactura.Location = New System.Drawing.Point(353, 40)
        Me.cmdLimpiarFactura.Name = "cmdLimpiarFactura"
        Me.cmdLimpiarFactura.Size = New System.Drawing.Size(110, 43)
        Me.cmdLimpiarFactura.TabIndex = 10
        Me.cmdLimpiarFactura.Text = "Limpiar Facturacion"
        Me.cmdLimpiarFactura.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Comp. Nro."
        '
        'txtCompNum
        '
        Me.txtCompNum.Location = New System.Drawing.Point(245, 79)
        Me.txtCompNum.Name = "txtCompNum"
        Me.txtCompNum.Size = New System.Drawing.Size(71, 20)
        Me.txtCompNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Punto de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo De factura"
        '
        'txtPuntoVenta
        '
        Me.txtPuntoVenta.Location = New System.Drawing.Point(106, 79)
        Me.txtPuntoVenta.Name = "txtPuntoVenta"
        Me.txtPuntoVenta.Size = New System.Drawing.Size(71, 20)
        Me.txtPuntoVenta.TabIndex = 2
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(106, 124)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha.TabIndex = 1
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboTipoFactura.Location = New System.Drawing.Point(106, 33)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoFactura.TabIndex = 0
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(15, 494)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(423, 37)
        Me.cmdAgregarCliente.TabIndex = 5
        Me.cmdAgregarCliente.Text = "Agregar Nuevo Cliente"
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.txtBuscador)
        Me.grpCliente.Controls.Add(Me.grlClientes)
        Me.grpCliente.Location = New System.Drawing.Point(12, 249)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(429, 239)
        Me.grpCliente.TabIndex = 2
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "SELECCIONE EL CLIENTE"
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(6, 31)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(420, 20)
        Me.txtBuscador.TabIndex = 1
        Me.txtBuscador.Text = "Buscador"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grlClientes
        '
        Me.grlClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grlClientes.Location = New System.Drawing.Point(3, 57)
        Me.grlClientes.Name = "grlClientes"
        Me.grlClientes.ReadOnly = True
        Me.grlClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlClientes.Size = New System.Drawing.Size(423, 179)
        Me.grlClientes.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1050, 65)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cargar Ventas"
        '
        'txtTotalPrecio
        '
        Me.txtTotalPrecio.Enabled = False
        Me.txtTotalPrecio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrecio.Location = New System.Drawing.Point(887, 99)
        Me.txtTotalPrecio.Name = "txtTotalPrecio"
        Me.txtTotalPrecio.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalPrecio.TabIndex = 29
        '
        'PanelResumen
        '
        Me.PanelResumen.Controls.Add(Me.Label7)
        Me.PanelResumen.Controls.Add(Me.cmdCancelar)
        Me.PanelResumen.Controls.Add(Me.cmdFinalizar)
        Me.PanelResumen.Controls.Add(Me.cmdLimpiar)
        Me.PanelResumen.Controls.Add(Me.txtTotalPrecio)
        Me.PanelResumen.Controls.Add(Me.grlResumenVenta)
        Me.PanelResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelResumen.Location = New System.Drawing.Point(0, 546)
        Me.PanelResumen.Name = "PanelResumen"
        Me.PanelResumen.Size = New System.Drawing.Size(1050, 157)
        Me.PanelResumen.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(668, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "TOTAL DE LA COMPRA"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(730, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(151, 60)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.Location = New System.Drawing.Point(573, 8)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(151, 60)
        Me.cmdFinalizar.TabIndex = 9
        Me.cmdFinalizar.Text = "Finalizar "
        Me.cmdFinalizar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(887, 8)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(151, 60)
        Me.cmdLimpiar.TabIndex = 8
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'grlResumenVenta
        '
        Me.grlResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlResumenVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Libro, Me.Nombre, Me.Precio, Me.Cantidad, Me.Total})
        Me.grlResumenVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlResumenVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.grlResumenVenta.Location = New System.Drawing.Point(0, 0)
        Me.grlResumenVenta.Name = "grlResumenVenta"
        Me.grlResumenVenta.ReadOnly = True
        Me.grlResumenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlResumenVenta.Size = New System.Drawing.Size(555, 157)
        Me.grlResumenVenta.TabIndex = 5
        '
        'ID_Libro
        '
        Me.ID_Libro.HeaderText = "Cod Libro"
        Me.ID_Libro.Name = "ID_Libro"
        Me.ID_Libro.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 703)
        Me.Controls.Add(Me.PanelResumen)
        Me.Controls.Add(Me.PanelCompleto)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVentas"
        Me.PanelCompleto.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpFactura.ResumeLayout(False)
        Me.grpFactura.PerformLayout()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelResumen.ResumeLayout(False)
        Me.PanelResumen.PerformLayout()
        CType(Me.grlResumenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelCompleto As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents grlClientes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents PanelResumen As System.Windows.Forms.Panel
    Friend WithEvents grpFactura As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents grlResumenVenta As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLimpiarFactura As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents NroVenta As System.Windows.Forms.TextBox
    Friend WithEvents chkEstadoFactura As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalPrecio As System.Windows.Forms.TextBox
    Friend WithEvents ID_Libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAceptarFacturac As System.Windows.Forms.Button
    Friend WithEvents cmdModificarFactura As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdSeleccionarLibro As System.Windows.Forms.Button
    Friend WithEvents lblClienteSeleccionado As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

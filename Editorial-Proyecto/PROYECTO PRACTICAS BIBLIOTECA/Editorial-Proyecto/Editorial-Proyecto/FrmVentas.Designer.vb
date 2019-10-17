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
        Me.cmdCancelarLibro = New System.Windows.Forms.Button()
        Me.cmdCacelarCliente = New System.Windows.Forms.Button()
        Me.lblClienteSeleccionado = New System.Windows.Forms.Label()
        Me.cmdAgregarLibro = New System.Windows.Forms.Button()
        Me.grpFactura = New System.Windows.Forms.GroupBox()
        Me.cmdLimpiarFactura = New System.Windows.Forms.Button()
        Me.cmdCargarFactura = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPuntoVenta = New System.Windows.Forms.TextBox()
        Me.FechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox()
        Me.cmdAgregarCliente = New System.Windows.Forms.Button()
        Me.grpLibros = New System.Windows.Forms.GroupBox()
        Me.txtBuscadoLibros = New System.Windows.Forms.TextBox()
        Me.grlLibros = New System.Windows.Forms.DataGridView()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.grlClientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelResumen = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.grlResumenVenta = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNroVenta = New System.Windows.Forms.Label()
        Me.PanelCompleto.SuspendLayout()
        Me.grpFactura.SuspendLayout()
        Me.grpLibros.SuspendLayout()
        CType(Me.grlLibros, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCompleto.Controls.Add(Me.cmdCancelarLibro)
        Me.PanelCompleto.Controls.Add(Me.cmdCacelarCliente)
        Me.PanelCompleto.Controls.Add(Me.lblClienteSeleccionado)
        Me.PanelCompleto.Controls.Add(Me.cmdAgregarLibro)
        Me.PanelCompleto.Controls.Add(Me.grpFactura)
        Me.PanelCompleto.Controls.Add(Me.cmdAgregarCliente)
        Me.PanelCompleto.Controls.Add(Me.grpLibros)
        Me.PanelCompleto.Controls.Add(Me.grpCliente)
        Me.PanelCompleto.Controls.Add(Me.Panel2)
        Me.PanelCompleto.Location = New System.Drawing.Point(0, 0)
        Me.PanelCompleto.Name = "PanelCompleto"
        Me.PanelCompleto.Size = New System.Drawing.Size(1050, 562)
        Me.PanelCompleto.TabIndex = 0
        '
        'cmdCancelarLibro
        '
        Me.cmdCancelarLibro.Location = New System.Drawing.Point(888, 503)
        Me.cmdCancelarLibro.Name = "cmdCancelarLibro"
        Me.cmdCancelarLibro.Size = New System.Drawing.Size(144, 33)
        Me.cmdCancelarLibro.TabIndex = 10
        Me.cmdCancelarLibro.Text = "Cancelar Libro"
        Me.cmdCancelarLibro.UseVisualStyleBackColor = True
        '
        'cmdCacelarCliente
        '
        Me.cmdCacelarCliente.Location = New System.Drawing.Point(235, 460)
        Me.cmdCacelarCliente.Name = "cmdCacelarCliente"
        Me.cmdCacelarCliente.Size = New System.Drawing.Size(203, 37)
        Me.cmdCacelarCliente.TabIndex = 9
        Me.cmdCacelarCliente.Text = "Cancelar Cliente"
        Me.cmdCacelarCliente.UseVisualStyleBackColor = True
        '
        'lblClienteSeleccionado
        '
        Me.lblClienteSeleccionado.AutoSize = True
        Me.lblClienteSeleccionado.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteSeleccionado.Location = New System.Drawing.Point(474, 276)
        Me.lblClienteSeleccionado.Name = "lblClienteSeleccionado"
        Me.lblClienteSeleccionado.Size = New System.Drawing.Size(223, 25)
        Me.lblClienteSeleccionado.TabIndex = 8
        Me.lblClienteSeleccionado.Text = "ClienteSeleccionado"
        '
        'cmdAgregarLibro
        '
        Me.cmdAgregarLibro.Location = New System.Drawing.Point(718, 503)
        Me.cmdAgregarLibro.Name = "cmdAgregarLibro"
        Me.cmdAgregarLibro.Size = New System.Drawing.Size(144, 33)
        Me.cmdAgregarLibro.TabIndex = 7
        Me.cmdAgregarLibro.Text = "Agregar Libro"
        Me.cmdAgregarLibro.UseVisualStyleBackColor = True
        '
        'grpFactura
        '
        Me.grpFactura.Controls.Add(Me.lblNroVenta)
        Me.grpFactura.Controls.Add(Me.Label6)
        Me.grpFactura.Controls.Add(Me.cmdLimpiarFactura)
        Me.grpFactura.Controls.Add(Me.cmdCargarFactura)
        Me.grpFactura.Controls.Add(Me.Label5)
        Me.grpFactura.Controls.Add(Me.Label4)
        Me.grpFactura.Controls.Add(Me.txtCompNum)
        Me.grpFactura.Controls.Add(Me.Label3)
        Me.grpFactura.Controls.Add(Me.Label2)
        Me.grpFactura.Controls.Add(Me.txtPuntoVenta)
        Me.grpFactura.Controls.Add(Me.FechaFactura)
        Me.grpFactura.Controls.Add(Me.cboTipoFactura)
        Me.grpFactura.Location = New System.Drawing.Point(12, 82)
        Me.grpFactura.Name = "grpFactura"
        Me.grpFactura.Size = New System.Drawing.Size(605, 161)
        Me.grpFactura.TabIndex = 6
        Me.grpFactura.TabStop = False
        Me.grpFactura.Text = "Factura"
        '
        'cmdLimpiarFactura
        '
        Me.cmdLimpiarFactura.Location = New System.Drawing.Point(467, 49)
        Me.cmdLimpiarFactura.Name = "cmdLimpiarFactura"
        Me.cmdLimpiarFactura.Size = New System.Drawing.Size(110, 73)
        Me.cmdLimpiarFactura.TabIndex = 10
        Me.cmdLimpiarFactura.Text = "Limpiar Facturacion"
        Me.cmdLimpiarFactura.UseVisualStyleBackColor = True
        '
        'cmdCargarFactura
        '
        Me.cmdCargarFactura.Location = New System.Drawing.Point(351, 49)
        Me.cmdCargarFactura.Name = "cmdCargarFactura"
        Me.cmdCargarFactura.Size = New System.Drawing.Size(110, 73)
        Me.cmdCargarFactura.TabIndex = 9
        Me.cmdCargarFactura.Text = "Cargar Factura"
        Me.cmdCargarFactura.UseVisualStyleBackColor = True
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
        'FechaFactura
        '
        Me.FechaFactura.Location = New System.Drawing.Point(106, 124)
        Me.FechaFactura.Name = "FechaFactura"
        Me.FechaFactura.Size = New System.Drawing.Size(200, 20)
        Me.FechaFactura.TabIndex = 1
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboTipoFactura.Location = New System.Drawing.Point(106, 33)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(71, 21)
        Me.cboTipoFactura.TabIndex = 0
        '
        'cmdAgregarCliente
        '
        Me.cmdAgregarCliente.Location = New System.Drawing.Point(15, 460)
        Me.cmdAgregarCliente.Name = "cmdAgregarCliente"
        Me.cmdAgregarCliente.Size = New System.Drawing.Size(199, 37)
        Me.cmdAgregarCliente.TabIndex = 5
        Me.cmdAgregarCliente.Text = "Agregar Nuevo Cliente"
        Me.cmdAgregarCliente.UseVisualStyleBackColor = True
        '
        'grpLibros
        '
        Me.grpLibros.Controls.Add(Me.txtBuscadoLibros)
        Me.grpLibros.Controls.Add(Me.grlLibros)
        Me.grpLibros.Location = New System.Drawing.Point(715, 71)
        Me.grpLibros.Name = "grpLibros"
        Me.grpLibros.Size = New System.Drawing.Size(323, 429)
        Me.grpLibros.TabIndex = 4
        Me.grpLibros.TabStop = False
        Me.grpLibros.Text = "SELECCIONE LOS LIBROS A VENDER"
        '
        'txtBuscadoLibros
        '
        Me.txtBuscadoLibros.Location = New System.Drawing.Point(9, 31)
        Me.txtBuscadoLibros.Name = "txtBuscadoLibros"
        Me.txtBuscadoLibros.Size = New System.Drawing.Size(307, 20)
        Me.txtBuscadoLibros.TabIndex = 5
        Me.txtBuscadoLibros.Text = "Buscador"
        Me.txtBuscadoLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grlLibros
        '
        Me.grlLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlLibros.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlLibros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grlLibros.Location = New System.Drawing.Point(3, 72)
        Me.grlLibros.Name = "grlLibros"
        Me.grlLibros.ReadOnly = True
        Me.grlLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlLibros.Size = New System.Drawing.Size(317, 354)
        Me.grlLibros.TabIndex = 4
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.txtBuscador)
        Me.grpCliente.Controls.Add(Me.grlClientes)
        Me.grpCliente.Location = New System.Drawing.Point(12, 249)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(429, 205)
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
        Me.grlClientes.Size = New System.Drawing.Size(423, 145)
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
        'PanelResumen
        '
        Me.PanelResumen.Controls.Add(Me.Button9)
        Me.PanelResumen.Controls.Add(Me.Button7)
        Me.PanelResumen.Controls.Add(Me.Button6)
        Me.PanelResumen.Controls.Add(Me.Button8)
        Me.PanelResumen.Controls.Add(Me.grlResumenVenta)
        Me.PanelResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelResumen.Location = New System.Drawing.Point(0, 546)
        Me.PanelResumen.Name = "PanelResumen"
        Me.PanelResumen.Size = New System.Drawing.Size(1050, 157)
        Me.PanelResumen.TabIndex = 1
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(887, 85)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(151, 60)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(730, 85)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 60)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(730, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 60)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Finalizar "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(887, 8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(151, 60)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Limpiar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'grlResumenVenta
        '
        Me.grlResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlResumenVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlResumenVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.grlResumenVenta.Location = New System.Drawing.Point(0, 0)
        Me.grlResumenVenta.Name = "grlResumenVenta"
        Me.grlResumenVenta.ReadOnly = True
        Me.grlResumenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlResumenVenta.Size = New System.Drawing.Size(717, 157)
        Me.grlResumenVenta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Venta Nro"
        '
        'lblNroVenta
        '
        Me.lblNroVenta.AutoSize = True
        Me.lblNroVenta.Location = New System.Drawing.Point(267, 36)
        Me.lblNroVenta.Name = "lblNroVenta"
        Me.lblNroVenta.Size = New System.Drawing.Size(22, 13)
        Me.lblNroVenta.TabIndex = 13
        Me.lblNroVenta.Text = "-----"
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
        Me.PanelCompleto.PerformLayout()
        Me.grpFactura.ResumeLayout(False)
        Me.grpFactura.PerformLayout()
        Me.grpLibros.ResumeLayout(False)
        Me.grpLibros.PerformLayout()
        CType(Me.grlLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelResumen.ResumeLayout(False)
        CType(Me.grlResumenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelCompleto As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents grpLibros As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents grlClientes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents grlLibros As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscadoLibros As System.Windows.Forms.TextBox
    Friend WithEvents PanelResumen As System.Windows.Forms.Panel
    Friend WithEvents cmdAgregarLibro As System.Windows.Forms.Button
    Friend WithEvents grpFactura As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents FechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents grlResumenVenta As System.Windows.Forms.DataGridView
    Friend WithEvents lblClienteSeleccionado As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiarFactura As System.Windows.Forms.Button
    Friend WithEvents cmdCargarFactura As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents cmdCacelarCliente As System.Windows.Forms.Button
    Friend WithEvents cmdCancelarLibro As System.Windows.Forms.Button
    Friend WithEvents NroVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNroVenta As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdFacturasEliminadas = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.rbtMontoMenor = New System.Windows.Forms.RadioButton()
        Me.rbtNombreCliente = New System.Windows.Forms.RadioButton()
        Me.rbtNroFactura = New System.Windows.Forms.RadioButton()
        Me.PanelDetalleFacturaCartel = New System.Windows.Forms.Panel()
        Me.PanelFacturaCartel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelFactura = New System.Windows.Forms.Panel()
        Me.grlFacturas = New System.Windows.Forms.DataGridView()
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.PanelDetalleFactura = New System.Windows.Forms.Panel()
        Me.grlFacturaDetalle = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.Encabezado.SuspendLayout()
        Me.PanelFacturaCartel.SuspendLayout()
        Me.PanelFactura.SuspendLayout()
        CType(Me.grlFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGeneral.SuspendLayout()
        Me.PanelDetalleFactura.SuspendLayout()
        CType(Me.grlFacturaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 21)
        Me.Panel1.TabIndex = 0
        '
        'txtBuscador
        '
        Me.txtBuscador.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBuscador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(0, 0)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(675, 21)
        Me.txtBuscador.TabIndex = 3
        Me.txtBuscador.Text = "BUSCADOR"
        Me.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.cmdLimpiar)
        Me.PanelBotones.Controls.Add(Me.cmdFacturasEliminadas)
        Me.PanelBotones.Controls.Add(Me.Button2)
        Me.PanelBotones.Controls.Add(Me.cmdEliminar)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(0, 417)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(675, 54)
        Me.PanelBotones.TabIndex = 1
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(195, 12)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(93, 33)
        Me.cmdLimpiar.TabIndex = 3
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdFacturasEliminadas
        '
        Me.cmdFacturasEliminadas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFacturasEliminadas.Location = New System.Drawing.Point(558, 0)
        Me.cmdFacturasEliminadas.Name = "cmdFacturasEliminadas"
        Me.cmdFacturasEliminadas.Size = New System.Drawing.Size(96, 48)
        Me.cmdFacturasEliminadas.TabIndex = 2
        Me.cmdFacturasEliminadas.Text = "Facturas Eliminadas"
        Me.cmdFacturasEliminadas.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(386, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Location = New System.Drawing.Point(12, 11)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(85, 34)
        Me.cmdEliminar.TabIndex = 0
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.Controls.Add(Me.rbtMontoMenor)
        Me.Encabezado.Controls.Add(Me.rbtNombreCliente)
        Me.Encabezado.Controls.Add(Me.rbtNroFactura)
        Me.Encabezado.Controls.Add(Me.PanelDetalleFacturaCartel)
        Me.Encabezado.Controls.Add(Me.PanelFacturaCartel)
        Me.Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(675, 64)
        Me.Encabezado.TabIndex = 0
        '
        'rbtMontoMenor
        '
        Me.rbtMontoMenor.AutoSize = True
        Me.rbtMontoMenor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMontoMenor.Location = New System.Drawing.Point(416, 23)
        Me.rbtMontoMenor.Name = "rbtMontoMenor"
        Me.rbtMontoMenor.Size = New System.Drawing.Size(111, 20)
        Me.rbtMontoMenor.TabIndex = 4
        Me.rbtMontoMenor.TabStop = True
        Me.rbtMontoMenor.Text = "Monto Menor a"
        Me.rbtMontoMenor.UseVisualStyleBackColor = True
        '
        'rbtNombreCliente
        '
        Me.rbtNombreCliente.AutoSize = True
        Me.rbtNombreCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNombreCliente.Location = New System.Drawing.Point(206, 23)
        Me.rbtNombreCliente.Name = "rbtNombreCliente"
        Me.rbtNombreCliente.Size = New System.Drawing.Size(110, 20)
        Me.rbtNombreCliente.TabIndex = 4
        Me.rbtNombreCliente.TabStop = True
        Me.rbtNombreCliente.Text = "Nombre Cliente"
        Me.rbtNombreCliente.UseVisualStyleBackColor = True
        '
        'rbtNroFactura
        '
        Me.rbtNroFactura.AutoSize = True
        Me.rbtNroFactura.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNroFactura.Location = New System.Drawing.Point(321, 23)
        Me.rbtNroFactura.Name = "rbtNroFactura"
        Me.rbtNroFactura.Size = New System.Drawing.Size(89, 20)
        Me.rbtNroFactura.TabIndex = 3
        Me.rbtNroFactura.TabStop = True
        Me.rbtNroFactura.Text = "Nro Factura"
        Me.rbtNroFactura.UseVisualStyleBackColor = True
        '
        'PanelDetalleFacturaCartel
        '
        Me.PanelDetalleFacturaCartel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDetalleFacturaCartel.Location = New System.Drawing.Point(475, 0)
        Me.PanelDetalleFacturaCartel.Name = "PanelDetalleFacturaCartel"
        Me.PanelDetalleFacturaCartel.Size = New System.Drawing.Size(200, 64)
        Me.PanelDetalleFacturaCartel.TabIndex = 1
        '
        'PanelFacturaCartel
        '
        Me.PanelFacturaCartel.Controls.Add(Me.Label1)
        Me.PanelFacturaCartel.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelFacturaCartel.Location = New System.Drawing.Point(0, 0)
        Me.PanelFacturaCartel.Name = "PanelFacturaCartel"
        Me.PanelFacturaCartel.Size = New System.Drawing.Size(200, 64)
        Me.PanelFacturaCartel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DETALLES DE LA FACTURA"
        '
        'PanelFactura
        '
        Me.PanelFactura.Controls.Add(Me.grlFacturas)
        Me.PanelFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFactura.Location = New System.Drawing.Point(0, 64)
        Me.PanelFactura.Name = "PanelFactura"
        Me.PanelFactura.Size = New System.Drawing.Size(675, 133)
        Me.PanelFactura.TabIndex = 1
        '
        'grlFacturas
        '
        Me.grlFacturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlFacturas.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlFacturas.Location = New System.Drawing.Point(0, 0)
        Me.grlFacturas.Name = "grlFacturas"
        Me.grlFacturas.Size = New System.Drawing.Size(675, 133)
        Me.grlFacturas.TabIndex = 0
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.Label2)
        Me.PanelGeneral.Controls.Add(Me.PanelDetalleFactura)
        Me.PanelGeneral.Controls.Add(Me.PanelFactura)
        Me.PanelGeneral.Controls.Add(Me.Encabezado)
        Me.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGeneral.Location = New System.Drawing.Point(0, 21)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(675, 396)
        Me.PanelGeneral.TabIndex = 2
        '
        'PanelDetalleFactura
        '
        Me.PanelDetalleFactura.Controls.Add(Me.grlFacturaDetalle)
        Me.PanelDetalleFactura.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDetalleFactura.Location = New System.Drawing.Point(0, 267)
        Me.PanelDetalleFactura.Name = "PanelDetalleFactura"
        Me.PanelDetalleFactura.Size = New System.Drawing.Size(675, 129)
        Me.PanelDetalleFactura.TabIndex = 3
        '
        'grlFacturaDetalle
        '
        Me.grlFacturaDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlFacturaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlFacturaDetalle.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlFacturaDetalle.Location = New System.Drawing.Point(0, 0)
        Me.grlFacturaDetalle.Name = "grlFacturaDetalle"
        Me.grlFacturaDetalle.Size = New System.Drawing.Size(675, 129)
        Me.grlFacturaDetalle.TabIndex = 1
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(675, 471)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmFacturas"
        Me.Text = "Facturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.Encabezado.ResumeLayout(False)
        Me.Encabezado.PerformLayout()
        Me.PanelFacturaCartel.ResumeLayout(False)
        Me.PanelFacturaCartel.PerformLayout()
        Me.PanelFactura.ResumeLayout(False)
        CType(Me.grlFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelGeneral.PerformLayout()
        Me.PanelDetalleFactura.ResumeLayout(False)
        CType(Me.grlFacturaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelBotones As System.Windows.Forms.Panel
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdFacturasEliminadas As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents Encabezado As System.Windows.Forms.Panel
    Friend WithEvents PanelDetalleFacturaCartel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelFacturaCartel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelFactura As System.Windows.Forms.Panel
    Friend WithEvents PanelGeneral As System.Windows.Forms.Panel
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents rbtMontoMenor As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNombreCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNroFactura As System.Windows.Forms.RadioButton
    Friend WithEvents grlFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents PanelDetalleFactura As System.Windows.Forms.Panel
    Friend WithEvents grlFacturaDetalle As System.Windows.Forms.DataGridView
End Class

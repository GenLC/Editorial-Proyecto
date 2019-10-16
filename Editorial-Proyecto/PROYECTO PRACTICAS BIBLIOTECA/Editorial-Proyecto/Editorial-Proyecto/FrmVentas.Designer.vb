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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClienteSeleccionado = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpFactura = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpLibros = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grlLibros = New System.Windows.Forms.DataGridView()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.grlClientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grlResumenVenta = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grpFactura.SuspendLayout()
        Me.grpLibros.SuspendLayout()
        CType(Me.grlLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCliente.SuspendLayout()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grlResumenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.lblClienteSeleccionado)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.grpFactura)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.grpLibros)
        Me.Panel1.Controls.Add(Me.grpCliente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 562)
        Me.Panel1.TabIndex = 0
        '
        'lblClienteSeleccionado
        '
        Me.lblClienteSeleccionado.AutoSize = True
        Me.lblClienteSeleccionado.Location = New System.Drawing.Point(462, 82)
        Me.lblClienteSeleccionado.Name = "lblClienteSeleccionado"
        Me.lblClienteSeleccionado.Size = New System.Drawing.Size(104, 13)
        Me.lblClienteSeleccionado.TabIndex = 8
        Me.lblClienteSeleccionado.Text = "ClienteSeleccionado"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(718, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(317, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Agregar Libro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grpFactura
        '
        Me.grpFactura.Controls.Add(Me.Button5)
        Me.grpFactura.Controls.Add(Me.Button4)
        Me.grpFactura.Controls.Add(Me.Button3)
        Me.grpFactura.Controls.Add(Me.Label5)
        Me.grpFactura.Controls.Add(Me.Label4)
        Me.grpFactura.Controls.Add(Me.TextBox3)
        Me.grpFactura.Controls.Add(Me.Label3)
        Me.grpFactura.Controls.Add(Me.Label2)
        Me.grpFactura.Controls.Add(Me.TextBox2)
        Me.grpFactura.Controls.Add(Me.DateTimePicker1)
        Me.grpFactura.Controls.Add(Me.ComboBox1)
        Me.grpFactura.Location = New System.Drawing.Point(12, 113)
        Me.grpFactura.Name = "grpFactura"
        Me.grpFactura.Size = New System.Drawing.Size(438, 161)
        Me.grpFactura.TabIndex = 6
        Me.grpFactura.TabStop = False
        Me.grpFactura.Text = "Factura"
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(245, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 20)
        Me.TextBox3.TabIndex = 5
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 20)
        Me.TextBox2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(106, 124)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(106, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpLibros
        '
        Me.grpLibros.Controls.Add(Me.TextBox1)
        Me.grpLibros.Controls.Add(Me.grlLibros)
        Me.grpLibros.Location = New System.Drawing.Point(715, 82)
        Me.grpLibros.Name = "grpLibros"
        Me.grpLibros.Size = New System.Drawing.Size(323, 429)
        Me.grpLibros.TabIndex = 4
        Me.grpLibros.TabStop = False
        Me.grpLibros.Text = "SELECCIONE LOS LIBROS A VENDER"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(307, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Buscador"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.grpCliente.Location = New System.Drawing.Point(21, 303)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(324, 205)
        Me.grpCliente.TabIndex = 2
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "SELECCIONE EL CLIENTE"
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(3, 31)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(317, 20)
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
        Me.grlClientes.Size = New System.Drawing.Size(318, 145)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.grlResumenVenta)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 560)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1050, 157)
        Me.Panel3.TabIndex = 1
        '
        'grlResumenVenta
        '
        Me.grlResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlResumenVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlResumenVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlResumenVenta.Location = New System.Drawing.Point(0, 0)
        Me.grlResumenVenta.Name = "grlResumenVenta"
        Me.grlResumenVenta.ReadOnly = True
        Me.grlResumenVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlResumenVenta.Size = New System.Drawing.Size(1050, 157)
        Me.grlResumenVenta.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(345, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(345, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Limpiar "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(345, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Nueva"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 717)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
        Me.Panel3.ResumeLayout(False)
        CType(Me.grlResumenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents grpLibros As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents grlClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grlLibros As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents grpFactura As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents grlResumenVenta As System.Windows.Forms.DataGridView
    Friend WithEvents lblClienteSeleccionado As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class

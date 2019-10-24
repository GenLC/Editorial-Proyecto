<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaLibroSeleccion
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
        Me.grpLibros = New System.Windows.Forms.GroupBox()
        Me.txtBuscadoLibros = New System.Windows.Forms.TextBox()
        Me.grlLibros = New System.Windows.Forms.DataGridView()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAgregarNuevoLibro = New System.Windows.Forms.Button()
        Me.cmdAgregarLibro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClienteSeleccionado = New System.Windows.Forms.Label()
        Me.grpLibros.SuspendLayout()
        CType(Me.grlLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpLibros
        '
        Me.grpLibros.Controls.Add(Me.txtBuscadoLibros)
        Me.grpLibros.Controls.Add(Me.grlLibros)
        Me.grpLibros.Location = New System.Drawing.Point(49, 31)
        Me.grpLibros.Name = "grpLibros"
        Me.grpLibros.Size = New System.Drawing.Size(323, 429)
        Me.grpLibros.TabIndex = 5
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
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(428, 394)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(144, 33)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Text = "Cancelar "
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAgregarNuevoLibro
        '
        Me.cmdAgregarNuevoLibro.Location = New System.Drawing.Point(428, 310)
        Me.cmdAgregarNuevoLibro.Name = "cmdAgregarNuevoLibro"
        Me.cmdAgregarNuevoLibro.Size = New System.Drawing.Size(144, 33)
        Me.cmdAgregarNuevoLibro.TabIndex = 11
        Me.cmdAgregarNuevoLibro.Text = "Agregar Nuevo Libro"
        Me.cmdAgregarNuevoLibro.UseVisualStyleBackColor = True
        '
        'cmdAgregarLibro
        '
        Me.cmdAgregarLibro.Location = New System.Drawing.Point(428, 226)
        Me.cmdAgregarLibro.Name = "cmdAgregarLibro"
        Me.cmdAgregarLibro.Size = New System.Drawing.Size(144, 33)
        Me.cmdAgregarLibro.TabIndex = 13
        Me.cmdAgregarLibro.Text = "Agrega Libro"
        Me.cmdAgregarLibro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(459, 143)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cliente"
        '
        'lblClienteSeleccionado
        '
        Me.lblClienteSeleccionado.AutoSize = True
        Me.lblClienteSeleccionado.Location = New System.Drawing.Point(456, 51)
        Me.lblClienteSeleccionado.Name = "lblClienteSeleccionado"
        Me.lblClienteSeleccionado.Size = New System.Drawing.Size(10, 13)
        Me.lblClienteSeleccionado.TabIndex = 17
        Me.lblClienteSeleccionado.Text = "-"
        '
        'FrmVentaLibroSeleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 472)
        Me.Controls.Add(Me.lblClienteSeleccionado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAgregarLibro)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAgregarNuevoLibro)
        Me.Controls.Add(Me.grpLibros)
        Me.Name = "FrmVentaLibroSeleccion"
        Me.Text = "FrmVentaLibroSeleccion"
        Me.grpLibros.ResumeLayout(False)
        Me.grpLibros.PerformLayout()
        CType(Me.grlLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLibros As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscadoLibros As System.Windows.Forms.TextBox
    Friend WithEvents grlLibros As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarNuevoLibro As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarLibro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblClienteSeleccionado As System.Windows.Forms.Label
End Class

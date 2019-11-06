<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Me.txtBuscardor = New System.Windows.Forms.TextBox()
        Me.grl_GrillaStock = New System.Windows.Forms.DataGridView()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Accion = New System.Windows.Forms.Label()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grl_GrillaStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscardor
        '
        Me.txtBuscardor.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.txtBuscardor.Location = New System.Drawing.Point(198, 227)
        Me.txtBuscardor.Name = "txtBuscardor"
        Me.txtBuscardor.Size = New System.Drawing.Size(150, 21)
        Me.txtBuscardor.TabIndex = 61
        '
        'grl_GrillaStock
        '
        Me.grl_GrillaStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grl_GrillaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_GrillaStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grl_GrillaStock.Location = New System.Drawing.Point(0, 0)
        Me.grl_GrillaStock.Name = "grl_GrillaStock"
        Me.grl_GrillaStock.ReadOnly = True
        Me.grl_GrillaStock.Size = New System.Drawing.Size(570, 181)
        Me.grl_GrillaStock.TabIndex = 0
        Me.grl_GrillaStock.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.txtCantidad.Location = New System.Drawing.Point(198, 330)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(69, 21)
        Me.txtCantidad.TabIndex = 48
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Cantidad.Location = New System.Drawing.Point(114, 336)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(62, 16)
        Me.Cantidad.TabIndex = 60
        Me.Cantidad.Text = "Cantidad"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Accion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(570, 38)
        Me.Panel2.TabIndex = 57
        '
        'lbl_Accion
        '
        Me.lbl_Accion.AutoSize = True
        Me.lbl_Accion.Location = New System.Drawing.Point(12, 16)
        Me.lbl_Accion.Name = "lbl_Accion"
        Me.lbl_Accion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Accion.TabIndex = 0
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(471, 395)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Cancelar.TabIndex = 51
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(114, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre "
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Aceptar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Aceptar.Location = New System.Drawing.Point(373, 395)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Aceptar.TabIndex = 50
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Modificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Modificar.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Modificar.Location = New System.Drawing.Point(471, 187)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Modificar.TabIndex = 45
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Agregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Agregar.ForeColor = System.Drawing.Color.Red
        Me.cmd_Agregar.Location = New System.Drawing.Point(373, 187)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Agregar.TabIndex = 44
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Limpiar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Limpiar.Location = New System.Drawing.Point(0, 187)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Limpiar.TabIndex = 53
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grl_GrillaStock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 181)
        Me.Panel1.TabIndex = 52
        '
        'cboLibro
        '
        Me.cboLibro.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.cboLibro.FormattingEnabled = True
        Me.cboLibro.Location = New System.Drawing.Point(198, 282)
        Me.cboLibro.Name = "cboLibro"
        Me.cboLibro.Size = New System.Drawing.Size(150, 24)
        Me.cboLibro.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(114, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Buscador"
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(570, 469)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLibro)
        Me.Controls.Add(Me.txtBuscardor)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_Aceptar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmStock"
        Me.Text = "Stock"
        CType(Me.grl_GrillaStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscardor As System.Windows.Forms.TextBox
    Friend WithEvents grl_GrillaStock As System.Windows.Forms.DataGridView
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboLibro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMClientes
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
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.grbCuotas = New System.Windows.Forms.GroupBox()
        Me.grlLibrosClientes = New System.Windows.Forms.DataGridView()
        Me.chkEstadoCliente = New System.Windows.Forms.CheckBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.grlClientes = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdModif = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.grbCuotas.SuspendLayout()
        CType(Me.grlLibrosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAccion.Location = New System.Drawing.Point(0, 0)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(0, 13)
        Me.lblAccion.TabIndex = 0
        '
        'grbCuotas
        '
        Me.grbCuotas.Controls.Add(Me.grlLibrosClientes)
        Me.grbCuotas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCuotas.Location = New System.Drawing.Point(15, 441)
        Me.grbCuotas.Name = "grbCuotas"
        Me.grbCuotas.Size = New System.Drawing.Size(478, 171)
        Me.grbCuotas.TabIndex = 201
        Me.grbCuotas.TabStop = False
        Me.grbCuotas.Text = "Libros llevados recientemente"
        '
        'grlLibrosClientes
        '
        Me.grlLibrosClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlLibrosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlLibrosClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlLibrosClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlLibrosClientes.Location = New System.Drawing.Point(3, 17)
        Me.grlLibrosClientes.Name = "grlLibrosClientes"
        Me.grlLibrosClientes.ReadOnly = True
        Me.grlLibrosClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlLibrosClientes.Size = New System.Drawing.Size(472, 151)
        Me.grlLibrosClientes.TabIndex = 3
        '
        'chkEstadoCliente
        '
        Me.chkEstadoCliente.AutoSize = True
        Me.chkEstadoCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoCliente.Location = New System.Drawing.Point(322, 249)
        Me.chkEstadoCliente.Name = "chkEstadoCliente"
        Me.chkEstadoCliente.Size = New System.Drawing.Size(102, 20)
        Me.chkEstadoCliente.TabIndex = 200
        Me.chkEstadoCliente.Text = "EstadoCliente"
        Me.chkEstadoCliente.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(133, 249)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(74, 21)
        Me.txtIdCliente.TabIndex = 197
        '
        'grlClientes
        '
        Me.grlClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlClientes.Location = New System.Drawing.Point(0, 0)
        Me.grlClientes.Name = "grlClientes"
        Me.grlClientes.ReadOnly = True
        Me.grlClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlClientes.Size = New System.Drawing.Size(812, 170)
        Me.grlClientes.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Codigo Cliente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 618)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 29)
        Me.Panel1.TabIndex = 195
        '
        'cmdModif
        '
        Me.cmdModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModif.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModif.Location = New System.Drawing.Point(673, 209)
        Me.cmdModif.Name = "cmdModif"
        Me.cmdModif.Size = New System.Drawing.Size(115, 35)
        Me.cmdModif.TabIndex = 194
        Me.cmdModif.Text = "Modificar"
        Me.cmdModif.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(509, 554)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(115, 35)
        Me.cmdAceptar.TabIndex = 192
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(670, 554)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(115, 35)
        Me.cmdCancelar.TabIndex = 193
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLimpiar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(15, 209)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(115, 35)
        Me.cmdLimpiar.TabIndex = 191
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(512, 209)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(115, 35)
        Me.cmdAgregar.TabIndex = 190
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(133, 403)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(156, 21)
        Me.txtMail.TabIndex = 174
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelMovil.Location = New System.Drawing.Point(133, 359)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(156, 21)
        Me.txtTelMovil.TabIndex = 173
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreApellido.Location = New System.Drawing.Point(133, 281)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(156, 21)
        Me.txtNombreApellido.TabIndex = 165
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(133, 318)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(156, 21)
        Me.txtDNI.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Apellido y nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "DNI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 16)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "Telefono Móvil"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grlClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 170)
        Me.Panel2.TabIndex = 175
        '
        'txtBuscador
        '
        Me.txtBuscador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(0, 176)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(312, 21)
        Me.txtBuscador.TabIndex = 203
        Me.txtBuscador.Text = "BUSCADOR..."
        '
        'FrmABMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 647)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.grbCuotas)
        Me.Controls.Add(Me.chkEstadoCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdModif)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtTelMovil)
        Me.Controls.Add(Me.txtNombreApellido)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmABMClientes"
        Me.Text = "Clientes"
        Me.grbCuotas.ResumeLayout(False)
        CType(Me.grlLibrosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents grbCuotas As System.Windows.Forms.GroupBox
    Friend WithEvents chkEstadoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents grlClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdModif As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grlLibrosClientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.grbCuotas = New System.Windows.Forms.GroupBox()
        Me.txtCantBolsasMes = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdLimpiarDatos = New System.Windows.Forms.Button()
        Me.cmdCalcularDatos = New System.Windows.Forms.Button()
        Me.txtCantBolsasTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrecioCuota = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantCuotas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkEstadoCliente = New System.Windows.Forms.CheckBox()
        Me.txtValorPlan = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.grlClientes = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtValorBolsa = New System.Windows.Forms.TextBox()
        Me.cmdModif = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboProvincias = New System.Windows.Forms.ComboBox()
        Me.cboPlanTipo = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grbCuotas.SuspendLayout()
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(226, 190)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 13)
        Me.Label19.TabIndex = 203
        Me.Label19.Text = "Valor actual de la Bolsa:"
        '
        'grbCuotas
        '
        Me.grbCuotas.Controls.Add(Me.txtCantBolsasMes)
        Me.grbCuotas.Controls.Add(Me.Label18)
        Me.grbCuotas.Controls.Add(Me.cmdLimpiarDatos)
        Me.grbCuotas.Controls.Add(Me.cmdCalcularDatos)
        Me.grbCuotas.Controls.Add(Me.txtCantBolsasTotal)
        Me.grbCuotas.Controls.Add(Me.Label17)
        Me.grbCuotas.Controls.Add(Me.txtPrecioCuota)
        Me.grbCuotas.Controls.Add(Me.Label15)
        Me.grbCuotas.Controls.Add(Me.txtCantCuotas)
        Me.grbCuotas.Controls.Add(Me.Label14)
        Me.grbCuotas.Location = New System.Drawing.Point(12, 476)
        Me.grbCuotas.Name = "grbCuotas"
        Me.grbCuotas.Size = New System.Drawing.Size(558, 137)
        Me.grbCuotas.TabIndex = 201
        Me.grbCuotas.TabStop = False
        '
        'txtCantBolsasMes
        '
        Me.txtCantBolsasMes.Location = New System.Drawing.Point(394, 60)
        Me.txtCantBolsasMes.Name = "txtCantBolsasMes"
        Me.txtCantBolsasMes.Size = New System.Drawing.Size(156, 20)
        Me.txtCantBolsasMes.TabIndex = 171
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(298, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 170
        Me.Label18.Text = "Cant Bolsas/Mes"
        '
        'cmdLimpiarDatos
        '
        Me.cmdLimpiarDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLimpiarDatos.Location = New System.Drawing.Point(30, 91)
        Me.cmdLimpiarDatos.Name = "cmdLimpiarDatos"
        Me.cmdLimpiarDatos.Size = New System.Drawing.Size(91, 26)
        Me.cmdLimpiarDatos.TabIndex = 169
        Me.cmdLimpiarDatos.Text = "Limpiar"
        Me.cmdLimpiarDatos.UseVisualStyleBackColor = True
        '
        'cmdCalcularDatos
        '
        Me.cmdCalcularDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCalcularDatos.Location = New System.Drawing.Point(459, 96)
        Me.cmdCalcularDatos.Name = "cmdCalcularDatos"
        Me.cmdCalcularDatos.Size = New System.Drawing.Size(91, 26)
        Me.cmdCalcularDatos.TabIndex = 168
        Me.cmdCalcularDatos.Text = "Calcular"
        Me.cmdCalcularDatos.UseVisualStyleBackColor = True
        '
        'txtCantBolsasTotal
        '
        Me.txtCantBolsasTotal.Location = New System.Drawing.Point(394, 21)
        Me.txtCantBolsasTotal.Name = "txtCantBolsasTotal"
        Me.txtCantBolsasTotal.Size = New System.Drawing.Size(156, 20)
        Me.txtCantBolsasTotal.TabIndex = 166
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(298, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 165
        Me.Label17.Text = "Cant Bolsas Total"
        '
        'txtPrecioCuota
        '
        Me.txtPrecioCuota.Location = New System.Drawing.Point(116, 60)
        Me.txtPrecioCuota.Name = "txtPrecioCuota"
        Me.txtPrecioCuota.Size = New System.Drawing.Size(156, 20)
        Me.txtPrecioCuota.TabIndex = 164
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 163
        Me.Label15.Text = "Precio por Cuota"
        '
        'txtCantCuotas
        '
        Me.txtCantCuotas.Location = New System.Drawing.Point(116, 24)
        Me.txtCantCuotas.Name = "txtCantCuotas"
        Me.txtCantCuotas.Size = New System.Drawing.Size(156, 20)
        Me.txtCantCuotas.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "Cantidad de Cuotas"
        '
        'chkEstadoCliente
        '
        Me.chkEstadoCliente.AutoSize = True
        Me.chkEstadoCliente.Location = New System.Drawing.Point(320, 247)
        Me.chkEstadoCliente.Name = "chkEstadoCliente"
        Me.chkEstadoCliente.Size = New System.Drawing.Size(91, 17)
        Me.chkEstadoCliente.TabIndex = 200
        Me.chkEstadoCliente.Text = "EstadoCliente"
        Me.chkEstadoCliente.UseVisualStyleBackColor = True
        '
        'txtValorPlan
        '
        Me.txtValorPlan.Location = New System.Drawing.Point(708, 476)
        Me.txtValorPlan.Name = "txtValorPlan"
        Me.txtValorPlan.ReadOnly = True
        Me.txtValorPlan.Size = New System.Drawing.Size(156, 20)
        Me.txtValorPlan.TabIndex = 199
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(606, 478)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 198
        Me.Label16.Text = "Valor del Plan"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(111, 248)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(156, 20)
        Me.txtIdCliente.TabIndex = 197
        '
        'grlClientes
        '
        Me.grlClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.grlClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlClientes.Location = New System.Drawing.Point(0, 0)
        Me.grlClientes.Name = "grlClientes"
        Me.grlClientes.ReadOnly = True
        Me.grlClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlClientes.Size = New System.Drawing.Size(934, 170)
        Me.grlClientes.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Codigo Cliente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 618)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 29)
        Me.Panel1.TabIndex = 195
        '
        'txtValorBolsa
        '
        Me.txtValorBolsa.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorBolsa.Location = New System.Drawing.Point(381, 179)
        Me.txtValorBolsa.Name = "txtValorBolsa"
        Me.txtValorBolsa.ReadOnly = True
        Me.txtValorBolsa.Size = New System.Drawing.Size(96, 32)
        Me.txtValorBolsa.TabIndex = 202
        '
        'cmdModif
        '
        Me.cmdModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModif.Location = New System.Drawing.Point(749, 176)
        Me.cmdModif.Name = "cmdModif"
        Me.cmdModif.Size = New System.Drawing.Size(115, 35)
        Me.cmdModif.TabIndex = 194
        Me.cmdModif.Text = "Modificar"
        Me.cmdModif.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.Location = New System.Drawing.Point(609, 563)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(115, 35)
        Me.cmdAceptar.TabIndex = 192
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.Location = New System.Drawing.Point(788, 563)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(115, 35)
        Me.cmdCancelar.TabIndex = 193
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 176)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(115, 35)
        Me.cmdLimpiar.TabIndex = 191
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAgregar.Location = New System.Drawing.Point(570, 176)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(115, 35)
        Me.cmdAgregar.TabIndex = 190
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(616, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Tipo de Plan"
        '
        'cboProvincias
        '
        Me.cboProvincias.FormattingEnabled = True
        Me.cboProvincias.Location = New System.Drawing.Point(111, 327)
        Me.cboProvincias.Name = "cboProvincias"
        Me.cboProvincias.Size = New System.Drawing.Size(156, 21)
        Me.cboProvincias.TabIndex = 188
        '
        'cboPlanTipo
        '
        Me.cboPlanTipo.FormattingEnabled = True
        Me.cboPlanTipo.Location = New System.Drawing.Point(708, 425)
        Me.cboPlanTipo.Name = "cboPlanTipo"
        Me.cboPlanTipo.Size = New System.Drawing.Size(156, 21)
        Me.cboPlanTipo.TabIndex = 187
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(406, 422)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(156, 20)
        Me.txtMail.TabIndex = 174
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Location = New System.Drawing.Point(111, 422)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(156, 20)
        Me.txtTelMovil.TabIndex = 173
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(708, 377)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(49, 20)
        Me.txtNumero.TabIndex = 172
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(406, 377)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(156, 20)
        Me.txtCalle.TabIndex = 171
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(708, 327)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(156, 20)
        Me.txtBarrio.TabIndex = 169
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(111, 377)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(49, 20)
        Me.txtCodPostal.TabIndex = 170
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(406, 327)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(156, 20)
        Me.txtLocalidad.TabIndex = 168
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(111, 284)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 20)
        Me.txtNombre.TabIndex = 165
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(708, 284)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(156, 20)
        Me.txtDNI.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Nombre"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(406, 284)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(156, 20)
        Me.txtApellido.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "DNI"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 183
        Me.Label12.Text = "Cod. Postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(317, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "Telefono Móvil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Provincia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(641, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Barrio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(641, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Número"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Calle"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grlClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 170)
        Me.Panel2.TabIndex = 175
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 647)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.grbCuotas)
        Me.Controls.Add(Me.chkEstadoCliente)
        Me.Controls.Add(Me.txtValorPlan)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtValorBolsa)
        Me.Controls.Add(Me.cmdModif)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboProvincias)
        Me.Controls.Add(Me.cboPlanTipo)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtTelMovil)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtBarrio)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.grbCuotas.ResumeLayout(False)
        Me.grbCuotas.PerformLayout()
        CType(Me.grlClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents grbCuotas As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantBolsasMes As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiarDatos As System.Windows.Forms.Button
    Friend WithEvents cmdCalcularDatos As System.Windows.Forms.Button
    Friend WithEvents txtCantBolsasTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCantCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkEstadoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents txtValorPlan As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents grlClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtValorBolsa As System.Windows.Forms.TextBox
    Friend WithEvents cmdModif As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlanTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class

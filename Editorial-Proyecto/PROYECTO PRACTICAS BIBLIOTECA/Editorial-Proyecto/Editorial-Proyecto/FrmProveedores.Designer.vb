<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Me.grl_GrillaProveedores = New System.Windows.Forms.DataGridView()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_IDProveedor = New System.Windows.Forms.TextBox()
        Me.txt_NombreCompañia = New System.Windows.Forms.TextBox()
        Me.txt_NombreFantasia = New System.Windows.Forms.TextBox()
        Me.txt_NombreContacto = New System.Windows.Forms.TextBox()
        Me.txt_NroCuit = New System.Windows.Forms.TextBox()
        Me.txt_NroContacto = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grl_GrillaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grl_GrillaProveedores)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 211)
        Me.Panel1.TabIndex = 0
        '
        'grl_GrillaProveedores
        '
        Me.grl_GrillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_GrillaProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grl_GrillaProveedores.Location = New System.Drawing.Point(0, 0)
        Me.grl_GrillaProveedores.Name = "grl_GrillaProveedores"
        Me.grl_GrillaProveedores.ReadOnly = True
        Me.grl_GrillaProveedores.Size = New System.Drawing.Size(609, 211)
        Me.grl_GrillaProveedores.TabIndex = 0
        Me.grl_GrillaProveedores.TabStop = False
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 217)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(89, 38)
        Me.cmd_Limpiar.TabIndex = 1
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Agregar.ForeColor = System.Drawing.Color.Red
        Me.cmd_Agregar.Location = New System.Drawing.Point(404, 217)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(89, 38)
        Me.cmd_Agregar.TabIndex = 2
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Modificar.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Modificar.Location = New System.Drawing.Point(499, 217)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(89, 38)
        Me.cmd_Modificar.TabIndex = 3
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Estado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 487)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(609, 37)
        Me.Panel2.TabIndex = 4
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(13, 12)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Estado.TabIndex = 0
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Aceptar.Location = New System.Drawing.Point(404, 435)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(89, 38)
        Me.cmd_Aceptar.TabIndex = 7
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Cancelar.Location = New System.Drawing.Point(499, 435)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(89, 38)
        Me.cmd_Cancelar.TabIndex = 8
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre Compañia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre Fantasia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre Contacto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Numero Cuit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Numero Contacto"
        '
        'txt_IDProveedor
        '
        Me.txt_IDProveedor.Location = New System.Drawing.Point(278, 265)
        Me.txt_IDProveedor.Name = "txt_IDProveedor"
        Me.txt_IDProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_IDProveedor.TabIndex = 1
        '
        'txt_NombreCompañia
        '
        Me.txt_NombreCompañia.Location = New System.Drawing.Point(278, 293)
        Me.txt_NombreCompañia.Name = "txt_NombreCompañia"
        Me.txt_NombreCompañia.Size = New System.Drawing.Size(182, 20)
        Me.txt_NombreCompañia.TabIndex = 2
        '
        'txt_NombreFantasia
        '
        Me.txt_NombreFantasia.Location = New System.Drawing.Point(278, 317)
        Me.txt_NombreFantasia.Name = "txt_NombreFantasia"
        Me.txt_NombreFantasia.Size = New System.Drawing.Size(182, 20)
        Me.txt_NombreFantasia.TabIndex = 3
        '
        'txt_NombreContacto
        '
        Me.txt_NombreContacto.Location = New System.Drawing.Point(278, 344)
        Me.txt_NombreContacto.Name = "txt_NombreContacto"
        Me.txt_NombreContacto.Size = New System.Drawing.Size(182, 20)
        Me.txt_NombreContacto.TabIndex = 4
        '
        'txt_NroCuit
        '
        Me.txt_NroCuit.Location = New System.Drawing.Point(278, 373)
        Me.txt_NroCuit.Name = "txt_NroCuit"
        Me.txt_NroCuit.Size = New System.Drawing.Size(182, 20)
        Me.txt_NroCuit.TabIndex = 5
        '
        'txt_NroContacto
        '
        Me.txt_NroContacto.Location = New System.Drawing.Point(278, 402)
        Me.txt_NroContacto.Name = "txt_NroContacto"
        Me.txt_NroContacto.Size = New System.Drawing.Size(182, 20)
        Me.txt_NroContacto.TabIndex = 6
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 524)
        Me.Controls.Add(Me.txt_NroContacto)
        Me.Controls.Add(Me.txt_NroCuit)
        Me.Controls.Add(Me.txt_NombreContacto)
        Me.Controls.Add(Me.txt_NombreFantasia)
        Me.Controls.Add(Me.txt_NombreCompañia)
        Me.Controls.Add(Me.txt_IDProveedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Aceptar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProveedores"
        Me.Text = "Proveedores"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grl_GrillaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grl_GrillaProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents txt_IDProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreCompañia As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreFantasia As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreContacto As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroCuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroContacto As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulosGenero
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
        Me.grl_ArticulosGenero = New System.Windows.Forms.DataGridView()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.txt_IDArticulo = New System.Windows.Forms.TextBox()
        Me.txt_Genero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.txt_TipoArticulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grl_ArticulosGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grl_ArticulosGenero)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 207)
        Me.Panel1.TabIndex = 0
        '
        'grl_ArticulosGenero
        '
        Me.grl_ArticulosGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_ArticulosGenero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grl_ArticulosGenero.Location = New System.Drawing.Point(0, 0)
        Me.grl_ArticulosGenero.Name = "grl_ArticulosGenero"
        Me.grl_ArticulosGenero.Size = New System.Drawing.Size(639, 207)
        Me.grl_ArticulosGenero.TabIndex = 0
        Me.grl_ArticulosGenero.TabStop = False
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 213)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Limpiar.TabIndex = 2
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Modificar.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Modificar.Location = New System.Drawing.Point(517, 213)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Modificar.TabIndex = 5
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Agregar.ForeColor = System.Drawing.Color.Red
        Me.cmd_Agregar.Location = New System.Drawing.Point(419, 213)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Agregar.TabIndex = 4
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Cancelar.Location = New System.Drawing.Point(517, 381)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Cancelar.TabIndex = 13
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Aceptar.Location = New System.Drawing.Point(419, 381)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Aceptar.TabIndex = 12
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'txt_IDArticulo
        '
        Me.txt_IDArticulo.Location = New System.Drawing.Point(305, 264)
        Me.txt_IDArticulo.Name = "txt_IDArticulo"
        Me.txt_IDArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txt_IDArticulo.TabIndex = 9
        '
        'txt_Genero
        '
        Me.txt_Genero.Location = New System.Drawing.Point(305, 294)
        Me.txt_Genero.Name = "txt_Genero"
        Me.txt_Genero.Size = New System.Drawing.Size(163, 20)
        Me.txt_Genero.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Genero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Estado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 39)
        Me.Panel2.TabIndex = 14
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(4, 14)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Estado.TabIndex = 0
        '
        'txt_TipoArticulo
        '
        Me.txt_TipoArticulo.Location = New System.Drawing.Point(305, 330)
        Me.txt_TipoArticulo.Name = "txt_TipoArticulo"
        Me.txt_TipoArticulo.Size = New System.Drawing.Size(163, 20)
        Me.txt_TipoArticulo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre Tipo Articulo"
        '
        'FrmArticulosGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 463)
        Me.Controls.Add(Me.txt_TipoArticulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Aceptar)
        Me.Controls.Add(Me.txt_IDArticulo)
        Me.Controls.Add(Me.txt_Genero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmArticulosGenero"
        Me.Text = "ArticulosGenero"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grl_ArticulosGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grl_ArticulosGenero As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_IDArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Genero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents txt_TipoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

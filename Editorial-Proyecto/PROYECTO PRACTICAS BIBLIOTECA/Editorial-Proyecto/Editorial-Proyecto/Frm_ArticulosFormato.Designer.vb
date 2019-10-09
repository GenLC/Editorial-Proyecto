<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ArticulosFormato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ArticulosFormato))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grl_GrillaArtFormato = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IDArtFormato = New System.Windows.Forms.TextBox()
        Me.txt_NombreTipoFormato = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grl_GrillaArtFormato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grl_GrillaArtFormato)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 223)
        Me.Panel1.TabIndex = 0
        '
        'grl_GrillaArtFormato
        '
        Me.grl_GrillaArtFormato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_GrillaArtFormato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grl_GrillaArtFormato.Location = New System.Drawing.Point(0, 0)
        Me.grl_GrillaArtFormato.Name = "grl_GrillaArtFormato"
        Me.grl_GrillaArtFormato.ReadOnly = True
        Me.grl_GrillaArtFormato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grl_GrillaArtFormato.Size = New System.Drawing.Size(558, 223)
        Me.grl_GrillaArtFormato.TabIndex = 0
        Me.grl_GrillaArtFormato.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Estado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 434)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(558, 39)
        Me.Panel2.TabIndex = 1
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(13, 14)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Estado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Art.Formato"
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 229)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(96, 36)
        Me.cmd_Limpiar.TabIndex = 1
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Agregar.ForeColor = System.Drawing.Color.Red
        Me.cmd_Agregar.Location = New System.Drawing.Point(354, 229)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(96, 36)
        Me.cmd_Agregar.TabIndex = 2
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Modificar.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Modificar.Location = New System.Drawing.Point(456, 229)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(96, 36)
        Me.cmd_Modificar.TabIndex = 3
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Aceptar.Location = New System.Drawing.Point(354, 392)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(96, 36)
        Me.cmd_Aceptar.TabIndex = 5
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Cancelar.Location = New System.Drawing.Point(456, 392)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(96, 36)
        Me.cmd_Cancelar.TabIndex = 6
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre Tipo Art.Formato"
        '
        'txt_IDArtFormato
        '
        Me.txt_IDArtFormato.Location = New System.Drawing.Point(210, 300)
        Me.txt_IDArtFormato.Name = "txt_IDArtFormato"
        Me.txt_IDArtFormato.Size = New System.Drawing.Size(100, 20)
        Me.txt_IDArtFormato.TabIndex = 9
        '
        'txt_NombreTipoFormato
        '
        Me.txt_NombreTipoFormato.Location = New System.Drawing.Point(210, 331)
        Me.txt_NombreTipoFormato.Name = "txt_NombreTipoFormato"
        Me.txt_NombreTipoFormato.Size = New System.Drawing.Size(179, 20)
        Me.txt_NombreTipoFormato.TabIndex = 4
        '
        'Frm_ArticulosFormato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 473)
        Me.Controls.Add(Me.txt_NombreTipoFormato)
        Me.Controls.Add(Me.txt_IDArtFormato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Aceptar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ArticulosFormato"
        Me.Text = "ArticulosFormato"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grl_GrillaArtFormato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grl_GrillaArtFormato As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IDArtFormato As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreTipoFormato As System.Windows.Forms.TextBox
End Class

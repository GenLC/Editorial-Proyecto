<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grl_GrillaEditorial = New System.Windows.Forms.DataGridView()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_NombreEditorial = New System.Windows.Forms.TextBox()
        Me.txt_IDEditorial = New System.Windows.Forms.TextBox()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Accion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grl_GrillaEditorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grl_GrillaEditorial)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 181)
        Me.Panel1.TabIndex = 0
        '
        'grl_GrillaEditorial
        '
        Me.grl_GrillaEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_GrillaEditorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grl_GrillaEditorial.Location = New System.Drawing.Point(0, 0)
        Me.grl_GrillaEditorial.Name = "grl_GrillaEditorial"
        Me.grl_GrillaEditorial.ReadOnly = True
        Me.grl_GrillaEditorial.Size = New System.Drawing.Size(462, 181)
        Me.grl_GrillaEditorial.TabIndex = 0
        Me.grl_GrillaEditorial.TabStop = False
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Limpiar.Location = New System.Drawing.Point(3, 187)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Limpiar.TabIndex = 1
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Agregar.ForeColor = System.Drawing.Color.Red
        Me.cmd_Agregar.Location = New System.Drawing.Point(260, 187)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Agregar.TabIndex = 2
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Modificar.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Modificar.Location = New System.Drawing.Point(358, 187)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Modificar.TabIndex = 3
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre "
        '
        'txt_NombreEditorial
        '
        Me.txt_NombreEditorial.Location = New System.Drawing.Point(189, 280)
        Me.txt_NombreEditorial.Name = "txt_NombreEditorial"
        Me.txt_NombreEditorial.Size = New System.Drawing.Size(163, 20)
        Me.txt_NombreEditorial.TabIndex = 5
        '
        'txt_IDEditorial
        '
        Me.txt_IDEditorial.Location = New System.Drawing.Point(189, 250)
        Me.txt_IDEditorial.Name = "txt_IDEditorial"
        Me.txt_IDEditorial.Size = New System.Drawing.Size(100, 20)
        Me.txt_IDEditorial.TabIndex = 4
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Aceptar.Location = New System.Drawing.Point(260, 319)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Aceptar.TabIndex = 6
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Cancelar.Location = New System.Drawing.Point(358, 319)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Cancelar.TabIndex = 7
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Accion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(462, 38)
        Me.Panel2.TabIndex = 10
        '
        'lbl_Accion
        '
        Me.lbl_Accion.AutoSize = True
        Me.lbl_Accion.Location = New System.Drawing.Point(12, 16)
        Me.lbl_Accion.Name = "lbl_Accion"
        Me.lbl_Accion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Accion.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 420)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Aceptar)
        Me.Controls.Add(Me.txt_IDEditorial)
        Me.Controls.Add(Me.txt_NombreEditorial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Editorial"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grl_GrillaEditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grl_GrillaEditorial As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreEditorial As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDEditorial As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label

End Class

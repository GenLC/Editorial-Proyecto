<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturasEliminadas
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
        Me.grlFacturasEliminadas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdRestaurar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.grlFacturasEliminadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grlFacturasEliminadas
        '
        Me.grlFacturasEliminadas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grlFacturasEliminadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlFacturasEliminadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grlFacturasEliminadas.Location = New System.Drawing.Point(0, 0)
        Me.grlFacturasEliminadas.Name = "grlFacturasEliminadas"
        Me.grlFacturasEliminadas.ReadOnly = True
        Me.grlFacturasEliminadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlFacturasEliminadas.Size = New System.Drawing.Size(723, 240)
        Me.grlFacturasEliminadas.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grlFacturasEliminadas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 240)
        Me.Panel1.TabIndex = 1
        '
        'cmdRestaurar
        '
        Me.cmdRestaurar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestaurar.Location = New System.Drawing.Point(49, 272)
        Me.cmdRestaurar.Name = "cmdRestaurar"
        Me.cmdRestaurar.Size = New System.Drawing.Size(98, 36)
        Me.cmdRestaurar.TabIndex = 2
        Me.cmdRestaurar.Text = "Restaurar"
        Me.cmdRestaurar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(579, 272)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(98, 36)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'FrmFacturasEliminadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(723, 320)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdRestaurar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmFacturasEliminadas"
        Me.Text = "FrmFacturasEliminadas"
        CType(Me.grlFacturasEliminadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grlFacturasEliminadas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRestaurar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class

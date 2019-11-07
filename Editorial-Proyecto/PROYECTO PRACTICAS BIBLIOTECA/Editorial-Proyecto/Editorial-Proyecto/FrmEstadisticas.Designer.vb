<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadisticas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.cmd_Actualizar = New System.Windows.Forms.Button()
        Me.txtTotalLibrosStock = New System.Windows.Forms.TextBox()
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox()
        Me.txtTotalClientes = New System.Windows.Forms.TextBox()
        Me.txtMaxCompraCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(27, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Máximo compra de clientes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(26, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Total de Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(27, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Total de ingresos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(27, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Total de libros en stock:"
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Salir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Salir.Location = New System.Drawing.Point(304, 307)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Salir.TabIndex = 53
        Me.cmd_Salir.Text = "Salir"
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'cmd_Actualizar
        '
        Me.cmd_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Actualizar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Actualizar.Location = New System.Drawing.Point(62, 307)
        Me.cmd_Actualizar.Name = "cmd_Actualizar"
        Me.cmd_Actualizar.Size = New System.Drawing.Size(92, 37)
        Me.cmd_Actualizar.TabIndex = 52
        Me.cmd_Actualizar.Text = "Actualizar"
        Me.cmd_Actualizar.UseVisualStyleBackColor = True
        '
        'txtTotalLibrosStock
        '
        Me.txtTotalLibrosStock.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLibrosStock.Location = New System.Drawing.Point(258, 25)
        Me.txtTotalLibrosStock.Name = "txtTotalLibrosStock"
        Me.txtTotalLibrosStock.ReadOnly = True
        Me.txtTotalLibrosStock.Size = New System.Drawing.Size(196, 41)
        Me.txtTotalLibrosStock.TabIndex = 54
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIngresos.Location = New System.Drawing.Point(258, 79)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.ReadOnly = True
        Me.txtTotalIngresos.Size = New System.Drawing.Size(196, 41)
        Me.txtTotalIngresos.TabIndex = 55
        '
        'txtTotalClientes
        '
        Me.txtTotalClientes.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalClientes.Location = New System.Drawing.Point(257, 136)
        Me.txtTotalClientes.Name = "txtTotalClientes"
        Me.txtTotalClientes.ReadOnly = True
        Me.txtTotalClientes.Size = New System.Drawing.Size(196, 41)
        Me.txtTotalClientes.TabIndex = 56
        '
        'txtMaxCompraCliente
        '
        Me.txtMaxCompraCliente.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxCompraCliente.Location = New System.Drawing.Point(257, 193)
        Me.txtMaxCompraCliente.Name = "txtMaxCompraCliente"
        Me.txtMaxCompraCliente.ReadOnly = True
        Me.txtMaxCompraCliente.Size = New System.Drawing.Size(196, 41)
        Me.txtMaxCompraCliente.TabIndex = 57
        '
        'FrmEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 369)
        Me.Controls.Add(Me.txtMaxCompraCliente)
        Me.Controls.Add(Me.txtTotalClientes)
        Me.Controls.Add(Me.txtTotalIngresos)
        Me.Controls.Add(Me.txtTotalLibrosStock)
        Me.Controls.Add(Me.cmd_Salir)
        Me.Controls.Add(Me.cmd_Actualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmEstadisticas"
        Me.Text = "FrmEstadisticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_Salir As System.Windows.Forms.Button
    Friend WithEvents cmd_Actualizar As System.Windows.Forms.Button
    Friend WithEvents txtTotalLibrosStock As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIngresos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalClientes As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxCompraCliente As System.Windows.Forms.TextBox
End Class

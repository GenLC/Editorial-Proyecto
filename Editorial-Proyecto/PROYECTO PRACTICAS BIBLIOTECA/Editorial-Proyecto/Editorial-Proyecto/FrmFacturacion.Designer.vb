<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion
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
        Me.PanelMenuFondo = New System.Windows.Forms.Panel()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdmClientes = New System.Windows.Forms.Button()
        Me.cmdVentas = New System.Windows.Forms.Button()
        Me.cmdAlquiler = New System.Windows.Forms.Button()
        Me.PanelMenuFondo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuFondo
        '
        Me.PanelMenuFondo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMenuFondo.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.a6537467ad00a76a7af8948075f9a5e4
        Me.PanelMenuFondo.Controls.Add(Me.cmdSalir)
        Me.PanelMenuFondo.Controls.Add(Me.Button5)
        Me.PanelMenuFondo.Controls.Add(Me.PanelMenu)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmClientes)
        Me.PanelMenuFondo.Controls.Add(Me.cmdVentas)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAlquiler)
        Me.PanelMenuFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenuFondo.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuFondo.Name = "PanelMenuFondo"
        Me.PanelMenuFondo.Size = New System.Drawing.Size(558, 477)
        Me.PanelMenuFondo.TabIndex = 2
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Image = Global.Editorial_Proyecto.My.Resources.Resources.izquierda
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalir.Location = New System.Drawing.Point(12, 62)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(71, 46)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "Volver"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(100, 421)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(328, 37)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Estadísticas"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(558, 56)
        Me.PanelMenu.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Facturacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAdmClientes
        '
        Me.cmdAdmClientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmClientes.Image = Global.Editorial_Proyecto.My.Resources.Resources.receipt
        Me.cmdAdmClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmClientes.Location = New System.Drawing.Point(100, 291)
        Me.cmdAdmClientes.Name = "cmdAdmClientes"
        Me.cmdAdmClientes.Size = New System.Drawing.Size(328, 124)
        Me.cmdAdmClientes.TabIndex = 6
        Me.cmdAdmClientes.Text = "Listado de Facturas"
        Me.cmdAdmClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmClientes.UseVisualStyleBackColor = True
        '
        'cmdVentas
        '
        Me.cmdVentas.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVentas.Image = Global.Editorial_Proyecto.My.Resources.Resources.shopping_cart
        Me.cmdVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdVentas.Location = New System.Drawing.Point(276, 130)
        Me.cmdVentas.Name = "cmdVentas"
        Me.cmdVentas.Size = New System.Drawing.Size(152, 124)
        Me.cmdVentas.TabIndex = 5
        Me.cmdVentas.Text = "Ventas"
        Me.cmdVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVentas.UseVisualStyleBackColor = True
        '
        'cmdAlquiler
        '
        Me.cmdAlquiler.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlquiler.Image = Global.Editorial_Proyecto.My.Resources.Resources.rent
        Me.cmdAlquiler.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAlquiler.Location = New System.Drawing.Point(100, 130)
        Me.cmdAlquiler.Name = "cmdAlquiler"
        Me.cmdAlquiler.Size = New System.Drawing.Size(152, 124)
        Me.cmdAlquiler.TabIndex = 4
        Me.cmdAlquiler.Text = "Alquileres"
        Me.cmdAlquiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlquiler.UseVisualStyleBackColor = True
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources._9f996626135ea0506d5e3de41a70e0db
        Me.ClientSize = New System.Drawing.Size(558, 477)
        Me.Controls.Add(Me.PanelMenuFondo)
        Me.Name = "FrmFacturacion"
        Me.Text = "Menu Facturacion"
        Me.PanelMenuFondo.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuFondo As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAdmClientes As System.Windows.Forms.Button
    Friend WithEvents cmdVentas As System.Windows.Forms.Button
    Friend WithEvents cmdAlquiler As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class

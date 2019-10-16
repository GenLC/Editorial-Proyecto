<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PanelMenuFondo = New System.Windows.Forms.Panel()
        Me.cmdAdmSistema = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdmCuentas = New System.Windows.Forms.Button()
        Me.cmdAdmClientes = New System.Windows.Forms.Button()
        Me.cmdAdmLibros = New System.Windows.Forms.Button()
        Me.cmdFacturacion = New System.Windows.Forms.Button()
        Me.PanelMenuFondo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuFondo
        '
        Me.PanelMenuFondo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMenuFondo.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.biblio__1_
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmSistema)
        Me.PanelMenuFondo.Controls.Add(Me.Button5)
        Me.PanelMenuFondo.Controls.Add(Me.PanelMenu)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmCuentas)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmClientes)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmLibros)
        Me.PanelMenuFondo.Controls.Add(Me.cmdFacturacion)
        Me.PanelMenuFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenuFondo.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuFondo.Name = "PanelMenuFondo"
        Me.PanelMenuFondo.Size = New System.Drawing.Size(737, 491)
        Me.PanelMenuFondo.TabIndex = 1
        '
        'cmdAdmSistema
        '
        Me.cmdAdmSistema.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmSistema.Image = Global.Editorial_Proyecto.My.Resources.Resources.escritorio
        Me.cmdAdmSistema.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmSistema.Location = New System.Drawing.Point(453, 99)
        Me.cmdAdmSistema.Name = "cmdAdmSistema"
        Me.cmdAdmSistema.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmSistema.TabIndex = 10
        Me.cmdAdmSistema.Text = "Administrar Sistema"
        Me.cmdAdmSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmSistema.UseVisualStyleBackColor = True
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
        Me.PanelMenu.Size = New System.Drawing.Size(737, 56)
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
        Me.Label1.Size = New System.Drawing.Size(207, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Principal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAdmCuentas
        '
        Me.cmdAdmCuentas.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmCuentas.Image = Global.Editorial_Proyecto.My.Resources.Resources.escritorio
        Me.cmdAdmCuentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmCuentas.Location = New System.Drawing.Point(276, 260)
        Me.cmdAdmCuentas.Name = "cmdAdmCuentas"
        Me.cmdAdmCuentas.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmCuentas.TabIndex = 7
        Me.cmdAdmCuentas.Text = "Administrar Cuentas"
        Me.cmdAdmCuentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmCuentas.UseVisualStyleBackColor = True
        '
        'cmdAdmClientes
        '
        Me.cmdAdmClientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmClientes.Image = Global.Editorial_Proyecto.My.Resources.Resources.usuario
        Me.cmdAdmClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmClientes.Location = New System.Drawing.Point(100, 260)
        Me.cmdAdmClientes.Name = "cmdAdmClientes"
        Me.cmdAdmClientes.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmClientes.TabIndex = 6
        Me.cmdAdmClientes.Text = "Administrar Clientes"
        Me.cmdAdmClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmClientes.UseVisualStyleBackColor = True
        '
        'cmdAdmLibros
        '
        Me.cmdAdmLibros.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmLibros.Image = Global.Editorial_Proyecto.My.Resources.Resources.charla
        Me.cmdAdmLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmLibros.Location = New System.Drawing.Point(276, 99)
        Me.cmdAdmLibros.Name = "cmdAdmLibros"
        Me.cmdAdmLibros.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmLibros.TabIndex = 5
        Me.cmdAdmLibros.Text = "Administrar Libros"
        Me.cmdAdmLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmLibros.UseVisualStyleBackColor = True
        '
        'cmdFacturacion
        '
        Me.cmdFacturacion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFacturacion.Image = Global.Editorial_Proyecto.My.Resources.Resources.recibo_1_
        Me.cmdFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFacturacion.Location = New System.Drawing.Point(100, 99)
        Me.cmdFacturacion.Name = "cmdFacturacion"
        Me.cmdFacturacion.Size = New System.Drawing.Size(152, 124)
        Me.cmdFacturacion.TabIndex = 4
        Me.cmdFacturacion.Text = "Facturacion"
        Me.cmdFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFacturacion.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.biblio__1_
        Me.ClientSize = New System.Drawing.Size(737, 491)
        Me.Controls.Add(Me.PanelMenuFondo)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIBLIOTECA"
        Me.PanelMenuFondo.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuFondo As System.Windows.Forms.Panel
    Friend WithEvents cmdAdmCuentas As System.Windows.Forms.Button
    Friend WithEvents cmdAdmClientes As System.Windows.Forms.Button
    Friend WithEvents cmdAdmLibros As System.Windows.Forms.Button
    Friend WithEvents cmdFacturacion As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAdmSistema As System.Windows.Forms.Button
End Class

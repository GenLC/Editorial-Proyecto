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
        Me.PanelDer = New System.Windows.Forms.Panel()
        Me.PanelIzq = New System.Windows.Forms.Panel()
        Me.cmdAdmSistema = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdmStock = New System.Windows.Forms.Button()
        Me.cmdAdmClientes = New System.Windows.Forms.Button()
        Me.cmdFacturacion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelMenuFondo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuFondo
        '
        Me.PanelMenuFondo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMenuFondo.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuFondo.Controls.Add(Me.Button1)
        Me.PanelMenuFondo.Controls.Add(Me.PanelDer)
        Me.PanelMenuFondo.Controls.Add(Me.PanelIzq)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmSistema)
        Me.PanelMenuFondo.Controls.Add(Me.PanelMenu)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmStock)
        Me.PanelMenuFondo.Controls.Add(Me.cmdAdmClientes)
        Me.PanelMenuFondo.Controls.Add(Me.cmdFacturacion)
        Me.PanelMenuFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenuFondo.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuFondo.Name = "PanelMenuFondo"
        Me.PanelMenuFondo.Size = New System.Drawing.Size(1012, 515)
        Me.PanelMenuFondo.TabIndex = 1
        '
        'PanelDer
        '
        Me.PanelDer.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDer.Location = New System.Drawing.Point(812, 50)
        Me.PanelDer.Name = "PanelDer"
        Me.PanelDer.Size = New System.Drawing.Size(200, 465)
        Me.PanelDer.TabIndex = 12
        '
        'PanelIzq
        '
        Me.PanelIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzq.Location = New System.Drawing.Point(0, 50)
        Me.PanelIzq.Name = "PanelIzq"
        Me.PanelIzq.Size = New System.Drawing.Size(200, 465)
        Me.PanelIzq.TabIndex = 11
        '
        'cmdAdmSistema
        '
        Me.cmdAdmSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdmSistema.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmSistema.Image = Global.Editorial_Proyecto.My.Resources.Resources.system
        Me.cmdAdmSistema.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmSistema.Location = New System.Drawing.Point(622, 94)
        Me.cmdAdmSistema.Name = "cmdAdmSistema"
        Me.cmdAdmSistema.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmSistema.TabIndex = 10
        Me.cmdAdmSistema.Text = "Administrar Sistema"
        Me.cmdAdmSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmSistema.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1012, 50)
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
        'cmdAdmStock
        '
        Me.cmdAdmStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdmStock.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmStock.Image = Global.Editorial_Proyecto.My.Resources.Resources.safebox
        Me.cmdAdmStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmStock.Location = New System.Drawing.Point(622, 285)
        Me.cmdAdmStock.Name = "cmdAdmStock"
        Me.cmdAdmStock.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmStock.TabIndex = 7
        Me.cmdAdmStock.Text = "Libros"
        Me.cmdAdmStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmStock.UseVisualStyleBackColor = True
        '
        'cmdAdmClientes
        '
        Me.cmdAdmClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdmClientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdmClientes.Image = Global.Editorial_Proyecto.My.Resources.Resources.contacts
        Me.cmdAdmClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAdmClientes.Location = New System.Drawing.Point(248, 285)
        Me.cmdAdmClientes.Name = "cmdAdmClientes"
        Me.cmdAdmClientes.Size = New System.Drawing.Size(152, 124)
        Me.cmdAdmClientes.TabIndex = 6
        Me.cmdAdmClientes.Text = "Administrar Clientes"
        Me.cmdAdmClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdmClientes.UseVisualStyleBackColor = True
        '
        'cmdFacturacion
        '
        Me.cmdFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFacturacion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFacturacion.Image = Global.Editorial_Proyecto.My.Resources.Resources.clientes
        Me.cmdFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFacturacion.Location = New System.Drawing.Point(248, 94)
        Me.cmdFacturacion.Name = "cmdFacturacion"
        Me.cmdFacturacion.Size = New System.Drawing.Size(152, 124)
        Me.cmdFacturacion.TabIndex = 4
        Me.cmdFacturacion.Text = "Facturacion"
        Me.cmdFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFacturacion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(490, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.a6537467ad00a76a7af8948075f9a5e41
        Me.ClientSize = New System.Drawing.Size(1012, 515)
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
    Friend WithEvents cmdAdmStock As System.Windows.Forms.Button
    Friend WithEvents cmdAdmClientes As System.Windows.Forms.Button
    Friend WithEvents cmdFacturacion As System.Windows.Forms.Button
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAdmSistema As System.Windows.Forms.Button
    Friend WithEvents PanelDer As System.Windows.Forms.Panel
    Friend WithEvents PanelIzq As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

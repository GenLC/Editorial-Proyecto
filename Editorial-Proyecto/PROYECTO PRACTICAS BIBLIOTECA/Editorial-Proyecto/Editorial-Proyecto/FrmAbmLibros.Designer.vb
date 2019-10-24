<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbmLibros
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
        Me.cmdArticulosGenero = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdProveedores = New System.Windows.Forms.Button()
        Me.cmdAutores = New System.Windows.Forms.Button()
        Me.cmdArticulos = New System.Windows.Forms.Button()
        Me.cmdArticulosFormato = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.biblio__1_
        Me.Panel1.Controls.Add(Me.cmdArticulosGenero)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cmdProveedores)
        Me.Panel1.Controls.Add(Me.cmdAutores)
        Me.Panel1.Controls.Add(Me.cmdArticulos)
        Me.Panel1.Controls.Add(Me.cmdArticulosFormato)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 496)
        Me.Panel1.TabIndex = 2
        '
        'cmdArticulosGenero
        '
        Me.cmdArticulosGenero.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArticulosGenero.Image = Global.Editorial_Proyecto.My.Resources.Resources.escritorio
        Me.cmdArticulosGenero.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdArticulosGenero.Location = New System.Drawing.Point(453, 99)
        Me.cmdArticulosGenero.Name = "cmdArticulosGenero"
        Me.cmdArticulosGenero.Size = New System.Drawing.Size(152, 124)
        Me.cmdArticulosGenero.TabIndex = 10
        Me.cmdArticulosGenero.Text = "Articulos Genero"
        Me.cmdArticulosGenero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdArticulosGenero.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 56)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administracion de Libros"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdProveedores
        '
        Me.cmdProveedores.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedores.Image = Global.Editorial_Proyecto.My.Resources.Resources.escritorio
        Me.cmdProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdProveedores.Location = New System.Drawing.Point(276, 260)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Size = New System.Drawing.Size(152, 124)
        Me.cmdProveedores.TabIndex = 7
        Me.cmdProveedores.Text = "Proveedores"
        Me.cmdProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProveedores.UseVisualStyleBackColor = True
        '
        'cmdAutores
        '
        Me.cmdAutores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutores.Image = Global.Editorial_Proyecto.My.Resources.Resources.usuario
        Me.cmdAutores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAutores.Location = New System.Drawing.Point(100, 260)
        Me.cmdAutores.Name = "cmdAutores"
        Me.cmdAutores.Size = New System.Drawing.Size(152, 124)
        Me.cmdAutores.TabIndex = 6
        Me.cmdAutores.Text = "Autores"
        Me.cmdAutores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAutores.UseVisualStyleBackColor = True
        '
        'cmdArticulos
        '
        Me.cmdArticulos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArticulos.Image = Global.Editorial_Proyecto.My.Resources.Resources.charla
        Me.cmdArticulos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdArticulos.Location = New System.Drawing.Point(276, 99)
        Me.cmdArticulos.Name = "cmdArticulos"
        Me.cmdArticulos.Size = New System.Drawing.Size(152, 124)
        Me.cmdArticulos.TabIndex = 5
        Me.cmdArticulos.Text = "Articulos"
        Me.cmdArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdArticulos.UseVisualStyleBackColor = True
        '
        'cmdArticulosFormato
        '
        Me.cmdArticulosFormato.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArticulosFormato.Image = Global.Editorial_Proyecto.My.Resources.Resources.recibo_1_
        Me.cmdArticulosFormato.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdArticulosFormato.Location = New System.Drawing.Point(100, 99)
        Me.cmdArticulosFormato.Name = "cmdArticulosFormato"
        Me.cmdArticulosFormato.Size = New System.Drawing.Size(152, 124)
        Me.cmdArticulosFormato.TabIndex = 4
        Me.cmdArticulosFormato.Text = "Articulos Formato"
        Me.cmdArticulosFormato.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdArticulosFormato.UseVisualStyleBackColor = True
        '
        'FrmAdmLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 496)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAdmLibros"
        Me.Text = "FrmAdmLibros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdArticulosGenero As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdProveedores As System.Windows.Forms.Button
    Friend WithEvents cmdAutores As System.Windows.Forms.Button
    Friend WithEvents cmdArticulos As System.Windows.Forms.Button
    Friend WithEvents cmdArticulosFormato As System.Windows.Forms.Button
End Class

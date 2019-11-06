<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuStock
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdModificarStock = New System.Windows.Forms.Button()
        Me.cmdAgregarModificarLibros = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cmdModificarStock)
        Me.Panel1.Controls.Add(Me.cmdAgregarModificarLibros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 365)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Editorial_Proyecto.My.Resources.Resources.izquierda
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(6, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 46)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Volver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 56)
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
        Me.Label1.Size = New System.Drawing.Size(169, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdModificarStock
        '
        Me.cmdModificarStock.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarStock.Image = Global.Editorial_Proyecto.My.Resources.Resources.coupons
        Me.cmdModificarStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdModificarStock.Location = New System.Drawing.Point(285, 130)
        Me.cmdModificarStock.Name = "cmdModificarStock"
        Me.cmdModificarStock.Size = New System.Drawing.Size(152, 124)
        Me.cmdModificarStock.TabIndex = 5
        Me.cmdModificarStock.Text = "Modificar Stock"
        Me.cmdModificarStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModificarStock.UseVisualStyleBackColor = True
        '
        'cmdAgregarModificarLibros
        '
        Me.cmdAgregarModificarLibros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarModificarLibros.Image = Global.Editorial_Proyecto.My.Resources.Resources.budget
        Me.cmdAgregarModificarLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAgregarModificarLibros.Location = New System.Drawing.Point(73, 130)
        Me.cmdAgregarModificarLibros.Name = "cmdAgregarModificarLibros"
        Me.cmdAgregarModificarLibros.Size = New System.Drawing.Size(152, 124)
        Me.cmdAgregarModificarLibros.TabIndex = 4
        Me.cmdAgregarModificarLibros.Text = "Agregar / Modificar Libros"
        Me.cmdAgregarModificarLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAgregarModificarLibros.UseVisualStyleBackColor = True
        '
        'FrmMenuStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Editorial_Proyecto.My.Resources.Resources.a6537467ad00a76a7af8948075f9a5e4
        Me.ClientSize = New System.Drawing.Size(531, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMenuStock"
        Me.Text = "Menu Stock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdModificarStock As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarModificarLibros As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

Public Class FrmAdmLibros

    Private Sub cmdArticulosFormato_Click(sender As System.Object, e As System.EventArgs) Handles cmdArticulosFormato.Click
        Frm_ArticulosFormato.Show()
    End Sub

    Private Sub cmdArticulos_Click(sender As System.Object, e As System.EventArgs) Handles cmdArticulos.Click
        FrmArticulos.Show()
    End Sub

    Private Sub cmdArticulosGenero_Click(sender As System.Object, e As System.EventArgs) Handles cmdArticulosGenero.Click
        FrmArticulosGenero.Show()
    End Sub

    Private Sub cmdAutores_Click(sender As System.Object, e As System.EventArgs) Handles cmdAutores.Click
        FrmAutores.Show()
    End Sub

    Private Sub cmdProveedores_Click(sender As System.Object, e As System.EventArgs) Handles cmdProveedores.Click
        FrmProveedores.Show()

    End Sub
End Class
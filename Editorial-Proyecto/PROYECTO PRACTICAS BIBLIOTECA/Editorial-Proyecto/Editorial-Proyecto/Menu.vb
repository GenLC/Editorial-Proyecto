Public Class Menu

    Private Sub BibliotecaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub EditorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Form1.Show()
    'End Sub

    

    'Private Sub TipoArtFormatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Frm_ArticulosFormato.Show()
    'End Sub

   

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FrmABMClientes.Show()

    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdmStock.Click
        FrmMenuStock.Show()

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdFacturacion.Click
        FrmFacturacion.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdmClientes.Click
        FrmABMClientes.Show()
        'FrmClientes.Show()

    End Sub

    Private Sub cmdAdmSistema_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdmSistema.Click
        FrmMenuAltasBajas.Show()
    End Sub

    
    Private Sub cmdEstadisticas_Click(sender As System.Object, e As System.EventArgs) Handles cmdEstadisticas.Click
        FrmEstadisticas.Show()
    End Sub
End Class
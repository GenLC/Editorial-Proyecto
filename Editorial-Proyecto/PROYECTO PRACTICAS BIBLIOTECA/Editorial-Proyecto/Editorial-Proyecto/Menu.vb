﻿Public Class Menu

    Private Sub BibliotecaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EditorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmProveedores.Show()
    End Sub

    Private Sub TipoArtFormatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_ArticulosFormato.Show()
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmAutores.Show()
    End Sub

    Private Sub ArtGeneroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmArticulosGenero.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FrmClientes.Show()

    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        FrmMenuAltasBajas.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmFacturacion.Show()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        FrmClientes.Show()

    End Sub


    Private Sub Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
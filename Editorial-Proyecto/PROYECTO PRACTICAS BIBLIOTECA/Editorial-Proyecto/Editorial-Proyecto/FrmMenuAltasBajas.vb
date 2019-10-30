Public Class FrmMenuAltasBajas


    

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        Frm_ArticulosFormato.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        FrmArticulosGenero.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        FrmAutores.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        FrmProveedores.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

 

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        FrmABMClientes.Show()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        FrmStock.Show()
    End Sub

    Private Sub cmdStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStock.Click
        FrmStock.Show()
    End Sub
End Class
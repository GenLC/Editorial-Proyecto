Public Class FrmMenuStock

    Private Sub cmdSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdAgregarModificarLibros_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarModificarLibros.Click
        FrmLibros.Show()
    End Sub

    Private Sub cmdModificarStock_Click(sender As System.Object, e As System.EventArgs) Handles cmdModificarStock.Click
        FrmStock.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
Public Class FrmFacturacion

    Private Sub cmdAlquiler_Click(sender As System.Object, e As System.EventArgs) Handles cmdAlquiler.Click
        FrmAlquileres.Show()
    End Sub

    Private Sub cmdVentas_Click(sender As System.Object, e As System.EventArgs) Handles cmdVentas.Click
        FrmVentas.Show()
    End Sub

    Private Sub cmdAdmClientes_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdmClientes.Click
        FrmVentaLibroSeleccion.Show()
    End Sub
End Class
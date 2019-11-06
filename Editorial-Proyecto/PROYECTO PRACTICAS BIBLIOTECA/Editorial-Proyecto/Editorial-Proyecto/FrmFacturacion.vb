Public Class FrmFacturacion

    Private Sub cmdAlquiler_Click(sender As System.Object, e As System.EventArgs) Handles cmdAlquiler.Click
        MsgBox("En desarrollo", MsgBoxStyle.Critical, "Estamos trabajando")
        'FrmAlquileres.Show()
    End Sub

    Private Sub cmdVentas_Click(sender As System.Object, e As System.EventArgs) Handles cmdVentas.Click
        FrmVentas.Show()
    End Sub

    Private Sub cmdAdmClientes_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdmClientes.Click
        FrmFacturas.Show()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MsgBox("En desarrollo", MsgBoxStyle.Critical, "Estamos trabajando")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
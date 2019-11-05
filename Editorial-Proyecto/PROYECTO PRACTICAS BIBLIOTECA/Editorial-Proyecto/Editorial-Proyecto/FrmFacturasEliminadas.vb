Imports EDITORIAL.AD
Public Class FrmFacturasEliminadas

    Private Sub FrmFacturasEliminadas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarFacturasEliminadas()
    End Sub

    Private Sub CargarFacturasEliminadas()

        Dim ods As New Data.DataSet
        Dim oFacturas As New C_Facturas

        ods = oFacturas.CargarFacturasEliminadas

        grlFacturasEliminadas.DataSource = ods.Tables(0)

        'grlFacturasEliminadas.Columns(0).HeaderText = "Cod. Cliente"
        'grlFacturas.Columns(0).Width = 5

        'grlFacturas.Columns(6).HeaderText = "Nro Factura"
        'grlFacturas.Columns(6).Width = 5
        'grlFacturas.Columns(0).Width = 100


        grlFacturasEliminadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


    Private Sub RestaurarFactura(NroFactura As Integer)


        Dim oFacturas As New C_Facturas

        oFacturas.RestaurarFactura(NroFactura)


        grlFacturasEliminadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub cmdRestaurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestaurar.Click

        RestaurarFactura(grlFacturasEliminadas.CurrentRow.Cells(0).Value)

        CargarFacturasEliminadas()

        MsgBox("Restauracion con exito", vbInformation, "Exito")

    End Sub

    Private Sub cmdSalir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
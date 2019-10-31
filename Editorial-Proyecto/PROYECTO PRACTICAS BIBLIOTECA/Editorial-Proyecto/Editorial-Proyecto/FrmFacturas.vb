Imports EDITORIAL.AD

Public Class FrmFacturas


#Region "Funciones"


    'doble click en factura seleccionada no trae factura detalle

    'CARGAR GRILLA
    Private Sub CargarGrillaLibros()

        Dim ods As New Data.DataSet
        Dim oFacturas As New C_Facturas

        ods = oFacturas.CargarGrillaFacturas

        grlFacturas.DataSource = ods.Tables(0)

        grlFacturas.Columns(0).HeaderText = "Cod. Cliente"
        grlFacturas.Columns(0).Width = 5

        grlFacturas.Columns(6).HeaderText = "Nro Factura"
        grlFacturas.Columns(6).Width = 5
        grlFacturas.Columns(0).Width = 100


        grlFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    'BUSCADOR

    Private Sub BuscadorFacturasGrillaNombre(ByVal NombreCliente As String)


        Dim oDs As New DataSet
        Dim oFacturas As New C_Facturas

        oDs = oFacturas.BuscadorFacturasGrillaNombre(NombreCliente)

        grlFacturas.Columns(0).HeaderText = "Cod. Cliente"
        grlFacturas.Columns(0).Width = 5
        grlFacturas.Columns(6).HeaderText = "Nro Factura"
        grlFacturas.Columns(6).Width = 5
        grlFacturas.Columns(0).Width = 100


        grlFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oFacturas = Nothing

    End Sub




    Private Sub BuscadorFacturasGrillaNroFactura(ByVal NroFactura As String)


        Dim oDs As New DataSet
        Dim oFacturas As New C_Facturas

        oDs = oFacturas.BuscadorFacturasGrillaNroFactura(NroFactura)

        grlFacturas.DataSource = oDs.Tables(0)
        grlFacturas.Columns(0).HeaderText = "Cod. Cliente"
        grlFacturas.Columns(0).Width = 5

        grlFacturas.Columns(6).HeaderText = "Nro Factura"
        grlFacturas.Columns(6).Width = 5
        grlFacturas.Columns(0).Width = 100

        grlFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oFacturas = Nothing

    End Sub


    Private Sub BuscadorFacturasGrillaMontoMenor(ByVal Monto As Double)


        Dim oDs As New DataSet
        Dim oFacturas As New C_Facturas

        oDs = oFacturas.BuscadorFacturasGrillaMontoMenor(Monto)

        grlFacturas.DataSource = oDs.Tables(0)

        grlFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oFacturas = Nothing
    End Sub

    Private Sub CargarFacturaDetalle(ByVal IdCliente As Double)


        Dim oDs As New DataSet
        Dim oFacturas As New C_Facturas

        oDs = oFacturas.CargarFacturaDetalle(IdCliente)

        grlFacturaDetalle.DataSource = oDs.Tables(0)

        grlFacturaDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oFacturas = Nothing

    End Sub




    Private Sub Limpiar()

        rbtNombreCliente.Checked = True
        CargarGrillaLibros()
        grlFacturaDetalle.Rows.Clear()
        grlFacturaDetalle.Columns.Clear()
        txtBuscador.Text = "BUSCADOR"
    End Sub

#End Region

    Dim IdClienteSeleccionado As Integer


    Private Sub FrmFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()

    End Sub




    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click

        Limpiar()

    End Sub

    Private Sub txtBuscador_Click1(sender As Object, e As System.EventArgs) Handles txtBuscador.Click
        txtBuscador.Text = ""
    End Sub

    Private Sub txtBuscador_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscador.KeyUp
        If txtBuscador.Text <> "" Then

            If rbtNombreCliente.Checked = True Then
                BuscadorFacturasGrillaNombre(txtBuscador.Text)
            End If
            If rbtNroFactura.Checked = True Then
                BuscadorFacturasGrillaNroFactura(CInt(txtBuscador.Text))
            End If
            If rbtMontoMenor.Checked = True Then
                BuscadorFacturasGrillaMontoMenor(CDbl(txtBuscador.Text))
            End If

        End If
    End Sub




    Private Sub grlFacturas_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlFacturas.CellDoubleClick
        IdClienteSeleccionado = grlFacturas.CurrentRow.Cells(0).Value


        CargarFacturaDetalle(IdClienteSeleccionado)

    End Sub
End Class
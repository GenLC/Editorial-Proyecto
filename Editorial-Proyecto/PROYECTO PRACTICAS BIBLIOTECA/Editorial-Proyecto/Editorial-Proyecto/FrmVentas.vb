
Imports EDITORIAL.AD

Public Class FrmVentas





    Public Sub FrmVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eFacturacion

    End Sub

    Private eEstado As EstadodelFormulario


    Public Enum EstadodelFormulario
        eFacturacion = 1
        eSeleccionarCliente = 2
        eSeleccionarLibros = 3
    End Enum



#Region "Propiedades"

    Dim ClienteSeleccionado As String
    Dim TipoFactura As String
    Dim PuntoVenta As Integer
    Dim CompNum As Integer
    Dim LibroSeleccionado As String
    Dim PrecioLibro As Double
    Dim TotalPrecio As Double


    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)

            'Actualizar estados

            Select Case vNewValue

                Case EstadodelFormulario.eFacturacion

                   



                    'DesactivarClientes()



                    'DesactivarResumen()
                    'ActivarFacturas()

                    LimpiarFactura()
                    'cmdCargarFactura.Enabled = True
                    'cmdLimpiarFactura.Enabled = True
                    'cmdCacelarCliente.Enabled = False


                Case EstadodelFormulario.eSeleccionarCliente

                    'DesactivarFacturas()
                    'ActivarClientes()

                    'DesactivarResumen()
                    'CargarGrillaClientes()

                    'cmdCacelarCliente.Enabled = True

                Case EstadodelFormulario.eSeleccionarLibros


                    DesactivarFacturas()
                    ' DesactivarClientes()


                    cmdCacelarCliente.Enabled = False

            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region



#Region "Funciones"
    'ACTIVO

    Private Sub ActivarFacturas()
        grpFactura.Enabled = True
    End Sub

    Private Sub ActivarClientes()
        grpCliente.Enabled = True
        cmdAgregarCliente.Enabled = True
    End Sub

    'Private Sub ActivarLibros()
    '    grpLibros.Enabled = True
    '    cmdAgregarLibro.Enabled = True
    'End Sub

    Private Sub ActivarResumen()
        grlResumenVenta.Enabled = True
        PanelResumen.Enabled = True
    End Sub



    'DESCACTIVO
    Private Sub DesactivarFacturas()
        grpFactura.Enabled = False
    End Sub

    Private Sub DesactivarClientes()
        grpCliente.Enabled = False
        cmdAgregarCliente.Enabled = False
    End Sub

    'Private Sub DesactivarLibros()
    '    grpLibros.Enabled = False
    '    cmdAgregarLibro.Enabled = False
    'End Sub

    Private Sub DesactivarResumen()
        grlResumenVenta.Enabled = False
        PanelResumen.Enabled = False
    End Sub

   

    'GRILLAS

    Private Sub CargarGrillaClientes()

        Dim ods As New Data.DataSet
        Dim oClientes As New C_Clientes

        ods = oClientes.CargarGrillaClientes

        grlClientes.DataSource = ods.Tables(0)


        grlClientes.Columns(0).HeaderText = "Cod."
        grlClientes.Columns(0).Width = 20

        grlClientes.Columns(1).HeaderText = "Nombre"
        grlClientes.Columns(1).Width = 100

        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub



    Private Sub LimpiarFactura()

        'ver luego como renumero
        cboTipoFactura.SelectedIndex = 2
        txtPuntoVenta.Text = "0001"
        txtCompNum.Text = "0001"

        txtTotalPrecio.Text = "0.00"
      

    End Sub

    Private Sub BuscadorClienteGrilla(ByVal Nombre As String)


        Dim oDs As New DataSet
        Dim oClientes As New C_Clientes

        oDs = oClientes.BuscadorCliente(Nombre)

        grlClientes.DataSource = oDs.Tables(0)



        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oClientes = Nothing

    End Sub

   


#End Region


  

   
#Region "Grp Factura"
    Private Sub cmdCargarFactura_Click(sender As System.Object, e As System.EventArgs) Handles cmdCargarFactura.Click

        TipoFactura = cboTipoFactura.Text
        PuntoVenta = txtPuntoVenta.Text
        CompNum = txtCompNum.Text
        cmdCargarFactura.Enabled = False
        cmdLimpiarFactura.Enabled = False

        Me.Estado = EstadodelFormulario.eSeleccionarCliente

    End Sub

    Private Sub cmdLimpiarFactura_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiarFactura.Click

        LimpiarFactura()

    End Sub


    
#End Region

    
   
#Region "grp Cliente"

    Private Sub cmdAgregarCliente_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarCliente.Click

        FrmABMClientes.Show()
        CargarGrillaClientes()

    End Sub

    Private Sub cmdCacelarCliente_Click(sender As System.Object, e As System.EventArgs) Handles cmdCacelarCliente.Click

        Me.Estado = EstadodelFormulario.eFacturacion


    End Sub

  


    Private Sub txtBuscardor_Click(sender As Object, e As System.EventArgs) Handles txtBuscador.Click
        txtBuscador.Text = ""
        CargarGrillaClientes()

    End Sub

    Private Sub txtBuscardor_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscador.KeyUp

        If txtBuscador.Text <> Nothing Then
            BuscadorClienteGrilla(txtBuscador.Text)
        End If
    End Sub

    Private Sub grlClientes_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlClientes.CellDoubleClick

        'IdCliente
        SeleccionClienteId = grlClientes.CurrentRow.Cells(0).Value

        'Nombre
        SeleccionClienteNombre = grlClientes.CurrentRow.Cells(1).Value

        lblClienteSeleccionado.Text = SeleccionClienteNombre

        Me.Estado = EstadodelFormulario.eSeleccionarLibros

    End Sub

#End Region


    
    
   

    

#Region "Finalzar"

    Private Sub cmdFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFinalizar.Click

        Dim oFactura As New C_Ventas
        Dim res As Integer
        Dim oFacturaDetalle As New C_Ventas


        res = oFactura.CargarFacturaVenta(cboTipoFactura.SelectedItem, txtPuntoVenta.Text, txtCompNum.Text, SeleccionClienteId, CDbl(txtTotalPrecio.Text), dtFecha.Value, chkEstadoFactura.Checked)

        For i = 0 To grlResumenVenta.RowCount - 2
            oFacturaDetalle.CargarFacturaVentaDetalle(res, CDbl(grlResumenVenta.Rows(i).Cells(0).Value), CDbl(grlResumenVenta.Rows(i).Cells(3).Value), CDbl(grlResumenVenta.Rows(i).Cells(2).Value), CDbl(txtTotalPrecio.Text))
        Next

        MsgBox("todo oka")

    End Sub

#End Region




#Region "Boton Seleccionar venta Libro"




    Private Sub txtCantidadLibros_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)

        TotalPrecio = PrecioLibro + TotalPrecio

        txtTotalPrecio.Text = TotalPrecio

    End Sub





    Private Sub cmdSeleccionarLibro_Click(sender As System.Object, e As System.EventArgs) Handles cmdSeleccionarLibro.Click

        FrmVentaLibroSeleccion.ShowDialog()
        calculartotales()

    End Sub


    Private Sub calculartotales()

        txtTotalPrecio.Text = "0.00"


        For i = 0 To grlResumenVenta.Rows.Count - 1


            txtTotalPrecio.Text = CDbl(txtTotalPrecio.Text) + CDbl(grlResumenVenta.Rows(i).Cells(4).Value)

        Next

        txtTotalPrecio.Text = FormatNumber(txtTotalPrecio.Text, 2)

    End Sub

#End Region





End Class
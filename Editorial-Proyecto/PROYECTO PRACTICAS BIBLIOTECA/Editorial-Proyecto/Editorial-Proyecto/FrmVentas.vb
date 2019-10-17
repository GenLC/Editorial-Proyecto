
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


    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)


            Select Case vNewValue

                Case EstadodelFormulario.eFacturacion

                    DesactivarClientes()
                    DesactivarLibros()
                    DesactivarResumen()
                    ActivarFacturas()

                    LimpiarFactura()
                    cmdCargarFactura.Enabled = True
                    cmdLimpiarFactura.Enabled = True
                    cmdCacelarCliente.Enabled = False


                Case EstadodelFormulario.eSeleccionarCliente

                    DesactivarFacturas()
                    ActivarClientes()
                    DesactivarLibros()
                    DesactivarResumen()
                    CargarGrillaClientes()

                    cmdCacelarCliente.Enabled = True

                Case EstadodelFormulario.eSeleccionarLibros

                    ActivarLibros()
                    DesactivarFacturas()
                    DesactivarClientes()
                    CargarGrillaLibros()

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

    Private Sub ActivarLibros()
        grpLibros.Enabled = True
        cmdAgregarLibro.Enabled = True
    End Sub

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

    Private Sub DesactivarLibros()
        grpLibros.Enabled = False
        cmdAgregarLibro.Enabled = False
    End Sub

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


    Private Sub CargarGrillaLibros()

        Dim ods As New Data.DataSet
        Dim oClientes As New C_Ventas

        ods = oClientes.CargarGrillaLibros

        grlLibros.DataSource = ods.Tables(0)


        'grlClientes.Columns(0).HeaderText = "Cod."
        'grlClientes.Columns(0).Width = 20

        'grlClientes.Columns(1).HeaderText = "Nombre"
        'grlClientes.Columns(1).Width = 100

        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


    Private Sub LimpiarFactura()

        cboTipoFactura.SelectedItem = 2
        txtCompNum.Text = Nothing
        txtPuntoVenta.Text = Nothing


    End Sub

    Private Sub BuscadorClienteGrilla(ByVal Nombre As String)


        Dim oDs As New DataSet
        Dim oClientes As New C_Clientes

        oDs = oClientes.BuscadorCliente(Nombre)

        grlClientes.DataSource = oDs.Tables(0)


        'grlClientes.Columns(0).HeaderText = "Cod."
        'grlClientes.Columns(0).Width = 20

        'grlClientes.Columns(1).HeaderText = "Nombre"
        'grlClientes.Columns(1).Width = 100

        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oClientes = Nothing

    End Sub

    Private Sub BuscadorLibrosGrilla(ByVal Nombre As String)


        Dim oDs As New DataSet
        Dim oLibro As New C_Ventas

        oDs = oLibro.BuscadorLibros(Nombre)

        grlLibros.DataSource = oDs.Tables(0)


        'grlClientes.Columns(0).HeaderText = "Cod."
        'grlClientes.Columns(0).Width = 20

        'grlClientes.Columns(1).HeaderText = "Nombre"
        'grlClientes.Columns(1).Width = 100

        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oLibro = Nothing

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

    Private Sub grlClientes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlClientes.CellContentClick

        ClienteSeleccionado = grlClientes.CurrentRow.Cells(0).Value

        lblClienteSeleccionado.Text = grlClientes.CurrentRow.Cells(1).Value

        Me.Estado = EstadodelFormulario.eSeleccionarLibros

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

#End Region


#Region "grp Libros"

    Private Sub cmdCancelarLibro_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelarLibro.Click

        Me.Estado = EstadodelFormulario.eSeleccionarCliente

    End Sub


    Private Sub txtBuscadoLibros_Click(sender As Object, e As System.EventArgs) Handles txtBuscadoLibros.Click
        txtBuscadoLibros.Text = ""
        CargarGrillaLibros()

    End Sub

    Private Sub txtBuscadoLibros_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscadoLibros.KeyUp
        If txtBuscadoLibros.Text <> Nothing Then
            BuscadorLibrosGrilla(txtBuscadoLibros.Text)
        End If
    End Sub

    Private Sub grlLibros_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlLibros.CellContentClick
        LibroSeleccionado = Nothing
        PrecioLibro = Nothing
        LibroSeleccionado = grlLibros.CurrentRow.Cells(0).Value
        'NroVenta = NroVenta.Text

        'PrecioLibro = grlLibros.CurrentRow.Cells(0).Value


        Dim oObjeto As New C_Ventas

        oObjeto.CargarDetalleVenta(ClienteSeleccionado, LibroSeleccionado, "1", "9999")

    End Sub
 
#End Region

    
    
   

    

    
    
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles cmdFinalizar.Click

    End Sub
End Class
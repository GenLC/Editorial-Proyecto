
Imports EDITORIAL.AD

Public Class FrmVentas


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmABMClientes.Show()
    End Sub



    Private Sub FrmVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eFacturacion
       
    End Sub

    Private eEstado As EstadodelFormulario


    Public Enum EstadodelFormulario
        eFacturacion = 1
        eAgregar = 2
        eModificar = 3
    End Enum



#Region "Propiedades"
    Dim ClienteSeleccionado As String

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


                Case EstadodelFormulario.eAgregar

                    'HabililarTXT()

                    'DeshabilitarGrillas()

                    'txtIdCliente.Enabled = False

                    'chkEstadoCliente.Checked = True



                    'cmdAgregar.Enabled = False
                    'cmdModif.Enabled = False
                    'cmdCancelar.Enabled = True
                    'cmdLimpiar.Enabled = True
                    'cmdAceptar.Enabled = True

                    'grlClientes.Enabled = False

                    'txtNombreApellido.Focus()
                    'Panel1.BackColor = Color.LightGreen
                    'lblAccion.Text = "Agregando, Calcule el precio de las cuotas antes de agregar"
                    'lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    'If txtIdCliente.Text <> Nothing Then

                    '    HabililarTXT()
                    '    HabililarComandos()
                    '    DeshabilitarGrillas()

                    '    txtIdCliente.Enabled = False


                    '    grbCuotas.Enabled = True


                    '    cmdLimpiar.Enabled = True
                    '    cmdCancelar.Enabled = True
                    '    cmdAgregar.Enabled = False
                    '    cmdModif.Enabled = False

                    '    grlClientes.Enabled = False

                    '    Panel1.BackColor = Color.LightSalmon
                    '    lblAccion.Text = "Modificando"
                    '    'lblAccion.ForeColor = Color.Black
                    'Else
                    MsgBox("ERROR CRITICO", MsgBoxStyle.Critical, "Error")
                    'End If
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
    End Sub

    Private Sub ActivarLibros()
        grpLibros.Enabled = True
    End Sub

    Private Sub ActivarResumen()
        grlResumenVenta.Enabled = True
    End Sub

  

    'DESCACTIVO
    Private Sub DesactivarFacturas()
        grpFactura.Enabled = False
    End Sub

    Private Sub DesactivarClientes()
        grpCliente.Enabled = False
    End Sub

    Private Sub DesactivarLibros()
        grpLibros.Enabled = False
    End Sub

    Private Sub DesactivarResumen()
        grlResumenVenta.Enabled = False
    End Sub

   

    'GRILLA

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
   

#End Region


    Private Sub grlClientes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlClientes.CellContentClick
        ClienteSeleccionado = grlClientes.CurrentRow.Cells(0).Value

        lblClienteSeleccionado.Text = grlClientes.CurrentRow.Cells(1).Value

    End Sub

   
End Class


Imports EDITORIAL.AD

Public Class frmClientes

    Private eEstado As EstadodelFormulario


    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eModificar = 3
    End Enum



#Region "Propiedades"


    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)


            Select Case vNewValue

                Case EstadodelFormulario.eConsulta

                    Limpiar()

                    DesHabililarTXT()

                    DesHabililarComandos()

                    DeshabilitarGrillas()

                    grlClientes.Enabled = True

                    cmdAgregar.Enabled = True

                    Panel1.BackColor = Color.LightBlue
                    lblAccion.Text = "Consultando"

                Case EstadodelFormulario.eAgregar

                    HabililarTXT()

                    DeshabilitarGrillas()

                    txtIdCliente.Enabled = False

                    chkEstadoCliente.Checked = True



                    cmdAgregar.Enabled = False
                    cmdModif.Enabled = False
                    cmdCancelar.Enabled = True
                    cmdLimpiar.Enabled = True
                    cmdAceptar.Enabled = True

                    grlClientes.Enabled = False

                    txtNombreApellido.Focus()
                    Panel1.BackColor = Color.LightGreen
                    lblAccion.Text = "Agregando, Calcule el precio de las cuotas antes de agregar"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txtIdCliente.Text <> Nothing Then

                        HabililarTXT()
                        HabililarComandos()
                        DeshabilitarGrillas()

                        txtIdCliente.Enabled = False


                        grbCuotas.Enabled = True


                        cmdLimpiar.Enabled = True
                        cmdCancelar.Enabled = True
                        cmdAgregar.Enabled = False
                        cmdModif.Enabled = False

                        grlClientes.Enabled = False

                        Panel1.BackColor = Color.LightSalmon
                        lblAccion.Text = "Modificando"
                        'lblAccion.ForeColor = Color.Black
                    Else
                        MsgBox("Seleccione algun Cliente", MsgBoxStyle.Critical, "Error")
                    End If
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "funciones"
    Private Sub Limpiar()

        CargarGrilla()

        txtNombreApellido.Text = ""
        txtDNI.Text = ""
        txtTelMovil.Text = ""
        txtMail.Text = ""
        txtIdCliente.Text = ""
        chkEstadoCliente.Checked = False

    End Sub
    Private Sub HabilitarGrillas()

        grlEstadosCuentaClientes.Enabled = True
        grlLibrosClientes.Enabled = True
        grlClientes.Enabled = True

    End Sub
    Private Sub DeshabilitarGrillas()

        grlEstadosCuentaClientes.Enabled = False
        grlLibrosClientes.Enabled = False
        grlClientes.Enabled = False
    End Sub
    Private Sub HabililarTXT()

        txtNombreApellido.Enabled = True
        txtDNI.Enabled = True
        txtTelMovil.Enabled = True
        txtMail.Enabled = True
        txtIdCliente.Enabled = True
        chkEstadoCliente.Enabled = True


    End Sub

    Private Sub DesHabililarTXT()
        txtNombreApellido.Enabled = False
        txtDNI.Enabled = False
        txtTelMovil.Enabled = False
        txtMail.Enabled = False
        txtIdCliente.Enabled = False
        chkEstadoCliente.Enabled = False
    End Sub

    Private Sub HabililarComandos()

        cmdAgregar.Enabled = True
        cmdModif.Enabled = True
        cmdLimpiar.Enabled = True
        cmdAceptar.Enabled = True
        cmdCancelar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()
        cmdAgregar.Enabled = False
        cmdModif.Enabled = False
        cmdLimpiar.Enabled = False
        cmdAceptar.Enabled = False
        cmdCancelar.Enabled = False

    End Sub


    Private Sub CargarGrilla()

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




    Private Function Validar() As Boolean

        If txtNombreApellido.Text = "" Or txtDNI.Text = "" Or txtMail.Text = "" Or txtTelMovil.Text = "" Then

            MsgBox("Complete todos los datos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region



#Region "Botones"
    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        If Validar() = True Then

            If Validar() = True Then


                Dim oCliente As New C_Clientes

                'PASAR TODO A MAYUSCULA

                If Me.Estado = EstadodelFormulario.eModificar Then
                    oCliente.ModificarCliente(txtIdCliente.Text, txtNombreApellido.Text, txtDNI.Text, txtTelMovil.Text, txtMail.Text, chkEstadoCliente.Checked)
                    MsgBox("Se modificó correctamente el Cliente con el código Nro: " + txtIdCliente.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    oCliente.AgregarCliente(txtNombreApellido.Text, txtDNI.Text, txtTelMovil.Text, txtMail.Text, chkEstadoCliente.Checked)
                    MsgBox("Se agregó correctamente el Cliente " + txtNombreApellido.Text.ToUpper + " con un nuevo código ", MsgBoxStyle.Information, "Exitos!")


                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If


        End If


    End Sub

    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click

        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmdAgregar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub


    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        If Me.eEstado = EstadodelFormulario.eModificar Then

            If MsgBox("Esta seguro de Salir?" & vbCrLf & _
             "*******************", _
             vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
                Me.Close()
            Else

            End If
        ElseIf Me.eEstado = EstadodelFormulario.eConsulta Then
            If MsgBox("Esta seguro de Salir?" & vbCrLf & _
            "---------------------", _
            vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
                Me.Close()
            Else

            End If
        End If


    End Sub
#End Region


#Region "Grilla"


    Private Sub grlClientes_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlClientes.CellContentDoubleClick
        Me.eEstado = EstadodelFormulario.eModificar

        BuscarCliente(grlClientes.CurrentRow.Cells(0).Value)

        cmdAgregar.Enabled = False
        cmdModif.Enabled = True
    End Sub

    Private Sub BuscarCliente(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oClientes As New C_Clientes

        oDs = oClientes.BuscarCliente(ID)

        'grlClientes.DataSource = oDs.Tables(0)


        txtIdCliente.Text = oDs.Tables(0).Rows(0).Item("IdCliente")
        txtNombreApellido.Text = oDs.Tables(0).Rows(0).Item("NombreFantasia")
        txtDNI.Text = oDs.Tables(0).Rows(0).Item("DNI")
        txtTelMovil.Text = oDs.Tables(0).Rows(0).Item("Movil")
        txtMail.Text = oDs.Tables(0).Rows(0).Item("Mail")
        chkEstadoCliente.Checked = oDs.Tables(0).Rows(0).Item("Estado")

        grlClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        oDs = Nothing
        oClientes = Nothing

    End Sub
#End Region



    Private Sub frmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Me.Estado = EstadodelFormulario.eConsulta


    End Sub

    Private Sub cmdModif_Click(sender As System.Object, e As System.EventArgs) Handles cmdModif.Click
        Me.Estado = EstadodelFormulario.eModificar
    End Sub






    Private Sub cmdLimpiarDatos_Click(sender As System.Object, e As System.EventArgs)

        Limpiar()

        cmdAceptar.Enabled = False

        lblAccion.Text = "Modificando, Calcue el valor de las cuotas"

    End Sub

#Region "Buscador"

    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscardor.TextChanged

        BuscadorClienteGrilla(txtBuscardor.Text)


    End Sub

    Private Sub BuscadorClienteGrilla(ByVal Nombre As Integer)


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


#End Region
End Class
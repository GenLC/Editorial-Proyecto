Imports EDITORIAL.AD
Public Class FrmProveedores




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


            Select Case vNewValue 'que es?

                Case EstadodelFormulario.eConsulta

                    Limpiar()
                    DesHabililarTXT()
                    DesHabililarComandos()
                    cmd_Modificar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    grl_GrillaProveedores.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                    Panel2.BackColor = Color.Purple
                    lbl_Estado.Text = "Consultando"


                Case EstadodelFormulario.eAgregar

                    HabililarTXT()
                    txt_IDProveedor.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False

                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_GrillaProveedores.Enabled = False

                    txt_NombreCompañia.Focus()
                    txt_NombreContacto.Focus()
                    txt_NombreFantasia.Focus()
                    txt_NroCuit.Focus()
                    txt_NroContacto.Focus()
                    Panel2.BackColor = Color.Red
                    lbl_Estado.Text = "Agregando"
                    lbl_Estado.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txt_IDProveedor.Text <> Nothing Then
                        HabililarTXT()
                        txt_IDProveedor.Enabled = False
                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False

                        cmd_Limpiar.Enabled = True
                        grl_GrillaProveedores.Enabled = False
                        cmd_Aceptar.Enabled = True
                        cmd_Cancelar.Enabled = True

                        Panel2.BackColor = Color.Green
                        lbl_Estado.Text = "Modificando"
                        lbl_Estado.ForeColor = Color.Black
                    Else
                        MsgBox("Seleccione algun autor", MsgBoxStyle.Critical, "Error")
                    End If
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "funciones"
    Private Sub Limpiar()
        CargarGrilla()
        txt_IDProveedor.Text = "ID Proveedor"
        txt_NombreCompañia.Text = "Nombre Compañia"
        txt_NombreContacto.Text = "Nombre Contacto"
        txt_NombreFantasia.Text = "Nombre Fantasia"
        txt_NroContacto.Text = "Numero Contacto"
        txt_NroCuit.Text = "Numero Cuit"

    End Sub

    Private Sub HabililarTXT()

        txt_IDProveedor.Enabled = True
        txt_NombreCompañia.Enabled = True
        txt_NombreContacto.Enabled = True
        txt_NombreFantasia.Enabled = True
        txt_NroContacto.Enabled = True
        txt_NroCuit.Enabled = True


    End Sub

    Private Sub DesHabililarTXT()

        txt_IDProveedor.Enabled = False
        txt_NombreCompañia.Enabled = False
        txt_NombreContacto.Enabled = False
        txt_NombreFantasia.Enabled = False
        txt_NroContacto.Enabled = False
        txt_NroCuit.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        cmd_Agregar.Enabled = True
        cmd_Modificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        cmd_Agregar.Enabled = False
        cmd_Modificar.Enabled = False


    End Sub

    Private Sub CargarGrilla()

        Dim ods As New Data.DataSet
        Dim objProveedores As New C_Proveedores

        ods = objProveedores.CargarGrilla
        grl_GrillaProveedores.DataSource = ods.Tables(0)
        'grl_GrillaProveedores.DataBindings(0)

        grl_GrillaProveedores.Columns(0).HeaderText = "Cod."
        grl_GrillaProveedores.Columns(0).Width = 30
    End Sub
#End Region

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If MsgBox("Esta seguro de Salir?" & vbCrLf & _
                "Se perderán las ultimas modificaciones", _
                vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub cmd_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Aceptar.Click
        Try

            If Validar() = True Then


                Dim objProveedores As New C_Proveedores


                If Me.Estado = EstadodelFormulario.eModificar Then
                    objProveedores.ModificarProveedores(txt_IDProveedor.Text, txt_NombreCompañia.Text, txt_NombreFantasia.Text, txt_NombreContacto.Text, txt_NroCuit.Text, txt_NroContacto.Text) ', ChkActivo.Checked
                    MsgBox("Se modificó correctamente datos del Proveedor el código Nro: " + txt_IDProveedor.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = objProveedores.CargarProveedores(txt_NombreCompañia.Text, txt_NombreFantasia.Text, txt_NombreContacto.Text, txt_NroCuit.Text, txt_NroContacto.Text) ', ChkActivo.Checked
                    MsgBox("Se agregó correctamente los datos del Proveedor " + txt_NombreCompañia.Text + txt_NombreFantasia.Text + txt_NombreContacto.Text + txt_NroCuit.Text + txt_NroContacto.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_NombreCompañia.Text = "" And txt_NombreContacto.Text = "" And txt_NombreFantasia.Text = "" And txt_NroCuit.Text = "" And txt_NroContacto.Text = "" Then

            MsgBox("Complete Campos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region



#Region "Formulario"

    Private Sub FrmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub



    Private Sub FrmProveedores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F3 And cmd_Agregar.Enabled = True Then ' agregar
            Me.Estado = EstadodelFormulario.eAgregar
        End If

        If e.KeyCode = Keys.F4 And cmd_Modificar.Enabled = True Then ' modificar
            Me.Estado = EstadodelFormulario.eModificar
        End If


        If e.KeyCode = Keys.F5 And cmd_Limpiar.Enabled = True Then ' limpiar
            Me.Estado = EstadodelFormulario.eConsulta
        End If


    End Sub

    Private Sub FrmProveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub


#End Region

    Private Sub cmd_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click
        Limpiar()

        Me.Estado = EstadodelFormulario.eAgregar
    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        Me.Estado = EstadodelFormulario.eModificar
    End Sub

    
    Private Sub grl_GrillaProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_GrillaProveedores.CellContentClick
        BuscarPorID(grl_GrillaProveedores.CurrentRow.Cells(0).Value)
        cmd_Agregar.Enabled = False
    End Sub

    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim objProveedor As New C_Proveedores

        oDs = objProveedor.BuscarID(ID)

        txt_IDProveedor.Text = oDs.Tables(0).Rows(0).Item("IdProveedores")
        txt_NombreCompañia.Text = oDs.Tables(0).Rows(0).Item("NombreCompañia")
        txt_NombreFantasia.Text = oDs.Tables(0).Rows(0).Item("NombreFantasia")
        txt_NombreContacto.Text = oDs.Tables(0).Rows(0).Item("NombreContacto")
        txt_NroCuit.Text = oDs.Tables(0).Rows(0).Item("NroCuit")
        txt_NroContacto.Text = oDs.Tables(0).Rows(0).Item("NroContacto")


        oDs = Nothing
        objProveedor = Nothing

    End Sub

    Private Sub txt_NombreCompañia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NombreCompañia.GotFocus
        txt_NombreCompañia.Text = ""
    End Sub

    Private Sub txt_NombreCompañia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NombreCompañia.TextChanged

    End Sub
End Class
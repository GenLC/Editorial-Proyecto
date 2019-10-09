Imports EDITORIAL.AD

Public Class FrmAutores


    Private Sub FrmAutores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub


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
                    cmdModificar.Enabled = True
                    cmdAceptar.Enabled = False
                    'cmdCancelar.Enabled = True
                    grl_Autores.Enabled = True
                    cmdAgregar.Enabled = True
                    cmdLimpiar.Enabled = True

                    Panel1.BackColor = Color.Purple
                    LblAccion.Text = "Consultando"


                Case EstadodelFormulario.eAgregar

                    HabililarTXT()
                    txtIdAutor.Enabled = False

                    cmdAgregar.Enabled = False
                    cmdModificar.Enabled = False

                    'cmdCancelar.Enabled = True
                    cmdLimpiar.Enabled = True
                    cmdAceptar.Enabled = True

                    grl_Autores.Enabled = False

                    txtNombre.Focus()
                    txtNacionalidad.Focus()
                    Panel1.BackColor = Color.Red
                    LblAccion.Text = "Agregando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txtIdAutor.Text <> Nothing Then
                        HabililarTXT()
                        txtIdAutor.Enabled = False
                        cmdAgregar.Enabled = False
                        cmdModificar.Enabled = False

                        cmdLimpiar.Enabled = True
                        grl_Autores.Enabled = False
                        cmdAceptar.Enabled = True
                        'cmdCancelar.Enabled = True

                        Panel1.BackColor = Color.Green
                        lblAccion.Text = "Modificando"
                        lblAccion.ForeColor = Color.Black
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
        txtIdAutor.Text = ""
        txtNombre.Text = ""
        txtNacionalidad.Text = ""
    End Sub

    Private Sub HabililarTXT()

        txtIdAutor.Enabled = True
        txtNombre.Enabled = True
        txtNacionalidad.Enabled = True


    End Sub

    Private Sub DesHabililarTXT()

        txtIdAutor.Enabled = False
        txtNombre.Enabled = False
        txtNacionalidad.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        CmdAgregar.Enabled = True
        CmdModificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        CmdAgregar.Enabled = False
        CmdModificar.Enabled = False


    End Sub

    Private Sub CargarGrilla()

        Dim ods As New Data.DataSet
        Dim oAutores As New C_Autores

        ods = oAutores.CargarGrillaoAutores
        grl_Autores.DataSource = ods.Tables(0)
        ' grl_Autores.DataBindings

        grl_Autores.Columns(0).HeaderText = "Cod."
        grl_Autores.Columns(0).Width = 70

        grl_Autores.Columns(1).HeaderText = "Nombres"
        grl_Autores.Columns(1).Width = 550

        grl_Autores.Columns(2).HeaderText = "Nacionalidad"
        grl_Autores.Columns(2).Width = 950

    End Sub
#End Region




    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oAutores As New C_Autores

        oDs = oAutores.BuscarPorId(ID)

        txtIdAutor.Text = oDs.Tables(0).Rows(0).Item("IdAutor")
        txtNombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")
        txtNacionalidad.Text = oDs.Tables(0).Rows(0).Item("Nacionalidad")


        oDs = Nothing
        oAutores = Nothing

    End Sub


    '#Region "Grilla"
    '    Private Sub grl_Autores_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_Autores.CellContentDoubleClick

    '        BuscarPorID(grl_Autores.CurrentRow.Cells(0).Value)
    '        cmdAgregar.Enabled = False

    '    End Sub
    '#End Region

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Estado = EstadodelFormulario.eConsulta

    End Sub



    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Esta seguro de Salir?" & vbCrLf & _
             "Se perderán las ultimas modificaciones", _
             vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If


        'Poner boton ara preguntar si desea salir
    End Sub


    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Limpiar()

        Me.Estado = EstadodelFormulario.eAgregar


    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Estado = EstadodelFormulario.eModificar
    End Sub


    Private Sub grl_Autores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        BuscarPorID(grl_Autores.CurrentRow.Cells(0).Value)
        cmdAgregar.Enabled = False

        'No modificar en la grilla
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Validar() = True Then

            If Validar() = True Then


                Dim oAutor As New C_Autores


                If Me.Estado = EstadodelFormulario.eModificar Then
                    oAutor.ModificarAutor(txtNombre.Text.ToUpper, txtNacionalidad.Text.ToUpper, txtIdAutor.Text)
                    MsgBox("Se modificó correctamente el Autor con el código Nro: " + txtIdAutor.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    'Dim resultado As Integer
                    'resultado =
                    oAutor.AgregarAutor(txtNombre.Text.ToUpper, txtNacionalidad.Text.ToUpper)
                    MsgBox("Se agregó correctamente el Autor " + txtNombre.Text.ToUpper + " con un nuevo código ", MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If


        End If
    End Sub


    Private Function Validar() As Boolean

        If TxtNombre.Text = "" Then

            MsgBox("Complete el nombre del Nombre", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function
    Private Sub FrmAutores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub
End Class
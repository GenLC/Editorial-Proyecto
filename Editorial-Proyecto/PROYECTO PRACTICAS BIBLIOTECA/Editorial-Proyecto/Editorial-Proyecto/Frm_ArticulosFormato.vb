Imports EDITORIAL.AD
Public Class Frm_ArticulosFormato

    Private Sub Frm_ArticulosFormato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    DeshabilitarTXT()
                    DeshabilitarComandos()
                    cmd_Modificar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    grl_GrillaArtFormato.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                    Panel2.BackColor = Color.Purple
                    lbl_Estado.Text = "Consultando"


                Case EstadodelFormulario.eAgregar

                    HabilitarTXT()
                    txt_IDArtFormato.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False

                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_GrillaArtFormato.Enabled = False

                    txt_NombreTipoFormato.Focus()
                    Panel2.BackColor = Color.Red
                    lbl_Estado.Text = "Agregando"
                    lbl_Estado.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txt_IDArtFormato.Text <> Nothing Then
                        HabilitarTXT()
                        txt_IDArtFormato.Enabled = False
                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False

                        cmd_Limpiar.Enabled = True
                        grl_GrillaArtFormato.Enabled = False
                        cmd_Aceptar.Enabled = True
                        cmd_Cancelar.Enabled = True

                        Panel2.BackColor = Color.Green
                        lbl_Estado.Text = "Modificando"
                        lbl_Estado.ForeColor = Color.Black
                    Else
                        MsgBox("Seleccione algun Tipo Art", MsgBoxStyle.Critical, "Error")
                    End If
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Funciones"

    Private Sub Limpiar()
        CargarGrilla()
        txt_IDArtFormato.Text = "Id Tipo Art.Formato"
        txt_NombreTipoFormato.Text = "Nombre Tipo Art"

    End Sub

    Private Sub HabilitarTXT()

        txt_IDArtFormato.Enabled = True
        txt_NombreTipoFormato.Enabled = True

    End Sub

    Private Sub DeshabilitarTXT()

        txt_IDArtFormato.Enabled = False
        txt_NombreTipoFormato.Enabled = False

    End Sub

    Private Sub HabilitarComandos()

        cmd_Agregar.Enabled = True
        cmd_Modificar.Enabled = True

    End Sub

    Private Sub DeshabilitarComandos()

        cmd_Agregar.Enabled = False
        cmd_Modificar.Enabled = False

    End Sub

    Private Sub CargarGrilla()

        Dim Ods As New DataSet
        Dim objArtFormato As New C_Art

        Ods = objArtFormato.BuscarTodos
        grl_GrillaArtFormato.DataSource = Ods.Tables(0)

        grl_GrillaArtFormato.Columns(0).HeaderText = "Cod."
        grl_GrillaArtFormato.Columns(0).Width = 90
        grl_GrillaArtFormato.Columns(1).HeaderText = "Nombre"
        grl_GrillaArtFormato.Columns(1).Width = 1350
        

    End Sub

#End Region
    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim objArtFormato As New C_Art

        oDs = objArtFormato.BuscarID(ID)

        txt_IDArtFormato.Text = oDs.Tables(0).Rows(0).Item("IdArticuloFormato")
        txt_NombreTipoFormato.Text = oDs.Tables(0).Rows(0).Item("NombreTipoArticulo")


        oDs = Nothing
        objArtFormato = Nothing


    End Sub



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


                Dim objArtFormato As New C_Art


                If Me.Estado = EstadodelFormulario.eModificar Then
                    objArtFormato.Modificar(txt_IDArtFormato.Text, txt_NombreTipoFormato.Text.ToUpper) ', ChkActivo.Checked
                    MsgBox("Se modificó correctamente el Tipo de Articulo el código Nro: " + txt_IDArtFormato.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = objArtFormato.Cargar(txt_NombreTipoFormato.Text.ToUpper) ', ChkActivo.Checked
                    MsgBox("Se agregó correctamente el Tipo de Artiulo " + txt_NombreTipoFormato.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_NombreTipoFormato.Text = "" Then

            MsgBox("Complete el nombre de Tipo Art", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region

#Region "Formulario"


    Private Sub Frm_ArticulosFormato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub Frm_ArticulosFormato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub


#End Region

    Private Sub grl_GrillaArtFormato_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_GrillaArtFormato.CellContentClick
        BuscarPorID(grl_GrillaArtFormato.CurrentRow.Cells(0).Value)
        cmd_Agregar.Enabled = False
    End Sub

    
   
End Class
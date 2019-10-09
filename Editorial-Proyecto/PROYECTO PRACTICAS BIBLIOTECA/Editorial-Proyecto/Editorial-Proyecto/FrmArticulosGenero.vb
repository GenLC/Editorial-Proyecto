Imports EDITORIAL.AD
Public Class FrmArticulosGenero

    Private Sub FrmArticulosGenero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmArticulosGenero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    Deshabilitar()
                    DeshabilitarComandos()
                    cmd_Modificar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    grl_ArticulosGenero.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                Case EstadodelFormulario.eAgregar

                    Habilitar()
                    txt_IDArticulo.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False

                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_ArticulosGenero.Enabled = False

                    txt_Genero.Focus()
                    txt_TipoArticulo.Focus()
                    Panel2.BackColor = Color.Red
                    lbl_Estado.Text = "Agregando"
                    lbl_Estado.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txt_IDArticulo.Text <> Nothing Then
                        Habilitar()
                        txt_IDArticulo.Enabled = False
                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False

                        cmd_Limpiar.Enabled = True
                        grl_ArticulosGenero.Enabled = False
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
        txt_IDArticulo.Text = ""
        txt_Genero.Text = ""
        txt_TipoArticulo.Text = ""
        CargarGrilla()

    End Sub

    Private Sub Habilitar()

        txt_IDArticulo.Enabled = True
        txt_Genero.Enabled = True
        txt_TipoArticulo.Enabled = True

    End Sub

    Private Sub Deshabilitar()

        txt_IDArticulo.Enabled = False
        txt_Genero.Enabled = False
        txt_TipoArticulo.Enabled = False

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
        Dim objArtGenero As New C_ArtGeneros

        Ods = objArtGenero.CargarGrilla
        grl_ArticulosGenero.DataSource = Ods.Tables(0)

        grl_ArticulosGenero.Columns(0).HeaderText = "Cod."
        grl_ArticulosGenero.Columns(0).Width = 90

        grl_ArticulosGenero.Columns(1).HeaderText = "Genero"
        grl_ArticulosGenero.Columns(1).Width = 200

        grl_ArticulosGenero.Columns(2).HeaderText = "NombreTipoArticulo"
        grl_ArticulosGenero.Columns(2).Width = 700


    End Sub


#End Region

    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim objArtGenero As New C_ArtGeneros

        oDs = objArtGenero.BuscarporID(ID)

        txt_IDArticulo.Text = oDs.Tables(0).Rows(0).Item("IdArticuloCaracteristica")
        txt_Genero.Text = oDs.Tables(0).Rows(0).Item("Genero")
        txt_TipoArticulo.Text = oDs.Tables(0).Rows(0).Item("NombreTipoArticulo")


        oDs = Nothing
        objArtGenero = Nothing


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


                Dim objArtGenero As New C_ArtGeneros


                If Me.Estado = EstadodelFormulario.eModificar Then
                    objArtGenero.Modificar(txt_IDArticulo.Text, txt_Genero.Text, txt_TipoArticulo.Text) ', ChkActivo.Checked
                    MsgBox("Se modificó correctamente datos del Proveedor el código Nro: " + txt_IDArticulo.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = objArtGenero.Cargar(txt_Genero.Text, txt_TipoArticulo.Text) ', ChkActivo.Checked
                    MsgBox("Se agregó correctamente los datos del Proveedor " + txt_Genero.Text + txt_TipoArticulo.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

#Region "Funcion Validar"

    Private Function Validar() As Boolean

        If txt_Genero.Text = "" And txt_TipoArticulo.Text = "" Then

            MsgBox("Complete Campos", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region

    Private Sub grl_ArticulosGenero_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_ArticulosGenero.CellContentClick
        BuscarPorID(grl_ArticulosGenero.CurrentRow.Cells(0).Value)
        cmd_Agregar.Enabled = False

    End Sub
End Class
Imports EDITORIAL.AD
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    cmd_Modificar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    grl_GrillaEditorial.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                    Panel2.BackColor = Color.Purple
                    lbl_Accion.Text = "Consultando"


                Case EstadodelFormulario.eAgregar

                    HabililarTXT()
                    txt_IDEditorial.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False

                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_GrillaEditorial.Enabled = False

                    txt_NombreEditorial.Focus()
                    Panel2.BackColor = Color.Red
                    lbl_Accion.Text = "Agregando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txt_IDEditorial.Text <> Nothing Then
                        HabililarTXT()
                        txt_IDEditorial.Enabled = False
                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False

                        cmd_Limpiar.Enabled = True
                        grl_GrillaEditorial.Enabled = False
                        cmd_Aceptar.Enabled = True
                        cmd_Cancelar.Enabled = True

                        Panel2.BackColor = Color.Green
                        lbl_Accion.Text = "Modificando"
                        lbl_Accion.ForeColor = Color.Black
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
        txt_IDEditorial.Text = "ID Editorial"
        txt_NombreEditorial.Text = "Nombre Editorial"

    End Sub

    Private Sub HabililarTXT()

        txt_IDEditorial.Enabled = True
        txt_NombreEditorial.Enabled = True
        

    End Sub

    Private Sub DesHabililarTXT()

        txt_IDEditorial.Enabled = False
        txt_NombreEditorial.Enabled = False
        
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
        Dim objEditorial As New C_Editorial

        ods = objEditorial.CargarGrilla
        grl_GrillaEditorial.DataSource = ods.Tables(0)
        ' grl_Autores.DataBindings

        grl_GrillaEditorial.Columns(0).HeaderText = "Cod."
        grl_GrillaEditorial.Columns(0).Width = 70

        grl_GrillaEditorial.Columns(1).HeaderText = "Nombre"
        grl_GrillaEditorial.Columns(1).Width = 1250
    End Sub
#End Region


    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim objEditorial As New C_Editorial

        oDs = objEditorial.BuscarporID(ID)

        txt_IDEditorial.Text = oDs.Tables(0).Rows(0).Item("idEditorial")
        txt_NombreEditorial.Text = oDs.Tables(0).Rows(0).Item("NombreEditorial")
    

        oDs = Nothing
        objEditorial = Nothing

    End Sub

    Private Sub cmd_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta

    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If MsgBox("Esta seguro de Salir?" & vbCrLf & _
                  "Se perderán las ultimas modificaciones", _
                  vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click
        Limpiar()

        Me.Estado = EstadodelFormulario.eAgregar
    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        Me.Estado = EstadodelFormulario.eModificar
    End Sub

    Private Sub grl_GrillaEditorial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_GrillaEditorial.CellContentClick

        BuscarPorID(grl_GrillaEditorial.CurrentRow.Cells(0).Value)
        cmd_Agregar.Enabled = False

        'No modificar en la grilla
    End Sub

    Private Sub cmd_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Aceptar.Click
        Try

            If Validar() = True Then


                Dim objEditorial As New C_Editorial


                If Me.Estado = EstadodelFormulario.eModificar Then
                    objEditorial.Modificar(txt_IDEditorial.Text, txt_NombreEditorial.Text.ToUpper) ', ChkActivo.Checked
                    MsgBox("Se modificó correctamente la Editorial el código Nro: " + txt_IDEditorial.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = objEditorial.Cargar(txt_NombreEditorial.Text.ToUpper) ', ChkActivo.Checked
                    MsgBox("Se agregó correctamente la Editorial " + txt_NombreEditorial.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
 
#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_NombreEditorial.Text = "" Then

            MsgBox("Complete el nombre de Editorial", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function

#End Region

#Region "Formulario"





    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub


#End Region
   
End Class

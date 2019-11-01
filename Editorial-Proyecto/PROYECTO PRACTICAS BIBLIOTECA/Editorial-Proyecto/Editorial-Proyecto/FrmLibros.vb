Imports EDITORIAL.AD
Public Class FrmLibros


#Region "Form y estados"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta
        txtBuscardor.Text = "Buscador por Nombre"

    End Sub

    Private eEstado As EstadodelFormulario

    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eModificar = 3
    End Enum
#End Region


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
                    grl_GrillaLibros.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                    Panel2.BackColor = Color.Purple
                    lbl_Accion.Text = "Consultando"


                Case EstadodelFormulario.eAgregar

                    HabililarTXT()
                    txtIDLibro.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False

                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_GrillaLibros.Enabled = False

                    txtLibro.Focus()
                    txtDescripcion.Focus()
                    txtPrecio.Focus()
                    txtCantidad.Focus()
                    Panel2.BackColor = Color.Red
                    lbl_Accion.Text = "Agregando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eModificar

                    If txtIDLibro.Text <> Nothing Then
                        HabililarTXT()
                        txtIDLibro.Enabled = False
                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False

                        cmd_Limpiar.Enabled = True
                        grl_GrillaLibros.Enabled = False
                        cmd_Aceptar.Enabled = True
                        cmd_Cancelar.Enabled = True

                        Panel2.BackColor = Color.Green
                        lbl_Accion.Text = "Modificando"
                        lbl_Accion.ForeColor = Color.Black
                    Else
                        MsgBox("Seleccione algun Libro", MsgBoxStyle.Critical, "Error")
                    End If
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region


#Region "funciones"
    Private Sub Limpiar()
        CargarGrilla()
        txtIDLibro.Text = ""
        txtLibro.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""

    End Sub

    Private Sub HabililarTXT()

        txtIDLibro.Enabled = True
        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True
        txtLibro.Enabled = True
        txtCantidad.Enabled = True


    End Sub

    Private Sub DesHabililarTXT()

        txtIDLibro.Enabled = False
        txtDescripcion.Enabled = False
        txtLibro.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False

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
        Dim objLibros As New C_Libros

        ods = objLibros.CargarGrilla
        grl_GrillaLibros.DataSource = ods.Tables(0)
        ' grl_Autores.DataBindings

        grl_GrillaLibros.Columns(0).HeaderText = "Cod."
        grl_GrillaLibros.Columns(0).Width = 70

        grl_GrillaLibros.Columns(1).HeaderText = "Nombre"
        grl_GrillaLibros.Columns(1).Width = 150

        grl_GrillaLibros.Columns(2).HeaderText = "Descripcion"
        grl_GrillaLibros.Columns(2).Width = 200

        grl_GrillaLibros.Columns(3).HeaderText = "Precio"
        grl_GrillaLibros.Columns(3).Width = 100



        grl_GrillaLibros.Columns(4).HeaderText = "Cantidad"
        grl_GrillaLibros.Columns(4).Width = 100
    End Sub
#End Region


#Region "Grilla y buscar por ID"
    Private Sub BuscarPorIDLibro(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim objLibros As New C_Libros

        oDs = objLibros.BuscarporIDLibro(ID)

        txtIDLibro.Text = oDs.Tables(0).Rows(0).Item("IdLibro")
        txtLibro.Text = oDs.Tables(0).Rows(0).Item("NombreLibro")
        txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        txtPrecio.Text = oDs.Tables(0).Rows(0).Item("Precio")
        txtCantidad.Text = oDs.Tables(0).Rows(0).Item("Cantidad")


        oDs = Nothing
        objLibros = Nothing

    End Sub
    Private Sub grl_GrillaLibros_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_GrillaLibros.CellContentClick
        BuscarPorIDLibro(grl_GrillaLibros.CurrentRow.Cells(0).Value)
        cmd_Agregar.Enabled = False


    End Sub
#End Region


#Region "Comandos"
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

    Private Sub cmd_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Aceptar.Click
        Try

            If Validar() = True Then


                Dim objLibros As New C_Libros


                If Me.Estado = EstadodelFormulario.eModificar Then
                    objLibros.Modificar(txtIDLibro.Text, txtLibro.Text.ToUpper, txtDescripcion.Text.ToUpper, txtPrecio.Text, txtCantidad.Text) ', ChkActivo.Checked
                    MsgBox("Se modificó correctamente la Libro " + txtLibro.Text + "el código Nro: " + txtIDLibro.Text + " contiene" + txtCantidad.Text + " libro", MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = objLibros.Cargar(txtLibro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text) ', ChkActivo.Checked
                    MsgBox("Se agregó correctamente el Libro " + txtLibro.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
#End Region


#Region "Funciones"

    Private Function Validar() As Boolean

        If txtLibro.Text = "" And txtDescripcion.Text = "" And txtPrecio.Text = "" Then

            MsgBox("Complete el nombre de Libro", MsgBoxStyle.Exclamation, "Mensaje")
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


#Region "Buscar por nombre Libro"
    Private Sub BuscadorLibroGrilla(ByVal NombreLibro As String)

        Dim oDs As New DataSet
        Dim objLibro As New C_Libros


        oDs = objLibro.BuscarLibro(NombreLibro)

        grl_GrillaLibros.DataSource = oDs.Tables(0)


        grl_GrillaLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


        oDs = Nothing
        objLibro = Nothing


    End Sub

    Private Sub txtBuscardor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscardor.Click

        txtBuscardor.Text = ""

        CargarGrilla()

    End Sub

    Private Sub txtBuscardor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscardor.KeyUp

        If txtBuscardor.Text <> Nothing Then

            BuscadorLibroGrilla(txtBuscardor.Text)


        End If

    End Sub

#End Region




  
  
End Class

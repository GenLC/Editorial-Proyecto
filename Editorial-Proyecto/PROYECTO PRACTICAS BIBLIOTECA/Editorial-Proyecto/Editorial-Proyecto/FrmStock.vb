Imports EDITORIAL.AD
Imports System.Data.SqlClient

Public Class FrmStock

    Private Sub FrmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadoDelFormulario.Consulta

        Limpiar()

    End Sub


    Private eEstado As EstadoDelFormulario

    Public Enum EstadoDelFormulario



        Agregar = 1

        Modificar = 2

        Consulta = 3


    End Enum

#Region "Propiedades"
    Public Property Estado() As EstadoDelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal value As EstadoDelFormulario)



            Select Case value


                Case EstadoDelFormulario.Consulta

                    Limpiar()
                    DesHabililarTXT()
                    DesHabililarComandos()

                    cmd_Modificar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    cmd_Agregar.Enabled = True
                    cmd_Limpiar.Enabled = True

                    grl_GrillaStock.Enabled = True

                    Panel2.BackColor = Color.Purple

                    lbl_Accion.Text = "Consultando"


                Case EstadoDelFormulario.Agregar

                    HabililarTXT()
                    txtBuscardor.Enabled = False

                    cmd_Agregar.Enabled = False
                    cmd_Modificar.Enabled = False
                    cmd_Cancelar.Enabled = True
                    cmd_Limpiar.Enabled = True
                    cmd_Aceptar.Enabled = True

                    grl_GrillaStock.Enabled = False

                    cboLibro.Focus()
                    txtCantidad.Focus()

                    Panel2.BackColor = Color.Red

                    lbl_Accion.Text = "Agregando"
                    lbl_Accion.ForeColor = Color.Black


                Case EstadoDelFormulario.Modificar

                    If txtBuscardor.Text <> Nothing Then


                        HabililarTXT()

                        txtBuscardor.Enabled = False


                        cmd_Agregar.Enabled = False
                        cmd_Modificar.Enabled = False
                        cmd_Limpiar.Enabled = True
                        cmd_Aceptar.Enabled = True
                        cmd_Cancelar.Enabled = True

                        grl_GrillaStock.Enabled = False

                        Panel2.BackColor = Color.Green

                        lbl_Accion.Text = "Modificando"
                        lbl_Accion.ForeColor = Color.Black


                    Else

                        MsgBox("Ingrese nombre en buscador", MsgBoxStyle.Critical, "Error")

                    End If
            End Select

            eEstado = value

        End Set

    End Property


#End Region


#Region "Grilla, Stock y Limpiar"

    Private Sub CargaStock()
        Dim Ods As New DataSet
        Dim objStock As New C_Libros

        Ods = objStock.CargarGrilla

        cboLibro.DataSource = Ods.Tables(0)
        cboLibro.DisplayMember = Ods.Tables(0).Columns("NombreLibro").ToString.Trim
        cboLibro.ValueMember = Ods.Tables(0).Columns("IdLibro").ToString.Trim
        'cboLibro.SelectedValue = Nothing
        'cboLibro.DataBind()

        'Dim conexion As SqlConnection
        'Dim comando As New SqlCommand

        'conexion = New SqlConnection("data source = pablo\sqlexpress; initial catalog = BD_Libreria_Practicas; user id = sa; password = esea")

        'conexion.Open()

        'comando.Connection = conexion
        'comando.CommandType = CommandType.StoredProcedure
        'comando.CommandText = ("CargarStock")
        'Dim adaptador As New SqlDataAdapter(comando)
        'Dim ods As New DataSet

        'adaptador.Fill(ods)

        'If ods.Tables(0).Rows.Count > 0 Then

        '    cboLibro.DataSource = ods.Tables(0)
        '    cboLibro.DisplayMember = "NombreLibro"
        '    cboLibro.ValueMember = "IdLibro"

        'End If

    End Sub

    Private Sub CargarGrilla()

        Dim ods As New Data.DataSet
        Dim ObjStock As New C_Stock

        ods = ObjStock.GrillaStock

        grl_GrillaStock.DataSource = ods.Tables(0)


        grl_GrillaStock.Columns(1).HeaderText = "Nombre Libro"
        grl_GrillaStock.Columns(1).Width = 150


        grl_GrillaStock.Columns(2).HeaderText = "Cantidad"
        grl_GrillaStock.Columns(2).Width = 120







    End Sub

    Private Sub Limpiar()
        CargarGrilla()
        CargaStock()
        cboLibro.Text = Nothing
        txtCantidad.Text = ""

    End Sub




    Private Sub HabililarTXT()

        cboLibro.Enabled = True
        txtCantidad.Enabled = True


    End Sub

    Private Sub DesHabililarTXT()

        cboLibro.Enabled = False
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

    Private Function Validar() As Boolean

        If txtCantidad.Text = "" And cboLibro.Text = Nothing Then

            MsgBox("Complete datos", MsgBoxStyle.Exclamation, "Mensaje")

            Return False


        End If

        Return True

    End Function
#End Region

    Private Sub BuscadorLibroGrilla(ByVal IdLibro As Integer)


        Dim oDs As New DataSet
        Dim oIdLibro As New C_Stock

        oDs = oIdLibro.BuscarID(IdLibro)

        grl_GrillaStock.DataSource = oDs.Tables(0)



        grl_GrillaStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oIdLibro = Nothing

    End Sub
#Region "Comando"
    Private Sub cmd_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Aceptar.Click



        Dim objStock As New C_Stock
        Dim objLibro As New C_Libros


        If Me.Estado = EstadoDelFormulario.Modificar Then

            objStock.Modificar(txtBuscardor.Text, cboLibro.Text, txtCantidad.Text)

            MsgBox("Se modificó correctamente" + cboLibro.SelectedValue + "" + txtCantidad.Text, MsgBoxStyle.Information, "Exitos!")

        End If


        If Me.Estado = EstadoDelFormulario.Agregar Then

            Dim resultado As Integer

            resultado = objStock.Cargar(cboLibro.SelectedIndex, txtCantidad.Text)

            For i = 0 To grl_GrillaStock.RowCount - 2

                objLibro.RestarStock(grl_GrillaStock.Rows(i).Cells(0).Value, grl_GrillaStock.Rows(i).Cells(2).Value)
            Next
            
            MsgBox("Se agregó correctamente" + cboLibro.SelectedText + "" + txtCantidad.Text + resultado.ToString, MsgBoxStyle.Information, "Exitos!")

        End If

        Me.Estado = EstadoDelFormulario.Consulta

         

    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click

        Me.Estado = EstadoDelFormulario.Agregar

        Limpiar()

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click

        Me.Estado = EstadoDelFormulario.Modificar

    End Sub

#End Region

    Private Sub txtBuscardor_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscardor.KeyUp
        Dim buscarID As Integer

        buscarID = grl_GrillaStock.CurrentRow.Cells(0).Value

        BuscadorLibroGrilla(buscarID)

    End Sub









    Private Sub txtBuscardor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscardor.TextChanged

    End Sub
End Class

Imports EDITORIAL.AD


Public Class FrmVentaLibroSeleccion

    Private Sub FrmVentaLibroSeleccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarGrillaLibros()
        lblClienteSeleccionado.Text = SeleccionClienteNombre
        txtCantidad.Text = " 1 "
    End Sub

#Region "Buscador"

    Private Sub txtBuscadoLibros_Click(sender As Object, e As System.EventArgs)
        txtBuscadoLibros.Text = ""
        CargarGrillaLibros()

    End Sub

    Private Sub txtBuscadoLibros_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If txtBuscadoLibros.Text <> Nothing Then
            BuscadorLibrosGrilla(txtBuscadoLibros.Text)
        End If
    End Sub


    Private Sub txtBuscadoLibros_Click1(sender As Object, e As System.EventArgs) Handles txtBuscadoLibros.Click
        txtBuscadoLibros.Text = ""
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

        grlLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        oDs = Nothing
        oLibro = Nothing

    End Sub

#End Region

    Private Sub CargarGrillaLibros()

        Dim ods As New Data.DataSet
        Dim oLibros As New C_Ventas

        ods = oLibros.CargarGrillaLibros

        grlLibros.DataSource = ods.Tables(0)



        grlLibros.Columns(0).Width = 100


        grlLibros.Columns(1).Width = 100

        grlLibros.Columns(2).HeaderText = "Cod Libro"
        grlLibros.Columns(1).Width = 20

        grlLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        oLibros = Nothing
    End Sub

    
    Private Sub cmdAgregarLibro_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarLibro.Click



        CodigoLibro = grlLibros.CurrentRow.Cells(2).Value
        NombreLibro = grlLibros.CurrentRow.Cells(0).Value
        PrecioLibro = grlLibros.CurrentRow.Cells(1).Value

        FrmVentas.grlResumenVenta.Rows.Add(CodigoLibro, NombreLibro, PrecioLibro, CDbl(txtCantidad.Text), CDbl(txtCantidad.Text) * PrecioLibro)


        Me.Close()

    
    End Sub

    Private Sub cmdAgregarNuevoLibro_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarNuevoLibro.Click
        FrmLibros.ShowDialog()
        CargarGrillaLibros()

    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
        CodigoLibro = Nothing
        NombreLibro = Nothing
        PrecioLibro = Nothing

    End Sub

   
    Private Sub grlLibros_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlLibros.CellContentClick

    End Sub
End Class



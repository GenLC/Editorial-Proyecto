Imports EDITORIAL.AD


Public Class FrmEstadisticas



    Private Sub TotalLibrosStock()
        Dim ods As New Data.DataSet
        Dim oLibro As New C_Estadisticas

        oLibro.

        txtTotalLibrosStock.Text = ods.Tables(0)
    End Sub


    Private Sub TotalLibrosStock()
        Dim ods As New Data.DataSet
        'Dim oLibros As New C_Clientes
        ''odsoLibros.
        ''Dim objLibros As New C_Libros


        ''txtTotalLibrosStock.DataBindings = ods.Tables(0)

        'txtIDLibro.Text = oDs.Tables(0).Rows(0).Item("IdLibro")
        'txtLibro.Text = oDs.Tables(0).Rows(0).Item("NombreLibro")
        'txtDescripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        'txtPrecio.Text = oDs.Tables(0).Rows(0).Item("Precio")
        'txtCantidad.Text = oDs.Tables(0).Rows(0).Item("Cantidad")


        'oDs = Nothing
        'objLibros = Nothing

    End Sub




    Private Sub FrmEstadisticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
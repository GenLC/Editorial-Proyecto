Imports EDITORIAL.AD


Public Class FrmEstadisticas

    Private Sub Calcular()
        CalcularTotalLibros()
        CalcularTotalIngresos()
        TotalClientes()
        MaxClientes()
    End Sub

    Private Sub CalcularTotalLibros()


        Dim oDs As New DataSet
        Dim TotalLibroStock As New C_Estadisticas

        oDs = TotalLibroStock.CalcularTotalLibros()

        txtTotalLibrosStock.Text = oDs.Tables(0).Rows(0).Item("suma")

        oDs = Nothing

    End Sub

    Private Sub CalcularTotalIngresos()


    Private Sub TotalLibrosStock()
        Dim ods As New Data.DataSet
        'Dim oLibros As New C_Clientes
        ''odsoLibros.
        ''Dim objLibros As New C_Libros


        Dim oDs As New DataSet
        Dim TotalIngresos As New C_Estadisticas

        oDs = TotalIngresos.CalcularTotalIngresos()

        txtTotalIngresos.Text = oDs.Tables(0).Rows(0).Item(0)

        oDs = Nothing

    End Sub

    Private Sub TotalClientes()


        Dim oDs As New DataSet
        Dim TotalClientes As New C_Estadisticas

        oDs = TotalClientes.ContarClientes()

        txtTotalClientes.Text = oDs.Tables(0).Rows(0).Item(0)

        oDs = Nothing

    End Sub


    Private Sub MaxClientes()


        Dim oDs As New DataSet
        Dim Oobjeto As New C_Estadisticas

        oDs = Oobjeto.MaximaCompraClientes()

        txtMaxCompraCliente.Text = oDs.Tables(0).Rows(0).Item(0)
        'txtMaxCompraClienteNombre.Text = oDs.Tables(0).Rows(0).Item(1)
        oDs = Nothing

    End Sub








    
    Private Sub FrmEstadisticas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Calcular()
    End Sub

    Private Sub cmd_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Actualizar.Click
        Calcular()

    End Sub
End Class
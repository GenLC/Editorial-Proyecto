Imports Editorial_Proyecto


Public Class FrmEstadisticas



    Private Sub TotalLibrosStock()
        Dim ods As New Data.DataSet
        Dim oLibro As New C_Estadisticas

        ods = oLibro.GrillaStock

        txtTotalLibrosStock.Text = ods.Tables(0)
    End Sub







End Class
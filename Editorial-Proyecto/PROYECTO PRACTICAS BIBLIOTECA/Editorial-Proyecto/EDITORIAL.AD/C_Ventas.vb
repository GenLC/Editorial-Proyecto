

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Ventas


    Dim odatabase As Database
    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    Public Function CargarGrillaLibros() As DataSet
        Return odatabase.ExecuteDataSet("CargarGrillaLibros")
    End Function


    Public Function BuscadorLibros(ByVal Nombre As String) As DataSet
        Return odatabase.ExecuteDataSet("BuscadorLibro", Nombre)
    End Function



    Public Function CargarDetalleVenta(ByVal IdCliente As Integer, ByVal IdLibro As Integer, ByVal IdVenta As Integer, ByVal PrecioLibro As Double) As Double
        Return odatabase.ExecuteScalar("CargarDetalleVenta", IdCliente, IdLibro, IdVenta, PrecioLibro)
    End Function


    Public Function CargarFacturaVenta(ByVal Letra As String, ByVal PuntoVenta As Integer, ByVal Nro As Integer, ByVal IdCliente As Integer, ByVal Total As Double, ByVal Fecha As DateTime, ByVal Estado As Integer) As Double
        Return odatabase.ExecuteScalar("CargarFacturaVenta", Letra, PuntoVenta, Nro, IdCliente, Total, Fecha, Estado)
    End Function


    Public Function CargarFacturaVentaDetalle(ByVal IdFactura As Integer, ByVal IdLibro As Integer, ByVal Cantidad As Integer, ByVal PrecioUnitario As Double, ByVal Total As Double) As Double
        Return odatabase.ExecuteScalar("CargarFacturaVentaDetalle", IdFactura, IdLibro, Cantidad, PrecioUnitario, Total)
    End Function

    Public Function RestaStock(ByVal IdLibro As Integer, ByVal Cantidad As Integer) As Double

        Return odatabase.ExecuteScalar("RestaStock", IdLibro, Cantidad)

    End Function

End Class

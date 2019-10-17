

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

    Public Function CargarNroVenta() As DataSet
        Return odatabase.ExecuteDataSet("CargarNroVenta")
    End Function


End Class

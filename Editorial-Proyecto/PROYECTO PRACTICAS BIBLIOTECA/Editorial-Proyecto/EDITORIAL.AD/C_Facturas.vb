Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration


Public Class C_Facturas

    Dim odatabase As Database
    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    Public Function CargarGrillaFacturas() As DataSet
        Return odatabase.ExecuteDataSet("CargarGrillaFacturas")
    End Function


    Public Function BuscadorFacturasGrillaNombre(ByVal NombreCliente As String) As DataSet
        Return odatabase.ExecuteDataSet("BuscadorFacturasGrillaNombre", NombreCliente)
    End Function



    Public Function BuscadorFacturasGrillaNroFactura(ByVal NroFactura As String) As DataSet
        Return odatabase.ExecuteDataSet("BuscadorFacturasGrillaNroFactura", NroFactura)
    End Function


    Public Function BuscadorFacturasGrillaMontoMenor(ByVal Monto As Double) As DataSet
        Return odatabase.ExecuteDataSet("BuscadorFacturasGrillaMontoMenor", Monto)
    End Function


    Public Function CargarFacturaDetalle(ByVal NroFacturaClienteSeleccionado As Double) As DataSet
        Return odatabase.ExecuteDataSet("CargarFacturaDetalle", NroFacturaClienteSeleccionado)
    End Function


    Public Function DesactivarFactura(ByVal NroFactura As Double) As Double
        Return odatabase.ExecuteScalar("DesactivarFactura", NroFactura)
    End Function

    Public Function RestaurarFactura(ByVal NroFactura As Integer) As Double

        Return odatabase.ExecuteScalar("RestaurarFactura", NroFactura)

    End Function

    Public Function CargarFacturasEliminadas() As DataSet
        Return odatabase.ExecuteDataSet("CargarFacturasEliminadas")
    End Function


End Class

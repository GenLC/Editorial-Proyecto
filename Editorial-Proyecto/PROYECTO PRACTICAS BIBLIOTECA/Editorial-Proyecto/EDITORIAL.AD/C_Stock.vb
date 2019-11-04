Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Stock

    Dim objStock As Database


    Public Sub New()

        objStock = DatabaseFactory.CreateDatabase("Conn")


    End Sub


    Public Function Cargar(ByVal IdLibro As Integer, ByVal Cantidad As Integer) As Integer

        Return objStock.ExecuteScalar("CargarStock", IdLibro, Cantidad)

    End Function

    Public Function GrillaStock() As DataSet


        Return objStock.ExecuteDataSet("CargarGrillaStock")

    End Function

    Public Function BuscarID(ByVal IdStock As String) As DataSet

        Return objStock.ExecuteDataSet("BuscarNombre", IdStock)

    End Function

    Public Function Modificar(ByVal IdStock As Integer, ByVal IdLibro As Integer, ByVal Cantidad As Integer) As Double

        Return objStock.ExecuteScalar("ModificarStock", IdStock, IdLibro, Cantidad)

    End Function

End Class

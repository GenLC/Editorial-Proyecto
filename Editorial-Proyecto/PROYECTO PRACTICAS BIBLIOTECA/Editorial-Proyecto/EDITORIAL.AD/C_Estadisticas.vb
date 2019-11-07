
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Estadisticas
    Dim odatabase As Database


    Public Sub New()

        odatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function CalcularTotalLibros() As DataSet
        Return odatabase.ExecuteDataSet("CalcularTotalLibros")
    End Function

    Public Function CalcularTotalIngresos() As DataSet
        Return odatabase.ExecuteDataSet("CalcularTotalIngresos")
    End Function

    Public Function ContarClientes() As DataSet
        Return odatabase.ExecuteDataSet("ContarClientes")
    End Function

    Public Function MaximaCompraClientes() As DataSet
        Return odatabase.ExecuteDataSet("MaximaCompraClientes")
    End Function


End Class

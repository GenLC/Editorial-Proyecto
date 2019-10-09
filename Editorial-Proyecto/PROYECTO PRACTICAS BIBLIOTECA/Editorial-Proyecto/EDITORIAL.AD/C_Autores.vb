Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Autores
    Dim odatabase As Database
    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function CargarGrillaoAutores() As DataSet
        Return odatabase.ExecuteDataSet("CargarGrillaoAutores")
    End Function

    Public Function BuscarPorId(ByVal IdAutor As Integer) As DataSet
        Return odatabase.ExecuteDataSet("BuscarPorId", IdAutor)
    End Function


    Public Function ModificarAutor(ByVal Nombre As String, ByVal Nacionalidad As String, ByVal IdAutor As Integer) As Double

        Return odatabase.ExecuteScalar("ModificarAutor", Nombre, Nacionalidad, IdAutor)

    End Function

    Public Function AgregarAutor(ByVal Nombre As String, ByVal Nacionalidad As String) As Double
        Try
            Return odatabase.ExecuteScalar("AgregarAutor", Nombre, Nacionalidad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

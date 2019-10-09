Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Editorial

    Dim objEditorial As Database


    Public Sub New()

        objEditorial = DatabaseFactory.CreateDatabase("Conn")

    End Sub


    Public Function Cargar(ByVal NombreEditorial As String) As Double

        Return objEditorial.ExecuteScalar("CargarEditorial", NombreEditorial)

    End Function

    Public Function Modificar(ByVal idEditorial As Integer, ByVal NombreEditorial As String) As Double

        Return objEditorial.ExecuteNonQuery("ModificarEditorial", idEditorial, NombreEditorial)

    End Function

    Public Function CargarGrilla() As DataSet

        Return objEditorial.ExecuteDataSet("CargarGrillaEditorial")

    End Function

    Public Function BuscarporID(ByVal idEditorial As Integer) As DataSet

        Return objEditorial.ExecuteDataSet("BuscarporID", idEditorial)

    End Function
End Class

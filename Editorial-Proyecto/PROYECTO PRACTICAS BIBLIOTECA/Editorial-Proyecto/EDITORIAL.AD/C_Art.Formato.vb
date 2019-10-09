Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Art

    Dim objArtFormato As Database


    Public Sub New()

        objArtFormato = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function Cargar(ByVal NombreTipoArticulo As String) As Double

        Return objArtFormato.ExecuteScalar("CargarArtFormato", NombreTipoArticulo)

    End Function


    Public Function Modificar(ByVal IdArticuloFormato As Integer, ByVal NombreTipoArticulo As String) As Double

        Return objArtFormato.ExecuteNonQuery("ModificarArtFormato", IdArticuloFormato, NombreTipoArticulo)

    End Function

    Public Function BuscarTodos() As DataSet

        Return objArtFormato.ExecuteDataSet("CargarGrillaArtFormato")

    End Function

    Public Function BuscarID(ByVal IdArticuloFormato As Integer) As DataSet

        Return objArtFormato.ExecuteDataSet("BuscarID", IdArticuloFormato)

    End Function

End Class

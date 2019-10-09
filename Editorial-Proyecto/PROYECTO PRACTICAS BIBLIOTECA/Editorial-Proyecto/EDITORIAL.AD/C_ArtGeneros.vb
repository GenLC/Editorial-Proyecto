Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_ArtGeneros

    Dim objArtGenero As Database

    Public Sub New()

        objArtGenero = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function Cargar(ByVal Genero As String, ByVal NombreTipoArticulo As String) As Double
        Try
            Return objArtGenero.ExecuteScalar("CargarArtGenero", Genero, NombreTipoArticulo)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function Modificar(ByVal IdArticuloCaracteristica As Integer, ByVal Genero As String, ByVal NombreTipoArticulo As String) As Double
        Try
            Return objArtGenero.ExecuteNonQuery("ModificarArtGenero", IdArticuloCaracteristica, Genero, NombreTipoArticulo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function CargarGrilla() As DataSet
        Try
            Return objArtGenero.ExecuteDataSet("CargarGrillaArtGenero")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarporID(ByVal IdArticuloCaracteristica As Integer) As DataSet
        Try
            Return objArtGenero.ExecuteDataSet("BuscarporIDGenero", IdArticuloCaracteristica)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function




End Class

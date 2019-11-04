Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Libros

    Dim objLibros As Database


    Public Sub New()

        objLibros = DatabaseFactory.CreateDatabase("Conn")

    End Sub


    Public Function Cargar(ByVal NombreLibro As String, ByVal Descripcion As String, ByVal Precio As Double, ByVal Cantidad As Integer) As Double
        Try
            Return objLibros.ExecuteScalar("CargarLibros", NombreLibro, Descripcion, Precio, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function Modificar(ByVal IdLibro As Integer, ByVal NombreLibro As String, ByVal Descripcion As String, ByVal Precio As Double, ByVal Cantidad As Integer) As Double
        Try
            Return objLibros.ExecuteNonQuery("ModificarLibros", IdLibro, NombreLibro, Descripcion, Precio, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function CargarGrilla() As DataSet
        Try
            Return objLibros.ExecuteDataSet("BuscarTodosLibros")
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarLibro(ByVal NombreLibro As String) As DataSet
        Try
            Return objLibros.ExecuteDataSet("BuscarLibroNombre", NombreLibro)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarporIDLibro(ByVal IdLibro As Integer) As DataSet
        Try
            Return objLibros.ExecuteDataSet("BuscarporIDLibro", IdLibro)
        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function RestarStock(ByVal IdLibro As Integer, ByVal Cantidad As Integer) As DataSet

        Return objLibros.ExecuteDataSet("LibroRestaStock", IdLibro, Cantidad)

    End Function
End Class

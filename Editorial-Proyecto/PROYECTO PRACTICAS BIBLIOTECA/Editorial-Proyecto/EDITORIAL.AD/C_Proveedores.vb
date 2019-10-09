Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Proveedores

    Dim objProveedores As Database



    Public Sub New()

        objProveedores = DatabaseFactory.CreateDatabase("Conn")

    End Sub


    Public Function CargarProveedores(ByVal NombreCompañia As String, ByVal NombreFantasia As String, ByVal NombreContacto As String, ByVal NroCuit As String, ByVal NroContacto As String) As Double

        Return objProveedores.ExecuteScalar("CargarProveedores", NombreCompañia, NombreFantasia, NombreContacto, NroCuit, NroContacto)

    End Function

    Public Function ModificarProveedores(ByVal IdProveedores As Integer, ByVal NombreCompañia As String, ByVal NombreFantasia As String, ByVal NombreContacto As String, ByVal NroCuit As String, ByVal NroContacto As String) As Double

        Return objProveedores.ExecuteNonQuery("ModificarProveedores", IdProveedores, NombreCompañia, NombreFantasia, NombreContacto, NroCuit, NroContacto)

    End Function


    Public Function CargarGrilla() As DataSet

        Return objProveedores.ExecuteDataSet("BuscarTodosPorveedores")

    End Function

    Public Function BuscarID(ByVal IdProveedores As Integer) As DataSet

        Return objProveedores.ExecuteDataSet("BuscarIDProveedor", IdProveedores)

    End Function
End Class

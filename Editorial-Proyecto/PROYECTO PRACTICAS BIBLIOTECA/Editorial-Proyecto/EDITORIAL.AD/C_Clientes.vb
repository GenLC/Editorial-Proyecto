
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Clientes
    Dim odatabase As Database
    Public Sub New()
        odatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarCliente(ByVal IdCliente As Integer) As DataSet
        Return odatabase.ExecuteDataSet("BuscarCliente", IdCliente)
    End Function


    Public Function BuscadorCliente(ByVal Nombre As Integer) As DataSet
        Return odatabase.ExecuteDataSet("BuscadorCliente", Nombre)
    End Function


    Public Function CargarGrillaClientes() As DataSet
        Return odatabase.ExecuteDataSet("CargarGrillaClientes")
    End Function

    Public Function ModificarCliente(ByVal IdCliente As Integer, ByVal Nombre As String, ByVal DNI As Integer, ByVal TelMovil As Integer, ByVal Mail As String, ByVal EstadoCliente As Boolean) As Double

        Return odatabase.ExecuteScalar("ModificarCliente", IdCliente, Nombre, DNI, TelMovil, Mail, EstadoCliente)

    End Function


    Public Function AgregarCliente(ByVal Nombre As String, ByVal DNI As Integer, ByVal TelMovil As Integer, ByVal Mail As String, ByVal EstadoCliente As Boolean) As Double
        Return odatabase.ExecuteScalar("AgregarCliente", Nombre, DNI, TelMovil, Mail, EstadoCliente)
    End Function

   




End Class

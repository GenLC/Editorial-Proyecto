
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

    Public Function CargarGrillaClientes() As DataSet
        Return odatabase.ExecuteDataSet("CargarGrillaClientes")
    End Function

    Public Function ModificarCliente(ByVal IdCliente As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal Provincia As Integer, ByVal Localidad As String, ByVal Barrio As String, ByVal CodPostal As Integer, ByVal Calle As String, ByVal Numero As Integer, ByVal TelefonoMovil As Integer, ByVal Mail As String, ByVal PlanTipo As Integer, ByVal CantCuotas As Integer, ByVal PrecioCuota As Double, ByVal EstadoCliente As Boolean, ByVal CantBolsasTotal As Integer, CantBolsasMes As Integer) As Double

        Return odatabase.ExecuteScalar("ModificarCliente", IdCliente, Nombre, Apellido, DNI, Provincia, Localidad, Barrio, CodPostal, Calle, Numero, TelefonoMovil, Mail, PlanTipo, CantCuotas, PrecioCuota, EstadoCliente, CantBolsasTotal, CantBolsasMes)

    End Function


    Public Function AgregarCliente(ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As Integer, ByVal Provincia As Integer, ByVal Localidad As String, ByVal Barrio As String, ByVal CodPostal As Integer, ByVal Calle As String, ByVal Numero As String, ByVal TelefonoMovil As String, ByVal Mail As String, ByVal PlanTipo As Integer, ByVal CantCuotas As Integer, ByVal PrecioCuota As Double, ByVal EstadoCliente As Boolean, ByVal CantBolsasTotal As Integer, CantBolsasMes As Integer) As Double
        Return odatabase.ExecuteScalar("AgregarCliente", Nombre, Apellido, DNI, Provincia, Localidad, Barrio, CodPostal, Calle, Numero, TelefonoMovil, Mail, PlanTipo, CantCuotas, PrecioCuota, EstadoCliente, CantBolsasTotal, CantBolsasMes)
    End Function



    Public Function CargarProvinciaCombo() As DataSet
        Return odatabase.ExecuteDataSet("CargarProvinciasCombo")
    End Function


    Public Function CargarPlanTipoCombo() As DataSet
        Return odatabase.ExecuteDataSet("CargarPlanTipoCombo")
    End Function

    Public Function CargarValorPlan(ByVal IdPlan As Integer) As DataSet
        Return odatabase.ExecuteDataSet("CargarValorPlan", IdPlan)
    End Function
    Public Function BuscarValorBolsa() As DataSet
        Return odatabase.ExecuteDataSet("BuscarValorBolsa")
    End Function

End Class

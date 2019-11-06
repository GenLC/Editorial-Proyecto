
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class C_Estadisticas
    Dim objArtFormato As Database


    Public Sub New()

        objArtFormato = DatabaseFactory.CreateDatabase("Conn")

    End Sub
End Class

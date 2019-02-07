Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrIdEmpleado As String
    Private MstrNombreEmpleado As String
    Private MstrContraseña As String
    Private MstrNombreSucursal As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property IdEmpleado() As String
        Get
            Return MstrIdEmpleado
        End Get
        Set(ByVal value As String)
            MstrIdEmpleado = value
        End Set
    End Property
    Public Property NombreEmpleado() As String
        Get
            Return MstrNombreEmpleado
        End Get
        Set(ByVal value As String)
            MstrNombreEmpleado = value
        End Set
    End Property
    Public Property Contraseña() As String
        Get
            Return MstrContraseña
        End Get
        Set(ByVal value As String)
            MstrContraseña = value
        End Set
    End Property
    Public Property NombreSucursal() As String
        Get
            Return MstrNombreSucursal
        End Get
        Set(ByVal value As String)
            MstrNombreSucursal = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function AltaEmpleado() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AltaEmpleado", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cmd.Parameters.Add(New SqlParameter("@NombreEmpleado", MstrNombreEmpleado))
        cmd.Parameters.Add(New SqlParameter("@Contraseña", MstrContraseña))
        cmd.Parameters.Add(New SqlParameter("@NombreSucursal", MstrNombreSucursal))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function BajaEmpleado() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.BajaEmpleado", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ActualizaEmpleado() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ActualizaEmpleado", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@NombreEmpleado", MstrNombreEmpleado))
        cmd.Parameters.Add(New SqlParameter("@Contraseña", MstrContraseña))
        cmd.Parameters.Add(New SqlParameter("@NombreSucursal", MstrNombreSucursal))
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ConsultaEmpleado() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ConsultaEmpleado", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim NombreEmpleado1, Contraseña1, NombreSucursal1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            NombreEmpleado1 = leer(1).ToString
            Contraseña1 = leer(2).ToString
            NombreSucursal1 = leer(3).ToString
            NombreEmpleado = NombreEmpleado1
            Contraseña = Contraseña1
            NombreSucursal = NombreSucursal1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class

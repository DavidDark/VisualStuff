Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrIdCliente As String
    Private MstrNombre As String
    Private MstrApellido As String
    Private MstrTelefono As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property IdCliente() As String
        Get
            Return MstrIdCliente
        End Get
        Set(ByVal value As String)
            MstrIdCliente = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return MstrNombre
        End Get
        Set(ByVal value As String)
            MstrNombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return MstrApellido
        End Get
        Set(ByVal value As String)
            MstrApellido = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return MstrTelefono
        End Get
        Set(ByVal value As String)
            MstrTelefono = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function Alta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Alta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Baja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Actualiza() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Actualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Consulta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Consulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombre1, Apellido1, Telefono1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            Nombre1 = leer(1).ToString
            Apellido1 = leer(2).ToString
            Telefono1 = leer(3).ToString
            Nombre = Nombre1
            Apellido = Apellido1
            Telefono = Telefono1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class

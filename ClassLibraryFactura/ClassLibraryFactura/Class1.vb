Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrIdFactura As String
    Private MstrMedioPago As String
    Private MstrIdPedido As String
    Private MstrIdEmpleado As String
    Private MstrIdSucursal As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property IdFactura() As String
        Get
            Return MstrIdFactura
        End Get
        Set(ByVal value As String)
            MstrIdFactura = value
        End Set
    End Property
    Public Property MedioPago() As String
        Get
            Return MstrMedioPago
        End Get
        Set(ByVal value As String)
            MstrMedioPago = value
        End Set
    End Property
    Public Property IdPedido() As String
        Get
            Return MstrIdPedido
        End Get
        Set(ByVal value As String)
            MstrIdPedido = value
        End Set
    End Property
    Public Property IdEmpleado() As String
        Get
            Return MstrIdEmpleado
        End Get
        Set(ByVal value As String)
            MstrIdEmpleado = value
        End Set
    End Property
    Public Property IdSucursal() As String
        Get
            Return MstrIdSucursal
        End Get
        Set(ByVal value As String)
            MstrIdSucursal = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function AltaFactura() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AltaFactura", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdFactura", MstrIdFactura))
        cmd.Parameters.Add(New SqlParameter("@MedioPago", MstrMedioPago))
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cmd.Parameters.Add(New SqlParameter("@IdSucursal", MstrIdSucursal))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function BajaFactura() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.BajaFactura", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdFactura", MstrIdFactura))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ActualizaFactura() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ActualizaFactura", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdFactura", MstrIdFactura))
        cmd.Parameters.Add(New SqlParameter("@MedioPago", MstrMedioPago))
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cmd.Parameters.Add(New SqlParameter("@IdSucursal", MstrIdSucursal))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ConsultaFactura() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ConsultaFactura", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim MedioPago1, IdPedido1, IdEmpleado1, IdSucursal1
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@IdFactura", MstrIdFactura))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            MedioPago1 = leer(1).ToString
            IdPedido1 = leer(2).ToString
            IdEmpleado1 = leer(3).ToString
            IdSucursal1 = leer(4).ToString
            MedioPago = MedioPago1
            IdPedido = IdPedido1
            IdEmpleado = IdEmpleado1
            IdSucursal = IdSucursal1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class
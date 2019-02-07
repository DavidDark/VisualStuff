Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrNorden As String
    Private MstrNomcliente As String
    Private MstrNumpaquete As String
    Private MstrHoraatencion As String
    Private MstrDescripcion As String
    Private MstrNotas As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property Norden() As String
        Get
            Return MstrNorden
        End Get
        Set(ByVal value As String)
            MstrNorden = value
        End Set
    End Property
    Public Property Nomcliente() As String
        Get
            Return MstrNomcliente
        End Get
        Set(ByVal value As String)
            MstrNomcliente = value
        End Set
    End Property
    Public Property Numpaquete() As String
        Get
            Return MstrNumpaquete
        End Get
        Set(ByVal value As String)
            MstrNumpaquete = value
        End Set
    End Property
    Public Property Horaatencion() As String
        Get
            Return MstrHoraatencion
        End Get
        Set(ByVal value As String)
            MstrHoraatencion = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return MstrDescripcion
        End Get
        Set(ByVal value As String)
            MstrDescripcion = value
        End Set
    End Property
    Public Property Notas() As String
        Get
            Return MstrNotas
        End Get
        Set(ByVal value As String)
            MstrNotas = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function Alta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PizzeriaWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Alta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Norden", MstrNorden))
        cmd.Parameters.Add(New SqlParameter("@Nomcliente", MstrNomcliente))
        cmd.Parameters.Add(New SqlParameter("@Numpaquete", MstrNumpaquete))
        cmd.Parameters.Add(New SqlParameter("@Horaatencion", MstrHoraatencion))
        cmd.Parameters.Add(New SqlParameter("@Descripcion", MstrDescripcion))
        cmd.Parameters.Add(New SqlParameter("@Notas", MstrNotas))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PizzeriaWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Baja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Norden", MstrNorden))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Actualiza() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PizzeriaWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Actualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nomcliente", MstrNomcliente))
        cmd.Parameters.Add(New SqlParameter("@Numpaquete", MstrNumpaquete))
        cmd.Parameters.Add(New SqlParameter("@Horaatencion", MstrHoraatencion))
        cmd.Parameters.Add(New SqlParameter("@Descripcion", MstrDescripcion))
        cmd.Parameters.Add(New SqlParameter("@Notas", MstrNotas))
        cmd.Parameters.Add(New SqlParameter("@Norden", MstrNorden))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Consulta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PizzeriaWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Consulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nomcliente1, Numpaquete1, Horaatencion1, Descripcion1, Notas1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@Norden", MstrNorden))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            Nomcliente1 = leer(1).ToString
            Numpaquete1 = leer(2).ToString
            Horaatencion1 = leer(3).ToString
            Descripcion1 = leer(4).ToString
            Notas1 = leer(5).ToString
            Nomcliente = Nomcliente1
            Numpaquete = Numpaquete1
            Horaatencion = Horaatencion1
            Descripcion = Descripcion1
            Notas = Notas1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class


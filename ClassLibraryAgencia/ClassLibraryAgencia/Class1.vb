Imports System.Data.SqlClient
Public Class Agencia
#Region "Definicion de propiedades"
    Private MstrId As String
    Private MstrDestino As String
    Private MstrCosto As String
    Private MstrVuelos As String
    Private MstrHorario As String
#End Region
#Region "Hacer publico el aceso a las propiedades"
    Public Property Id() As String
        Get
            Return MstrId
        End Get
        Set(ByVal value As String)
            MstrId = value
        End Set
    End Property
    Public Property Destino() As String
        Get
            Return MstrDestino
        End Get
        Set(ByVal value As String)
            MstrDestino = value
        End Set
    End Property
    Public Property Costo() As String
        Get
            Return MstrCosto
        End Get
        Set(ByVal value As String)
            MstrCosto = value
        End Set
    End Property
    Public Property Vuelos() As String
        Get
            Return MstrVuelos
        End Get
        Set(ByVal value As String)
            MstrVuelos = value
        End Set
    End Property
    Public Property Horario() As String
        Get
            Return MstrHorario
        End Get
        Set(ByVal value As String)
            MstrHorario = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function AgenciaAlta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=Agencia; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AgenAlta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Destino", MstrDestino))
        cmd.Parameters.Add(New SqlParameter("@Costo", MstrCosto))
        cmd.Parameters.Add(New SqlParameter("@Vuelos", MstrVuelos))
        cmd.Parameters.Add(New SqlParameter("@Horario", MstrHorario))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function AgenciaBaja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=Agencia; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AgenBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function AgenciaActualiza() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=Agencia; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AgenActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Destino", MstrDestino))
        cmd.Parameters.Add(New SqlParameter("@Costo", MstrCosto))
        cmd.Parameters.Add(New SqlParameter("@Vuelos", MstrVuelos))
        cmd.Parameters.Add(New SqlParameter("@Horario", MstrHorario))
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function AgenciaConsulta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=Agencia; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AgenConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Destino1, Costo1, Vuelos1, Horario1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Destino1 = leer(1).ToString
            Costo1 = leer(2).ToString
            Vuelos1 = leer(3).ToString
            Horario1 = leer(4).ToString
            Destino = Destino1
            Costo = Costo1
            Vuelos = Vuelos1
            Horario = 1
            cnx.Close()
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

End Class

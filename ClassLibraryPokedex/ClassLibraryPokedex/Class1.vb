Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrNum As String
    Private MstrNom As String
    Private MstrCon As String
    Private MstrTip As String
    Private MstrAlt As String
    Private MstrPes As String
    Private MstrCant As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property Num() As String
        Get
            Return MstrNum
        End Get
        Set(ByVal value As String)
            MstrNum = value
        End Set
    End Property
    Public Property Nom() As String
        Get
            Return MstrNom
        End Get
        Set(ByVal value As String)
            MstrNom = value
        End Set
    End Property
    Public Property Con() As String
        Get
            Return MstrCon
        End Get
        Set(ByVal value As String)
            MstrCon = value
        End Set
    End Property
    Public Property Tip() As String
        Get
            Return MstrTip
        End Get
        Set(ByVal value As String)
            MstrTip = value
        End Set
    End Property
    Public Property Alt() As String
        Get
            Return MstrAlt
        End Get
        Set(ByVal value As String)
            MstrAlt = value
        End Set
    End Property
    Public Property Pes() As String
        Get
            Return MstrPes
        End Get
        Set(ByVal value As String)
            MstrPes = value
        End Set
    End Property
    Public Property Cant() As String
        Get
            Return MstrCant
        End Get
        Set(ByVal value As String)
            MstrCant = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function Alta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PokedexWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Alta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Num", MstrNum))
        cmd.Parameters.Add(New SqlParameter("@Nom", MstrNom))
        cmd.Parameters.Add(New SqlParameter("@Con", MstrCon))
        cmd.Parameters.Add(New SqlParameter("@Tip", MstrTip))
        cmd.Parameters.Add(New SqlParameter("@Alt", MstrAlt))
        cmd.Parameters.Add(New SqlParameter("@Pes", MstrPes))
        cmd.Parameters.Add(New SqlParameter("@Cant", MstrCant))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PokedexWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Baja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Num", MstrNum))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Actualiza() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PokedexWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Actualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nom", MstrNom))
        cmd.Parameters.Add(New SqlParameter("@Con", MstrCon))
        cmd.Parameters.Add(New SqlParameter("@Tip", MstrTip))
        cmd.Parameters.Add(New SqlParameter("@Alt", MstrAlt))
        cmd.Parameters.Add(New SqlParameter("@Pes", MstrPes))
        cmd.Parameters.Add(New SqlParameter("@Cant", MstrCant))
        cmd.Parameters.Add(New SqlParameter("@Num", MstrNum))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function Consulta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=PokedexWeb; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.Consulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nom1, Con1, Tip1, Alt1, Pes1, Cant1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@Num", MstrNum))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            Nom1 = leer(1).ToString
            Con1 = leer(2).ToString
            Tip1 = leer(3).ToString
            Alt1 = leer(4).ToString
            Pes1 = leer(5).ToString
            Cant1 = leer(5).ToString
            Nom = Nom1
            Con = Con1
            Tip = Tip1
            Alt = Alt1
            Pes = Pes1
            Cant = Cant1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class

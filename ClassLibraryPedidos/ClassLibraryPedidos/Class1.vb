Imports System.Data.SqlClient
Public Class Class1
#Region "Definicion de propiedades"
    Private MstrIdPedido As String
    Private MstrSubtotal As String
    Private MstrImpuesto As String
    Private MstrTotal As String
    Private MstrEstatus As String
    Private MstrCantPizzas As String
    Private MstrCantBebidas As String
    Private MstrCantAderezo As String
    Private MstrHora As String
    Private MstrIdCliente As String
    Private MstrIdEmpleado As String
    Private MstrSucursal As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property IdPedido() As String
        Get
            Return MstrIdPedido
        End Get
        Set(ByVal value As String)
            MstrIdPedido = value
        End Set
    End Property
    Public Property Subtotal() As String
        Get
            Return MstrSubtotal
        End Get
        Set(ByVal value As String)
            MstrSubtotal = value
        End Set
    End Property
    Public Property Impuesto() As String
        Get
            Return MstrImpuesto
        End Get
        Set(ByVal value As String)
            MstrImpuesto = value
        End Set
    End Property
    Public Property Total() As String
        Get
            Return MstrTotal
        End Get
        Set(ByVal value As String)
            MstrTotal = value
        End Set
    End Property
    Public Property Estatus() As String
        Get
            Return MstrEstatus
        End Get
        Set(ByVal value As String)
            MstrEstatus = value
        End Set
    End Property
    Public Property CantPizzas() As String
        Get
            Return MstrCantPizzas
        End Get
        Set(ByVal value As String)
            MstrCantPizzas = value
        End Set
    End Property
    Public Property CantBebidas() As String
        Get
            Return MstrCantBebidas
        End Get
        Set(ByVal value As String)
            MstrCantBebidas = value
        End Set
    End Property
    Public Property CantAderezo() As String
        Get
            Return MstrCantAderezo
        End Get
        Set(ByVal value As String)
            MstrCantAderezo = value
        End Set
    End Property
    Public Property Hora() As String
        Get
            Return MstrHora
        End Get
        Set(ByVal value As String)
            MstrHora = value
        End Set
    End Property
    Public Property IdCliente() As String
        Get
            Return MstrIdCliente
        End Get
        Set(ByVal value As String)
            MstrIdCliente = value
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
    Public Property Sucursal() As String
        Get
            Return MstrSucursal
        End Get
        Set(ByVal value As String)
            MstrSucursal = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function AltaPedido() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AltaPedido", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cmd.Parameters.Add(New SqlParameter("@Subtotal", MstrSubtotal))
        cmd.Parameters.Add(New SqlParameter("@Impuesto", MstrImpuesto))
        cmd.Parameters.Add(New SqlParameter("@Total", MstrTotal))
        cmd.Parameters.Add(New SqlParameter("@Estatus", MstrEstatus))
        cmd.Parameters.Add(New SqlParameter("@CantPizzas", MstrCantPizzas))
        cmd.Parameters.Add(New SqlParameter("@CantBebidas", MstrCantBebidas))
        cmd.Parameters.Add(New SqlParameter("@CantAderezo", MstrCantAderezo))
        cmd.Parameters.Add(New SqlParameter("@Hora", MstrHora))
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cmd.Parameters.Add(New SqlParameter("@Sucursal", MstrSucursal))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function BajaPedido() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.BajaPedido", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ActualizaPedido() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ActualizaPedido", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cmd.Parameters.Add(New SqlParameter("@Subtotal", MstrSubtotal))
        cmd.Parameters.Add(New SqlParameter("@Impuesto", MstrImpuesto))
        cmd.Parameters.Add(New SqlParameter("@Total", MstrTotal))
        cmd.Parameters.Add(New SqlParameter("@Estatus", MstrEstatus))
        cmd.Parameters.Add(New SqlParameter("@CantPizzas", MstrCantPizzas))
        cmd.Parameters.Add(New SqlParameter("@CantBebidas", MstrCantBebidas))
        cmd.Parameters.Add(New SqlParameter("@CantAderezo", MstrCantAderezo))
        cmd.Parameters.Add(New SqlParameter("@Hora", MstrHora))
        cmd.Parameters.Add(New SqlParameter("@IdCliente", MstrIdCliente))
        cmd.Parameters.Add(New SqlParameter("@IdEmpleado", MstrIdEmpleado))
        cmd.Parameters.Add(New SqlParameter("@Sucursal", MstrSucursal))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function ConsultaPedido() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=ProyectoPizzeria2; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ConsultaPedido", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Subtotal1, Impuesto1, Total1, Estatus1, CantPizzas1, CantBebidas1, CantAderezo1, Hora1, IdCliente1, IdEmpleado1, Sucursal1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@IdPedido", MstrIdPedido))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read Then
            Subtotal1 = leer(1).ToString
            Impuesto1 = leer(2).ToString
            Total1 = leer(3).ToString
            Estatus1 = leer(4).ToString
            CantPizzas1 = leer(5).ToString
            CantBebidas1 = leer(6).ToString
            CantAderezo1 = leer(7).ToString
            Hora1 = leer(8).ToString
            IdCliente1 = leer(9).ToString
            IdEmpleado1 = leer(10).ToString
            Sucursal1 = leer(11).ToString
            Subtotal = Subtotal1
            Impuesto = Impuesto1
            Total = Total1
            Estatus = Estatus1
            CantPizzas = CantPizzas1
            CantBebidas = CantBebidas1
            CantAderezo = CantAderezo1
            Hora = Hora1
            IdCliente = IdCliente1
            IdEmpleado = IdEmpleado1
            Sucursal = Sucursal1
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class

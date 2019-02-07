Imports System.Data.SqlClient
Public Class Funciones
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Validar(ByVal dat As Datos) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("ValidarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@IdCliente", dat.idcliente)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class

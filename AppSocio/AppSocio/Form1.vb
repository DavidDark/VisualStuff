Imports System.Data.SqlClient
Public Class Form1
    Public Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtId.Focus()
    End Sub
    Private Sub nuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nuevoToolStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub consultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles consultarToolStripMenuItem.Click
        Dim Consultar As New ClassLibrarySocio1.Socio
        With Consultar
            .Id = txtId.Text
            If Consultar.SocioConsulta Then
                txtNombre.Text = .Nombre
                txtApellido.Text = .Apellido
                txtDireccion.Text = .Direccion
                txtTelefono.Text = .Telefono
            End If
        End With
    End Sub

    Private Sub agregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles agregarToolStripMenuItem.Click
        Dim Agregar As New ClassLibrarySocio1.Socio
        With Agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
        End With

        If Agregar.SocioAlta Then

        End If
        limpiar()
    End Sub

    Private Sub modificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles modificarToolStripMenuItem.Click
        Dim Modificar As New ClassLibrarySocio1.Socio
        With Modificar
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
            .Id = txtId.Text
        End With

        If Modificar.SocioActualiza Then

        End If
        limpiar()
    End Sub

    Private Sub eliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem.Click
        Dim Eliminar As New ClassLibrarySocio1.Socio
        With Eliminar
            .Id = txtId.Text
        End With

        If Eliminar.SocioBaja Then

        End If
        limpiar()
    End Sub

    Private Sub salirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles salirToolStripMenuItem.Click
        End
    End Sub

    Private Sub txtId_Leave(sender As Object, e As EventArgs) Handles txtId.Leave
        Dim cnx As New SqlConnection("Server=DESKTOP-P6IJOUH\LOCALHOST; database=videoclub; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim NombreSocio1, ApellidoSocio1, DireccionSocio1, TelefonoSocio1 As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            NombreSocio1 = leer(1).ToString
            ApellidoSocio1 = leer(2).ToString
            DireccionSocio1 = leer(3).ToString
            TelefonoSocio1 = leer(4).ToString
            txtNombre.Text = NombreSocio1
            txtApellido.Text = ApellidoSocio1
            txtDireccion.Text = DireccionSocio1
            txtTelefono.Text = TelefonoSocio1
            cnx.Close()
        End If
    End Sub
End Class

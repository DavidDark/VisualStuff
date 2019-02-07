Imports System.Data.OleDb
Public Class Form1
    Dim strFileName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtId.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCalle.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txtEmailEmp.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BUSCAR = "SELECT * FROM persona WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", txtId.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txtNombre.Text = Lectura(1)
            txtApellido.Text = Lectura(2)
            txtCalle.Text = Lectura(3)
            txtColonia.Text = Lectura(4)
            txtCiudad.Text = Lectura(5)
            txtTelefono.Text = Lectura(6)
            txtMovil.Text = Lectura(7)
            txtEmail.Text = Lectura(8)
            txtEmailEmp.Text = Lectura(9)
            picFoto.ImageLocation = Lectura(10)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Agenda")
            txtId.Clear()
            txtId.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Insertar = "Insert Into persona Values (@Id, @Nombre, @Apellido, @CalleYNumero,
@Colonia, @Ciudad, @TelCasa, @TelCel, @EmailPersonal, @EmailTrabajo, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            Cmd.Parameters.AddWithValue("@CalleYNumero", txtCalle.Text)
            Cmd.Parameters.AddWithValue("@Colonia", txtColonia.Text)
            Cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text)
            Cmd.Parameters.AddWithValue("@TelCasa", txtTelefono.Text)
            Cmd.Parameters.AddWithValue("@TelCel", txtMovil.Text)
            Cmd.Parameters.AddWithValue("@EmailPersonal", txtEmail.Text)
            Cmd.Parameters.AddWithValue("@EmailTrabajo", txtEmailEmp.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Registrado")
        Catch ex As Exception
            MsgBox("La Clave a Registrar Ya Existe")
        End Try
        txtId.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCalle.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txtEmailEmp.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Actualizar = "UPDATE persona SET Id=@Id, Nombre=@Nombre, Apellido=@Apellido,
CalleYNumero=@CalleYNumero, Colonia=@Colonia, Ciudad=@Ciudad, TelCasa=@TelCasa,
TelCel=@TelCel, EmailPersonal=@EmailPersonal, EmailTrabajo=@EmailTrabajo,
Fotografia=@Fotografia WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            Cmd.Parameters.AddWithValue("@CalleYNumero", txtCalle.Text)
            Cmd.Parameters.AddWithValue("@Colonia", txtColonia.Text)
            Cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text)
            Cmd.Parameters.AddWithValue("@TelCasa", txtTelefono.Text)
            Cmd.Parameters.AddWithValue("@TelCel", txtMovil.Text)
            Cmd.Parameters.AddWithValue("@EmailPersonal", txtEmail.Text)
            Cmd.Parameters.AddWithValue("@EmailTrabajo", txtEmailEmp.Text)
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Contacto Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtId.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCalle.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txtEmailEmp.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim Eliminar = "DELETE FROM persona WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtId.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCalle.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txtEmailEmp.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        With OpenFileDialog1
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                picFoto.Image = Image.FromFile(strFileName)
                OpenFileDialog1.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class

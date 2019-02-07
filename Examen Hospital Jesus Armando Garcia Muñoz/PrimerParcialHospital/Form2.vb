Imports System.Data.OleDb

Public Class Form2
    Dim strFileName As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f1 As New Form1
        f1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtced.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxesp.Text = ""
        txtcon.Clear()
        picFoto.Image = Nothing
        txtced.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BUSCAR = "SELECT * FROM medico WHERE Cedula=@Cedula"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Cedula", txtced.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txtnom.Text = Lectura(1)
            txtape.Text = Lectura(3)
            cbxesp.Text = Lectura(2)
            txtcon.Text = Lectura(4)
            picFoto.ImageLocation = Lectura(10)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "hospital")
            txtced.Clear()
            txtced.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Insertar = "Insert Into medico Values (@Cedula, @Nombre, @Apellido, @Especialidad, @Consultorio, @Foto)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtced.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtnom.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtape.Text)
            Cmd.Parameters.AddWithValue("@Especialidad", cbxesp.Text)
            Cmd.Parameters.AddWithValue("@Consultorio", txtcon.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Foto", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El medico Fue Registrado")
        Catch ex As Exception
            MsgBox("La Clave a Registrar Ya Existe")
        End Try
        txtced.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxesp.Text = ""
        txtcon.Clear()
        picFoto.Image = Nothing
        txtced.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Actualizar = "UPDATE medico SET Cedula=@Cedula, Nombre=@Nombre, Apellido=@Apellido,
Especialidad=@Especialidad, Consultorio=@Consultorio, Foto=@Foto WHERE Cedula=@Cedula"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtced.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtnom.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtape.Text)
            Cmd.Parameters.AddWithValue("@Especialidad", cbxesp.Text)
            Cmd.Parameters.AddWithValue("@Consultorio", txtcon.Text)
            Cmd.Parameters.AddWithValue("@Foto", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del medico Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtced.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxesp.Text = ""
        txtcon.Clear()
        picFoto.Image = Nothing
        txtced.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim Eliminar = "DELETE FROM medico WHERE Cedula=@Cedula"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtced.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El medico Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtced.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxesp.Text = ""
        txtcon.Clear()
        picFoto.Image = Nothing
        txtced.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
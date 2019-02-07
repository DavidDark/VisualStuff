Imports System.Data.OleDb

Public Class Form3
    Dim strFileName As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpIng.Value = DateTime.Now
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f1 As New Form1
        f1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtss.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxsex.Text = ""
        txtage.Clear()
        dtpIng.ResetText()
        picFoto.Image = Nothing
        txtss.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BUSCAR = "SELECT * FROM paciente WHERE NoSS=@NoSS"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@NoSS", txtss.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txtnom.Text = Lectura(1)
            txtape.Text = Lectura(3)
            cbxsex.Text = Lectura(2)
            txtage.Text = Lectura(4)
            dtpIng.Text = Lectura(5)
            picFoto.ImageLocation = Lectura(10)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "hospital")
            txtss.Clear()
            txtss.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Insertar = "Insert Into paciente Values (@NoSS, @Nombre, @Apellido, @Sexo, @Edad, @Ingreso, @Foto)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@NoSS", txtss.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtnom.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtape.Text)
            Cmd.Parameters.AddWithValue("@Sexo", cbxsex.Text)
            Cmd.Parameters.AddWithValue("@Edad", txtage.Text)
            Cmd.Parameters.AddWithValue("@Ingreso", dtpIng.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Foto", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El paciente Fue Registrado")
        Catch ex As Exception
            MsgBox("La Clave a Registrar Ya Existe")
        End Try
        txtss.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxsex.Text = ""
        txtage.Clear()
        dtpIng.ResetText()
        picFoto.Image = Nothing
        txtss.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Actualizar = "UPDATE paciente SET NoSS=@NoSS, Nombre=@Nombre, Apellido=@Apellido,
Sexo=@Sexo, Edad=@Edad, Ingreso=@Ingreso, Foto=@Foto WHERE NoSS=@NoSS"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@NoSS", txtss.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtnom.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtape.Text)
            Cmd.Parameters.AddWithValue("@Sexo", cbxsex.Text)
            Cmd.Parameters.AddWithValue("@Edad", txtage.Text)
            Cmd.Parameters.AddWithValue("@Ingreso", dtpIng.Text)
            Cmd.Parameters.AddWithValue("@Foto", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del paciente Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtss.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxsex.Text = ""
        txtage.Clear()
        dtpIng.ResetText()
        picFoto.Image = Nothing
        txtss.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim Eliminar = "DELETE FROM paciente WHERE NoSS=@NoSS"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@NoSS", txtss.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El paciente Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txtss.Clear()
        txtnom.Clear()
        txtape.Clear()
        cbxsex.Text = ""
        txtage.Clear()
        dtpIng.ResetText()
        picFoto.Image = Nothing
        txtss.Focus()
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
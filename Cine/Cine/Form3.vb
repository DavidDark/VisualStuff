Public Class Form3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = TextBox1.Text
        direccion = TextBox2.Text
        telefono = TextBox3.Text
        pelicula = ComboBox1.Text
        boletos = ComboBox2.Text
        horario = ComboBox3.Text

        Dim f4 As New Form4
        f4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub
End Class
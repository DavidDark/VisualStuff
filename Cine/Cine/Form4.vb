Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = Module1.nombre
        Label9.Text = Module1.direccion
        Label10.Text = Module1.telefono
        Label11.Text = Module1.pelicula
        Label12.Text = Module1.boletos
        Label13.Text = Module1.horario
    End Sub
End Class
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Text = Module1.nombre
        Label12.Text = Module1.peso
        Label13.Text = Module1.estatura
        Label14.Text = Module1.edad
        Label15.Text = Module1.nacionalidad
        Label16.Text = Module1.sexo
        Label17.Text = Module1.sustancia
        Label18.Text = Module1.indice
        Label19.Text = Module1.condicion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
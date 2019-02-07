Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        imagen1 = Image.FromFile("../../Resources/pinatamickey.png")
        imagen2 = Image.FromFile("../../Resources/globosmickey.png")
        imagen3 = Image.FromFile("../../Resources/pastelmickey.jpg")
        preciopastel = 1400
        Dim f5 As New Form5
        f5.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        imagen1 = Image.FromFile("../../Resources/pinataspiderman.png")
        imagen2 = Image.FromFile("../../Resources/globosspiderman.png")
        imagen3 = Image.FromFile("../../Resources/pastelspiderman.png")
        preciopastel = 1600
        Dim f5 As New Form5
        f5.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        imagen1 = Image.FromFile("../../Resources/pinataminion.png")
        imagen2 = Image.FromFile("../../Resources/globosminion.jpg")
        imagen3 = Image.FromFile("../../Resources/pastelminion.jpg")
        preciopastel = 1800
        Dim f5 As New Form5
        f5.Show()
    End Sub
End Class
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        imagen1 = Image.FromFile("../../Resources/pinataminnie.jpg")
        imagen2 = Image.FromFile("../../Resources/globosminnie.png")
        imagen3 = Image.FromFile("../../Resources/pastelminnie.png")
        preciopastel = 1500
        Dim f5 As New Form5
        f5.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        imagen1 = Image.FromFile("../../Resources/pinataprincesas.jpg")
        imagen2 = Image.FromFile("../../Resources/globosprincesas.png")
        imagen3 = Image.FromFile("../../Resources/pastelprincesas.jpg")
        preciopastel = 2000
        Dim f5 As New Form5
        f5.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        imagen1 = Image.FromFile("../../Resources/pinatadora.png")
        imagen2 = Image.FromFile("../../Resources/globosdora.png")
        imagen3 = Image.FromFile("../../Resources/pasteldora.png")
        preciopastel = 1300
        Dim f5 As New Form5
        f5.Show()
    End Sub
End Class
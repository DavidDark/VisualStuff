Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New Form3
        f3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.BackgroundImage = Image.FromFile("../../Resources/imagen3.jpg")
            Label3.Text = "Una poderosa historia basada en la supervivencia de una familia en el tsunami del 2004 en 
el Oceano Indio. Tras una feroz catastrofe natural durante sus vacasiones los integrantes de la familia se separan.
Pero entre miles de extraños hacen lo imposible por rencontrarse al mismo tiempo que aprenden una leccion de vida sobre
el amor y la bondad."
        End If
        If ComboBox1.SelectedIndex = 1 Then
            PictureBox1.BackgroundImage = Image.FromFile("../../Resources/imagen5.jpg")
            Label3.Text = "Una madre agobiada pide a sus padres que cuiden de sus tres hijos cuando tiene que salir de la ciudad 
para trabajar. Lo que no imagina es que los niños provocarán un sinfín de problemas para sus abuelos, lo cual creará un vinculo
especial entre ellos."
        End If
        If ComboBox1.SelectedIndex = 2 Then
            PictureBox1.BackgroundImage = Image.FromFile("../../Resources/imagen6.jpg")
            Label3.Text = "La película nos cuenta sobre un grupo de niños de la misma familia que se pierden en lo más profundo 
del bosque. Aparecen después de cinco años, aunque no regresarán solos puesto que un oscuro ente sobrenatural desencadenará una 
serie de extraños acontecimientos."
        End If
        If ComboBox1.SelectedIndex = 3 Then
            PictureBox1.BackgroundImage = Image.FromFile("../../Resources/imagen4.jpg")
            Label3.Text = "El polícia Ray Owens es ahora un sheriff del pueblo Sommerton Junction, que está en la frontera entre 
México y Estados Unidos. Cuando un peligroso narcotraficante escapa de un convoy del FBI, Owens debe detenerlo junto a su pequeño 
equipo."
        End If
        If ComboBox1.SelectedIndex = 4 Then
            PictureBox1.BackgroundImage = Image.FromFile("../../Resources/imagen7.jpg")
            Label3.Text = "Debido a una fortuita confusión, Tadeo, un albañil soñador será tomado por un famoso arqueólogo 
y enviado a una expedición a Perú. Con la ayuda de su fiel perro Jeff, una intrépida profesora, un loro mudo y un buscavidas, 
intentarán salvar la mítica Ciudad Pérdida de los Incas de una malvada corporación caza tesoros."
        End If
    End Sub

End Class
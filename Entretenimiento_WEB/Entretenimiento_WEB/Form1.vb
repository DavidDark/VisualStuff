Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "¿Cómo Entrenar A Tu Dragón? 3"
            TextBox2.Text = "Lo que comenzó como la inesperada amistad entre un joven vikingo
y un temible dragón Furia Nocturna se ha convertido en una épica
trilogía que ha recorrido sus vidas. En esta nueva entrega, Hipo
y Desdentao descubrirán finalmente su verdadero destino: para uno,
gobernar Isla Mema junto a Astrid; para el otro, ser el líder de su
especie. Pero, por el camino, deberán poner a prueba los lazos que los
unen, plantando cara a la mayor amenaza que jamás hayan afrontado... y
a la aparición de una Furia Nocturna hembra."
            PictureBox2.BackgroundImage = Image.FromFile("../../Imagenes/CEATD3.jpg")
        End If
        If ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "Espíritu Del Mal"
            TextBox2.Text = "Pyewacket cuenta la historia de Leah, una joven que es forzada a cambiarse
de residencia a una casa en el bosque junto a su inestable madre, después de
la dolorosa muerte de su padre."
            PictureBox2.BackgroundImage = Image.FromFile("../../Imagenes/EDM.jpg")
        End If
        If ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "Mirreyes vs. Godínez"
            TextBox2.Text = "Cuenta la historia de Genaro Rodríguez, un joven godi´n que ha dedicado su vida
a trabajar en Kuri & Sons y a aprender de su jefe Don Francisco Kuri, que lo quiere
como a un hijo ya que sabe que su propio hijo Santiago, un mirrey, quizá demasiado
consentido pero con un gran corazón, no tiene el más mínimo interés por la empresa.
El trabajo impecable de Genaro hace que Don Francisco confíe en él y le otorgue un poder
importante sobre la compañía."
            PictureBox2.BackgroundImage = Image.FromFile("../../Imagenes/MvG.jpg")
        End If
        If ComboBox1.SelectedIndex = 3 Then
            TextBox1.Text = "Glass"
            TextBox2.Text = "Continuando desde donde lo dejó Split, Glass sigue los pasos de David Dunn mientras busca
a la figura superhumana de La Bestia en una serie de encuentros puntuales. En la sombra,
Elijah Price parece emerger como una figura clave que conoce los secretos de ambos. Secuela
de El protegido y Split de M. Night Shyamalan."
            PictureBox2.BackgroundImage = Image.FromFile("../../Imagenes/GLASS.jpg")
        End If
    End Sub
End Class

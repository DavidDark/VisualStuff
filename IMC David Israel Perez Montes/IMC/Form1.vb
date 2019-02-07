Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        peso = Val(pesotex.Text)
        estatura = Val(estaturatex.Text)
        indice = peso / Math.Pow(estatura, 2)

        If indice >= 0 And indice < 18.5 Then
            condicion = ("Infrapeso: Usted se encuentra por debajo del IMC normal.")
        ElseIf indice >= 18.5 And indice <= 25 Then
            condicion = ("Normal: Usted se encuentra en el IMC adecuado para usted.")
        ElseIf indice > 25 Then
            condicion = ("Sobrepeso: Usted tiene sobrepeso.")
        End If

        Module1.nombre = nombretex.Text
        Module1.estatura = estaturatex.Text
        Module1.peso = pesotex.Text
        Module1.edad = ComboBox2.Text
        Module1.nacionalidad = ComboBox1.Text

        If RadioButton1.Checked Then
            Module1.sexo = RadioButton1.Text
        End If
        If RadioButton2.Checked Then
            Module1.sexo = RadioButton2.Text
        End If

        If CheckBox1.Checked Then
            Module1.sustancia = CheckBox1.Text + ", "
        End If
        If CheckBox2.Checked Then
            Module1.sustancia = Module1.sustancia + ", " + CheckBox2.Text
        End If
        If CheckBox3.Checked Then
            Module1.sustancia = Module1.sustancia + ", " + CheckBox3.Text
        End If
        If CheckBox4.Checked Then
            Module1.sustancia = Module1.sustancia + ", " + CheckBox4.Text
        End If

        Dim f2 As New Form2
        f2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

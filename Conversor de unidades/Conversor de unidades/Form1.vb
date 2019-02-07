Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        If RadioButton1.Checked Then 'Abre una condición
            Resultado.Text = (CDbl(Cantidad.Text + 273)) 'Si está seleccionado el RadioButton1, suma 273
        ElseIf RadioButton2.Checked Then
            Resultado.Text = (CDbl(Cantidad.Text - 273)) 'Si está seleccionado el RadioButton2, resta 273
        End If 'Cierra la condición
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        Cantidad.Text = "" 'El cuadro de texto N (El del número) se borra
        Resultado.Text = "0" 'El cuadro de texto R (El del resultado) se pone en 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        End 'Se cierra completamente el programa
    End Sub
End Class

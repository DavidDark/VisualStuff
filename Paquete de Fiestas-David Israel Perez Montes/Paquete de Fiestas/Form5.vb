Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Module1.imagen1
        PictureBox2.BackgroundImage = Module1.imagen2
        PictureBox3.BackgroundImage = Module1.imagen3
        Label3.Text = Module1.preciopastel
        Label6.Text = Module1.total
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            total = total + 300
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            total = total - 300
        End If
        Label6.Text = Module1.total
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            total = total + 450
        ElseIf CheckBox2.CheckState = CheckState.Unchecked Then
            total = total - 450
        End If
        Label6.Text = Module1.total
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = CheckState.Checked Then
            total = total + preciopastel
        ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
            total = total - preciopastel
        End If
        Label6.Text = Module1.total
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = CheckState.Checked Then
            total = total + 500
        ElseIf CheckBox4.CheckState = CheckState.Unchecked Then
            total = total - 500
        End If
        Label6.Text = Module1.total
    End Sub
End Class
Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Bukan Integer")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Masuskkan Nilai 0-100")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian <= 50 Then
            picImage.Image = Image.FromFile("Assets\1.jpg")
        ElseIf nilaiUjian <= 75 Then
            picImage.Image = Image.FromFile("Assets\2.jpg")
        Else
            picImage.Image = Image.FromFile("Assets\3.jpg")
        End If
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

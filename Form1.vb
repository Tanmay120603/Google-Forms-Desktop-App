Public Class Form1
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnView.KeyPress
        If Asc(e.KeyChar) = 22 Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub btnCreate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnCreate.KeyPress
        If Asc(e.KeyChar) = 3 Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class


Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ADMIN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class
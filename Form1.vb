Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myprogress.Increment(1)
        percentage.Text = Convert.ToString(myprogress.Value) + "%"
        If myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New home
            log.Show()
            Timer1.Enabled = False

        End If


    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles myprogress.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub percentage_Click(sender As Object, e As EventArgs) Handles percentage.Click

    End Sub
End Class

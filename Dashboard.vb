Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Private Sub countbooks()
        Dim bn As Integer
        con.Open()
        Dim query = "select sum(quantity) from booktbl"
        Dim cmd = New SqlCommand(query, con)
        bn = cmd.ExecuteScalar
        bknum.Text = bn
        con.Close()
    End Sub

    Private Sub countuser()

        Dim cn As Integer
        con.Open()
        Dim query = "select count(*) from userstbl"
        Dim cmd = New SqlCommand(query, con)
        cn = cmd.ExecuteScalar
        ulbl.Text = cn
        con.Close()

    End Sub


    Private Sub sumamount()
        Try
            Dim an As Double
            con.Open()
            Dim query = "select sum(total) from customer1"
            Dim cmd = New SqlCommand(query, con)
            an = cmd.ExecuteScalar
            am_lbl.Text = " Total Rs=" & an
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countbooks()
        countuser()
        sumamount()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Book.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        user.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        setting.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        ADMIN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        category.Show()
        Me.Hide()
    End Sub
End Class
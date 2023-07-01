Imports System.Data.SqlClient
Public Class LOGIN
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            If unametb.Text = "" Or passtb.Text = "" Then
                MsgBox("Enter Username And Password")
            Else
                con.Open()
                Dim query = "select * from userstbl where userNAME='" & unametb.Text & "' and PASSWORD ='" & passtb.Text & "' "
                cmd = New SqlCommand(query, con)
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet()
                sda.Fill(ds)
                Dim a As Integer
                a = ds.Tables(0).Rows.Count

                If a = 0 Then
                    MsgBox("wrong username and password")

                Else
                    Dim BILL = New bills
                    BILL.USERNAME = unametb.Text
                    'Me.Hide()
                    BILL.Show()
                    Me.Hide()
                    '  Me.Hide()
                    'unametb.Text = ""
                    passtb.Text = ""
                End If
                con.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                passtb.UseSystemPasswordChar = False
            Else
                passtb.UseSystemPasswordChar = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        ADMIN_LOGIN.Show()
        Me.Hide()
        ' unametb.Text = ""
        passtb.Text = ""

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        home.Show()
        Me.Hide()

    End Sub
End Class
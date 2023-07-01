Imports System.Data.SqlClient

Public Class ADMIN_LOGIN
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If anametb.Text = "" Or apasstb.Text = "" Then
            MsgBox("Enter Username And Password")
        Else
            con.Open()
            Dim query = "select * from admin where NAME='" & anametb.Text & "' and password ='" & apasstb.Text & "' "
            cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("wrong username and password")

            Else

                bills.USERNAME = anametb.Text
                Me.Hide()
                Book.Show()
                anametb.Text = ""
                apasstb.Text = ""
            End If





            con.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            apasstb.UseSystemPasswordChar = False
        Else
            apasstb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ADMIN_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
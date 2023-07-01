Imports System.Data.SqlClient

Public Class category
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Private Sub reset()
        cattb.Text = ""
    End Sub
    Public Sub populatecat()
        Try
            con.Open()
            Dim query = "select * from category"
            Dim adopter As SqlDataAdapter
            adopter = New SqlDataAdapter(query, con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adopter)
            Dim ds As DataSet
            ds = New DataSet
            adopter.Fill(ds)
            catdgv.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Book.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            If cattb.Text = "" Then
                MsgBox("missing informations")
            Else
                con.Open()
                Dim query As String
                query = "insert into category values ('" & cattb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("category saved succesfully")
                con.Close()
                populatecat()
                reset()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatecat()
    End Sub
    Dim key = 0
    Private Sub catdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles catdgv.CellMouseClick
        Try
            Dim row As DataGridViewRow = catdgv.Rows(e.RowIndex)
            cattb.Text = row.Cells(1).Value.ToString


            If cattb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Try
            If key = 0 Then
                MsgBox("select the user to be deleted")
            Else
                con.Open()
                Dim query As String
                query = "delete from category where cat_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" deleted succesfully")
                con.Close()
                populatecat()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click

        reset()
    End Sub

    Private Sub uptb_Click(sender As Object, e As EventArgs) Handles uptb.Click
        Try
            If cattb.Text = "" Then
                MsgBox("missing informations")
            Else
                con.Open()
                Dim query As String
                query = "update  category set cat_NAME= '" & cattb.Text & "' where cat_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" updated succesfully")
                con.Close()
                populatecat()
                reset()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        user.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        setting.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class

Imports System.Data.SqlClient

Public Class Book
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")

    Private Sub populate()
        Try
            con.Open()
            Dim query = "select * from booktbl"
            Dim adopter As SqlDataAdapter
            adopter = New SqlDataAdapter(query, con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adopter)
            Dim ds As DataSet
            ds = New DataSet
            adopter.Fill(ds)
            bookDGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub filter()
        Try
            con.Open()
            Dim query = "select * from booktbl where category='" & filtercb.SelectedValue.ToString() & "'"
            Dim adopter As SqlDataAdapter
            adopter = New SqlDataAdapter(query, con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adopter)
            Dim ds As DataSet
            ds = New DataSet
            adopter.Fill(ds)
            bookDGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub display()
        Try
            con.Open()
            Dim query = "SELECT * FROM category"
            Dim cmd = New SqlCommand(query, con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            con.Close()

            Dim bindingSource As New BindingSource()
            bindingSource.DataSource = tbl

            catbox.DataSource = bindingSource
            catbox.DisplayMember = "cat_name"
            catbox.ValueMember = "cat_name"

        Catch ex As Exception
            ' Handle the exception appropriately (e.g., display an error message)
        End Try
    End Sub


    Private Sub reset()
        Try
            bnametb.Text = ""
            authortb.Text = ""
            qtytb.Text = ""
            B_pricetb.Text = ""
            S_pricetb.Text = ""
            catbox.SelectedIndex = -1
            key = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub filtercategorys()
        Try
            con.Open()
            Dim query = "select * from category"
            Dim cmd = New SqlCommand(query, con)
            Dim tbl = New DataTable
            Dim adapter = New SqlDataAdapter(cmd)
            adapter.Fill(tbl)
            filtercb.DataSource = tbl
            category.populatecat()
            filtercb.DisplayMember = "cat_name"
            filtercb.ValueMember = "cat_name"
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            If bnametb.Text = "" Or authortb.Text = " " Or qtytb.Text = "" Or B_pricetb.Text = "" Or S_pricetb.Text = "" Or catbox.SelectedIndex = -1 Then
                MsgBox("missing informations")

            Else
                con.Open()
                Dim query As String
                query = "insert into booktbl values ('" & bnametb.Text & "','" & authortb.Text & "','" & catbox.SelectedValue.ToString() & "','" & qtytb.Text & "','" & B_pricetb.Text & "','" & S_pricetb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book saved succesfully")
                con.Close()
                populate()
                reset()

            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        reset()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Try
            If bnametb.Text = "" Or authortb.Text = " " Or qtytb.Text = "" Or B_pricetb.Text = "" Or S_pricetb.Text = "" Or catbox.SelectedIndex = -1 Then
                MsgBox("missing informations")
            Else
                con.Open()
                Dim query As String
                query = "update  BOOKtbl set BOOK_NAME= '" & bnametb.Text & "',BOOK_author='" & authortb.Text & "',Category='" & catbox.SelectedValue & "',quantity='" & qtytb.Text & "',B_price='" & B_pricetb.Text & "',s_price='" & S_pricetb.Text & "'   where  book_id=" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" Book Updated Succesfully")
                con.Close()
                populate()
                reset()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim key = 0
    Private Sub bookDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles bookDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = bookDGV.Rows(e.RowIndex)
            bnametb.Text = row.Cells(1).Value.ToString
            authortb.Text = row.Cells(2).Value.ToString
            catbox.SelectedValue = row.Cells(3).Value.ToString
            qtytb.Text = row.Cells(4).Value.ToString
            B_pricetb.Text = row.Cells(5).Value.ToString
            S_pricetb.Text = row.Cells(6).Value.ToString

            If bnametb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        'categorys()
        category.populatecat()
        display()
        filtercategorys()
        ' PopulateComboBox()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Try
            If key = 0 Then
                MsgBox("select the BOOK to be deleted")
            Else
                con.Open()
                Dim query As String
                query = "delete from booktbl  where BOOK_ID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book deleted succesfully")
                con.Close()
                populate()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles filtercb.SelectionChangeCommitted
        filter()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        populate()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        ' Me.Hide()
        'user.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        user.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub qtytb_TextChanged(sender As Object, e As EventArgs) Handles qtytb.TextChanged

    End Sub

    Private Sub qtytb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtytb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Prevent non-numeric input
        End If
    End Sub

    Private Sub bookDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookDGV.CellContentClick

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub S_pricetb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub filtercb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub B_pricetb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub catTB_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub authortb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bnametb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click_1(sender As Object, e As EventArgs)
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        user.Show()
        Me.Hide()

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        setting.Show()
        Me.Hide()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        category.Show()
        Me.Hide()

    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click_1(sender As Object, e As EventArgs) Handles Label12.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub filtercb_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles filtercb.SelectedIndexChanged

    End Sub

    Private Sub B_pricetb_TextChanged_1(sender As Object, e As EventArgs) Handles B_pricetb.TextChanged

    End Sub

    Private Sub S_pricetb_TextChanged_1(sender As Object, e As EventArgs) Handles S_pricetb.TextChanged

    End Sub

    Private Sub B_pricetb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles B_pricetb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Prevent non-numeric and non-decimal input
        End If
    End Sub

    Private Sub S_pricetb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles S_pricetb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Prevent non-numeric and non-decimal input
        End If
    End Sub
End Class
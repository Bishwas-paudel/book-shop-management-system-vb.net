Imports System.Data.SqlClient

Public Class user
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Private Sub populate()
        con.Open()
        Dim query = "select * from userstbl"
        Dim adopter As SqlDataAdapter
        adopter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adopter)
        Dim ds As DataSet
        ds = New DataSet
        adopter.Fill(ds)
        userDGV.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    Private Sub reset()
        unametb.Text = ""
        phonetb.Text = ""
        addresstb.Text = ""
        usnametb.Text = ""
        passwordtb.Text = ""
        key = 0
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If unametb.Text = "" Or phonetb.Text = " " Or addresstb.Text = "" Or usnametb.Text = "" Or passwordtb.Text = "" Then
            MsgBox("missing informations")
        Else
            con.Open()
            Dim query As String
            query = "insert into userstbl values ('" & unametb.Text & "','" & phonetb.Text & "','" & addresstb.Text & "','" & usnametb.Text & "','" & passwordtb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("user saved succesfully")
            con.Close()
            populate()
            reset()

        End If
    End Sub
    Private Sub unametb_TextChanged(sender As Object, e As EventArgs) Handles unametb.TextChanged
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub
    Dim key = 0
    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If key = 0 Then
            MsgBox("select the user to be deleted")
        Else
            con.Open()
            Dim query As String
            query = "delete from userstbl  where id=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("user deleted succesfully")
            con.Close()
            populate()

        End If
    End Sub

    Private Sub userDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles userDGV.CellMouseClick
        Dim row As DataGridViewRow = userDGV.Rows(e.RowIndex)
        unametb.Text = row.Cells(1).Value.ToString
        phonetb.Text = row.Cells(2).Value.ToString
        addresstb.Text = row.Cells(3).Value.ToString
        usnametb.Text = row.Cells(4).Value.ToString
        passwordtb.Text = row.Cells(5).Value.ToString

        If unametb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        reset()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If unametb.Text = "" Or phonetb.Text = " " Or addresstb.Text = "" Or passwordtb.Text = "" Then
            MsgBox("missing informations")
        Else
            con.Open()
            Dim query As String
            query = "update  userstbl set NAME= '" & unametb.Text & "',PHONE='" & phonetb.Text & "',ADDRESS='" & addresstb.Text & "',USERNAME='" & usnametb.Text & "',PASSWORD='" & passwordtb.Text & "'   where id=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("user updated succesfully")
            con.Close()
            populate()
            reset()

        End If
    End Sub

    Private Sub bookuserDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userDGV.CellContentClick, userDGV.CellContentClick, userDGV.CellContentClick

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Book.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub phonetb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phonetb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Prevent non-numeric input
        End If
    End Sub

    Private Sub phonetb_TextChanged(sender As Object, e As EventArgs) Handles phonetb.TextChanged
        Dim userInput As String = phonetb.Text.Trim()
        Dim digitsOnly As String = New String(userInput.Where(Function(c) Char.IsDigit(c)).ToArray())

        If Not String.IsNullOrEmpty(phonetb.Text) Then
            If digitsOnly.Length > 10 Then
                ' Remove extra digits if more than 10
                digitsOnly = digitsOnly.Substring(0, 10)
                phonetb.Text = digitsOnly
                'ElseIf digitsOnly.Length < 10 Then
                ' Suggest to complete if less than 10
                '   MessageBox.Show("Please enter a 10-digit phone number.", "Incomplete Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

        setting.Show()
        Me.Hide()

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        category.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

        home.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class
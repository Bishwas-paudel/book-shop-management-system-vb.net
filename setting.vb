Imports System.Data.SqlClient

Public Class setting
    Dim query As String
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")

    Dim pass As String = ADMIN_LOGIN.apasstb.Text
    Dim uname As String = ADMIN_LOGIN.anametb.Text
    Private Sub cpasstb_TextChanged(sender As Object, e As EventArgs) Handles cpasstb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim textBoxValue As String = cpasstb.Text

            ' Check if any of the text boxes are empty
            If cpasstb.Text = "" Or npasstb.Text = "" Or rntb.Text = "" Then
                MsgBox("Missing information")
            Else
                Try
                    con.Open()

                    ' Retrieve the password from the database for comparison
                    Dim query As String = "SELECT Password FROM ADMIN"
                    Dim com As New SqlCommand(query, con)
                    Dim databaseValue As String = DirectCast(com.ExecuteScalar(), String)

                    ' Compare the old password with the database value
                    If textBoxValue <> databaseValue Then
                        MsgBox("Invalid Old Password")
                    ElseIf npasstb.Text <> rntb.Text Then
                        MsgBox("Passwords do not match")
                    Else
                        ' Update the password in the database
                        ' query = "UPDATE ADMIN SET Password = @NewPassword"
                        query = "UPDATE ADMIN SET Password = '" & npasstb.Text & "'"
                        Dim cmd As New SqlCommand(query, con)
                        ' cmd.Parameters.AddWithValue("@NewPassword", renpasstb.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Password updated successfully")
                        reset()
                    End If

                    con.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        user.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Book.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        home.Show()
    End Sub
    Private Sub reset()
        cpasstb.Text = ""
        npasstb.Text = ""
        rntb.Text = ""

    End Sub
    Private Sub cantb_Click(sender As Object, e As EventArgs) Handles cantb.Click
        reset()
    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles cantb.MouseClick
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
        category.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class
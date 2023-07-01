Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.AxHost

Public Class bills

    Public Property USERNAME As String
    Dim con As New SqlConnection("Data Source=LAPTOP-LNLQIP35\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Dim key = 0, stock = 0, I = 0, GRDTOTAL = 0
    ' Dim username1 As String = USERNAME

    Private Sub populate()
        Try


            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query = "select book_id,book_name,book_author,category,quantity,s_price as price,b_price from booktbl "
            Dim adopter As SqlDataAdapter
            adopter = New SqlDataAdapter(query, con)
            Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adopter)
            Dim ds As DataSet
            ds = New DataSet
            adopter.Fill(ds)
            ds.Tables(0).Columns.Remove("b_price")
            bookdgv.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub reset2()
        key = 0
        qtytb.Text = ""
        ptb.Text = ""
        cnametb.Text = ""
        bnametb.Text = ""

    End Sub
    ' Private Sub populate2()
    '    con.Open()
    'Dim query = "select ID ,BOOK,QUANTITY,PRICE,TOTAL from BTABLE"
    'Dim adopter As SqlDataAdapter
    '   adopter = New SqlDataAdapter(query, con)
    'Dim builder As SqlCommandBuilder
    '   builder = New SqlCommandBuilder(adopter)
    'Dim ds As DataSet
    '   ds = New DataSet
    '  adopter.Fill(ds)
    ' billdgv.DataSource = ds.Tables(0)
    'con.Close()
    'End Sub
    Private Sub bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' USERlbl.Text = USERNAME
        populate()
        USERlbl.Text = USERNAME
        ' calculateProfit()
    End Sub

    Private Sub bookdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles bookdgv.CellMouseClick

    End Sub


    Private Sub TLBL_Click(sender As Object, e As EventArgs) Handles TLBL.Click

    End Sub

    Private Sub USER_Click(sender As Object, e As EventArgs) Handles USERlbl.Click

    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        reset2()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim lineHeight As Integer = 20
        Dim currentY As Integer = startY

        ' Set the background color
        e.Graphics.FillRectangle(Brushes.LightPink, e.PageBounds)

        ' Draw the bookshop title
        Dim bookshopTitle As String = "Bookshop"
        Dim titleFont As New Font("Arial", 20, FontStyle.Bold)
        Dim titleSize As SizeF = e.Graphics.MeasureString(bookshopTitle, titleFont)
        Dim titleX As Integer = CInt((e.PageBounds.Width - titleSize.Width) / 2)
        e.Graphics.DrawString(bookshopTitle, titleFont, brush, titleX, currentY)

        currentY += CInt(titleSize.Height) + lineHeight

        ' Draw customer and date information
        e.Graphics.DrawString("Customer: " & cnametb.Text, font, brush, startX, currentY)
        e.Graphics.DrawString("Date: " & DateTime.Today.ToString("dd/MM/yyyy"), font, brush, startX, currentY + lineHeight)

        ' Draw the "Entered by" on the right side
        Dim enteredByX As Integer = e.PageBounds.Width - startX - e.Graphics.MeasureString("Entered by: " & user.Text, font).Width
        e.Graphics.DrawString("Entered by: " & user.Text, font, brush, enteredByX, currentY)

        currentY += 2 * lineHeight

        ' Center and draw the DataGridView content
        Dim dgvWidth As Integer = billdgv.Width
        Dim dgvHeight As Integer = billdgv.Height
        Dim dgvStartX As Integer = CInt((e.PageBounds.Width - dgvWidth) / 2)
        Dim dgvStartY As Integer = currentY

        Using bm As New Bitmap(dgvWidth, dgvHeight)
            billdgv.DrawToBitmap(bm, New Rectangle(0, 0, dgvWidth, dgvHeight))
            e.Graphics.DrawImage(bm, dgvStartX, dgvStartY)
        End Using

        currentY += dgvHeight + lineHeight

        ' Draw the total amount on the right side
        Dim totalAmountText As String = "Total amount: Rs " & GRDTOTAL.ToString()
        Dim totalAmountX As Integer = e.PageBounds.Width - startX - e.Graphics.MeasureString(totalAmountText, New Font("Arial", 15, FontStyle.Bold)).Width
        e.Graphics.DrawString(totalAmountText, New Font("Arial", 15, FontStyle.Bold), brush, totalAmountX, currentY)

        currentY += 2 * lineHeight

        ' Draw the "Thanks" message
        Dim thankYouMessage As String = "Thank you, visit again (Not returnable)"
        Dim thankYouSize As SizeF = e.Graphics.MeasureString(thankYouMessage, font)
        Dim thankYouX As Integer = CInt((e.PageBounds.Width - thankYouSize.Width) / 2)
        Dim thankYouY As Integer = e.PageBounds.Height - CInt(thankYouSize.Height) - lineHeight
        e.Graphics.DrawString(thankYouMessage, font, brush, thankYouX, thankYouY)

    End Sub




    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub update1()
        Try


            Dim newqty = stock - Convert.ToInt32(qtytb.Text)

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query As String
            query = "update  BOOKtbl set quantity='" & newqty & "' where  book_id=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        addbill()
        '  PrintDocument1.Print()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub addbBtn_Click(sender As Object, e As EventArgs) Handles addbBtn.Click
        Try


            If bnametb.Text = "" Then
                MsgBox("SELECT THE BOOK")
            ElseIf ptb.Text = "" Or qtytb.Text = "" Then
                MsgBox("ENTER QUANTITY")
            ElseIf Convert.ToInt32(qtytb.Text) > stock Then
                MessageBox.Show("insufficient books.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else




                Dim RRUM As Integer = billdgv.Rows.Add()
                I = I + 1
                Dim TOTAL As Double = Convert.ToDouble(qtytb.Text) * Convert.ToDouble(ptb.Text)
                billdgv.Rows.Item(RRUM).Cells("COLUMN1").Value = I
                billdgv.Rows.Item(RRUM).Cells("COLUMN2").Value = bnametb.Text
                billdgv.Rows.Item(RRUM).Cells("COLUMN3").Value = ptb.Text
                billdgv.Rows.Item(RRUM).Cells("COLUMN4").Value = qtytb.Text
                billdgv.Rows.Item(RRUM).Cells("COLUMN5").Value = TOTAL
                GRDTOTAL = GRDTOTAL + TOTAL
                Dim TOT As String
                TOT = "TOTAL =  RS" + Convert.ToString(GRDTOTAL)
                TLBL.Text = TOT
                '   update1()
                'populate()
                ' update1()
                ' Reset()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bpricecalc()


        'Dim RRUM As Integer = billdgv.Rows.Add()
        '       I = I + 1
        '      Dim TOTAL As Double = Convert.ToDouble(qtytb.Text) * Convert.ToDouble(ptb.Text)
        '     billdgv.Rows.Item(RRUM).Cells("COLUMN1").Value = ""
        '    billdgv.Rows.Item(RRUM).Cells("COLUMN2").Value = ""
        '   billdgv.Rows.Item(RRUM).Cells("COLUMN3").Value = ""
        '  billdgv.Rows.Item(RRUM).Cells("COLUMN4").Value = ""
        ' billdgv.Rows.Item(RRUM).Cells("COLUMN5").Value = ""
        'GRDTOTAL = GRDTOTAL + TOTAL
        'Dim TOT As String
        'TOT = "TOTAL =  RS" + Convert.ToString(GRDTOTAL)
        'TLBL.Text = ""


    End Sub

    Private Sub qtytb_TextChanged(sender As Object, e As EventArgs) Handles qtytb.TextChanged

    End Sub

    Private Sub qtytb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtytb.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Prevent non-numeric and non-decimal input
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        GRDTOTAL = 0
        TLBL.Text = 0
        billdgv.Rows.Clear()
        ' billdgv.DataSource = Nothing
        '  billdgv.Refresh()
        'bpricecalc()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        ' printDocument()
    End Sub

    Private Sub addbill()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query As String
            I = I + 1
            query = "insert into customer1 values ('" & USERNAME & "','" & cnametb.Text & "','" & DateTime.Today.Date & "'," & GRDTOTAL & ")"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            '   MsgBox("Bill saved succesfully ")
            con.Close()
            'billdgv.Rows.Clear()
            'GRDTOTAL = 0
            ' TLBL.Text = "total"
            update1()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' billdgv.Rows.Clear()
        ' GRDTOTAL = 0
        '  TLBL.Text = "total"

        'update1()
    End Sub

    Private Sub bookdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookdgv.CellContentClick
        Try
            Dim row As DataGridViewRow = bookdgv.Rows(e.RowIndex)
            bnametb.Text = row.Cells(1).Value.ToString
            ptb.Text = row.Cells(5).Value.ToString

            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            If bnametb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub calculateProfit()
    'Dim totalCost As Double = 0
    '   Dim totalRevenue As Double = 0
    '  Dim totalProfit As Double = 0
    '
    'For Each row As DataGridViewRow In billdgv.Rows
    'Dim quantity As Integer = Convert.ToInt32(row.Cells("COLUMN4").Value)
    'Dim price As Double = Convert.ToDouble(row.Cells("COLUMN3").Value)
    'Dim total As Double = Convert.ToDouble(row.Cells("COLUMN5").Value)
    '
    '   totalCost += quantity * Convert.ToDouble(row.Cells("b_price").Value)
    '  totalRevenue += total
    'Next
    '
    'totalProfit = totalRevenue - totalCost
    '
    '       MsgBox("Total Cost: " & totalCost.ToString("C") & vbCrLf &
    '         "Total Revenue: " & totalRevenue.ToString("C") & vbCrLf &
    '        "Total Profit: " & totalProfit.ToString("C"))
    ' End Sub
    Private Sub printDocument(sender As Object, e As PrintPageEventArgs)

    End Sub

End Class


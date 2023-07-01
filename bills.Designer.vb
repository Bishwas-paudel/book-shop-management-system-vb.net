<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bills
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bills))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bnametb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cnametb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.qtytb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ptb = New System.Windows.Forms.TextBox()
        Me.addbBtn = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bookdgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.TLBL = New System.Windows.Forms.Label()
        Me.billdgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERlbl = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.billdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label12.Location = New System.Drawing.Point(71, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 34)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Logout"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 798)
        Me.Panel2.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(6, 743)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(232, 49)
        Me.Panel6.TabIndex = 36
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(9, -2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(92, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 27)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "BOOKSHOP"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(423, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BOOKSHOP SOFTWARE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(512, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'bnametb
        '
        Me.bnametb.Enabled = False
        Me.bnametb.Location = New System.Drawing.Point(49, 147)
        Me.bnametb.Name = "bnametb"
        Me.bnametb.Size = New System.Drawing.Size(118, 32)
        Me.bnametb.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(25, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BooK Name"
        '
        'cnametb
        '
        Me.cnametb.Location = New System.Drawing.Point(41, 252)
        Me.cnametb.Name = "cnametb"
        Me.cnametb.Size = New System.Drawing.Size(144, 32)
        Me.cnametb.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(16, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Customer name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(256, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Quantity"
        '
        'qtytb
        '
        Me.qtytb.Location = New System.Drawing.Point(256, 147)
        Me.qtytb.Name = "qtytb"
        Me.qtytb.Size = New System.Drawing.Size(111, 32)
        Me.qtytb.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(276, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 27)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Price"
        '
        'ptb
        '
        Me.ptb.Enabled = False
        Me.ptb.Location = New System.Drawing.Point(256, 252)
        Me.ptb.Name = "ptb"
        Me.ptb.Size = New System.Drawing.Size(111, 32)
        Me.ptb.TabIndex = 21
        '
        'addbBtn
        '
        Me.addbBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.addbBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.addbBtn.Location = New System.Drawing.Point(59, 301)
        Me.addbBtn.Name = "addbBtn"
        Me.addbBtn.Size = New System.Drawing.Size(126, 37)
        Me.addbBtn.TabIndex = 23
        Me.addbBtn.Text = "Add to Bill"
        Me.addbBtn.UseVisualStyleBackColor = False
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.resetbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.resetbtn.Location = New System.Drawing.Point(241, 301)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(126, 37)
        Me.resetbtn.TabIndex = 25
        Me.resetbtn.Text = "Reset "
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(159, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 27)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Book List"
        '
        'printbtn
        '
        Me.printbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.printbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.printbtn.Location = New System.Drawing.Point(684, 638)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(112, 57)
        Me.printbtn.TabIndex = 29
        Me.printbtn.Text = "Print"
        Me.printbtn.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(1117, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 37)
        Me.Label13.TabIndex = 14
        '
        'bookdgv
        '
        Me.bookdgv.AllowUserToAddRows = False
        Me.bookdgv.AllowUserToDeleteRows = False
        Me.bookdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bookdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bookdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bookdgv.Location = New System.Drawing.Point(9, 427)
        Me.bookdgv.Name = "bookdgv"
        Me.bookdgv.ReadOnly = True
        Me.bookdgv.RowHeadersWidth = 51
        Me.bookdgv.RowTemplate.Height = 24
        Me.bookdgv.Size = New System.Drawing.Size(541, 354)
        Me.bookdgv.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dt)
        Me.Panel1.Controls.Add(Me.TLBL)
        Me.Panel1.Controls.Add(Me.billdgv)
        Me.Panel1.Controls.Add(Me.USERlbl)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.bookdgv)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.printbtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.resetbtn)
        Me.Panel1.Controls.Add(Me.addbBtn)
        Me.Panel1.Controls.Add(Me.ptb)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.qtytb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cnametb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bnametb)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(233, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 811)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(993, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 47)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 23)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "SELECT THE BOOKS"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(881, 6)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(200, 23)
        Me.dt.TabIndex = 38
        '
        'TLBL
        '
        Me.TLBL.AutoSize = True
        Me.TLBL.BackColor = System.Drawing.Color.Transparent
        Me.TLBL.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLBL.ForeColor = System.Drawing.Color.Black
        Me.TLBL.Location = New System.Drawing.Point(787, 527)
        Me.TLBL.Name = "TLBL"
        Me.TLBL.Size = New System.Drawing.Size(68, 27)
        Me.TLBL.TabIndex = 33
        Me.TLBL.Text = "Total"
        '
        'billdgv
        '
        Me.billdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billdgv.BackgroundColor = System.Drawing.Color.MistyRose
        Me.billdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.billdgv.GridColor = System.Drawing.Color.PaleVioletRed
        Me.billdgv.Location = New System.Drawing.Point(604, 147)
        Me.billdgv.Name = "billdgv"
        Me.billdgv.RowHeadersWidth = 51
        Me.billdgv.RowTemplate.Height = 24
        Me.billdgv.Size = New System.Drawing.Size(537, 459)
        Me.billdgv.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "ITEM NO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "BOOK"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'USERlbl
        '
        Me.USERlbl.AutoSize = True
        Me.USERlbl.BackColor = System.Drawing.Color.SeaShell
        Me.USERlbl.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERlbl.ForeColor = System.Drawing.Color.Crimson
        Me.USERlbl.Location = New System.Drawing.Point(53, 12)
        Me.USERlbl.Name = "USERlbl"
        Me.USERlbl.Size = New System.Drawing.Size(71, 34)
        Me.USERlbl.TabIndex = 37
        Me.USERlbl.Text = "user"
        Me.USERlbl.UseMnemonic = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(806, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 27)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Books Bill"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'bills
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1507, 813)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bills"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.billdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bnametb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cnametb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents qtytb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ptb As TextBox
    Friend WithEvents addbBtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents printbtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents bookdgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents USERlbl As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TLBL As Label
    Friend WithEvents billdgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class

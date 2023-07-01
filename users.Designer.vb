<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bookDGV = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.S_pricetb = New System.Windows.Forms.TextBox()
        Me.filtercb = New System.Windows.Forms.ComboBox()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.B_pricetb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qtytb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.catbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.authortb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnametb = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.bookDGV)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.S_pricetb)
        Me.Panel1.Controls.Add(Me.filtercb)
        Me.Panel1.Controls.Add(Me.refreshbtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.resetbtn)
        Me.Panel1.Controls.Add(Me.deletebtn)
        Me.Panel1.Controls.Add(Me.editbtn)
        Me.Panel1.Controls.Add(Me.savebtn)
        Me.Panel1.Controls.Add(Me.B_pricetb)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.qtytb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.catbox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.authortb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bnametb)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Location = New System.Drawing.Point(238, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 814)
        Me.Panel1.TabIndex = 2
        '
        'bookDGV
        '
        Me.bookDGV.AllowUserToAddRows = False
        Me.bookDGV.AllowUserToDeleteRows = False
        Me.bookDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bookDGV.BackgroundColor = System.Drawing.Color.LightBlue
        Me.bookDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bookDGV.GridColor = System.Drawing.Color.SpringGreen
        Me.bookDGV.Location = New System.Drawing.Point(3, 467)
        Me.bookDGV.Name = "bookDGV"
        Me.bookDGV.ReadOnly = True
        Me.bookDGV.RowHeadersWidth = 51
        Me.bookDGV.RowTemplate.Height = 24
        Me.bookDGV.Size = New System.Drawing.Size(1262, 347)
        Me.bookDGV.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(983, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 27)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = " S_Price"
        '
        'S_pricetb
        '
        Me.S_pricetb.Location = New System.Drawing.Point(979, 192)
        Me.S_pricetb.Name = "S_pricetb"
        Me.S_pricetb.Size = New System.Drawing.Size(114, 32)
        Me.S_pricetb.TabIndex = 31
        '
        'filtercb
        '
        Me.filtercb.FormattingEnabled = True
        Me.filtercb.Items.AddRange(New Object() {"Mathematics", "Programming", "novels", "Networking", "Physics", "Account ", "English", ""})
        Me.filtercb.Location = New System.Drawing.Point(406, 316)
        Me.filtercb.Name = "filtercb"
        Me.filtercb.Size = New System.Drawing.Size(199, 31)
        Me.filtercb.TabIndex = 28
        Me.filtercb.Text = "Filter By Category"
        '
        'refreshbtn
        '
        Me.refreshbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.refreshbtn.Location = New System.Drawing.Point(629, 314)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(99, 33)
        Me.refreshbtn.TabIndex = 29
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(526, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 27)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Book List"
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.resetbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.resetbtn.Location = New System.Drawing.Point(701, 251)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(126, 37)
        Me.resetbtn.TabIndex = 25
        Me.resetbtn.Text = "Reset "
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.deletebtn.ForeColor = System.Drawing.SystemColors.Control
        Me.deletebtn.Location = New System.Drawing.Point(540, 251)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(126, 37)
        Me.deletebtn.TabIndex = 24
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.editbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.editbtn.Location = New System.Drawing.Point(395, 251)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(126, 37)
        Me.editbtn.TabIndex = 23
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.savebtn.ForeColor = System.Drawing.SystemColors.Control
        Me.savebtn.Location = New System.Drawing.Point(240, 251)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(126, 37)
        Me.savebtn.TabIndex = 22
        Me.savebtn.Text = "save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'B_pricetb
        '
        Me.B_pricetb.Location = New System.Drawing.Point(821, 192)
        Me.B_pricetb.Name = "B_pricetb"
        Me.B_pricetb.Size = New System.Drawing.Size(117, 32)
        Me.B_pricetb.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(816, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 27)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = " B_Price"
        '
        'qtytb
        '
        Me.qtytb.Location = New System.Drawing.Point(629, 192)
        Me.qtytb.Name = "qtytb"
        Me.qtytb.Size = New System.Drawing.Size(131, 32)
        Me.qtytb.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(638, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Quantity"
        '
        'catbox
        '
        Me.catbox.FormattingEnabled = True
        Me.catbox.Items.AddRange(New Object() {"Mathematics", "Programming", "novels", "Networking", "Physics", "Account ", "English"})
        Me.catbox.Location = New System.Drawing.Point(448, 194)
        Me.catbox.Name = "catbox"
        Me.catbox.Size = New System.Drawing.Size(132, 31)
        Me.catbox.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(443, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 27)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categories"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(264, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Author"
        '
        'authortb
        '
        Me.authortb.Location = New System.Drawing.Point(240, 193)
        Me.authortb.Name = "authortb"
        Me.authortb.Size = New System.Drawing.Size(164, 32)
        Me.authortb.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(81, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BooK Title"
        '
        'bnametb
        '
        Me.bnametb.Location = New System.Drawing.Point(71, 193)
        Me.bnametb.Name = "bnametb"
        Me.bnametb.Size = New System.Drawing.Size(131, 32)
        Me.bnametb.TabIndex = 12
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cyberfall", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(420, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BOOKSHOP SOFTWARE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 811)
        Me.Panel2.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.PictureBox8)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Location = New System.Drawing.Point(10, 288)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(232, 41)
        Me.Panel8.TabIndex = 35
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 34
        Me.PictureBox8.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label17.Location = New System.Drawing.Point(47, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 34)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = " Category"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Location = New System.Drawing.Point(10, 504)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(232, 41)
        Me.Panel7.TabIndex = 38
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label16.Location = New System.Drawing.Point(72, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 34)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Setting"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Controls.Add(Me.PictureBox7)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(10, 576)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(232, 41)
        Me.Panel6.TabIndex = 36
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label12.Location = New System.Drawing.Point(72, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 34)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Logout"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(10, 432)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(232, 41)
        Me.Panel5.TabIndex = 35
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, -2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label11.Location = New System.Drawing.Point(51, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 34)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Dashboard"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Controls.Add(Me.PictureBox6)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(10, 360)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 41)
        Me.Panel4.TabIndex = 34
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 35
        Me.PictureBox6.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label10.Location = New System.Drawing.Point(72, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 34)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Users"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(10, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 41)
        Me.Panel3.TabIndex = 32
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(72, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 34)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Books"
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
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1507, 813)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bnametb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents authortb As TextBox
    Friend WithEvents B_pricetb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents qtytb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents catbox As ComboBox
    Friend WithEvents deletebtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents filtercb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents S_pricetb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents bookDGV As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label17 As Label
End Class

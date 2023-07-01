<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.percentage = New System.Windows.Forms.Label()
        Me.myprogress = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 37)
        Me.Label3.TabIndex = 2
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'percentage
        '
        Me.percentage.AutoSize = True
        Me.percentage.BackColor = System.Drawing.Color.Transparent
        Me.percentage.Font = New System.Drawing.Font("Impact", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage.ForeColor = System.Drawing.Color.LawnGreen
        Me.percentage.Location = New System.Drawing.Point(781, 491)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(59, 59)
        Me.percentage.TabIndex = 4
        Me.percentage.Text = "%"
        '
        'myprogress
        '
        Me.myprogress.BackColor = System.Drawing.Color.Lime
        Me.myprogress.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.myprogress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.myprogress.Location = New System.Drawing.Point(166, 357)
        Me.myprogress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.myprogress.Name = "myprogress"
        Me.myprogress.Size = New System.Drawing.Size(1245, 73)
        Me.myprogress.Step = 0
        Me.myprogress.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label4.Font = New System.Drawing.Font("Cyberfall", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(553, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(497, 51)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "BOOKSHOP SOFTWARE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1507, 813)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.myprogress)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Process1 As Process
    Friend WithEvents Timer1 As Timer
    Friend WithEvents myprogress As ProgressBar
    Friend WithEvents percentage As Label
    Friend WithEvents Label4 As Label
End Class

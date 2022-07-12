<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sendermessage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.tstate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.temail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.sendbtn = New FontAwesome.Sharp.IconButton()
        Me.msend = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(225, 141)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1015, 629)
        Me.Panel3.TabIndex = 5
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.TextBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.tstate)
        Me.Guna2GroupBox1.Controls.Add(Me.temail)
        Me.Guna2GroupBox1.Controls.Add(Me.tusername)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.sendbtn)
        Me.Guna2GroupBox1.Controls.Add(Me.msend)
        Me.Guna2GroupBox1.Controls.Add(Me.TextBox1)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1015, 629)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Guna2GroupBox1"
        '
        'tstate
        '
        Me.tstate.BackColor = System.Drawing.Color.Transparent
        Me.tstate.Location = New System.Drawing.Point(60, 422)
        Me.tstate.Name = "tstate"
        Me.tstate.Size = New System.Drawing.Size(0, 0)
        Me.tstate.TabIndex = 7
        Me.tstate.Text = Nothing
        '
        'temail
        '
        Me.temail.BackColor = System.Drawing.Color.Transparent
        Me.temail.Location = New System.Drawing.Point(60, 332)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(0, 0)
        Me.temail.TabIndex = 6
        Me.temail.Text = Nothing
        '
        'tusername
        '
        Me.tusername.BackColor = System.Drawing.Color.Transparent
        Me.tusername.Location = New System.Drawing.Point(60, 280)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(0, 0)
        Me.tusername.TabIndex = 5
        Me.tusername.Text = Nothing
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.ChatRoom.My.Resources.Resources._1
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(75, 76)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(143, 139)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 4
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'sendbtn
        '
        Me.sendbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.sendbtn.ForeColor = System.Drawing.Color.White
        Me.sendbtn.IconChar = FontAwesome.Sharp.IconChar.Share
        Me.sendbtn.IconColor = System.Drawing.Color.SteelBlue
        Me.sendbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sendbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sendbtn.Location = New System.Drawing.Point(825, 555)
        Me.sendbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(164, 59)
        Me.sendbtn.TabIndex = 3
        Me.sendbtn.Text = "Send Message"
        Me.sendbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sendbtn.UseVisualStyleBackColor = False
        '
        'msend
        '
        Me.msend.Location = New System.Drawing.Point(304, 555)
        Me.msend.Multiline = True
        Me.msend.Name = "msend"
        Me.msend.Size = New System.Drawing.Size(515, 62)
        Me.msend.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 58)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(699, 480)
        Me.TextBox1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(225, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 141)
        Me.Panel2.TabIndex = 4
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = Global.ChatRoom.My.Resources.Resources._1
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(878, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(125, 109)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 5
        Me.Guna2CirclePictureBox2.TabStop = False
        Me.Guna2CirclePictureBox2.UseTransparentBackground = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton6)
        Me.Panel1.Controls.Add(Me.IconButton5)
        Me.Panel1.Controls.Add(Me.IconButton4)
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 770)
        Me.Panel1.TabIndex = 3
        '
        'IconButton6
        '
        Me.IconButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.PersonShelter
        Me.IconButton6.IconColor = System.Drawing.Color.GreenYellow
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton6.IconSize = 45
        Me.IconButton6.Location = New System.Drawing.Point(51, 605)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(102, 61)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.IconButton5.IconColor = System.Drawing.Color.GreenYellow
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton5.IconSize = 45
        Me.IconButton5.Location = New System.Drawing.Point(51, 514)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(102, 64)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare
        Me.IconButton4.IconColor = System.Drawing.Color.GreenYellow
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton4.IconSize = 45
        Me.IconButton4.Location = New System.Drawing.Point(0, 719)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(82, 54)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Message
        Me.IconButton3.IconColor = System.Drawing.Color.Orange
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton3.IconSize = 45
        Me.IconButton3.Location = New System.Drawing.Point(51, 319)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(102, 68)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.IconButton2.IconColor = System.Drawing.Color.GreenYellow
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton2.IconSize = 45
        Me.IconButton2.Location = New System.Drawing.Point(51, 230)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(102, 71)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconButton1.IconColor = System.Drawing.Color.GreenYellow
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconButton1.IconSize = 45
        Me.IconButton1.Location = New System.Drawing.Point(51, 409)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(102, 69)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 179
        Me.IconPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(225, 179)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(60, 578)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 31)
        Me.TextBox2.TabIndex = 8
        '
        'sendermessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 770)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "sendermessage"
        Me.Text = "sendermessage"
        Me.Panel3.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents msend As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents sendbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents tstate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents temail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox2 As TextBox
End Class

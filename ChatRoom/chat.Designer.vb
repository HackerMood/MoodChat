<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chating = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.tstate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.temail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tusername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.messagebox = New System.Windows.Forms.TextBox()
        Me.sendbtn = New FontAwesome.Sharp.IconButton()
        Me.messagesend = New System.Windows.Forms.TextBox()
        Me.listmessage = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.reloadertime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.chating.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listmessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Controls.Add(Me.chating)
        Me.Panel3.Controls.Add(Me.listmessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(225, 141)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1153, 635)
        Me.Panel3.TabIndex = 5
        '
        'chating
        '
        Me.chating.Controls.Add(Me.IconPictureBox3)
        Me.chating.Controls.Add(Me.tstate)
        Me.chating.Controls.Add(Me.temail)
        Me.chating.Controls.Add(Me.tusername)
        Me.chating.Controls.Add(Me.messagebox)
        Me.chating.Controls.Add(Me.sendbtn)
        Me.chating.Controls.Add(Me.messagesend)
        Me.chating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chating.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chating.Location = New System.Drawing.Point(0, 0)
        Me.chating.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chating.Name = "chating"
        Me.chating.Size = New System.Drawing.Size(1153, 635)
        Me.chating.TabIndex = 1
        Me.chating.Text = "Chating"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 184
        Me.IconPictureBox3.Location = New System.Drawing.Point(7, 60)
        Me.IconPictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(225, 184)
        Me.IconPictureBox3.TabIndex = 8
        Me.IconPictureBox3.TabStop = False
        '
        'tstate
        '
        Me.tstate.BackColor = System.Drawing.Color.Transparent
        Me.tstate.Location = New System.Drawing.Point(71, 409)
        Me.tstate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tstate.Name = "tstate"
        Me.tstate.Size = New System.Drawing.Size(0, 0)
        Me.tstate.TabIndex = 6
        Me.tstate.Text = Nothing
        '
        'temail
        '
        Me.temail.BackColor = System.Drawing.Color.Transparent
        Me.temail.Location = New System.Drawing.Point(68, 339)
        Me.temail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(0, 0)
        Me.temail.TabIndex = 5
        Me.temail.Text = Nothing
        '
        'tusername
        '
        Me.tusername.BackColor = System.Drawing.Color.Transparent
        Me.tusername.Location = New System.Drawing.Point(56, 285)
        Me.tusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(0, 0)
        Me.tusername.TabIndex = 4
        Me.tusername.Text = Nothing
        '
        'messagebox
        '
        Me.messagebox.Location = New System.Drawing.Point(322, 60)
        Me.messagebox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.messagebox.Multiline = True
        Me.messagebox.Name = "messagebox"
        Me.messagebox.Size = New System.Drawing.Size(817, 493)
        Me.messagebox.TabIndex = 3
        '
        'sendbtn
        '
        Me.sendbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.sendbtn.ForeColor = System.Drawing.Color.White
        Me.sendbtn.IconChar = FontAwesome.Sharp.IconChar.Share
        Me.sendbtn.IconColor = System.Drawing.Color.SteelBlue
        Me.sendbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sendbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sendbtn.Location = New System.Drawing.Point(975, 561)
        Me.sendbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(164, 59)
        Me.sendbtn.TabIndex = 2
        Me.sendbtn.Text = "Send Message"
        Me.sendbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sendbtn.UseVisualStyleBackColor = False
        '
        'messagesend
        '
        Me.messagesend.Location = New System.Drawing.Point(322, 561)
        Me.messagesend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.messagesend.Multiline = True
        Me.messagesend.Name = "messagesend"
        Me.messagesend.Size = New System.Drawing.Size(646, 58)
        Me.messagesend.TabIndex = 1
        '
        'listmessage
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.listmessage.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.listmessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.listmessage.BackgroundColor = System.Drawing.Color.White
        Me.listmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listmessage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.listmessage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listmessage.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.listmessage.ColumnHeadersHeight = 27
        Me.listmessage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.target, Me.message})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listmessage.DefaultCellStyle = DataGridViewCellStyle4
        Me.listmessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listmessage.EnableHeadersVisualStyles = False
        Me.listmessage.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listmessage.Location = New System.Drawing.Point(0, 0)
        Me.listmessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listmessage.Name = "listmessage"
        Me.listmessage.RowHeadersVisible = False
        Me.listmessage.RowHeadersWidth = 51
        Me.listmessage.RowTemplate.Height = 24
        Me.listmessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listmessage.Size = New System.Drawing.Size(1153, 635)
        Me.listmessage.TabIndex = 0
        Me.listmessage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.listmessage.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.listmessage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.listmessage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.listmessage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.listmessage.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.listmessage.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listmessage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listmessage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.listmessage.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.listmessage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.listmessage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.listmessage.ThemeStyle.HeaderStyle.Height = 27
        Me.listmessage.ThemeStyle.ReadOnly = False
        Me.listmessage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.listmessage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.listmessage.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.listmessage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.listmessage.ThemeStyle.RowsStyle.Height = 24
        Me.listmessage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listmessage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'target
        '
        Me.target.DataPropertyName = "sender"
        Me.target.HeaderText = "Destinataire"
        Me.target.MinimumWidth = 6
        Me.target.Name = "target"
        '
        'message
        '
        Me.message.DataPropertyName = "mesg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.message.DefaultCellStyle = DataGridViewCellStyle3
        Me.message.HeaderText = "Message Box"
        Me.message.MinimumWidth = 6
        Me.message.Name = "message"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.IconPictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(225, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1153, 141)
        Me.Panel2.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(570, 56)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(11, 26)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(71, 106)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(11, 26)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(35, 106)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(11, 26)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 106)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(11, 26)
        Me.TextBox1.TabIndex = 3
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox2.BackgroundImage = Global.ChatRoom.My.Resources.Resources._4
        Me.IconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IconPictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconPictureBox2.ErrorImage = Global.ChatRoom.My.Resources.Resources.person
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 129
        Me.IconPictureBox2.Location = New System.Drawing.Point(1024, 0)
        Me.IconPictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(129, 141)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
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
        Me.Panel1.Size = New System.Drawing.Size(225, 776)
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
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'reloadertime
        '
        Me.reloadertime.Interval = 2000
        '
        'chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 776)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "chat"
        Me.Text = "chat"
        Me.Panel3.ResumeLayout(False)
        Me.chating.ResumeLayout(False)
        Me.chating.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listmessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents listmessage As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents target As DataGridViewTextBoxColumn
    Friend WithEvents message As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents chating As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents sendbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents messagesend As TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents messagebox As TextBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents tstate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents temail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tusername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents reloadertime As Timer
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class

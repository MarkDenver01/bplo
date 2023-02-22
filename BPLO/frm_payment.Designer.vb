<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_payment))
        Me.btnshow = New System.Windows.Forms.Button()
        Me.DTPExpireddate = New System.Windows.Forms.DateTimePicker()
        Me.lblexpireddate = New System.Windows.Forms.Label()
        Me.cmbbusinesstype = New System.Windows.Forms.ComboBox()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.identi = New System.Windows.Forms.Panel()
        Me.cmborganization = New System.Windows.Forms.ComboBox()
        Me.lblorganization = New System.Windows.Forms.Label()
        Me.lblPHP = New System.Windows.Forms.Label()
        Me.bt = New System.Windows.Forms.Label()
        Me.txtmayorspermit = New System.Windows.Forms.TextBox()
        Me.mp = New System.Windows.Forms.Label()
        Me.addnum = New System.Windows.Forms.Label()
        Me.txtbusinessname = New System.Windows.Forms.TextBox()
        Me.bname = New System.Windows.Forms.Label()
        Me.txtcellphonenumber = New System.Windows.Forms.TextBox()
        Me.cpnumb = New System.Windows.Forms.Label()
        Me.DTPpermitdate = New System.Windows.Forms.DateTimePicker()
        Me.permit = New System.Windows.Forms.Label()
        Me.busiden = New System.Windows.Forms.Label()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.ownerinfo = New System.Windows.Forms.Panel()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblownersaddress = New System.Windows.Forms.Label()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.lblmi = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.owninfo = New System.Windows.Forms.Label()
        Me.lblownersID = New System.Windows.Forms.Label()
        Me.picboxclient = New System.Windows.Forms.PictureBox()
        Me.txtownersID = New System.Windows.Forms.TextBox()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.lblamountentry = New System.Windows.Forms.Label()
        Me.txtentryamount = New System.Windows.Forms.TextBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbusinessaddress = New System.Windows.Forms.ComboBox()
        Me.txtownersaddress = New System.Windows.Forms.ComboBox()
        Me.identi.SuspendLayout()
        Me.ownerinfo.SuspendLayout()
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnshow
        '
        Me.btnshow.Enabled = False
        Me.btnshow.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnshow.Location = New System.Drawing.Point(681, 66)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(67, 28)
        Me.btnshow.TabIndex = 47
        Me.btnshow.Text = "Update"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'DTPExpireddate
        '
        Me.DTPExpireddate.Enabled = False
        Me.DTPExpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPExpireddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPExpireddate.Location = New System.Drawing.Point(448, 67)
        Me.DTPExpireddate.Name = "DTPExpireddate"
        Me.DTPExpireddate.Size = New System.Drawing.Size(227, 25)
        Me.DTPExpireddate.TabIndex = 46
        '
        'lblexpireddate
        '
        Me.lblexpireddate.AutoSize = True
        Me.lblexpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpireddate.Location = New System.Drawing.Point(350, 71)
        Me.lblexpireddate.Name = "lblexpireddate"
        Me.lblexpireddate.Size = New System.Drawing.Size(100, 18)
        Me.lblexpireddate.TabIndex = 45
        Me.lblexpireddate.Text = "Expired Date:"
        '
        'cmbbusinesstype
        '
        Me.cmbbusinesstype.Enabled = False
        Me.cmbbusinesstype.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbusinesstype.FormattingEnabled = True
        Me.cmbbusinesstype.Items.AddRange(New Object() {"Canteen ", "Sari Sari Store", "Computer Shop"})
        Me.cmbbusinesstype.Location = New System.Drawing.Point(150, 192)
        Me.cmbbusinesstype.Name = "cmbbusinesstype"
        Me.cmbbusinesstype.Size = New System.Drawing.Size(328, 26)
        Me.cmbbusinesstype.TabIndex = 44
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Enabled = False
        Me.lblamount.Font = New System.Drawing.Font("Arial Unicode MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(553, 179)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(34, 39)
        Me.lblamount.TabIndex = 43
        Me.lblamount.Text = "0"
        '
        'identi
        '
        Me.identi.Controls.Add(Me.txtbusinessaddress)
        Me.identi.Controls.Add(Me.cmborganization)
        Me.identi.Controls.Add(Me.lblorganization)
        Me.identi.Controls.Add(Me.lblPHP)
        Me.identi.Controls.Add(Me.btnshow)
        Me.identi.Controls.Add(Me.DTPExpireddate)
        Me.identi.Controls.Add(Me.lblexpireddate)
        Me.identi.Controls.Add(Me.cmbbusinesstype)
        Me.identi.Controls.Add(Me.lblamount)
        Me.identi.Controls.Add(Me.bt)
        Me.identi.Controls.Add(Me.txtmayorspermit)
        Me.identi.Controls.Add(Me.mp)
        Me.identi.Controls.Add(Me.addnum)
        Me.identi.Controls.Add(Me.txtbusinessname)
        Me.identi.Controls.Add(Me.bname)
        Me.identi.Controls.Add(Me.txtcellphonenumber)
        Me.identi.Controls.Add(Me.cpnumb)
        Me.identi.Controls.Add(Me.DTPpermitdate)
        Me.identi.Controls.Add(Me.permit)
        Me.identi.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.identi.Location = New System.Drawing.Point(13, 133)
        Me.identi.Name = "identi"
        Me.identi.Size = New System.Drawing.Size(757, 268)
        Me.identi.TabIndex = 62
        '
        'cmborganization
        '
        Me.cmborganization.Enabled = False
        Me.cmborganization.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborganization.FormattingEnabled = True
        Me.cmborganization.Items.AddRange(New Object() {"Sole Proprietorship", "General Partnership", "Limited Partnership", "Corporation", """S"" Corporation", "Limited Liability"})
        Me.cmborganization.Location = New System.Drawing.Point(216, 161)
        Me.cmborganization.Name = "cmborganization"
        Me.cmborganization.Size = New System.Drawing.Size(262, 26)
        Me.cmborganization.TabIndex = 56
        '
        'lblorganization
        '
        Me.lblorganization.AutoSize = True
        Me.lblorganization.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorganization.Location = New System.Drawing.Point(9, 164)
        Me.lblorganization.Name = "lblorganization"
        Me.lblorganization.Size = New System.Drawing.Size(203, 18)
        Me.lblorganization.TabIndex = 55
        Me.lblorganization.Text = "Business Organization Type:"
        '
        'lblPHP
        '
        Me.lblPHP.AutoSize = True
        Me.lblPHP.Enabled = False
        Me.lblPHP.Font = New System.Drawing.Font("Arial Unicode MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHP.Location = New System.Drawing.Point(553, 140)
        Me.lblPHP.Name = "lblPHP"
        Me.lblPHP.Size = New System.Drawing.Size(122, 39)
        Me.lblPHP.TabIndex = 49
        Me.lblPHP.Text = "Amount"
        '
        'bt
        '
        Me.bt.AutoSize = True
        Me.bt.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt.Location = New System.Drawing.Point(9, 195)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(113, 18)
        Me.bt.TabIndex = 40
        Me.bt.Text = "Business Type:"
        '
        'txtmayorspermit
        '
        Me.txtmayorspermit.Enabled = False
        Me.txtmayorspermit.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmayorspermit.Location = New System.Drawing.Point(308, 12)
        Me.txtmayorspermit.Name = "txtmayorspermit"
        Me.txtmayorspermit.Size = New System.Drawing.Size(312, 36)
        Me.txtmayorspermit.TabIndex = 23
        '
        'mp
        '
        Me.mp.AutoSize = True
        Me.mp.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mp.Location = New System.Drawing.Point(127, 15)
        Me.mp.Name = "mp"
        Me.mp.Size = New System.Drawing.Size(175, 28)
        Me.mp.TabIndex = 22
        Me.mp.Text = "Mayor's Permit:"
        '
        'addnum
        '
        Me.addnum.AutoSize = True
        Me.addnum.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnum.Location = New System.Drawing.Point(9, 133)
        Me.addnum.Name = "addnum"
        Me.addnum.Size = New System.Drawing.Size(135, 18)
        Me.addnum.TabIndex = 30
        Me.addnum.Text = "Business Address:"
        '
        'txtbusinessname
        '
        Me.txtbusinessname.Enabled = False
        Me.txtbusinessname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusinessname.Location = New System.Drawing.Point(150, 99)
        Me.txtbusinessname.Name = "txtbusinessname"
        Me.txtbusinessname.Size = New System.Drawing.Size(598, 25)
        Me.txtbusinessname.TabIndex = 29
        '
        'bname
        '
        Me.bname.AutoSize = True
        Me.bname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bname.Location = New System.Drawing.Point(9, 102)
        Me.bname.Name = "bname"
        Me.bname.Size = New System.Drawing.Size(118, 18)
        Me.bname.TabIndex = 28
        Me.bname.Text = "Business Name:"
        '
        'txtcellphonenumber
        '
        Me.txtcellphonenumber.Enabled = False
        Me.txtcellphonenumber.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcellphonenumber.Location = New System.Drawing.Point(150, 223)
        Me.txtcellphonenumber.MaxLength = 11
        Me.txtcellphonenumber.Name = "txtcellphonenumber"
        Me.txtcellphonenumber.Size = New System.Drawing.Size(328, 25)
        Me.txtcellphonenumber.TabIndex = 27
        '
        'cpnumb
        '
        Me.cpnumb.AutoSize = True
        Me.cpnumb.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpnumb.Location = New System.Drawing.Point(9, 226)
        Me.cpnumb.Name = "cpnumb"
        Me.cpnumb.Size = New System.Drawing.Size(135, 18)
        Me.cpnumb.TabIndex = 26
        Me.cpnumb.Text = "Cellphone Number:"
        '
        'DTPpermitdate
        '
        Me.DTPpermitdate.Enabled = False
        Me.DTPpermitdate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPpermitdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPpermitdate.Location = New System.Drawing.Point(106, 67)
        Me.DTPpermitdate.Name = "DTPpermitdate"
        Me.DTPpermitdate.Size = New System.Drawing.Size(227, 25)
        Me.DTPpermitdate.TabIndex = 25
        '
        'permit
        '
        Me.permit.AutoSize = True
        Me.permit.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permit.Location = New System.Drawing.Point(9, 71)
        Me.permit.Name = "permit"
        Me.permit.Size = New System.Drawing.Size(93, 18)
        Me.permit.TabIndex = 24
        Me.permit.Text = "Permit Date:"
        '
        'busiden
        '
        Me.busiden.AutoSize = True
        Me.busiden.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busiden.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.busiden.Location = New System.Drawing.Point(283, 107)
        Me.busiden.Name = "busiden"
        Me.busiden.Size = New System.Drawing.Size(162, 18)
        Me.busiden.TabIndex = 64
        Me.busiden.Text = "Business Identification"
        '
        'cmbgender
        '
        Me.cmbgender.Enabled = False
        Me.cmbgender.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(90, 48)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(143, 26)
        Me.cmbgender.TabIndex = 19
        '
        'ownerinfo
        '
        Me.ownerinfo.Controls.Add(Me.txtownersaddress)
        Me.ownerinfo.Controls.Add(Me.cmbgender)
        Me.ownerinfo.Controls.Add(Me.lblgender)
        Me.ownerinfo.Controls.Add(Me.lblownersaddress)
        Me.ownerinfo.Controls.Add(Me.txtMI)
        Me.ownerinfo.Controls.Add(Me.lblmi)
        Me.ownerinfo.Controls.Add(Me.txtfirstname)
        Me.ownerinfo.Controls.Add(Me.lblfirstname)
        Me.ownerinfo.Controls.Add(Me.txtlastname)
        Me.ownerinfo.Controls.Add(Me.lbllastname)
        Me.ownerinfo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ownerinfo.Location = New System.Drawing.Point(13, 438)
        Me.ownerinfo.Name = "ownerinfo"
        Me.ownerinfo.Size = New System.Drawing.Size(757, 87)
        Me.ownerinfo.TabIndex = 63
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(3, 51)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(61, 18)
        Me.lblgender.TabIndex = 17
        Me.lblgender.Text = "Gender:"
        '
        'lblownersaddress
        '
        Me.lblownersaddress.AutoSize = True
        Me.lblownersaddress.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersaddress.Location = New System.Drawing.Point(270, 48)
        Me.lblownersaddress.Name = "lblownersaddress"
        Me.lblownersaddress.Size = New System.Drawing.Size(128, 18)
        Me.lblownersaddress.TabIndex = 7
        Me.lblownersaddress.Text = "Owners Address: "
        '
        'txtMI
        '
        Me.txtMI.Enabled = False
        Me.txtMI.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI.Location = New System.Drawing.Point(616, 13)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(36, 25)
        Me.txtMI.TabIndex = 5
        '
        'lblmi
        '
        Me.lblmi.AutoSize = True
        Me.lblmi.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmi.Location = New System.Drawing.Point(569, 16)
        Me.lblmi.Name = "lblmi"
        Me.lblmi.Size = New System.Drawing.Size(29, 18)
        Me.lblmi.TabIndex = 4
        Me.lblmi.Text = "MI:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(390, 13)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(154, 25)
        Me.txtfirstname.TabIndex = 3
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(270, 16)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(87, 18)
        Me.lblfirstname.TabIndex = 2
        Me.lblfirstname.Text = "First Name:"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(90, 13)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(143, 25)
        Me.txtlastname.TabIndex = 1
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(3, 16)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(85, 18)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "Last Name:"
        '
        'owninfo
        '
        Me.owninfo.AutoSize = True
        Me.owninfo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owninfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.owninfo.Location = New System.Drawing.Point(283, 411)
        Me.owninfo.Name = "owninfo"
        Me.owninfo.Size = New System.Drawing.Size(179, 18)
        Me.owninfo.TabIndex = 65
        Me.owninfo.Text = "Owner Information/Profile"
        '
        'lblownersID
        '
        Me.lblownersID.AutoSize = True
        Me.lblownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblownersID.Location = New System.Drawing.Point(18, 273)
        Me.lblownersID.Name = "lblownersID"
        Me.lblownersID.Size = New System.Drawing.Size(80, 18)
        Me.lblownersID.TabIndex = 66
        Me.lblownersID.Text = "Owner's ID"
        Me.lblownersID.Visible = False
        '
        'picboxclient
        '
        Me.picboxclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxclient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxclient.Location = New System.Drawing.Point(803, 133)
        Me.picboxclient.Name = "picboxclient"
        Me.picboxclient.Size = New System.Drawing.Size(207, 190)
        Me.picboxclient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxclient.TabIndex = 69
        Me.picboxclient.TabStop = False
        '
        'txtownersID
        '
        Me.txtownersID.Enabled = False
        Me.txtownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownersID.Location = New System.Drawing.Point(103, 408)
        Me.txtownersID.Name = "txtownersID"
        Me.txtownersID.Size = New System.Drawing.Size(100, 25)
        Me.txtownersID.TabIndex = 67
        Me.txtownersID.Visible = False
        '
        'txttotalamount
        '
        Me.txttotalamount.Enabled = False
        Me.txttotalamount.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamount.Location = New System.Drawing.Point(910, 338)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Size = New System.Drawing.Size(100, 25)
        Me.txttotalamount.TabIndex = 71
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(798, 337)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(103, 18)
        Me.lbltotalamount.TabIndex = 72
        Me.lbltotalamount.Text = "Total Amount:"
        '
        'lblamountentry
        '
        Me.lblamountentry.AutoSize = True
        Me.lblamountentry.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountentry.Location = New System.Drawing.Point(798, 363)
        Me.lblamountentry.Name = "lblamountentry"
        Me.lblamountentry.Size = New System.Drawing.Size(105, 18)
        Me.lblamountentry.TabIndex = 73
        Me.lblamountentry.Text = "Enter Amount:"
        '
        'txtentryamount
        '
        Me.txtentryamount.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentryamount.Location = New System.Drawing.Point(910, 364)
        Me.txtentryamount.Name = "txtentryamount"
        Me.txtentryamount.Size = New System.Drawing.Size(100, 25)
        Me.txtentryamount.TabIndex = 74
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblstatus.Location = New System.Drawing.Point(616, 411)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(57, 18)
        Me.lblstatus.TabIndex = 75
        Me.lblstatus.Text = "Status:"
        Me.lblstatus.Visible = False
        '
        'txtstatus
        '
        Me.txtstatus.Enabled = False
        Me.txtstatus.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(679, 408)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(91, 25)
        Me.txtstatus.TabIndex = 76
        Me.txtstatus.Visible = False
        '
        'txtchange
        '
        Me.txtchange.Enabled = False
        Me.txtchange.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(910, 390)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(100, 25)
        Me.txtchange.TabIndex = 78
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.Location = New System.Drawing.Point(800, 389)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(63, 18)
        Me.lblchange.TabIndex = 77
        Me.lblchange.Text = "Change:"
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnback)
        Me.pnlheader.Controls.Add(Me.lbltitle)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1023, 104)
        Me.pnlheader.TabIndex = 79
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnback.Location = New System.Drawing.Point(1272, 61)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(91, 36)
        Me.btnback.TabIndex = 21
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        Me.btnback.Visible = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltitle.Location = New System.Drawing.Point(353, 24)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(335, 55)
        Me.lbltitle.TabIndex = 6
        Me.lbltitle.Text = "Add Payment"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(849, 479)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(113, 36)
        Me.btnclose.TabIndex = 81
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(849, 437)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(113, 36)
        Me.btnsave.TabIndex = 80
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Owner's ID"
        Me.Label1.Visible = False
        '
        'txtbusinessaddress
        '
        Me.txtbusinessaddress.FormattingEnabled = True
        Me.txtbusinessaddress.Items.AddRange(New Object() {"Aya Talisay, Batangas", "Quiling Talisay, Batangas", "Tumaway Talisay, Batangas", "Zone 8 Talisay, Batangas", "Zone 7 Talisay, Batangas", "Zone 6 Talisay, Batangas", "Zone 5 Talisay, Batangas", "Zone 4 Talisay, Batangas", "Zone 3 Talisay, Batangas", "Zone 2 Talisay, Batangas", "Zone 1 Talisay, Batangas", "Sitio, Tabla Talisay, Batangas", "San Isidro Talisay, Batangas", "Banga Talisay, Batangas", "Sta. Maria Talisay, Batangas", "Balas Talisay, Batangas", "Buco Talisay, Batangas", "Caloocan Talisay, Batangas", "Leynes Talisay, Batangas", "Sampaloc Talisay, Batangas"})
        Me.txtbusinessaddress.Location = New System.Drawing.Point(216, 130)
        Me.txtbusinessaddress.Name = "txtbusinessaddress"
        Me.txtbusinessaddress.Size = New System.Drawing.Size(261, 26)
        Me.txtbusinessaddress.TabIndex = 57
        '
        'txtownersaddress
        '
        Me.txtownersaddress.FormattingEnabled = True
        Me.txtownersaddress.Items.AddRange(New Object() {"Aya Talisay, Batangas", "Quiling Talisay, Batangas", "Tumaway Talisay, Batangas", "Zone 8 Talisay, Batangas", "Zone 7 Talisay, Batangas", "Zone 6 Talisay, Batangas", "Zone 5 Talisay, Batangas", "Zone 4 Talisay, Batangas", "Zone 3 Talisay, Batangas", "Zone 2 Talisay, Batangas", "Zone 1 Talisay, Batangas", "Sitio, Tabla Talisay, Batangas", "San Isidro Talisay, Batangas", "Banga Talisay, Batangas", "Sta. Maria Talisay, Batangas", "Balas Talisay, Batangas", "Buco Talisay, Batangas", "Caloocan Talisay, Batangas", "Leynes Talisay, Batangas", "Sampaloc Talisay, Batangas"})
        Me.txtownersaddress.Location = New System.Drawing.Point(390, 48)
        Me.txtownersaddress.Name = "txtownersaddress"
        Me.txtownersaddress.Size = New System.Drawing.Size(261, 26)
        Me.txtownersaddress.TabIndex = 55
        '
        'frm_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtentryamount)
        Me.Controls.Add(Me.lblamountentry)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.identi)
        Me.Controls.Add(Me.busiden)
        Me.Controls.Add(Me.ownerinfo)
        Me.Controls.Add(Me.owninfo)
        Me.Controls.Add(Me.lblownersID)
        Me.Controls.Add(Me.picboxclient)
        Me.Controls.Add(Me.txtownersID)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT"
        Me.identi.ResumeLayout(False)
        Me.identi.PerformLayout()
        Me.ownerinfo.ResumeLayout(False)
        Me.ownerinfo.PerformLayout()
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents DTPExpireddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblexpireddate As System.Windows.Forms.Label
    Friend WithEvents cmbbusinesstype As System.Windows.Forms.ComboBox
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents identi As System.Windows.Forms.Panel
    Friend WithEvents bt As System.Windows.Forms.Label
    Friend WithEvents txtmayorspermit As System.Windows.Forms.TextBox
    Friend WithEvents mp As System.Windows.Forms.Label
    Friend WithEvents addnum As System.Windows.Forms.Label
    Friend WithEvents txtbusinessname As System.Windows.Forms.TextBox
    Friend WithEvents bname As System.Windows.Forms.Label
    Friend WithEvents txtcellphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents cpnumb As System.Windows.Forms.Label
    Friend WithEvents DTPpermitdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents permit As System.Windows.Forms.Label
    Friend WithEvents busiden As System.Windows.Forms.Label
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents ownerinfo As System.Windows.Forms.Panel
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblownersaddress As System.Windows.Forms.Label
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents lblmi As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents owninfo As System.Windows.Forms.Label
    Friend WithEvents lblownersID As System.Windows.Forms.Label
    Friend WithEvents picboxclient As System.Windows.Forms.PictureBox
    Friend WithEvents txtownersID As System.Windows.Forms.TextBox
    Friend WithEvents txttotalamount As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalamount As System.Windows.Forms.Label
    Friend WithEvents lblamountentry As System.Windows.Forms.Label
    Friend WithEvents txtentryamount As System.Windows.Forms.TextBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents lblPHP As System.Windows.Forms.Label
    Friend WithEvents cmborganization As System.Windows.Forms.ComboBox
    Friend WithEvents lblorganization As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbusinessaddress As System.Windows.Forms.ComboBox
    Friend WithEvents txtownersaddress As System.Windows.Forms.ComboBox
End Class

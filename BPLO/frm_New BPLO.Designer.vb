<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_BPLO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_BPLO))
        Me.txtownersID = New System.Windows.Forms.TextBox()
        Me.lblownersID = New System.Windows.Forms.Label()
        Me.owninfo = New System.Windows.Forms.Label()
        Me.ownerinfo = New System.Windows.Forms.Panel()
        Me.txtownersaddress = New System.Windows.Forms.ComboBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblownersaddress = New System.Windows.Forms.Label()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.lblmi = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.identi = New System.Windows.Forms.Panel()
        Me.txtbusinessaddress = New System.Windows.Forms.ComboBox()
        Me.cmborganization = New System.Windows.Forms.ComboBox()
        Me.lblorganization = New System.Windows.Forms.Label()
        Me.lblPHP = New System.Windows.Forms.Label()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.DTPExpireddate = New System.Windows.Forms.DateTimePicker()
        Me.lblexpireddate = New System.Windows.Forms.Label()
        Me.cmbbusinesstype = New System.Windows.Forms.ComboBox()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.bt = New System.Windows.Forms.Label()
        Me.txtmayorspermit = New System.Windows.Forms.TextBox()
        Me.mp = New System.Windows.Forms.Label()
        Me.addnum = New System.Windows.Forms.Label()
        Me.txtbusinessname = New System.Windows.Forms.TextBox()
        Me.bname = New System.Windows.Forms.Label()
        Me.txtcellphonenumber = New System.Windows.Forms.TextBox()
        Me.cpnumb = New System.Windows.Forms.Label()
        Me.DTPpermitdate = New System.Windows.Forms.DateTimePicker()
        Me.lblpermit = New System.Windows.Forms.Label()
        Me.req = New System.Windows.Forms.GroupBox()
        Me.chckboxCHECKALL = New System.Windows.Forms.CheckBox()
        Me.chckboxbrgyclearance = New System.Windows.Forms.CheckBox()
        Me.chckboxTIN = New System.Windows.Forms.CheckBox()
        Me.chckboxDTI = New System.Windows.Forms.CheckBox()
        Me.busiden = New System.Windows.Forms.Label()
        Me.picboxclient = New System.Windows.Forms.PictureBox()
        Me.btnchoose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.ownerinfo.SuspendLayout()
        Me.identi.SuspendLayout()
        Me.req.SuspendLayout()
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtownersID
        '
        Me.txtownersID.Enabled = False
        Me.txtownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownersID.Location = New System.Drawing.Point(107, 565)
        Me.txtownersID.Name = "txtownersID"
        Me.txtownersID.Size = New System.Drawing.Size(100, 25)
        Me.txtownersID.TabIndex = 56
        Me.txtownersID.Visible = False
        '
        'lblownersID
        '
        Me.lblownersID.AutoSize = True
        Me.lblownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblownersID.Location = New System.Drawing.Point(21, 569)
        Me.lblownersID.Name = "lblownersID"
        Me.lblownersID.Size = New System.Drawing.Size(80, 18)
        Me.lblownersID.TabIndex = 55
        Me.lblownersID.Text = "Owner's ID"
        Me.lblownersID.Visible = False
        '
        'owninfo
        '
        Me.owninfo.AutoSize = True
        Me.owninfo.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owninfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.owninfo.Location = New System.Drawing.Point(285, 568)
        Me.owninfo.Name = "owninfo"
        Me.owninfo.Size = New System.Drawing.Size(179, 18)
        Me.owninfo.TabIndex = 52
        Me.owninfo.Text = "Owner Information/Profile"
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
        Me.ownerinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ownerinfo.Location = New System.Drawing.Point(18, 597)
        Me.ownerinfo.Name = "ownerinfo"
        Me.ownerinfo.Size = New System.Drawing.Size(757, 87)
        Me.ownerinfo.TabIndex = 50
        '
        'txtownersaddress
        '
        Me.txtownersaddress.FormattingEnabled = True
        Me.txtownersaddress.Items.AddRange(New Object() {"Aya Talisay, Batangas", "Quiling Talisay, Batangas", "Tumaway Talisay, Batangas", "Zone 8 Talisay, Batangas", "Zone 7 Talisay, Batangas", "Zone 6 Talisay, Batangas", "Zone 5 Talisay, Batangas", "Zone 4 Talisay, Batangas", "Zone 3 Talisay, Batangas", "Zone 2 Talisay, Batangas", "Zone 1 Talisay, Batangas", "Sitio, Tabla Talisay, Batangas", "San Isidro Talisay, Batangas", "Banga Talisay, Batangas", "Sta. Maria Talisay, Batangas", "Balas Talisay, Batangas", "Buco Talisay, Batangas", "Caloocan Talisay, Batangas", "Leynes Talisay, Batangas", "Sampaloc Talisay, Batangas"})
        Me.txtownersaddress.Location = New System.Drawing.Point(385, 47)
        Me.txtownersaddress.Name = "txtownersaddress"
        Me.txtownersaddress.Size = New System.Drawing.Size(261, 26)
        Me.txtownersaddress.TabIndex = 54
        '
        'cmbgender
        '
        Me.cmbgender.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(90, 50)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(143, 26)
        Me.cmbgender.TabIndex = 19
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(4, 50)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(61, 18)
        Me.lblgender.TabIndex = 17
        Me.lblgender.Text = "Gender:"
        '
        'lblownersaddress
        '
        Me.lblownersaddress.AutoSize = True
        Me.lblownersaddress.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersaddress.Location = New System.Drawing.Point(267, 50)
        Me.lblownersaddress.Name = "lblownersaddress"
        Me.lblownersaddress.Size = New System.Drawing.Size(128, 18)
        Me.lblownersaddress.TabIndex = 7
        Me.lblownersaddress.Text = "Owners Address: "
        '
        'txtMI
        '
        Me.txtMI.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI.Location = New System.Drawing.Point(597, 15)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(36, 25)
        Me.txtMI.TabIndex = 5
        '
        'lblmi
        '
        Me.lblmi.AutoSize = True
        Me.lblmi.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmi.Location = New System.Drawing.Point(550, 18)
        Me.lblmi.Name = "lblmi"
        Me.lblmi.Size = New System.Drawing.Size(29, 18)
        Me.lblmi.TabIndex = 4
        Me.lblmi.Text = "MI:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(385, 15)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(154, 25)
        Me.txtfirstname.TabIndex = 3
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(267, 18)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(87, 18)
        Me.lblfirstname.TabIndex = 2
        Me.lblfirstname.Text = "First Name:"
        '
        'txtlastname
        '
        Me.txtlastname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(90, 15)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(143, 25)
        Me.txtlastname.TabIndex = 1
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(4, 18)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(85, 18)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "Last Name:"
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
        Me.identi.Controls.Add(Me.lblpermit)
        Me.identi.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.identi.Location = New System.Drawing.Point(18, 260)
        Me.identi.Name = "identi"
        Me.identi.Size = New System.Drawing.Size(757, 300)
        Me.identi.TabIndex = 49
        '
        'txtbusinessaddress
        '
        Me.txtbusinessaddress.FormattingEnabled = True
        Me.txtbusinessaddress.Items.AddRange(New Object() {"Aya Talisay, Batangas", "Quiling Talisay, Batangas", "Tumaway Talisay, Batangas", "Zone 8 Talisay, Batangas", "Zone 7 Talisay, Batangas", "Zone 6 Talisay, Batangas", "Zone 5 Talisay, Batangas", "Zone 4 Talisay, Batangas", "Zone 3 Talisay, Batangas", "Zone 2 Talisay, Batangas", "Zone 1 Talisay, Batangas", "Sitio, Tabla Talisay, Batangas", "San Isidro Talisay, Batangas", "Banga Talisay, Batangas", "Sta. Maria Talisay, Batangas", "Balas Talisay, Batangas", "Buco Talisay, Batangas", "Caloocan Talisay, Batangas", "Leynes Talisay, Batangas", "Sampaloc Talisay, Batangas"})
        Me.txtbusinessaddress.Location = New System.Drawing.Point(213, 144)
        Me.txtbusinessaddress.Name = "txtbusinessaddress"
        Me.txtbusinessaddress.Size = New System.Drawing.Size(261, 26)
        Me.txtbusinessaddress.TabIndex = 53
        '
        'cmborganization
        '
        Me.cmborganization.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborganization.FormattingEnabled = True
        Me.cmborganization.Items.AddRange(New Object() {"Sole Proprietorship", "General Partnership"})
        Me.cmborganization.Location = New System.Drawing.Point(213, 176)
        Me.cmborganization.Name = "cmborganization"
        Me.cmborganization.Size = New System.Drawing.Size(262, 26)
        Me.cmborganization.TabIndex = 52
        '
        'lblorganization
        '
        Me.lblorganization.AutoSize = True
        Me.lblorganization.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorganization.Location = New System.Drawing.Point(9, 181)
        Me.lblorganization.Name = "lblorganization"
        Me.lblorganization.Size = New System.Drawing.Size(203, 18)
        Me.lblorganization.TabIndex = 51
        Me.lblorganization.Text = "Business Organization Type:"
        '
        'lblPHP
        '
        Me.lblPHP.AutoSize = True
        Me.lblPHP.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHP.Location = New System.Drawing.Point(545, 176)
        Me.lblPHP.Name = "lblPHP"
        Me.lblPHP.Size = New System.Drawing.Size(136, 43)
        Me.lblPHP.TabIndex = 48
        Me.lblPHP.Text = "Amount"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnshow.Location = New System.Drawing.Point(681, 76)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(67, 27)
        Me.btnshow.TabIndex = 47
        Me.btnshow.Text = "Update"
        Me.btnshow.UseVisualStyleBackColor = True
        Me.btnshow.Visible = False
        '
        'DTPExpireddate
        '
        Me.DTPExpireddate.Enabled = False
        Me.DTPExpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPExpireddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPExpireddate.Location = New System.Drawing.Point(448, 77)
        Me.DTPExpireddate.Name = "DTPExpireddate"
        Me.DTPExpireddate.Size = New System.Drawing.Size(227, 25)
        Me.DTPExpireddate.TabIndex = 46
        '
        'lblexpireddate
        '
        Me.lblexpireddate.AutoSize = True
        Me.lblexpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpireddate.Location = New System.Drawing.Point(351, 82)
        Me.lblexpireddate.Name = "lblexpireddate"
        Me.lblexpireddate.Size = New System.Drawing.Size(100, 18)
        Me.lblexpireddate.TabIndex = 45
        Me.lblexpireddate.Text = "Expired Date:"
        '
        'cmbbusinesstype
        '
        Me.cmbbusinesstype.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbusinesstype.FormattingEnabled = True
        Me.cmbbusinesstype.Items.AddRange(New Object() {"Canteen ", "Sari Sari Store", "Computer Shop", "Motorcycle Shop", "Car Shop", "Convenience Store", "Gas Station", "Restraurant", "Grocery Store", "Resort"})
        Me.cmbbusinesstype.Location = New System.Drawing.Point(162, 209)
        Me.cmbbusinesstype.Name = "cmbbusinesstype"
        Me.cmbbusinesstype.Size = New System.Drawing.Size(312, 26)
        Me.cmbbusinesstype.TabIndex = 44
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(545, 209)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(38, 43)
        Me.lblamount.TabIndex = 43
        Me.lblamount.Text = "0"
        '
        'bt
        '
        Me.bt.AutoSize = True
        Me.bt.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt.Location = New System.Drawing.Point(9, 212)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(113, 18)
        Me.bt.TabIndex = 40
        Me.bt.Text = "Business Type:"
        '
        'txtmayorspermit
        '
        Me.txtmayorspermit.Font = New System.Drawing.Font("Arial Unicode MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmayorspermit.Location = New System.Drawing.Point(321, 14)
        Me.txtmayorspermit.Name = "txtmayorspermit"
        Me.txtmayorspermit.Size = New System.Drawing.Size(312, 44)
        Me.txtmayorspermit.TabIndex = 23
        '
        'mp
        '
        Me.mp.AutoSize = True
        Me.mp.Font = New System.Drawing.Font("Arial Unicode MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mp.Location = New System.Drawing.Point(97, 17)
        Me.mp.Name = "mp"
        Me.mp.Size = New System.Drawing.Size(218, 36)
        Me.mp.TabIndex = 22
        Me.mp.Text = "Mayor's Permit:"
        '
        'addnum
        '
        Me.addnum.AutoSize = True
        Me.addnum.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnum.Location = New System.Drawing.Point(9, 147)
        Me.addnum.Name = "addnum"
        Me.addnum.Size = New System.Drawing.Size(135, 18)
        Me.addnum.TabIndex = 30
        Me.addnum.Text = "Business Address:"
        '
        'txtbusinessname
        '
        Me.txtbusinessname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusinessname.Location = New System.Drawing.Point(145, 112)
        Me.txtbusinessname.Name = "txtbusinessname"
        Me.txtbusinessname.Size = New System.Drawing.Size(603, 25)
        Me.txtbusinessname.TabIndex = 29
        '
        'bname
        '
        Me.bname.AutoSize = True
        Me.bname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bname.Location = New System.Drawing.Point(9, 117)
        Me.bname.Name = "bname"
        Me.bname.Size = New System.Drawing.Size(118, 18)
        Me.bname.TabIndex = 28
        Me.bname.Text = "Business Name:"
        '
        'txtcellphonenumber
        '
        Me.txtcellphonenumber.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcellphonenumber.Location = New System.Drawing.Point(162, 242)
        Me.txtcellphonenumber.MaxLength = 11
        Me.txtcellphonenumber.Name = "txtcellphonenumber"
        Me.txtcellphonenumber.Size = New System.Drawing.Size(312, 25)
        Me.txtcellphonenumber.TabIndex = 27
        '
        'cpnumb
        '
        Me.cpnumb.AutoSize = True
        Me.cpnumb.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpnumb.Location = New System.Drawing.Point(7, 245)
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
        Me.DTPpermitdate.Location = New System.Drawing.Point(99, 79)
        Me.DTPpermitdate.Name = "DTPpermitdate"
        Me.DTPpermitdate.Size = New System.Drawing.Size(227, 25)
        Me.DTPpermitdate.TabIndex = 25
        '
        'lblpermit
        '
        Me.lblpermit.AutoSize = True
        Me.lblpermit.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpermit.Location = New System.Drawing.Point(9, 83)
        Me.lblpermit.Name = "lblpermit"
        Me.lblpermit.Size = New System.Drawing.Size(93, 18)
        Me.lblpermit.TabIndex = 24
        Me.lblpermit.Text = "Permit Date:"
        '
        'req
        '
        Me.req.Controls.Add(Me.chckboxCHECKALL)
        Me.req.Controls.Add(Me.chckboxbrgyclearance)
        Me.req.Controls.Add(Me.chckboxTIN)
        Me.req.Controls.Add(Me.chckboxDTI)
        Me.req.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.req.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.req.Location = New System.Drawing.Point(20, 111)
        Me.req.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.req.Name = "req"
        Me.req.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.req.Size = New System.Drawing.Size(755, 122)
        Me.req.TabIndex = 48
        Me.req.TabStop = False
        Me.req.Text = "Requirements"
        '
        'chckboxCHECKALL
        '
        Me.chckboxCHECKALL.AutoSize = True
        Me.chckboxCHECKALL.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxCHECKALL.Location = New System.Drawing.Point(48, 24)
        Me.chckboxCHECKALL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chckboxCHECKALL.Name = "chckboxCHECKALL"
        Me.chckboxCHECKALL.Size = New System.Drawing.Size(92, 22)
        Me.chckboxCHECKALL.TabIndex = 3
        Me.chckboxCHECKALL.Text = "Check All"
        Me.chckboxCHECKALL.UseVisualStyleBackColor = True
        '
        'chckboxbrgyclearance
        '
        Me.chckboxbrgyclearance.AutoSize = True
        Me.chckboxbrgyclearance.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxbrgyclearance.Location = New System.Drawing.Point(48, 55)
        Me.chckboxbrgyclearance.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chckboxbrgyclearance.Name = "chckboxbrgyclearance"
        Me.chckboxbrgyclearance.Size = New System.Drawing.Size(162, 22)
        Me.chckboxbrgyclearance.TabIndex = 0
        Me.chckboxbrgyclearance.Text = "Barangay Clearance"
        Me.chckboxbrgyclearance.UseVisualStyleBackColor = True
        '
        'chckboxTIN
        '
        Me.chckboxTIN.AutoSize = True
        Me.chckboxTIN.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxTIN.Location = New System.Drawing.Point(48, 88)
        Me.chckboxTIN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chckboxTIN.Name = "chckboxTIN"
        Me.chckboxTIN.Size = New System.Drawing.Size(238, 22)
        Me.chckboxTIN.TabIndex = 2
        Me.chckboxTIN.Text = "Tax Identification Number (TIN)"
        Me.chckboxTIN.UseVisualStyleBackColor = True
        '
        'chckboxDTI
        '
        Me.chckboxDTI.AutoSize = True
        Me.chckboxDTI.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxDTI.Location = New System.Drawing.Point(401, 36)
        Me.chckboxDTI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chckboxDTI.Name = "chckboxDTI"
        Me.chckboxDTI.Size = New System.Drawing.Size(244, 58)
        Me.chckboxDTI.TabIndex = 1
        Me.chckboxDTI.Text = "Documento na sa katunayan ay " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nakarehistro ang negosyo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      (DTI/SEC/CDA)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chckboxDTI.UseVisualStyleBackColor = True
        '
        'busiden
        '
        Me.busiden.AutoSize = True
        Me.busiden.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busiden.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.busiden.Location = New System.Drawing.Point(298, 234)
        Me.busiden.Name = "busiden"
        Me.busiden.Size = New System.Drawing.Size(162, 18)
        Me.busiden.TabIndex = 51
        Me.busiden.Text = "Business Identification"
        '
        'picboxclient
        '
        Me.picboxclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxclient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxclient.Location = New System.Drawing.Point(796, 120)
        Me.picboxclient.Name = "picboxclient"
        Me.picboxclient.Size = New System.Drawing.Size(207, 190)
        Me.picboxclient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxclient.TabIndex = 58
        Me.picboxclient.TabStop = False
        '
        'btnchoose
        '
        Me.btnchoose.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnchoose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnchoose.FlatAppearance.BorderSize = 0
        Me.btnchoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnchoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnchoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchoose.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchoose.ForeColor = System.Drawing.Color.White
        Me.btnchoose.Image = CType(resources.GetObject("btnchoose.Image"), System.Drawing.Image)
        Me.btnchoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchoose.Location = New System.Drawing.Point(845, 316)
        Me.btnchoose.Name = "btnchoose"
        Me.btnchoose.Size = New System.Drawing.Size(113, 36)
        Me.btnchoose.TabIndex = 59
        Me.btnchoose.Text = "Choose"
        Me.btnchoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnchoose.UseVisualStyleBackColor = False
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
        Me.btnsave.Location = New System.Drawing.Point(845, 358)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(113, 36)
        Me.btnsave.TabIndex = 60
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
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
        Me.btnclose.Location = New System.Drawing.Point(845, 400)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(113, 36)
        Me.btnclose.TabIndex = 61
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnback)
        Me.pnlheader.Controls.Add(Me.lbltitle)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1024, 104)
        Me.pnlheader.TabIndex = 62
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
        Me.lbltitle.Location = New System.Drawing.Point(278, 26)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(460, 55)
        Me.lbltitle.TabIndex = 6
        Me.lbltitle.Text = "Add New Business"
        '
        'New_BPLO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 704)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnchoose)
        Me.Controls.Add(Me.picboxclient)
        Me.Controls.Add(Me.txtownersID)
        Me.Controls.Add(Me.lblownersID)
        Me.Controls.Add(Me.owninfo)
        Me.Controls.Add(Me.ownerinfo)
        Me.Controls.Add(Me.identi)
        Me.Controls.Add(Me.req)
        Me.Controls.Add(Me.busiden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "New_BPLO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPLO NEWLY APPLIED BUSINESS"
        Me.ownerinfo.ResumeLayout(False)
        Me.ownerinfo.PerformLayout()
        Me.identi.ResumeLayout(False)
        Me.identi.PerformLayout()
        Me.req.ResumeLayout(False)
        Me.req.PerformLayout()
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtownersID As System.Windows.Forms.TextBox
    Friend WithEvents lblownersID As System.Windows.Forms.Label
    Friend WithEvents owninfo As System.Windows.Forms.Label
    Friend WithEvents ownerinfo As System.Windows.Forms.Panel
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblownersaddress As System.Windows.Forms.Label
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents lblmi As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents identi As System.Windows.Forms.Panel
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents DTPExpireddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblexpireddate As System.Windows.Forms.Label
    Friend WithEvents cmbbusinesstype As System.Windows.Forms.ComboBox
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents bt As System.Windows.Forms.Label
    Friend WithEvents txtmayorspermit As System.Windows.Forms.TextBox
    Friend WithEvents mp As System.Windows.Forms.Label
    Friend WithEvents addnum As System.Windows.Forms.Label
    Friend WithEvents txtbusinessname As System.Windows.Forms.TextBox
    Friend WithEvents bname As System.Windows.Forms.Label
    Friend WithEvents txtcellphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents cpnumb As System.Windows.Forms.Label
    Friend WithEvents DTPpermitdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblpermit As System.Windows.Forms.Label
    Friend WithEvents req As System.Windows.Forms.GroupBox
    Friend WithEvents chckboxCHECKALL As System.Windows.Forms.CheckBox
    Friend WithEvents chckboxbrgyclearance As System.Windows.Forms.CheckBox
    Friend WithEvents chckboxTIN As System.Windows.Forms.CheckBox
    Friend WithEvents chckboxDTI As System.Windows.Forms.CheckBox
    Friend WithEvents busiden As System.Windows.Forms.Label
    Friend WithEvents picboxclient As System.Windows.Forms.PictureBox
    Friend WithEvents lblPHP As System.Windows.Forms.Label
    Friend WithEvents cmborganization As System.Windows.Forms.ComboBox
    Friend WithEvents lblorganization As System.Windows.Forms.Label
    Friend WithEvents btnchoose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents txtbusinessaddress As System.Windows.Forms.ComboBox
    Friend WithEvents txtownersaddress As System.Windows.Forms.ComboBox
End Class

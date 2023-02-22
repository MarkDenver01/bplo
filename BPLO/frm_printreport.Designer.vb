<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_printreport))
        Me.lblexpireddate = New System.Windows.Forms.Label()
        Me.lblorganization = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.txtownersID = New System.Windows.Forms.TextBox()
        Me.picboxclient = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.cmbgender = New System.Windows.Forms.TextBox()
        Me.DTPExpireddate = New System.Windows.Forms.TextBox()
        Me.DTPpermitdate = New System.Windows.Forms.TextBox()
        Me.cmbbusinesstype = New System.Windows.Forms.TextBox()
        Me.cmborganization = New System.Windows.Forms.TextBox()
        Me.lblnameoftreasurer = New System.Windows.Forms.Label()
        Me.txttresurer = New System.Windows.Forms.TextBox()
        Me.lblamountentry = New System.Windows.Forms.Label()
        Me.txtamountentry = New System.Windows.Forms.TextBox()
        Me.txtownersaddress = New System.Windows.Forms.TextBox()
        Me.lblownersaddress = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblownersID = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.bt = New System.Windows.Forms.Label()
        Me.txtbusinessaddress = New System.Windows.Forms.TextBox()
        Me.txtmayorspermit = New System.Windows.Forms.TextBox()
        Me.mp = New System.Windows.Forms.Label()
        Me.addnum = New System.Windows.Forms.Label()
        Me.txtbusinessname = New System.Windows.Forms.TextBox()
        Me.bname = New System.Windows.Forms.Label()
        Me.txtcellphonenumber = New System.Windows.Forms.TextBox()
        Me.cpnumb = New System.Windows.Forms.Label()
        Me.permit = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblexpireddate
        '
        Me.lblexpireddate.AutoSize = True
        Me.lblexpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpireddate.ForeColor = System.Drawing.Color.Black
        Me.lblexpireddate.Location = New System.Drawing.Point(622, 316)
        Me.lblexpireddate.Name = "lblexpireddate"
        Me.lblexpireddate.Size = New System.Drawing.Size(82, 15)
        Me.lblexpireddate.TabIndex = 45
        Me.lblexpireddate.Text = "Expired Date"
        '
        'lblorganization
        '
        Me.lblorganization.AutoSize = True
        Me.lblorganization.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorganization.ForeColor = System.Drawing.Color.Black
        Me.lblorganization.Location = New System.Drawing.Point(52, 387)
        Me.lblorganization.Name = "lblorganization"
        Me.lblorganization.Size = New System.Drawing.Size(175, 15)
        Me.lblorganization.TabIndex = 53
        Me.lblorganization.Text = "Business Organization Type:"
        '
        'txtstatus
        '
        Me.txtstatus.Enabled = False
        Me.txtstatus.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(138, 196)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(43, 25)
        Me.txtstatus.TabIndex = 90
        Me.txtstatus.Visible = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Black
        Me.Status.Location = New System.Drawing.Point(54, 198)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(57, 18)
        Me.Status.TabIndex = 89
        Me.Status.Text = "Status:"
        Me.Status.Visible = False
        '
        'txtownersID
        '
        Me.txtownersID.Enabled = False
        Me.txtownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownersID.Location = New System.Drawing.Point(138, 162)
        Me.txtownersID.Name = "txtownersID"
        Me.txtownersID.Size = New System.Drawing.Size(43, 25)
        Me.txtownersID.TabIndex = 88
        Me.txtownersID.Visible = False
        '
        'picboxclient
        '
        Me.picboxclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxclient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxclient.Location = New System.Drawing.Point(28, 16)
        Me.picboxclient.Name = "picboxclient"
        Me.picboxclient.Size = New System.Drawing.Size(173, 128)
        Me.picboxclient.TabIndex = 82
        Me.picboxclient.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.btnclose)
        Me.panel1.Controls.Add(Me.cmbgender)
        Me.panel1.Controls.Add(Me.btnprint)
        Me.panel1.Controls.Add(Me.DTPExpireddate)
        Me.panel1.Controls.Add(Me.DTPpermitdate)
        Me.panel1.Controls.Add(Me.cmbbusinesstype)
        Me.panel1.Controls.Add(Me.cmborganization)
        Me.panel1.Controls.Add(Me.lblnameoftreasurer)
        Me.panel1.Controls.Add(Me.txttresurer)
        Me.panel1.Controls.Add(Me.lblamountentry)
        Me.panel1.Controls.Add(Me.txtamountentry)
        Me.panel1.Controls.Add(Me.txtstatus)
        Me.panel1.Controls.Add(Me.Status)
        Me.panel1.Controls.Add(Me.txtownersaddress)
        Me.panel1.Controls.Add(Me.lblownersaddress)
        Me.panel1.Controls.Add(Me.lblgender)
        Me.panel1.Controls.Add(Me.lblorganization)
        Me.panel1.Controls.Add(Me.txtownersID)
        Me.panel1.Controls.Add(Me.lblownersID)
        Me.panel1.Controls.Add(Me.picboxclient)
        Me.panel1.Controls.Add(Me.txtlastname)
        Me.panel1.Controls.Add(Me.lbllastname)
        Me.panel1.Controls.Add(Me.lblexpireddate)
        Me.panel1.Controls.Add(Me.bt)
        Me.panel1.Controls.Add(Me.txtbusinessaddress)
        Me.panel1.Controls.Add(Me.txtmayorspermit)
        Me.panel1.Controls.Add(Me.mp)
        Me.panel1.Controls.Add(Me.addnum)
        Me.panel1.Controls.Add(Me.txtbusinessname)
        Me.panel1.Controls.Add(Me.bname)
        Me.panel1.Controls.Add(Me.txtcellphonenumber)
        Me.panel1.Controls.Add(Me.cpnumb)
        Me.panel1.Controls.Add(Me.permit)
        Me.panel1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(821, 482)
        Me.panel1.TabIndex = 83
        '
        'cmbgender
        '
        Me.cmbgender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbgender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmbgender.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.Location = New System.Drawing.Point(292, 175)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(234, 18)
        Me.cmbgender.TabIndex = 99
        Me.cmbgender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTPExpireddate
        '
        Me.DTPExpireddate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTPExpireddate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPExpireddate.Location = New System.Drawing.Point(548, 294)
        Me.DTPExpireddate.Name = "DTPExpireddate"
        Me.DTPExpireddate.Size = New System.Drawing.Size(234, 18)
        Me.DTPExpireddate.TabIndex = 98
        Me.DTPExpireddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTPpermitdate
        '
        Me.DTPpermitdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTPpermitdate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPpermitdate.Location = New System.Drawing.Point(295, 294)
        Me.DTPpermitdate.Name = "DTPpermitdate"
        Me.DTPpermitdate.Size = New System.Drawing.Size(234, 18)
        Me.DTPpermitdate.TabIndex = 97
        Me.DTPpermitdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbbusinesstype
        '
        Me.cmbbusinesstype.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmbbusinesstype.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbusinesstype.Location = New System.Drawing.Point(28, 356)
        Me.cmbbusinesstype.Name = "cmbbusinesstype"
        Me.cmbbusinesstype.Size = New System.Drawing.Size(222, 18)
        Me.cmbbusinesstype.TabIndex = 96
        Me.cmbbusinesstype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmborganization
        '
        Me.cmborganization.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmborganization.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborganization.Location = New System.Drawing.Point(28, 403)
        Me.cmborganization.Name = "cmborganization"
        Me.cmborganization.Size = New System.Drawing.Size(222, 18)
        Me.cmborganization.TabIndex = 95
        Me.cmborganization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnameoftreasurer
        '
        Me.lblnameoftreasurer.AutoSize = True
        Me.lblnameoftreasurer.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameoftreasurer.ForeColor = System.Drawing.Color.Black
        Me.lblnameoftreasurer.Location = New System.Drawing.Point(605, 380)
        Me.lblnameoftreasurer.Name = "lblnameoftreasurer"
        Me.lblnameoftreasurer.Size = New System.Drawing.Size(116, 15)
        Me.lblnameoftreasurer.TabIndex = 94
        Me.lblnameoftreasurer.Text = "Name of Treasurer"
        '
        'txttresurer
        '
        Me.txttresurer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttresurer.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttresurer.Location = New System.Drawing.Point(548, 355)
        Me.txttresurer.Name = "txttresurer"
        Me.txttresurer.Size = New System.Drawing.Size(234, 18)
        Me.txttresurer.TabIndex = 93
        Me.txttresurer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblamountentry
        '
        Me.lblamountentry.AutoSize = True
        Me.lblamountentry.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountentry.ForeColor = System.Drawing.Color.Black
        Me.lblamountentry.Location = New System.Drawing.Point(367, 380)
        Me.lblamountentry.Name = "lblamountentry"
        Me.lblamountentry.Size = New System.Drawing.Size(84, 15)
        Me.lblamountentry.TabIndex = 92
        Me.lblamountentry.Text = "Amount Entry"
        '
        'txtamountentry
        '
        Me.txtamountentry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtamountentry.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamountentry.Location = New System.Drawing.Point(292, 355)
        Me.txtamountentry.Name = "txtamountentry"
        Me.txtamountentry.Size = New System.Drawing.Size(237, 18)
        Me.txtamountentry.TabIndex = 91
        Me.txtamountentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtownersaddress
        '
        Me.txtownersaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtownersaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtownersaddress.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownersaddress.Location = New System.Drawing.Point(548, 175)
        Me.txtownersaddress.Name = "txtownersaddress"
        Me.txtownersaddress.Size = New System.Drawing.Size(234, 18)
        Me.txtownersaddress.TabIndex = 8
        Me.txtownersaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblownersaddress
        '
        Me.lblownersaddress.AutoSize = True
        Me.lblownersaddress.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersaddress.ForeColor = System.Drawing.Color.Black
        Me.lblownersaddress.Location = New System.Drawing.Point(613, 196)
        Me.lblownersaddress.Name = "lblownersaddress"
        Me.lblownersaddress.Size = New System.Drawing.Size(104, 15)
        Me.lblownersaddress.TabIndex = 7
        Me.lblownersaddress.Text = "Owners Address"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.Color.Black
        Me.lblgender.Location = New System.Drawing.Point(388, 196)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(50, 15)
        Me.lblgender.TabIndex = 17
        Me.lblgender.Text = "Gender"
        '
        'lblownersID
        '
        Me.lblownersID.AutoSize = True
        Me.lblownersID.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownersID.ForeColor = System.Drawing.Color.Black
        Me.lblownersID.Location = New System.Drawing.Point(51, 164)
        Me.lblownersID.Name = "lblownersID"
        Me.lblownersID.Size = New System.Drawing.Size(80, 18)
        Me.lblownersID.TabIndex = 87
        Me.lblownersID.Text = "Owner's ID"
        Me.lblownersID.Visible = False
        '
        'txtlastname
        '
        Me.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlastname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(292, 126)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(487, 18)
        Me.txtlastname.TabIndex = 1
        Me.txtlastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.ForeColor = System.Drawing.Color.Black
        Me.lbllastname.Location = New System.Drawing.Point(510, 147)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(39, 15)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "Name"
        '
        'bt
        '
        Me.bt.AutoSize = True
        Me.bt.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt.ForeColor = System.Drawing.Color.Black
        Me.bt.Location = New System.Drawing.Point(83, 340)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(97, 15)
        Me.bt.TabIndex = 40
        Me.bt.Text = "Business Type:"
        '
        'txtbusinessaddress
        '
        Me.txtbusinessaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusinessaddress.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusinessaddress.Location = New System.Drawing.Point(28, 307)
        Me.txtbusinessaddress.Name = "txtbusinessaddress"
        Me.txtbusinessaddress.Size = New System.Drawing.Size(222, 18)
        Me.txtbusinessaddress.TabIndex = 31
        Me.txtbusinessaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmayorspermit
        '
        Me.txtmayorspermit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmayorspermit.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmayorspermit.Location = New System.Drawing.Point(430, 242)
        Me.txtmayorspermit.Name = "txtmayorspermit"
        Me.txtmayorspermit.Size = New System.Drawing.Size(234, 18)
        Me.txtmayorspermit.TabIndex = 23
        Me.txtmayorspermit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mp
        '
        Me.mp.AutoSize = True
        Me.mp.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mp.ForeColor = System.Drawing.Color.Black
        Me.mp.Location = New System.Drawing.Point(495, 265)
        Me.mp.Name = "mp"
        Me.mp.Size = New System.Drawing.Size(93, 15)
        Me.mp.TabIndex = 22
        Me.mp.Text = "Mayor's Permit"
        '
        'addnum
        '
        Me.addnum.AutoSize = True
        Me.addnum.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnum.ForeColor = System.Drawing.Color.Black
        Me.addnum.Location = New System.Drawing.Point(75, 291)
        Me.addnum.Name = "addnum"
        Me.addnum.Size = New System.Drawing.Size(116, 15)
        Me.addnum.TabIndex = 30
        Me.addnum.Text = "Business Address:"
        '
        'txtbusinessname
        '
        Me.txtbusinessname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusinessname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusinessname.Location = New System.Drawing.Point(28, 264)
        Me.txtbusinessname.Name = "txtbusinessname"
        Me.txtbusinessname.Size = New System.Drawing.Size(222, 18)
        Me.txtbusinessname.TabIndex = 29
        Me.txtbusinessname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bname
        '
        Me.bname.AutoSize = True
        Me.bname.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bname.ForeColor = System.Drawing.Color.Black
        Me.bname.Location = New System.Drawing.Point(83, 248)
        Me.bname.Name = "bname"
        Me.bname.Size = New System.Drawing.Size(100, 15)
        Me.bname.TabIndex = 28
        Me.bname.Text = "Business Name:"
        '
        'txtcellphonenumber
        '
        Me.txtcellphonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcellphonenumber.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcellphonenumber.Location = New System.Drawing.Point(28, 450)
        Me.txtcellphonenumber.MaxLength = 11
        Me.txtcellphonenumber.Name = "txtcellphonenumber"
        Me.txtcellphonenumber.Size = New System.Drawing.Size(222, 18)
        Me.txtcellphonenumber.TabIndex = 27
        Me.txtcellphonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cpnumb
        '
        Me.cpnumb.AutoSize = True
        Me.cpnumb.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpnumb.ForeColor = System.Drawing.Color.Black
        Me.cpnumb.Location = New System.Drawing.Point(80, 434)
        Me.cpnumb.Name = "cpnumb"
        Me.cpnumb.Size = New System.Drawing.Size(116, 15)
        Me.cpnumb.TabIndex = 26
        Me.cpnumb.Text = "Cellphone Number:"
        '
        'permit
        '
        Me.permit.AutoSize = True
        Me.permit.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permit.ForeColor = System.Drawing.Color.Black
        Me.permit.Location = New System.Drawing.Point(368, 317)
        Me.permit.Name = "permit"
        Me.permit.Size = New System.Drawing.Size(74, 15)
        Me.permit.TabIndex = 24
        Me.permit.Text = "Permit Date"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnprint.FlatAppearance.BorderSize = 0
        Me.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprint.Location = New System.Drawing.Point(562, 431)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(113, 36)
        Me.btnprint.TabIndex = 84
        Me.btnprint.Text = "Print"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprint.UseVisualStyleBackColor = False
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
        Me.btnclose.Location = New System.Drawing.Point(681, 432)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(113, 36)
        Me.btnclose.TabIndex = 100
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 50)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "INFORMATION ACCOUNT"
        '
        'frm_printreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 483)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_printreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_renwew_treasurer"
        CType(Me.picboxclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblexpireddate As System.Windows.Forms.Label
    Friend WithEvents lblorganization As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents txtownersID As System.Windows.Forms.TextBox
    Friend WithEvents picboxclient As System.Windows.Forms.PictureBox
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt As System.Windows.Forms.Label
    Friend WithEvents txtbusinessaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtmayorspermit As System.Windows.Forms.TextBox
    Friend WithEvents mp As System.Windows.Forms.Label
    Friend WithEvents addnum As System.Windows.Forms.Label
    Friend WithEvents txtbusinessname As System.Windows.Forms.TextBox
    Friend WithEvents bname As System.Windows.Forms.Label
    Friend WithEvents txtcellphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents cpnumb As System.Windows.Forms.Label
    Friend WithEvents permit As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents txtownersaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblownersaddress As System.Windows.Forms.Label
    Friend WithEvents lblownersID As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblnameoftreasurer As System.Windows.Forms.Label
    Friend WithEvents txttresurer As System.Windows.Forms.TextBox
    Friend WithEvents lblamountentry As System.Windows.Forms.Label
    Friend WithEvents txtamountentry As System.Windows.Forms.TextBox
    Friend WithEvents cmborganization As System.Windows.Forms.TextBox
    Friend WithEvents cmbbusinesstype As System.Windows.Forms.TextBox
    Friend WithEvents DTPExpireddate As System.Windows.Forms.TextBox
    Friend WithEvents DTPpermitdate As System.Windows.Forms.TextBox
    Friend WithEvents cmbgender As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

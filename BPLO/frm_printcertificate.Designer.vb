<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printcertificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_printcertificate))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.pnlcert = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtplatenymber = New System.Windows.Forms.Label()
        Me.txtexpiry = New System.Windows.Forms.Label()
        Me.txtissue = New System.Windows.Forms.Label()
        Me.txtbarangay = New System.Windows.Forms.Label()
        Me.txtyear = New System.Windows.Forms.Label()
        Me.txtregistrationtype = New System.Windows.Forms.Label()
        Me.txtbusinessorgtype = New System.Windows.Forms.Label()
        Me.txtownersname = New System.Windows.Forms.Label()
        Me.txtbusinessname = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.pnlcert.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
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
        Me.btnprint.Location = New System.Drawing.Point(414, 594)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(113, 36)
        Me.btnprint.TabIndex = 101
        Me.btnprint.Text = "Print"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'pnlcert
        '
        Me.pnlcert.BackgroundImage = CType(resources.GetObject("pnlcert.BackgroundImage"), System.Drawing.Image)
        Me.pnlcert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlcert.Controls.Add(Me.Panel4)
        Me.pnlcert.Controls.Add(Me.Panel3)
        Me.pnlcert.Controls.Add(Me.Panel2)
        Me.pnlcert.Controls.Add(Me.Panel1)
        Me.pnlcert.Controls.Add(Me.txtplatenymber)
        Me.pnlcert.Controls.Add(Me.txtexpiry)
        Me.pnlcert.Controls.Add(Me.txtissue)
        Me.pnlcert.Controls.Add(Me.txtbarangay)
        Me.pnlcert.Controls.Add(Me.txtyear)
        Me.pnlcert.Controls.Add(Me.txtregistrationtype)
        Me.pnlcert.Controls.Add(Me.txtbusinessorgtype)
        Me.pnlcert.Controls.Add(Me.txtownersname)
        Me.pnlcert.Controls.Add(Me.txtbusinessname)
        Me.pnlcert.Location = New System.Drawing.Point(12, 11)
        Me.pnlcert.Name = "pnlcert"
        Me.pnlcert.Size = New System.Drawing.Size(643, 577)
        Me.pnlcert.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(344, 265)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 17)
        Me.Panel4.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(23, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 20)
        Me.Panel3.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(30, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 20)
        Me.Panel2.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(24, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 49)
        Me.Panel1.TabIndex = 11
        '
        'txtplatenymber
        '
        Me.txtplatenymber.AutoSize = True
        Me.txtplatenymber.BackColor = System.Drawing.Color.Transparent
        Me.txtplatenymber.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplatenymber.Location = New System.Drawing.Point(470, 168)
        Me.txtplatenymber.Name = "txtplatenymber"
        Me.txtplatenymber.Size = New System.Drawing.Size(99, 23)
        Me.txtplatenymber.TabIndex = 10
        Me.txtplatenymber.Text = "NUMBER"
        '
        'txtexpiry
        '
        Me.txtexpiry.AutoSize = True
        Me.txtexpiry.BackColor = System.Drawing.Color.Transparent
        Me.txtexpiry.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpiry.Location = New System.Drawing.Point(431, 297)
        Me.txtexpiry.Name = "txtexpiry"
        Me.txtexpiry.Size = New System.Drawing.Size(42, 15)
        Me.txtexpiry.TabIndex = 9
        Me.txtexpiry.Text = "Expiry"
        '
        'txtissue
        '
        Me.txtissue.AutoSize = True
        Me.txtissue.BackColor = System.Drawing.Color.Transparent
        Me.txtissue.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtissue.Location = New System.Drawing.Point(428, 281)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(36, 15)
        Me.txtissue.TabIndex = 8
        Me.txtissue.Text = "Issue"
        '
        'txtbarangay
        '
        Me.txtbarangay.AutoSize = True
        Me.txtbarangay.BackColor = System.Drawing.Color.Transparent
        Me.txtbarangay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarangay.Location = New System.Drawing.Point(455, 250)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(60, 15)
        Me.txtbarangay.TabIndex = 6
        Me.txtbarangay.Text = "Barangay"
        '
        'txtyear
        '
        Me.txtyear.AutoSize = True
        Me.txtyear.BackColor = System.Drawing.Color.Transparent
        Me.txtyear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(487, 102)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(66, 23)
        Me.txtyear.TabIndex = 4
        Me.txtyear.Text = "YEAR"
        '
        'txtregistrationtype
        '
        Me.txtregistrationtype.AutoSize = True
        Me.txtregistrationtype.BackColor = System.Drawing.Color.Transparent
        Me.txtregistrationtype.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationtype.Location = New System.Drawing.Point(203, 280)
        Me.txtregistrationtype.Name = "txtregistrationtype"
        Me.txtregistrationtype.Size = New System.Drawing.Size(104, 15)
        Me.txtregistrationtype.TabIndex = 3
        Me.txtregistrationtype.Text = "Registration Type"
        '
        'txtbusinessorgtype
        '
        Me.txtbusinessorgtype.AutoSize = True
        Me.txtbusinessorgtype.BackColor = System.Drawing.Color.Transparent
        Me.txtbusinessorgtype.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusinessorgtype.Location = New System.Drawing.Point(206, 264)
        Me.txtbusinessorgtype.Name = "txtbusinessorgtype"
        Me.txtbusinessorgtype.Size = New System.Drawing.Size(102, 15)
        Me.txtbusinessorgtype.TabIndex = 2
        Me.txtbusinessorgtype.Text = "Organiation Type"
        '
        'txtownersname
        '
        Me.txtownersname.AutoSize = True
        Me.txtownersname.BackColor = System.Drawing.Color.Transparent
        Me.txtownersname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownersname.Location = New System.Drawing.Point(156, 250)
        Me.txtownersname.Name = "txtownersname"
        Me.txtownersname.Size = New System.Drawing.Size(84, 15)
        Me.txtownersname.TabIndex = 1
        Me.txtownersname.Text = "Owners Name"
        '
        'txtbusinessname
        '
        Me.txtbusinessname.AutoSize = True
        Me.txtbusinessname.BackColor = System.Drawing.Color.Transparent
        Me.txtbusinessname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbusinessname.Location = New System.Drawing.Point(269, 209)
        Me.txtbusinessname.Name = "txtbusinessname"
        Me.txtbusinessname.Size = New System.Drawing.Size(92, 15)
        Me.txtbusinessname.TabIndex = 0
        Me.txtbusinessname.Text = "Business Name"
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
        Me.btnclose.Location = New System.Drawing.Point(542, 594)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(113, 36)
        Me.btnclose.TabIndex = 102
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frm_printcertificate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 655)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.pnlcert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_printcertificate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_printcertificate"
        Me.pnlcert.ResumeLayout(False)
        Me.pnlcert.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlcert As System.Windows.Forms.Panel
    Friend WithEvents txtbusinessname As System.Windows.Forms.Label
    Friend WithEvents txtownersname As System.Windows.Forms.Label
    Friend WithEvents txtbusinessorgtype As System.Windows.Forms.Label
    Friend WithEvents txtregistrationtype As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.Label
    Friend WithEvents txtplatenymber As System.Windows.Forms.Label
    Friend WithEvents txtexpiry As System.Windows.Forms.Label
    Friend WithEvents txtissue As System.Windows.Forms.Label
    Friend WithEvents txtbarangay As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class

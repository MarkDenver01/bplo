<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printreceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_printreceipt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttransactionnumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.txtcahsier = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtcahsier)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txttransactionnumber)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 348)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 14)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Talisay Batangas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtchange)
        Me.Panel2.Controls.Add(Me.txtcash)
        Me.Panel2.Controls.Add(Me.txttotalamount)
        Me.Panel2.Controls.Add(Me.lblThank)
        Me.Panel2.Controls.Add(Me.lblOR)
        Me.Panel2.Controls.Add(Me.lblLine)
        Me.Panel2.Controls.Add(Me.change)
        Me.Panel2.Controls.Add(Me.Cash)
        Me.Panel2.Controls.Add(Me.TotalAmount)
        Me.Panel2.Location = New System.Drawing.Point(10, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 136)
        Me.Panel2.TabIndex = 46
        '
        'txtchange
        '
        Me.txtchange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtchange.Location = New System.Drawing.Point(173, 55)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(100, 14)
        Me.txtchange.TabIndex = 59
        '
        'txtcash
        '
        Me.txtcash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcash.Location = New System.Drawing.Point(173, 32)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(100, 14)
        Me.txtcash.TabIndex = 58
        '
        'txttotalamount
        '
        Me.txttotalamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotalamount.Location = New System.Drawing.Point(173, 9)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Size = New System.Drawing.Size(100, 14)
        Me.txttotalamount.TabIndex = 57
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThank.Location = New System.Drawing.Point(65, 106)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(160, 13)
        Me.lblThank.TabIndex = 55
        Me.lblThank.Text = "Thank You Come Again!"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(44, 89)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(200, 13)
        Me.lblOR.TabIndex = 56
        Me.lblOR.Text = "THIS IS YOUR OFFICIAL RECEPIT"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(2, 73)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(277, 13)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "=============================="
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(1, 54)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(95, 18)
        Me.change.TabIndex = 52
        Me.change.Text = "Change    :"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(1, 35)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(93, 13)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash             :"
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(1, 12)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(91, 13)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount :"
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(190, 119)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 13)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtname
        '
        Me.txtname.AutoSize = True
        Me.txtname.Location = New System.Drawing.Point(95, 119)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(40, 13)
        Me.txtname.TabIndex = 1
        Me.txtname.Text = "Name"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(177, 97)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(103, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Client Name:"
        '
        'txttransactionnumber
        '
        Me.txttransactionnumber.AutoSize = True
        Me.txttransactionnumber.Location = New System.Drawing.Point(110, 97)
        Me.txttransactionnumber.Name = "txttransactionnumber"
        Me.txttransactionnumber.Size = New System.Drawing.Size(49, 13)
        Me.txttransactionnumber.TabIndex = 1
        Me.txttransactionnumber.Text = "Invoice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Transaction No :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(77, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "TIN#: 119-239-518"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contact No : 796-434-9402"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Municipality of Talisay"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnprint.Location = New System.Drawing.Point(192, 354)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(113, 36)
        Me.btnprint.TabIndex = 102
        Me.btnprint.Text = "Print"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'txtcahsier
        '
        Me.txtcahsier.AutoSize = True
        Me.txtcahsier.Location = New System.Drawing.Point(75, 143)
        Me.txtcahsier.Name = "txtcahsier"
        Me.txtcahsier.Size = New System.Drawing.Size(88, 13)
        Me.txtcahsier.TabIndex = 49
        Me.txtcahsier.Text = "Cashier Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Cashier :"
        '
        'frm_printreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 395)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_printreceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frm_printreceipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblThank As System.Windows.Forms.Label
    Friend WithEvents lblOR As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttransactionnumber As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txtcash As System.Windows.Forms.TextBox
    Friend WithEvents txttotalamount As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents txtcahsier As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

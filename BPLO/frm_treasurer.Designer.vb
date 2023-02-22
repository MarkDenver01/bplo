<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_treasurer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_treasurer))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txttreasurername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btnviewnewbusiness = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnviewrenewbusiness = New System.Windows.Forms.Button()
        Me.btnviewallrecords = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslUser, Me.ToolStripStatusLabel3, Me.lblDate, Me.ToolStripStatusLabel5, Me.lblTimer, Me.ToolStripStatusLabel4, Me.txttreasurername})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 701)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1364, 50)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(89, 45)
        Me.ToolStripStatusLabel1.Text = "Active User :"
        '
        'tsslUser
        '
        Me.tsslUser.ActiveLinkColor = System.Drawing.Color.White
        Me.tsslUser.AutoSize = False
        Me.tsslUser.Enabled = False
        Me.tsslUser.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslUser.ForeColor = System.Drawing.Color.White
        Me.tsslUser.LinkColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.Size = New System.Drawing.Size(150, 45)
        Me.tsslUser.Text = " "
        Me.tsslUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslUser.VisitedLinkColor = System.Drawing.Color.White
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(46, 45)
        Me.ToolStripStatusLabel3.Text = "Date :"
        '
        'lblDate
        '
        Me.lblDate.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.lblDate.AutoSize = False
        Me.lblDate.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.LinkColor = System.Drawing.Color.Maroon
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(121, 45)
        Me.lblDate.Text = " mm/dd/yyyy"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.LinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(48, 45)
        Me.ToolStripStatusLabel5.Text = "Time :"
        '
        'lblTimer
        '
        Me.lblTimer.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.lblTimer.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.LinkColor = System.Drawing.Color.Maroon
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(77, 45)
        Me.lblTimer.Text = "hh:mm:sss"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.LinkColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(106, 45)
        Me.ToolStripStatusLabel4.Text = "              Name:"
        '
        'txttreasurername
        '
        Me.txttreasurername.ActiveLinkColor = System.Drawing.Color.White
        Me.txttreasurername.AutoSize = False
        Me.txttreasurername.Enabled = False
        Me.txttreasurername.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttreasurername.ForeColor = System.Drawing.Color.White
        Me.txttreasurername.LinkColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txttreasurername.Name = "txttreasurername"
        Me.txttreasurername.Size = New System.Drawing.Size(150, 45)
        Me.txttreasurername.Text = " "
        Me.txttreasurername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txttreasurername.VisitedLinkColor = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnlogout)
        Me.pnlheader.Controls.Add(Me.btntransaction)
        Me.pnlheader.Controls.Add(Me.btnviewnewbusiness)
        Me.pnlheader.Controls.Add(Me.btnhome)
        Me.pnlheader.Controls.Add(Me.btnviewrenewbusiness)
        Me.pnlheader.Controls.Add(Me.btnviewallrecords)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1364, 101)
        Me.pnlheader.TabIndex = 19
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(1244, 61)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(117, 36)
        Me.btnlogout.TabIndex = 24
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btntransaction
        '
        Me.btntransaction.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btntransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btntransaction.FlatAppearance.BorderSize = 0
        Me.btntransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btntransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransaction.ForeColor = System.Drawing.Color.White
        Me.btntransaction.Image = CType(resources.GetObject("btntransaction.Image"), System.Drawing.Image)
        Me.btntransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntransaction.Location = New System.Drawing.Point(876, 61)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(192, 36)
        Me.btntransaction.TabIndex = 21
        Me.btntransaction.Text = "View Transaction"
        Me.btntransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntransaction.UseVisualStyleBackColor = False
        '
        'btnviewnewbusiness
        '
        Me.btnviewnewbusiness.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnviewnewbusiness.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnviewnewbusiness.FlatAppearance.BorderSize = 0
        Me.btnviewnewbusiness.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewnewbusiness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewnewbusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewnewbusiness.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewnewbusiness.ForeColor = System.Drawing.Color.White
        Me.btnviewnewbusiness.Image = CType(resources.GetObject("btnviewnewbusiness.Image"), System.Drawing.Image)
        Me.btnviewnewbusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnviewnewbusiness.Location = New System.Drawing.Point(337, 61)
        Me.btnviewnewbusiness.Name = "btnviewnewbusiness"
        Me.btnviewnewbusiness.Size = New System.Drawing.Size(281, 36)
        Me.btnviewnewbusiness.TabIndex = 20
        Me.btnviewnewbusiness.Text = "View New Business Records"
        Me.btnviewnewbusiness.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnviewnewbusiness.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Image = CType(resources.GetObject("btnhome.Image"), System.Drawing.Image)
        Me.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.Location = New System.Drawing.Point(4, 61)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(113, 36)
        Me.btnhome.TabIndex = 15
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'btnviewrenewbusiness
        '
        Me.btnviewrenewbusiness.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnviewrenewbusiness.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnviewrenewbusiness.FlatAppearance.BorderSize = 0
        Me.btnviewrenewbusiness.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewrenewbusiness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewrenewbusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewrenewbusiness.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewrenewbusiness.ForeColor = System.Drawing.Color.White
        Me.btnviewrenewbusiness.Image = CType(resources.GetObject("btnviewrenewbusiness.Image"), System.Drawing.Image)
        Me.btnviewrenewbusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnviewrenewbusiness.Location = New System.Drawing.Point(622, 61)
        Me.btnviewrenewbusiness.Name = "btnviewrenewbusiness"
        Me.btnviewrenewbusiness.Size = New System.Drawing.Size(251, 36)
        Me.btnviewrenewbusiness.TabIndex = 16
        Me.btnviewrenewbusiness.Text = "View Renewed Records"
        Me.btnviewrenewbusiness.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnviewrenewbusiness.UseVisualStyleBackColor = False
        '
        'btnviewallrecords
        '
        Me.btnviewallrecords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnviewallrecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnviewallrecords.FlatAppearance.BorderSize = 0
        Me.btnviewallrecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewallrecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnviewallrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewallrecords.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewallrecords.ForeColor = System.Drawing.Color.White
        Me.btnviewallrecords.Image = CType(resources.GetObject("btnviewallrecords.Image"), System.Drawing.Image)
        Me.btnviewallrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnviewallrecords.Location = New System.Drawing.Point(121, 61)
        Me.btnviewallrecords.Name = "btnviewallrecords"
        Me.btnviewallrecords.Size = New System.Drawing.Size(213, 36)
        Me.btnviewallrecords.TabIndex = 18
        Me.btnviewallrecords.Text = "View All Businesses"
        Me.btnviewallrecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnviewallrecords.UseVisualStyleBackColor = False
        '
        'frm_treasurer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 751)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_treasurer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlheader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnviewnewbusiness As System.Windows.Forms.Button
    Friend WithEvents btnviewallrecords As System.Windows.Forms.Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnviewrenewbusiness As System.Windows.Forms.Button
    Friend WithEvents btntransaction As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txttreasurername As System.Windows.Forms.ToolStripStatusLabel
End Class

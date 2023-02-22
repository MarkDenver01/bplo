<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnrenew = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnnewrecord = New System.Windows.Forms.Button()
        Me.btncreateaccount = New System.Windows.Forms.Button()
        Me.btnrecords = New System.Windows.Forms.Button()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnrenew)
        Me.GroupBox1.Controls.Add(Me.btnlogout)
        Me.GroupBox1.Controls.Add(Me.btnnewrecord)
        Me.GroupBox1.Controls.Add(Me.btncreateaccount)
        Me.GroupBox1.Controls.Add(Me.btnrecords)
        Me.GroupBox1.Controls.Add(Me.btntransaction)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 687)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categories"
        '
        'btnrenew
        '
        Me.btnrenew.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnrenew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnrenew.FlatAppearance.BorderSize = 0
        Me.btnrenew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnrenew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnrenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrenew.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrenew.ForeColor = System.Drawing.Color.White
        Me.btnrenew.Image = CType(resources.GetObject("btnrenew.Image"), System.Drawing.Image)
        Me.btnrenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrenew.Location = New System.Drawing.Point(12, 198)
        Me.btnrenew.Name = "btnrenew"
        Me.btnrenew.Size = New System.Drawing.Size(180, 52)
        Me.btnrenew.TabIndex = 22
        Me.btnrenew.Text = "Renew"
        Me.btnrenew.UseVisualStyleBackColor = False
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
        Me.btnlogout.Location = New System.Drawing.Point(12, 411)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(180, 52)
        Me.btnlogout.TabIndex = 23
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnnewrecord
        '
        Me.btnnewrecord.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnnewrecord.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnnewrecord.FlatAppearance.BorderSize = 0
        Me.btnnewrecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnnewrecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnnewrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewrecord.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewrecord.ForeColor = System.Drawing.Color.White
        Me.btnnewrecord.Image = CType(resources.GetObject("btnnewrecord.Image"), System.Drawing.Image)
        Me.btnnewrecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewrecord.Location = New System.Drawing.Point(12, 124)
        Me.btnnewrecord.Name = "btnnewrecord"
        Me.btnnewrecord.Size = New System.Drawing.Size(180, 52)
        Me.btnnewrecord.TabIndex = 21
        Me.btnnewrecord.Text = "New Business"
        Me.btnnewrecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnewrecord.UseVisualStyleBackColor = False
        '
        'btncreateaccount
        '
        Me.btncreateaccount.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btncreateaccount.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncreateaccount.FlatAppearance.BorderSize = 0
        Me.btncreateaccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btncreateaccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btncreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreateaccount.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreateaccount.ForeColor = System.Drawing.Color.White
        Me.btncreateaccount.Image = CType(resources.GetObject("btncreateaccount.Image"), System.Drawing.Image)
        Me.btncreateaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncreateaccount.Location = New System.Drawing.Point(12, 340)
        Me.btncreateaccount.Name = "btncreateaccount"
        Me.btncreateaccount.Size = New System.Drawing.Size(180, 52)
        Me.btncreateaccount.TabIndex = 24
        Me.btncreateaccount.Text = "Create Account"
        Me.btncreateaccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncreateaccount.UseVisualStyleBackColor = False
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnrecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnrecords.FlatAppearance.BorderSize = 0
        Me.btnrecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnrecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecords.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecords.ForeColor = System.Drawing.Color.White
        Me.btnrecords.Image = CType(resources.GetObject("btnrecords.Image"), System.Drawing.Image)
        Me.btnrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrecords.Location = New System.Drawing.Point(12, 49)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.Size = New System.Drawing.Size(180, 52)
        Me.btnrecords.TabIndex = 20
        Me.btnrecords.Text = "Records"
        Me.btnrecords.UseVisualStyleBackColor = False
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
        Me.btntransaction.Location = New System.Drawing.Point(12, 271)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(180, 52)
        Me.btntransaction.TabIndex = 19
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntransaction.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslUser, Me.ToolStripStatusLabel3, Me.lblDate, Me.ToolStripStatusLabel5, Me.lblTimer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 693)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1358, 50)
        Me.StatusStrip1.TabIndex = 16
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
        Me.tsslUser.ActiveLinkColor = System.Drawing.Color.Maroon
        Me.tsslUser.AutoSize = False
        Me.tsslUser.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslUser.ForeColor = System.Drawing.Color.White
        Me.tsslUser.LinkColor = System.Drawing.Color.Maroon
        Me.tsslUser.Name = "tsslUser"
        Me.tsslUser.Size = New System.Drawing.Size(150, 45)
        Me.tsslUser.Text = " "
        Me.tsslUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(205, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 689)
        Me.Panel1.TabIndex = 17
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 743)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPLO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btntransaction As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btncreateaccount As System.Windows.Forms.Button
    Friend WithEvents btnrecords As System.Windows.Forms.Button
    Friend WithEvents btnnewrecord As System.Windows.Forms.Button
    Friend WithEvents btnrenew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

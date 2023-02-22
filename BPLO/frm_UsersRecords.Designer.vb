<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UsersRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UsersRecords))
        Me.dgUsersRecord = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btndeterecords = New System.Windows.Forms.Button()
        Me.btneditrecords = New System.Windows.Forms.Button()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnaddrecords = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgUsersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUsersRecord
        '
        Me.dgUsersRecord.AllowUserToAddRows = False
        Me.dgUsersRecord.AllowUserToDeleteRows = False
        Me.dgUsersRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgUsersRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgUsersRecord.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUsersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsersRecord.Location = New System.Drawing.Point(1, 135)
        Me.dgUsersRecord.Name = "dgUsersRecord"
        Me.dgUsersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsersRecord.Size = New System.Drawing.Size(789, 625)
        Me.dgUsersRecord.TabIndex = 15
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(46, 101)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(744, 33)
        Me.txtsearch.TabIndex = 16
        '
        'btndeterecords
        '
        Me.btndeterecords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btndeterecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndeterecords.FlatAppearance.BorderSize = 0
        Me.btndeterecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btndeterecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btndeterecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeterecords.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeterecords.ForeColor = System.Drawing.Color.White
        Me.btndeterecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeterecords.Location = New System.Drawing.Point(598, 61)
        Me.btndeterecords.Name = "btndeterecords"
        Me.btndeterecords.Size = New System.Drawing.Size(175, 36)
        Me.btndeterecords.TabIndex = 19
        Me.btndeterecords.Text = "Delete Records"
        Me.btndeterecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeterecords.UseVisualStyleBackColor = False
        '
        'btneditrecords
        '
        Me.btneditrecords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btneditrecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btneditrecords.FlatAppearance.BorderSize = 0
        Me.btneditrecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btneditrecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btneditrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditrecords.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditrecords.ForeColor = System.Drawing.Color.White
        Me.btneditrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditrecords.Location = New System.Drawing.Point(440, 61)
        Me.btneditrecords.Name = "btneditrecords"
        Me.btneditrecords.Size = New System.Drawing.Size(155, 36)
        Me.btneditrecords.TabIndex = 18
        Me.btneditrecords.Text = "Edit Records"
        Me.btneditrecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditrecords.UseVisualStyleBackColor = False
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnview)
        Me.pnlheader.Controls.Add(Me.btndeterecords)
        Me.pnlheader.Controls.Add(Me.btneditrecords)
        Me.pnlheader.Controls.Add(Me.btnhome)
        Me.pnlheader.Controls.Add(Me.btnaddrecords)
        Me.pnlheader.Location = New System.Drawing.Point(0, -1)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(790, 102)
        Me.pnlheader.TabIndex = 18
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnview.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnview.FlatAppearance.BorderSize = 0
        Me.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.White
        Me.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnview.Location = New System.Drawing.Point(123, 61)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(155, 36)
        Me.btnview.TabIndex = 20
        Me.btnview.Text = "View Records"
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnview.UseVisualStyleBackColor = False
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
        Me.btnhome.Location = New System.Drawing.Point(4, 61)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(113, 36)
        Me.btnhome.TabIndex = 15
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'btnaddrecords
        '
        Me.btnaddrecords.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnaddrecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnaddrecords.FlatAppearance.BorderSize = 0
        Me.btnaddrecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnaddrecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnaddrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddrecords.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddrecords.ForeColor = System.Drawing.Color.White
        Me.btnaddrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddrecords.Location = New System.Drawing.Point(282, 61)
        Me.btnaddrecords.Name = "btnaddrecords"
        Me.btnaddrecords.Size = New System.Drawing.Size(155, 36)
        Me.btnaddrecords.TabIndex = 16
        Me.btnaddrecords.Text = "Add Records"
        Me.btnaddrecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddrecords.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frm_UsersRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 772)
        Me.Controls.Add(Me.dgUsersRecord)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_UsersRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_UsersRecords"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgUsersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgUsersRecord As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btndeterecords As System.Windows.Forms.Button
    Friend WithEvents btneditrecords As System.Windows.Forms.Button
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnaddrecords As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnview As System.Windows.Forms.Button
End Class

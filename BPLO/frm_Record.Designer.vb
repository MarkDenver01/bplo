<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Record))
        Me.dgRecords = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnneedsrenewal = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnaddrecords = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgRecords
        '
        Me.dgRecords.AllowUserToAddRows = False
        Me.dgRecords.AllowUserToDeleteRows = False
        Me.dgRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgRecords.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecords.Location = New System.Drawing.Point(0, 137)
        Me.dgRecords.Name = "dgRecords"
        Me.dgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecords.Size = New System.Drawing.Size(1366, 614)
        Me.dgRecords.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(119, 101)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1247, 34)
        Me.txtsearch.TabIndex = 4
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnrefresh)
        Me.pnlheader.Controls.Add(Me.btnback)
        Me.pnlheader.Controls.Add(Me.btnview)
        Me.pnlheader.Controls.Add(Me.btnneedsrenewal)
        Me.pnlheader.Controls.Add(Me.btnhome)
        Me.pnlheader.Controls.Add(Me.btnaddrecords)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1364, 101)
        Me.pnlheader.TabIndex = 19
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(1222, 61)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(47, 36)
        Me.btnrefresh.TabIndex = 22
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        Me.btnrefresh.Visible = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnview.Image = CType(resources.GetObject("btnview.Image"), System.Drawing.Image)
        Me.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnview.Location = New System.Drawing.Point(108, 61)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(167, 36)
        Me.btnview.TabIndex = 20
        Me.btnview.Text = "View Records"
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnview.UseVisualStyleBackColor = False
        '
        'btnneedsrenewal
        '
        Me.btnneedsrenewal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnneedsrenewal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnneedsrenewal.FlatAppearance.BorderSize = 0
        Me.btnneedsrenewal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnneedsrenewal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.btnneedsrenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnneedsrenewal.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnneedsrenewal.ForeColor = System.Drawing.Color.White
        Me.btnneedsrenewal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnneedsrenewal.Location = New System.Drawing.Point(431, 59)
        Me.btnneedsrenewal.Name = "btnneedsrenewal"
        Me.btnneedsrenewal.Size = New System.Drawing.Size(175, 36)
        Me.btnneedsrenewal.TabIndex = 19
        Me.btnneedsrenewal.Text = "Needs Renewal"
        Me.btnneedsrenewal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnneedsrenewal.UseVisualStyleBackColor = False
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
        Me.btnhome.Size = New System.Drawing.Size(101, 36)
        Me.btnhome.TabIndex = 15
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnaddrecords.Image = CType(resources.GetObject("btnaddrecords.Image"), System.Drawing.Image)
        Me.btnaddrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddrecords.Location = New System.Drawing.Point(278, 61)
        Me.btnaddrecords.Name = "btnaddrecords"
        Me.btnaddrecords.Size = New System.Drawing.Size(155, 36)
        Me.btnaddrecords.TabIndex = 16
        Me.btnaddrecords.Text = "Add Records"
        Me.btnaddrecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddrecords.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.FlatAppearance.BorderSize = 0
        Me.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(0, 101)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(117, 36)
        Me.btnsearch.TabIndex = 21
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'frm_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 751)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPLO RECORD MONITORING"
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgRecords As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnneedsrenewal As System.Windows.Forms.Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnaddrecords As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class

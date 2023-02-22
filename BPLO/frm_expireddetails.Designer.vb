<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_expireddetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_expireddetails))
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnrenew = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dgRecordsissue = New System.Windows.Forms.DataGridView()
        Me.pnlheader.SuspendLayout()
        CType(Me.dgRecordsissue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnhome)
        Me.pnlheader.Controls.Add(Me.btnrenew)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1348, 101)
        Me.pnlheader.TabIndex = 21
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
        Me.btnhome.Size = New System.Drawing.Size(100, 36)
        Me.btnhome.TabIndex = 15
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhome.UseVisualStyleBackColor = False
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
        Me.btnrenew.Location = New System.Drawing.Point(107, 61)
        Me.btnrenew.Name = "btnrenew"
        Me.btnrenew.Size = New System.Drawing.Size(119, 36)
        Me.btnrenew.TabIndex = 18
        Me.btnrenew.Text = "Renew"
        Me.btnrenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrenew.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(0, 102)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(117, 36)
        Me.btnsearch.TabIndex = 24
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(116, 102)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1252, 36)
        Me.txtsearch.TabIndex = 23
        '
        'dgRecordsissue
        '
        Me.dgRecordsissue.AllowUserToAddRows = False
        Me.dgRecordsissue.AllowUserToDeleteRows = False
        Me.dgRecordsissue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgRecordsissue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgRecordsissue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRecordsissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecordsissue.Location = New System.Drawing.Point(0, 138)
        Me.dgRecordsissue.Margin = New System.Windows.Forms.Padding(4)
        Me.dgRecordsissue.Name = "dgRecordsissue"
        Me.dgRecordsissue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecordsissue.Size = New System.Drawing.Size(1348, 593)
        Me.dgRecordsissue.TabIndex = 26
        '
        'frm_expireddetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 731)
        Me.Controls.Add(Me.dgRecordsissue)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.pnlheader)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_expireddetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXPIRED DATE"
        Me.pnlheader.ResumeLayout(False)
        CType(Me.dgRecordsissue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnrenew As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgRecordsissue As System.Windows.Forms.DataGridView
End Class

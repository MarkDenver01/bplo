<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Transaction))
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.dgtransaction = New System.Windows.Forms.DataGridView()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.dgtransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnsearch.Location = New System.Drawing.Point(0, 101)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(117, 36)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'dgtransaction
        '
        Me.dgtransaction.AllowUserToAddRows = False
        Me.dgtransaction.AllowUserToDeleteRows = False
        Me.dgtransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgtransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgtransaction.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaction.Location = New System.Drawing.Point(2, 137)
        Me.dgtransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtransaction.Name = "dgtransaction"
        Me.dgtransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtransaction.Size = New System.Drawing.Size(1370, 608)
        Me.dgtransaction.TabIndex = 25
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
        Me.btnview.Location = New System.Drawing.Point(107, 61)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(119, 36)
        Me.btnview.TabIndex = 18
        Me.btnview.Text = "View"
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnview.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(116, 101)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1256, 36)
        Me.txtsearch.TabIndex = 27
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlheader.Controls.Add(Me.btnrefresh)
        Me.pnlheader.Controls.Add(Me.btnback)
        Me.pnlheader.Controls.Add(Me.btnhome)
        Me.pnlheader.Controls.Add(Me.btnview)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1348, 101)
        Me.pnlheader.TabIndex = 26
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
        Me.btnrefresh.Location = New System.Drawing.Point(1215, 65)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(47, 36)
        Me.btnrefresh.TabIndex = 23
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
        Me.btnback.Location = New System.Drawing.Point(1265, 65)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(91, 36)
        Me.btnback.TabIndex = 22
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        Me.btnback.Visible = False
        '
        'frm_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dgtransaction)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.pnlheader)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgtransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents dgtransaction As System.Windows.Forms.DataGridView
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class

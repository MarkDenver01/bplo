<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.loging = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usertxtbox = New System.Windows.Forms.TextBox()
        Me.passtxtbox = New System.Windows.Forms.TextBox()
        Me.confirmb = New System.Windows.Forms.Button()
        Me.cancelb = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.loging.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(25, 72)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(102, 37)
        Me.exitbutton.TabIndex = 6
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'loginbutton
        '
        Me.loginbutton.Location = New System.Drawing.Point(25, 19)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(102, 37)
        Me.loginbutton.TabIndex = 5
        Me.loginbutton.Text = "Log In"
        Me.loginbutton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Controls.Add(Me.exitbutton)
        Me.GroupBox1.Controls.Add(Me.loginbutton)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 244)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categories"
        '
        'loging
        '
        Me.loging.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.loging.Controls.Add(Me.Panel1)
        Me.loging.Controls.Add(Me.cancelb)
        Me.loging.Controls.Add(Me.confirmb)
        Me.loging.Controls.Add(Me.passtxtbox)
        Me.loging.Controls.Add(Me.usertxtbox)
        Me.loging.Controls.Add(Me.Label2)
        Me.loging.Controls.Add(Me.Label1)
        Me.loging.Location = New System.Drawing.Point(189, 19)
        Me.loging.Name = "loging"
        Me.loging.Size = New System.Drawing.Size(407, 200)
        Me.loging.TabIndex = 2
        Me.loging.TabStop = False
        Me.loging.Text = "Log In"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'usertxtbox
        '
        Me.usertxtbox.Location = New System.Drawing.Point(218, 57)
        Me.usertxtbox.Name = "usertxtbox"
        Me.usertxtbox.Size = New System.Drawing.Size(171, 20)
        Me.usertxtbox.TabIndex = 2
        '
        'passtxtbox
        '
        Me.passtxtbox.Location = New System.Drawing.Point(218, 111)
        Me.passtxtbox.Name = "passtxtbox"
        Me.passtxtbox.Size = New System.Drawing.Size(171, 20)
        Me.passtxtbox.TabIndex = 3
        '
        'confirmb
        '
        Me.confirmb.Location = New System.Drawing.Point(218, 156)
        Me.confirmb.Name = "confirmb"
        Me.confirmb.Size = New System.Drawing.Size(74, 33)
        Me.confirmb.TabIndex = 4
        Me.confirmb.Text = "Confirm"
        Me.confirmb.UseVisualStyleBackColor = True
        '
        'cancelb
        '
        Me.cancelb.Location = New System.Drawing.Point(315, 156)
        Me.cancelb.Name = "cancelb"
        Me.cancelb.Size = New System.Drawing.Size(74, 33)
        Me.cancelb.TabIndex = 5
        Me.cancelb.Text = "Cancel"
        Me.cancelb.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(3, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 181)
        Me.Panel1.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 241)
        Me.Controls.Add(Me.loging)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.loging.ResumeLayout(False)
        Me.loging.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents loginbutton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents loging As System.Windows.Forms.GroupBox
    Friend WithEvents cancelb As System.Windows.Forms.Button
    Friend WithEvents confirmb As System.Windows.Forms.Button
    Friend WithEvents passtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents usertxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

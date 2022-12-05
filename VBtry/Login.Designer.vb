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
        Me.components = New System.ComponentModel.Container()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.forgotpass = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.remembermecheckbox = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupBox3.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.CheckBox1)
        Me.groupBox3.Controls.Add(Me.forgotpass)
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Controls.Add(Me.loginbutton)
        Me.groupBox3.Controls.Add(Me.remembermecheckbox)
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.pictureBox3)
        Me.groupBox3.Controls.Add(Me.pictureBox2)
        Me.groupBox3.Controls.Add(Me.usernametxt)
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Controls.Add(Me.passwordtxt)
        Me.groupBox3.Location = New System.Drawing.Point(24, 37)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(678, 482)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Image = Global.VBtry.My.Resources.Resources.eye
        Me.CheckBox1.Location = New System.Drawing.Point(302, 191)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 22)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'forgotpass
        '
        Me.forgotpass.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forgotpass.ForeColor = System.Drawing.Color.Black
        Me.forgotpass.Location = New System.Drawing.Point(133, 382)
        Me.forgotpass.Name = "forgotpass"
        Me.forgotpass.Size = New System.Drawing.Size(139, 30)
        Me.forgotpass.TabIndex = 11
        Me.forgotpass.Text = "Forgot Password?"
        Me.forgotpass.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(272, 382)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(0, 17)
        Me.label5.TabIndex = 9
        '
        'loginbutton
        '
        Me.loginbutton.BackColor = System.Drawing.Color.Pink
        Me.loginbutton.ForeColor = System.Drawing.Color.Black
        Me.loginbutton.Location = New System.Drawing.Point(122, 311)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(164, 40)
        Me.loginbutton.TabIndex = 8
        Me.loginbutton.Text = "Log in"
        Me.loginbutton.UseVisualStyleBackColor = False
        '
        'remembermecheckbox
        '
        Me.remembermecheckbox.AutoSize = True
        Me.remembermecheckbox.Location = New System.Drawing.Point(160, 237)
        Me.remembermecheckbox.Name = "remembermecheckbox"
        Me.remembermecheckbox.Size = New System.Drawing.Size(18, 17)
        Me.remembermecheckbox.TabIndex = 7
        Me.remembermecheckbox.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(54, 236)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 17)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Remember me"
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pictureBox3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox3.Image = Global.VBtry.My.Resources.Resources.key
        Me.pictureBox3.Location = New System.Drawing.Point(55, 194)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(21, 21)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 5
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.VBtry.My.Resources.Resources.user
        Me.pictureBox2.Location = New System.Drawing.Point(57, 135)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(21, 19)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(47, 130)
        Me.usernametxt.Multiline = True
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(288, 29)
        Me.usernametxt.TabIndex = 1
        Me.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(179, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 17)
        Me.label3.TabIndex = 2
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Bernard MT Condensed", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(146, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(94, 39)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Log in"
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.HideSelection = False
        Me.passwordtxt.Location = New System.Drawing.Point(47, 188)
        Me.passwordtxt.Multiline = True
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(288, 33)
        Me.passwordtxt.TabIndex = 12
        Me.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(573, 68)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(203, 38)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Savannah's"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(17, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(977, 603)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.pictureBox1)
        Me.groupBox2.Controls.Add(Me.groupBox3)
        Me.groupBox2.Location = New System.Drawing.Point(21, 21)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(934, 569)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.VBtry.My.Resources.Resources.shopcoverr
        Me.pictureBox1.Location = New System.Drawing.Point(405, 121)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(492, 411)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'tableBindingSource
        '
        Me.tableBindingSource.DataMember = "Table"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1010, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableBindingSource As BindingSource
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents forgotpass As Button
    Private WithEvents label5 As Label
    Private WithEvents loginbutton As Button
    Private WithEvents remembermecheckbox As CheckBox
    Private WithEvents label4 As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents usernametxt As TextBox
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Protected WithEvents passwordtxt As TextBox
End Class

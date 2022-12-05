<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.confirmpasstxt = New System.Windows.Forms.TextBox()
        Me.newpasstxt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 13)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(909, 570)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.groupBox2.Controls.Add(Me.groupBox3)
        Me.groupBox2.Location = New System.Drawing.Point(12, 8)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(874, 536)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.label1)
        Me.groupBox3.Controls.Add(Me.button2)
        Me.groupBox3.Controls.Add(Me.pictureBox1)
        Me.groupBox3.Controls.Add(Me.button1)
        Me.groupBox3.Controls.Add(Me.confirmpasstxt)
        Me.groupBox3.Controls.Add(Me.newpasstxt)
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Location = New System.Drawing.Point(24, 37)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(832, 464)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(148, 261)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(178, 17)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Confirm New Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(156, 141)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(170, 17)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Create New Password"
        '
        'button2
        '
        Me.button2.Image = Global.VBtry.My.Resources.Resources.back
        Me.button2.Location = New System.Drawing.Point(20, 22)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(78, 36)
        Me.button2.TabIndex = 13
        Me.button2.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(442, 72)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(359, 310)
        Me.pictureBox1.TabIndex = 12
        Me.pictureBox1.TabStop = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Pink
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Location = New System.Drawing.Point(159, 379)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(164, 40)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Change Password"
        Me.button1.UseVisualStyleBackColor = False
        '
        'confirmpasstxt
        '
        Me.confirmpasstxt.Location = New System.Drawing.Point(100, 296)
        Me.confirmpasstxt.Multiline = True
        Me.confirmpasstxt.Name = "confirmpasstxt"
        Me.confirmpasstxt.Size = New System.Drawing.Size(261, 37)
        Me.confirmpasstxt.TabIndex = 4
        Me.confirmpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newpasstxt
        '
        Me.newpasstxt.Location = New System.Drawing.Point(100, 173)
        Me.newpasstxt.Multiline = True
        Me.newpasstxt.Name = "newpasstxt"
        Me.newpasstxt.Size = New System.Drawing.Size(261, 37)
        Me.newpasstxt.TabIndex = 1
        Me.newpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(179, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 17)
        Me.label3.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Bernard MT Condensed", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(136, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(214, 39)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Reset Password"
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 596)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Reset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button1 As Button
    Private WithEvents confirmpasstxt As TextBox
    Private WithEvents newpasstxt As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
End Class

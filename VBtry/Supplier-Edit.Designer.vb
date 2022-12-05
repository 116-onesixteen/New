<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier_Edit
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.suppname = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.suppadd = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.suppnum = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaShell
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(718, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 55)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.SeaShell
        Me.button3.ForeColor = System.Drawing.Color.Black
        Me.button3.Location = New System.Drawing.Point(597, 499)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(115, 55)
        Me.button3.TabIndex = 104
        Me.button3.Text = "Add"
        Me.button3.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.Button2)
        Me.groupBox1.Controls.Add(Me.Button4)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(38, 43)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(945, 632)
        Me.groupBox1.TabIndex = 103
        Me.groupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MistyRose
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.MistyRose
        Me.Button4.Image = Global.VBtry.My.Resources.Resources.back
        Me.Button4.Location = New System.Drawing.Point(26, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 48)
        Me.Button4.TabIndex = 29
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(418, 102)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(107, 36)
        Me.label1.TabIndex = 26
        Me.label1.Text = "SUPPLIER"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.LightPink
        Me.groupBox2.Controls.Add(Me.suppname)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.suppadd)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.suppnum)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(85, 170)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(748, 276)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'suppname
        '
        Me.suppname.Location = New System.Drawing.Point(326, 73)
        Me.suppname.Name = "suppname"
        Me.suppname.Size = New System.Drawing.Size(197, 22)
        Me.suppname.TabIndex = 32
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(204, 112)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(74, 22)
        Me.label7.TabIndex = 30
        Me.label7.Text = "Address:"
        '
        'suppadd
        '
        Me.suppadd.Location = New System.Drawing.Point(326, 112)
        Me.suppadd.Multiline = True
        Me.suppadd.Name = "suppadd"
        Me.suppadd.Size = New System.Drawing.Size(197, 68)
        Me.suppadd.TabIndex = 31
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(162, 196)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(142, 22)
        Me.label6.TabIndex = 28
        Me.label6.Text = "Contact Number:"
        '
        'suppnum
        '
        Me.suppnum.Location = New System.Drawing.Point(326, 196)
        Me.suppnum.Name = "suppnum"
        Me.suppnum.Size = New System.Drawing.Size(197, 22)
        Me.suppnum.TabIndex = 29
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(205, 73)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Name:"
        '
        'Supplier_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1021, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Button2 As Button
    Private WithEvents button3 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Button4 As Button
    Private WithEvents label1 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label7 As Label
    Private WithEvents suppadd As TextBox
    Private WithEvents label6 As Label
    Private WithEvents suppnum As TextBox
    Private WithEvents label4 As Label
    Private WithEvents suppname As TextBox
End Class

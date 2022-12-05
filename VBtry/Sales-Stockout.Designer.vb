<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_Stockout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.outprice = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.outnum = New System.Windows.Forms.TextBox()
        Me.outcombounit = New System.Windows.Forms.ComboBox()
        Me.outcomboitem = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnoutreset = New System.Windows.Forms.Button()
        Me.btnoutsave = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.outadd = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.outcnum = New System.Windows.Forms.TextBox()
        Me.outname = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.outcombomode = New System.Windows.Forms.ComboBox()
        Me.outdate = New System.Windows.Forms.DateTimePicker()
        Me.label11 = New System.Windows.Forms.Label()
        Me.outtotal = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.Panel2)
        Me.groupBox1.Controls.Add(Me.btnoutreset)
        Me.groupBox1.Controls.Add(Me.btnoutsave)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.GroupBox3)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(4, -4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(973, 842)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.MistyRose
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.MistyRose
        Me.button2.Image = Global.VBtry.My.Resources.Resources.back
        Me.button2.Location = New System.Drawing.Point(6, 21)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(54, 48)
        Me.button2.TabIndex = 92
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Pink
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.outprice)
        Me.Panel2.Controls.Add(Me.label10)
        Me.Panel2.Controls.Add(Me.button4)
        Me.Panel2.Controls.Add(Me.outnum)
        Me.Panel2.Controls.Add(Me.outcombounit)
        Me.Panel2.Controls.Add(Me.outcomboitem)
        Me.Panel2.Controls.Add(Me.label6)
        Me.Panel2.Controls.Add(Me.label5)
        Me.Panel2.Location = New System.Drawing.Point(86, 319)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 214)
        Me.Panel2.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(390, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 22)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Price:"
        '
        'outprice
        '
        Me.outprice.Location = New System.Drawing.Point(487, 78)
        Me.outprice.Name = "outprice"
        Me.outprice.Size = New System.Drawing.Size(197, 22)
        Me.outprice.TabIndex = 80
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Black
        Me.label10.Location = New System.Drawing.Point(378, 37)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(80, 22)
        Me.label10.TabIndex = 77
        Me.label10.Text = "Quantity:"
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.SeaShell
        Me.button4.ForeColor = System.Drawing.Color.Black
        Me.button4.Image = Global.VBtry.My.Resources.Resources.add
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(611, 146)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(114, 50)
        Me.button4.TabIndex = 76
        Me.button4.Text = "Add Items"
        Me.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button4.UseVisualStyleBackColor = False
        '
        'outnum
        '
        Me.outnum.Location = New System.Drawing.Point(487, 37)
        Me.outnum.Name = "outnum"
        Me.outnum.Size = New System.Drawing.Size(197, 22)
        Me.outnum.TabIndex = 78
        '
        'outcombounit
        '
        Me.outcombounit.FormattingEnabled = True
        Me.outcombounit.Items.AddRange(New Object() {"Bundle/s", "Piece/s"})
        Me.outcombounit.Location = New System.Drawing.Point(148, 78)
        Me.outcombounit.Name = "outcombounit"
        Me.outcombounit.Size = New System.Drawing.Size(197, 24)
        Me.outcombounit.TabIndex = 75
        '
        'outcomboitem
        '
        Me.outcomboitem.FormattingEnabled = True
        Me.outcomboitem.Location = New System.Drawing.Point(148, 39)
        Me.outcomboitem.Name = "outcomboitem"
        Me.outcomboitem.Size = New System.Drawing.Size(197, 24)
        Me.outcomboitem.TabIndex = 70
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(30, 41)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(49, 22)
        Me.label6.TabIndex = 69
        Me.label6.Text = "Item:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(30, 78)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 22)
        Me.label5.TabIndex = 68
        Me.label5.Text = "Unit:"
        '
        'btnoutreset
        '
        Me.btnoutreset.BackColor = System.Drawing.Color.SeaShell
        Me.btnoutreset.ForeColor = System.Drawing.Color.Black
        Me.btnoutreset.Location = New System.Drawing.Point(734, 749)
        Me.btnoutreset.Name = "btnoutreset"
        Me.btnoutreset.Size = New System.Drawing.Size(104, 55)
        Me.btnoutreset.TabIndex = 28
        Me.btnoutreset.Text = "Reset"
        Me.btnoutreset.UseVisualStyleBackColor = False
        '
        'btnoutsave
        '
        Me.btnoutsave.BackColor = System.Drawing.Color.SeaShell
        Me.btnoutsave.ForeColor = System.Drawing.Color.Black
        Me.btnoutsave.Location = New System.Drawing.Point(613, 749)
        Me.btnoutsave.Name = "btnoutsave"
        Me.btnoutsave.Size = New System.Drawing.Size(115, 55)
        Me.btnoutsave.TabIndex = 27
        Me.btnoutsave.Text = "Add"
        Me.btnoutsave.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(374, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(170, 36)
        Me.label1.TabIndex = 26
        Me.label1.Text = "ITEM STOCK OUT"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Pink
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.outadd)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.outcnum)
        Me.groupBox2.Controls.Add(Me.outname)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(86, 98)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(752, 215)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(204, 125)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 22)
        Me.label2.TabIndex = 41
        Me.label2.Text = "Address:"
        '
        'outadd
        '
        Me.outadd.Location = New System.Drawing.Point(325, 125)
        Me.outadd.Multiline = True
        Me.outadd.Name = "outadd"
        Me.outadd.Size = New System.Drawing.Size(197, 41)
        Me.outadd.TabIndex = 42
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(188, 87)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(116, 22)
        Me.label7.TabIndex = 30
        Me.label7.Text = "Customer No."
        '
        'outcnum
        '
        Me.outcnum.Location = New System.Drawing.Point(325, 87)
        Me.outcnum.Name = "outcnum"
        Me.outcnum.Size = New System.Drawing.Size(197, 22)
        Me.outcnum.TabIndex = 31
        '
        'outname
        '
        Me.outname.Location = New System.Drawing.Point(325, 48)
        Me.outname.Name = "outname"
        Me.outname.Size = New System.Drawing.Size(197, 22)
        Me.outname.TabIndex = 29
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(165, 48)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Customer Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Pink
        Me.GroupBox3.Controls.Add(Me.outcombomode)
        Me.GroupBox3.Controls.Add(Me.outdate)
        Me.GroupBox3.Controls.Add(Me.label11)
        Me.GroupBox3.Controls.Add(Me.outtotal)
        Me.GroupBox3.Controls.Add(Me.label8)
        Me.GroupBox3.Controls.Add(Me.label12)
        Me.GroupBox3.Location = New System.Drawing.Point(86, 539)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 201)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        '
        'outcombomode
        '
        Me.outcombomode.FormattingEnabled = True
        Me.outcombomode.Items.AddRange(New Object() {"Deliver", "Walk-in"})
        Me.outcombomode.Location = New System.Drawing.Point(325, 40)
        Me.outcombomode.Name = "outcombomode"
        Me.outcombomode.Size = New System.Drawing.Size(197, 24)
        Me.outcombomode.TabIndex = 103
        '
        'outdate
        '
        Me.outdate.Location = New System.Drawing.Point(324, 81)
        Me.outdate.Name = "outdate"
        Me.outdate.Size = New System.Drawing.Size(197, 22)
        Me.outdate.TabIndex = 102
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.Pink
        Me.label11.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.Black
        Me.label11.Location = New System.Drawing.Point(214, 42)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(58, 22)
        Me.label11.TabIndex = 99
        Me.label11.Text = "Mode:"
        '
        'outtotal
        '
        Me.outtotal.Location = New System.Drawing.Point(324, 137)
        Me.outtotal.Name = "outtotal"
        Me.outtotal.Size = New System.Drawing.Size(197, 22)
        Me.outtotal.TabIndex = 101
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Pink
        Me.label8.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Black
        Me.label8.Location = New System.Drawing.Point(129, 137)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(175, 22)
        Me.label8.TabIndex = 98
        Me.label8.Text = "Total Cost Purchased:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.Pink
        Me.label12.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(215, 83)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(50, 22)
        Me.label12.TabIndex = 100
        Me.label12.Text = "Date:"
        '
        'Sales_Stockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 834)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Sales_Stockout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents button2 As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents label10 As Label
    Private WithEvents button4 As Button
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents btnoutreset As Button
    Private WithEvents btnoutsave As Button
    Private WithEvents label1 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents label7 As Label
    Private WithEvents label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents outcombomode As ComboBox
    Public WithEvents outdate As DateTimePicker
    Private WithEvents label11 As Label
    Public WithEvents outtotal As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label12 As Label
    Public WithEvents outnum As TextBox
    Public WithEvents outcombounit As ComboBox
    Public WithEvents outcomboitem As ComboBox
    Public WithEvents outadd As TextBox
    Public WithEvents outcnum As TextBox
    Public WithEvents outname As TextBox
    Private WithEvents Label13 As Label
    Public WithEvents outprice As TextBox
End Class

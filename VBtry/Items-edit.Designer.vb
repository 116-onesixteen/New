<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items_edit
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
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.itmdesc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.updateid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.itmcat = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.combosupplier = New System.Windows.Forms.ComboBox()
        Me.itmname = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.itmoprice = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.itmsprice = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.itmnum = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.SeaShell
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.Location = New System.Drawing.Point(816, 577)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(104, 55)
        Me.btnreset.TabIndex = 28
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SeaShell
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(561, 577)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(115, 55)
        Me.btnupdate.TabIndex = 27
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Pink
        Me.groupBox2.Controls.Add(Me.itmdesc)
        Me.groupBox2.Controls.Add(Me.Label9)
        Me.groupBox2.Controls.Add(Me.updateid)
        Me.groupBox2.Controls.Add(Me.Label8)
        Me.groupBox2.Controls.Add(Me.itmcat)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.combosupplier)
        Me.groupBox2.Controls.Add(Me.itmname)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.itmoprice)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.itmsprice)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.itmnum)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(102, 144)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(760, 411)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'itmdesc
        '
        Me.itmdesc.Location = New System.Drawing.Point(303, 141)
        Me.itmdesc.Multiline = True
        Me.itmdesc.Name = "itmdesc"
        Me.itmdesc.Size = New System.Drawing.Size(197, 66)
        Me.itmdesc.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 22)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Item ID:"
        '
        'updateid
        '
        Me.updateid.Location = New System.Drawing.Point(139, 18)
        Me.updateid.Name = "updateid"
        Me.updateid.Size = New System.Drawing.Size(197, 22)
        Me.updateid.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(165, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 22)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Supplier:"
        '
        'itmcat
        '
        Me.itmcat.FormattingEnabled = True
        Me.itmcat.Items.AddRange(New Object() {"Flowers", "Gifts"})
        Me.itmcat.Location = New System.Drawing.Point(303, 62)
        Me.itmcat.Name = "itmcat"
        Me.itmcat.Size = New System.Drawing.Size(197, 24)
        Me.itmcat.TabIndex = 32
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(165, 101)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(60, 22)
        Me.label7.TabIndex = 30
        Me.label7.Text = "Name:"
        '
        'combosupplier
        '
        Me.combosupplier.FormattingEnabled = True
        Me.combosupplier.Location = New System.Drawing.Point(303, 222)
        Me.combosupplier.Name = "combosupplier"
        Me.combosupplier.Size = New System.Drawing.Size(197, 24)
        Me.combosupplier.TabIndex = 33
        '
        'itmname
        '
        Me.itmname.Location = New System.Drawing.Point(303, 101)
        Me.itmname.Name = "itmname"
        Me.itmname.Size = New System.Drawing.Size(197, 22)
        Me.itmname.TabIndex = 31
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(165, 141)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 22)
        Me.label6.TabIndex = 28
        Me.label6.Text = "Description:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(165, 266)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(116, 22)
        Me.label5.TabIndex = 26
        Me.label5.Text = "Original Price:"
        '
        'itmoprice
        '
        Me.itmoprice.Location = New System.Drawing.Point(303, 266)
        Me.itmoprice.Name = "itmoprice"
        Me.itmoprice.Size = New System.Drawing.Size(197, 22)
        Me.itmoprice.TabIndex = 27
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(165, 314)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 22)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Selling Price:"
        '
        'itmsprice
        '
        Me.itmsprice.Location = New System.Drawing.Point(303, 314)
        Me.itmsprice.Name = "itmsprice"
        Me.itmsprice.Size = New System.Drawing.Size(197, 22)
        Me.itmsprice.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(165, 353)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 22)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Quantity:"
        '
        'itmnum
        '
        Me.itmnum.Location = New System.Drawing.Point(303, 353)
        Me.itmnum.Name = "itmnum"
        Me.itmnum.Size = New System.Drawing.Size(197, 22)
        Me.itmnum.TabIndex = 23
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(165, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(83, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Category:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(387, 71)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(233, 36)
        Me.label1.TabIndex = 26
        Me.label1.Text = "UPDATE DETAILS ITEMS"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.MistyRose
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.MistyRose
        Me.button2.Image = Global.VBtry.My.Resources.Resources.back
        Me.button2.Location = New System.Drawing.Point(26, 21)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(54, 48)
        Me.button2.TabIndex = 29
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.Button1)
        Me.groupBox1.Controls.Add(Me.btnreset)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.btnupdate)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(-2, -3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(945, 632)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(689, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 55)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Items_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(961, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Items_edit"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnreset As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
    Public WithEvents btnupdate As Button
    Public WithEvents itmcat As ComboBox
    Public WithEvents itmname As TextBox
    Public WithEvents itmoprice As TextBox
    Public WithEvents itmsprice As TextBox
    Public WithEvents itmnum As TextBox
    Public WithEvents combosupplier As ComboBox
    Public WithEvents updateid As TextBox
    Public WithEvents itmdesc As TextBox
    Public WithEvents Button1 As Button
End Class

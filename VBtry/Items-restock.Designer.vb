<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items_restock
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
        Me.resdesc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.updateid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rescat = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.rescombosupplier = New System.Windows.Forms.ComboBox()
        Me.resname = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.resoprice = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ressprice = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.resnum = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnaddrestock = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.Button4)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.btnaddrestock)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(0, -1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1001, 686)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Pink
        Me.groupBox2.Controls.Add(Me.resdesc)
        Me.groupBox2.Controls.Add(Me.Label9)
        Me.groupBox2.Controls.Add(Me.updateid)
        Me.groupBox2.Controls.Add(Me.Label8)
        Me.groupBox2.Controls.Add(Me.rescat)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.rescombosupplier)
        Me.groupBox2.Controls.Add(Me.resname)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.resoprice)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.ressprice)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.resnum)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(124, 138)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(752, 411)
        Me.groupBox2.TabIndex = 31
        Me.groupBox2.TabStop = False
        '
        'resdesc
        '
        Me.resdesc.Location = New System.Drawing.Point(295, 144)
        Me.resdesc.Multiline = True
        Me.resdesc.Name = "resdesc"
        Me.resdesc.Size = New System.Drawing.Size(197, 66)
        Me.resdesc.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 22)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Item ID:"
        '
        'updateid
        '
        Me.updateid.Location = New System.Drawing.Point(131, 21)
        Me.updateid.Name = "updateid"
        Me.updateid.Size = New System.Drawing.Size(197, 22)
        Me.updateid.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(157, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 22)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Supplier:"
        '
        'rescat
        '
        Me.rescat.FormattingEnabled = True
        Me.rescat.Items.AddRange(New Object() {"Flowers", "Gifts"})
        Me.rescat.Location = New System.Drawing.Point(295, 65)
        Me.rescat.Name = "rescat"
        Me.rescat.Size = New System.Drawing.Size(197, 24)
        Me.rescat.TabIndex = 32
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(157, 104)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(60, 22)
        Me.label7.TabIndex = 30
        Me.label7.Text = "Name:"
        '
        'rescombosupplier
        '
        Me.rescombosupplier.FormattingEnabled = True
        Me.rescombosupplier.Location = New System.Drawing.Point(295, 225)
        Me.rescombosupplier.Name = "rescombosupplier"
        Me.rescombosupplier.Size = New System.Drawing.Size(197, 24)
        Me.rescombosupplier.TabIndex = 33
        '
        'resname
        '
        Me.resname.Location = New System.Drawing.Point(295, 104)
        Me.resname.Name = "resname"
        Me.resname.Size = New System.Drawing.Size(197, 22)
        Me.resname.TabIndex = 31
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(157, 144)
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
        Me.label5.Location = New System.Drawing.Point(157, 269)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(116, 22)
        Me.label5.TabIndex = 26
        Me.label5.Text = "Original Price:"
        '
        'resoprice
        '
        Me.resoprice.Location = New System.Drawing.Point(295, 269)
        Me.resoprice.Name = "resoprice"
        Me.resoprice.Size = New System.Drawing.Size(197, 22)
        Me.resoprice.TabIndex = 27
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(157, 317)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 22)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Selling Price:"
        '
        'ressprice
        '
        Me.ressprice.Location = New System.Drawing.Point(295, 317)
        Me.ressprice.Name = "ressprice"
        Me.ressprice.Size = New System.Drawing.Size(197, 22)
        Me.ressprice.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(157, 356)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 22)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Quantity:"
        '
        'resnum
        '
        Me.resnum.Location = New System.Drawing.Point(295, 356)
        Me.resnum.Name = "resnum"
        Me.resnum.Size = New System.Drawing.Size(197, 22)
        Me.resnum.TabIndex = 23
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(157, 65)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(83, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Category:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MistyRose
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.MistyRose
        Me.Button4.Image = Global.VBtry.My.Resources.Resources.back
        Me.Button4.Location = New System.Drawing.Point(12, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 48)
        Me.Button4.TabIndex = 30
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.SeaShell
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Location = New System.Drawing.Point(670, 575)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 55)
        Me.button1.TabIndex = 28
        Me.button1.Text = "Reset"
        Me.button1.UseVisualStyleBackColor = False
        '
        'btnaddrestock
        '
        Me.btnaddrestock.BackColor = System.Drawing.Color.SeaShell
        Me.btnaddrestock.ForeColor = System.Drawing.Color.Black
        Me.btnaddrestock.Location = New System.Drawing.Point(790, 575)
        Me.btnaddrestock.Name = "btnaddrestock"
        Me.btnaddrestock.Size = New System.Drawing.Size(115, 55)
        Me.btnaddrestock.TabIndex = 27
        Me.btnaddrestock.Text = "Add"
        Me.btnaddrestock.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(385, 70)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(211, 36)
        Me.label1.TabIndex = 26
        Me.label1.Text = "RESTOCK OLD ITEMS"
        '
        'Items_restock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Items_restock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents button1 As Button
    Private WithEvents label1 As Label
    Private WithEvents Button4 As Button
    Public WithEvents btnaddrestock As Button
    Private WithEvents groupBox2 As GroupBox
    Public WithEvents resdesc As TextBox
    Private WithEvents Label9 As Label
    Public WithEvents updateid As TextBox
    Private WithEvents Label8 As Label
    Public WithEvents rescat As ComboBox
    Private WithEvents label7 As Label
    Public WithEvents rescombosupplier As ComboBox
    Public WithEvents resname As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Public WithEvents resoprice As TextBox
    Private WithEvents label3 As Label
    Public WithEvents ressprice As TextBox
    Private WithEvents label2 As Label
    Public WithEvents resnum As TextBox
    Private WithEvents label4 As Label
End Class

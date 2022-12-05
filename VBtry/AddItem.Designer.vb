<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.label10 = New System.Windows.Forms.Label()
        Me.allnum = New System.Windows.Forms.TextBox()
        Me.button4 = New System.Windows.Forms.Button()
        Me.allcombounit = New System.Windows.Forms.ComboBox()
        Me.allcomboitem = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.alldesc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(-25, -6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(767, 217)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Pink
        Me.groupBox2.Controls.Add(Me.Button1)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.allnum)
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Controls.Add(Me.allcombounit)
        Me.groupBox2.Controls.Add(Me.allcomboitem)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.alldesc)
        Me.groupBox2.Location = New System.Drawing.Point(19, 0)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(871, 402)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Black
        Me.label10.Location = New System.Drawing.Point(203, 160)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(80, 22)
        Me.label10.TabIndex = 43
        Me.label10.Text = "Quantity:"
        '
        'allnum
        '
        Me.allnum.Location = New System.Drawing.Point(341, 160)
        Me.allnum.Name = "allnum"
        Me.allnum.Size = New System.Drawing.Size(197, 22)
        Me.allnum.TabIndex = 44
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.SeaShell
        Me.button4.ForeColor = System.Drawing.Color.Black
        Me.button4.Image = Global.VBtry.My.Resources.Resources.add
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(562, 46)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(127, 50)
        Me.button4.TabIndex = 39
        Me.button4.Text = "Add Items"
        Me.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button4.UseVisualStyleBackColor = False
        '
        'allcombounit
        '
        Me.allcombounit.FormattingEnabled = True
        Me.allcombounit.Location = New System.Drawing.Point(340, 62)
        Me.allcombounit.Name = "allcombounit"
        Me.allcombounit.Size = New System.Drawing.Size(197, 24)
        Me.allcombounit.TabIndex = 38
        '
        'allcomboitem
        '
        Me.allcomboitem.FormattingEnabled = True
        Me.allcomboitem.Location = New System.Drawing.Point(341, 21)
        Me.allcomboitem.Name = "allcomboitem"
        Me.allcomboitem.Size = New System.Drawing.Size(197, 24)
        Me.allcomboitem.TabIndex = 32
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(219, 23)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(49, 22)
        Me.label6.TabIndex = 28
        Me.label6.Text = "Item:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(219, 64)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 22)
        Me.label5.TabIndex = 26
        Me.label5.Text = "Unit:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(203, 104)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 22)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Description:"
        '
        'alldesc
        '
        Me.alldesc.Location = New System.Drawing.Point(341, 104)
        Me.alldesc.Multiline = True
        Me.alldesc.Name = "alldesc"
        Me.alldesc.Size = New System.Drawing.Size(197, 37)
        Me.alldesc.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.VBtry.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(562, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 50)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Preview"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(739, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label10 As Label
    Private WithEvents allnum As TextBox
    Private WithEvents button4 As Button
    Private WithEvents allcombounit As ComboBox
    Private WithEvents allcomboitem As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents alldesc As TextBox
    Private WithEvents Button1 As Button
End Class

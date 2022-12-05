<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items_View
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
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.pictureBox1)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(9, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(812, 559)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Pink
        Me.groupBox2.Controls.Add(Me.richTextBox1)
        Me.groupBox2.Location = New System.Drawing.Point(331, 50)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(404, 450)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(49, 60)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(303, 327)
        Me.richTextBox1.TabIndex = 0
        Me.richTextBox1.Text = ""
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(60, 139)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(202, 221)
        Me.pictureBox1.TabIndex = 22
        Me.pictureBox1.TabStop = False
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(91, 397)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(145, 22)
        Me.textBox1.TabIndex = 21
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(127, 363)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Name:"
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
        Me.button2.TabIndex = 30
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'Items_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 582)
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items_View"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents button2 As Button
End Class

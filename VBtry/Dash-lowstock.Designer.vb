<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash_lowstock
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(248, 124)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(141, 24)
        Me.comboBox1.TabIndex = 99
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(168, 124)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 22)
        Me.label4.TabIndex = 98
        Me.label4.Text = "Sort by"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaShell
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.VBtry.My.Resources.Resources.supplier
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(743, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 50)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Supplier"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Pink
        Me.Button1.Image = Global.VBtry.My.Resources.Resources.back
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 48)
        Me.Button1.TabIndex = 97
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.SeaShell
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Image = Global.VBtry.My.Resources.Resources.order1
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(878, 30)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(128, 50)
        Me.button2.TabIndex = 96
        Me.button2.Text = "Order Now"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(176, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(674, 394)
        Me.DataGridView1.TabIndex = 101
        '
        'Dash_lowstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1054, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dash_lowstock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents button2 As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

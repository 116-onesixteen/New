<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.btnref = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.itemno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.btnref)
        Me.groupBox1.Controls.Add(Me.DataGridView1)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox1.ForeColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Location = New System.Drawing.Point(0, -1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1037, 665)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'btnref
        '
        Me.btnref.BackColor = System.Drawing.Color.SeaShell
        Me.btnref.ForeColor = System.Drawing.Color.Black
        Me.btnref.Image = Global.VBtry.My.Resources.Resources.update
        Me.btnref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnref.Location = New System.Drawing.Point(909, 44)
        Me.btnref.Name = "btnref"
        Me.btnref.Size = New System.Drawing.Size(107, 55)
        Me.btnref.TabIndex = 107
        Me.btnref.Text = "Referesh"
        Me.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnref.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemno, Me.Column6, Me.Column5, Me.rsv_total})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(21, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(995, 450)
        Me.DataGridView1.TabIndex = 25
        '
        'itemno
        '
        Me.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemno.DataPropertyName = "transaction_id"
        Me.itemno.HeaderText = "Transaction ID"
        Me.itemno.Name = "itemno"
        Me.itemno.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "sales_date"
        Me.Column6.HeaderText = "Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "sales_method"
        Me.Column5.HeaderText = "Sales method"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'rsv_total
        '
        Me.rsv_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rsv_total.DataPropertyName = "sales"
        Me.rsv_total.HeaderText = "Sales"
        Me.rsv_total.Name = "rsv_total"
        Me.rsv_total.ReadOnly = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(871, 579)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(145, 22)
        Me.textBox1.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(774, 579)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 22)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Total Sales"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(102, 60)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(167, 24)
        Me.comboBox1.TabIndex = 19
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(22, 60)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 22)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Sort by"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.SeaShell
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Image = Global.VBtry.My.Resources.Resources.out_of_stock__2_
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(778, 44)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(109, 55)
        Me.button2.TabIndex = 14
        Me.button2.Text = "Stock Out"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button2.UseVisualStyleBackColor = False
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1037, 665)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.LightCoral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents itemno As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents rsv_total As DataGridViewTextBoxColumn
    Private WithEvents btnref As Button
End Class

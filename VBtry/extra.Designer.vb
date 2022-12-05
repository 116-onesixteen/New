<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extra))
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rsvno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_cnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_add = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_itemid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_sprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_mode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rsv_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.crestock = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.addrsv = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.VBtry.My.Resources.Resources.update
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rsvno, Me.rsv_name, Me.rsv_cnum, Me.rsv_add, Me.rsv_itemid, Me.rsv_cat, Me.item_sprice, Me.rsv_unit, Me.rsv_desc, Me.rsv_num, Me.rsv_stat, Me.rsv_mode, Me.rsv_date, Me.rsv_total, Me.cedit, Me.crestock})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(26, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(995, 450)
        Me.DataGridView1.TabIndex = 30
        '
        'rsvno
        '
        Me.rsvno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsvno.DataPropertyName = "rsvno"
        Me.rsvno.HeaderText = "Reserve ID"
        Me.rsvno.Name = "rsvno"
        Me.rsvno.ReadOnly = True
        Me.rsvno.Width = 105
        '
        'rsv_name
        '
        Me.rsv_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_name.DataPropertyName = "rsv_name"
        Me.rsv_name.HeaderText = "Name"
        Me.rsv_name.Name = "rsv_name"
        Me.rsv_name.ReadOnly = True
        Me.rsv_name.Width = 72
        '
        'rsv_cnum
        '
        Me.rsv_cnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_cnum.DataPropertyName = "rsv_cnum"
        Me.rsv_cnum.HeaderText = "Contact No."
        Me.rsv_cnum.Name = "rsv_cnum"
        Me.rsv_cnum.ReadOnly = True
        Me.rsv_cnum.Width = 109
        '
        'rsv_add
        '
        Me.rsv_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rsv_add.DataPropertyName = "rsv_add"
        Me.rsv_add.HeaderText = "Address"
        Me.rsv_add.Name = "rsv_add"
        Me.rsv_add.ReadOnly = True
        '
        'rsv_itemid
        '
        Me.rsv_itemid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_itemid.DataPropertyName = "rsv_itemid"
        Me.rsv_itemid.HeaderText = "Item ID"
        Me.rsv_itemid.Name = "rsv_itemid"
        Me.rsv_itemid.ReadOnly = True
        Me.rsv_itemid.Width = 78
        '
        'rsv_cat
        '
        Me.rsv_cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_cat.DataPropertyName = "rsv_cat"
        Me.rsv_cat.HeaderText = "Category"
        Me.rsv_cat.Name = "rsv_cat"
        Me.rsv_cat.ReadOnly = True
        Me.rsv_cat.Width = 92
        '
        'item_sprice
        '
        Me.item_sprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_sprice.DataPropertyName = "rsv_item"
        Me.item_sprice.HeaderText = "Item"
        Me.item_sprice.Name = "item_sprice"
        Me.item_sprice.ReadOnly = True
        Me.item_sprice.Width = 61
        '
        'rsv_unit
        '
        Me.rsv_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_unit.DataPropertyName = "rsv_unit"
        Me.rsv_unit.HeaderText = "Unit"
        Me.rsv_unit.Name = "rsv_unit"
        Me.rsv_unit.ReadOnly = True
        Me.rsv_unit.Width = 60
        '
        'rsv_desc
        '
        Me.rsv_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rsv_desc.DataPropertyName = "rsv_desc"
        Me.rsv_desc.HeaderText = "Description"
        Me.rsv_desc.Name = "rsv_desc"
        Me.rsv_desc.ReadOnly = True
        '
        'rsv_num
        '
        Me.rsv_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_num.DataPropertyName = "rsv_num"
        Me.rsv_num.HeaderText = "Quantity"
        Me.rsv_num.Name = "rsv_num"
        Me.rsv_num.ReadOnly = True
        Me.rsv_num.Width = 88
        '
        'rsv_stat
        '
        Me.rsv_stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_stat.DataPropertyName = "rsv_stat"
        Me.rsv_stat.HeaderText = "Status"
        Me.rsv_stat.Name = "rsv_stat"
        Me.rsv_stat.ReadOnly = True
        Me.rsv_stat.Width = 75
        '
        'rsv_mode
        '
        Me.rsv_mode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_mode.DataPropertyName = "rsv_mode"
        Me.rsv_mode.HeaderText = "Mode"
        Me.rsv_mode.Name = "rsv_mode"
        Me.rsv_mode.ReadOnly = True
        Me.rsv_mode.Width = 70
        '
        'rsv_date
        '
        Me.rsv_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_date.DataPropertyName = "rsv_date"
        Me.rsv_date.HeaderText = "Date"
        Me.rsv_date.Name = "rsv_date"
        Me.rsv_date.ReadOnly = True
        Me.rsv_date.Width = 65
        '
        'rsv_total
        '
        Me.rsv_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rsv_total.DataPropertyName = "rsv_total"
        Me.rsv_total.HeaderText = "Total"
        Me.rsv_total.Name = "rsv_total"
        Me.rsv_total.ReadOnly = True
        Me.rsv_total.Width = 67
        '
        'cedit
        '
        Me.cedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cedit.HeaderText = ""
        Me.cedit.Image = CType(resources.GetObject("cedit.Image"), System.Drawing.Image)
        Me.cedit.Name = "cedit"
        Me.cedit.ReadOnly = True
        Me.cedit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cedit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cedit.Width = 21
        '
        'crestock
        '
        Me.crestock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.crestock.HeaderText = ""
        Me.crestock.Image = CType(resources.GetObject("crestock.Image"), System.Drawing.Image)
        Me.crestock.Name = "crestock"
        Me.crestock.ReadOnly = True
        Me.crestock.Width = 5
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SeaShell
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.VBtry.My.Resources.Resources.update
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(915, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 55)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Referesh"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.SeaShell
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Image = Global.VBtry.My.Resources.Resources.task
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(905, 585)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(118, 55)
        Me.button1.TabIndex = 28
        Me.button1.Text = "Completed"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(99, 25)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(141, 24)
        Me.comboBox1.TabIndex = 27
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(19, 25)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 22)
        Me.label4.TabIndex = 26
        Me.label4.Text = "Sort by"
        '
        'addrsv
        '
        Me.addrsv.BackColor = System.Drawing.Color.SeaShell
        Me.addrsv.ForeColor = System.Drawing.Color.Black
        Me.addrsv.Image = Global.VBtry.My.Resources.Resources.file
        Me.addrsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addrsv.Location = New System.Drawing.Point(742, 585)
        Me.addrsv.Name = "addrsv"
        Me.addrsv.Size = New System.Drawing.Size(157, 55)
        Me.addrsv.TabIndex = 25
        Me.addrsv.Text = "Add Reservation"
        Me.addrsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addrsv.UseVisualStyleBackColor = False
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1074, 643)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.addrsv)
        Me.Enabled = False
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Reserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rsvno As DataGridViewTextBoxColumn
    Friend WithEvents rsv_name As DataGridViewTextBoxColumn
    Friend WithEvents rsv_cnum As DataGridViewTextBoxColumn
    Friend WithEvents rsv_add As DataGridViewTextBoxColumn
    Friend WithEvents rsv_itemid As DataGridViewTextBoxColumn
    Friend WithEvents rsv_cat As DataGridViewTextBoxColumn
    Friend WithEvents item_sprice As DataGridViewTextBoxColumn
    Friend WithEvents rsv_unit As DataGridViewTextBoxColumn
    Friend WithEvents rsv_desc As DataGridViewTextBoxColumn
    Friend WithEvents rsv_num As DataGridViewTextBoxColumn
    Friend WithEvents rsv_stat As DataGridViewTextBoxColumn
    Friend WithEvents rsv_mode As DataGridViewTextBoxColumn
    Friend WithEvents rsv_date As DataGridViewTextBoxColumn
    Friend WithEvents rsv_total As DataGridViewTextBoxColumn
    Friend WithEvents cedit As DataGridViewImageColumn
    Friend WithEvents crestock As DataGridViewImageColumn
    Private WithEvents Button4 As Button
    Private WithEvents button1 As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents addrsv As Button
End Class

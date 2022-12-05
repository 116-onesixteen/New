<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.sort = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_oprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_sprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.crestock = New System.Windows.Forms.DataGridViewImageColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.groupBox1.Controls.Add(Me.Button4)
        Me.groupBox1.Controls.Add(Me.DataGridView1)
        Me.groupBox1.Controls.Add(Me.sort)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.groupBox1.Location = New System.Drawing.Point(-1, -1)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.groupBox1.Size = New System.Drawing.Size(780, 541)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SeaShell
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.VBtry.My.Resources.Resources.update
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(669, 54)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 45)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Referesh"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.item_cat, Me.item_name, Me.item_desc, Me.Column2, Me.item_oprice, Me.item_sprice, Me.quantity, Me.cedit, Me.crestock})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(14, 104)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(746, 366)
        Me.DataGridView1.TabIndex = 20
        '
        'sort
        '
        Me.sort.FormattingEnabled = True
        Me.sort.Items.AddRange(New Object() {"Flowers", "Gifts"})
        Me.sort.Location = New System.Drawing.Point(82, 67)
        Me.sort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sort.Name = "sort"
        Me.sort.Size = New System.Drawing.Size(107, 21)
        Me.sort.TabIndex = 19
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(22, 67)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 18)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Sort by"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.SeaShell
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Image = Global.VBtry.My.Resources.Resources.add
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(562, 54)
        Me.button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(103, 45)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Add New Items"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = False
        '
        'item_no
        '
        Me.item_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_no.DataPropertyName = "item_no"
        Me.item_no.HeaderText = "Item ID"
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = True
        Me.item_no.Width = 59
        '
        'item_cat
        '
        Me.item_cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_cat.DataPropertyName = "item_cat"
        Me.item_cat.HeaderText = "Category"
        Me.item_cat.Name = "item_cat"
        Me.item_cat.ReadOnly = True
        Me.item_cat.Width = 72
        '
        'item_name
        '
        Me.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_name.DataPropertyName = "item_name"
        Me.item_name.HeaderText = "Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 58
        '
        'item_desc
        '
        Me.item_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.item_desc.DataPropertyName = "item_desc"
        Me.item_desc.HeaderText = "Description"
        Me.item_desc.Name = "item_desc"
        Me.item_desc.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "item_supplier"
        Me.Column2.HeaderText = "Supplier"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'item_oprice
        '
        Me.item_oprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_oprice.DataPropertyName = "item_oprice"
        Me.item_oprice.HeaderText = "Original Price "
        Me.item_oprice.Name = "item_oprice"
        Me.item_oprice.ReadOnly = True
        Me.item_oprice.Width = 87
        '
        'item_sprice
        '
        Me.item_sprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_sprice.DataPropertyName = "item_sprice"
        Me.item_sprice.HeaderText = "Selling Price"
        Me.item_sprice.Name = "item_sprice"
        Me.item_sprice.ReadOnly = True
        Me.item_sprice.Width = 81
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 69
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
        Me.cedit.Width = 17
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
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(778, 540)
        Me.Controls.Add(Me.groupBox1)
        Me.ForeColor = System.Drawing.Color.MistyRose
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents sort As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents Button4 As Button
    Friend WithEvents item_no As DataGridViewTextBoxColumn
    Friend WithEvents item_cat As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents item_desc As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents item_oprice As DataGridViewTextBoxColumn
    Friend WithEvents item_sprice As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents cedit As DataGridViewImageColumn
    Friend WithEvents crestock As DataGridViewImageColumn
End Class

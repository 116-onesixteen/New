<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.itemno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnref = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Button1.TabIndex = 102
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaShell
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.VBtry.My.Resources.Resources.add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(934, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 50)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "Add"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemno, Me.item_name, Me.Column2, Me.quantity, Me.cedit})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(22, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(995, 453)
        Me.DataGridView1.TabIndex = 105
        '
        'itemno
        '
        Me.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.itemno.DataPropertyName = "suppno"
        Me.itemno.HeaderText = "Supplier ID"
        Me.itemno.Name = "itemno"
        Me.itemno.ReadOnly = True
        Me.itemno.Width = 104
        '
        'item_name
        '
        Me.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.item_name.DataPropertyName = "supp_name"
        Me.item_name.HeaderText = "Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 72
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "supp_num"
        Me.Column2.HeaderText = "Contact Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 137
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.quantity.DataPropertyName = "supp_add"
        Me.quantity.HeaderText = "Address"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
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
        'btnref
        '
        Me.btnref.BackColor = System.Drawing.Color.SeaShell
        Me.btnref.ForeColor = System.Drawing.Color.Black
        Me.btnref.Image = Global.VBtry.My.Resources.Resources.update
        Me.btnref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnref.Location = New System.Drawing.Point(804, 70)
        Me.btnref.Name = "btnref"
        Me.btnref.Size = New System.Drawing.Size(107, 50)
        Me.btnref.TabIndex = 106
        Me.btnref.Text = "Referesh"
        Me.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnref.UseVisualStyleBackColor = False
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1054, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnref)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents itemno As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents cedit As DataGridViewImageColumn
    Private WithEvents btnref As Button
End Class

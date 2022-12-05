Imports MySql.Data.MySqlClient

Public Class Items

    Dim _id, _cat, _name, _desc, _supplier, _oprice, _sprice, _q
    Private cName As String


    'Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    '    Dim str As String = "Data source=localhost; userid = root; password = ; database = savannahvb;"
    '    Dim cn As New MySqlConnection(str)
    '    Dim comm As String = "select itemno item_cat item_name item_desc item_oprice item_sprice quantity"
    '    Dim cm As New MySqlCommand
    '    Dim dr As MySqlDataReader

    'End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim frm = Items_Addnew

        frm.btnsave.Enabled = True

        Items_Addnew.Show()

    End Sub

    Private Sub forgotpass_Click(sender As Object, e As EventArgs)
        Items_Addnew.Show()
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sort.SelectedIndexChanged







    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)
        Items_restock.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try

            reload("select * FROM tbl_items", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Public Sub LoadRecords()

    '    Dim i As Integer
    '    DataGridView1.Rows.Clear()

    '    strconn.Open()
    '    comm = New MySqlCommand("Select * FROM tbl_items order by item_cat, item_name, item_desc ", strconn)

    '    read = comm.ExecuteReader()

    '    While (read.Read)

    '        i += 1

    '        DataGridView1.Rows.Add(i, read.Item("item_cat").ToString(), read.Item("item_name").ToString(), read.Item("item_desc").ToString(), read.Item("item_supplier").ToString(), read.Item("item_oprice").ToString(), read.Item("item_sprice").ToString(), read.Item("quantity").ToString())

    '    End While

    '    read.Close()
    '    strconn.Close()

    'End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        _id = DataGridView1(2, i).Value.ToString()
        _cat = DataGridView1(3, i).Value.ToString()
        _name = DataGridView1(4, i).Value.ToString()
        _desc = DataGridView1(5, i).Value.ToString()
        _supplier = DataGridView1(6, i).Value.ToString()
        _oprice = DataGridView1(7, i).Value.ToString()
        _sprice = DataGridView1(8, i).Value.ToString()
        _q = DataGridView1(9, i).Value.ToString()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        cName = DataGridView1.Columns(e.ColumnIndex).Name

        If (cName = "cedit") Then

            Dim frm1 = Items_edit
            frm1.updateid.Enabled = False
            frm1.btnupdate.Enabled = True
            frm1.updateid.Text = _id
            frm1.itmcat.Text = _cat
            frm1.itmname.Text = _name
            frm1.itmdesc.Text = _desc
            frm1.combosupplier.Text = _supplier
            frm1.itmoprice.Text = _oprice
            frm1.itmsprice.Text = _sprice
            frm1.itmnum.Text = _q
            frm1.ShowDialog()

        ElseIf (cName = "crestock") Then
            Dim frm2 = Items_restock
            frm2.updateid.Enabled = False
            frm2.rescat.Enabled = False
            frm2.resname.Enabled = False
            frm2.resdesc.Enabled = False
            frm2.rescombosupplier.Enabled = False
            frm2.resoprice.Enabled = False
            frm2.ressprice.Enabled = False
            frm2.resnum.Enabled = True
            frm2.btnaddrestock.Enabled = True
            frm2.updateid.Text = _id
            frm2.rescat.Text = _cat
            frm2.resname.Text = _name
            frm2.resdesc.Text = _desc
            frm2.rescombosupplier.Text = _supplier
            frm2.resoprice.Text = _oprice
            frm2.ressprice.Text = _sprice
            frm2.resnum.Text = _q
            frm2.ShowDialog()


        End If
    End Sub



End Class
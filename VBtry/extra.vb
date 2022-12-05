Imports MySql.Data.MySqlClient

Public Class extra

    Dim _cusname, _cusnum, _address, _cat, _item, _unit, _desc, _quanti, _pstat, _mode, _date, _totalcost

    Private Sub Reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private cName As String

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)

        Dim frm = ReserveButton

        frm.rsvtotal.Enabled = False


        ReserveButton.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Try

            reload("select * FROM tbl_reserve", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        _cusname = DataGridView1(2, i).Value.ToString()
        _cusnum = DataGridView1(3, i).Value.ToString()
        _address = DataGridView1(4, i).Value.ToString()
        _cat = DataGridView1(6, i).Value.ToString()
        _item = DataGridView1(7, i).Value.ToString()
        _unit = DataGridView1(8, i).Value.ToString()
        _desc = DataGridView1(9, i).Value.ToString()
        _quanti = DataGridView1(10, i).Value.ToString()
        _pstat = DataGridView1(11, i).Value.ToString()
        _mode = DataGridView1(12, i).Value.ToString()
        _date = DataGridView1(13, i).Value.ToString()
        _totalcost = DataGridView1(14, i).Value.ToString()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        cName = DataGridView1.Columns(e.ColumnIndex).Name

        If (cName = "cedit") Then

            Dim frm1 = Reserve_Sales
            frm1.rsvsaletotal.Enabled = False
            frm1.btncomplete.Enabled = True
            'frm1.btnsave.Enabled = False
            frm1.rsvsalename.Text = _cusname
            frm1.rsvsaleadd.Text = _address
            'frm1.rsvcnum.Text = _cusnum
            'frm1.rsvcat.Text = _cat
            frm1.rsvsalecomboitems.Text = _item
            frm1.rsvsalecombounit.Text = _unit
            'frm1.rsvdesc.Text = _desc
            frm1.rsvsalenum.Text = _quanti
            'frm1.rsvcombostat.Text = _pstat
            frm1.rsvsalecombomode.Text = _mode
            frm1.rsvsaledate.Value = DateTime.Parse(_date)
            frm1.rsvsaletotal.Text = _totalcost
            frm1.ShowDialog()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        'Clicking row inside datagrid

        Dim click As DataGridViewRow
        Dim frm1 = Reserve_Sales

        click = DataGridView1.Rows(e.RowIndex)

        frm1.rsvsalename.Text = click.Cells(2).Value
        frm1.ShowDialog()

    End Sub
End Class
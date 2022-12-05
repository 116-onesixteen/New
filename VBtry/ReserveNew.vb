Imports MySql.Data.MySqlClient

Public Class ReserveNew

    Dim _name, _num, _add, _cat, _item, _unit, _desc, _sprice, _q, _stat, _mode, _date, _totalp

    Private Sub comboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged


        comboBox1.Text = "Value"

        If comboBox1.SelectedIndex = 0 Then

            opencon()

            cmd.Connection = con
            cmd.CommandText = "SELECT rsvadd FROM tbl_reservenew"
            cmd.Prepare()

            cmdreader = cmd.ExecuteReader

            While cmdreader.Read

                Try

                    Dim filter_list = read.GetString("rsvadd")
                    comboBox1.Items.Add(filter_list)

                Catch ex As System.InvalidCastException

                End Try

            End While

            cmdreader.Close()
            con.Close()

            'ElseIf comboBox1.SelectedIndex = 1 Then

            ' opencon()

            ' cmd.Connection = con
            'cmd.CommandText = "SELECT categories_name FROM categories"
            ' cmd.Prepare()

            ' cmdreader = cmd.ExecuteReader

            'While cmdreader.Read
            'Dim filter_list = cmdreader.GetString("categories_name")
            ' comboBox1.Items.Add(filter_list)
            ' End While

            ' cmdreader.Close()
            ' con.Close()
        End If

    End Sub

    Private cName As String

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        _name = DataGridView1(2, i).Value.ToString()
        _num = DataGridView1(3, i).Value.ToString()
        _add = DataGridView1(4, i).Value.ToString()
        _cat = DataGridView1(5, i).Value.ToString()
        _item = DataGridView1(6, i).Value.ToString()
        _unit = DataGridView1(7, i).Value.ToString()
        _desc = DataGridView1(8, i).Value.ToString()
        _sprice = DataGridView1(9, i).Value.ToString()
        _q = DataGridView1(10, i).Value.ToString()
        _stat = DataGridView1(11, i).Value.ToString()
        _date = DataGridView1(12, i).Value.ToString()
        _totalp = DataGridView1(13, i).Value.ToString()

    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    '    cName = DataGridView1.Columns(e.ColumnIndex).Name

    '    If (cName = "cdelete") Then

    '        Dim frm1 = ReserveButton

    '        frm1.btnsave.Enabled = False
    '        frm1.rsvtotal.Enabled = False
    '        frm1.rsvname.Text = _name
    '        frm1.rsvcnum.Text = _num
    '        frm1.rsvadd.Text = _add
    '        frm1.rsvcat.Text = _cat
    '        frm1.rsvcomboitems.Text = _item
    '        frm1.rsvcombounit.Text = _unit
    '        frm1.rsvdesc.Text = _desc
    '        frm1.rsvnum.Text = _sprice
    '        frm1.rsvprice.Text = _q
    '        frm1.rsvcombostat.Text = _stat
    '        frm1.rsvcombomode.Text = _mode
    '        frm1.rsvdate.Text = DateTime.Parse(_date)
    '        frm1.rsvtotal.Text = _totalp
    '        frm1.ShowDialog()

    '    End If

    'End Sub

    Private Sub addrsv_Click(sender As Object, e As EventArgs)

        Dim frm = ReserveButton

        frm.rsvtotal.Enabled = False
        frm.btnsave.Enabled = True


        ReserveButton.Show()

    End Sub

    'Public Sub LoadRecords()

    '    Dim i As Integer
    '    DataGridView1.Rows.Clear()

    '    strconn.Open()
    '    comm = New MySqlCommand("select * from tbl_reservenew order by rsvname, rsvcontact, rsvadd", strconn)
    '    read = comm.ExecuteReader()

    '    While (read.Read)

    '        i += 1

    '        DataGridView1.Rows.Add(i, read.Item("rsvname").ToString(), read.Item("rsvcontact").ToString(), read.Item("rsvadd").ToString(), read.Item("rsvcat").ToString(), read.Item("rsvitem").ToString(), read.Item("rsvunit").ToString(), read.Item("rsvdesc").ToString(), read.Item("rsvquantity").ToString(), read.Item("rsv_sprice").ToString(), read.Item("rsvstat").ToString(), read.Item("rsvmode").ToString(), read.Item("rsvdate").ToString(), read.Item("rsvtotal").ToString())

    '    End While

    '    read.Close()
    '    strconn.Close()

    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReserveNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addrsv_Click_1(sender As Object, e As EventArgs) Handles addrsv.Click

        Dim frm1 = ReserveButton

        frm1.Show()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Clicking row inside datagrid

        Dim click As DataGridViewRow
        Dim frm1 = Reserve_Sales
        Dim sdate = Reserve_Sales.rsvsaledate.Value.ToString("yyyy-MM-dd")

        click = DataGridView1.Rows(e.RowIndex)

        frm1.rsvsalename.Text = click.Cells(2).Value
        frm1.rsvsalenumber.Text = click.Cells(3).Value
        frm1.rsvsaleadd.Text = click.Cells(4).Value
        frm1.rsvsalecomboitems.Text = click.Cells(6).Value
        frm1.rsvsalecombounit.Text = click.Cells(7).Value
        frm1.rsvsalenum.Text = click.Cells(9).Value
        frm1.rsvsaleprice.Text = click.Cells(10).Value
        frm1.rsvsalecombomode.Text = click.Cells(12).Value
        sdate = click.Cells(13).Value
        frm1.rsvsaletotal.Text = click.Cells(14).Value
        frm1.ShowDialog()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            reload("select * FROM tbl_reservenew", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
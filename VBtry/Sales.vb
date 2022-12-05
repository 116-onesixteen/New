Imports MySql.Data.MySqlClient

Public Class Sales
    Private outname As Object

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Sales_Stockout.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


        Try

            reload("Select transaction_id, sales_date, sales_method, sales from tbl_sales", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        Dim i As Decimal
        Dim Sum As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum += DataGridView1.Rows(i).Cells(3).Value

        Next
        textBox1.Text = Sum


    End Sub

    Public Sub LoadRecords()

        Dim i As Integer
        DataGridView1.Rows.Clear()

        strconn.Open()
        comm = New MySqlCommand("Select * FROM tbl_sales order by sales_date, sales_method, sales ", strconn)
        read = comm.ExecuteReader()

        While (read.Read)

            i += 1

            DataGridView1.Rows.Add(i, read.Item("sales_date").ToString(), read.Item("sales_method").ToString(), read.Item("sales").ToString())

        End While

        read.Close()
        strconn.Close()

    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Clicking row inside datagrid and viewing data outside dataG

        strconn.Open()

        Dim data As DataGridViewRow
        Dim click As String
        Dim frmTransact = Transaction

        click = "select out_name, out_cnum, out_add, out_items, out_unit, out_num, out_sprice from tbl_sales"

        Dim cmd As New MySqlCommand(click, strconn)

        Dim myreader As MySqlDataReader

        data = DataGridView1.Rows(e.RowIndex)

        myreader = cmd.ExecuteReader


        myreader.Read()
        frmTransact.outname.Text = myreader("out_name")
        frmTransact.outadd.Text = myreader("out_cnum")
        frmTransact.TextBox1.Text = myreader("out_add")
        frmTransact.outcomboitem.Text = myreader("out_items")
        frmTransact.outcombounit.Text = myreader("out_unit")
        frmTransact.outnum.Text = myreader("out_num")
        frmTransact.outitemsprice.Text = myreader("out_sprice")

        frmTransact.ShowDialog()

        strconn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged









    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub btnref_Click(sender As Object, e As EventArgs) Handles btnref.Click

        Try

            reload("Select transaction_id, sales_date, sales_method, sales from tbl_sales", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
Imports MySql.Data.MySqlClient




Public Class Dash_availableflowers












    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ReserveButton.Show()
    End Sub

    Private Sub Dash_availableflowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    '    Try

    '        reload("Select itemno, item_name, item_desc,quantity from tbl_items where item_cat = 'Flowers'", dgv)

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message)
    '    End Try

    '    Dim i As Decimal
    '    Dim Sum As Decimal = 0
    '    For i = 0 To dgv.Rows.Count - 1
    '        Sum += dgv.Rows(i).Cells(3).Value

    '    Next
    '    Dashboard1.avaf.Text = Sum
    'End Sub

    Public Sub LoadRecords()

        Dim i As Integer
        dgv.Rows.Clear()

        strconn.Open()
        comm = New MySqlCommand("Select itemno, item_name, item_desc,quantity from tbl_items where item_cat = 'Flowers' ", strconn)
        read = comm.ExecuteReader()

        While (read.Read)

            i += 1

            dgv.Rows.Add(i, read.Item("itemno").ToString(), read.Item("item_desc").ToString(), read.Item("quantity").ToString())

        End While

        Dim z As Decimal
        Dim Sum As Decimal = 0
        For z = 0 To dgv.Rows.Count - 1
            Sum += dgv.Rows(z).Cells(3).Value

        Next
        Dashboard1.avaf.Text = Sum

        read.Close()
        strconn.Close()

    End Sub


End Class
Public Class Supplier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Supplier_Edit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Supplier_Edit.Show()
    End Sub

    Private Sub btnref_Click(sender As Object, e As EventArgs) Handles btnref.Click

        Try

            reload("select * FROM tbl_supplier", DataGridView1)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
Public Class Reserve_Sales
    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Public Sub Clear()

        rsvsalename.Clear()
        rsvsaleadd.Clear()
        rsvsalecomboitems.Text = ""
        rsvsalecombounit.Text = ""
        rsvsalenum.Clear()
        rsvsaletotal.Clear()
        rsvsalecombomode.Text = ""
        rsvsaledate.Value = DateTime.Now


    End Sub

    Private Sub btncomplete_Click(sender As Object, e As EventArgs) Handles btncomplete.Click

        Try

            If rsvsalename.Text = String.Empty Or rsvsaleadd.Text = String.Empty Or rsvsalecomboitems.Text = String.Empty Or rsvsalecombounit.Text = String.Empty Or rsvsalenum.Text = String.Empty Or rsvsalecombomode.Text = String.Empty Or rsvsaledate.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            create("Insert into tbl_sales(sales_date, sales_method, sales, out_name, out_cnum, out_add, out_items, out_unit, out_num, out_sprice) values ('" & Format(rsvsaledate.Value, "yyy-MM-dd") & "', '" & rsvsalecombomode.Text & "', '" & rsvsaletotal.Text & "', '" & rsvsalename.Text & "', '" & rsvsalenumber.Text & "', '" & rsvsaleadd.Text & "', '" & rsvsalecomboitems.Text & "', '" & rsvsalecombounit.Text & "', '" & rsvsalenum.Text & "', '" & rsvsaleprice.Text & "')")


            Clear()


        Catch ex As Exception

            MessageBox.Show("Is the transaction complete?", "Reservation Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End Try

        ReserveNew.Show()
        Me.Dispose()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
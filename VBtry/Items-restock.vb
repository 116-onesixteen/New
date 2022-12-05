Imports MySql.Data.MySqlClient

Public Class Items_restock
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnaddrestock.Click

        Try

            If rescat.Text = String.Empty Or resname.Text = String.Empty Or resdesc.Text = String.Empty Or rescombosupplier.Text = String.Empty Or resoprice.Text = String.Empty Or ressprice.Text = String.Empty Or resnum.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            'strconn.Open()
            'comm = New MySqlCommand("Update tbl_items set item_cat = '" & rescat.Text & "', item_name = '" & resname.Text & "', item_desc = '" & resdesc.Text & "', item_supplier = '" & rescombosupplier.Text & "', item_oprice = '" & resoprice.Text & "', item_sprice = '" & ressprice.Text & "', quantity = '" & resnum.Text & "'WHERE itemno='" & updateid.Text & "'")
            'comm.ExecuteNonQuery()

            'strconn.Close()
            'MessageBox.Show("Record has been successfully updated.", "item information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Clear()

            updates("UPDATE tbl_items SET item_cat = '" & rescat.Text & "', item_name = '" & resname.Text & "', item_desc = '" & resdesc.Text & "', item_supplier = '" & rescombosupplier.Text & "', item_oprice = '" & resoprice.Text & "', item_sprice = '" & ressprice.Text & "', quantity = '" & resnum.Text & "' WHERE itemno = '" & updateid.Text & "'")



        Catch ex As Exception

            'strconn.Close()
            MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

        Items.Show()
        Me.Dispose()

    End Sub

    Public Sub Clear()

        resnum.Clear()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Clear()

    End Sub

    Private Sub groupBox2_Enter(sender As Object, e As EventArgs) Handles groupBox2.Enter

    End Sub

    Private Sub resnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles resnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub
End Class
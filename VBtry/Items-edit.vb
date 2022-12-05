Public Class Items_edit
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()

    End Sub

    Private Sub Items_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub

    Public Sub Clear()

        itmcat.Text = ""
        itmname.Clear()
        itmdesc.Clear()
        combosupplier.Text = ""
        itmoprice.Clear()
        itmsprice.Clear()
        itmnum.Clear()
        btnupdate.Enabled = True

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnupdate.Click


        Try

            If itmcat.Text = String.Empty Or itmname.Text = String.Empty Or itmdesc.Text = String.Empty Or combosupplier.Text = String.Empty Or itmoprice.Text = String.Empty Or itmsprice.Text = String.Empty Or itmnum.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            updates("Update tbl_items set item_cat = '" & itmcat.Text & "', item_name = '" & itmname.Text & "', item_desc = '" & itmdesc.Text & "', item_supplier = '" & combosupplier.Text & "', item_oprice = '" & itmoprice.Text & "', item_sprice = '" & itmsprice.Text & "', quantity = '" & itmnum.Text & "'WHERE itemno='" & updateid.Text & "'")

            reload("select * FROM tbl_items", Items.DataGridView1)

        Catch ex As Exception

            MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

        Items.Show()
        Me.Dispose()


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combosupplier.SelectedIndexChanged

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        Clear()

    End Sub

    Private Sub groupBox2_Enter(sender As Object, e As EventArgs) Handles groupBox2.Enter

    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

        Dim str As String

        str = ("Select supp_name FROM tbl_supplier")

        Try
            readqueary(str)

            With read
                While .Read
                    combosupplier.Items.Add(.GetValue(0))

                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            MessageBox.Show("Are you sure you want to delete this item?", "Delete Form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            delete("DELETE FROM tbl_items WHERE itemno = '" & updateid.Text & "'")

            reload("select * FROM tbl_items", Items.DataGridView1)


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Items.Show()
        Me.Dispose()

    End Sub

    Private Sub itmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub itmdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmdesc.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub itmoprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmoprice.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub itmsprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmsprice.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub itmnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub
End Class
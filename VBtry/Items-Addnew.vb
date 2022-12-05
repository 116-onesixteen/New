Imports MySql.Data.MySqlClient


Public Class Items_Addnew

    Dim item_id As String

    Public Sub Clear()

        itmcat.Text = ""
        itmname.Clear()
        itmdesc.Clear()
        combosupplier.Text = ""
        itmoprice.Clear()
        itmsprice.Clear()
        itmnum.Clear()
        btnsave.Enabled = True


    End Sub

    Private Sub itemssupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combosupplier.SelectedIndexChanged

        opencon()

        cmd.Connection = con
        cmd.CommandText = "SELECT `suppno` FROM `tbl_supplier` WHERE `supp_name` = '" & combosupplier.Text & "'"
        cmd.Prepare()

        cmdreader = cmd.ExecuteReader

        While cmdreader.Read

            Try

                item_id = cmdreader.GetValue(0)

            Catch ex As System.InvalidCastException

            End Try

        End While

        cmdreader.Close()
        con.Close()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try

            strconnection_n()

            cmd.Connection = str_conn
            str_conn.Open()

            cmd.CommandText = "INSERT INTO `tbl_items`(`item_no`, `item_cat`, `item_name`, `item_desc`, `item_supplier`, `item_oprice`, `item_sprice`, `quantity`) VALUES ('DEFAULT','" & itmcat.Text & "','" & itmname.Text & "','" & itmdesc.Text & "','" & combosupplier.Text & "', '" & itmoprice.Text & "','" & itmsprice.Text & "','" & itmnum.Text & "')"
            cmd.ExecuteNonQuery()

            strconn.Close()

            MsgBox("ITEM ADDED", MsgBoxStyle.OkOnly, "Action Confirmation")


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Items.Show()
        Me.Dispose()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        Clear()

    End Sub



    Private Sub chuchu_Click(sender As Object, e As EventArgs)

        Try

            If itmcat.Text = String.Empty Or itmname.Text = String.Empty Or itmdesc.Text = String.Empty Or combosupplier.Text = String.Empty Or itmoprice.Text = String.Empty Or itmsprice.Text = String.Empty Or itmnum.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            updates("Update tbl_items set item_cat = '" & itmcat.Text & "', item_name = '" & itmname.Text & "', item_desc = '" & itmdesc.Text & "', item_supplier = '" & combosupplier.Text & "', item_oprice = '" & itmoprice.Text & "', item_sprice = '" & itmsprice.Text & "', quantity = '" & itmnum.Text & "'WHERE item_name='" & itmname.Text & "'")

            Clear()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Items.Show()
        Me.Dispose()

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

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()

    End Sub



    Private Sub groupBox2_Enter(sender As Object, e As EventArgs) Handles groupBox2.Enter

    End Sub

    Private Sub itmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmname.KeyPress
        'Error handling: Letters only

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
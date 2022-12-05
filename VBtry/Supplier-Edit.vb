Public Class Supplier_Edit
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()

    End Sub

    Public Sub Clear()

        suppname.Clear()
        suppnum.Clear()
        suppadd.Clear()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click

        Try

            If suppname.Text = String.Empty Or suppnum.Text = String.Empty Or suppadd.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            create("Insert into tbl_supplier(supp_name, supp_num, supp_add) values ('" & suppname.Text & "', '" & suppnum.Text & "', '" & suppadd.Text & "')")


            Clear()


        Catch ex As Exception

            MessageBox.Show("Record has been successfully saved.", "Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
    End Sub

    Private Sub suppname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles suppname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub suppnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles suppnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        If suppnum.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True

                MessageBox.Show("Phone number should not be more than 11 digits")

            End If
        End If

    End Sub
End Class
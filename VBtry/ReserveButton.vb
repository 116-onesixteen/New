Imports MySql.Data.MySqlClient

Public Class ReserveButton


    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub Clear()

        rsvname.Clear()
        rsvcnum.Clear()
        rsvadd.Clear()
        rsvcat.Text = ""
        rsvcomboitems.Text = ""
        rsvcombounit.Text = ""
        rsvdesc.Clear()
        rsvnum.Clear()
        rsvprice.Clear()
        rsvtotal.Clear()
        rsvcombostat.Text = ""
        rsvcombomode.Text = ""
        rsvdate.Value = DateTime.Now
        btnsave.Enabled = True


    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click

        childform(AddItem)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            Dim sdate = rsvdate.Value.ToString("yyyy-MM-dd")
            If rsvname.Text = String.Empty Or rsvcnum.Text = String.Empty Or rsvadd.Text = String.Empty Or rsvcat.Text = String.Empty Or rsvcomboitems.Text = String.Empty Or rsvcombounit.Text = String.Empty Or rsvdesc.Text = String.Empty Or rsvnum.Text = String.Empty Or rsvcombostat.Text = String.Empty Or rsvcombomode.Text = String.Empty Or rsvdate.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If
            create("Insert into tbl_reservenew(rsvname, rsvcontact, rsvadd, rsvcat, rsvitem, rsvunit, rsvdesc, rsvquantity,rsv_sprice, rsvstat, rsvmode, rsvdate, rsvtotal) values ('" & rsvname.Text & "', '" & rsvcnum.Text & "', '" & rsvadd.Text & "', '" & rsvcat.Text & "', '" & rsvcomboitems.Text & "', '" & rsvcombounit.Text & "', '" & rsvdesc.Text & "', '" & rsvnum.Text & "',  '" & rsvprice.Text & "','" & rsvcombostat.Text & "', '" & rsvcombomode.Text & "', '" & sdate & "', '" & rsvtotal.Text & "')")

            reload("select * FROM tbl_reservenew", ReserveNew.DataGridView1)

            'ReserveNew.LoadRecords()

            Clear()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        ReserveNew.Show()
        Me.Dispose()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint




    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

        Dim str As String

        str = ("Select item_name FROM tbl_items")

        Try
            readqueary(str)

            With read
                While .Read
                    rsvcomboitems.Items.Add(.GetValue(0))

                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    'Private Sub btncomplete_Click(sender As Object, e As EventArgs) Handles btncomplete.Click

    '    Try

    '        If rsvname.Text = String.Empty Or rsvcnum.Text = String.Empty Or rsvadd.Text = String.Empty Or rsvcat.Text = String.Empty Or rsvcomboitems.Text = String.Empty Or rsvcombounit.Text = String.Empty Or rsvdesc.Text = String.Empty Or rsvnum.Text = String.Empty Or rsvcombostat.Text = String.Empty Or rsvcombomode.Text = String.Empty Or rsvdate.Text = String.Empty Then

    '            MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Return

    '        End If

    '        create("Insert into tbl_sales(sales_date, sales_method , sales, customer_name, sales_add, sales_item_name, sales_unit, sales_quantity, sales_price) values ('" & Format(rsvdate.Value, "yyy-MM-dd") & "', '" & rsvcombomode.Text & "', '" & rsvtotal.Text & "', '" & rsvname.Text & "', '" & rsvadd.Text & "', '" & rsvcomboitems.Text & "', '" & rsvcombounit.Text & "', '" & rsvnum.Text & "')")


    '        Clear()


    '    Catch ex As Exception

    '        MessageBox.Show("Is the transaction complete?", "Reservation Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    End Try

    '    Reserve.Show()
    '    Me.Dispose()

    'End Sub

    Private Sub rsvadd_TextChanged(sender As Object, e As EventArgs) Handles rsvadd.TextChanged

    End Sub

    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

    End Sub

    Private Sub rsvcnum_TextChanged(sender As Object, e As EventArgs) Handles rsvcnum.TextChanged

    End Sub

    Private Sub rsvname_TextChanged(sender As Object, e As EventArgs) Handles rsvname.TextChanged

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Clear()

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub groupBox2_Enter(sender As Object, e As EventArgs) Handles groupBox2.Enter

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub rsvcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rsvcat.SelectedIndexChanged

    End Sub

    Private Sub label10_Click(sender As Object, e As EventArgs) Handles label10.Click

    End Sub

    Private Sub rsvnum_TextChanged(sender As Object, e As EventArgs) Handles rsvnum.TextChanged

    End Sub

    Private Sub rsvcombounit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rsvcombounit.SelectedIndexChanged

    End Sub

    Private Sub rsvcomboitems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rsvcomboitems.SelectedIndexChanged

    End Sub

    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub

    Private Sub rsvdesc_TextChanged(sender As Object, e As EventArgs) Handles rsvdesc.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub rsvcombomode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rsvcombomode.SelectedIndexChanged

    End Sub

    Private Sub rsvcombostat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rsvcombostat.SelectedIndexChanged

    End Sub

    Private Sub rsvdate_ValueChanged(sender As Object, e As EventArgs) Handles rsvdate.ValueChanged

    End Sub

    Private Sub rsvtotal_TextChanged(sender As Object, e As EventArgs) Handles rsvtotal.TextChanged

    End Sub

    Private Sub label12_Click(sender As Object, e As EventArgs) Handles label12.Click

    End Sub

    Private Sub label8_Click(sender As Object, e As EventArgs) Handles label8.Click

    End Sub

    Private Sub label11_Click(sender As Object, e As EventArgs) Handles label11.Click

    End Sub

    Private Sub label9_Click(sender As Object, e As EventArgs) Handles label9.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub ReserveButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rsvnum_KeyDown(sender As Object, e As KeyEventArgs) Handles rsvnum.KeyDown


        If e.KeyCode = Keys.Enter Then

            Dim a, b, c As Double

            a = rsvnum.Text
            b = rsvprice.Text
            rsvtotal.Text = c


            rsvtotal.Text = a * b

        End If





    End Sub

    Private Sub rsvprice_TextChanged(sender As Object, e As EventArgs) Handles rsvprice.TextChanged





    End Sub

    Private Sub rsvprice_KeyDown(sender As Object, e As KeyEventArgs) Handles rsvprice.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim a, b, c As Double

            a = rsvnum.Text
            b = rsvprice.Text
            rsvtotal.Text = c


            rsvtotal.Text = a * b

        End If












    End Sub

    Private Sub rsvname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rsvname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub rsvcnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rsvcnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub rsvdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rsvdesc.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub rsvnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rsvnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub rsvprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rsvprice.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub
End Class
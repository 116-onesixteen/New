Imports MySql.Data.MySqlClient

Public Class Sales_Stockout

    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub




    Private Sub button2_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        childform(AddItem)





    End Sub

    Private Sub button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click
        Close()

    End Sub

    Public Sub Clear()

        outname.Text = ""
        outcnum.Clear()
        outadd.Clear()
        outcomboitem.Text = ""
        outcombounit.Text = ""
        outnum.Clear()
        outcombomode.Text = ""
        outdate.Value = DateTime.Now
        outtotal.Clear()
        btnoutsave.Enabled = True


    End Sub



    Private Sub btnoutsave_Click(sender As Object, e As EventArgs) Handles btnoutsave.Click

        'Try
        '    Dim sdate = rsvdate.Value.ToString("yyyy-MM-dd")
        '    If rsvname.Text = String.Empty Or rsvcnum.Text = String.Empty Or rsvadd.Text = String.Empty Or rsvcat.Text = String.Empty Or rsvcomboitems.Text = String.Empty Or rsvcombounit.Text = String.Empty Or rsvdesc.Text = String.Empty Or rsvnum.Text = String.Empty Or rsvcombostat.Text = String.Empty Or rsvcombomode.Text = String.Empty Or rsvdate.Text = String.Empty Then

        '        MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Return

        '    End If
        '    create("Insert into tbl_reservenew(rsvname, rsvcontact, rsvadd, rsvcat, rsvitem, rsvunit, rsvdesc, rsvquantity,rsv_sprice, rsvstat, rsvmode, rsvdate, rsvtotal) values ('" & rsvname.Text & "', '" & rsvcnum.Text & "', '" & rsvadd.Text & "', '" & rsvcat.Text & "', '" & rsvcomboitems.Text & "', '" & rsvcombounit.Text & "', '" & rsvdesc.Text & "', '" & rsvnum.Text & "',  '" & rsvprice.Text & "','" & rsvcombostat.Text & "', '" & rsvcombomode.Text & "', '" & sdate & "', '" & rsvtotal.Text & "')")

        '    ReserveNew.LoadRecords()

        '    Clear()



        'Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        'End Try

        'ReserveNew.Show()
        'Me.Dispose()   


        Try
            Dim sdate = outdate.Value.ToString("yyyy-MM-dd")
            If outname.Text = String.Empty Or outcnum.Text = String.Empty Or outadd.Text = String.Empty Or outcomboitem.Text = String.Empty Or outcombounit.Text = String.Empty Or outnum.Text = String.Empty Or outcombomode.Text = String.Empty Or outdate.Text = String.Empty Then

                MessageBox.Show("Warning: Required empty field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            End If

            create("Insert into tbl_sales(sales_date, sales_method, sales, out_name, out_cnum, out_add, out_items, out_unit, out_num, out_sprice) values ('" & sdate & "', '" & outcombomode.Text & "', '" & outtotal.Text & "', '" & outname.Text & "', '" & outcnum.Text & "', '" & outadd.Text & "', '" & outcomboitem.Text & "', '" & outcombounit.Text & "', '" & outnum.Text & "', '" & outprice.Text & "')")


            Clear()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


        Me.Dispose()

    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

        Dim str As String
        Dim num1 As Integer = 0
        Dim count As Integer = 0








        str = ("Select item_name FROM tbl_items")

        Try
            readqueary(str)

            With read
                While .Read
                    outcomboitem.Items.Add(.GetValue(0))

                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try




















        ' For outnum.Text.Value() = num1




        'Dim i As Decimal
        ' Dim Sum As Decimal = 0
        'For i = 0 To DataGridView1.Rows.Count - 1
        'm += DataGridView1.Rows(i).Cells(3).Value

        ' Next
        ' outtotal.Text = Sum









    End Sub

    Private Sub outcombostat_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sales_Stockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub outtotal_TextChanged(sender As Object, e As EventArgs) Handles outtotal.TextChanged









    End Sub

    Private Sub outnum_TextChanged(sender As Object, e As EventArgs) Handles outnum.TextChanged

    End Sub

    Private Sub btnoutreset_Click(sender As Object, e As EventArgs) Handles btnoutreset.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub outname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles outname.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept LETTER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub outcnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles outcnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub outnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles outnum.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub outprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles outprice.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

            MessageBox.Show("This field will only accept NUMBER/S", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub outprice_TextChanged(sender As Object, e As EventArgs) Handles outprice.TextChanged

    End Sub

    'Private Sub outnum_KeyDown(sender As Object, e As KeyEventArgs) Handles outnum.KeyDown





    '    'Try search (

    '    'Catch ex As Exception

    '    'End Try



    '    'strconn.Open()
    '    'comm = New MySqlCommand("Select itemno, item_name, item_desc,quantity from tbl_items where item_cat = 'Gifts' ", strconn)


    '    'Dim z As Integer
    '    'Dim i As Integer
    '    'Dim a As Double




    '    'For outcomboitem.ComboBox.Text = 0 To Items.DataGridView1.Rows.Count - 1
    '    '    i += Items.DataGridView1.Rows(z).Cells(6).Value

    '    '    a = outnum.Text



    '    'Next
    '    'outtotal.Text = a * i

    '    'read.Close()
    '    'strconn.Close()



    'End Sub
End Class
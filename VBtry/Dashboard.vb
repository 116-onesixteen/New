Public Class Dashboard

    Sub childform(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub



    Private Sub dashboardbutton_MouseClick(sender As Object, e As MouseEventArgs) Handles dashboardbutton.MouseClick
        childform(Dashboard1)

    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles dashboardbutton.MouseHover
        dashboardbutton.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles dashboardbutton.MouseLeave

        dashboardbutton.BackColor = Color.Pink


    End Sub

    Private Sub itemsbutton_MouseHover(sender As Object, e As EventArgs) Handles itemsbutton.MouseHover
        itemsbutton.BackColor = Color.PaleVioletRed
    End Sub

    Private Sub itemsbutton_MouseLeave(sender As Object, e As EventArgs) Handles itemsbutton.MouseLeave
        itemsbutton.BackColor = Color.Pink
    End Sub

    Private Sub reservebutton_MouseHover(sender As Object, e As EventArgs) Handles reservebutton.MouseHover
        reservebutton.BackColor = Color.PaleVioletRed


    End Sub

    Private Sub reservebutton_MouseLeave(sender As Object, e As EventArgs) Handles reservebutton.MouseLeave

        reservebutton.BackColor = Color.Pink


    End Sub

    Private Sub salesbutton_MouseHover(sender As Object, e As EventArgs) Handles salesbutton.MouseHover
        salesbutton.BackColor = Color.PaleVioletRed


    End Sub

    Private Sub salesbutton_MouseLeave(sender As Object, e As EventArgs) Handles salesbutton.MouseLeave
        salesbutton.BackColor = Color.Pink



    End Sub

    Private Sub itemsbutton_MouseClick(sender As Object, e As MouseEventArgs) Handles itemsbutton.MouseClick

        childform(Items)

    End Sub

    Private Sub reservebutton_MouseClick(sender As Object, e As MouseEventArgs) Handles reservebutton.MouseClick
        childform(ReserveNew)

        'ReserveNew.LoadRecords()

    End Sub

    Private Sub salesbutton_MouseClick(sender As Object, e As MouseEventArgs) Handles salesbutton.MouseClick
        childform(Sales)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub salesbutton_Click(sender As Object, e As EventArgs) Handles salesbutton.Click

        Sales.LoadRecords()

    End Sub

    Private Sub reservebutton_Click(sender As Object, e As EventArgs) Handles reservebutton.Click

        'ReserveNew.LoadRecords()

        reload("select * FROM tbl_reservenew", ReserveNew.DataGridView1)

    End Sub

    Private Sub dashboardbutton_Click(sender As Object, e As EventArgs) Handles dashboardbutton.Click

        Dash_availableflowers.LoadRecords()

        Dash_availablegifts.LoadRecords()


    End Sub

    Private Sub itemsbutton_Click(sender As Object, e As EventArgs) Handles itemsbutton.Click

        'Items.LoadRecords()

        reload("select * FROM tbl_items", Items.DataGridView1)

    End Sub
End Class
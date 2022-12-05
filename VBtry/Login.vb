Public Class Login
    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        'Commonet
        Try

            'create("INSERT INTO tbl_login(log_name, log_pass) VALUES ('" & usernametxt.Text & "', '" & passwordtxt.Text & "')")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Dashboard.Show()

    End Sub

    Private Sub loginbutton_Click_1(sender As Object, e As EventArgs) Handles loginbutton.Click



    End Sub

    Private Sub loginbutton_Click_2(sender As Object, e As EventArgs) Handles loginbutton.Click


    End Sub

    Private Sub loginbutton_Click_3(sender As Object, e As EventArgs) Handles loginbutton.Click

    End Sub

    Private Sub forgotpass_Click(sender As Object, e As EventArgs) Handles forgotpass.Click
        Loginn.Show()

    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            passwordtxt.UseSystemPasswordChar = True
        Else
            passwordtxt.UseSystemPasswordChar = False
        End If





    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class

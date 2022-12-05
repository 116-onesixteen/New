''Imports System
''Imports System.Collections.Generic
''Imports System.ComponentModel
''Imports System.Data
''Imports System.Drawing
'Imports System.Linq
'Imports System.Text
'Imports System.Threading.Tasks
'Imports MySql.Data.MySqlClient
'Imports System.Windows.Forms

Public Class Dashboard1







    '    Partial Public Class Form1
    '        Inherits Form
    '        Dim cn As MySqlConnection
    '        Dim cm As MySqlCommand

    '        Public void New()

    '            InitializeComponent()
    '            Connection()
    '            Dashboard()


    '        Public void Connection()

    '            strconn = New MySqlConnection()
    '            strconn.ConnectionString = "server=localhost;user id=root;password=;database=rentaldb"


    '        Public Double GetTotal(String sql)

    '            Dim _total As Double = 0
    '        Try
    '                strconn.Open()
    '                comm = New MySqlCommand(sql, strconn)
    '                _total = Double.Parse(cm.ExecuteScalar().ToString())
    '                strconn.Close()

    'Catch ex As Exception
    '                cn.Close()
    '                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End Try
    '        Return _total
    '        }

    '        Public void Dashboard()
    '        {
    '            lblDaily.Text = GetTotal("select ifnull(sum(cash),0) from tblpayment where sdate = curdate()").ToString("#,##0.00")
    '            lblWeekly.Text = GetTotal("select ifnull(sum(cash),0) from tblpayment where week(sdate) = week(now())").ToString("#,##0.00")
    '            lblMonthly.Text = GetTotal("select ifnull(sum(cash),0) from tblpayment where month(sdate) = month(now())").ToString("#,##0.00")
    '            lblYearly.Text = GetTotal("select ifnull(sum(cash),0) from tblpayment where year(sdate) = year(now())").ToString("#,##0.00")
    '        }

    '    End Class
    'End Namespace






























    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click



















    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dash_availableflowers.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dash_availablegifts.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dash_lowstock.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Dash_topselling.Show()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Dash_topselling.Show()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Dash_topselling.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dash_sales.Show()
    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub label10_Click(sender As Object, e As EventArgs) Handles label10.Click

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click











    End Sub
End Class
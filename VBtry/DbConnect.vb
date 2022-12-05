Imports MySql.Data.MySqlClient

Module DbConnect

    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server = localhost;userid = root; password = ; database = savannahsis; convert zero datetime = true")
    End Function

    Public strconn As MySqlConnection = strconnection()
    Public conn As New MySqlConnection

    Public result As String
    Public comm As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Public read As MySqlDataReader

    Public proj_server = "'localhost'"
    Public proj_id = "'root'"
    Public proj_pass = "''"
    Dim proj_name = "'savannahsis'"

    Public strcon As String = "server = " & proj_server & ";uid = " & proj_id & ";password = " & proj_pass & ";database = " & proj_name & ""

    Public Sub readqueary(ByVal sql As String)

        Try

            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString() = strcon
                .Open()
            End With

            With comm
                .Connection = conn
                .CommandText = sql
                read = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Sub create(ByVal sql As String)
        Try
            strconn.Open()
            With comm
                .Connection = strconn
                .CommandText = sql
                result = comm.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Unsuccessful. Data not saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Successful. Data has been saved.", "GREAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            strconn.Close()

        End Try

    End Sub

    Public Sub reload(ByVal sql As String, ByVal dataglist As Object)

        Try
            datatable = New DataTable

            strconn.Open()

            With comm
                .Connection = strconn
                .CommandText = sql
            End With

            adapter.SelectCommand = comm
            adapter.Fill(datatable)
            dataglist.datasource = datatable
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            strconn.Close()
            adapter.Dispose()

        End Try


    End Sub

    Public Sub updates(ByVal sql As String)

        Try

            strconn.Open()
            With comm
                .Connection = strconn
                .CommandText = sql

                result = comm.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Unsuccessful. Data not update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Successful. Data has been updated.", "GREAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            strconn.Close()

        End Try
    End Sub

    Public Sub delete(ByVal sql As String)

        Try

            strconn.Open()
            With comm
                .Connection = strconn
                .CommandText = sql

                result = comm.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Unsuccessful. Data not delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Successful. Data has been deleted.", "GREAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            strconn.Close()

        End Try
    End Sub

    Public Sub search(ByVal sql As String)
        Try
            strconn.Open()
            With comm
                .Connection = strconn
                .CommandText = sql
                result = comm.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Unsuccessful. Missing Data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Successful. Please Wait.", "GREAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            strconn.Close()

        End Try

    End Sub

End Module

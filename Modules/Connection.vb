Imports MySql.Data.MySqlClient

Module Connection
    Public Connect As MySqlConnection
    Public DataReader As MySqlDataReader
    Public DataAdapter As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet

    Public Sub openConnection()
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=db_siswa"

        Try
            Connect = New MySqlConnection(myConnectionString)
            Connect.Open()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub closeConnection()
        If Connect IsNot Nothing Then
            Try
                Connect.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Module

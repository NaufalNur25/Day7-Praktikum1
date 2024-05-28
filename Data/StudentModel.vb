Imports MySql.Data.MySqlClient

Public Class StudentModel
    Public Function show() As List(Of StudentInterface)
        Dim students As New List(Of StudentInterface)
        Try
            Connection.openConnection()
            Dim query As String = "SELECT * FROM siswa"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim student As New Student With {
                        .Id = Convert.ToInt32(reader("id")),
                        .Nim = reader("nim").ToString(),
                        .Major = reader("major").ToString(),
                        .Name = reader("name").ToString(),
                        .Gender = reader("gender").ToString(),
                        .PhoneNumber = reader("phone_number").ToString(),
                        .Address = reader("address").ToString()
                    }
                        students.Add(student)
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            ' todo
            Throw
        Finally
            Connection.closeConnection()
        End Try
        Return students
    End Function

    Public Function create(student As StudentInterface) As Integer
        Dim rowsAffected As Integer
        Try
            Connection.openConnection()
            Dim query As String = "INSERT INTO SISWA (nim, name, major, gender, phone_number, address) VALUES (@nim, @name, @major, @gender, @phone_number, @address)"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@nim", student.Nim)
                cmd.Parameters.AddWithValue("@name", student.Name)
                cmd.Parameters.AddWithValue("@major", student.Major)
                cmd.Parameters.AddWithValue("@gender", student.Gender)
                cmd.Parameters.AddWithValue("@phone_number", student.PhoneNumber)
                cmd.Parameters.AddWithValue("@address", student.Address)
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Adding Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rowsAffected = -1
        Finally
            Connection.closeConnection()
        End Try
        Return rowsAffected
    End Function

    Public Function update(id As Integer, student As StudentInterface) As Integer
        Dim rowsAffected As Integer
        Try
            Connection.openConnection()
            Dim query As String = "UPDATE siswa SET nim = @nim, name = @name, major = @major, gender = @gender, phone_number = @phone_number, address = @address WHERE id = @id"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nim", student.Nim)
                cmd.Parameters.AddWithValue("@name", student.Name)
                cmd.Parameters.AddWithValue("@major", student.Major)
                cmd.Parameters.AddWithValue("@gender", student.Gender)
                cmd.Parameters.AddWithValue("@phone_number", student.PhoneNumber)
                cmd.Parameters.AddWithValue("@address", student.Address)
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Updated Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rowsAffected = -1
        Finally
            Connection.closeConnection()
        End Try
        Return rowsAffected
    End Function

    Public Function delete(id As Integer) As Integer
        Dim rowsAffected As Integer
        Try
            Connection.openConnection()
            Dim query As String = "DELETE FROM siswa WHERE id = @id"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@id", id)
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rowsAffected = -1
        Finally
            Connection.closeConnection()
        End Try
        Return rowsAffected
    End Function

    Public Function studentExists(nim As String) As Boolean
        Dim exists As Boolean = False
        Try
            Connection.openConnection()
            Dim query As String = "SELECT COUNT(*) FROM SISWA WHERE nim = @nim"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@nim", nim)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Convert.ToInt32(result) > 0 Then
                    exists = True
                End If
            End Using
        Catch ex As MySqlException
            ' Handle exception
            Throw
        Finally
            Connection.closeConnection()
        End Try
        Return exists
    End Function
End Class

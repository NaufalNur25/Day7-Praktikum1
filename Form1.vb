Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private previousTxtNimText As String = String.Empty

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf siswaGrid

        ' InputChecked
        AddHandler TxtNim.KeyPress, AddressOf specialNimInput
        AddHandler TxtNim.TextChanged, AddressOf SpecialFormEvent

        ' Button
        AddHandler BtAdd.MouseClick, AddressOf addStudent
        AddHandler btUpdate.MouseClick, AddressOf updateStudent
        AddHandler btDelete.MouseClick, AddressOf deleteStudent
        AddHandler BtCancel.MouseClick, AddressOf cancel

        ' Grid utils
        AddHandler DataGridSiswa.SelectionChanged, AddressOf selectedGrid
    End Sub

    Private Sub siswaGrid()
        Dim model As New StudentModel()
        Dim students As List(Of StudentInterface) = model.show()

        Dim dt As New DataTable()
        dt.Columns.Add("Id")
        dt.Columns.Add("NIM")
        dt.Columns.Add("Name")
        dt.Columns.Add("Major")
        dt.Columns.Add("Gender")
        dt.Columns.Add("Phone Number")
        dt.Columns.Add("Address")

        For Each student As StudentInterface In students
            dt.Rows.Add(student.Id, student.Nim, student.Name, student.Major, student.Gender, student.PhoneNumber, student.Address)
        Next

        DataGridSiswa.DataSource = dt
        DataGridSiswa.Columns("Id").Visible = False
    End Sub

    Private Sub addStudent()
        If Not allInputChecked() Then
            Return
        End If

        Dim student As New Student With {
            .Nim = TxtNim.Text,
            .Name = txtName.Text,
            .Major = txtMajor.Text,
            .Gender = cbGender.Text,
            .PhoneNumber = If(String.IsNullOrWhiteSpace(txtNomorTelepon.Text), "-", txtNomorTelepon.Text),
            .Address = If(String.IsNullOrWhiteSpace(txtAddress.Text), "-", txtAddress.Text)
        }

        Dim model As New StudentModel()
        Dim rowsInserted As Integer = model.create(student)

        If rowsInserted > 0 Then
            MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshGrid()
            clearForm()
            enableForm(False)
            RuleOfButtons("disable")
        End If

        Return
    End Sub

    Private Sub updateStudent()
        If Not allInputChecked() Then
            Exit Sub
        End If

        Dim Id As Integer = Convert.ToInt32(DataGridSiswa.SelectedRows(0).Cells("Id").Value)
        Dim student As New Student With {
        .Id = Id,
        .Nim = TxtNim.Text,
        .Name = txtName.Text,
        .Major = txtMajor.Text,
        .Gender = cbGender.SelectedItem.ToString(),
        .PhoneNumber = If(String.IsNullOrWhiteSpace(txtNomorTelepon.Text), "-", txtNomorTelepon.Text),
        .Address = If(String.IsNullOrWhiteSpace(txtAddress.Text), "-", txtAddress.Text)
    }

        Dim model As New StudentModel()
        Dim result As Integer = model.update(student.Id, student)

        If result > 0 Then
            MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshGrid()
            clearForm()
            enableForm(False)
            RuleOfButtons("disable")
        End If

        Return
    End Sub

    Private Sub deleteStudent()
        Dim id As Integer = DataGridSiswa.SelectedRows(0).Cells("Id").Value
        Dim name As String = DataGridSiswa.SelectedRows(0).Cells("Name").Value.ToString()

        Dim confirmMessage As String = String.Format("Are you sure you want to delete {0}?", name)
        Dim dialogResult As DialogResult = MessageBox.Show(confirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dialogResult = DialogResult.Yes Then
            Dim model As New StudentModel()
            Dim result As Integer = model.delete(id)
            If result > 0 Then
                MessageBox.Show("Student has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshGrid()
                clearForm()
                enableForm(False)
                RuleOfButtons("disable")
            End If
        End If
    End Sub

    Private Sub selectedGrid(sender As Object, e As EventArgs)
        If DataGridSiswa.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridSiswa.SelectedRows(0)

            Dim selectedStudent As New Student()
            selectedStudent.Nim = selectedRow.Cells("NIM").Value.ToString()
            selectedStudent.Name = selectedRow.Cells("Name").Value.ToString()
            selectedStudent.Major = selectedRow.Cells("Major").Value.ToString()
            selectedStudent.Gender = selectedRow.Cells("Gender").Value.ToString()
            selectedStudent.PhoneNumber = selectedRow.Cells("Phone Number").Value.ToString()
            selectedStudent.Address = selectedRow.Cells("Address").Value.ToString()

            RuleOfButtons("update")
            PopulateInputForm(selectedStudent)
        End If
    End Sub

    Private Sub specialFormEvent(sender As Object, e As EventArgs)
        If previousTxtNimText.Length = 1 AndAlso TxtNim.Text.Length = 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the last character? This will clear all input fields.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                clearForm()
                enableForm(False)
                RuleOfButtons("disable")
                Return
            Else
                TxtNim.Text = previousTxtNimText
                TxtNim.SelectionStart = TxtNim.Text.Length
            End If
        End If

        If Not String.IsNullOrWhiteSpace(TxtNim.Text) Then
            ' Memeriksa apakah Nim sudah ada sebelumnya (untuk kasus update)
            If Not isNimExist(TxtNim.Text) Then
                RuleOfButtons("add")
            Else
                RuleOfButtons("update")
            End If
        End If

        enableForm()
        previousTxtNimText = TxtNim.Text
    End Sub

    Private Sub specialNimInput(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function allInputChecked() As Boolean
        Dim checkIsValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            ShowWarningMessage("Name cannot be empty.")
            txtName.Focus()
            checkIsValid = False
        End If

        If String.IsNullOrWhiteSpace(txtMajor.Text) Then
            ShowWarningMessage("Major cannot be empty.")
            txtMajor.Focus()
            checkIsValid = False
        End If

        If String.IsNullOrWhiteSpace(cbGender.Text) Then
            ShowWarningMessage("Gender cannot be empty.")
            cbGender.Focus()
            checkIsValid = False
        End If

        Return checkIsValid
    End Function

    Private Sub refreshGrid()
        Call siswaGrid()
    End Sub

    Private Sub cancel(sender As Object, e As MouseEventArgs)
        clearForm()
        refreshGrid()
        enableForm(False)
        RuleOfButtons("disable")
    End Sub

    Private Sub RuleOfButtons(ruleType As String)
        Select Case ruleType
            Case "add"
                BtAdd.Enabled = True
                btUpdate.Enabled = False
                btDelete.Enabled = False
                BtCancel.Enabled = True
            Case "update"
                BtAdd.Enabled = True
                btUpdate.Enabled = True
                btDelete.Enabled = True
                BtCancel.Enabled = True
            Case Else
                BtAdd.Enabled = False
                btUpdate.Enabled = False
                btDelete.Enabled = False
                BtCancel.Enabled = False
        End Select
    End Sub

    Private Sub enableForm(Optional isEnable As Boolean = True)
        TxtNim.Enabled = True
        txtName.Enabled = isEnable
        txtMajor.Enabled = isEnable
        txtAddress.Enabled = isEnable
        txtNomorTelepon.Enabled = isEnable
        cbGender.Enabled = isEnable
    End Sub

    Private Sub ShowWarningMessage(text As String)
        MessageBox.Show(text, "Attation!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub PopulateInputForm(student As StudentInterface)
        TxtNim.Text = student.Nim
        txtName.Text = student.Name
        txtMajor.Text = student.Major
        txtAddress.Text = student.Address
        txtNomorTelepon.Text = student.PhoneNumber

        For i As Integer = 0 To cbGender.Items.Count - 1
            If cbGender.Items(i).ToString() = student.Gender Then
                cbGender.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub clearForm(Optional execute As Boolean = True)
        If Not execute Then
            Return
        End If

        TxtNim.Text = String.Empty
        txtName.Text = String.Empty
        txtMajor.Text = String.Empty
        txtAddress.Text = String.Empty
        txtNomorTelepon.Text = String.Empty
        cbGender.Text = String.Empty
        cbGender.SelectedIndex = -1
    End Sub

    Private Function isNimExist(nim As String) As Boolean
        Dim model As New StudentModel()
        Return model.studentExists(nim)
    End Function
End Class

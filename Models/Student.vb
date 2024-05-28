Public Class Student
    Implements StudentInterface

    Public Property Id As Integer Implements StudentInterface.Id
    Public Property Nim As String Implements StudentInterface.Nim
    Public Property Major As String Implements StudentInterface.Major
    Public Property Name As String Implements StudentInterface.Name
    Public Property Gender As String Implements StudentInterface.Gender
    Public Property PhoneNumber As String Implements StudentInterface.PhoneNumber
    Public Property Address As String Implements StudentInterface.Address
End Class
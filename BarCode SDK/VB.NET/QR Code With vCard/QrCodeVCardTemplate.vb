'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Public Class QrCodeVCardTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal FirstName As String, ByVal LastName As String, ByVal Phone As String, ByVal Fax As String, ByVal Email As String, ByVal Company As String, ByVal Job As String, ByVal Street As String, ByVal City As String, ByVal State As String, ByVal ZipCode As String, ByVal Country As String)
        Me.FirstName = FirstName
        Me.LastName = LastName
        Me.Phone = Phone
        Me.Fax = Fax
        Me.Email = Email
        Me.Company = Company
        Me.Job = Job
        Me.State = State
        Me.City = City
        Me.Street = Street
        Me.Country = Country
        Me.ZipCode = ZipCode
    End Sub

#End Region


#Region "Properties"

    Public Property FirstName As String
    Public Property LastName As String

    Public Property Phone As String
    Public Property Fax As String
    Public Property Email As String

    Public Property Company As String
    Public Property Job As String

    Public Property Street As String
    Public Property City As String
    Public Property State As String
    Public Property Country As String
    Public Property ZipCode As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(FirstName) AndAlso String.IsNullOrEmpty(LastName) Then Return MyBase.ToString()

        Return $"BEGIN:VCARD
VERSION:2.1
N:{LastName};{FirstName};;
FN:{FirstName} {LastName}
ORG:{Company}
TITLE:{Job}
TEL;WORK;VOICE:{Phone}
TEL;FAX;VOICE:{Fax}
ADR;WORK;PREF:;;{Street};{City};{State};{ZipCode};{Country}
LABEL;WORK;PREF;ENCODING=QUOTED-PRINTABLE;CHARSET=UTF-8
EMAIL:{Email}
END:VCARD
"

    End Function

#End Region


End Class

'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Public Class QrCodeEmailTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal Email As String, ByVal Subject As String, ByVal Message As String)
        Me.Email = Email
        Me.Subject = Subject
        Me.Message = Message
    End Sub

#End Region


#Region "Properties"

    Public Property Email As String
    Public Property Subject As String
    Public Property Message As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(Email) AndAlso String.IsNullOrEmpty(Subject) AndAlso String.IsNullOrEmpty(Message) Then Return MyBase.ToString()

        Return $"MATMSG:TO:

{Email};

SUB:

{Subject}

BODY:

{Message}
;;"

    End Function

#End Region


End Class

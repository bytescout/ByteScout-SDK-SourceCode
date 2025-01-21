'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Public Class QrCodeSmsTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal Number As String, ByVal Message As String)
        Me.Number = Number
        Me.Message = Message
    End Sub

#End Region


#Region "Properties"

    Public Property Number As String
    Public Property Message As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(Number) AndAlso String.IsNullOrEmpty(Message) Then Return MyBase.ToString()

        Return $"smsto:{Number}:{Message}"

    End Function

#End Region


End Class

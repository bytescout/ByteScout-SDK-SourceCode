'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Public Class QrCodeUrlTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal Url As String)
        Me.Url = Url
    End Sub

#End Region


#Region "Properties"

    Public Property Url As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(Url) Then Return MyBase.ToString()

        Return Url

    End Function

#End Region


End Class

'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Generic

Public Class SettingsVM

    Public MainFolderName As String

    Public Settings As List(Of Settings)

End Class

Public Class Settings

    Public category As String
    Public regex As String

End Class
